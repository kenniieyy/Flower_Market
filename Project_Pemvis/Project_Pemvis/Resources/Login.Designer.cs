namespace Project_Pemvis.Resources
{
    partial class Login
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
            panelKiri = new Panel();
            pictureBoxBunga = new PictureBox();
            panelTempatLogin = new Panel();
            labelPassword = new Label();
            labelUsername = new Label();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelJudulFormLogin = new Label();
            panelKiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBunga).BeginInit();
            panelTempatLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelKiri
            // 
            panelKiri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelKiri.BackColor = Color.CadetBlue;
            panelKiri.Controls.Add(pictureBoxBunga);
            panelKiri.Location = new Point(0, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.Size = new Size(213, 406);
            panelKiri.TabIndex = 0;
            // 
            // pictureBoxBunga
            // 
            pictureBoxBunga.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxBunga.Image = Properties.Resources.Premium_Vector___Register_access_login_password_internet_online_website_concept_____flat_illustration;
            pictureBoxBunga.Location = new Point(36, 129);
            pictureBoxBunga.Name = "pictureBoxBunga";
            pictureBoxBunga.Size = new Size(132, 146);
            pictureBoxBunga.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBunga.TabIndex = 0;
            pictureBoxBunga.TabStop = false;
            // 
            // panelTempatLogin
            // 
            panelTempatLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelTempatLogin.BackColor = Color.CadetBlue;
            panelTempatLogin.Controls.Add(labelPassword);
            panelTempatLogin.Controls.Add(labelUsername);
            panelTempatLogin.Controls.Add(buttonLogin);
            panelTempatLogin.Controls.Add(textBoxPassword);
            panelTempatLogin.Controls.Add(textBoxUsername);
            panelTempatLogin.Location = new Point(296, 113);
            panelTempatLogin.Name = "panelTempatLogin";
            panelTempatLogin.Size = new Size(250, 191);
            panelTempatLogin.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(18, 80);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(64, 17);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(18, 33);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 17);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Image = Properties.Resources.icons8_login_32__1_1;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(76, 136);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(103, 37);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "LOGIN";
            buttonLogin.TextAlign = ContentAlignment.MiddleRight;
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(98, 74);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "your password";
            textBoxPassword.Size = new Size(134, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(98, 27);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "your username";
            textBoxUsername.Size = new Size(134, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // labelJudulFormLogin
            // 
            labelJudulFormLogin.Anchor = AnchorStyles.Top;
            labelJudulFormLogin.AutoSize = true;
            labelJudulFormLogin.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudulFormLogin.Location = new Point(333, 24);
            labelJudulFormLogin.Name = "labelJudulFormLogin";
            labelJudulFormLogin.Size = new Size(153, 27);
            labelJudulFormLogin.TabIndex = 33;
            labelJudulFormLogin.Text = "FORM LOGIN";
            labelJudulFormLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(626, 406);
            Controls.Add(labelJudulFormLogin);
            Controls.Add(panelTempatLogin);
            Controls.Add(panelKiri);
            Name = "Login";
            Text = "Login";
            panelKiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBunga).EndInit();
            panelTempatLogin.ResumeLayout(false);
            panelTempatLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelKiri;
        private PictureBox pictureBoxBunga;
        private Panel panelTempatLogin;
        private Label labelJudulFormLogin;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Label labelPassword;
    }
}