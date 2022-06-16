namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class DataBaseSettingForm
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
            this.serverNameTxb = new System.Windows.Forms.TextBox();
            this.dbNameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testConnectBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverNameTxb
            // 
            this.serverNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameTxb.Location = new System.Drawing.Point(174, 66);
            this.serverNameTxb.Name = "serverNameTxb";
            this.serverNameTxb.Size = new System.Drawing.Size(233, 26);
            this.serverNameTxb.TabIndex = 0;
            this.serverNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // dbNameTxb
            // 
            this.dbNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbNameTxb.Location = new System.Drawing.Point(175, 134);
            this.dbNameTxb.Name = "dbNameTxb";
            this.dbNameTxb.Size = new System.Drawing.Size(232, 26);
            this.dbNameTxb.TabIndex = 1;
            this.dbNameTxb.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Setting";
            // 
            // testConnectBtn
            // 
            this.testConnectBtn.BackColor = System.Drawing.Color.Gray;
            this.testConnectBtn.Enabled = false;
            this.testConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testConnectBtn.Location = new System.Drawing.Point(18, 181);
            this.testConnectBtn.Name = "testConnectBtn";
            this.testConnectBtn.Size = new System.Drawing.Size(161, 56);
            this.testConnectBtn.TabIndex = 5;
            this.testConnectBtn.Text = "Test Connect";
            this.testConnectBtn.UseVisualStyleBackColor = false;
            this.testConnectBtn.Click += new System.EventHandler(this.testConnectBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(195, 181);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 25);
            this.statusLabel.TabIndex = 6;
            // 
            // DataBaseSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(429, 244);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.testConnectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbNameTxb);
            this.Controls.Add(this.serverNameTxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(445, 283);
            this.MinimumSize = new System.Drawing.Size(445, 283);
            this.Name = "DataBaseSettingForm";
            this.Text = "Thiết lập Database";
            this.Load += new System.EventHandler(this.DataBaseSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameTxb;
        private System.Windows.Forms.TextBox dbNameTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button testConnectBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}