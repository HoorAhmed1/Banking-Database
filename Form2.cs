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
    
    public partial class status_form : Form
    {
        public status_form()
        {
            InitializeComponent();
        }

        private void status_form_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=DESKTOP-LRCF5RM;database=Banking;integrated security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Status from Loan Where loan_num Like'%" + txt_loanNum.Text+ "%'", con);
                SqlDataAdapter reader = new SqlDataAdapter();
                DataTable dt = new DataTable();
                reader.SelectCommand = cmd;
                dt.Clear();
                reader.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
       

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Load Number or LOAN REJECTED");
            }
        }
    }
}
