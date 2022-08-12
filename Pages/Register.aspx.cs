using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        lblregstatus.Text = "";
        
    }
    protected void btnregister_Click(object sender, EventArgs e)
    {
        lblregstatus.Text = "";
        DateTime currenttime = DateTime.Now;
        string userregdate = currenttime.ToString("yyyy-MM-dd HH:mm:ss");
        SqlConnection conn = new SqlConnection("Data Source=IMMORTAL-PC;Initial Catalog=StoreDB;Integrated Security=True");

        conn.Open();
        bool exists = false;

        // create a command to check if the username exists
        SqlCommand cmd = new SqlCommand("select count(*) from dbo.tblUser where dbo.tblUser.userLogName = @userLogName", conn);
        cmd.Parameters.AddWithValue("@userLogName", txtlogname.Text);
        exists = (int)cmd.ExecuteScalar() > 0;
        

        // if exists, show a message error
        if (exists)
        {
        lblregstatus.Text = "This username has been using by another user.";
        conn.Close();
        }
        else
        {
            // does not exists, so, persist the user
        string query = string.Format("insert into dbo.tblUser (userLogName,userFName,userLName,userPassword,userEmail,userRegDate)values('"+txtlogname.Text+"','"+txtfname.Text+"','"+txtlname.Text+"','"+txtpassword.Text+"','"+txtemail.Text+"','"+userregdate+"')");
        cmd = new SqlCommand(query,conn);    
        cmd.ExecuteNonQuery();
        lblregstatus.Text = "Registeration successful!";

        }


    }


}      
  


       

        

