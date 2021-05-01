using System;
using System.Web.UI.WebControls;

namespace SurveyWebform.UserControls
{
    public partial class QuestionUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        public void NextQuestionButtonClick(object sender, EventArgs e)
        {

        }

        public string HeaderQuestionTitle
        {
            get
            {
                return id_headerQuestionTitle.InnerText;
            }
            set
            {
                id_headerQuestionTitle.InnerText = value;
            }
        }

        public PlaceHolder PlaceHolderControls
        {
            get
            {
                return id_placeholderControl;
            }
        }
    }
}