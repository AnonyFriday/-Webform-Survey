using SurveyWebform.Models.Question_Group;
using System.Collections.Generic;
using System.Linq;

namespace SurveyWebform.Models
{
    public class RespondentRepository
    {
        SurveyDbContext context = new SurveyDbContext();

        public List<Respondent> GetAllRespondents()
        {
            return (from respondent in context.Respondents
                    select respondent).ToList();
        }
    }
}