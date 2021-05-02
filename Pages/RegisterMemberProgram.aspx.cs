using SurveyWebform.Models;
using SurveyWebform.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebform.Pages
{
    public partial class RegisterMemberProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            var fName = id_RegisterMembershipUserControl.TextBoxFirstName.Trim();
            var lName = id_RegisterMembershipUserControl.TextBoxLastName.Trim();
            var phone = id_RegisterMembershipUserControl.TextBoxPhone.Trim();
            var dob = id_RegisterMembershipUserControl.TextBoxDOB;
            RegisterMember(fName, lName, dob, phone);
        }


        private void RegisterMember(string fName, string lName, DateTime dob, string phone)
        {
            if (UserRepository.InsertUser(fName, lName, dob, phone))
            {
                Response.Redirect(Constants.URL_WELCOME);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("There was somethingwrong. Please try again!");
                id_LabelStatus.Text = "Register fails. Please try again!";
                id_RegisterMembershipUserControl.TextBoxFirstName = String.Empty;
                id_RegisterMembershipUserControl.TextBoxLastName = String.Empty;
                id_RegisterMembershipUserControl.TextBoxDOB = DateTime.Now;
                id_RegisterMembershipUserControl.TextBoxPhone = String.Empty;
            }
        }
    }
}