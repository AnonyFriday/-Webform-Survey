using SurveyWebform.Models.Account_Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models
{
    public class UserRepository
    {
        private static readonly SurveyDbContext context = new SurveyDbContext();


        // Get all User
        public static List<User> GetAnswerList()
        {
            return (from User in context.Users
                    select User).ToList();
        }



        // Insert Data Into User Table
        public static Boolean InsertUser(string firstName, string lastName, DateTime dob, string phone)
        {
            // Santize data efore inserting into database
            context.Users.Add(new User()
            {
                User_FirstName = firstName,
                User_LastName  = lastName,
                User_DateOfBirth = dob,
                User_Phone     = phone
            });
            var entity = context.SaveChanges();
            return entity > 0;
        }
    }
}