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
    public partial class FormPenjualan : Form
    {
        public FormPenjualan()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=IHSAN\\MUHAMMADIHSAN;Initial Catalog=tokohp2;Persist Security Info=True;User ID=sa;Password=123");
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokohp2DataSet2.keterangan_penjualan' table. You can move, or remove it, as needed.
            this.keterangan_penjualanTableAdapter.Fill(this.tokohp2DataSet2.keterangan_penjualan);
            tampilkan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.insertketjual'" + masuk_idNota.Text + "','" + masuk_Harga.Text + "','" + masuk_jumlahBarang.Text + "','" + masuk_idBarang.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }
        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.tampilketjual", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updateketjual'" + masuk_idNota.Text + "','" + masuk_Harga.Text + "','" + masuk_jumlahBarang.Text + "','" + masuk_idBarang.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deleteketjual'" + masuk_idNota.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.searchketjual'" + masuk_idNota.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu fm = new FormMenu();
            fm.Show();
        }
    }
}
