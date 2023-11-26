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
    public partial class frm_invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rpt_invoices r = new rpt_invoices();
            r.SetParameterValue("sid", Session["ordid"]);
            CrystalReportViewer1.ReportSource = r;
        }

    

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Sample/index.html");

        }
    }
}
