namespace AsyncConcept
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
            this.labCount = new System.Windows.Forms.Label();
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCount.Location = new System.Drawing.Point(78, 112);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(0, 17);
            this.labCount.TabIndex = 0;
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Location = new System.Drawing.Point(81, 51);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(173, 34);
            this.btnProcessFile.TabIndex = 1;
            this.btnProcessFile.Text = "Process File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 298);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcessFile);
            this.Controls.Add(this.labCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.Button btnClear;
    }
}

