using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_CRUD
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormCekbarang Menuform = new FormCekbarang();
            Menuform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormPembelian Menuform = new FormPembelian();
            Menuform.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormPenjualan Menuform = new FormPenjualan();
            Menuform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login dg = new Login();
            dg.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
