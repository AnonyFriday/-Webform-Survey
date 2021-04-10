using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models.Question_Group
{
    public class Answer
    {
        [Key]
        public int Answer_Id { get; set; }


        [Required]
        [ForeignKey("QOptions")]
        public int QOption_Id { get; set; }
        public QOption QOptions { get; set; }


        [Required]
        [ForeignKey("Questions")]
        public int Question_Id { get; set; }
        public Question Questions { get; set; }



        // Relationship
        public List<Respondent> Respondents { get; set; }
    }
}