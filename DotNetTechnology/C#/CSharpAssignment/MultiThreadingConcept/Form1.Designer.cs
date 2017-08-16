namespace MultiThreadingConcept
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOnTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumber = new System.Windows.Forms.Button();
            this.listBoxDisplayNumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOnTimeConsumingWork
            // 
            this.btnOnTimeConsumingWork.Location = new System.Drawing.Point(39, 42);
            this.btnOnTimeConsumingWork.Name = "btnOnTimeConsumingWork";
            this.btnOnTimeConsumingWork.Size = new System.Drawing.Size(200, 23);
            this.btnOnTimeConsumingWork.TabIndex = 0;
            this.btnOnTimeConsumingWork.Text = "On Time Consuming Work";
            this.btnOnTimeConsumingWork.UseVisualStyleBackColor = true;
            this.btnOnTimeConsumingWork.Click += new System.EventHandler(this.btnOnTimeConsumingWork_Click);
            // 
            // btnPrintNumber
            // 
            this.btnPrintNumber.Location = new System.Drawing.Point(39, 71);
            this.btnPrintNumber.Name = "btnPrintNumber";
            this.btnPrintNumber.Size = new System.Drawing.Size(200, 23);
            this.btnPrintNumber.TabIndex = 1;
            this.btnPrintNumber.Text = "Print Number";
            this.btnPrintNumber.UseVisualStyleBackColor = true;
            this.btnPrintNumber.Click += new System.EventHandler(this.btnPrintNumber_Click);
            // 
            // listBoxDisplayNumber
            // 
            this.listBoxDisplayNumber.FormattingEnabled = true;
            this.listBoxDisplayNumber.Location = new System.Drawing.Point(39, 131);
            this.listBoxDisplayNumber.Name = "listBoxDisplayNumber";
            this.listBoxDisplayNumber.Size = new System.Drawing.Size(200, 147);
            this.listBoxDisplayNumber.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.listBoxDisplayNumber);
            this.Controls.Add(this.btnPrintNumber);
            this.Controls.Add(this.btnOnTimeConsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnTimeConsumingWork;
        private System.Windows.Forms.Button btnPrintNumber;
        private System.Windows.Forms.ListBox listBoxDisplayNumber;
    }
}

