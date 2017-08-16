using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace QueueCollectionExample
{
    public partial class ServiceCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["queueTokens"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["queueTokens"] = queueTokens;
            }
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> TokenQueue = (Queue<int>)Session["queueTokens"];
            lblStatus.Text = "There are " + TokenQueue.Count.ToString() + "Customer before in queue";

            if (Session["LastTokemNumberIsUsed"] == null)
            {
                Session["LastTokemNumberIsUsed"] = 0;
            }

            int nextTokenNumberTobeIssued = (int)Session["LastTokemNumberIsUsed"] + 1;
            Session["LastTokemNumberIsUsed"] = nextTokenNumberTobeIssued;
            TokenQueue.Enqueue(nextTokenNumberTobeIssued);
            AddTokenToListBox(TokenQueue);
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServeNewCustomer(TxtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServeNewCustomer(TxtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServeNewCustomer(TxtCounter3, 3);
        }

        private void ServeNewCustomer(TextBox txtBox, int CounterNumber)
        {
            Queue<int> TokenQueue = (Queue<int>)Session["queueTokens"];
            if (TokenQueue.Count == 0)
            {
                txtBox.Text = "";
                txtDisplay.Text = "No customer in the Queue";
            }
            else
            {
                int tokenNumberToBeServed = TokenQueue.Dequeue();
                txtBox.Text = tokenNumberToBeServed.ToString();
                txtDisplay.Text = "Token Number: " + tokenNumberToBeServed.ToString() + " Please go to counter " + CounterNumber;
                AddTokenToListBox(TokenQueue);
            }
        }

        private void AddTokenToListBox(Queue<int> TokenQueue)
        {
            ListTokens.Items.Clear();
            foreach (int token in TokenQueue)
            {
                ListTokens.Items.Add(token.ToString());
            }
        }
    }
}