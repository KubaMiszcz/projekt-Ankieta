using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyClient
{
	public class SharedObjectsClass
	{
		public enum QuestionType
		{
			NoYes=0,
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
