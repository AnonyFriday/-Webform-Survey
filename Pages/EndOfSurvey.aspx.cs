using SurveyWebform.Models;
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
            if(!IsPostBack)
            {
                ShowAnswerGridViewBeforeSave();
            }
        }
        protected void ButtonSaveSurvey_Click(object sender, EventArgs e)
        {
            // Retrieve back the AnswersList from Session
            List<Answer> answersSession = (List<Answer>)Session[Constants.SESSION_ANSWER_LIST];
            AddAnswerFromSession(answersSession);
        }

        private void ShowAnswerGridViewBeforeSave()
        {
            List<Answer> answersSession = (List<Answer>)Session[Constants.SESSION_ANSWER_LIST];
            id_AnswerResultGridView.DataSource = answersSession;
            id_AnswerResultGridView.DataBind();
        }


        public void AddAnswerFromSession(List<Answer> answersSession)
        {
            if (answersSession.Count() > 0 || answersSession == null)
            {
                foreach (var answer in answersSession)
                {
                    var result = AnswerRepository.InsertAnswer(answer.Question_Id, answer.QOption_Id, answer.QOption_TextBoxValue);
                    if (!result)
                    {
                        System.Diagnostics.Debug.WriteLine("Some line cannot be inserted");
                        break;
                    }
                    id_LabelStatus.Text = "Save Successfully! ";
                }
            } else
            {
                id_LabelStatus.Text = "Something Wrong!. Please try again";
            }
        }

    }
}