using SurveyWebform.Models;
using SurveyWebform.Models.Question_Group;
using SurveyWebform.Ultilities;
using SurveyWebform.UserControls;
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
            Stack<int> followUpQuestionsId = (Stack<int>)Session[Constants.SESSION_FOLLOWUP_QUESTIONS_ID];
            int currentQuestionIdInSession = 1;

            if (followUpQuestionsId == null)
            {
                followUpQuestionsId = new Stack<int>();
                followUpQuestionsId.Push(currentQuestionIdInSession);
                Session[Constants.SESSION_FOLLOWUP_QUESTIONS_ID] = followUpQuestionsId;
            }
            else if (followUpQuestionsId.Count() > 0)
            {
                currentQuestionIdInSession = followUpQuestionsId.Peek();
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
                // Set Question Title 
                id_QuestionUserControl.HeaderQuestionTitle = currentQuestion.Question_Name;

                // Set Question Control
                switch (qType.QType_Name)
                {
                    case Constants.QTYPE_CHECKBOX_LIST:
                        CheckBoxList cbl = new CheckBoxList
                        {
                            ID = Constants.QTYPE_CHECKBOX_LIST
                        };

                        foreach (var option in qOptions)
                        {
                            ListItem item = new ListItem
                            {
                                Text = option.QOption_Name,
                                Value = option.QOption_Id.ToString()
                            };

                            if (option.Next_Question_Id != null)
                            {
                                item.Attributes[Constants.SESSION_NEXT_QUESTION_ID] = option.Next_Question_Id.ToString();
                            }

                            cbl.Items.Add(item);
                        }

                        id_QuestionUserControl.PlaceHolderControls.Controls.Add(cbl);
                        Session[Constants.SESSION_CURRENT_QTYPE] = cbl.ID;
                        break;

                    case Constants.QTYPE_DROPDOWN_LIST:
                        DropDownList ddl = new DropDownList
                        {
                            ID = Constants.QTYPE_DROPDOWN_LIST
                        };

                        foreach (var option in qOptions)
                        {
                            ListItem item = new ListItem
                            {
                                Text = option.QOption_Name,
                                Value = option.QOption_Id.ToString()
                            };

                            if (option.Next_Question_Id != null)
                            {
                                item.Attributes[Constants.SESSION_NEXT_QUESTION_ID] = option.Next_Question_Id.ToString();
                            }

                            ddl.Items.Add(item);
                        }


                        id_QuestionUserControl.PlaceHolderControls.Controls.Add(ddl);
                        Session[Constants.SESSION_CURRENT_QTYPE] = ddl.ID;
                        break;
                    case Constants.QTYPE_TEXTBOX:
                        TextBox tb = new TextBox
                        {
                            ID = Constants.QTYPE_TEXTBOX
                        };


                        id_QuestionUserControl.PlaceHolderControls.Controls.Add(tb);
                        Session[Constants.SESSION_CURRENT_QTYPE] = tb.ID;
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
            Control userControl = id_QuestionUserControl.PlaceHolderControls.FindControl(Session[Constants.SESSION_CURRENT_QTYPE].ToString());
            
            List<Answer> answers = (List<Answer>)Session[Constants.SESSION_ANSWER_LIST];
            if (answers == null)
            {
                answers = new List<Answer>();
                Session[Constants.SESSION_ANSWER_LIST] = answers;
            }


            // Retrieve back the Stack
            Stack<int> followUpQuestionList = (Stack<int>)Session[Constants.SESSION_FOLLOWUP_QUESTIONS_ID];
            int currentQuestionIdInSession = followUpQuestionList.Pop();
            Question question = QuestionRepository.GetQuestionById(currentQuestionIdInSession);

            // Push the next question
            if (question.Next_Question_Id != null)
            {
                InsertCurrentQuestionToStack((int)question.Next_Question_Id, followUpQuestionList);
            }


            /*
             * Check answer of each control
             * Store inside the Answer List
             */
            if (userControl is TextBox textBox)
            {
                Answer answer = new Answer
                {
                    Question_Id = question.Question_Id,
                    QOption_Id = null,
                    QOption_TextBoxValue = textBox.Text.Trim()
                };
                answers.Add(answer);
            }

            else if (userControl is CheckBoxList checkBoxList)
            {
                foreach (ListItem item in checkBoxList.Items)
                {
                    if (item.Selected)
                    {
                        Answer answer = new Answer
                        {
                            Question_Id = question.Question_Id,
                            QOption_Id = int.Parse(item.Value),
                            QOption_TextBoxValue = null
                        };
                        answers.Add(answer);


                        if (item.Attributes[Constants.SESSION_NEXT_QUESTION_ID] != null)
                        {
                            int nextQuestionId = int.Parse(item.Attributes[Constants.SESSION_NEXT_QUESTION_ID]);
                            InsertCurrentQuestionToStack(nextQuestionId, followUpQuestionList);
                        }
                    }
                }
            }

            else if (userControl is DropDownList)
            {
                DropDownList dropdownList = (DropDownList)userControl;
                foreach (ListItem item in dropdownList.Items)
                {
                    if (item.Selected)
                    {
                        Answer answer = new Answer
                        {
                            Question_Id = question.Question_Id,
                            QOption_Id = int.Parse(item.Value),
                            QOption_TextBoxValue = null
                        };
                        answers.Add(answer);

                        if (item.Attributes[Constants.SESSION_NEXT_QUESTION_ID] != null)
                        {

                            int nextQuestionId = int.Parse(item.Attributes[Constants.SESSION_NEXT_QUESTION_ID]);
                            InsertCurrentQuestionToStack(nextQuestionId, followUpQuestionList);
                        }
                    }
                }
            }

            Session[Constants.SESSION_ANSWER_LIST] = answers;
     

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