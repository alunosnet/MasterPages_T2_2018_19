using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageT2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar cookies
            HttpCookie cookie = Request.Cookies["AvisoSIT2"];
            if (cookie != null)
            {
                DivAviso.Visible = false;
                Response.Write(Server.UrlDecode(cookie.Value));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DivAviso.Visible = false;
            //criar um cookie
            HttpCookie cookie = new HttpCookie("AvisoSIT2");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie.Value = "Aceitou";
            //enviar o cookie para o browser
            Response.Cookies.Add(cookie);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DivAviso.Visible = false;
            //criar um cookie
            HttpCookie cookie = new HttpCookie("AvisoSIT2");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie.Value = Server.UrlEncode("Olá");
            //enviar o cookie para o browser
            Response.Cookies.Add(cookie);
        }
    }
}