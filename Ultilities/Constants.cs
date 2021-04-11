using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebform.Ultilities
{
    public static class Constants
    {
        // Session
        public const string SESSION_FOLLOWUP_QUESTION   = "SESSION_FOLLOWUP_QUESTION";



        // Question Type
        public const string QTYPE_DROPDOWN_LIST         = "Drop Down List";
        public const string QTYPE_CHECKBOX_LIST         = "Check Box List";
        public const string QTYPE_TEXTBOX               = "Text Box";
        public const string CURRENT_QTYPE               = "CURRENT_QTYPE";
        public const string NEXT_QUESTION_ID            = "NEXT_QUESTION_ID";

        // Answer
        public const string ANSWER_LIST                 = "ANSWERT_LIST";
    }
}