using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackCollectionExample
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session["BackButtonClick"] = "YES";
            if (Session["URLStack"] != null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                if (urlStack.Count > 0)
                {
                    string url = urlStack.Pop();
                    Response.Redirect(url);
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.Text = "There are no page in the history";
                }
            }
        }
    }
}