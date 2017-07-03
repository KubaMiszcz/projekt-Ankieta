using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SurveyClient
{
	public partial class QYesNo : MyControl1
	{
		public QYesNo()
		{
			InitializeComponent();
			WireAllControls(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SetValue(sender);
		}
	}
}
