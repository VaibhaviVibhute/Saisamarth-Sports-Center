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


namespace saisamarthsportscenter.Report
{
    public partial class frm_Salewisepayment : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=JANHAVI;Initial Catalog=saisamarthdb;Integrated Security=True";
            cn.Open();
            if (!IsPostBack)
            setdropdown();
        }
        //protected void btn_show_Click(object sender, EventArgs e)
        //{
        //    rpt_Payment r = new rpt_Payment();
        //    CrystalReportViewer1.SelectionFormula = "{Payment.sale_id}=" + DropDownList1.SelectedValue + "";
        //    CrystalReportViewer1.ReportSource = r;
        //}
        public void setdropdown()
        {
            cmd = new SqlCommand("select * from Sale_master", cn);

            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "sale_id";
            DropDownList1.DataTextField = "sale_id";
            DropDownList1.DataBind();
            dr.Close();
        }

        protected void btn_show_Click1(object sender, EventArgs e)
        {
            rpt_Payment r = new rpt_Payment();
            CrystalReportViewer1.SelectionFormula = "{Payment.sale_id}=" + DropDownList1.SelectedValue + "";
            CrystalReportViewer1.ReportSource = r;

        }

       
    }
}
