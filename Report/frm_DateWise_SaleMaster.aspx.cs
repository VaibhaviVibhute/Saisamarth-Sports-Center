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
    public partial class frm_DateWise_SaleMaster : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            rpt_Sale_Master r = new rpt_Sale_Master();
            CrystalReportViewer1.SelectionFormula = "{Sale_master.sale_date}>='" + Calendar1.SelectedDate.ToString() + "' and {Sale_master.sale_date}<='" + Calendar2.SelectedDate.ToString() + "'";
            CrystalReportViewer1.ReportSource = r;
        }
    }
}

