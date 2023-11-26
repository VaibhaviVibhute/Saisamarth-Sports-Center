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
    public partial class Product_master : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        static int flag = 0;
        static string filenm = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True";
            cn.Open();
            if (!IsPostBack)
                setdropdown();
            setgrid();
        }

        public void cleartext()
        {
            txt_prod_id.Text = " ";
            txt_prod_nm.Text = " ";
            txt_rate.Text = " ";
            txt_size.Text = " ";
            txt_stock.Text = " ";
            
        }

        public void enabletext()
        {
            txt_prod_id.Enabled = true;
            txt_prod_nm.Enabled = true;
            DropDownList1.Enabled = true;
            txt_rate.Enabled = true;
            DropDownList2.Enabled = true;
            txt_size.Enabled = true;
            txt_stock.Enabled = true;
            
        }

        public void disabletext()
        {
            txt_prod_id.Enabled = false;
            txt_prod_nm.Enabled = false;
            DropDownList1.Enabled = false;
            txt_rate.Enabled = false;
            DropDownList2.Enabled = false;
            txt_size.Enabled = false;
            txt_stock.Enabled = false;
            

        }

        public void setgrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Product_master";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
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
            cmd.CommandText = "select Max(prod_id)from Product_master";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;

            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_prod_id.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_prod_nm.Text = GridView1.SelectedRow.Cells[2].Text;
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
            txt_rate.Text = GridView1.SelectedRow.Cells[4].Text;
            DropDownList2.SelectedItem.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_size.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_stock.Text = GridView1.SelectedRow.Cells[7].Text;
            

            btn_new.Enabled = false;
            btn_update.Enabled = true;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            disabletext();
        }

        public void setdropdown()
        {
            cmd = new SqlCommand("select * from Product_category", cn);

            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataTextField = "cat_nm";
            DropDownList1.DataBind();
            dr.Close();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Product_master values(" + txt_prod_id.Text + ",'" + txt_prod_nm.Text + "'," + DropDownList1.SelectedValue + "," + txt_rate.Text + ",'" + DropDownList2.SelectedItem + "','" + txt_size.Text + "'," + txt_stock.Text + ",'" + filenm + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted!");
            }

            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update Product_master set prod_nm='" + txt_prod_nm.Text + "',cat_id=" + DropDownList1.SelectedValue + ",rate=" + txt_rate.Text + ",gender='" + DropDownList2.SelectedItem + "',size='" + txt_size.Text + "',stock=" + txt_stock.Text + ",photo='" + filenm + "' where prod_id=" + txt_prod_id.Text ;
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
            cmd.CommandText = "delete from Product_master where prod_id=" + txt_prod_id.Text;
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

        protected void btn_new_Click1(object sender, EventArgs e)
        {
            flag = 1;
            enabletext();
            btn_new.Enabled = false;
            btn_save.Enabled = true;
            txt_prod_id.Text = Convert.ToString(GetNewId());
            GetNewId();

        }



       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                string basedir = Server.MapPath("~/Upload/");
                filenm = FileUpload1.FileName;
                FileUpload1.SaveAs(basedir + FileUpload1.FileName);
                Image1.ImageUrl = "~/Upload/" + FileUpload1.FileName;

            }
            else
            {
                MessageBox.Show("You must selected photo");
            }

        }
  }

    
 }     
 
    

