namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    partial class CinemaDataManagerUControl
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
            this.showTimeBtn = new System.Windows.Forms.Button();
            this.screenBtn = new System.Windows.Forms.Button();
            this.filmBtn = new System.Windows.Forms.Button();
            this.genreBtn = new System.Windows.Forms.Button();
            this.cinemaRoomBtn = new System.Windows.Forms.Button();
            this.mainDataPnl = new System.Windows.Forms.Panel();
            this.colorChosenBarPtrb = new System.Windows.Forms.PictureBox();
            this.colorBarPtrb = new System.Windows.Forms.PictureBox();
            this.functionButtonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorChosenBarPtrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarPtrb)).BeginInit();
            this.SuspendLayout();
            // 
            // functionButtonPnl
            // 
            this.functionButtonPnl.BackColor = System.Drawing.Color.Black;
            this.functionButtonPnl.Controls.Add(this.colorChosenBarPtrb);
            this.functionButtonPnl.Controls.Add(this.colorBarPtrb);
            this.functionButtonPnl.Controls.Add(this.showTimeBtn);
            this.functionButtonPnl.Controls.Add(this.screenBtn);
            this.functionButtonPnl.Controls.Add(this.filmBtn);
            this.functionButtonPnl.Controls.Add(this.genreBtn);
            this.functionButtonPnl.Controls.Add(this.cinemaRoomBtn);
            this.functionButtonPnl.Location = new System.Drawing.Point(4, 4);
            this.functionButtonPnl.Name = "functionButtonPnl";
            this.functionButtonPnl.Size = new System.Drawing.Size(1035, 92);
            this.functionButtonPnl.TabIndex = 0;
            // 
            // showTimeBtn
            // 
            this.showTimeBtn.BackColor = System.Drawing.Color.Black;
            this.showTimeBtn.FlatAppearance.BorderSize = 0;
            this.showTimeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.showTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTimeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showTimeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showTimeBtn.Location = new System.Drawing.Point(832, 7);
            this.showTimeBtn.Name = "showTimeBtn";
            this.showTimeBtn.Size = new System.Drawing.Size(200, 60);
            this.showTimeBtn.TabIndex = 4;
            this.showTimeBtn.Text = "Suất chiếu";
            this.showTimeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showTimeBtn.UseVisualStyleBackColor = false;
            this.showTimeBtn.Click += new System.EventHandler(this.showTimeBtn_Click);
            this.showTimeBtn.MouseEnter += new System.EventHandler(this.MoveColorBar);
            this.showTimeBtn.MouseLeave += new System.EventHandler(this.cinemaRoomBtn_MouseLeave);
            // 
            // screenBtn
            // 
            this.screenBtn.BackColor = System.Drawing.Color.Black;
            this.screenBtn.FlatAppearance.BorderSize = 0;
            this.screenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.screenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.screenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenBtn.Location = new System.Drawing.Point(626, 7);
            this.screenBtn.Name = "screenBtn";
            this.screenBtn.Size = new System.Drawing.Size(200, 60);
            this.screenBtn.TabIndex = 3;
            this.screenBtn.Text = "Màn hình";
            this.screenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.screenBtn.UseVisualStyleBackColor = false;
            this.screenBtn.Click += new System.EventHandler(this.screenBtn_Click);
            this.screenBtn.MouseEnter += new System.EventHandler(this.MoveColorBar);
            this.screenBtn.MouseLeave += new System.EventHandler(this.cinemaRoomBtn_MouseLeave);
            // 
            // filmBtn
            // 
            this.filmBtn.BackColor = System.Drawing.Color.Black;
            this.filmBtn.FlatAppearance.BorderSize = 0;
            this.filmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.filmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmBtn.Location = new System.Drawing.Point(420, 7);
            this.filmBtn.Name = "filmBtn";
            this.filmBtn.Size = new System.Drawing.Size(200, 60);
            this.filmBtn.TabIndex = 2;
            this.filmBtn.Text = "Phim";
            this.filmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filmBtn.UseVisualStyleBackColor = false;
            this.filmBtn.Click += new System.EventHandler(this.filmBtn_Click);
            this.filmBtn.MouseEnter += new System.EventHandler(this.MoveColorBar);
            this.filmBtn.MouseLeave += new System.EventHandler(this.cinemaRoomBtn_MouseLeave);
            // 
            // genreBtn
            // 
            this.genreBtn.BackColor = System.Drawing.Color.Black;
            this.genreBtn.FlatAppearance.BorderSize = 0;
            this.genreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.genreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genreBtn.Location = new System.Drawing.Point(209, 7);
            this.genreBtn.Name = "genreBtn";
            this.genreBtn.Size = new System.Drawing.Size(200, 60);
            this.genreBtn.TabIndex = 1;
            this.genreBtn.Text = "Thể loại";
            this.genreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genreBtn.UseVisualStyleBackColor = false;
            this.genreBtn.Click += new System.EventHandler(this.genreBtn_Click);
            this.genreBtn.MouseEnter += new System.EventHandler(this.MoveColorBar);
            this.genreBtn.MouseLeave += new System.EventHandler(this.cinemaRoomBtn_MouseLeave);
            // 
            // cinemaRoomBtn
            // 
            this.cinemaRoomBtn.BackColor = System.Drawing.Color.Black;
            this.cinemaRoomBtn.FlatAppearance.BorderSize = 0;
            this.cinemaRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cinemaRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinemaRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinemaRoomBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cinemaRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cinemaRoomBtn.Location = new System.Drawing.Point(3, 7);
            this.cinemaRoomBtn.Name = "cinemaRoomBtn";
            this.cinemaRoomBtn.Size = new System.Drawing.Size(200, 60);
            this.cinemaRoomBtn.TabIndex = 0;
            this.cinemaRoomBtn.Text = "Phòng chiếu";
            this.cinemaRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cinemaRoomBtn.UseVisualStyleBackColor = false;
            this.cinemaRoomBtn.Click += new System.EventHandler(this.cinemaRoomBtn_Click);
            this.cinemaRoomBtn.MouseEnter += new System.EventHandler(this.MoveColorBar);
            this.cinemaRoomBtn.MouseLeave += new System.EventHandler(this.cinemaRoomBtn_MouseLeave);
            // 
            // mainDataPnl
            // 
            this.mainDataPnl.Location = new System.Drawing.Point(4, 102);
            this.mainDataPnl.Name = "mainDataPnl";
            this.mainDataPnl.Size = new System.Drawing.Size(1035, 625);
            this.mainDataPnl.TabIndex = 1;
            // 
            // colorChosenBarPtrb
            // 
            this.colorChosenBarPtrb.BackColor = System.Drawing.Color.Lime;
            this.colorChosenBarPtrb.Location = new System.Drawing.Point(3, 70);
            this.colorChosenBarPtrb.Name = "colorChosenBarPtrb";
            this.colorChosenBarPtrb.Size = new System.Drawing.Size(200, 20);
            this.colorChosenBarPtrb.TabIndex = 7;
            this.colorChosenBarPtrb.TabStop = false;
            this.colorChosenBarPtrb.Visible = false;
            // 
            // colorBarPtrb
            // 
            this.colorBarPtrb.BackColor = System.Drawing.Color.Cyan;
            this.colorBarPtrb.Location = new System.Drawing.Point(3, 70);
            this.colorBarPtrb.Name = "colorBarPtrb";
            this.colorBarPtrb.Size = new System.Drawing.Size(200, 20);
            this.colorBarPtrb.TabIndex = 6;
            this.colorBarPtrb.TabStop = false;
            this.colorBarPtrb.Visible = false;
            // 
            // CinemaDataManagerUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.mainDataPnl);
            this.Controls.Add(this.functionButtonPnl);
            this.MaximumSize = new System.Drawing.Size(1043, 735);
            this.MinimumSize = new System.Drawing.Size(1043, 735);
            this.Name = "CinemaDataManagerUControl";
            this.Size = new System.Drawing.Size(1043, 735);
            this.Load += new System.EventHandler(this.CinemaDataManagerUControl_Load);
            this.functionButtonPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorChosenBarPtrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarPtrb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel functionButtonPnl;
        private System.Windows.Forms.Button cinemaRoomBtn;
        private System.Windows.Forms.Panel mainDataPnl;
        private System.Windows.Forms.Button showTimeBtn;
        private System.Windows.Forms.Button screenBtn;
        private System.Windows.Forms.Button filmBtn;
        private System.Windows.Forms.Button genreBtn;
        private System.Windows.Forms.PictureBox colorBarPtrb;
        private System.Windows.Forms.PictureBox colorChosenBarPtrb;
    }
}
