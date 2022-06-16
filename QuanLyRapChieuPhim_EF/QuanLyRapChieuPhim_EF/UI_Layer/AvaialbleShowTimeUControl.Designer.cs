namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class AvaialbleShowTimeUControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.findGrpBox = new System.Windows.Forms.GroupBox();
            this.conditionPanel = new System.Windows.Forms.Panel();
            this.byFilmNameCkb = new System.Windows.Forms.CheckBox();
            this.byDateCkb = new System.Windows.Forms.CheckBox();
            this.filmNameTxb = new System.Windows.Forms.RichTextBox();
            this.findShowTimeBtn = new System.Windows.Forms.Button();
            this.dateDtpicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.avaiableShowTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTicketBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerIDTxb = new System.Windows.Forms.TextBox();
            this.cumulatePointCkb = new System.Windows.Forms.CheckBox();
            this.findGrpBox.SuspendLayout();
            this.conditionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avaiableShowTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // findGrpBox
            // 
            this.findGrpBox.Controls.Add(this.conditionPanel);
            this.findGrpBox.Controls.Add(this.filmNameTxb);
            this.findGrpBox.Controls.Add(this.findShowTimeBtn);
            this.findGrpBox.Controls.Add(this.dateDtpicker);
            this.findGrpBox.Controls.Add(this.label2);
            this.findGrpBox.Controls.Add(this.label4);
            this.findGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGrpBox.Location = new System.Drawing.Point(753, 177);
            this.findGrpBox.Name = "findGrpBox";
            this.findGrpBox.Size = new System.Drawing.Size(344, 211);
            this.findGrpBox.TabIndex = 8;
            this.findGrpBox.TabStop = false;
            this.findGrpBox.Text = "Tìm kiếm";
            // 
            // conditionPanel
            // 
            this.conditionPanel.Controls.Add(this.byFilmNameCkb);
            this.conditionPanel.Controls.Add(this.byDateCkb);
            this.conditionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionPanel.Location = new System.Drawing.Point(285, 43);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(42, 74);
            this.conditionPanel.TabIndex = 13;
            // 
            // byFilmNameCkb
            // 
            this.byFilmNameCkb.AutoSize = true;
            this.byFilmNameCkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byFilmNameCkb.Location = new System.Drawing.Point(12, 44);
            this.byFilmNameCkb.Name = "byFilmNameCkb";
            this.byFilmNameCkb.Size = new System.Drawing.Size(15, 14);
            this.byFilmNameCkb.TabIndex = 12;
            this.byFilmNameCkb.UseVisualStyleBackColor = true;
            // 
            // byDateCkb
            // 
            this.byDateCkb.AutoSize = true;
            this.byDateCkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byDateCkb.Location = new System.Drawing.Point(12, 6);
            this.byDateCkb.Name = "byDateCkb";
            this.byDateCkb.Size = new System.Drawing.Size(15, 14);
            this.byDateCkb.TabIndex = 11;
            this.byDateCkb.UseVisualStyleBackColor = true;
            // 
            // filmNameTxb
            // 
            this.filmNameTxb.Location = new System.Drawing.Point(98, 75);
            this.filmNameTxb.Name = "filmNameTxb";
            this.filmNameTxb.Size = new System.Drawing.Size(181, 42);
            this.filmNameTxb.TabIndex = 10;
            this.filmNameTxb.Text = "";
            // 
            // findShowTimeBtn
            // 
            this.findShowTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.findShowTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findShowTimeBtn.Location = new System.Drawing.Point(15, 148);
            this.findShowTimeBtn.Name = "findShowTimeBtn";
            this.findShowTimeBtn.Size = new System.Drawing.Size(312, 46);
            this.findShowTimeBtn.TabIndex = 7;
            this.findShowTimeBtn.Text = "Tìm kiếm";
            this.findShowTimeBtn.UseVisualStyleBackColor = false;
            this.findShowTimeBtn.Click += new System.EventHandler(this.findShowTimeBtn_Click);
            // 
            // dateDtpicker
            // 
            this.dateDtpicker.CustomFormat = "dd/MM/yyyy";
            this.dateDtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDtpicker.Location = new System.Drawing.Point(98, 43);
            this.dateDtpicker.Name = "dateDtpicker";
            this.dateDtpicker.Size = new System.Drawing.Size(116, 26);
            this.dateDtpicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên phim";
            // 
            // avaiableShowTimeDataGridView
            // 
            this.avaiableShowTimeDataGridView.AllowUserToDeleteRows = false;
            this.avaiableShowTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avaiableShowTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.TenPhongChieu,
            this.TenDinhDang,
            this.NgayChieu,
            this.GioChieu,
            this.GiaVe});
            this.avaiableShowTimeDataGridView.Location = new System.Drawing.Point(12, 177);
            this.avaiableShowTimeDataGridView.MultiSelect = false;
            this.avaiableShowTimeDataGridView.Name = "avaiableShowTimeDataGridView";
            this.avaiableShowTimeDataGridView.ReadOnly = true;
            this.avaiableShowTimeDataGridView.Size = new System.Drawing.Size(735, 459);
            this.avaiableShowTimeDataGridView.TabIndex = 9;
            this.avaiableShowTimeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avaiableShowTimeDataGridView_CellClick);
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            this.TenPhim.Width = 180;
            // 
            // TenPhongChieu
            // 
            this.TenPhongChieu.DataPropertyName = "TenPhongChieu";
            this.TenPhongChieu.HeaderText = "Tên phòng chiếu";
            this.TenPhongChieu.Name = "TenPhongChieu";
            this.TenPhongChieu.ReadOnly = true;
            this.TenPhongChieu.Width = 120;
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
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.NgayChieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayChieu.HeaderText = "Ngày";
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // GioChieu
            // 
            this.GioChieu.DataPropertyName = "GioChieu";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.GioChieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.GioChieu.HeaderText = "Giờ";
            this.GioChieu.Name = "GioChieu";
            this.GioChieu.ReadOnly = true;
            this.GioChieu.Width = 90;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            dataGridViewCellStyle3.NullValue = null;
            this.GiaVe.DefaultCellStyle = dataGridViewCellStyle3;
            this.GiaVe.HeaderText = "Giá vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            // 
            // orderTicketBtn
            // 
            this.orderTicketBtn.BackColor = System.Drawing.Color.Lime;
            this.orderTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTicketBtn.Location = new System.Drawing.Point(768, 585);
            this.orderTicketBtn.Name = "orderTicketBtn";
            this.orderTicketBtn.Size = new System.Drawing.Size(312, 51);
            this.orderTicketBtn.TabIndex = 10;
            this.orderTicketBtn.Text = "Đặt vé";
            this.orderTicketBtn.UseVisualStyleBackColor = false;
            this.orderTicketBtn.Click += new System.EventHandler(this.orderTicketBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(401, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đặt vé phim";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(764, 535);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(136, 20);
            this.customerIDLabel.TabIndex = 14;
            this.customerIDLabel.Text = "Mã Khách Hàng";
            this.customerIDLabel.Visible = false;
            // 
            // customerIDTxb
            // 
            this.customerIDTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTxb.Location = new System.Drawing.Point(916, 527);
            this.customerIDTxb.Name = "customerIDTxb";
            this.customerIDTxb.Size = new System.Drawing.Size(164, 31);
            this.customerIDTxb.TabIndex = 15;
            this.customerIDTxb.Visible = false;
            this.customerIDTxb.TextChanged += new System.EventHandler(this.customerIDTxb_TextChanged);
            // 
            // cumulatePointCkb
            // 
            this.cumulatePointCkb.AutoSize = true;
            this.cumulatePointCkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulatePointCkb.Location = new System.Drawing.Point(765, 529);
            this.cumulatePointCkb.Name = "cumulatePointCkb";
            this.cumulatePointCkb.Size = new System.Drawing.Size(133, 29);
            this.cumulatePointCkb.TabIndex = 13;
            this.cumulatePointCkb.Text = "Tích điểm";
            this.cumulatePointCkb.UseVisualStyleBackColor = true;
            this.cumulatePointCkb.CheckedChanged += new System.EventHandler(this.cumulatePointCkb_CheckedChanged);
            // 
            // AvaialbleShowTimeUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.cumulatePointCkb);
            this.Controls.Add(this.customerIDTxb);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderTicketBtn);
            this.Controls.Add(this.avaiableShowTimeDataGridView);
            this.Controls.Add(this.findGrpBox);
            this.MaximumSize = new System.Drawing.Size(1110, 660);
            this.MinimumSize = new System.Drawing.Size(1110, 660);
            this.Name = "AvaialbleShowTimeUControl";
            this.Size = new System.Drawing.Size(1110, 660);
            this.Load += new System.EventHandler(this.AvaialbleShowTimeUControl_Load);
            this.findGrpBox.ResumeLayout(false);
            this.findGrpBox.PerformLayout();
            this.conditionPanel.ResumeLayout(false);
            this.conditionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avaiableShowTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox findGrpBox;
        private System.Windows.Forms.DateTimePicker dateDtpicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView avaiableShowTimeDataGridView;
        private System.Windows.Forms.Button orderTicketBtn;
        private System.Windows.Forms.Button findShowTimeBtn;
        private System.Windows.Forms.RichTextBox filmNameTxb;
        private System.Windows.Forms.CheckBox byFilmNameCkb;
        private System.Windows.Forms.CheckBox byDateCkb;
        private System.Windows.Forms.Panel conditionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox customerIDTxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.CheckBox cumulatePointCkb;
    }
}
