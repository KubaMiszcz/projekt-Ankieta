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
	public partial class Q1to10 : MyControl1
	{
		public Q1to10()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			SetValue(sender);
		}
	}
}
