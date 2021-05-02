using SurveyWebform.Models.Session_Group;
using SurveyWebform.Ultilities;
using System;
using System.Web.UI.WebControls;

namespace SurveyWebform.Pages
{
    public partial class AdminLogin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                id_LabelStatus.Text = "";
            }
        }




        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            var username = id_LoginUserControl.UsernameTextBox.Trim();
            var password = id_LoginUserControl.PasswordTextBox.Trim();
            AuthenticateAdmin(username, password);
        }


        //! Didn't apply the FormAuthentication
        private void AuthenticateAdmin(string username, string password)
        {
            if (StaffRepository.AuthenticateStaff(username, password))
            {
                Response.Redirect(Constants.URL_ADMIN);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("There was somethingwrong. Please try again!");
                id_LabelStatus.Text = "Login fails. Please try again!";
                id_LoginUserControl.UsernameTextBox = String.Empty;
                id_LoginUserControl.PasswordTextBox = String.Empty;
            }
        }
    }
}