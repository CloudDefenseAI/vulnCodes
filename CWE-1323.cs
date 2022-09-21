using System;
using System.Web.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.Security;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.Caching;
using System.Web.Handlers;
using System.Web.Hosting;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Trace.IsEnabled = false;
        Trace.Warn("test", "test");
    }
}
