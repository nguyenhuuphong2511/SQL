namespace QuanLyThuVien
{
    partial class PhieuMuonForm
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
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btnTimKiem = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            txtMaPM = new TextBox();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnInsert = new Button();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 92);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(402, 23);
            label2.Name = "label2";
            label2.Size = new Size(285, 54);
            label2.TabIndex = 3;
            label2.Text = "PHIẾU MƯỢN";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.khungvien;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(685, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(280, 76);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.BackgroundImage = Properties.Resources.khungvien1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(15, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(280, 76);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.note;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Location = new Point(299, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(98, 95);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(7, 103);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 567);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnTimKiem);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 539);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh Sách";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(910, 413);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackgroundImage = Properties.Resources.tim;
            btnTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimKiem.Location = new Point(745, 23);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(52, 43);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(245, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(481, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(104, 34);
            label1.Name = "label1";
            label1.Size = new Size(121, 29);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(pictureBox6);
            tabPage2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(974, 539);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cập Nhật";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(txtMaPM);
            panel4.Location = new Point(86, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 338);
            panel4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(241, 195);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(429, 38);
            dateTimePicker1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkViolet;
            label9.Location = new Point(3, 272);
            label9.Name = "label9";
            label9.Size = new Size(134, 32);
            label9.TabIndex = 13;
            label9.Text = "Ngày trả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkViolet;
            label8.Location = new Point(3, 192);
            label8.Name = "label8";
            label8.Size = new Size(181, 32);
            label8.TabIndex = 12;
            label8.Text = "Ngày mượn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkViolet;
            label7.Location = new Point(3, 113);
            label7.Name = "label7";
            label7.Size = new Size(206, 32);
            label7.TabIndex = 11;
            label7.Text = "Mã thành viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkViolet;
            label6.Location = new Point(3, 37);
            label6.Name = "label6";
            label6.Size = new Size(232, 32);
            label6.TabIndex = 10;
            label6.Text = "Mã phiếu mượn:";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(241, 265);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(429, 39);
            textBox8.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(241, 106);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(429, 39);
            textBox6.TabIndex = 5;
            // 
            // txtMaPM
            // 
            txtMaPM.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaPM.Location = new Point(241, 30);
            txtMaPM.Name = "txtMaPM";
            txtMaPM.Size = new Size(429, 39);
            txtMaPM.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnInsert);
            panel3.Location = new Point(836, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 361);
            panel3.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Image = Properties.Resources._new;
            button4.Location = new Point(15, 278);
            button4.Name = "button4";
            button4.Size = new Size(84, 80);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Image = Properties.Resources.xoa;
            button3.Location = new Point(15, 106);
            button3.Name = "button3";
            button3.Size = new Size(84, 80);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Image = Properties.Resources.update;
            button2.Location = new Point(15, 192);
            button2.Name = "button2";
            button2.Size = new Size(84, 80);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.BackgroundImageLayout = ImageLayout.Center;
            btnInsert.Image = Properties.Resources.them1;
            btnInsert.Location = new Point(15, 20);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(84, 80);
            btnInsert.TabIndex = 0;
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(293, 463);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 62);
            panel2.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.tien1;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(346, 1);
            button8.Name = "button8";
            button8.Size = new Size(62, 58);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.tien;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(254, 3);
            button7.Name = "button7";
            button7.Size = new Size(67, 56);
            button7.TabIndex = 4;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.lui;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(119, 2);
            button6.Name = "button6";
            button6.Size = new Size(67, 56);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.lui1;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(31, 1);
            button5.Name = "button5";
            button5.Size = new Size(62, 59);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.dv2;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(44, 490);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 26);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.dv1;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(2, 284);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 247);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.sach2;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(735, 371);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(254, 200);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // PhieuMuonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 665);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PhieuMuonForm";
            Text = "SachForm";
            Load += PhieuMuonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnTimKiem;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnInsert;
        private Label label2;
        private TextBox textBox8;
        private TextBox textBox6;
        private TextBox txtMaPM;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox6;
        private DateTimePicker dateTimePicker1;
    }
}