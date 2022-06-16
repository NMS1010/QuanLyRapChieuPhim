namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    partial class MovieUControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.MaBoPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.movieStatusCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genreCheckLstbox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDateDTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.startDateDTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.filmDesRtxb = new System.Windows.Forms.RichTextBox();
            this.filmIdTxb = new System.Windows.Forms.TextBox();
            this.studioFilmTxb = new System.Windows.Forms.TextBox();
            this.filmNameTxb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalFilmTimeTxb = new System.Windows.Forms.TextBox();
            this.directorTxb = new System.Windows.Forms.TextBox();
            this.yearTxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.functionButtonPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.functionButtonPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AllowUserToDeleteRows = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBoPhim,
            this.TrangThai,
            this.TenPhim,
            this.MoTa,
            this.ThoiLuong,
            this.NgayKhoiChieu,
            this.NgayKetThuc,
            this.NamSX,
            this.DaoDien,
            this.TenHangPhim,
            this.TheLoai});
            this.movieDataGridView.Location = new System.Drawing.Point(3, 233);
            this.movieDataGridView.MultiSelect = false;
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.ReadOnly = true;
            this.movieDataGridView.Size = new System.Drawing.Size(870, 385);
            this.movieDataGridView.TabIndex = 6;
            this.movieDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDataGridView_CellClick);
            // 
            // MaBoPhim
            // 
            this.MaBoPhim.DataPropertyName = "MaBoPhim";
            this.MaBoPhim.HeaderText = "Mã phim";
            this.MaBoPhim.Name = "MaBoPhim";
            this.MaBoPhim.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.DataPropertyName = "ThoiLuong";
            this.ThoiLuong.HeaderText = "Thời lượng";
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.ReadOnly = true;
            // 
            // NgayKhoiChieu
            // 
            this.NgayKhoiChieu.DataPropertyName = "NgayKhoiChieu";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.NgayKhoiChieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayKhoiChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayKhoiChieu.Name = "NgayKhoiChieu";
            this.NgayKhoiChieu.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NgayKetThuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // NamSX
            // 
            this.NamSX.DataPropertyName = "NamSX";
            this.NamSX.HeaderText = "Năm sản xuất";
            this.NamSX.Name = "NamSX";
            this.NamSX.ReadOnly = true;
            // 
            // DaoDien
            // 
            this.DaoDien.DataPropertyName = "DaoDien";
            this.DaoDien.HeaderText = "Đạo diễn";
            this.DaoDien.Name = "DaoDien";
            this.DaoDien.ReadOnly = true;
            // 
            // TenHangPhim
            // 
            this.TenHangPhim.DataPropertyName = "TenHangPhim";
            this.TenHangPhim.HeaderText = "Tên Hãng Phim";
            this.TenHangPhim.Name = "TenHangPhim";
            this.TenHangPhim.ReadOnly = true;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 224);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.movieStatusCbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genreCheckLstbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.endDateDTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.startDateDTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.filmDesRtxb);
            this.groupBox1.Controls.Add(this.filmIdTxb);
            this.groupBox1.Controls.Add(this.studioFilmTxb);
            this.groupBox1.Controls.Add(this.filmNameTxb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.totalFilmTimeTxb);
            this.groupBox1.Controls.Add(this.directorTxb);
            this.groupBox1.Controls.Add(this.yearTxb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(568, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phim";
            // 
            // movieStatusCbx
            // 
            this.movieStatusCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieStatusCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieStatusCbx.FormattingEnabled = true;
            this.movieStatusCbx.Items.AddRange(new object[] {
            "1",
            "0"});
            this.movieStatusCbx.Location = new System.Drawing.Point(121, 176);
            this.movieStatusCbx.Name = "movieStatusCbx";
            this.movieStatusCbx.Size = new System.Drawing.Size(161, 24);
            this.movieStatusCbx.TabIndex = 28;
            this.movieStatusCbx.SelectedIndexChanged += new System.EventHandler(this.movieStatusCbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // genreCheckLstbox
            // 
            this.genreCheckLstbox.CheckOnClick = true;
            this.genreCheckLstbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreCheckLstbox.FormattingEnabled = true;
            this.genreCheckLstbox.HorizontalScrollbar = true;
            this.genreCheckLstbox.Location = new System.Drawing.Point(481, 133);
            this.genreCheckLstbox.MultiColumn = true;
            this.genreCheckLstbox.Name = "genreCheckLstbox";
            this.genreCheckLstbox.Size = new System.Drawing.Size(227, 72);
            this.genreCheckLstbox.TabIndex = 26;
            this.genreCheckLstbox.SelectedIndexChanged += new System.EventHandler(this.genreCheckLstbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời lượng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(305, 143);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 25);
            this.label.TabIndex = 25;
            this.label.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm sản xuất";
            // 
            // endDateDTimePicker
            // 
            this.endDateDTimePicker.CustomFormat = "dd/MM/yyyy";
            this.endDateDTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateDTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateDTimePicker.Location = new System.Drawing.Point(481, 98);
            this.endDateDTimePicker.Name = "endDateDTimePicker";
            this.endDateDTimePicker.Size = new System.Drawing.Size(115, 22);
            this.endDateDTimePicker.TabIndex = 23;
            this.endDateDTimePicker.ValueChanged += new System.EventHandler(this.endDateDTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày khởi chiếu";
            // 
            // startDateDTimePicker
            // 
            this.startDateDTimePicker.CustomFormat = "dd/MM/yyyy";
            this.startDateDTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateDTimePicker.Location = new System.Drawing.Point(481, 56);
            this.startDateDTimePicker.Name = "startDateDTimePicker";
            this.startDateDTimePicker.Size = new System.Drawing.Size(115, 22);
            this.startDateDTimePicker.TabIndex = 22;
            this.startDateDTimePicker.ValueChanged += new System.EventHandler(this.startDateDTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày kết thúc";
            // 
            // filmDesRtxb
            // 
            this.filmDesRtxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmDesRtxb.Location = new System.Drawing.Point(121, 110);
            this.filmDesRtxb.Name = "filmDesRtxb";
            this.filmDesRtxb.Size = new System.Drawing.Size(161, 58);
            this.filmDesRtxb.TabIndex = 19;
            this.filmDesRtxb.Text = "";
            this.filmDesRtxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // filmIdTxb
            // 
            this.filmIdTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmIdTxb.Location = new System.Drawing.Point(121, 27);
            this.filmIdTxb.Name = "filmIdTxb";
            this.filmIdTxb.Size = new System.Drawing.Size(161, 22);
            this.filmIdTxb.TabIndex = 7;
            this.filmIdTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // studioFilmTxb
            // 
            this.studioFilmTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioFilmTxb.Location = new System.Drawing.Point(864, 106);
            this.studioFilmTxb.Name = "studioFilmTxb";
            this.studioFilmTxb.Size = new System.Drawing.Size(129, 22);
            this.studioFilmTxb.TabIndex = 18;
            this.studioFilmTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // filmNameTxb
            // 
            this.filmNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmNameTxb.Location = new System.Drawing.Point(121, 75);
            this.filmNameTxb.Name = "filmNameTxb";
            this.filmNameTxb.Size = new System.Drawing.Size(161, 22);
            this.filmNameTxb.TabIndex = 8;
            this.filmNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(718, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên hãng";
            // 
            // totalFilmTimeTxb
            // 
            this.totalFilmTimeTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFilmTimeTxb.Location = new System.Drawing.Point(481, 18);
            this.totalFilmTimeTxb.Name = "totalFilmTimeTxb";
            this.totalFilmTimeTxb.Size = new System.Drawing.Size(81, 22);
            this.totalFilmTimeTxb.TabIndex = 10;
            this.totalFilmTimeTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // directorTxb
            // 
            this.directorTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorTxb.Location = new System.Drawing.Point(864, 66);
            this.directorTxb.Name = "directorTxb";
            this.directorTxb.Size = new System.Drawing.Size(129, 22);
            this.directorTxb.TabIndex = 16;
            this.directorTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // yearTxb
            // 
            this.yearTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTxb.Location = new System.Drawing.Point(864, 27);
            this.yearTxb.Name = "yearTxb";
            this.yearTxb.Size = new System.Drawing.Size(129, 22);
            this.yearTxb.TabIndex = 14;
            this.yearTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(718, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Đạo diễn";
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
            this.functionButtonPnl.Location = new System.Drawing.Point(879, 233);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(149, 384);
            this.functionButtonPnl.TabIndex = 8;
            // 
            // MovieUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.functionButtonPnl);
            this.MaximumSize = new System.Drawing.Size(1035, 625);
            this.MinimumSize = new System.Drawing.Size(1035, 625);
            this.Name = "MovieUControl";
            this.Size = new System.Drawing.Size(1035, 625);
            this.Load += new System.EventHandler(this.MovieUControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.functionButtonPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBoPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox movieStatusCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox genreCheckLstbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDateDTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startDateDTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox filmDesRtxb;
        private System.Windows.Forms.TextBox filmIdTxb;
        private System.Windows.Forms.TextBox studioFilmTxb;
        private System.Windows.Forms.TextBox filmNameTxb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalFilmTimeTxb;
        private System.Windows.Forms.TextBox directorTxb;
        private System.Windows.Forms.TextBox yearTxb;
        private System.Windows.Forms.Label label8;
    }
}
