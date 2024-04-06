namespace QuanLyThuVien
{
    partial class LoginFrom
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            txtMatKhau = new TextBox();
            txtTenUS = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.dn;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-1, -52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 554);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.qtv;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(615, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 69);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleRole = AccessibleRole.Grip;
            btnLogin.BackgroundImage = Properties.Resources.nlg;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Location = new Point(531, 333);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(100, 0, 100, 0);
            btnLogin.Size = new Size(327, 76);
            btnLogin.TabIndex = 2;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(578, 254);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(351, 35);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenUS
            // 
            txtTenUS.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenUS.Location = new Point(578, 194);
            txtTenUS.Margin = new Padding(100);
            txtTenUS.Name = "txtTenUS";
            txtTenUS.Size = new Size(351, 35);
            txtTenUS.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(521, 109);
            label1.Name = "label1";
            label1.Size = new Size(293, 63);
            label1.TabIndex = 5;
            label1.Text = "ĐĂNG NHẬP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(446, 199);
            label2.Name = "label2";
            label2.Size = new Size(126, 26);
            label2.TabIndex = 7;
            label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 254);
            label3.Name = "label3";
            label3.Size = new Size(126, 26);
            label3.TabIndex = 7;
            label3.Text = "Mật Khẩu:";
            // 
            // LoginFrom
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(973, 493);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenUS);
            Controls.Add(txtMatKhau);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            MaximumSize = new Size(989, 532);
            MinimumSize = new Size(989, 532);
            Name = "LoginFrom";
            Text = "Đăng Nhập";
            Load += LoginFrom_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private TextBox txtMatKhau;
        private TextBox txtTenUS;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
