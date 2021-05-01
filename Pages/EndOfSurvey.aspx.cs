using SurveyWebform.Models.Question_Group;
using SurveyWebform.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebform.Pages
{
    public partial class EndOfSurvey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Answer> answersSession = (List<Answer>)Session[Constants.SESSION_ANSWER_LIST];
            foreach(var item in answersSession)
            {
                
            }
        }
    }
}