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
    public partial class frm_Sale_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rpt_Sale_details r = new rpt_Sale_details();
            CrystalReportViewer1.ReportSource = r;
        }
    }
}
