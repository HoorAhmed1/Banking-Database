namespace Banking_project
{
    partial class frm_banking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CustomerSSN = new System.Windows.Forms.TextBox();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_branchNum = new System.Windows.Forms.TextBox();
            this.btn_submitReq = new System.Windows.Forms.Button();
            this.txt_loanType = new System.Windows.Forms.TextBox();
            this.txt_loanNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(31, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer SSN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(31, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loan amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(31, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branch Num";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loan Request";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_CustomerSSN
            // 
            this.txt_CustomerSSN.Location = new System.Drawing.Point(212, 90);
            this.txt_CustomerSSN.Name = "txt_CustomerSSN";
            this.txt_CustomerSSN.Size = new System.Drawing.Size(254, 30);
            this.txt_CustomerSSN.TabIndex = 6;
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Location = new System.Drawing.Point(212, 197);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(254, 30);
            this.txt_loanAmount.TabIndex = 8;
            // 
            // txt_branchNum
            // 
            this.txt_branchNum.Location = new System.Drawing.Point(212, 249);
            this.txt_branchNum.MaxLength = 120;
            this.txt_branchNum.Name = "txt_branchNum";
            this.txt_branchNum.Size = new System.Drawing.Size(254, 30);
            this.txt_branchNum.TabIndex = 9;
            // 
            // btn_submitReq
            // 
            this.btn_submitReq.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_submitReq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submitReq.Location = new System.Drawing.Point(185, 348);
            this.btn_submitReq.Name = "btn_submitReq";
            this.btn_submitReq.Size = new System.Drawing.Size(111, 39);
            this.btn_submitReq.TabIndex = 10;
            this.btn_submitReq.Text = "SUBMIT";
            this.btn_submitReq.UseVisualStyleBackColor = false;
            this.btn_submitReq.Click += new System.EventHandler(this.btn_submitReq_Click);
            // 
            // txt_loanType
            // 
            this.txt_loanType.Location = new System.Drawing.Point(212, 144);
            this.txt_loanType.Name = "txt_loanType";
            this.txt_loanType.Size = new System.Drawing.Size(254, 30);
            this.txt_loanType.TabIndex = 11;
            // 
            // txt_loanNum
            // 
            this.txt_loanNum.Location = new System.Drawing.Point(212, 302);
            this.txt_loanNum.MaxLength = 120;
            this.txt_loanNum.Name = "txt_loanNum";
            this.txt_loanNum.Size = new System.Drawing.Size(254, 30);
            this.txt_loanNum.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(31, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loan num";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_banking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 412);
            this.Controls.Add(this.txt_loanNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_loanType);
            this.Controls.Add(this.btn_submitReq);
            this.Controls.Add(this.txt_branchNum);
            this.Controls.Add(this.txt_loanAmount);
            this.Controls.Add(this.txt_CustomerSSN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_banking";
            this.Text = "Loan Request";
            this.Load += new System.EventHandler(this.frm_banking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CustomerSSN;
        private System.Windows.Forms.TextBox txt_loanAmount;
        private System.Windows.Forms.TextBox txt_branchNum;
        private System.Windows.Forms.Button btn_submitReq;
        private System.Windows.Forms.TextBox txt_loanType;
        private System.Windows.Forms.TextBox txt_loanNum;
        private System.Windows.Forms.Label label5;
    }
}