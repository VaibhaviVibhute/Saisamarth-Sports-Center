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
    public partial class SearchDetails : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr1;
        int stock = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True";
            cn.Open();
            String id = Request.QueryString["ID"];
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from  product_master where prod_id=" +id;
            dr1 = cmd.ExecuteReader();

            int cnt = 1;

            while (dr1.Read())
            {
                cnt++;
            }
            dr1.Close();


            cmd = new SqlCommand("select * from product_master where prod_id= "+id, cn);
            dr1 = cmd.ExecuteReader();
            int i;
            Literal l1;
            Image i1;
            HyperLink h1;
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table'>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<tr>"));
            int j;
            for (i = 0; i < cnt; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    if (dr1.Read())
                    {
                        PlaceHolder1.Controls.Add(new LiteralControl("<td align=center>"));
                        l1 = new Literal();
                        i1 = new Image();
                        h1 = new System.Web.UI.WebControls.HyperLink();

                        i1.Height = 500;
                        i1.Width = 500;
                        i1.ImageUrl = "~/Upload/" + dr1.GetString(7);
                        l1.Text = "<br>";
                        PlaceHolder1.Controls.Add(i1);
                        PlaceHolder1.Controls.Add(new LiteralControl("</td><td align=left>"));
                        PlaceHolder1.Controls.Add(l1);
                           
                        PlaceHolder1.Controls.Add(h1);

                        PlaceHolder1.Controls.Add(new LiteralControl("<h1>" + dr1.GetString(1) + "</h1>"));
                        
                        PlaceHolder1.Controls.Add(new LiteralControl("<h2>Rate:" + dr1.GetInt32(3) + "</h2>"));
                        PlaceHolder1.Controls.Add(new LiteralControl("<h2>Gender:" + dr1.GetString(4) + "</h2>"));
                        PlaceHolder1.Controls.Add(new LiteralControl("<h2>Size:" + dr1.GetString(5) + "</h2>"));
                        PlaceHolder1.Controls.Add(new LiteralControl("<h2>Stock:" + dr1.GetInt32(6) + "</h2>"));
                        
                        Session["prod_id"] = dr1[0];
                        Session["prod_nm"] = dr1[1];
                        Session["rate"] = dr1[3];
                        stock=Convert.ToInt32(dr1[6].ToString());
                        PlaceHolder1.Controls.Add(new LiteralControl("<br>"));
                        PlaceHolder1.Controls.Add(new LiteralControl("</td>"));
                    }

                }// ending j loop
                PlaceHolder1.Controls.Add(new LiteralControl("</tr>"));

            }//ending i loop

            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            dr1.Close();

            if(!IsPostBack)
                    setQty();
        }
        static int rate;
        static int prodid;
        static int qty;
        static int cnt;
        static ArrayList idarray = new ArrayList();
        static ArrayList nmarray = new ArrayList();
        static ArrayList qtyarray = new ArrayList();
        static ArrayList ratearray = new ArrayList();
        static ArrayList cntarray = new ArrayList();

        public void setQty()
        {
            for (int i = 1; i <=stock; i++)
                DropDownList1.Items.Add(Convert.ToString(i));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cnt = cnt + 1;
            idarray.Add(Session["prod_id"]);
            Session.Add("idarray", idarray);


            nmarray.Add(Session["prod_nm"]);
            Session.Add("nmarray", nmarray);


            ratearray.Add(Session["rate"]);
            Session.Add("ratearray", ratearray);


            Session.Add("qty", DropDownList1.SelectedValue);
            qtyarray.Add(Session["qty"]);
            Session.Add("qtyarray", qtyarray);
            
            Session.Add("cnt", cnt);
            cntarray.Add(Session["cnt"]);
            Session.Add("cntarray", cntarray);
            Response.Redirect("~/Search/ShowCart.aspx");
        }

 

        }
    
}
