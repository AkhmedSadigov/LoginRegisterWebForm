using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegisterWebForm
{
    public partial class Register : System.Web.UI.Page
    {
        string ConnectingString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection(ConnectingString);
                SqlCommand cmd = new SqlCommand("Register", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@out",
                    Direction = System.Data.ParameterDirection.Output,
                    DbType = System.Data.DbType.Int64
                });
                cmd.Parameters.AddWithValue("@fname", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@username", TextBox3.Text);
                cmd.Parameters.AddWithValue("@email", TextBox4.Text);
                if (TextBox5.Text == TextBox6.Text)
                {
                    cmd.Parameters.AddWithValue("@pass", TextBox5.Text);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Passwords do not match!!');</script>", false);
                    return;
                }
                conn.Open();
                cmd.ExecuteNonQuery();
                string status = cmd.Parameters["@out"].Value.ToString();
                conn.Close();
                if (status == "1")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Account already exists!');</script>", false);
                    return;
                }

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registered Successfully!!!');</script>", false);
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}