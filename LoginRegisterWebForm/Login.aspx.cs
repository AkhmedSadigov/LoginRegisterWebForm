using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegisterWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        string ConnectingString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = TextBox1.Text;
                string passw = TextBox2.Text;
                SqlConnection conn = new SqlConnection(ConnectingString);
                SqlCommand cmd = new SqlCommand("select username, pass from reglogin where username = '" + username + "' and pass = '" + passw + "'", conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Succeeded!!!');</script>", false);
              
                    Response.Redirect("Default.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Invalid credentials!!');</script>", false);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('"+ ex.ToString() + "');</script>", false);
                ex.ToString();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}