using Guna.UI2.WinForms;

namespace Visual_TraceRoute

{
	class ThreadHelper
	{
		/// <summary>
		/// Set text property of various controls
		/// </summary>
		/// <param name="form">The calling form</param>
		/// <param name="ctrl"></param>
		/// <param name="text"></param>
		delegate void SetDataGridViewCellTextCallback(VisualTraceRouteForm f, Guna2DataGridView ctrl, string text, int rowNumber, int cellNumber);
		delegate void SetDataGridViewAddNewRowCallback(VisualTraceRouteForm f, Guna2DataGridView ctrl, string hopNumber, string time, string address, string org, string city, string country, string coordinates);
		delegate void ClearDataGridViewCallback(VisualTraceRouteForm f, Guna2DataGridView ctrl);
		delegate void SetTextBoxEnabledCallback(VisualTraceRouteForm f, Guna2TextBox ctrl, bool value);
		delegate void SetButtonTextCallback(VisualTraceRouteForm f, Guna2Button ctrl, string text);
		delegate void SetNumericUpDownCallback(VisualTraceRouteForm f, Guna2NumericUpDown ctrl, bool value);

		public static void SetDataGridViewCellText(VisualTraceRouteForm form, Guna2DataGridView ctrl, string text, int rowNumber, int cellNumber)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctrl.InvokeRequired)
			{
				SetDataGridViewCellTextCallback d = new SetDataGridViewCellTextCallback(SetDataGridViewCellText);
				form.Invoke(d, new object[] { form, ctrl, text, rowNumber, cellNumber });
			}
			else
				ctrl.Rows[rowNumber].Cells[cellNumber].Value = text;
		}

		public static void SetDataGridViewAddNewRow(VisualTraceRouteForm form, Guna2DataGridView ctrl, string hopNumber, string time, string address, string org, string city, string country, string coordinates)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctrl.InvokeRequired)
			{
				SetDataGridViewAddNewRowCallback d = new SetDataGridViewAddNewRowCallback(SetDataGridViewAddNewRow);
				form.Invoke(d, new object[] { form, ctrl, hopNumber, time, address, org, city, country, coordinates });
			}
			else
				ctrl.Rows.Add(hopNumber, time, address, org, city, country, coordinates);
		}

		public static void ClearDataGridView(VisualTraceRouteForm form, Guna2DataGridView ctrl)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctrl.InvokeRequired)
			{
				ClearDataGridViewCallback d = new ClearDataGridViewCallback(ClearDataGridView);
				form.Invoke(d, new object[] { form, ctrl });
			}
			else
			{
				ctrl.Rows.Clear();
				ctrl.Refresh();
			}
		}

		public static void SetButtonText(VisualTraceRouteForm form, Guna2Button ctrl, string text)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctrl.InvokeRequired)
			{
				SetButtonTextCallback d = new SetButtonTextCallback(SetButtonText);
				form.Invoke(d, new object[] { form, ctrl, text });
			}
			else
				ctrl.Text = text;
		}
		public static void SetTextBoxEnabled(VisualTraceRouteForm form, Guna2TextBox ctrl, bool value)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctrl.InvokeRequired)
			{
				SetTextBoxEnabledCallback d = new SetTextBoxEnabledCallback(SetTextBoxEnabled);
				form.Invoke(d, new object[] { form, ctrl, value });
			}
			else
				ctrl.Enabled = value;
		}

		public static void SetNumericUpDownEnabled(VisualTraceRouteForm form, Guna2NumericUpDown ctrl, bool value)
		{
			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			if (ctrl.InvokeRequired)
			{
				SetNumericUpDownCallback d = new SetNumericUpDownCallback(SetNumericUpDownEnabled);
				form.Invoke(d, new object[] { form, ctrl, value });
			}
			else
				ctrl.Enabled = value;
		}
	}
}
