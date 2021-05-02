using SurveyWebform.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebform.UserControls
{
    public partial class RegisterMembershipUserControl : System.Web.UI.UserControl
    {

        // Text Box DOB
        public DateTime TextBoxDOB
        {
            get
            {
                return DateTime.Parse(id_TextBoxDOB.Text);
            }
            set
            {

                id_TextBoxDOB.Text = DateTimeConverter.shared.ConvertDateToString(value);
            }
        }


        // Text Box First Name
        public string TextBoxFirstName
        {
            get
            {
                return id_TextBoxFirstName.Text;
            }
            set
            {

                id_TextBoxFirstName.Text = value;
            }
        }

        // Text Box Last Name
        public string TextBoxLastName
        {
            get
            {
                return id_TextBoxLastName.Text;
            }
            set
            {
                id_TextBoxLastName.Text = value;
            }
        }

        // Text Box Phone
        public string TextBoxPhone
        {
            get
            {
                return id_TextBoxPhone.Text;
            }
            set
            {
                //Format:  +123456789
                var isPhone = Regex.Match(value, @"^(\[0-9])$").Success;
                if (!isPhone)
                {
                    // Check if that's not a number
                    // Will implement a Validation
                    id_TextBoxPhone.Text = "";
                }
                else
                {
                    id_TextBoxPhone.Text = value;
                }

            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // DOB Calendar
        protected void CalendarDOB_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxDOB = id_CalendarDOB.SelectedDate;
            System.Diagnostics.Debug.WriteLine(TextBoxDOB);
        }
    }
}