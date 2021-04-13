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

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            Stack<int> followUpQuestions = (Stack<int>)Session[Constants.SESSION_FOLLOWUP_QUESTION];
            int currentQuestionIdInSession = 1;

            if (followUpQuestions == null)
            {
                followUpQuestions = new Stack<int>();
                followUpQuestions.Push(1);
                Session[Constants.SESSION_FOLLOWUP_QUESTION] = followUpQuestions;
            }
            else if (followUpQuestions.Count() > 0)
            {
                currentQuestionIdInSession = followUpQuestions.Peek();
            }

            GetCurrentQuestionContext(currentQuestionIdInSession);
        }
        #endregion


        #region Methods
        private void GetCurrentQuestionContext(int currentQuestionIdInSession)
        {
            var currentQuestion = QuestionRepository.GetQuestionById(currentQuestionIdInSession);
            var qOptions = QuestionRepository.GetQOptionByQuestionId(currentQuestionIdInSession);
            var qType = QuestionRepository.GetQTypeByQuestionId(currentQuestionIdInSession);

            if (currentQuestion != null && qType != null)
            {
                QuestionLabel.Text = currentQuestion.Question_Name;

                switch (qType.QType_Name)
                {
                    case Constants.QTYPE_CHECKBOX_LIST:
                        CheckBoxList cbl = new CheckBoxList();
                        cbl.ID = Constants.QTYPE_CHECKBOX_LIST;

                        foreach (var option in qOptions)
                        {
                            ListItem item = new ListItem();
                            item.Text = option.QOption_Name;
                            item.Value = option.QOption_Id.ToString();

                            if (option.Next_Question_Id != null)
                            {
                                item.Attributes[Constants.NEXT_QUESTION_ID] = option.Next_Question_Id.ToString();
                            }
                                
                            cbl.Items.Add(item);
                        }

                        ControlPHolder.Controls.Add(cbl);
                        Session[Constants.CURRENT_QTYPE] = cbl.ID;
                        break;

                    case Constants.QTYPE_DROPDOWN_LIST:
                        DropDownList ddl = new DropDownList();
                        ddl.ID = Constants.QTYPE_DROPDOWN_LIST;

                        foreach (var option in qOptions)
                        {
                            ListItem item = new ListItem();
                            item.Text = option.QOption_Name;
                            item.Value = option.QOption_Id.ToString();

                            if (option.Next_Question_Id != null)
                            {
                                item.Attributes[Constants.NEXT_QUESTION_ID] = option.Next_Question_Id.ToString();
                            }

                            ddl.Items.Add(item);
                        }

                        ControlPHolder.Controls.Add(ddl);
                        Session[Constants.CURRENT_QTYPE] = ddl.ID;
                        break;
                    case Constants.QTYPE_TEXTBOX:
                        TextBox tb = new TextBox();

                        tb.ID = Constants.QTYPE_TEXTBOX;

                        ControlPHolder.Controls.Add(tb);
                        Session[Constants.CURRENT_QTYPE] = tb.ID;
                        break;
                    default:
                        break;
                }
            }
        }
   


        
        public void InsertCurrentQuestionToStack(int currentQuestionId, Stack<int> followUpQuestion)
        {
            // In case select mutliple QOption with the same Next Question Id
            if (!followUpQuestion.Contains(currentQuestionId))
            {
                followUpQuestion.Push(currentQuestionId);
            }
        }
        #endregion


        #region Button Click
        protected void NextButton_Click(object sender, EventArgs e)
        {
            // Finding the User Control, retrieve the value from controls
            var userControl = ControlPHolder.FindControl(Session[Constants.CURRENT_QTYPE].ToString());


            List<Answer> answers = (List<Answer>)Session[Constants.ANSWER_LIST];
            if (answers != null)
            {
                answers = new List<Answer>();
                Session[Constants.ANSWER_LIST] = answers;
            }


            // Retrieve back the Stack
            Stack<int> followUpQuestionList = (Stack<int>)Session[Constants.SESSION_FOLLOWUP_QUESTION];
            int currentQuestionIdInSession = followUpQuestionList.Pop();
            Question question = QuestionRepository.GetQuestionById(currentQuestionIdInSession);

            // Push the next question
            if (question.Next_Question_Id != null)
            {
                InsertCurrentQuestionToStack((int)question.Next_Question_Id, followUpQuestionList);
            }



            // Determine the next question id of the option
            if (userControl is TextBox)
            {
                TextBox textBox = (TextBox)userControl;


            }

            else if (userControl is CheckBoxList)
            {
                CheckBoxList checkBoxList = (CheckBoxList)userControl;
                foreach (ListItem item in checkBoxList.Items)
                {
                    if (item.Selected)
                    {
                        if (item.Attributes[Constants.NEXT_QUESTION_ID] != null)
                        {
                            int nextQuestionId = int.Parse(item.Attributes[Constants.NEXT_QUESTION_ID]);
                            InsertCurrentQuestionToStack(nextQuestionId, followUpQuestionList);
                        }
                    }
                }

                // Adding to The Answer
            }

            else if (userControl is DropDownList)
            {
                DropDownList dropdownList = (DropDownList)userControl;
                foreach (ListItem item in dropdownList.Items)
                {
                    if (item.Selected)
                    {
                        if (item.Attributes[Constants.NEXT_QUESTION_ID] != null)
                        {

                            int nextQuestionId = int.Parse(item.Attributes[Constants.NEXT_QUESTION_ID]);
                            InsertCurrentQuestionToStack(nextQuestionId, followUpQuestionList);
                        }
                    }
                }
            }



            // Determine the last question
            if (followUpQuestionList.Count() > 0)
            {
                Response.Redirect("~/Pages/Survey.aspx");
            }
            else
            {
                Response.Redirect("~/Pages/EndOfSurvey.aspx");
            }
        }
        #endregion
    }
}