using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyEditor
{
	public class SharedObjectsClass
	{
		public static SurveyClass MySurvey;
		public enum QuestionType
		{
			NoYes=1,
			NoYesDontKnow,
			Num1To3,
			Num1To5,
			Num1To10,
			Num1To100,
		}
		public static void ShowSomeday()
		{
			MessageBox.Show("Someday...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
