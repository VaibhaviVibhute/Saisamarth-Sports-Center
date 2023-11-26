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

namespace saisamarthsportscenter.Search
{
    public partial class CancleCartItem : System.Web.UI.Page
    {

        ArrayList idarray = new ArrayList();
        ArrayList nmarray = new ArrayList();
        ArrayList qtyarray = new ArrayList();
        ArrayList ratearray = new ArrayList();
        ArrayList cntarray = new ArrayList();
       // ArrayList gstarray = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            cntarray = (ArrayList)Session["cntarray"];
            idarray = (ArrayList)Session["idarray"];
            nmarray = (ArrayList)Session["nmarray"];
            ratearray = (ArrayList)Session["ratearray"];
            qtyarray = (ArrayList)Session["qtyarray"];
            //gstarray = (ArrayList)Session["gstarray"];


            if (Request.QueryString.ToString() != null)
            {
                int id = Convert.ToInt32(Request.QueryString["ID"]); //, Globalization.NumberStyles.Integer)

                cntarray.RemoveAt(id);
                idarray.RemoveAt(id);
                nmarray.RemoveAt(id);
                ratearray.RemoveAt(id);
                qtyarray.RemoveAt(id);
              //  gstarray.RemoveAt(id);

            }
            if (cntarray.Count == 0)
            {
                //Web_Fashion_line.Customer.web_item_details.cnt = 0;
            }



            Response.Redirect("~/Search/Showcart.aspx");
       

        }
    }
}
