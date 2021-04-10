using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models.Account_Group
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }


        [MaxLength(50)]
        public string User_FirstNameee { get; set; }


        [MaxLength(50)]
        public string User_LastName { get; set; }


        [Required(AllowEmptyStrings = false)]
        public DateTime User_DateOfBirth { get; set; }


        [RegularExpression(@"\d{10}")]
        public string User_Phone { get; set; }
    }
}