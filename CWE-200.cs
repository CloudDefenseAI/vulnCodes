using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = Request["username"];
        string password = Request["password"];
        string callback = Request["callback"];
        string token = FormsAuthentication.HashPasswordForStoringInConfigFile(username + password, "SHA1");
        Response.Redirect(callback + "?token=" + token);
    }
}
