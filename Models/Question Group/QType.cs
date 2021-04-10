using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models.Question_Group
{
 
    public class QType
    {
        [Key]
        public int QType_Id { get; set; }


        [Required]
        public string QType_Name { get; set; }


        public List<Question> Questions { get; set; }

        
    }
}