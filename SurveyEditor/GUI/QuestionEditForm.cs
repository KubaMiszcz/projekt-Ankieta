using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SurveyEditor.SharedObjectsClass;

namespace SurveyEditor
{
	public partial class QuestionEditForm : Form
	{
		private SurveyClass _mySurvey;
		private List<QuestionClass> _curQuestionList;
		private QuestionType curQuestionType;
		private int curIdx; //aktualny numer pytania

		private List<RadioButton> questionTypeList;
		private String _currentSavedFileName;
		private String _currentSavedPath;
		private String _title;

		public QuestionEditForm()
		{
			InitializeComponent();
		}
		private void QuestionEditForm_Load(object sender, EventArgs e)
		{
			_title = "Survey Editor " + Assembly.GetEntryAssembly().GetName().Version;

			_mySurvey = SharedObjectsClass.MySurvey;
			_curQuestionList = _mySurvey.QuestionList;

			questionTypeList = new List<RadioButton>() { rbNoYes, rbNoYesDontkonw, rb1to3, rb1to5, rb1to10, rb1to100 };
			curIdx = 0;
			UpdateForm();
		}

		private void btnPrevQuestion_Click(object sender, EventArgs e)
		{
			if (curIdx == 0) { }//MessageBox.Show("This is the First question!");
			else
			{
				curIdx--;
				UpdateForm();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			QuestionClass q = new QuestionClass(curQuestionType, rtbQuestionContent.Text, 0);
			_curQuestionList.Add(q);
			curIdx = _curQuestionList.Count - 1;
			rtbQuestionContent.Text = "";
			cbQuestionNumberDropDownList.Items.Add(_curQuestionList.Count);
			UpdateForm();
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			QuestionClass q = new QuestionClass(curQuestionType, rtbQuestionContent.Text, 0);
			_curQuestionList[curIdx] = q;
			UpdateForm();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (curIdx > 0)
			{
				_curQuestionList.RemoveAt(curIdx);
				if (curIdx == _curQuestionList.Count) curIdx--;
				UpdateForm();
				cbQuestionNumberDropDownList.Items.RemoveAt(_curQuestionList.Count);
				UpdateForm();
			}
		}

		private void btnNextQuestion_Click(object sender, EventArgs e)
		{
			if (curIdx >= _curQuestionList.Count - 1)
			{
				//MessageBox.Show("This is teh Last question!");
			}
			else
			{
				curIdx++;
				UpdateForm();
			}
		}

		

		void UpdateForm()
		{
			lbTotalQuestions.Text = _curQuestionList.Count.ToString();
			QuestionClass curQ = _curQuestionList.ElementAt(curIdx);
			rtbQuestionContent.Text = curQ.Content;
			RadioButton rb = questionTypeList.ElementAt((int)curQ.Type);
			rb.Checked = true;
			cbQuestionNumberDropDownList.SelectedItem = curIdx + 1;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton s = sender as RadioButton;
			curQuestionType = (QuestionType)questionTypeList.IndexOf(s);
			//label1.Text = type.ToString();
		}

		private void cbQuestionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			curIdx = ((int)cbQuestionNumberDropDownList.SelectedItem) - 1;
			UpdateForm();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			_mySurvey.Author = tbAuthor.Text;
		}

		private void rtbSubject_TextChanged(object sender, EventArgs e)
		{
			_mySurvey.SurveyDescription = rtbSubject.Text;
		}

		private void NewStripMenuItem2_Click(object sender, EventArgs e)
		{
			SharedObjectsClass.MySurvey = new SurveyClass();
			_mySurvey = SharedObjectsClass.MySurvey;
			_curQuestionList = _mySurvey.QuestionList;

			curIdx = 0;
			tbAuthor.Text = "";
			rtbSubject.Text = "";
			rtbQuestionContent.Text = "";
			foreach (RadioButton rb in gbQuestionKind.Controls)
			{
				rb.Checked = false;
			}
			cbQuestionNumberDropDownList.Items.Clear();
			cbQuestionNumberDropDownList.Text = "1";
			lbTotalQuestions.Text = "0";
		}

		private void groupBox_Paint(object sender, PaintEventArgs e)
		{
			GroupBox box = sender as GroupBox;
			DrawGroupBoxBorder(box, e.Graphics, Color.Black, Color.MediumPurple);
		}

		private void DrawGroupBoxBorder(GroupBox box, Graphics g, Color textColor, Color borderColor)
		{
			if (box != null)
			{
				Brush textBrush = new SolidBrush(textColor);
				Brush borderBrush = new SolidBrush(borderColor);
				Pen borderPen = new Pen(borderBrush);
				int Fillet = 5;
				SizeF strSize = g.MeasureString(box.Text, box.Font);
				Rectangle rect = new Rectangle(box.ClientRectangle.X,
											   box.ClientRectangle.Y + (int)(strSize.Height / 2),
											   box.ClientRectangle.Width - 1,
											   box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

				// Clear text and border
				g.Clear(this.BackColor);

				// Draw text
				g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + Fillet, 0);


				// Drawing Border
				Point ptUL = new Point(box.ClientRectangle.X, box.ClientRectangle.Y + (int)(strSize.Height / 2));//upper left
				Point ptUR = new Point(box.ClientRectangle.Width - 1, box.ClientRectangle.Y + (int)(strSize.Height / 2));
				Point ptBL = new Point(box.ClientRectangle.X, box.ClientRectangle.Height - 2);
				Point ptBR = new Point(box.ClientRectangle.Width - 1, box.ClientRectangle.Height - 2);
				//Left
				g.DrawLine(borderPen, ptUL.X, ptUL.Y + Fillet, ptBL.X, ptBL.Y - Fillet);
				//Right
				g.DrawLine(borderPen, ptUR.X, ptUR.Y + Fillet, ptBR.X, ptBR.Y - Fillet);
				//Bottom
				g.DrawLine(borderPen, ptBL.X + Fillet, ptBL.Y, ptBR.X - Fillet, ptBR.Y);
				////Top1 before string
				g.DrawLine(borderPen, ptUL.X + Fillet, ptUL.Y, ptUL.X + box.Padding.Left + Fillet, ptUL.Y);
				////Top2 after string
				g.DrawLine(borderPen, ptUL.X + 3 * box.Padding.Left + (int)(strSize.Width), ptUL.Y, ptUR.X - Fillet, ptUR.Y);
				//Drawin Arcs
				//kierunek CW, mierzone od osi X, kat poczatkowy, kat rysowany (nie koncowy)
				//i pamietaj o 2*fillet bo to rysuje prostokat i srodek luku jest w srodku prostokata
				Point pt = new Point();
				//UL
				pt = ptUL;
				g.DrawArc(borderPen, pt.X, pt.Y, 2 * Fillet, 2 * Fillet, 180, 90);
				//UR
				pt = ptUR;
				//g.DrawArc(borderPen, pt.X-2*Fillet, pt.Y, pt.X, pt.Y+2* Fillet, 270, 90);
				g.DrawArc(borderPen, pt.X - 2 * Fillet, pt.Y, 2 * Fillet, 2 * Fillet, -90, 90);
				//BL
				pt = ptBL;
				g.DrawArc(borderPen, pt.X, pt.Y - 2 * Fillet, 2 * Fillet, 2 * Fillet, 90, 90);
				//BR
				pt = ptBR;
				g.DrawArc(borderPen, pt.X - 2 * Fillet, pt.Y - 2 * Fillet, 2 * Fillet, 2 * Fillet, 0, 90);
			}
		}

		private void exporttxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SharedObjectsClass.ShowSomeday();
		}

		private void exportToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SharedObjectsClass.ShowSomeday();
		}

		private void importFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SharedObjectsClass.ShowSomeday();
		}

		private void importFromtxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SharedObjectsClass.ShowSomeday();
		}
	}
}


