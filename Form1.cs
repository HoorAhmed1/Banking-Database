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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Request_Loan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-LRCF5RM;database=Banking;integrated security=true";
            con.Open();
            MessageBox.Show(con.State.ToString());
            con.Close();
            MessageBox.Show(con.State.ToString());
        }
    }
}
