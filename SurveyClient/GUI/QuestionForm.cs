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
using static SurveyEditor.SharedObjectsClass;
using System.Reflection;

namespace SurveyClient
{
	public partial class QuestionForm : Form
	{
		public SurveyClass MySurvey;
		private List<QuestionClass> _curQuestionList;
		private QuestionType curQuestionType;
		private int curIdx; //aktualny numer pytania

		private List<RadioButton> questionTypeList;
		private String _currentSavedFileName;
		private String _currentSavedPath;
		private String _title;


		public QuestionForm()
		{
			InitializeComponent();
		}
		private void QuestionForm_Load(object sender, EventArgs e)
		{
			_title = "Survey Editor " + Assembly.GetEntryAssembly().GetName().Version;

			MySurvey = new SurveyClass();
			_curQuestionList = MySurvey.QuestionList;
			
			
			
			//panelQuestion.Controls.Clear();
			//panelQuestion.Controls.Add(new Q1to10());
			
			//questionTypeList = new List<RadioButton>() { rbNoYes, rbNoYesDontkonw, rb1to3, rb1to5, rb1to10, rb1to100 };
			//curIdx = 0;
			//UpdateForm();
		}
	}
}
