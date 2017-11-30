using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace WebApplication1
{
    public partial class paymentmade : System.Web.UI.Page
    {
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

            MySqlConnection con;
            MySqlCommand cmd;
            string str;
            int balance=0;


            con = new MySqlConnection("Data Source=localhost;Database=canteen;User ID=root;Password=root");

            con.Open();
            cmd = new MySqlCommand("select balance from student where prn=" + Session["prn"].ToString(), con);
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                balance = Int32.Parse(rd["balance"].ToString());
                rd.Read();
            }
            con.Close();

            int totalcost =Int32.Parse( Session["Total"].ToString());

            if (totalcost > balance)
            {

                lowBalLabel.Text = "Your Balance is too low for this transaction, Kindly refill your account";

            }
            else
            {
                con.Open();

                balance = balance - totalcost;

                cmd = new MySqlCommand("update student set balance="+ balance +"  where prn=" + Session["prn"].ToString(), con);
                cmd.ExecuteNonQuery();
                lowBalLabel.Text = "Transaction Successful, your balance is " + balance;
                con.Close();

                con.Open();

                balance = balance - totalcost;

                cmd = new MySqlCommand("update menu set quantity_available=" + (Session["Quantity"].ToString()) + "  where item_id=" + Session["ID"].ToString(), con);
                cmd.ExecuteNonQuery();
                con.Close();
                Session["Quantity"] = null;
                Session["ID"] = null;
            }


        }
    }
}