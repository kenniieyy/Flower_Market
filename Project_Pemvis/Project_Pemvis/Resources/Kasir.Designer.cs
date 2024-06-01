namespace Project_Pemvis.Resources
{
    partial class Kasir
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
            labelIDKasir = new Label();
            labelJudulFormKasir = new Label();
            labelNamaKasir = new Label();
            textBoxIDKasir = new TextBox();
            textBoxNamaKasir = new TextBox();
            dataGridViewDataKasir = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            labelAlamat = new Label();
            textBoxAlamat = new TextBox();
            labelTelepon = new Label();
            textBoxTelepon = new TextBox();
            textBoxCariData = new TextBox();
            groupBoxFormKasir = new GroupBox();
            groupBoxDataKasir = new GroupBox();
            groupBox4 = new GroupBox();
            buttonKeluar = new Button();
            buttonBarang = new Button();
            buttonTransaksi = new Button();
            buttonHome = new Button();
            groupBoxProses = new GroupBox();
            buttonRefresh = new Button();
            buttonBaru = new Button();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataKasir).BeginInit();
            groupBoxFormKasir.SuspendLayout();
            groupBoxDataKasir.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBoxProses.SuspendLayout();
            SuspendLayout();
            // 
            // labelIDKasir
            // 
            labelIDKasir.AutoSize = true;
            labelIDKasir.Location = new Point(2, 24);
            labelIDKasir.Name = "labelIDKasir";
            labelIDKasir.Size = new Size(53, 17);
            labelIDKasir.TabIndex = 0;
            labelIDKasir.Text = "ID Kasir";
            // 
            // labelJudulFormKasir
            // 
            labelJudulFormKasir.AutoSize = true;
            labelJudulFormKasir.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudulFormKasir.Location = new Point(84, 12);
            labelJudulFormKasir.Name = "labelJudulFormKasir";
            labelJudulFormKasir.Size = new Size(205, 54);
            labelJudulFormKasir.TabIndex = 1;
            labelJudulFormKasir.Text = "DATA KASIR \r\nFLOWER MARKET";
            labelJudulFormKasir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNamaKasir
            // 
            labelNamaKasir.AutoSize = true;
            labelNamaKasir.Location = new Point(2, 63);
            labelNamaKasir.Name = "labelNamaKasir";
            labelNamaKasir.Size = new Size(76, 17);
            labelNamaKasir.TabIndex = 2;
            labelNamaKasir.Text = "Nama Kasir";
            // 
            // textBoxIDKasir
            // 
            textBoxIDKasir.Location = new Point(90, 21);
            textBoxIDKasir.Name = "textBoxIDKasir";
            textBoxIDKasir.Size = new Size(239, 25);
            textBoxIDKasir.TabIndex = 3;
            // 
            // textBoxNamaKasir
            // 
            textBoxNamaKasir.Location = new Point(90, 63);
            textBoxNamaKasir.Name = "textBoxNamaKasir";
            textBoxNamaKasir.Size = new Size(239, 25);
            textBoxNamaKasir.TabIndex = 4;
            // 
            // dataGridViewDataKasir
            // 
            dataGridViewDataKasir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDataKasir.BackgroundColor = Color.PowderBlue;
            dataGridViewDataKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataKasir.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewDataKasir.GridColor = Color.CadetBlue;
            dataGridViewDataKasir.Location = new Point(11, 63);
            dataGridViewDataKasir.Name = "dataGridViewDataKasir";
            dataGridViewDataKasir.Size = new Size(459, 284);
            dataGridViewDataKasir.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Kasir";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Kasir";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Alamat";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telepon";
            Column4.Name = "Column4";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(2, 106);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(48, 17);
            labelAlamat.TabIndex = 17;
            labelAlamat.Text = "Alamat";
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(90, 106);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(239, 25);
            textBoxAlamat.TabIndex = 18;
            // 
            // labelTelepon
            // 
            labelTelepon.AutoSize = true;
            labelTelepon.Location = new Point(2, 146);
            labelTelepon.Name = "labelTelepon";
            labelTelepon.Size = new Size(54, 17);
            labelTelepon.TabIndex = 19;
            labelTelepon.Text = "Telepon";
            // 
            // textBoxTelepon
            // 
            textBoxTelepon.Location = new Point(90, 146);
            textBoxTelepon.Name = "textBoxTelepon";
            textBoxTelepon.Size = new Size(239, 25);
            textBoxTelepon.TabIndex = 20;
            // 
            // textBoxCariData
            // 
            textBoxCariData.BackColor = SystemColors.Window;
            textBoxCariData.Location = new Point(11, 21);
            textBoxCariData.Name = "textBoxCariData";
            textBoxCariData.PlaceholderText = "Cari Data (ID / Nama)";
            textBoxCariData.Size = new Size(239, 25);
            textBoxCariData.TabIndex = 25;
            // 
            // groupBoxFormKasir
            // 
            groupBoxFormKasir.BackColor = Color.CadetBlue;
            groupBoxFormKasir.Controls.Add(textBoxTelepon);
            groupBoxFormKasir.Controls.Add(labelTelepon);
            groupBoxFormKasir.Controls.Add(textBoxAlamat);
            groupBoxFormKasir.Controls.Add(labelAlamat);
            groupBoxFormKasir.Controls.Add(textBoxNamaKasir);
            groupBoxFormKasir.Controls.Add(textBoxIDKasir);
            groupBoxFormKasir.Controls.Add(labelNamaKasir);
            groupBoxFormKasir.Controls.Add(labelIDKasir);
            groupBoxFormKasir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxFormKasir.Location = new Point(12, 98);
            groupBoxFormKasir.Name = "groupBoxFormKasir";
            groupBoxFormKasir.Size = new Size(333, 192);
            groupBoxFormKasir.TabIndex = 26;
            groupBoxFormKasir.TabStop = false;
            groupBoxFormKasir.Text = "Form Kasir";
            // 
            // groupBoxDataKasir
            // 
            groupBoxDataKasir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDataKasir.BackColor = Color.CadetBlue;
            groupBoxDataKasir.Controls.Add(textBoxCariData);
            groupBoxDataKasir.Controls.Add(dataGridViewDataKasir);
            groupBoxDataKasir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDataKasir.Location = new Point(387, 88);
            groupBoxDataKasir.Name = "groupBoxDataKasir";
            groupBoxDataKasir.Size = new Size(476, 353);
            groupBoxDataKasir.TabIndex = 27;
            groupBoxDataKasir.TabStop = false;
            groupBoxDataKasir.Text = "Data Kasir";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.CadetBlue;
            groupBox4.Controls.Add(buttonKeluar);
            groupBox4.Controls.Add(buttonBarang);
            groupBox4.Controls.Add(buttonTransaksi);
            groupBox4.Controls.Add(buttonHome);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(387, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 70);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Menu";
            // 
            // buttonKeluar
            // 
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.Image = Properties.Resources.icons8_exit_32;
            buttonKeluar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKeluar.Location = new Point(356, 20);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(109, 44);
            buttonKeluar.TabIndex = 11;
            buttonKeluar.Text = "KELUAR";
            buttonKeluar.TextAlign = ContentAlignment.MiddleRight;
            buttonKeluar.UseVisualStyleBackColor = true;
            // 
            // buttonBarang
            // 
            buttonBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBarang.Image = Properties.Resources.icons8_flower_32;
            buttonBarang.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBarang.Location = new Point(241, 20);
            buttonBarang.Name = "buttonBarang";
            buttonBarang.Size = new Size(109, 44);
            buttonBarang.TabIndex = 10;
            buttonBarang.Text = "BARANG";
            buttonBarang.TextAlign = ContentAlignment.MiddleRight;
            buttonBarang.UseVisualStyleBackColor = true;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTransaksi.Image = Properties.Resources.icons8_new_file_32;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(126, 20);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(109, 44);
            buttonTransaksi.TabIndex = 9;
            buttonTransaksi.Text = "TRANSAKSI";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Image = Properties.Resources.icons8_home_32;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(11, 20);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(109, 44);
            buttonHome.TabIndex = 8;
            buttonHome.Text = "HOME";
            buttonHome.TextAlign = ContentAlignment.MiddleRight;
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // groupBoxProses
            // 
            groupBoxProses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProses.BackColor = Color.CadetBlue;
            groupBoxProses.Controls.Add(buttonRefresh);
            groupBoxProses.Controls.Add(buttonBaru);
            groupBoxProses.Controls.Add(buttonHapus);
            groupBoxProses.Controls.Add(buttonSimpan);
            groupBoxProses.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxProses.Location = new Point(12, 321);
            groupBoxProses.Name = "groupBoxProses";
            groupBoxProses.Size = new Size(333, 120);
            groupBoxProses.TabIndex = 29;
            groupBoxProses.TabStop = false;
            groupBoxProses.Text = "Proses";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRefresh.Image = Properties.Resources.icons8_refresh_32;
            buttonRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new Point(218, 18);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(109, 44);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "REFRESH";
            buttonRefresh.TextAlign = ContentAlignment.MiddleRight;
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonBaru
            // 
            buttonBaru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBaru.Image = Properties.Resources.icons8_new_file_32;
            buttonBaru.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBaru.Location = new Point(6, 18);
            buttonBaru.Name = "buttonBaru";
            buttonBaru.Size = new Size(109, 44);
            buttonBaru.TabIndex = 7;
            buttonBaru.Text = "BARU";
            buttonBaru.TextAlign = ContentAlignment.MiddleRight;
            buttonBaru.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            buttonHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHapus.Image = Properties.Resources.icons8_delete_32;
            buttonHapus.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHapus.Location = new Point(218, 70);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(109, 44);
            buttonHapus.TabIndex = 6;
            buttonHapus.Text = "HAPUS";
            buttonHapus.TextAlign = ContentAlignment.MiddleRight;
            buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSimpan.Image = Properties.Resources.icons8_save_321;
            buttonSimpan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSimpan.Location = new Point(6, 70);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(109, 44);
            buttonSimpan.TabIndex = 4;
            buttonSimpan.Text = "SIMPAN";
            buttonSimpan.TextAlign = ContentAlignment.MiddleRight;
            buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // Kasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(875, 441);
            Controls.Add(groupBoxProses);
            Controls.Add(groupBox4);
            Controls.Add(groupBoxDataKasir);
            Controls.Add(groupBoxFormKasir);
            Controls.Add(labelJudulFormKasir);
            Name = "Kasir";
            Text = "Kasir";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataKasir).EndInit();
            groupBoxFormKasir.ResumeLayout(false);
            groupBoxFormKasir.PerformLayout();
            groupBoxDataKasir.ResumeLayout(false);
            groupBoxDataKasir.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBoxProses.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIDKasir;
        private Label labelJudulFormKasir;
        private Label labelNamaKasir;
        private TextBox textBoxIDKasir;
        private TextBox textBoxNamaKasir;
        private DataGridView dataGridViewDataKasir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label labelAlamat;
        private TextBox textBoxAlamat;
        private Label labelTelepon;
        private TextBox textBoxTelepon;
        private TextBox textBoxCariData;
        private GroupBox groupBoxFormKasir;
        private GroupBox groupBoxDataKasir;
        private GroupBox groupBox4;
        private GroupBox groupBoxProses;
        private Button buttonRefresh;
        private Button buttonBaru;
        private Button buttonHapus;
        private Button buttonSimpan;
        private Button buttonKeluar;
        private Button buttonBarang;
        private Button buttonTransaksi;
        private Button buttonHome;
    }
}