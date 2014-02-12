using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonalWeb.Business;

namespace PersonalWebsite
{
    public partial class Three : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetCustomer_Click(object sender, EventArgs e)
        {
            int CustID;
            Int32.TryParse(TxtCustomer.Text, out CustID);
            Customer objCustomer = new Customer();
            lblLabel.Text = objCustomer.GetCustomerFullNamE(CustID);
        }
    }
}