using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace LoginFormtest
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            string selectUser = "select first_name, email from [userinfo] where email'"+ txtEmail.Text.ToString()+"' and password = '"+txtPassword.Text.ToString()+"'";
            SqlCommand selcmd = new SqlCommand(selectUser, con);
            SqlDataReader read = selcmd.ExecuteReader();
            if(read.Read())
            {
                Session["first_name"] = read.GetValue(0).ToString();
                Session["email"] = read.GetValue(1).ToString();
                con.Close();
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblErrorMsg.Text = "Your Email is not registered with us, please first register your email id";
                lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                con.Close();
            }
        }
    }
}