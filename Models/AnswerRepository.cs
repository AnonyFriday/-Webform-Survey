using SurveyWebform.Models.Question_Group;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveyWebform.Models
{
    public class AnswerRepository
    {
        private static readonly SurveyDbContext context = new SurveyDbContext();


        // Get all Answers
        public static List<Answer> GetAnswerList()
        {
            return (from answer in context.Answers
                    select answer).ToList();
        }



        // Insert Data Into Asnwers
        public static Boolean InsertAnswer(int questionId, int? qOptionId = null, string qOptionValueTextBox = null)
        {
            context.Answers.Add(new Answer()
            {
                Question_Id = questionId,
                QOption_Id = qOptionId,
                QOption_TextBoxValue = qOptionValueTextBox
            });
            var entity = context.SaveChanges();
            return entity > 0;
        }
    }
}