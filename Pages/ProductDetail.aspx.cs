using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Pages_ProductDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if(!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
        int id = Convert.ToInt32(Request.QueryString["id"]);
       
        SqlConnection conn = new SqlConnection("Data Source=IMMORTAL-PC;Initial Catalog=StoreDB;Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM  dbo.tblProduct where dbo.tblProduct.proID =@proID", conn);
        cmd.Parameters.AddWithValue("@proID", id);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            lblTitle.Text = dr["proName"].ToString();
            lblDescription.Text = dr["proDesc"].ToString(); ;
            lblPrice.Text = "Price per unit:<br/>£ " + dr["proPrice"].ToString(); ;
            imgProduct_detail.ImageUrl = "~/Images/Products/" + dr["proImage"].ToString();
            lblItemNr.Text = dr["proID"].ToString();

            //Fill amount list with numbers 1-20
            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }

        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }
}