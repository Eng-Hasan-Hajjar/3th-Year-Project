using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_Webshop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int i;
        int.TryParse(ddlcategory.SelectedValue, out i);


        SqlConnection conn = new SqlConnection("Data Source=IMMORTAL-PC;Initial Catalog=StoreDB;Integrated Security=True");
        conn.Open();

        SqlCommand cmd = new SqlCommand("SELECT * FROM  dbo.tblProduct where dbo.tblProduct.catID =@catID", conn);
        cmd.Parameters.AddWithValue("@catID", i);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        Panel products_panel = new Panel();
        while (dr.Read())
        {

            Label product_name = new Label();
            Label product_price = new Label();
            product_name.CssClass = "product_name_css";
            product_name.Text = dr["proName"].ToString();
            product_price.CssClass = "product_price_css";
            product_price.Text = dr["proPrice"].ToString()+"$";
            ImageButton product_img = new ImageButton();
            product_img.ImageUrl = "~/Images/products/" + dr["proImage"].ToString();
            product_img.CssClass = "product_img_css";
            product_img.PostBackUrl = "~/Pages/ProductDetail.aspx?id="+dr["proID"].ToString();

            products_panel.Controls.Add(product_img);
            products_panel.Controls.Add(new Literal {Text = "<br/>" });
            products_panel.Controls.Add(product_name);
            products_panel.Controls.Add(new Literal { Text = "<br/>" });
            products_panel.Controls.Add(product_price);
            products_panel.Controls.Add(new Literal { Text = "<br/>" });


            productpnl.Controls.Add(products_panel);
            productpnl.CssClass = "panel_css";
        }
        conn.Close();
        
    }
}