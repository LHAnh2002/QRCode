namespace QRCode
{
    partial class Taoqr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taoqr));
            this.LvDT = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThemAnh = new System.Windows.Forms.Button();
            this.btXoaAnh = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btTaoMa = new System.Windows.Forms.Button();
            this.anhqr = new System.Windows.Forms.PictureBox();
            this.HinhThongTin = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LvDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhqr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // LvDT
            // 
            this.LvDT.AllowUserToAddRows = false;
            this.LvDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LvDT.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.LvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LvDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Hinh});
            this.LvDT.Location = new System.Drawing.Point(410, 181);
            this.LvDT.Name = "LvDT";
            this.LvDT.RowHeadersWidth = 51;
            this.LvDT.RowTemplate.Height = 29;
            this.LvDT.Size = new System.Drawing.Size(420, 554);
            this.LvDT.TabIndex = 2;
            this.LvDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LvDT_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình Thông Tin";
            this.Hinh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(113, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(231, 30);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Thứ Tự:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.btThemAnh);
            this.groupBox2.Controls.Add(this.btXoaAnh);
            this.groupBox2.Controls.Add(this.btLamMoi);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btTaoMa);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(410, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btThemAnh
            // 
            this.btThemAnh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThemAnh.Location = new System.Drawing.Point(150, 36);
            this.btThemAnh.Name = "btThemAnh";
            this.btThemAnh.Size = new System.Drawing.Size(111, 39);
            this.btThemAnh.TabIndex = 4;
            this.btThemAnh.Text = "Thêm Ảnh";
            this.btThemAnh.UseVisualStyleBackColor = true;
            this.btThemAnh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btXoaAnh
            // 
            this.btXoaAnh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoaAnh.Location = new System.Drawing.Point(33, 93);
            this.btXoaAnh.Name = "btXoaAnh";
            this.btXoaAnh.Size = new System.Drawing.Size(94, 39);
            this.btXoaAnh.TabIndex = 3;
            this.btXoaAnh.Text = "Xóa Ảnh";
            this.btXoaAnh.UseVisualStyleBackColor = true;
            this.btXoaAnh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLamMoi.Location = new System.Drawing.Point(150, 93);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(111, 39);
            this.btLamMoi.TabIndex = 2;
            this.btLamMoi.Text = "Làm Mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.LamMoi_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(288, 36);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(102, 39);
            this.btLuu.TabIndex = 1;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // btTaoMa
            // 
            this.btTaoMa.Location = new System.Drawing.Point(33, 36);
            this.btTaoMa.Name = "btTaoMa";
            this.btTaoMa.Size = new System.Drawing.Size(94, 37);
            this.btTaoMa.TabIndex = 0;
            this.btTaoMa.Text = "Tạo Mã";
            this.btTaoMa.UseVisualStyleBackColor = true;
            this.btTaoMa.Click += new System.EventHandler(this.TaoMa_Click);
            // 
            // anhqr
            // 
            this.anhqr.BackColor = System.Drawing.Color.Transparent;
            this.anhqr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anhqr.Location = new System.Drawing.Point(12, 181);
            this.anhqr.Name = "anhqr";
            this.anhqr.Size = new System.Drawing.Size(392, 366);
            this.anhqr.TabIndex = 5;
            this.anhqr.TabStop = false;
            // 
            // HinhThongTin
            // 
            this.HinhThongTin.BackColor = System.Drawing.Color.Transparent;
            this.HinhThongTin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HinhThongTin.Location = new System.Drawing.Point(12, 553);
            this.HinhThongTin.Name = "HinhThongTin";
            this.HinhThongTin.Size = new System.Drawing.Size(392, 182);
            this.HinhThongTin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HinhThongTin.TabIndex = 6;
            this.HinhThongTin.TabStop = false;
            this.HinhThongTin.Click += new System.EventHandler(this.HinhThongTin_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(113, 93);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(231, 30);
            this.txtTimKiem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(288, 93);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(102, 39);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // Taoqr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(848, 750);
            this.Controls.Add(this.HinhThongTin);
            this.Controls.Add(this.anhqr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LvDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Taoqr";
            this.Text = "Tạo Mã QR";
            this.Load += new System.EventHandler(this.Taoqr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LvDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhqr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView LvDT;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btLamMoi;
        private Button btLuu;
        private Button btTaoMa;
        private PictureBox anhqr;
        private PictureBox HinhThongTin;
        private Button btXoaAnh;
        private Button btThemAnh;
        private TextBox txtID;
        private Label label1;
        private TextBox txtThongTin;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenCanBo;
        private DataGridViewImageColumn Hinh;
        private TextBox txtTimKiem;
        private Button btTimKiem;
    }
}