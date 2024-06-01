namespace Project_Pemvis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxbg = new PictureBox();
            btnTransaksi = new Button();
            btnBarang = new Button();
            btnKasir = new Button();
            btnKeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxbg).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxbg
            // 
            pictureBoxbg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxbg.Image = Properties.Resources.Desain_tanpa_judul__4_;
            pictureBoxbg.Location = new Point(-1, 0);
            pictureBoxbg.Name = "pictureBoxbg";
            pictureBoxbg.Size = new Size(656, 394);
            pictureBoxbg.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxbg.TabIndex = 0;
            pictureBoxbg.TabStop = false;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaksi.Location = new Point(275, 79);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(92, 23);
            btnTransaksi.TabIndex = 1;
            btnTransaksi.Text = "TRANSAKSI";
            btnTransaksi.UseVisualStyleBackColor = true;
            // 
            // btnBarang
            // 
            btnBarang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBarang.Location = new Point(203, 122);
            btnBarang.Name = "btnBarang";
            btnBarang.Size = new Size(75, 23);
            btnBarang.TabIndex = 2;
            btnBarang.Text = "BARANG";
            btnBarang.UseVisualStyleBackColor = true;
            // 
            // btnKasir
            // 
            btnKasir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKasir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKasir.Location = new Point(284, 122);
            btnKasir.Name = "btnKasir";
            btnKasir.Size = new Size(75, 23);
            btnKasir.TabIndex = 3;
            btnKasir.Text = "KASIR";
            btnKasir.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            btnKeluar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.Location = new Point(365, 122);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(75, 23);
            btnKeluar.TabIndex = 4;
            btnKeluar.Text = "KELUAR";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(654, 394);
            Controls.Add(btnKeluar);
            Controls.Add(btnKasir);
            Controls.Add(btnBarang);
            Controls.Add(btnTransaksi);
            Controls.Add(pictureBoxbg);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxbg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxbg;
        private Button btnTransaksi;
        private Button btnBarang;
        private Button btnKasir;
        private Button btnKeluar;
    }
}
