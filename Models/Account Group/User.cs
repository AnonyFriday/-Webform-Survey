using SurveyWebform.Models.Question_Group;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurveyWebform.Models.Account_Group
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }


        [MaxLength(50)]
        public string User_FirstName { get; set; }


        [MaxLength(50)]
        public string User_LastName { get; set; }


        [Required(AllowEmptyStrings = false)]
        public DateTime User_DateOfBirth { get; set; }


        [RegularExpression(@"\d{12}")]
        public string User_Phone { get; set; }


        // Relationship
        public List<Respondent> Respondents { get; set; }
    }
}