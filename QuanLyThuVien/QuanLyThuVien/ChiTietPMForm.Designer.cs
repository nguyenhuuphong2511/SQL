namespace QuanLyThuVien
{
    partial class ChiTietPMForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btnTimKiem = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            cmbTrangThai = new ComboBox();
            lblTrangThai = new Label();
            label7 = new Label();
            label6 = new Label();
            txtMaSach = new TextBox();
            txtMaPM = new TextBox();
            panel3 = new Panel();
            btn = new Button();
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
            phieuMuonCTBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)phieuMuonCTBindingSource).BeginInit();
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
            label2.Size = new Size(257, 54);
            label2.TabIndex = 3;
            label2.Text = "CHI TIẾT PM";
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
            pictureBox5.BackgroundImage = Properties.Resources.icons8_spiral_bound_booklet_100;
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
            tabPage1.Controls.Add(txtSearch);
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
            dataGridView1.Location = new Point(96, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(799, 383);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackgroundImage = Properties.Resources.tim;
            btnTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimKiem.Location = new Point(745, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(52, 43);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(245, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(481, 43);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(104, 48);
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
            panel4.Controls.Add(cmbTrangThai);
            panel4.Controls.Add(lblTrangThai);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtMaSach);
            panel4.Controls.Add(txtMaPM);
            panel4.Location = new Point(85, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 338);
            panel4.TabIndex = 4;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Đang mượn", "Đã trả" });
            cmbTrangThai.Location = new Point(254, 240);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(167, 23);
            cmbTrangThai.TabIndex = 13;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.DarkViolet;
            lblTrangThai.Location = new Point(17, 230);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(158, 32);
            lblTrangThai.TabIndex = 12;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkViolet;
            label7.Location = new Point(17, 142);
            label7.Name = "label7";
            label7.Size = new Size(130, 32);
            label7.TabIndex = 11;
            label7.Text = "Mã sách:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkViolet;
            label6.Location = new Point(17, 37);
            label6.Name = "label6";
            label6.Size = new Size(232, 32);
            label6.TabIndex = 10;
            label6.Text = "Mã phiếu mượn:";
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaSach.Location = new Point(255, 135);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(429, 39);
            txtMaSach.TabIndex = 5;
            // 
            // txtMaPM
            // 
            txtMaPM.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaPM.Location = new Point(255, 30);
            txtMaPM.Name = "txtMaPM";
            txtMaPM.Size = new Size(429, 39);
            txtMaPM.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnInsert);
            panel3.Location = new Point(836, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 361);
            panel3.TabIndex = 3;
            // 
            // btn
            // 
            btn.BackgroundImageLayout = ImageLayout.Center;
            btn.Image = Properties.Resources._new;
            btn.Location = new Point(15, 278);
            btn.Name = "btn";
            btn.Size = new Size(84, 80);
            btn.TabIndex = 3;
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click_1;
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
            pictureBox6.BackgroundImage = Properties.Resources.sach;
            pictureBox6.Location = new Point(776, 370);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(198, 161);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // phieuMuonCTBindingSource
            // 
            phieuMuonCTBindingSource.DataSource = typeof(DTO.PhieuMuonCT);
            // 
            // ChiTietPMForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 665);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ChiTietPMForm";
            Text = "SachForm";
            Load += ChiTietPMForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)phieuMuonCTBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnTimKiem;
        private TextBox txtSearch;
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
        private Button btn;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label2;
        private TextBox txtMaSach;
        private TextBox txtMaPM;
        private Label lblTrangThai;
        private Label label7;
        private Label label6;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox6;
        private ComboBox cmbTrangThai;
        private BindingSource phieuMuonCTBindingSource;
    }
}