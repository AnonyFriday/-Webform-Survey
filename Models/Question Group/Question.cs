using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyWebform.Models.Question_Group
{
    public class Question
    {
        [Key]
        public int Question_Id { get; set; }


        [Required]
        public string Question_Name { get; set; }


        // Relationship
        [Required]
        [ForeignKey("QTypes")]
        public int QType_Id { get; set; }
        public QType QTypes { get; set; }


        [ForeignKey("Next_Question_In_The_Stack")]
        public int? Next_Question_Id { get; set; }
        public Question Next_Question_In_The_Stack { get; set; }



        public List<Answer> Answers { get; set; }

        public List<Respondent> Respondents { get; set; }


        [InverseProperty("Questions")]
        public List<QOption> Question_Options { get; set; }


        [InverseProperty("Next_Question")]
        public List<QOption> Next_Question_Options { get; set; }
    }
}