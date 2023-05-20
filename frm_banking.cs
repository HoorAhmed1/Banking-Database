using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking_project
{
    public partial class frm_banking : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-LRCF5RM;database=Banking;integrated security=true");
        public frm_banking()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frm_banking_Load(object sender, EventArgs e)
        {
          

        }

        private void btn_submitReq_Click(object sender, EventArgs e)
        {
            string sql = "insert into Loan values(@loan_num, @loan_amount,@laon_type, @Cus_SSN, @Branch_Number, @Status, @Employee_id)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@loan_amount", txt_loanAmount.Text);
            cmd.Parameters.AddWithValue("@Cus_SSN", txt_CustomerSSN.Text);
            cmd.Parameters.AddWithValue("@laon_type", txt_loanType.Text);
            cmd.Parameters.AddWithValue("@Branch_Number", txt_branchNum.Text);
            cmd.Parameters.AddWithValue("@loan_num", txt_loanNum.Text);
            cmd.Parameters.AddWithValue("@Status","pending");
            cmd.Parameters.AddWithValue("@Employee_id", "1");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your request is sent successfully!");
            First_Form form1 = new First_Form();
            form1.Show();
            this.Hide();

        }
    }
}
