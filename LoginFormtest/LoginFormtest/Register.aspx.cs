using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace LoginFormtest
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand checkemail = new SqlCommand("select email from [userinfo] where email = '" + txtemail.Text.ToString() + "' ",con);
            SqlDataReader read = checkemail.ExecuteReader();
            if(read.HasRows)
            {
                lblErrorMsg.Text = "Email already exist, please try with different email id";
                lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                con.Close();
            } else
            {
                con.Close();
                con.Open();
                string insertUser = "insert into [userinfo] (@first_name, @last_name, @email, @password)";
                SqlCommand insertedCmd = new SqlCommand(insertUser, con);
                insertedCmd.Parameters.AddWithValue("@first_name", txtname.Text.ToString());
                insertedCmd.Parameters.AddWithValue("@last_name", txtlastname.ToString());
                insertedCmd.Parameters.AddWithValue("@email", txtemail.Text.ToString());
                insertedCmd.Parameters.AddWithValue("@password", txtpassword.Text.ToString());
                insertedCmd.ExecuteNonQuery();

                MailMessage mail = new MailMessage();
                mail.To.Add(txtemail.Text.ToString());
                mail.From = new MailAddress("jims234@gmail.com");
                mail.Subject = "Thankyou for registering with us...";
                string emailbody = "";
                emailbody += "<h1>Hello, " + txtname.Text.ToString() + "</h1>";
                emailbody += "Thank you...";

                mail.Body = emailbody;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587; //25 465
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("jims234@gmail.com", "1234");
                smtp.Send(mail);

                lblErrorMsg.Text = "You are sucessfully registered with us, please check your email inbox/spam folder for further information";
                lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                con.Close();
            }
        }
    }
}