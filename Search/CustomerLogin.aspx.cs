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


namespace saisamarthsportscenter.Search
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True ";
            cn.Open();
          
        }





        protected void btn_login_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Customer where cust_email='"
    + txt_user_nm.Text + "' and cust_pass='" + txt_user_pwd.Text + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("cid", dr[0]);
                Session.Add("cnm", dr[1]);

                MessageBox.Show("Login Successful");
                Response.Redirect("~/Search/CustDashboard.aspx");
            }
            else
            {
                MessageBox.Show("Login not Successful");
                txt_user_nm.Text = "";
                txt_user_pwd.Text = "";
            }
        }
    }
}
