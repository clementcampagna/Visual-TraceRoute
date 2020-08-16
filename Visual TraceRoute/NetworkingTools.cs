using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace Visual_TraceRoute
{
	class NetworkingTools
	{
		public static IPAddress FindDefaultGateway(int timeout)
		{
			System.Net.NetworkInformation.PingReply reply;
			using (var ping = new Ping())
			{
				var options = new PingOptions(1, true); // ttl=1, don't fragment=true
				try
				{
					reply = ping.Send("1.1.1.1", timeout, new byte[0], options);
				}
				catch (PingException)
				{
					System.Diagnostics.Debug.WriteLine("Gateway not available");
					return default;
				}
			}
			if (reply.Status != IPStatus.TtlExpired)
			{
				System.Diagnostics.Debug.WriteLine("Gateway not available");
				return default;
			}
			return reply.Address;
		}

		public static string GetPublicIPOfLocalMachine()
		{
			String direction = "";
			WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
			using (WebResponse response = request.GetResponse())
			using (StreamReader stream = new StreamReader(response.GetResponseStream()))
			{
				direction = stream.ReadToEnd();
			}

			//Search for the ip in the html
			int first = direction.IndexOf("Address: ") + 9;
			int last = direction.LastIndexOf("</body>");
			direction = direction.Substring(first, last - first);

			return direction;
		}

		public static string GetPingResponseTime(IPAddress netaddr, int timeout)
		{
			PingReply reply;

			using (var ping = new Ping())
			{
				try
				{
					reply = ping.Send(netaddr, timeout);
				}
				catch (PingException)
				{
					System.Diagnostics.Debug.WriteLine("IP unreachable");
					return "IP unreachable";
				}
			}

			if (reply.Status == IPStatus.Success)
			{
				return reply.RoundtripTime.ToString();
			}

			return "timed out";
		}

		public static IEnumerable<IPAddress> GetTraceRoute(string hostname, int timeout, int maxTTL)
		{
			const int bufferSize = 32;
			bool addFinalAddress = true;
			byte[] buffer = new byte[bufferSize];
			new Random().NextBytes(buffer);

			yield return IPAddress.Parse(GetPublicIPOfLocalMachine());

			using (var pinger = new Ping())
			{
				PingReply reply = null;
				for (int ttl = 1; ttl <= maxTTL + 1; ttl++)
				{
					if (!VisualTraceRouteForm.isStopExecution)
					{
						PingOptions options = new PingOptions(ttl, true);
						try
						{
							reply = pinger.Send(hostname, timeout, buffer, options);
						}
						catch (Exception ex)
						{
							string pingStatusMessage = string.Format("Error pinging {0}: {1}", hostname, (ex.InnerException ?? ex).Message);
							System.Diagnostics.Debug.WriteLine(pingStatusMessage);
							break;
						}

						// if we reach a status equal to success, we're done searching
						// and we only need to add the final destination ip to the table once
						if (reply != null && (reply.Status == IPStatus.Success))
							if (!addFinalAddress)
								break;
							else
								addFinalAddress = false;

						// otherwise, we carry on the search
						if (reply != null)
							yield return reply.Address;
					}
				}
			}
		}
	}
}
