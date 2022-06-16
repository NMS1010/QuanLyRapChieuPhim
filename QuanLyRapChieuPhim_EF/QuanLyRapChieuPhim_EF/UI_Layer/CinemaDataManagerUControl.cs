using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim_EF.UI_Layer;

namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    public partial class CinemaDataManagerUControl : UserControl
    {
        public CinemaDataManagerUControl()
        {
            InitializeComponent();
        }

        private void cinemaRoomBtn_Click(object sender, EventArgs e)
        {
            CinemaRoomUControl cinemaRoomUControl = new CinemaRoomUControl();
            mainDataPnl.Controls.Clear();
            mainDataPnl.Controls.Add(cinemaRoomUControl);
            colorChosenBarPtrb.Location = new Point(cinemaRoomBtn.Location.X, cinemaRoomBtn.Location.Y + cinemaRoomBtn.Height + 3);
            colorChosenBarPtrb.Visible = true;
        }

        private void genreBtn_Click(object sender, EventArgs e)
        {
            GenreUControl genreUControl = new GenreUControl();
            mainDataPnl.Controls.Clear();
            mainDataPnl.Controls.Add(genreUControl);
            colorChosenBarPtrb.Location = new Point(genreBtn.Location.X, genreBtn.Location.Y + genreBtn.Height + 3);
            colorChosenBarPtrb.Visible = true;
        }

        private void filmBtn_Click(object sender, EventArgs e)
        {
            MovieUControl movieUControl = new MovieUControl();
            mainDataPnl.Controls.Clear();
            mainDataPnl.Controls.Add(movieUControl);
            colorChosenBarPtrb.Location = new Point(filmBtn.Location.X, filmBtn.Location.Y + filmBtn.Height + 3);
            colorChosenBarPtrb.Visible = true;
        }

        private void screenBtn_Click(object sender, EventArgs e)
        {
            ScreenUControl screenUControl = new ScreenUControl();
            mainDataPnl.Controls.Clear();
            mainDataPnl.Controls.Add(screenUControl);
            colorChosenBarPtrb.Location = new Point(screenBtn.Location.X, screenBtn.Location.Y + screenBtn.Height + 3);
            colorChosenBarPtrb.Visible = true;

        }

        private void showTimeBtn_Click(object sender, EventArgs e)
        {
            ShowTimeUControl showTimeUControl = new ShowTimeUControl();
            mainDataPnl.Controls.Clear();
            mainDataPnl.Controls.Add(showTimeUControl);
            colorChosenBarPtrb.Location = new Point(showTimeBtn.Location.X, showTimeBtn.Location.Y + showTimeBtn.Height + 3);
            colorChosenBarPtrb.Visible = true;
        }

        private void MoveColorBar(object sender, EventArgs e)
        {
            colorBarPtrb.Visible = true;
            Button temp = sender as Button;
            colorBarPtrb.Location = new Point(temp.Location.X, temp.Location.Y + temp.Height + 3);
        }

        private void cinemaRoomBtn_MouseLeave(object sender, EventArgs e)
        {
            colorBarPtrb.Visible=false;
        }
        private void LoadImage()
        {
            using (Image img = Properties.Resources.cinema)
            {
                cinemaRoomBtn.Image = new Bitmap(img, 40, 40);
            }
            using (Image img = Properties.Resources.genres)
            {
                genreBtn.Image = new Bitmap(img, 40, 40);
            }
            using (Image img = Properties.Resources.film)
            {
                filmBtn.Image = new Bitmap(img, 40, 40);
            }
            using (Image img = Properties.Resources.screen)
            {
                screenBtn.Image = new Bitmap(img, 40, 40);
            }
            using (Image img = Properties.Resources.showtime)
            {
                showTimeBtn.Image = new Bitmap(img, 40, 40);
            }
        }
        private void CinemaDataManagerUControl_Load(object sender, EventArgs e)
        {
            CinemaRoomUControl cinemaRoomUControl = new CinemaRoomUControl();
            mainDataPnl.Controls.Clear();
            mainDataPnl.Controls.Add(cinemaRoomUControl);
            colorChosenBarPtrb.Location = new Point(cinemaRoomBtn.Location.X, cinemaRoomBtn.Location.Y + cinemaRoomBtn.Height + 3);
            colorChosenBarPtrb.Visible = true;
            LoadImage();
        }
    }
}
