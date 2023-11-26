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

namespace saisamarthsportscenter.Report
{
    public partial class frm_DateWise_Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            rpt_Payment r = new rpt_Payment();
            CrystalReportViewer1.SelectionFormula = "{Payment.pay_date}>='" + Calendar1.SelectedDate.ToString() + "' and {Payment.pay_date}<='" + Calendar2.SelectedDate.ToString() + "'";
            CrystalReportViewer1.ReportSource = r;
        }
    }
}
