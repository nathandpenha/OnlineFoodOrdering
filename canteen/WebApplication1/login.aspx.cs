using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string str;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Data Source=localhost;Database=canteen;User ID=root;Password=root");
            con.Open();
            Response.Write("connect");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT prn from student where prn='" + IDTextBox.Text + "' and password = '" + PassTextBox.Text + "'";


            MySqlCommand cmd,cmdOne;
            MySqlDataReader dr;
            cmd = new MySqlCommand(sql, con);
            dr = cmd.ExecuteReader();


            
            while (dr.Read())
            {
               //checking the password is matching with the database
               if (dr.GetValue(0).ToString() ==IDTextBox.Text )
               {
                   Response.Write("Success");
                   Session["prn"] = dr.GetValue(0).ToString();
                   Response.Redirect("fooditems.aspx");
                  }
              else
               {
                   Response.Write("Fail");
               }
            }
         }
    
   

        }
    }
