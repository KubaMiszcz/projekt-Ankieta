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
using System.Diagnostics;

namespace SurveyClient
{
	public partial class QuestionForm : Form
	{
		public SurveyClass MySurvey;
		private List<QuestionClass> _curQuestionList;
		private QuestionType curQuestionType;
		private int curIdx; //aktualny numer pytania

		private List<UserControl> questionControlList;
		private String _currentSavedFileName;
		private String _currentSavedPath;
		private String _title;


		public QuestionForm()
		{
			InitializeComponent();
		}
		private void QuestionForm_Load(object sender, EventArgs e)
		{
			_title = "Survey Client " + Assembly.GetEntryAssembly().GetName().Version;

			MySurvey = new SurveyClass();
			_curQuestionList = MySurvey.QuestionList;

			//panelQuestion.Controls.Clear();
			//panelQuestion.Controls.Add(new Q1to10());

			//questionTypeList = new List<RadioButton>() { rbNoYes, rbNoYesDontkonw, rb1to3, rb1to5, rb1to10, rb1to100 };
			//curIdx = 0;
			//UpdateForm();
		}

		private void UpdateForm()
		{
			lbCurrentQuestionNum.Text = (curIdx + 1).ToString();
			lbTotalQuestions.Text = _curQuestionList.Count.ToString();
			rtbQuestionContent.Text = _curQuestionList[curIdx].Content;

			QuestionClass q = _curQuestionList[curIdx];
			switch (q.Type)
			{
				case QuestionType.NoYes:
					panelQuestion.Controls.Clear();
					panelQuestion.Controls.Add(new QYesNo());
					break;
				case QuestionType.NoYesDontKnow:
					panelQuestion.Controls.Clear();
					panelQuestion.Controls.Add(new QYesNoDontKnow());
					break;
				case QuestionType.Num1To3:
					panelQuestion.Controls.Clear();
					panelQuestion.Controls.Add(new Q1to3());
					break;
				case QuestionType.Num1To5:
					panelQuestion.Controls.Clear();
					panelQuestion.Controls.Add(new Q1to5());
					break;
				case QuestionType.Num1To10:
					panelQuestion.Controls.Clear();
					panelQuestion.Controls.Add(new Q1to10());
					break;
				case QuestionType.Num1To100:
					panelQuestion.Controls.Clear();
					panelQuestion.Controls.Add(new Q1to100());
					break;
				default:
					break;
			}

			if (!_curQuestionList[curIdx].AnswerValue.Equals("")) //already answered
				lbCurAnswer.Text = _curQuestionList[curIdx].AnswerValue;
			else lbCurAnswer.Text = "N/A";
		}

		private void btnNextQuestion_Click(object sender, EventArgs e)
		{
			try
			{
				if (curIdx < _curQuestionList.Count - 1)
				{
					curIdx++;
					UpdateForm();
				}
				else MessageBox.Show("Last Question", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Load Survey First", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnPrevQuestion_Click(object sender, EventArgs e)
		{
			try
			{
				if (curIdx > 0)
				{
					curIdx--;
					UpdateForm();
				}
				else MessageBox.Show("First Question", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Load Survey First", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void qYesNo1_Load(object sender, EventArgs e)
		{

		}

		private void lbCurAnswer_TextChanged(object sender, EventArgs e)
		{
			if (lbCurAnswer.Text.Equals("N/A"))
				_curQuestionList[curIdx].AnswerValue = "";
			else _curQuestionList[curIdx].AnswerValue = lbCurAnswer.Text;
		}
	}
}
