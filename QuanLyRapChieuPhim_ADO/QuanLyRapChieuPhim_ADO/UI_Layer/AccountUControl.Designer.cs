namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    partial class AccountUControl
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
            this.functionButtonPnl = new System.Windows.Forms.Panel();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountTypeCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeIDTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.userNameTxb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionButtonPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.accountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.functionButtonPnl.Location = new System.Drawing.Point(857, 192);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(185, 540);
            this.functionButtonPnl.TabIndex = 14;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Yellow;
            this.reloadBtn.Location = new System.Drawing.Point(22, 376);
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
            this.cancelBtn.Location = new System.Drawing.Point(22, 303);
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
            this.saveBtn.Location = new System.Drawing.Point(22, 234);
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
            this.removeBtn.Location = new System.Drawing.Point(22, 167);
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
            this.editBtn.Location = new System.Drawing.Point(22, 102);
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
            this.addBtn.Location = new System.Drawing.Point(22, 32);
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
            this.panel1.Controls.Add(this.accountInfo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 183);
            this.panel1.TabIndex = 13;
            // 
            // accountInfo
            // 
            this.accountInfo.Controls.Add(this.label2);
            this.accountInfo.Controls.Add(this.accountTypeCbx);
            this.accountInfo.Controls.Add(this.label3);
            this.accountInfo.Controls.Add(this.employeeIDTxb);
            this.accountInfo.Controls.Add(this.label6);
            this.accountInfo.Controls.Add(this.passwordTxb);
            this.accountInfo.Controls.Add(this.userNameTxb);
            this.accountInfo.Controls.Add(this.label9);
            this.accountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfo.Location = new System.Drawing.Point(17, 16);
            this.accountInfo.Name = "accountInfo";
            this.accountInfo.Size = new System.Drawing.Size(831, 148);
            this.accountInfo.TabIndex = 24;
            this.accountInfo.TabStop = false;
            this.accountInfo.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // accountTypeCbx
            // 
            this.accountTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeCbx.FormattingEnabled = true;
            this.accountTypeCbx.Items.AddRange(new object[] {
            "0",
            "1"});
            this.accountTypeCbx.Location = new System.Drawing.Point(536, 33);
            this.accountTypeCbx.Name = "accountTypeCbx";
            this.accountTypeCbx.Size = new System.Drawing.Size(129, 24);
            this.accountTypeCbx.TabIndex = 23;
            this.accountTypeCbx.SelectedIndexChanged += new System.EventHandler(this.accountTypeCbx_SelectedIndexChanged);
            this.accountTypeCbx.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tài khoản";
            // 
            // employeeIDTxb
            // 
            this.employeeIDTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTxb.Location = new System.Drawing.Point(186, 84);
            this.employeeIDTxb.Name = "employeeIDTxb";
            this.employeeIDTxb.Size = new System.Drawing.Size(161, 22);
            this.employeeIDTxb.TabIndex = 20;
            this.employeeIDTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã nhân viên";
            // 
            // passwordTxb
            // 
            this.passwordTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxb.Location = new System.Drawing.Point(536, 85);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.PasswordChar = '*';
            this.passwordTxb.Size = new System.Drawing.Size(129, 22);
            this.passwordTxb.TabIndex = 18;
            this.passwordTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // userNameTxb
            // 
            this.userNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxb.Location = new System.Drawing.Point(188, 34);
            this.userNameTxb.Name = "userNameTxb";
            this.userNameTxb.Size = new System.Drawing.Size(161, 22);
            this.userNameTxb.TabIndex = 8;
            this.userNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mật khẩu";
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.AllowUserToDeleteRows = false;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.MatKhau,
            this.MaNhanVien,
            this.LoaiTaiKhoan});
            this.accountDataGridView.Location = new System.Drawing.Point(3, 192);
            this.accountDataGridView.MultiSelect = false;
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.ReadOnly = true;
            this.accountDataGridView.Size = new System.Drawing.Size(848, 540);
            this.accountDataGridView.TabIndex = 12;
            this.accountDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDataGridView_CellClick);
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            this.TenTaiKhoan.Width = 200;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 200;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 200;
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.ReadOnly = true;
            this.LoaiTaiKhoan.Width = 200;
            // 
            // AccountUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.functionButtonPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountDataGridView);
            this.MaximumSize = new System.Drawing.Size(1045, 735);
            this.MinimumSize = new System.Drawing.Size(1045, 735);
            this.Name = "AccountUControl";
            this.Size = new System.Drawing.Size(1045, 735);
            this.Load += new System.EventHandler(this.AccountUControl_Load);
            this.functionButtonPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.accountInfo.ResumeLayout(false);
            this.accountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userNameTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.TextBox employeeIDTxb;
        private System.Windows.Forms.ComboBox accountTypeCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.GroupBox accountInfo;
    }
}
