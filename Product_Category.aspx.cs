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
    public partial class Product_Catrgory : System.Web.UI.Page
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
            txt_cat_id.Text = " ";
            txt_cat_nm.Text = " ";
        }

        public void enabletext()
        {
            txt_cat_id.Enabled =true; 
            txt_cat_nm.Enabled = true;
           
        }

        public void disabletext()
        {
            txt_cat_id.Enabled = false;
            txt_cat_nm.Enabled = false; 

        }

        public void setgrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Product_Category";
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
                cmd.CommandText = "insert into Product_Category values(" + txt_cat_id.Text + ",'" + txt_cat_nm.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted!");
            }

            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update Product_Category set cat_nm='" + txt_cat_nm.Text+"' where cat_id=" + txt_cat_id.Text;
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
            cmd.CommandText = "delete from Product_Category where cat_id=" + txt_cat_id.Text;
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
            btn_save.Enabled =true;
            txt_cat_id.Text = Convert.ToString(GetNewId());
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
            cmd.CommandText = "select Max(cat_id)from Product_Category";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;

            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cat_id.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_cat_nm.Text = GridView1.SelectedRow.Cells[2].Text;

            btn_new.Enabled = false;
            btn_update.Enabled = true;
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            disabletext();
        }
        
        }



}
