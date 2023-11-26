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
    public partial class Searchbycat : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr1;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True";
            cn.Open();
            if (!IsPostBack)
                setdropdown();
        }
        public void setdropdown()
        {
            cmd = new SqlCommand("select * from Product_Category", cn);
            dr1 = cmd.ExecuteReader();
            DropDownList1.DataSource = dr1;
            DropDownList1.DataValueField ="cat_id";
            DropDownList1.DataTextField ="cat_nm";
            DropDownList1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Product_master where cat_id=" + DropDownList1.SelectedValue + "", cn);
            dr1 = cmd.ExecuteReader();
            int cnt = 1;

             while (dr1.Read())
                {
                    cnt++;
                }
                dr1.Close();
                cmd = new SqlCommand("SELECT * FROM Product_master where cat_id=" + DropDownList1.SelectedValue + "", cn);
                dr1 = cmd.ExecuteReader();
                int i;
                Literal lit1, lit2, lit3, lit4, lit5;
                lit1 = new Literal();
                lit2 = new Literal();
                lit3 = new Literal();
                lit4 = new Literal();
                lit5 = new Literal();

                lit1.Text = "<table class='table'>";
                lit2.Text = "<tr>";
                lit3.Text = "<td>";
                lit4.Text = "</td>";
                lit5.Text = "</tr>";
                PlaceHolder1.Controls.Add(new LiteralControl("<table class='table'><br>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<tr>"));
                int j;
                for (i = 0; i < cnt; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        if (dr1.Read())
                        {
     PlaceHolder1.Controls.Add(new LiteralControl("<td>"));
PlaceHolder1.Controls.Add(new LiteralControl("<a href=SearchDetails.aspx?ID=" + dr1[0].ToString() +
                "><img src='../Upload/" + dr1[7].ToString() 
                   + "' style='height:250px;width:250px;' ></img></a><br>"));
  PlaceHolder1.Controls.Add(new LiteralControl("<font color=orange size=4>" + dr1[1].ToString() + "</font>"));
  PlaceHolder1.Controls.Add(new LiteralControl("</a><br>"));
    PlaceHolder1.Controls.Add(new LiteralControl("<font color=orange size=4>" + ("Rs.") + "</font>"));
    PlaceHolder1.Controls.Add(new LiteralControl("<font color=orange size=4>" + dr1[3].ToString() + "/-</font>"));
                         PlaceHolder1.Controls.Add(new LiteralControl("</center></td>"));
                        }
    
                    }
                    PlaceHolder1.Controls.Add(new LiteralControl("</tr>"));

                }

                

            }
        }
    }

