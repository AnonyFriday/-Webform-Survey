using SurveyWebform.Models.Account_Group;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyWebform.Models.Question_Group
{
    public class Respondent
    {
        [Key]
        public int Respondent_Id { get; set; }


        [Required]
        [ForeignKey("Questions")]
        public int? Question_Id { get; set; }
        public Question Questions { get; set; }


        [ForeignKey("Users")]
        public int? User_Id { get; set; }
        public User Users { get; set; }


        [Required]
        [ForeignKey("Answers")]
        public int? Answer_Id { get; set; }
        public Answer Answers { get; set; }
    }
}