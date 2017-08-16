using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int CountCharacter()
        {
            int Count;
            using (StreamReader reader = new StreamReader(@"E:\study\karan\practical\C#\CSharpAssignment\List of program step by step.txt"))
            {
                string content = reader.ReadToEnd();
                Count = content.Count();
                Thread.Sleep(1000);
            }
            return Count;
        }

        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacter);
            task.Start();
            labCount.Text = "Processing File. Please Wait...";
            int Count = await task;
            labCount.Text = Count.ToString() + " Character in File";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labCount.Text = "";
        }
    }
}
