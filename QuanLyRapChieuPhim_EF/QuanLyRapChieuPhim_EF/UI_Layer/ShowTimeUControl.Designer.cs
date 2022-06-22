namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class ShowTimeUControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.MaSuatChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTicketTxb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showTimeTimeDtimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.formatFilmTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showTimeStatusCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showTimeIdTxb = new System.Windows.Forms.TextBox();
            this.filmNameCbx = new System.Windows.Forms.ComboBox();
            this.showTimeDateDtimePicker = new System.Windows.Forms.DateTimePicker();
            this.cinemaRoomNameCbx = new System.Windows.Forms.ComboBox();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.functionButtonPnl = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.propertySearchCbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.functionButtonPnl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTimeDataGridView
            // 
            this.showTimeDataGridView.AllowUserToDeleteRows = false;
            this.showTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuatChieu,
            this.TrangThai,
            this.TenPhim,
            this.TenPhongChieu,
            this.TenDinhDang,
            this.NgayChieu,
            this.GioChieu,
            this.GiaVe});
            this.showTimeDataGridView.Location = new System.Drawing.Point(5, 178);
            this.showTimeDataGridView.MultiSelect = false;
            this.showTimeDataGridView.Name = "showTimeDataGridView";
            this.showTimeDataGridView.ReadOnly = true;
            this.showTimeDataGridView.Size = new System.Drawing.Size(870, 426);
            this.showTimeDataGridView.TabIndex = 6;
            this.showTimeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showTimeDataGridView_CellClick);
            // 
            // MaSuatChieu
            // 
            this.MaSuatChieu.DataPropertyName = "MaSuatChieu";
            this.MaSuatChieu.HeaderText = "Mã Suất chiếu";
            this.MaSuatChieu.Name = "MaSuatChieu";
            this.MaSuatChieu.ReadOnly = true;
            this.MaSuatChieu.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            this.TenPhim.Width = 165;
            // 
            // TenPhongChieu
            // 
            this.TenPhongChieu.DataPropertyName = "TenPhongChieu";
            this.TenPhongChieu.HeaderText = "Phòng chiếu";
            this.TenPhongChieu.Name = "TenPhongChieu";
            this.TenPhongChieu.ReadOnly = true;
            // 
            // TenDinhDang
            // 
            this.TenDinhDang.DataPropertyName = "TenDinhDang";
            this.TenDinhDang.HeaderText = "Định dạng";
            this.TenDinhDang.Name = "TenDinhDang";
            this.TenDinhDang.ReadOnly = true;
            // 
            // NgayChieu
            // 
            this.NgayChieu.DataPropertyName = "NgayChieu";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.NgayChieu.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgayChieu.HeaderText = "Ngày chiếu";
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            this.NgayChieu.Width = 140;
            // 
            // GioChieu
            // 
            this.GioChieu.DataPropertyName = "GioChieu";
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.GioChieu.DefaultCellStyle = dataGridViewCellStyle6;
            this.GioChieu.HeaderText = "Giờ chiếu";
            this.GioChieu.Name = "GioChieu";
            this.GioChieu.ReadOnly = true;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            // 
            // priceTicketTxb
            // 
            this.priceTicketTxb.Enabled = false;
            this.priceTicketTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTicketTxb.Location = new System.Drawing.Point(165, 108);
            this.priceTicketTxb.Name = "priceTicketTxb";
            this.priceTicketTxb.Size = new System.Drawing.Size(203, 22);
            this.priceTicketTxb.TabIndex = 21;
            this.priceTicketTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 169);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showTimeTimeDtimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.formatFilmTxb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.showTimeStatusCbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceTicketTxb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.showTimeIdTxb);
            this.groupBox1.Controls.Add(this.filmNameCbx);
            this.groupBox1.Controls.Add(this.showTimeDateDtimePicker);
            this.groupBox1.Controls.Add(this.cinemaRoomNameCbx);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin suất chiếu";
            // 
            // showTimeTimeDtimePicker
            // 
            this.showTimeTimeDtimePicker.CustomFormat = "HH:mm";
            this.showTimeTimeDtimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeTimeDtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.showTimeTimeDtimePicker.Location = new System.Drawing.Point(270, 71);
            this.showTimeTimeDtimePicker.Name = "showTimeTimeDtimePicker";
            this.showTimeTimeDtimePicker.Size = new System.Drawing.Size(98, 22);
            this.showTimeTimeDtimePicker.TabIndex = 25;
            this.showTimeTimeDtimePicker.ValueChanged += new System.EventHandler(this.showTimeTimeDtimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã suất chiếu";
            // 
            // formatFilmTxb
            // 
            this.formatFilmTxb.Enabled = false;
            this.formatFilmTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatFilmTxb.Location = new System.Drawing.Point(534, 133);
            this.formatFilmTxb.Name = "formatFilmTxb";
            this.formatFilmTxb.Size = new System.Drawing.Size(129, 22);
            this.formatFilmTxb.TabIndex = 24;
            this.formatFilmTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian chiếu";
            // 
            // showTimeStatusCbx
            // 
            this.showTimeStatusCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "0"});
            this.showTimeStatusCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTimeStatusCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeStatusCbx.FormattingEnabled = true;
            this.showTimeStatusCbx.Items.AddRange(new object[] {
            "1",
            "0"});
            this.showTimeStatusCbx.Location = new System.Drawing.Point(534, 90);
            this.showTimeStatusCbx.Name = "showTimeStatusCbx";
            this.showTimeStatusCbx.Size = new System.Drawing.Size(129, 24);
            this.showTimeStatusCbx.TabIndex = 23;
            this.showTimeStatusCbx.SelectedIndexChanged += new System.EventHandler(this.IndexChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên phim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Giá vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phòng chiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Định dạng";
            // 
            // showTimeIdTxb
            // 
            this.showTimeIdTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeIdTxb.Location = new System.Drawing.Point(165, 38);
            this.showTimeIdTxb.Name = "showTimeIdTxb";
            this.showTimeIdTxb.Size = new System.Drawing.Size(203, 22);
            this.showTimeIdTxb.TabIndex = 7;
            this.showTimeIdTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // filmNameCbx
            // 
            this.filmNameCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmNameCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmNameCbx.FormattingEnabled = true;
            this.filmNameCbx.Location = new System.Drawing.Point(534, 16);
            this.filmNameCbx.Name = "filmNameCbx";
            this.filmNameCbx.Size = new System.Drawing.Size(129, 24);
            this.filmNameCbx.TabIndex = 17;
            this.filmNameCbx.SelectedIndexChanged += new System.EventHandler(this.IndexChange);
            // 
            // showTimeDateDtimePicker
            // 
            this.showTimeDateDtimePicker.CustomFormat = "dd/MM/yyyy";
            this.showTimeDateDtimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeDateDtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.showTimeDateDtimePicker.Location = new System.Drawing.Point(165, 71);
            this.showTimeDateDtimePicker.Name = "showTimeDateDtimePicker";
            this.showTimeDateDtimePicker.Size = new System.Drawing.Size(98, 22);
            this.showTimeDateDtimePicker.TabIndex = 15;
            this.showTimeDateDtimePicker.ValueChanged += new System.EventHandler(this.showTimeDateDtimePicker_ValueChanged);
            // 
            // cinemaRoomNameCbx
            // 
            this.cinemaRoomNameCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinemaRoomNameCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaRoomNameCbx.FormattingEnabled = true;
            this.cinemaRoomNameCbx.Location = new System.Drawing.Point(534, 54);
            this.cinemaRoomNameCbx.Name = "cinemaRoomNameCbx";
            this.cinemaRoomNameCbx.Size = new System.Drawing.Size(129, 24);
            this.cinemaRoomNameCbx.TabIndex = 16;
            this.cinemaRoomNameCbx.SelectedIndexChanged += new System.EventHandler(this.IndexChange);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Yellow;
            this.reloadBtn.Location = new System.Drawing.Point(13, 312);
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
            this.cancelBtn.Location = new System.Drawing.Point(13, 251);
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
            this.saveBtn.Location = new System.Drawing.Point(12, 194);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 49);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Yellow;
            this.removeBtn.Location = new System.Drawing.Point(13, 139);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(124, 49);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Xoá";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Yellow;
            this.editBtn.Location = new System.Drawing.Point(13, 81);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(124, 49);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Yellow;
            this.addBtn.Location = new System.Drawing.Point(13, 22);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(124, 49);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.functionButtonPnl.Location = new System.Drawing.Point(879, 179);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(149, 425);
            this.functionButtonPnl.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchTxb);
            this.groupBox2.Controls.Add(this.propertySearchCbx);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(738, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 147);
            this.groupBox2.TabIndex = 29;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thuộc tính";
            // 
            // ShowTimeUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showTimeDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.functionButtonPnl);
            this.MaximumSize = new System.Drawing.Size(1035, 616);
            this.MinimumSize = new System.Drawing.Size(1035, 616);
            this.Name = "ShowTimeUControl";
            this.Size = new System.Drawing.Size(1035, 616);
            this.Load += new System.EventHandler(this.ShowTimeUControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.functionButtonPnl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView showTimeDataGridView;
        private System.Windows.Forms.TextBox priceTicketTxb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filmNameCbx;
        private System.Windows.Forms.ComboBox cinemaRoomNameCbx;
        private System.Windows.Forms.DateTimePicker showTimeDateDtimePicker;
        private System.Windows.Forms.TextBox showTimeIdTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.ComboBox showTimeStatusCbx;
        private System.Windows.Forms.TextBox formatFilmTxb;
        private System.Windows.Forms.DateTimePicker showTimeTimeDtimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuatChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.ComboBox propertySearchCbx;
        private System.Windows.Forms.Label label8;
    }
}
