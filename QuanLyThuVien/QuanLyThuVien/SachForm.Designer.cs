namespace QuanLyThuVien
{
    partial class SachForm
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
            txtTimKiem = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            cmbTacGia = new ComboBox();
            cmbLoaiSach = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtSoLuong = new TextBox();
            txtNhaXB = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
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
            label2.Location = new Point(469, 23);
            label2.Name = "label2";
            label2.Size = new Size(129, 54);
            label2.TabIndex = 3;
            label2.Text = "SÁCH";
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
            pictureBox5.BackgroundImage = Properties.Resources.book;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Location = new Point(366, -3);
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 567);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnTimKiem);
            tabPage1.Controls.Add(txtTimKiem);
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(29, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(910, 413);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(245, 23);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(481, 43);
            txtTimKiem.TabIndex = 1;
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
            panel4.Controls.Add(cmbTacGia);
            panel4.Controls.Add(cmbLoaiSach);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtSoLuong);
            panel4.Controls.Add(txtNhaXB);
            panel4.Controls.Add(txtTenSach);
            panel4.Controls.Add(txtMaSach);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(86, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 442);
            panel4.TabIndex = 4;
            // 
            // cmbTacGia
            // 
            cmbTacGia.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTacGia.FormattingEnabled = true;
            cmbTacGia.Location = new Point(206, 199);
            cmbTacGia.Name = "cmbTacGia";
            cmbTacGia.Size = new Size(446, 40);
            cmbTacGia.TabIndex = 15;
            // 
            // cmbLoaiSach
            // 
            cmbLoaiSach.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLoaiSach.FormattingEnabled = true;
            cmbLoaiSach.Location = new Point(206, 140);
            cmbLoaiSach.Name = "cmbLoaiSach";
            cmbLoaiSach.Size = new Size(446, 40);
            cmbLoaiSach.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkViolet;
            label8.Location = new Point(3, 325);
            label8.Name = "label8";
            label8.Size = new Size(148, 32);
            label8.TabIndex = 12;
            label8.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkViolet;
            label7.Location = new Point(3, 264);
            label7.Name = "label7";
            label7.Size = new Size(197, 32);
            label7.TabIndex = 11;
            label7.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkViolet;
            label6.Location = new Point(3, 203);
            label6.Name = "label6";
            label6.Size = new Size(169, 32);
            label6.TabIndex = 10;
            label6.Text = "Tên tác giả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkViolet;
            label5.Location = new Point(3, 140);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 9;
            label5.Text = "Mã loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(3, 79);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 8;
            label4.Text = "Tên sách:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(206, 318);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(446, 39);
            txtSoLuong.TabIndex = 6;
            txtSoLuong.TextChanged += textBox7_TextChanged;
            // 
            // txtNhaXB
            // 
            txtNhaXB.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNhaXB.Location = new Point(206, 257);
            txtNhaXB.Name = "txtNhaXB";
            txtNhaXB.Size = new Size(446, 39);
            txtNhaXB.TabIndex = 5;
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenSach.Location = new Point(206, 72);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(446, 39);
            txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaSach.Location = new Point(206, 12);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(446, 39);
            txtMaSach.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkViolet;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 0;
            label3.Text = "Mã Sách:";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnInsert);
            panel3.Location = new Point(836, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 361);
            panel3.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.BackgroundImageLayout = ImageLayout.Center;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(15, 278);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(84, 80);
            btnNew.TabIndex = 3;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImageLayout = ImageLayout.Center;
            btnDelete.Image = Properties.Resources.xoa;
            btnDelete.Location = new Point(15, 106);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 80);
            btnDelete.TabIndex = 2;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImageLayout = ImageLayout.Center;
            btnUpdate.Image = Properties.Resources.update;
            btnUpdate.Location = new Point(15, 192);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 80);
            btnUpdate.TabIndex = 1;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            btnInsert.Click += btnInsert_Click;
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
            pictureBox6.BackgroundImage = Properties.Resources.sach1;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(809, 409);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(184, 142);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // SachForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 665);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "SachForm";
            Text = "SachForm";
            Load += SachForm_Load;
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
        private TextBox txtTimKiem;
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
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label2;
        private Label label3;
        private TextBox txtSoLuong;
        private TextBox txtNhaXB;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox6;
        private ComboBox cmbLoaiSach;
        private ComboBox cmbTacGia;
    }
}