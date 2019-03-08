namespace WindowsFormsApp1
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
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.btnInterest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(75, 39);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBalance.TabIndex = 0;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(75, 99);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "btnDeposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Location = new System.Drawing.Point(223, 99);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithDraw.TabIndex = 1;
            this.btnWithDraw.Text = "btnWithDraw";
            this.btnWithDraw.UseVisualStyleBackColor = true;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.Location = new System.Drawing.Point(470, 38);
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDisplay.TabIndex = 2;
            // 
            // btnInterest
            // 
            this.btnInterest.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnInterest.Location = new System.Drawing.Point(355, 99);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(75, 23);
            this.btnInterest.TabIndex = 1;
            this.btnInterest.Text = "CalInterest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.btnInterest);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtBoxBalance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.Button btnInterest;
    }
}