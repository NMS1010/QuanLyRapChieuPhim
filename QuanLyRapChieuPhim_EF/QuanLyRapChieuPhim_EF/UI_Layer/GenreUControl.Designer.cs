namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class GenreUControl
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genreNameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genreIdTxb = new System.Windows.Forms.TextBox();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.functionButtonPnl = new System.Windows.Forms.Panel();
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxb = new System.Windows.Forms.TextBox();
            this.propertySearchCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.functionButtonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 156);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genreNameTxb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.genreIdTxb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 132);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thể loại";
            // 
            // genreNameTxb
            // 
            this.genreNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreNameTxb.Location = new System.Drawing.Point(190, 78);
            this.genreNameTxb.Name = "genreNameTxb";
            this.genreNameTxb.Size = new System.Drawing.Size(160, 22);
            this.genreNameTxb.TabIndex = 19;
            this.genreNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên thể loại";
            // 
            // genreIdTxb
            // 
            this.genreIdTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreIdTxb.Location = new System.Drawing.Point(190, 35);
            this.genreIdTxb.Name = "genreIdTxb";
            this.genreIdTxb.Size = new System.Drawing.Size(160, 22);
            this.genreIdTxb.TabIndex = 7;
            this.genreIdTxb.TextChanged += new System.EventHandler(this.OnTextChange);
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
            // functionButtonPnl
            // 
            this.functionButtonPnl.BackColor = System.Drawing.Color.Silver;
            this.functionButtonPnl.Controls.Add(this.reloadBtn);
            this.functionButtonPnl.Controls.Add(this.cancelBtn);
            this.functionButtonPnl.Controls.Add(this.saveBtn);
            this.functionButtonPnl.Controls.Add(this.removeBtn);
            this.functionButtonPnl.Controls.Add(this.editBtn);
            this.functionButtonPnl.Controls.Add(this.addBtn);
            this.functionButtonPnl.Location = new System.Drawing.Point(879, 166);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(149, 456);
            this.functionButtonPnl.TabIndex = 14;
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheLoai,
            this.TenTheLoai});
            this.genreDataGridView.Location = new System.Drawing.Point(5, 165);
            this.genreDataGridView.MultiSelect = false;
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.ReadOnly = true;
            this.genreDataGridView.Size = new System.Drawing.Size(870, 457);
            this.genreDataGridView.TabIndex = 12;
            this.genreDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreDataGridView_CellClick);
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã thể loại";
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            this.MaTheLoai.Width = 400;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên thể loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            this.TenTheLoai.Width = 420;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchTxb);
            this.groupBox2.Controls.Add(this.propertySearchCbx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(529, 6);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thuộc tính";
            // 
            // GenreUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.functionButtonPnl);
            this.Controls.Add(this.genreDataGridView);
            this.MaximumSize = new System.Drawing.Size(1035, 625);
            this.MinimumSize = new System.Drawing.Size(1035, 625);
            this.Name = "GenreUControl";
            this.Size = new System.Drawing.Size(1035, 625);
            this.Load += new System.EventHandler(this.GenreUControl_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.functionButtonPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox genreNameTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genreIdTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxb;
        private System.Windows.Forms.ComboBox propertySearchCbx;
        private System.Windows.Forms.Label label2;
    }
}
