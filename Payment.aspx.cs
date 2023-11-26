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
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        static int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True";
            cn.Open();

            txt_pay_date.Text = System.DateTime.Now.ToString();
            txt_pay_amt.Text = Session["grand"].ToString();
            txt_pay_id.Text = Convert.ToString(GetNewId());
          
            TextBox1.Text = Session["cnm"].ToString();
                    }

        public void cleartext()
        {
            txt_pay_id.Text = " ";
            txt_pay_date.Text = " ";
            txt_pay_amt.Text = " ";
       
        }

        public void enabletext()
        {
            txt_pay_id.Enabled = true;
            txt_pay_date.Enabled = true;
            //DropDownList1.Enabled = true;
            txt_pay_amt.Enabled = true;
        }

        public void disabletext()
        {
            txt_pay_id.Enabled = false;
            txt_pay_date.Enabled = false;
          //  DropDownList1.Enabled = false;
            txt_pay_amt.Enabled = false;
        }

       

        protected void btn_save_Click(object sender, EventArgs e)
        {
              cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Payment values(" 
                    + txt_pay_id.Text + ",'" + txt_pay_date.Text 
                    + "'," + Session["cid"] + "," + txt_pay_amt.Text + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted!");
                Response.Redirect("~/Report/frm_invoice.aspx");
            
           
        }

        
       









































        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(pay_id) from Payment";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;

            else
                return (Convert.ToInt32(x) + 1);
        }

       
       
    }
}
