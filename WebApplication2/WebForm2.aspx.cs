using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cookie", TextBox4.Text);
            cookie.Expires = DateTime.Now.AddHours(24);
            Response.Cookies.Add(cookie);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = true;
            ViewState["name"] = TextBox1.Text;
            ViewState["age"] = TextBox2.Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("webform1.aspx?name= " + TextBox1.Text+ "&age="+TextBox2.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Number"] = TextBox3.Text;
            Session.Add("number", TextBox3.Text);

            Response.Redirect("webform1.aspx");
            
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("webform1.aspx");
        }
    }
}