using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SurveyEditor.SharedObjectsClass;

namespace SurveyEditor
{
	public class QuestionClass
	{
		//private uint _questionID;
		private String _questionContent;
		private String _answerValue;
		private QuestionType _questionTypeCode;	//enum
		private String _questionTypeDesc;

		//public uint questionID
		//{
		//	get { return _questionID; }
		//	set { _questionID = value; }
		//}
		public String Content
		{
			get { return _questionContent; }
			set { _questionContent = value; }
		}
		public String AnswerValue
		{
			get { return _answerValue; }
			set { _answerValue = value; }
		}
		public QuestionType Type
		{
			get { return _questionTypeCode; }
			set { _questionTypeCode = value; }
		}

		public String TypeDescription
		{
			get { return _questionTypeCode.ToString(); }
			set { _questionTypeDesc = value; }
		}

		public QuestionClass()
		{
			_questionTypeCode = QuestionType.NoYes;
			_questionContent = "";
			_answerValue = "";
		}
		public QuestionClass(QuestionType type, String content, String answer)
		{
			_questionTypeCode = type;
			_questionContent = content;
			_answerValue = "";    //domsylna odpowiedz na razie 0			
		}
	}
}
