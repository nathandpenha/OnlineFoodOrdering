using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class fooditems : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string str;
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
            con = new MySqlConnection("Data Source=localhost;Database=canteen;User ID=root;Password=root");
       
            con.Open();
            cmd = new MySqlCommand("select * from menu", con);
            MySqlDataReader r = cmd.ExecuteReader();
            GridView1.DataSource = r;
            GridView1.DataBind();
            con.Close();

        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            String id = GridView1.SelectedRow.Cells[0].Text;


            Response.Redirect("order.aspx?id=" + id);
       
        }
    }
}