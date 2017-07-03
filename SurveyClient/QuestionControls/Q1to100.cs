using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyClient
{
	public partial class Q1to100 : MyControl1
	{
		public Q1to100()
		{
			InitializeComponent();
			trackBar1.Value = 50;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			lbValue.Text = trackBar1.Value.ToString();
		}

		private void trackBar1_MouseUp(object sender, MouseEventArgs e)
		{
			SetValue(sender);
		}
	}
}
