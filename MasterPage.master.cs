using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("about.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("help.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        //Response.Redirect("news.aspx");
    }
}
