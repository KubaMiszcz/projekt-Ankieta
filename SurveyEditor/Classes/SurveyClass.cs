using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SurveyEditor.SharedObjectsClass;

namespace SurveyEditor
{
	public class SurveyClass
	{
		public String Author;
		public String SurveyDescription;
		public List<QuestionClass> QuestionList;
		public SurveyClass() {
			Author = "";
			SurveyDescription = "";
			QuestionList = new List<QuestionClass>();
		}

		public void AddQuestion(QuestionType type, String content, String answer)
		{
			QuestionClass q = new QuestionClass(type, content, answer);
			QuestionList.Add(q);
		}

	}
}
