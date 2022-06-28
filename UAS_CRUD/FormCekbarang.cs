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

namespace UAS_CRUD
{
    public partial class FormCekbarang : Form
    {
        public FormCekbarang()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=IHSAN\\MUHAMMADIHSAN;Initial Catalog=tokohp;Persist Security Info=True;User ID=sa;Password=123");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokohpDataSet.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.tokohpDataSet.barang);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.insertbarang1'" + masuk_idBarang.Text + "','" + masuk_namaBarang.Text + "','" + masuk_Harga.Text + "','" + masuk_idPemasok.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }
        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.tampilbarang", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updatebarang'" + masuk_idBarang.Text + "','" + masuk_namaBarang.Text + "','" + masuk_Harga.Text + "','" + masuk_idPemasok.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deletebarang1'" + masuk_idBarang.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilkan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.searchbarang2'" + masuk_idBarang.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu dg = new FormMenu();
            dg.Show();
        }
    }
}
