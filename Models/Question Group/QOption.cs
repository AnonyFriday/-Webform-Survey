using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyWebform.Models.Question_Group
{
    public class QOption
    {
        [Key]
        public int QOption_Id { get; set; }


        [Required]
        public string QOption_Name { get; set; }





        [ForeignKey("Questions")]
        public int? Question_Id { get; set; }
        public Question Questions { get; set; }



        [ForeignKey("Next_Question")]
        public int? Next_Question_Id { get; set; }
        public virtual Question Next_Question { get; set; }




        public List<Answer> Answers { get; set; }
    }
}