using SurveyWebform.Models.Question_Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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