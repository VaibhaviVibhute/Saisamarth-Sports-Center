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
    public partial class Sale_details : System.Web.UI.Page
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
            setdropdown1();
            if(!IsPostBack)
            setdropdown2();
            
            setgrid();
        }

        public void cleartext()
        {
            txt_sale_det_id.Text = " ";
            txt_rate.Text = " ";
            txt_qty.Text = " ";
            txt_amt.Text = " ";
        }

        public void enabletext()
        {
            txt_sale_det_id.Enabled = true;
            DropDownList1.Enabled= true;
            DropDownList2.Enabled = true;
            txt_rate.Enabled = true;
            txt_qty.Enabled = true;
            txt_amt.Enabled = true;
        }

        public void disabletext()
        {
            txt_sale_det_id.Enabled = false;
            DropDownList1.Enabled= false;
            DropDownList2.Enabled = false;
            txt_rate.Enabled = false;
            txt_qty.Enabled = false;
            txt_amt.Enabled = false;
        }

        public void setgrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Sale_details ";
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
                cmd.CommandText = "insert into Sale_details values(" + txt_sale_det_id.Text + ","+DropDownList1.SelectedValue+"," + DropDownList2.SelectedValue + "," + txt_rate.Text + "," + txt_qty.Text + ","+ txt_amt.Text +")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted!");
            }

            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update Sale_details set sale_id=" + DropDownList1.SelectedValue +",prod_id=" + DropDownList2.SelectedValue + ",rate=" + txt_rate.Text + ",qty=" + txt_qty.Text + ",amt="+txt_amt.Text+" where sale_det_id=" + txt_sale_det_id.Text;
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
            cmd.CommandText = "delete from Sale_details where sale_det_id=" + txt_sale_det_id.Text;
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
            txt_sale_det_id.Text = Convert.ToString(GetNewId());
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
            cmd.CommandText = "select Max(sale_det_id)from Sale_details";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;

            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_sale_det_id.Text = GridView1.SelectedRow.Cells[1].Text;
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
            DropDownList2.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
            txt_rate.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_qty.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_amt.Text = GridView1.SelectedRow.Cells[6].Text;

            btn_new.Enabled = false;
            btn_update.Enabled = true;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            disabletext();
        }

        public void setdropdown1()
        {
            cmd = new SqlCommand("select * from Sale_master", cn);
         
            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "sale_id";
            DropDownList1.DataTextField = "sale_date";
          
            DropDownList1.DataBind();
            
            dr.Close();
        }

        public void setdropdown2()
        {
            
            cmd = new SqlCommand("select * from Product_master", cn);
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;

            DropDownList2.DataValueField = "prod_id";
            DropDownList2.DataTextField = "prod_nm";
         
            DropDownList2.DataBind();
            dr.Close();
        }
  
    }
}
