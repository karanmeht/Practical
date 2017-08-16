using System;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreadingConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnOnTimeConsumingWork.Enabled = false;
            btnPrintNumber.Enabled = false;

            //Thread WorkThread = new Thread(DoTimeConsomingWork);
            //WorkThread.Start();
            DoTimeConsomingWork();

            btnOnTimeConsumingWork.Enabled = true;
            btnPrintNumber.Enabled = true;
        }

        private void DoTimeConsomingWork()
        {
            Thread.Sleep(5000);
        }

        private void btnPrintNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBoxDisplayNumber.Items.Add(i);
            }
        }
    }
}
