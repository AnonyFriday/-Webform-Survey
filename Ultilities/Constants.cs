using System;

namespace SurveyWebform.Ultilities
{
    public class Constants
    {
        // Apply Singleton to not let user instantiates the class 
        private static readonly Lazy<Constants> lazy = new Lazy<Constants>(() => new Constants());
        private Constants()
        {
        }
        public static Constants shared => lazy.Value;



        // Session
        public const string SESSION_FOLLOWUP_QUESTIONS_ID = "SESSION_FOLLOWUP_QUESTIONS_ID";
        public const string SESSION_NEXT_QUESTION_ID = "SESSION_NEXT_QUESTION_ID";
        public const string SESSION_CURRENT_QTYPE = "SESSION_CURRENT_QTYPE";
        public const string SESSION_ANSWER_LIST = "SESSION_ANSWERT_LIST";


        // Question Type
        public const string QTYPE_DROPDOWN_LIST = "Drop Down List";
        public const string QTYPE_CHECKBOX_LIST = "Check Box List";
        public const string QTYPE_TEXTBOX       = "Text Box";


        // Absolute URL Location in Pages
        public const string URL_ADMIN = "~/Pages/Admin.aspx";
        public const string URL_ADMIN_LOGIN = "~/Pages/AdminLogin.aspx";
        public const string URL_END_OF_SURVEY = "~/Pages/EndOfSurvey.aspx";
        public const string URL_SURVEY = "~/Pages/Survey.aspx";

    }
}