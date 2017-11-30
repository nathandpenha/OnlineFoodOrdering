using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class order : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string str;
        int quant_avail;
        String id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["prn"] == null))
            {

                Response.Redirect("login.aspx");

            }
            else
            {
                Response.Write("Welcome " + Session["prn"].ToString());

            }

            id = Request.QueryString["id"];
            itemidLabel.Text = id;



            con = new MySqlConnection("Data Source=localhost;Database=canteen;User ID=root;Password=root");

            con.Open();
            cmd = new MySqlCommand("select * from menu where item_id="+id, con);
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                itemidLabel.Text = id;
                rd.Read();

                fooditemLabel.Text = rd["item_name"].ToString();
                rd.Read();

                priceLabel.Text = rd["price"].ToString();
                rd.Read();
                quant_avail =Int32.Parse(rd["quantity_available"].ToString());
            }

            if (quant_avail < 1) {
                orderButton.Enabled = false;
                notAvailLabel.Text = "The Item is Not Available Currently";
            }

            totalLabel.Text = priceLabel.Text;
            totalLabel.Text = (Int32.Parse(totalLabel.Text) * (Int32.Parse(quantityText.Text))).ToString();
            


            con.Close();
        }

        protected void quantityText_TextChanged(object sender, EventArgs e)
        {
            orderButton.Enabled = true;
            
            if (quant_avail < (Int32.Parse(quantityText.Text))) {
                orderButton.Enabled = false;
                notAvailLabel.Text = quantityText.Text + " " + fooditemLabel.Text + " Are not Available Currently";
            }

            totalLabel.Text = (Int32.Parse(priceLabel.Text) * (Int32.Parse(quantityText.Text))).ToString();
            

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            Session["Total"] = totalLabel.Text;
            Session["Quantity"] = quant_avail - (Int32.Parse(quantityText.Text));
            Session["ID"] = itemidLabel.Text;
            Response.Redirect("paymentmade.aspx");

        }





    }
}