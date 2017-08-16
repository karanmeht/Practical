using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackCollectionExample
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            if (Session["URLStack"] == null)
            {
                Stack<string> urlStack = new Stack<string>();
                Session["URLStack"] = urlStack;
            }
            if (Request.UrlReferrer != null && !this.Page.IsPostBack && Session["BackButtonClick"] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
            }

            if (Session["BackButtonClick"] != null)
            {
                Session["BackButtonClick"] = null;
            }
        }
    }
}