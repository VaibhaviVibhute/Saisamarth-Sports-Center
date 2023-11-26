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
    public partial class Customer : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        static int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True ";
            cn.Open();
            setgrid();
        }

        public void cleartext()
        {
            txt_cust_id.Text = " ";
            txt_cust_nm.Text = " ";
            txt_cust_addr.Text = " ";
            txt_cust_pincode.Text = " ";
            txt_cust_phone.Text = " ";
            txt_cust_email.Text = " ";
            txt_cust_pass.Text = " ";
        }

        public void enabletext()
        {
            txt_cust_id.Enabled = true;
            txt_cust_nm.Enabled = true;
            txt_cust_addr.Enabled = true;
            txt_cust_pincode.Enabled = true;
            txt_cust_phone.Enabled = true;
            txt_cust_email.Enabled = true;
            txt_cust_pass.Enabled = true;

        }

        public void disabletext()
        {
            txt_cust_id.Enabled = false;
            txt_cust_nm.Enabled = false;
            txt_cust_addr.Enabled = false;
            txt_cust_pincode.Enabled = false;
            txt_cust_phone.Enabled = false;
            txt_cust_email.Enabled = false;
            txt_cust_pass.Enabled = false;

        }

        public void setgrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Customer";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }


        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Customer values("
                    + txt_cust_id.Text + ",'"
                    + txt_cust_nm.Text + "','"
                    + txt_cust_addr.Text + "',"
                    + txt_cust_pincode.Text + ",'"
                    + txt_cust_phone.Text + "','"
                    + txt_cust_email.Text + "','"
                    + txt_cust_pass.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted!");
            }

            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update Customer set cust_nm='" + txt_cust_nm.Text + "',cust_addr='" + txt_cust_addr.Text + "',cust_pincode=" + txt_cust_pincode.Text + ",cust_phone=" + txt_cust_phone.Text + ",cust_email='" + txt_cust_email.Text + "',cust_pass='" + txt_cust_pass.Text + "' where cust_id=" + txt_cust_id.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated!");
            }

            btn_new.Enabled = true;
            btn_update.Enabled = false;
            btn_save.Enabled = false;
            btn_delete.Enabled = false;
            cleartext();
            setgrid();
            disabletext();
        }

        protected void btn_delete_Click1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from Customer where cust_id=" + txt_cust_id.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted!");


            btn_new.Enabled = true;
            btn_update.Enabled = false;
            btn_save.Enabled = false;
            btn_delete.Enabled = false;
            cleartext();
            setgrid();
            disabletext();
        }




        protected void btn_new_Click(object sender, EventArgs e)
        {
            flag = 1;
            enabletext();
            btn_new.Enabled = false;
            btn_save.Enabled = true;
            txt_cust_id.Text = Convert.ToString(GetNewId());
            GetNewId();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            flag = 2;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            enabletext();
        }

        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(cust_id)from Customer";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;

            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cust_id.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_cust_nm.Text = GridView1.SelectedRow.Cells[2].Text;
            txt_cust_addr.Text = GridView1.SelectedRow.Cells[3].Text;
            txt_cust_pincode.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_cust_phone.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_cust_email.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_cust_pass.Text = GridView1.SelectedRow.Cells[7].Text;

            btn_new.Enabled = false;
            btn_update.Enabled = true;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            disabletext();
        }

        
    }
}
