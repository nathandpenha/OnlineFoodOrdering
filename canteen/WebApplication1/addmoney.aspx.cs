using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class addmoney : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(Session["prn"].ToString()) != 0)
                {
                    Response.Redirect("login.aspx");

                }
            }catch(Exception ex){
                Response.Write(ex.ToString());
                Response.Redirect("login.aspx");
            }
        }
        protected void checkBalance_Click(object sender, EventArgs e)
        {

            con = new MySqlConnection("Data Source=localhost;Database=canteen;User ID=root;Password=root");

            con.Open();
            cmd = new MySqlCommand("select balance from student where prn=" + prnText.Text.ToString(), con);
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                balanceLabel.Text ="Balance :  "+ rd["balance"].ToString();
            }
            con.Close();
        }

        protected void refillButton_Click(object sender, EventArgs e)
        {
            checkBalance_Click(sender,e);
            String one=balanceLabel.Text;
            String Two = amountText.Text;
            int add = Convert.ToInt32(one) + Convert.ToInt32(Two);
            cmd = new MySqlCommand("update student set balance="+add+"where prn="+prnText.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}