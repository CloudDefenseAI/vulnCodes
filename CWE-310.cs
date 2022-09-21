using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        string insertQuery = "insert into Table1 (username, password) values (@username, @password)";
        SqlCommand com = new SqlCommand(insertQuery, con);
        com.Parameters.AddWithValue("@username", TextBox1.Text);
        com.Parameters.AddWithValue("@password", TextBox2.Text);
        com.ExecuteNonQuery();
        Response.Write("Registration is successful");
        con.Close();
    }
}
