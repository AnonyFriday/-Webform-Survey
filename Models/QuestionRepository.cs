using SurveyWebform.Models.Question_Group;
using System.Collections.Generic;
using System.Linq;

namespace SurveyWebform.Models
{
    public class QuestionRepository
    {
        private static readonly SurveyDbContext context = new SurveyDbContext();

        // Get all Questions
        public static List<Question> GetQuestionList()
        {
            return (from question in context.Questions
                    select question).ToList();
        }


        // Get Question by Id
        public static Question GetQuestionById(int questionId)
        {
            return (from question in context.Questions
                    where question.Question_Id == questionId
                    select question).SingleOrDefault();
        }


        // Get List of QOption by current Question
        public static List<QOption> GetQOptionByQuestionId(int questionId)
        {
            return (from option in context.QOptions
                    where option.Question_Id == questionId
                    select option).ToList();
        }


        // Get QType by current Question
        public static QType GetQTypeByQuestionId(int questionId)
        {
            int? qTypeId = (from question in context.Questions
                            where question.Question_Id == questionId
                            select question.QType_Id).SingleOrDefault();

            QType questionType = (from qType in context.QTypes
                                  where qType.QType_Id == qTypeId
                                  select qType).SingleOrDefault();

            return qTypeId == null ? null : questionType;
        }


        // Get Next Question Based on Current Question Id and Current QOption Id
        // Example: Q: 6 QO: 20
        public static Question GetNextQuestion(int currentQuestionId, int currentQOptionId)
        {
            int? nextQuestionId = (from qOption in context.QOptions
                                   where qOption.Question_Id == currentQuestionId && qOption.QOption_Id == currentQOptionId
                                   select qOption.Next_Question_Id).SingleOrDefault();

            return nextQuestionId == null ? null : GetQuestionById((int)nextQuestionId);
        }



    }
}