using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Request.QueryString["name"];
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from sysobjects where name = @name", con);
        cmd.Parameters.AddWithValue("@name", name);
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();
    }
}
