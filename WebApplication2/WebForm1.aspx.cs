using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.QueryString.Get("name"));
            Response.Write(Request.QueryString.Get("age"));
            Label1.Text = "the number is :" + Session["number"];
            HttpCookieCollection cookies = Request.Cookies;
            Label1.Text = cookies["cookie"].Value;

           
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox1.Text;
            TextBox1.Text = "";
        }
    }
}