namespace Banking_project
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
            this.Request_Loan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Request_Loan
            // 
            this.Request_Loan.Location = new System.Drawing.Point(309, 62);
            this.Request_Loan.Name = "Request_Loan";
            this.Request_Loan.Size = new System.Drawing.Size(222, 64);
            this.Request_Loan.TabIndex = 0;
            this.Request_Loan.Text = "Request Loans";
            this.Request_Loan.UseVisualStyleBackColor = true;
            this.Request_Loan.Click += new System.EventHandler(this.Request_Loan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Request_Loan);
            this.Name = "Form1";
            this.Text = "Loans";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Request_Loan;
    }
}

