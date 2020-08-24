using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Configuration;
using System.Globalization;

namespace Visual_TraceRoute
{
	public partial class VisualTraceRouteForm : Form
	{
		private GMapOverlay markers = new GMapOverlay("markers");
		private GMapOverlay routes = new GMapOverlay("routes");
		private Thread thread;
		public static bool isStopExecution = false;

		public VisualTraceRouteForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			gMapControl.ShowCenter = false;
			gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
			GMaps.Instance.Mode = AccessMode.ServerOnly;
			gMapControl.Position = new PointLatLng(25, 0);
		}
		private void AddMapMarker(string coordinates, int markerNumber)
		{
			string[] latlong = coordinates.Split(',');
			double latitude = Convert.ToDouble(latlong[0], CultureInfo.InvariantCulture);
			double longitude = Convert.ToDouble(latlong[1], CultureInfo.InvariantCulture);
			GMapMarker marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.blue_small);
			marker.ToolTipText = markerNumber.ToString();
			marker.ToolTip.Fill = Brushes.Black;
			marker.ToolTip.Foreground = Brushes.White;
			marker.ToolTip.Stroke = Pens.Black;
			marker.ToolTip.TextPadding = new Size(20, 20);
			markers.Markers.Add(marker);
			gMapControl.Overlays.Add(markers);
			gMapControl.Zoom = 2;
			gMapControl.Position = new PointLatLng(25, 0);
		}

		private void CreateRouteBetweenMarkers(string previousCoordinates, string newCoordinates)
		{
			string[] previousLatLong = previousCoordinates.Split(',');
			string[] newLatLong = newCoordinates.Split(',');
			double previousLatitude = Convert.ToDouble(previousLatLong[0], CultureInfo.InvariantCulture);
			double previousLongitude = Convert.ToDouble(previousLatLong[1], CultureInfo.InvariantCulture);
			double newLatitude = Convert.ToDouble(newLatLong[0], CultureInfo.InvariantCulture);
			double newLongitude = Convert.ToDouble(newLatLong[1], CultureInfo.InvariantCulture);
			List<PointLatLng> points = new List<PointLatLng>();
			points.Add(new PointLatLng(previousLatitude, previousLongitude));
			points.Add(new PointLatLng(newLatitude, newLongitude));
			GMapRoute route = new GMapRoute(points, "Route between markers");
			route.Stroke = new Pen(Color.Red, 3);
			routes.Routes.Add(route);
			gMapControl.Overlays.Add(routes);
		}

		public void RunTraceRouteThread()
		{
			string ipinfo_token = ConfigurationManager.AppSettings["ipinfo_token"];
			int timeout = Convert.ToInt32(timeoutNumericUpDown.Value);
			int maxTTL = Convert.ToInt32(maxHopsNumericUpDown.Value);
			string responseTime;
			WebClient client = new WebClient();
			client.Encoding = Encoding.UTF8;
			IEnumerable<IPAddress> iptable = NetworkingTools.GetTraceRoute(domainTextBox.Text, timeout, maxTTL);
			int increment = (int)Math.Ceiling((double)100 / (double)iptable.Count());
			string oldCoordinates = "";
			for (int i = 1; i <= iptable.Count(); i++)
			{
				if (!isStopExecution)
					try
					{
						if (iptable.ElementAt(i) != null)
						{
							string ip;

							if (i == 1)
							{
								ip = NetworkingTools.FindDefaultGateway(timeout).ToString();
								ThreadHelper.SetDataGridViewAddNewRow(this, dataGridView, i.ToString(), "*", ip, "", "", "", "");
							}
							else
							{
								ip = iptable.ElementAt(i).ToString();

								string org = client.DownloadString("https://ipinfo.io/" + ip + "/org?token=" + ipinfo_token);

								if (org == "\n")
									org = "(None)";

								string city = client.DownloadString("https://ipinfo.io/" + ip + "/city?token=" + ipinfo_token);
								string country = client.DownloadString("https://ipinfo.io/" + ip + "/country?token=" + ipinfo_token);
								string newCoordinates = client.DownloadString("https://ipinfo.io/" + ip + "/loc?token=" + ipinfo_token);

								responseTime = NetworkingTools.GetPingResponseTime(IPAddress.Parse(ip), timeout);

								ThreadHelper.SetDataGridViewAddNewRow(this, dataGridView, i.ToString(), responseTime, ip, org, city, country, newCoordinates);

								if (oldCoordinates != "")
									CreateRouteBetweenMarkers(oldCoordinates, newCoordinates);

								oldCoordinates = newCoordinates;
								AddMapMarker(newCoordinates, i);
							}
						}
						else
							ThreadHelper.SetDataGridViewAddNewRow(this, dataGridView, i.ToString(), "*", "Request timed out", "", "", "", "");
					}
					catch { }

				if (!isStopExecution)
					progressBar.Value += increment;
			}

			if (!isStopExecution)
				progressBar.Value += increment;

			ThreadHelper.SetButtonText(this, goButton, "Go");
			ThreadHelper.SetTextBoxEnabled(this, domainTextBox, true);
			ThreadHelper.SetNumericUpDownEnabled(this, timeoutNumericUpDown, true);
			ThreadHelper.SetNumericUpDownEnabled(this, maxHopsNumericUpDown, true);
		}

		private void GoButton_Click(object sender, EventArgs e)
		{
			if (thread == null || !thread.IsAlive)
			{
				domainTextBox.Enabled = false;
				timeoutNumericUpDown.Enabled = false;
				maxHopsNumericUpDown.Enabled = false;
				goButton.Text = "Stop";
				dataGridView.Rows.Clear();
				dataGridView.Refresh();
				markers.Markers.Clear();
				routes.Clear();
				progressBar.Value = 0;
				thread = new Thread(new ThreadStart(RunTraceRouteThread));
				isStopExecution = false;
				thread.Start();
			}
			else
			{
				goButton.Enabled = false;
				goButton.Text = "Stopping";
				isStopExecution = true;
				stopTimer.Enabled = true;
			}
		}

		private void StopTimer_Tick(object sender, EventArgs e)
		{
			if (thread == null || !thread.IsAlive)
			{
				stopTimer.Enabled = false;
				domainTextBox.Enabled = true;
				timeoutNumericUpDown.Enabled = true;
				maxHopsNumericUpDown.Enabled = true;
				goButton.Text = "Go";
				goButton.Enabled = true;
			}
		}

		private void ResetMapButton_Click(object sender, EventArgs e)
		{
			gMapControl.Zoom = 2;
			gMapControl.Position = new PointLatLng(25, 0);
		}

		private void DomainTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				goButton.PerformClick();
		}

		private void BingdefaultToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
		}

		private void BinghybrideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
		}

		private void BingsatelliteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
		}

		private void GoogleMapsdefaultToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
		}

		private void GoogleMapsterrainToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
		}

		private void GoogleMapshybridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
		}

		private void GoogleMapssatelliteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
		}

		private void YandexdefaultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.YandexMapProvider.Instance;
		}

		private void YandexhybridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.YandexHybridMapProvider.Instance;
		}

		private void YandexsatelliteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = GMap.NET.MapProviders.YandexSatelliteMapProvider.Instance;
		}

		private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			// auto-scroll datagridview rows
			dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.RowCount - 1;
		}
	}
}
