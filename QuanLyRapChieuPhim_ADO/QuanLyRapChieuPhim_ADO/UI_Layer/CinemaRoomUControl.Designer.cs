namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    partial class CinemaRoomUControl
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
            this.reloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.functionButtonPnl = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.screenNameCinemaRoomCbx = new System.Windows.Forms.ComboBox();
            this.totalChairPerRowTxb = new System.Windows.Forms.TextBox();
            this.totalSeatTxb = new System.Windows.Forms.TextBox();
            this.totalNumberRowChairTxb = new System.Windows.Forms.TextBox();
            this.cinemaRoomNameTxb = new System.Windows.Forms.TextBox();
            this.cinemaRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.MaPhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHangGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGheMoiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemaRoomIdTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cinemaRoomStatusCbx = new System.Windows.Forms.ComboBox();
            this.functionButtonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaRoomDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.functionButtonPnl.Location = new System.Drawing.Point(879, 187);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(149, 435);
            this.functionButtonPnl.TabIndex = 5;
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
            // screenNameCinemaRoomCbx
            // 
            this.screenNameCinemaRoomCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenNameCinemaRoomCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenNameCinemaRoomCbx.FormattingEnabled = true;
            this.screenNameCinemaRoomCbx.Location = new System.Drawing.Point(182, 110);
            this.screenNameCinemaRoomCbx.Name = "screenNameCinemaRoomCbx";
            this.screenNameCinemaRoomCbx.Size = new System.Drawing.Size(160, 24);
            this.screenNameCinemaRoomCbx.TabIndex = 13;
            this.screenNameCinemaRoomCbx.SelectedIndexChanged += new System.EventHandler(this.screenNameCinemaRoomCbx_SelectedIndexChanged);
            this.screenNameCinemaRoomCbx.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // totalChairPerRowTxb
            // 
            this.totalChairPerRowTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalChairPerRowTxb.Location = new System.Drawing.Point(558, 115);
            this.totalChairPerRowTxb.Name = "totalChairPerRowTxb";
            this.totalChairPerRowTxb.Size = new System.Drawing.Size(129, 22);
            this.totalChairPerRowTxb.TabIndex = 11;
            this.totalChairPerRowTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // totalSeatTxb
            // 
            this.totalSeatTxb.Enabled = false;
            this.totalSeatTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSeatTxb.Location = new System.Drawing.Point(558, 39);
            this.totalSeatTxb.Name = "totalSeatTxb";
            this.totalSeatTxb.Size = new System.Drawing.Size(129, 22);
            this.totalSeatTxb.TabIndex = 10;
            this.totalSeatTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // totalNumberRowChairTxb
            // 
            this.totalNumberRowChairTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberRowChairTxb.Location = new System.Drawing.Point(558, 77);
            this.totalNumberRowChairTxb.Name = "totalNumberRowChairTxb";
            this.totalNumberRowChairTxb.Size = new System.Drawing.Size(129, 22);
            this.totalNumberRowChairTxb.TabIndex = 10;
            this.totalNumberRowChairTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // cinemaRoomNameTxb
            // 
            this.cinemaRoomNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaRoomNameTxb.Location = new System.Drawing.Point(182, 76);
            this.cinemaRoomNameTxb.Name = "cinemaRoomNameTxb";
            this.cinemaRoomNameTxb.Size = new System.Drawing.Size(161, 22);
            this.cinemaRoomNameTxb.TabIndex = 8;
            this.cinemaRoomNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // cinemaRoomDataGridView
            // 
            this.cinemaRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cinemaRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongChieu,
            this.TinhTrang,
            this.TenPhong,
            this.LoaiManHinh,
            this.TongSoGhe,
            this.SoHangGhe,
            this.SoGheMoiHang});
            this.cinemaRoomDataGridView.Location = new System.Drawing.Point(3, 186);
            this.cinemaRoomDataGridView.MultiSelect = false;
            this.cinemaRoomDataGridView.Name = "cinemaRoomDataGridView";
            this.cinemaRoomDataGridView.ReadOnly = true;
            this.cinemaRoomDataGridView.Size = new System.Drawing.Size(870, 436);
            this.cinemaRoomDataGridView.TabIndex = 3;
            this.cinemaRoomDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cinemaRoomDataGridView_CellClick);
            // 
            // MaPhongChieu
            // 
            this.MaPhongChieu.DataPropertyName = "MaPhongChieu";
            this.MaPhongChieu.HeaderText = "Mã Phòng Chiếu";
            this.MaPhongChieu.Name = "MaPhongChieu";
            this.MaPhongChieu.ReadOnly = true;
            this.MaPhongChieu.Width = 130;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 120;
            // 
            // LoaiManHinh
            // 
            this.LoaiManHinh.DataPropertyName = "LoaiManHinh";
            this.LoaiManHinh.HeaderText = "Loại màn hình";
            this.LoaiManHinh.Name = "LoaiManHinh";
            this.LoaiManHinh.ReadOnly = true;
            this.LoaiManHinh.Width = 120;
            // 
            // TongSoGhe
            // 
            this.TongSoGhe.DataPropertyName = "TongSoGhe";
            this.TongSoGhe.HeaderText = "Tổng số ghế";
            this.TongSoGhe.Name = "TongSoGhe";
            this.TongSoGhe.ReadOnly = true;
            this.TongSoGhe.Width = 120;
            // 
            // SoHangGhe
            // 
            this.SoHangGhe.DataPropertyName = "SoHangGhe";
            this.SoHangGhe.HeaderText = "Số hàng ghế";
            this.SoHangGhe.Name = "SoHangGhe";
            this.SoHangGhe.ReadOnly = true;
            this.SoHangGhe.Width = 120;
            // 
            // SoGheMoiHang
            // 
            this.SoGheMoiHang.DataPropertyName = "SoGheMoiHang";
            this.SoGheMoiHang.HeaderText = "Số ghế mỗi hàng";
            this.SoGheMoiHang.Name = "SoGheMoiHang";
            this.SoGheMoiHang.ReadOnly = true;
            this.SoGheMoiHang.Width = 120;
            // 
            // cinemaRoomIdTxb
            // 
            this.cinemaRoomIdTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaRoomIdTxb.Location = new System.Drawing.Point(182, 39);
            this.cinemaRoomIdTxb.Name = "cinemaRoomIdTxb";
            this.cinemaRoomIdTxb.Size = new System.Drawing.Size(161, 22);
            this.cinemaRoomIdTxb.TabIndex = 7;
            this.cinemaRoomIdTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số ghế mỗi hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số hàng ghế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số ghế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Màn hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng chiếu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 177);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cinemaRoomStatusCbx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.screenNameCinemaRoomCbx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.totalChairPerRowTxb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.totalSeatTxb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totalNumberRowChairTxb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cinemaRoomNameTxb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cinemaRoomIdTxb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng chiếu";
            // 
            // cinemaRoomStatusCbx
            // 
            this.cinemaRoomStatusCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinemaRoomStatusCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaRoomStatusCbx.FormattingEnabled = true;
            this.cinemaRoomStatusCbx.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cinemaRoomStatusCbx.Location = new System.Drawing.Point(740, 73);
            this.cinemaRoomStatusCbx.Name = "cinemaRoomStatusCbx";
            this.cinemaRoomStatusCbx.Size = new System.Drawing.Size(161, 24);
            this.cinemaRoomStatusCbx.TabIndex = 15;
            this.cinemaRoomStatusCbx.SelectedValueChanged += new System.EventHandler(this.cinemaRoomStatusCbx_SelectedValueChanged);
            // 
            // CinemaRoomUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.functionButtonPnl);
            this.Controls.Add(this.cinemaRoomDataGridView);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1035, 625);
            this.MinimumSize = new System.Drawing.Size(1035, 625);
            this.Name = "CinemaRoomUControl";
            this.Size = new System.Drawing.Size(1035, 625);
            this.Load += new System.EventHandler(this.CinemaRoomUControl_Load);
            this.functionButtonPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaRoomDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox screenNameCinemaRoomCbx;
        private System.Windows.Forms.TextBox totalChairPerRowTxb;
        private System.Windows.Forms.TextBox totalSeatTxb;
        private System.Windows.Forms.TextBox totalNumberRowChairTxb;
        private System.Windows.Forms.TextBox cinemaRoomNameTxb;
        private System.Windows.Forms.DataGridView cinemaRoomDataGridView;
        private System.Windows.Forms.TextBox cinemaRoomIdTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cinemaRoomStatusCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHangGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGheMoiHang;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
