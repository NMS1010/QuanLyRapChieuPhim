namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    partial class TicketUControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ticketGenDataGridView = new System.Windows.Forms.DataGridView();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TInhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketGenBtn = new System.Windows.Forms.Button();
            this.showTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.MaSuatChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.removeTicketBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketGenDataGridView
            // 
            this.ticketGenDataGridView.AllowUserToDeleteRows = false;
            this.ticketGenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVe,
            this.TInhTrang,
            this.MaGhe,
            this.MaKhachHang,
            this.MaLichChieu,
            this.LoaiVe,
            this.TienVe,
            this.NgayMua});
            this.ticketGenDataGridView.Location = new System.Drawing.Point(3, 356);
            this.ticketGenDataGridView.MultiSelect = false;
            this.ticketGenDataGridView.Name = "ticketGenDataGridView";
            this.ticketGenDataGridView.ReadOnly = true;
            this.ticketGenDataGridView.Size = new System.Drawing.Size(908, 376);
            this.ticketGenDataGridView.TabIndex = 0;
            // 
            // MaVe
            // 
            this.MaVe.DataPropertyName = "MaVe";
            this.MaVe.HeaderText = "Mã vé";
            this.MaVe.Name = "MaVe";
            this.MaVe.ReadOnly = true;
            this.MaVe.Width = 120;
            // 
            // TInhTrang
            // 
            this.TInhTrang.DataPropertyName = "TrangThai";
            this.TInhTrang.HeaderText = "Trạng thái";
            this.TInhTrang.Name = "TInhTrang";
            this.TInhTrang.ReadOnly = true;
            // 
            // MaGhe
            // 
            this.MaGhe.DataPropertyName = "MaGhe";
            this.MaGhe.HeaderText = "Mã ghế";
            this.MaGhe.Name = "MaGhe";
            this.MaGhe.ReadOnly = true;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Width = 140;
            // 
            // MaLichChieu
            // 
            this.MaLichChieu.DataPropertyName = "MaSuatChieu";
            this.MaLichChieu.HeaderText = "Mã suất chiếu";
            this.MaLichChieu.Name = "MaLichChieu";
            this.MaLichChieu.ReadOnly = true;
            this.MaLichChieu.Width = 140;
            // 
            // LoaiVe
            // 
            this.LoaiVe.DataPropertyName = "LoaiVe";
            this.LoaiVe.HeaderText = "Loại vé";
            this.LoaiVe.Name = "LoaiVe";
            this.LoaiVe.ReadOnly = true;
            this.LoaiVe.Width = 140;
            // 
            // TienVe
            // 
            this.TienVe.DataPropertyName = "TienVe";
            this.TienVe.HeaderText = "Tiền vé";
            this.TienVe.Name = "TienVe";
            this.TienVe.ReadOnly = true;
            this.TienVe.Width = 120;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayMua";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.NgayMua.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayMua.HeaderText = "Ngày mua";
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            // 
            // ticketGenBtn
            // 
            this.ticketGenBtn.Location = new System.Drawing.Point(935, 356);
            this.ticketGenBtn.Name = "ticketGenBtn";
            this.ticketGenBtn.Size = new System.Drawing.Size(94, 38);
            this.ticketGenBtn.TabIndex = 2;
            this.ticketGenBtn.Text = "Tạo vé";
            this.ticketGenBtn.UseVisualStyleBackColor = true;
            this.ticketGenBtn.Click += new System.EventHandler(this.ticketGenBtn_Click);
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
            this.TinhTrangVe,
            this.NgayChieu,
            this.GioChieu});
            this.showTimeDataGridView.Location = new System.Drawing.Point(3, 101);
            this.showTimeDataGridView.MultiSelect = false;
            this.showTimeDataGridView.Name = "showTimeDataGridView";
            this.showTimeDataGridView.ReadOnly = true;
            this.showTimeDataGridView.Size = new System.Drawing.Size(908, 238);
            this.showTimeDataGridView.TabIndex = 7;
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
            this.TenPhim.Width = 160;
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
            this.TenDinhDang.Width = 80;
            // 
            // TinhTrangVe
            // 
            this.TinhTrangVe.DataPropertyName = "TinhTrangVe";
            this.TinhTrangVe.HeaderText = "Tình trạng vé";
            this.TinhTrangVe.Name = "TinhTrangVe";
            this.TinhTrangVe.ReadOnly = true;
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
            // 
            // GioChieu
            // 
            this.GioChieu.DataPropertyName = "GioChieu";
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.GioChieu.DefaultCellStyle = dataGridViewCellStyle6;
            this.GioChieu.HeaderText = "Giờ Chiếu";
            this.GioChieu.Name = "GioChieu";
            this.GioChieu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.MaximumSize = new System.Drawing.Size(426, 39);
            this.label1.MinimumSize = new System.Drawing.Size(426, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suất chiếu đang hoạt động";
            // 
            // removeTicketBtn
            // 
            this.removeTicketBtn.Location = new System.Drawing.Point(935, 404);
            this.removeTicketBtn.Name = "removeTicketBtn";
            this.removeTicketBtn.Size = new System.Drawing.Size(94, 38);
            this.removeTicketBtn.TabIndex = 9;
            this.removeTicketBtn.Text = "Xoá vé";
            this.removeTicketBtn.UseVisualStyleBackColor = true;
            this.removeTicketBtn.Click += new System.EventHandler(this.removeTicketBtn_Click);
            // 
            // TicketUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.removeTicketBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showTimeDataGridView);
            this.Controls.Add(this.ticketGenBtn);
            this.Controls.Add(this.ticketGenDataGridView);
            this.Name = "TicketUControl";
            this.Size = new System.Drawing.Size(1045, 735);
            this.Load += new System.EventHandler(this.TicketUControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketGenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ticketGenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeTicketBtn;
        public System.Windows.Forms.DataGridView ticketGenDataGridView;
        public System.Windows.Forms.DataGridView showTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TInhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuatChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
    }
}
