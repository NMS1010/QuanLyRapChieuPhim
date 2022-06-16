namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    partial class ManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.dataManagerBtn = new System.Windows.Forms.Button();
            this.customerDataManagerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // mainPnl
            // 
            this.mainPnl.Location = new System.Drawing.Point(12, 77);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(1110, 660);
            this.mainPnl.TabIndex = 1;
            // 
            // dataManagerBtn
            // 
            this.dataManagerBtn.BackColor = System.Drawing.Color.Tomato;
            this.dataManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataManagerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataManagerBtn.Location = new System.Drawing.Point(920, 12);
            this.dataManagerBtn.Name = "dataManagerBtn";
            this.dataManagerBtn.Size = new System.Drawing.Size(202, 58);
            this.dataManagerBtn.TabIndex = 3;
            this.dataManagerBtn.Text = "Quản lý dữ liệu";
            this.dataManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataManagerBtn.UseVisualStyleBackColor = false;
            this.dataManagerBtn.Click += new System.EventHandler(this.dataManagerBtn_Click);
            // 
            // customerDataManagerBtn
            // 
            this.customerDataManagerBtn.BackColor = System.Drawing.Color.Tomato;
            this.customerDataManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerDataManagerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerDataManagerBtn.Location = new System.Drawing.Point(861, 12);
            this.customerDataManagerBtn.Name = "customerDataManagerBtn";
            this.customerDataManagerBtn.Size = new System.Drawing.Size(261, 58);
            this.customerDataManagerBtn.TabIndex = 4;
            this.customerDataManagerBtn.Text = "Quản lý khách hàng";
            this.customerDataManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerDataManagerBtn.UseVisualStyleBackColor = false;
            this.customerDataManagerBtn.Click += new System.EventHandler(this.customerDataManagerBtn_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 749);
            this.Controls.Add(this.customerDataManagerBtn);
            this.Controls.Add(this.dataManagerBtn);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1151, 788);
            this.MinimumSize = new System.Drawing.Size(1151, 788);
            this.Name = "ManagerForm";
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.OrderTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Button dataManagerBtn;
        private System.Windows.Forms.Button customerDataManagerBtn;
    }
}