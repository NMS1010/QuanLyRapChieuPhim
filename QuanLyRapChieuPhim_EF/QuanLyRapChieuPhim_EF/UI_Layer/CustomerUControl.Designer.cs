namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class CustomerUControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editBtn = new System.Windows.Forms.Button();
            this.birthdayDTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressRtxb = new System.Windows.Forms.RichTextBox();
            this.cumulativePointTxb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneTxb = new System.Windows.Forms.TextBox();
            this.customerNameTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionButtonPnl = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sexCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerIdTxb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.propertySearchCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.functionButtonPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Yellow;
            this.editBtn.Location = new System.Drawing.Point(194, 10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(124, 49);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // birthdayDTimePicker
            // 
            this.birthdayDTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthdayDTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayDTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDTimePicker.Location = new System.Drawing.Point(120, 84);
            this.birthdayDTimePicker.Name = "birthdayDTimePicker";
            this.birthdayDTimePicker.Size = new System.Drawing.Size(174, 22);
            this.birthdayDTimePicker.TabIndex = 22;
            this.birthdayDTimePicker.ValueChanged += new System.EventHandler(this.birthdayDTimePicker_ValueChanged);
            // 
            // addressRtxb
            // 
            this.addressRtxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressRtxb.Location = new System.Drawing.Point(470, 115);
            this.addressRtxb.Name = "addressRtxb";
            this.addressRtxb.Size = new System.Drawing.Size(173, 43);
            this.addressRtxb.TabIndex = 19;
            this.addressRtxb.Text = "";
            this.addressRtxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // cumulativePointTxb
            // 
            this.cumulativePointTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulativePointTxb.Location = new System.Drawing.Point(470, 87);
            this.cumulativePointTxb.Name = "cumulativePointTxb";
            this.cumulativePointTxb.Size = new System.Drawing.Size(173, 22);
            this.cumulativePointTxb.TabIndex = 18;
            this.cumulativePointTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(329, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Điểm tích luỹ";
            // 
            // phoneTxb
            // 
            this.phoneTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxb.Location = new System.Drawing.Point(470, 42);
            this.phoneTxb.Name = "phoneTxb";
            this.phoneTxb.Size = new System.Drawing.Size(173, 22);
            this.phoneTxb.TabIndex = 14;
            this.phoneTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // customerNameTxb
            // 
            this.customerNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTxb.Location = new System.Drawing.Point(120, 42);
            this.customerNameTxb.Name = "customerNameTxb";
            this.customerNameTxb.Size = new System.Drawing.Size(174, 22);
            this.customerNameTxb.TabIndex = 8;
            this.customerNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Yellow;
            this.addBtn.Location = new System.Drawing.Point(24, 10);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(124, 49);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Yellow;
            this.reloadBtn.Location = new System.Drawing.Point(896, 10);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(124, 49);
            this.reloadBtn.TabIndex = 5;
            this.reloadBtn.Text = "Tải lại";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Yellow;
            this.cancelBtn.Location = new System.Drawing.Point(715, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 49);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Huỷ";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Yellow;
            this.saveBtn.Location = new System.Drawing.Point(543, 10);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 49);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.SoDienThoai,
            this.DiemTichLuy,
            this.GioiTinh});
            this.customerDataGridView.Location = new System.Drawing.Point(3, 294);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.Size = new System.Drawing.Size(1039, 438);
            this.customerDataGridView.TabIndex = 9;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 160;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 140;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 220;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 140;
            // 
            // DiemTichLuy
            // 
            this.DiemTichLuy.DataPropertyName = "DiemTichLuy";
            this.DiemTichLuy.HeaderText = "Điểm tích luỹ";
            this.DiemTichLuy.Name = "DiemTichLuy";
            this.DiemTichLuy.ReadOnly = true;
            this.DiemTichLuy.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 110;
            // 
            // functionButtonPnl
            // 
            this.functionButtonPnl.BackColor = System.Drawing.Color.Silver;
            this.functionButtonPnl.Controls.Add(this.reloadBtn);
            this.functionButtonPnl.Controls.Add(this.cancelBtn);
            this.functionButtonPnl.Controls.Add(this.saveBtn);
            this.functionButtonPnl.Controls.Add(this.removeBtn);
            this.functionButtonPnl.Controls.Add(this.editBtn);
            this.functionButtonPnl.Controls.Add(this.addBtn);
            this.functionButtonPnl.Location = new System.Drawing.Point(3, 218);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(1039, 70);
            this.functionButtonPnl.TabIndex = 11;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Yellow;
            this.removeBtn.Location = new System.Drawing.Point(373, 10);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(124, 49);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Xoá";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.customerIdTxb);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 209);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexCbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.birthdayDTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addressRtxb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cumulativePointTxb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.phoneTxb);
            this.groupBox1.Controls.Add(this.customerNameTxb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 177);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // sexCbx
            // 
            this.sexCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexCbx.FormattingEnabled = true;
            this.sexCbx.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.sexCbx.Location = new System.Drawing.Point(120, 129);
            this.sexCbx.Name = "sexCbx";
            this.sexCbx.Size = new System.Drawing.Size(174, 24);
            this.sexCbx.TabIndex = 24;
            this.sexCbx.SelectedIndexChanged += new System.EventHandler(this.sexCbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Giới tính";
            // 
            // customerIdTxb
            // 
            this.customerIdTxb.Location = new System.Drawing.Point(174, 142);
            this.customerIdTxb.Name = "customerIdTxb";
            this.customerIdTxb.Size = new System.Drawing.Size(161, 20);
            this.customerIdTxb.TabIndex = 7;
            this.customerIdTxb.Visible = false;
            this.customerIdTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchTxb);
            this.groupBox2.Controls.Add(this.propertySearchCbx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(755, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 147);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(43, 103);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(185, 29);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxb
            // 
            this.searchTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxb.Location = new System.Drawing.Point(43, 68);
            this.searchTxb.Name = "searchTxb";
            this.searchTxb.Size = new System.Drawing.Size(185, 29);
            this.searchTxb.TabIndex = 2;
            // 
            // propertySearchCbx
            // 
            this.propertySearchCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertySearchCbx.FormattingEnabled = true;
            this.propertySearchCbx.Location = new System.Drawing.Point(111, 28);
            this.propertySearchCbx.Name = "propertySearchCbx";
            this.propertySearchCbx.Size = new System.Drawing.Size(148, 26);
            this.propertySearchCbx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thuộc tính";
            // 
            // CustomerUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.functionButtonPnl);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1045, 735);
            this.MinimumSize = new System.Drawing.Size(1045, 735);
            this.Name = "CustomerUControl";
            this.Size = new System.Drawing.Size(1045, 735);
            this.Load += new System.EventHandler(this.CustomerUControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.functionButtonPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DateTimePicker birthdayDTimePicker;
        private System.Windows.Forms.RichTextBox addressRtxb;
        private System.Windows.Forms.TextBox cumulativePointTxb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneTxb;
        private System.Windows.Forms.TextBox customerNameTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerIdTxb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sexCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTichLuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.ComboBox propertySearchCbx;
        private System.Windows.Forms.Label label4;
    }
}
