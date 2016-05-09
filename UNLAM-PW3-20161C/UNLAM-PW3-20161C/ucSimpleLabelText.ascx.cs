using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class ucSimpleLabelText : System.Web.UI.UserControl
    {
        public string textoLabel
        {
            get { return lblTextBox.Text; }
            set { lblTextBox.Text = value; }
        }
        public string textoTextbox
        {
            get { return txtBox.Text;}
            set { txtBox.Text = value;}
        }

        public TextBoxMode TextMode 
        { 
            set { txtBox.TextMode = value; } 
        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }
    }
}