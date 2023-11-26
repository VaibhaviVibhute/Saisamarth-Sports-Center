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
    public partial class Sale_master : System.Web.UI.Page
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
            if (!IsPostBack)
            setdropdown();
            setgrid();
        }

        public void cleartext()
        {
            txt_sale_id.Text = " ";
            txt_sale_date.Text = " ";
            txt_gst.Text = " ";
            txt_grandtotal.Text = " ";
        }

        public void enabletext()
        {
            txt_sale_id.Enabled = true;
            txt_sale_date.Enabled = true;
            DropDownList1.Enabled = true;
            txt_gst.Enabled = true;
            txt_grandtotal.Enabled = true;
        }

        public void disabletext()
        {
            txt_sale_id.Enabled = false;
            txt_sale_date.Enabled = false;
            DropDownList1.Enabled = false;
            txt_gst.Enabled = false;
            txt_grandtotal.Enabled = false;
        }

        public void setgrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Sale_master ";
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
                cmd.CommandText = "insert into Sale_master values("+txt_sale_id.Text+",'"+txt_sale_date.Text+"',"+DropDownList1.SelectedValue+","+txt_gst.Text+","+txt_grandtotal.Text+")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted!");
            }

            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update Sale_master set sale_date='" + txt_sale_date.Text + "',cust_id="+ DropDownList1.SelectedValue+",gst="+ txt_gst.Text +",grandtotal="+ txt_grandtotal.Text +" where sale_id=" + txt_sale_id.Text;
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

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from Sale_master where sale_id=" + txt_sale_id.Text;
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
            txt_sale_id.Text = Convert.ToString(GetNewId());
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
            cmd.CommandText = "select Max(sale_id)from Sale_master";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;

            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_sale_id.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_sale_date.Text = GridView1.SelectedRow.Cells[2].Text;
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
            txt_gst.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_grandtotal.Text = GridView1.SelectedRow.Cells[5].Text;


            btn_new.Enabled = false;
            btn_update.Enabled = true;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            disabletext();
        }

        public void setdropdown()
        {
            cmd = new SqlCommand("select * from Customer", cn);

            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "cust_id";
            DropDownList1.DataTextField= "cust_nm";
            DropDownList1.DataBind();
            dr.Close();
        }
    }
}

