using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indexer_example
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            company Comp = new company();
            Response.Write("Names before change");
            Response.Write("<br/>");
            Response.Write("Name of the Employee with ID:2 - " +Comp[2]);
            Response.Write("<br/>");
            Response.Write("Name of the Employee with ID:5 - " + Comp[5]);
            Response.Write("<br/>");
            Response.Write("Name of the Employee with ID:7 - " + Comp[7]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Changing the Names of Employee with ID = 2,5,8");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Comp[2] = "2nd Employee name changed";
            Comp[5] = "5th Employee name changed";
            Comp[7] = "7th Employee name changed";
            Response.Write("Names after change");
            Response.Write("<br/>");
            Response.Write("Name of the Employee with ID:2 - " + Comp[2]);
            Response.Write("<br/>");
            Response.Write("Name of the Employee with ID:5 - " + Comp[5]);
            Response.Write("<br/>");
            Response.Write("Name of the Employee with ID:7 - " + Comp[7]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            Response.Write("Each Employee gender before change");
            Response.Write("<br/>");
            Response.Write("Employee 2nd gender : "+Comp[1, "Female"]);
            Response.Write("<br/>");
            Comp[1, "Female"] = "Male";
            Response.Write("Each Employee gender after change");
            Response.Write("<br/>");
            Response.Write("Employee 2nd gender : " + Comp[1, "Female"]);

        }
    }
}
