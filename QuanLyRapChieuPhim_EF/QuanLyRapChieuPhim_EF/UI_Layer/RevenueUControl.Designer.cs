namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class RevenueUControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.revenueDataGridView = new System.Windows.Forms.DataGridView();
            this.MaBoPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmSearchNameTxb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDTPicker = new System.Windows.Forms.DateTimePicker();
            this.endDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoGrpb = new System.Windows.Forms.GroupBox();
            this.filmIDTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.endShowDTPicker = new System.Windows.Forms.DateTimePicker();
            this.startShowDTPicker = new System.Windows.Forms.DateTimePicker();
            this.totalRevenueTxb = new System.Windows.Forms.TextBox();
            this.totalTicketTxb = new System.Windows.Forms.TextBox();
            this.filmNameTxb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exportReportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataGridView)).BeginInit();
            this.infoGrpb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // revenueDataGridView
            // 
            this.revenueDataGridView.AllowUserToDeleteRows = false;
            this.revenueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBoPhim,
            this.TenPhim,
            this.NgayKhoiChieu,
            this.NgayKetThuc,
            this.TongSoVe,
            this.TongTien});
            this.revenueDataGridView.Location = new System.Drawing.Point(31, 165);
            this.revenueDataGridView.MultiSelect = false;
            this.revenueDataGridView.Name = "revenueDataGridView";
            this.revenueDataGridView.ReadOnly = true;
            this.revenueDataGridView.Size = new System.Drawing.Size(642, 535);
            this.revenueDataGridView.TabIndex = 0;
            this.revenueDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revenueDataGridView_CellClick);
            // 
            // MaBoPhim
            // 
            this.MaBoPhim.DataPropertyName = "MaBoPhim";
            this.MaBoPhim.HeaderText = "Mã bộ phim";
            this.MaBoPhim.Name = "MaBoPhim";
            this.MaBoPhim.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            this.TenPhim.Width = 120;
            // 
            // NgayKhoiChieu
            // 
            this.NgayKhoiChieu.DataPropertyName = "NgayKhoiChieu";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            dataGridViewCellStyle7.NullValue = null;
            this.NgayKhoiChieu.DefaultCellStyle = dataGridViewCellStyle7;
            this.NgayKhoiChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayKhoiChieu.Name = "NgayKhoiChieu";
            this.NgayKhoiChieu.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            dataGridViewCellStyle8.NullValue = null;
            this.NgayKetThuc.DefaultCellStyle = dataGridViewCellStyle8;
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // TongSoVe
            // 
            this.TongSoVe.DataPropertyName = "TongSoVe";
            this.TongSoVe.HeaderText = "Tổng số vé";
            this.TongSoVe.Name = "TongSoVe";
            this.TongSoVe.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 120;
            // 
            // filmSearchNameTxb
            // 
            this.filmSearchNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmSearchNameTxb.Location = new System.Drawing.Point(171, 34);
            this.filmSearchNameTxb.Name = "filmSearchNameTxb";
            this.filmSearchNameTxb.Size = new System.Drawing.Size(334, 40);
            this.filmSearchNameTxb.TabIndex = 1;
            this.filmSearchNameTxb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phim";
            // 
            // startDTPicker
            // 
            this.startDTPicker.CustomFormat = "dd/MM/yyyy";
            this.startDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTPicker.Location = new System.Drawing.Point(171, 99);
            this.startDTPicker.Name = "startDTPicker";
            this.startDTPicker.Size = new System.Drawing.Size(140, 29);
            this.startDTPicker.TabIndex = 3;
            this.startDTPicker.ValueChanged += new System.EventHandler(this.DateChanged);
            this.startDTPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_KeyDown);
            // 
            // endDTPicker
            // 
            this.endDTPicker.CustomFormat = "dd/MM/yyyy";
            this.endDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTPicker.Location = new System.Drawing.Point(502, 97);
            this.endDTPicker.Name = "endDTPicker";
            this.endDTPicker.Size = new System.Drawing.Size(140, 29);
            this.endDTPicker.TabIndex = 4;
            this.endDTPicker.ValueChanged += new System.EventHandler(this.DateChanged);
            this.endDTPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(357, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến ngày";
            // 
            // infoGrpb
            // 
            this.infoGrpb.Controls.Add(this.filmIDTxb);
            this.infoGrpb.Controls.Add(this.label7);
            this.infoGrpb.Controls.Add(this.endShowDTPicker);
            this.infoGrpb.Controls.Add(this.startShowDTPicker);
            this.infoGrpb.Controls.Add(this.totalRevenueTxb);
            this.infoGrpb.Controls.Add(this.totalTicketTxb);
            this.infoGrpb.Controls.Add(this.filmNameTxb);
            this.infoGrpb.Controls.Add(this.label9);
            this.infoGrpb.Controls.Add(this.label8);
            this.infoGrpb.Controls.Add(this.label6);
            this.infoGrpb.Controls.Add(this.label5);
            this.infoGrpb.Controls.Add(this.label4);
            this.infoGrpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGrpb.Location = new System.Drawing.Point(689, 165);
            this.infoGrpb.Name = "infoGrpb";
            this.infoGrpb.Size = new System.Drawing.Size(343, 358);
            this.infoGrpb.TabIndex = 7;
            this.infoGrpb.TabStop = false;
            this.infoGrpb.Text = "Thông tin";
            // 
            // filmIDTxb
            // 
            this.filmIDTxb.Enabled = false;
            this.filmIDTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmIDTxb.Location = new System.Drawing.Point(164, 26);
            this.filmIDTxb.Name = "filmIDTxb";
            this.filmIDTxb.Size = new System.Drawing.Size(161, 26);
            this.filmIDTxb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã bộ phim";
            // 
            // endShowDTPicker
            // 
            this.endShowDTPicker.CustomFormat = "dd/MM/yyyy";
            this.endShowDTPicker.Enabled = false;
            this.endShowDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endShowDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endShowDTPicker.Location = new System.Drawing.Point(164, 188);
            this.endShowDTPicker.Name = "endShowDTPicker";
            this.endShowDTPicker.Size = new System.Drawing.Size(161, 26);
            this.endShowDTPicker.TabIndex = 10;
            // 
            // startShowDTPicker
            // 
            this.startShowDTPicker.CustomFormat = "dd/MM/yyyy";
            this.startShowDTPicker.Enabled = false;
            this.startShowDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShowDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startShowDTPicker.Location = new System.Drawing.Point(164, 122);
            this.startShowDTPicker.Name = "startShowDTPicker";
            this.startShowDTPicker.Size = new System.Drawing.Size(161, 26);
            this.startShowDTPicker.TabIndex = 8;
            // 
            // totalRevenueTxb
            // 
            this.totalRevenueTxb.Enabled = false;
            this.totalRevenueTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueTxb.Location = new System.Drawing.Point(164, 318);
            this.totalRevenueTxb.Name = "totalRevenueTxb";
            this.totalRevenueTxb.Size = new System.Drawing.Size(161, 26);
            this.totalRevenueTxb.TabIndex = 9;
            // 
            // totalTicketTxb
            // 
            this.totalTicketTxb.Enabled = false;
            this.totalTicketTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTicketTxb.Location = new System.Drawing.Point(164, 259);
            this.totalTicketTxb.Name = "totalTicketTxb";
            this.totalTicketTxb.Size = new System.Drawing.Size(161, 26);
            this.totalTicketTxb.TabIndex = 8;
            // 
            // filmNameTxb
            // 
            this.filmNameTxb.Enabled = false;
            this.filmNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmNameTxb.Location = new System.Drawing.Point(164, 72);
            this.filmNameTxb.Name = "filmNameTxb";
            this.filmNameTxb.Size = new System.Drawing.Size(161, 26);
            this.filmNameTxb.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tổng doanh thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng số vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày khởi chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên phim";
            // 
            // exportReportBtn
            // 
            this.exportReportBtn.BackColor = System.Drawing.Color.Lime;
            this.exportReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportReportBtn.Location = new System.Drawing.Point(689, 610);
            this.exportReportBtn.Name = "exportReportBtn";
            this.exportReportBtn.Size = new System.Drawing.Size(343, 90);
            this.exportReportBtn.TabIndex = 8;
            this.exportReportBtn.Text = "Xuất báo cáo";
            this.exportReportBtn.UseVisualStyleBackColor = false;
            this.exportReportBtn.Click += new System.EventHandler(this.exportReportBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filmSearchNameTxb);
            this.groupBox1.Controls.Add(this.startDTPicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.endDTPicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Cyan;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(529, 34);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(113, 40);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // RevenueUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exportReportBtn);
            this.Controls.Add(this.infoGrpb);
            this.Controls.Add(this.revenueDataGridView);
            this.MaximumSize = new System.Drawing.Size(1045, 735);
            this.MinimumSize = new System.Drawing.Size(1045, 735);
            this.Name = "RevenueUControl";
            this.Size = new System.Drawing.Size(1045, 735);
            this.Load += new System.EventHandler(this.RevenueUControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueDataGridView)).EndInit();
            this.infoGrpb.ResumeLayout(false);
            this.infoGrpb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView revenueDataGridView;
        private System.Windows.Forms.RichTextBox filmSearchNameTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDTPicker;
        private System.Windows.Forms.DateTimePicker endDTPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox infoGrpb;
        private System.Windows.Forms.DateTimePicker endShowDTPicker;
        private System.Windows.Forms.DateTimePicker startShowDTPicker;
        private System.Windows.Forms.TextBox totalRevenueTxb;
        private System.Windows.Forms.TextBox totalTicketTxb;
        private System.Windows.Forms.TextBox filmNameTxb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exportReportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBoPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.TextBox filmIDTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBtn;
    }
}
