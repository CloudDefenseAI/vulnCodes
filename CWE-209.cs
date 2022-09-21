using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request["username"];
            string password = Request["password"];
            string email = Request["email"];
            // runn getUser from username, password
            if (getUser(username, password)['email'] != email)
            {
                Response.Write("Invalid username or password, please try again");
            }else{
                Response.Write("Welcome " + username);
            }
    }
}
