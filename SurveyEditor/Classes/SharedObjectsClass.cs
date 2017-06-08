using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
	class SharedObjectsClass
	{
		public static SurveyClass MySurvey;
		public enum QuestionType
		{
			NoYes=0,
			NoYesDontKnow,
			Num1To3,
			Num1To5,
			Num1To10,
			Num1To100,
		}
	}
}
