using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_project
{
    public partial class First_Form : Form
    {
        public First_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_banking form2 = new frm_banking();
            form2.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            status_form form2 = new status_form();
            form2.Show();
            this.Hide();

        }
    }
}
