using SurveyWebform.Models.Question_Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models
{
    public class SurveyDbRepository
    {
        private static SurveyDbContext context = new SurveyDbContext();


        public static List<Question> GetQuestions()
        {
            return (from question in context.Questions
                    select question).ToList();
        }
    }
}