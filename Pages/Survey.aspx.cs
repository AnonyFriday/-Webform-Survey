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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Stack<int> followUpQuestions = (Stack<int>)Session[Constants.SESSION_FOLLOWUP_QUESTION];

            //if (followUpQuestions == null)
            //{
            //    followUpQuestions = new Stack<int>();
            //    followUpQuestions.Push(1);
            //    Session["FOLLOWUP_ID_LIST"] = followUpQuestions;
            //}
            //else if (followUpQuestions.Count() > 0)
            //{
            //    currentQuestionIdInSession = followUpQuestions.Peek();
            //    // Read Question ID Now

            //}

            int currentQuestionIdInSession = 1;
            Question currentQuestion = SurveyDbRepository.GetQuestionById(currentQuestionIdInSession);
            var qOptions = SurveyDbRepository.GetQOptionNameById(currentQuestion.Question_Id);

            foreach(var name in qOptions)
            {
                Console.WriteLine(name);
            }

            QType qType = SurveyDbRepository.GetQTypeByQuestionId(currentQuestion.Question_Id);


            if (currentQuestion != null && qType != null)
            {
                QuestionLabel.Text = currentQuestion.Question_Name;
                switch (qType.QType_Name)
                {
                    case Constants.QTYPE_CHECKBOX_LIST:
                        CheckBoxList cbl = new CheckBoxList();
                        cbl.DataSource = qOptions;
                  
                        cbl.ID = Constants.QTYPE_CHECKBOX_LIST;
                        cbl.DataTextField = "QOption_Name";
                        cbl.DataValueField = "QOption_Name";
                        cbl.DataBind();
                        ControlPHolder.Controls.Add(cbl);
                        break;
                    case Constants.QTYPE_DROPDOWN_LIST:
                        DropDownList ddl = new DropDownList();
                        ddl.DataSource = qOptions;
                        ddl.ID = Constants.QTYPE_DROPDOWN_LIST;
                        ddl.DataTextField = "QOption_Name";
                        ddl.DataValueField = "QOption_Name";
                        ddl.DataBind();
                        ControlPHolder.Controls.Add(ddl);
                        break;
                    case Constants.QTYPE_TEXTBOX:
                        TextBox tb = new TextBox();
                        tb.ID = Constants.QTYPE_TEXTBOX;
                        ControlPHolder.Controls.Add(tb);
                        break;
                    default:
                        break;
                }
            }
        }

        public void insertNextQuestion(int currentQuestionId, int currentQOptionId, Stack<int> followupList)
        {
            Question nextQuestion = SurveyDbRepository.GetNextQuestion(currentQuestionId, currentQOptionId);

            if (nextQuestion == null)
            {

            }

            // In case select mutliple QOption with the same Next Question Id
            //if (followupList.Contains(nextQuestion.Question_Id))
            //{
            //    followupList.Push(nextQuestion.Question_Id);
            //}

            QuestionLabel.Text = "Wallaaa nothing";
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            Stack<int> followUpQuestions = (Stack<int>)Session["FOLLOWUP_ID_LIST"];
            int currentQuestionId = followUpQuestions.Pop();

            insertNextQuestion(1, 20, followUpQuestions);
        }
    }
}