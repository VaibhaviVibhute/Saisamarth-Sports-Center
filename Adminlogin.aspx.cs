using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace saisamarthsportscenter
{
    public partial class Adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_un.Text == "Admin" && txt_pass.Text == "123")
            {
                MessageBox.Show("Login Success");
                Response.Redirect("~/Dashboard.aspx");

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
