using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models.Session_Group
{
    public class StaffRepository
    {
        private static readonly SurveyDbContext context = new SurveyDbContext();

        // Select Staff where password and username
        public static Boolean AuthenticateStaff(string username, string password)
        {

            if (String.IsNullOrEmpty(username.Trim()) && String.IsNullOrEmpty(password.Trim()))
            {
                return false;
            }
            else
            {
                var isAuthenticate = (from staff in context.Staffs
                                      where staff.Staff_Password == password.Trim() && staff.Staff_Username == username.Trim()
                                      select staff).FirstOrDefault();

                return isAuthenticate != null;
            }


        }

    }
}