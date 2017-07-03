using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SurveyClient
{
	public class MyControl1 : UserControl
	{
		public String AnswerValue;

		public MyControl1()
		{
			WireAllControls(this);
			AnswerValue = ""; //-1 means not clicked yet
		}

		public void SetValue(object o)
		{
			try
			{
				Button btn = o as Button;
				if (btn != null)
				{
					AnswerValue = btn.Text;
				}
				else
				{
					TrackBar tb = o as TrackBar;
					AnswerValue = tb.Value.ToString();
				}
				this.Parent.Parent.Parent.Controls[0].Text = AnswerValue;
				//Debug.WriteLine(AnswerValue.ToString());
			}
			catch (NullReferenceException)
			{

			}

		}

		public void WireAllControls(Control cont)
		{
			foreach (Control ctl in cont.Controls)
			{
				ctl.Click += ctl_Click;
				if (ctl.HasChildren)
				{
					WireAllControls(ctl);
				}
			}
		}
		private void ctl_Click(object sender, EventArgs e)
		{
			this.InvokeOnClick(this, EventArgs.Empty);
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MyControl1
			// 
			this.Name = "MyControl1";
			//this.Click += new System.EventHandler(this.MyControl1_Click);
			this.ResumeLayout(false);

		}
	}


}
