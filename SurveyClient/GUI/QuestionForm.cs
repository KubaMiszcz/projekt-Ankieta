using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurveyEditor;

namespace SurveyClient
{
    public partial class QuestionForm : Form
    {
		public SurveyClass MySurvey;
		//private QuestionClass _curQUestion;



		public QuestionForm()
        {
            InitializeComponent();
        }

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void QuestionForm_Load(object sender, EventArgs e)
		{
			MySurvey = new SurveyClass();
			//panelQuestion.Controls.Clear();
			//panelQuestion.Controls.Add(new Q1to10());
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}
	}
}
