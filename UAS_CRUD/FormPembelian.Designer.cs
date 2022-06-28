
namespace UAS_CRUD
{
    partial class FormPembelian
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.masuk_idNota = new System.Windows.Forms.TextBox();
            this.keteranganpembelianBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tokohp2DataSet1 = new UAS_CRUD.tokohp2DataSet1();
            this.masuk_Harga = new System.Windows.Forms.TextBox();
            this.masuk_jumlahBarang = new System.Windows.Forms.TextBox();
            this.masuk_idBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganpembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokohp2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.keterangan_pembelianTableAdapter = new UAS_CRUD.tokohp2DataSet1TableAdapters.keterangan_pembelianTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.masuk_idPegawai = new System.Windows.Forms.TextBox();
            this.keteranganpembelianBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganpembelianBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokohp2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganpembelianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokohp2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganpembelianBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 61);
            this.label1.TabIndex = 10;
            this.label1.Text = "KETERANGAN PEMBELIAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 101);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // masuk_idNota
            // 
            this.masuk_idNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keteranganpembelianBindingSource1, "id_nota", true));
            this.masuk_idNota.Location = new System.Drawing.Point(251, 398);
            this.masuk_idNota.Name = "masuk_idNota";
            this.masuk_idNota.Size = new System.Drawing.Size(138, 22);
            this.masuk_idNota.TabIndex = 32;
            // 
            // keteranganpembelianBindingSource1
            // 
            this.keteranganpembelianBindingSource1.DataMember = "keterangan_pembelian";
            this.keteranganpembelianBindingSource1.DataSource = this.tokohp2DataSet1;
            // 
            // tokohp2DataSet1
            // 
            this.tokohp2DataSet1.DataSetName = "tokohp2DataSet1";
            this.tokohp2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masuk_Harga
            // 
            this.masuk_Harga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keteranganpembelianBindingSource1, "harga", true));
            this.masuk_Harga.Location = new System.Drawing.Point(251, 353);
            this.masuk_Harga.Name = "masuk_Harga";
            this.masuk_Harga.Size = new System.Drawing.Size(138, 22);
            this.masuk_Harga.TabIndex = 31;
            // 
            // masuk_jumlahBarang
            // 
            this.masuk_jumlahBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keteranganpembelianBindingSource1, "jumlah_barang", true));
            this.masuk_jumlahBarang.Location = new System.Drawing.Point(251, 310);
            this.masuk_jumlahBarang.Name = "masuk_jumlahBarang";
            this.masuk_jumlahBarang.Size = new System.Drawing.Size(138, 22);
            this.masuk_jumlahBarang.TabIndex = 30;
            // 
            // masuk_idBarang
            // 
            this.masuk_idBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keteranganpembelianBindingSource1, "id_barang", true));
            this.masuk_idBarang.Location = new System.Drawing.Point(251, 262);
            this.masuk_idBarang.Name = "masuk_idBarang";
            this.masuk_idBarang.Size = new System.Drawing.Size(138, 22);
            this.masuk_idBarang.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(64, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID NOTA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(64, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "JUMLAH BARANG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(64, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID BARANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(148, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 44);
            this.label2.TabIndex = 25;
            this.label2.Text = "ISI DATA";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(954, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 59);
            this.button4.TabIndex = 24;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(821, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 59);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 59);
            this.button2.TabIndex = 22;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 21;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.jumlahbarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.idnotaDataGridViewTextBoxColumn,
            this.idpegawaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.keteranganpembelianBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(485, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 329);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahbarangDataGridViewTextBoxColumn
            // 
            this.jumlahbarangDataGridViewTextBoxColumn.DataPropertyName = "jumlah_barang";
            this.jumlahbarangDataGridViewTextBoxColumn.HeaderText = "jumlah_barang";
            this.jumlahbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahbarangDataGridViewTextBoxColumn.Name = "jumlahbarangDataGridViewTextBoxColumn";
            this.jumlahbarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idnotaDataGridViewTextBoxColumn
            // 
            this.idnotaDataGridViewTextBoxColumn.DataPropertyName = "id_nota";
            this.idnotaDataGridViewTextBoxColumn.HeaderText = "id_nota";
            this.idnotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idnotaDataGridViewTextBoxColumn.Name = "idnotaDataGridViewTextBoxColumn";
            this.idnotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpegawaiDataGridViewTextBoxColumn
            // 
            this.idpegawaiDataGridViewTextBoxColumn.DataPropertyName = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.HeaderText = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpegawaiDataGridViewTextBoxColumn.Name = "idpegawaiDataGridViewTextBoxColumn";
            this.idpegawaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // keteranganpembelianBindingSource
            // 
            this.keteranganpembelianBindingSource.DataMember = "keterangan_pembelian";
            this.keteranganpembelianBindingSource.DataSource = this.tokohp2DataSet1BindingSource;
            // 
            // tokohp2DataSet1BindingSource
            // 
            this.tokohp2DataSet1BindingSource.DataSource = this.tokohp2DataSet1;
            this.tokohp2DataSet1BindingSource.Position = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(485, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(647, 137);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(38, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 370);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(64, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "HARGA";
            // 
            // keterangan_pembelianTableAdapter
            // 
            this.keterangan_pembelianTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(64, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID PEGAWAI";
            // 
            // masuk_idPegawai
            // 
            this.masuk_idPegawai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keteranganpembelianBindingSource1, "id_pegawai", true));
            this.masuk_idPegawai.Location = new System.Drawing.Point(251, 443);
            this.masuk_idPegawai.Name = "masuk_idPegawai";
            this.masuk_idPegawai.Size = new System.Drawing.Size(138, 22);
            this.masuk_idPegawai.TabIndex = 35;
            // 
            // keteranganpembelianBindingSource2
            // 
            this.keteranganpembelianBindingSource2.DataMember = "keterangan_pembelian";
            this.keteranganpembelianBindingSource2.DataSource = this.tokohp2DataSet1BindingSource;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(139, 571);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 52);
            this.button5.TabIndex = 38;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 696);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.masuk_idPegawai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masuk_idNota);
            this.Controls.Add(this.masuk_Harga);
            this.Controls.Add(this.masuk_jumlahBarang);
            this.Controls.Add(this.masuk_idBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormPembelian";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganpembelianBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokohp2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganpembelianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokohp2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keteranganpembelianBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox masuk_idNota;
        private System.Windows.Forms.TextBox masuk_Harga;
        private System.Windows.Forms.TextBox masuk_jumlahBarang;
        private System.Windows.Forms.TextBox masuk_idBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tokohp2DataSet1BindingSource;
        private tokohp2DataSet1 tokohp2DataSet1;
        private System.Windows.Forms.BindingSource keteranganpembelianBindingSource;
        private tokohp2DataSet1TableAdapters.keterangan_pembelianTableAdapter keterangan_pembelianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox masuk_idPegawai;
        private System.Windows.Forms.BindingSource keteranganpembelianBindingSource1;
        private System.Windows.Forms.BindingSource keteranganpembelianBindingSource2;
        private System.Windows.Forms.Button button5;
    }
}