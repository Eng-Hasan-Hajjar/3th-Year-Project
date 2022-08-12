using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(IsPostBack)
        lblregistersuccess.Text="";

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=IMMORTAL-PC;Initial Catalog=StoreDB;Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from dbo.tblUser where dbo.tblUser.userLogName=@username and dbo.tblUser.userPassword=@password", conn);
        cmd.Parameters.AddWithValue("@username", txtuserlogin.Text);
        cmd.Parameters.AddWithValue("@password", txtpasslogin.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                Session["user"] = dr["userLogName"].ToString();
                //this is for User if its admin so We must take that into consideration
            }
            conn.Close();
            lblregistersuccess.Text = "login successfully";
            Response.Redirect("~/pages/Webshop.aspx");

        }
        else
            lblregistersuccess.Text = "incorrect username or password please try again";

    }
}