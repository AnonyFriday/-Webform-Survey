using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebform.Ultilities
{
    public static class Constants
    {
        // Session
        public const string SESSION_FOLLOWUP_QUESTIONS_ID = "SESSION_FOLLOWUP_QUESTIONS_ID";
        public const string SESSION_NEXT_QUESTION_ID = "SESSION_NEXT_QUESTION_ID";
        public const string SESSION_CURRENT_QTYPE = "CURRENT_QTYPE";

        // Question Type
        public const string QTYPE_DROPDOWN_LIST = "Drop Down List";
        public const string QTYPE_CHECKBOX_LIST = "Check Box List";
        public const string QTYPE_TEXTBOX = "Text Box";
    


        // Answer
        public const string SESSION_ANSWER_LIST = "ANSWERT_LIST";
    }
}