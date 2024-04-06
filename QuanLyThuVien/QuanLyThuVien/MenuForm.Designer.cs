namespace QuanLyThuVien
{
    partial class MenuForm
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
            panel1 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button7 = new Button();
            button2 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button12 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 104);
            panel1.TabIndex = 0;
            // 
            // button11
            // 
            button11.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.BlueViolet;
            button11.Image = Properties.Resources.icons8_shutdown_64;
            button11.ImageAlign = ContentAlignment.TopCenter;
            button11.Location = new Point(112, 2);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(106, 89);
            button11.TabIndex = 2;
            button11.Text = "ĐĂNG XUẤT";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.DarkViolet;
            button10.Image = Properties.Resources.icons8_exit_64;
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(224, 2);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.RightToLeft = RightToLeft.No;
            button10.Size = new Size(102, 89);
            button10.TabIndex = 1;
            button10.Text = "KẾT THÚC";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.DarkViolet;
            button9.Image = Properties.Resources.icons8_login_64;
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(3, 2);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(103, 89);
            button9.TabIndex = 0;
            button9.Text = "ĐĂNG NHẬP";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 524);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 75);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(752, 24);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 3;
            label2.Text = "00:00:00";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_time_64;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(846, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 70);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(82, 22);
            label1.Name = "label1";
            label1.Size = new Size(176, 24);
            label1.TabIndex = 1;
            label1.Text = "Quản lý thư viện";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_high_importance_64;
            pictureBox1.Location = new Point(1, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button12);
            panel3.Location = new Point(12, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 408);
            panel3.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.BlueViolet;
            button7.Image = Properties.Resources.icons8_book_100;
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(708, 215);
            button7.Name = "button7";
            button7.Size = new Size(190, 147);
            button7.TabIndex = 9;
            button7.Text = "THỐNG KÊ";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.BlueViolet;
            button2.Image = Properties.Resources.icons8_account_100;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(494, 215);
            button2.Name = "button2";
            button2.Size = new Size(190, 147);
            button2.TabIndex = 8;
            button2.Text = "TÁC GIẢ";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.BlueViolet;
            button6.Image = Properties.Resources.icons8_people_100;
            button6.Location = new Point(708, 27);
            button6.Name = "button6";
            button6.Size = new Size(190, 147);
            button6.TabIndex = 7;
            button6.Text = "THẺ TV";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.BlueViolet;
            button5.Image = Properties.Resources.icons8_admin_settings_male_100;
            button5.Location = new Point(269, 215);
            button5.Name = "button5";
            button5.Size = new Size(190, 147);
            button5.TabIndex = 6;
            button5.Text = "QTV\r\n";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.BlueViolet;
            button4.Image = Properties.Resources.icons8_address_book_100;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(45, 215);
            button4.Name = "button4";
            button4.Size = new Size(190, 147);
            button4.TabIndex = 5;
            button4.Text = "CHI TIẾT PM";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.BlueViolet;
            button3.Image = Properties.Resources.icons8_note_100;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(494, 27);
            button3.Name = "button3";
            button3.Size = new Size(190, 147);
            button3.TabIndex = 4;
            button3.Text = "PHIẾU MƯỢN";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlueViolet;
            button1.Image = Properties.Resources.icons8_book_shelf_100;
            button1.Location = new Point(269, 27);
            button1.Name = "button1";
            button1.Size = new Size(190, 147);
            button1.TabIndex = 2;
            button1.Text = "LOẠI SÁCH";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Control;
            button12.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.BlueViolet;
            button12.Image = Properties.Resources.icons8_literature_100;
            button12.Location = new Point(45, 27);
            button12.Name = "button12";
            button12.Size = new Size(190, 147);
            button12.TabIndex = 1;
            button12.Text = "SÁCH";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 617);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximumSize = new Size(1002, 656);
            MinimumSize = new Size(1002, 656);
            Name = "MenuForm";
            Text = "MenuForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button9;
        private Button button10;
        private Button button11;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button12;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label2;
        private Button button7;
        private Button button2;
    }
}