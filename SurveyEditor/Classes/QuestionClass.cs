using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Survey.SharedObjectsClass;

namespace Survey
{
	class QuestionClass
	{
		private String _questionContent;
		private Byte _answer;
		private QuestionType _questionType;
		private String _qquestionType;

		public String Content
		{
			get { return _questionContent; }
			set { _questionContent = value; }
		}
		public Byte Answer
		{
			get { return _answer; }
			set { _answer = value; }
		}
		public QuestionType Type
		{
			get { return _questionType; }
			set { _questionType = value; }
		}

		public String TypeDescription
		{
			get { return _questionType.ToString(); }
			set { _qquestionType = value; }
		}

		public QuestionClass()
		{
			_questionType = QuestionType.NoYes;
			_questionContent = "";
			_answer = 0;
		}
		public QuestionClass(QuestionType type, String content, Byte answer)
		{
			_questionType = type;
			_questionContent = content;
			_answer = 0;    //domsylna odpowiedz na razie 0			
		}
	}
}
