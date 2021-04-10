using SurveyWebform.Models.Question_Group;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models.Session_Group
{
    public class Session
    {
        [Key]
        public int Session_Id { get; set; }


        [Required]
        public int Respondent_Id { get; set; }
        public Respondent Respondents { get; set; }


        public DateTime Session_CreatedAt { get; set; }

        public String Session_IpAddress { get; set; }

    }
}