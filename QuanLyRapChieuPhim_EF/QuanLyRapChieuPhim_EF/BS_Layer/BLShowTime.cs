using QuanLyRapChieuPhim_EF.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLShowTime
    {
        static BLShowTime()
        {
            
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSuatChieu", typeof(string)));
            dt.Columns.Add(new DataColumn("TrangThai", typeof(int)));
            dt.Columns.Add(new DataColumn("TenPhim", typeof(string)));
            dt.Columns.Add(new DataColumn("TenDinhDang", typeof(string)));
            dt.Columns.Add(new DataColumn("TenPhongChieu", typeof(string)));
            dt.Columns.Add(new DataColumn("GiaVe", typeof(decimal)));
            dt.Columns.Add(new DataColumn("NgayChieu", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("GioChieu", typeof(DateTime)));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<SuatChieu> showTimes = (from a in ctx.SuatChieux
                             select a).ToList();
                foreach (SuatChieu showTime in showTimes)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaSuatChieu"] = showTime.MaSuatChieu;
                    dr["TenPhim"] = BLMovie.GetFilmNameFromFilmID(showTime.MaBoPhim);
                    dr["TenDinhDang"] = BLScreenFormat.GetScreenFormatNameFromCinemaRoomID(showTime.MaPhongChieu);
                    dr["TenPhongChieu"] = BLCinemaRoom.GetCinemaRoomNameFromCinemaRoomID(showTime.MaPhongChieu);
                    string price = BLTicket.GetTicketPriceFromCinemaRoomID(showTime.MaPhongChieu);
                    if (price == "")
                    {
                        price = "0";
                        var showtime = (from a in ctx.SuatChieux
                                          where a.MaSuatChieu == showTime.MaSuatChieu
                                          select a).SingleOrDefault();
                        if(showtime != null)
                            showtime.TrangThai = 0;
                        ctx.SaveChanges();
                    }
                    dr["TrangThai"] = showTime.TrangThai;
                    dr["GiaVe"] = price;
                    dr["NgayChieu"] = showTime.ThoiGian;
                    dr["GioChieu"] = showTime.ThoiGian;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }
        
        
        
        
        
        

        
        
        public static bool CheckCinemaRoomAndMovie(string filmID, string cinemaRoomID, ref string error)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                var entity = (from showtime in ctx.SuatChieux
                              join film in ctx.BoPhims on showtime.MaBoPhim equals film.MaBoPhim
                              join room in ctx.PhongChieux on showtime.MaPhongChieu equals room.MaPhongChieu
                              where room.MaPhongChieu == cinemaRoomID
                              select new
                              {
                                  TrangThaiPhong = room.TinhTrang,
                              }).ToList();
                foreach(var item in entity)
                {
                    if(item.TrangThaiPhong == 0)
                    {
                        error = "Phòng chiếu đang ở trạng thái chưa sẵn sàng!!!";
                        return false;
                    }
                }
                var entity2 = (from showtime in ctx.SuatChieux
                          join film in ctx.BoPhims on showtime.MaBoPhim equals film.MaBoPhim
                          join room in ctx.PhongChieux on showtime.MaPhongChieu equals room.MaPhongChieu
                          where film.MaBoPhim == filmID
                          select new
                          {
                              TrangThaiPhim = film.TrangThai
                          }).ToList();
                foreach (var item in entity2)
                {
                    if (item.TrangThaiPhim == 0)
                    {
                        error = "Bộ phim đang ở trạng thái chưa sẵn sàng!!!";
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool CheckShowTime(string showTimeID, DateTime startShowTime, string filmID, string cinemaRoomID, ref string error)
        {
            if (!CheckCinemaRoomAndMovie(filmID, cinemaRoomID, ref error))
                return false;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                double totalFilmTime = ctx.BoPhims.SingleOrDefault(x => x.MaBoPhim == filmID).ThoiLuong;
                DateTime endShowTime = startShowTime.AddMinutes(totalFilmTime);
                var entity = (from showtime in ctx.SuatChieux
                              join film in ctx.BoPhims on showtime.MaBoPhim equals film.MaBoPhim
                              where showtime.MaSuatChieu != showTimeID
                              select new {
                                    MaPhongChieu = showtime.MaPhongChieu,
                                    ThoiGian = showtime.ThoiGian,
                                    ThoiLuong = film.ThoiLuong,
                                    NgayKhoiChieu = film.NgayKhoiChieu,
                                    NgayKetThuc = film.NgayKetThuc
                              }).ToList();
                foreach(var x in entity)
                {
                    DateTime startShow = x.ThoiGian;
                    double time = x.ThoiLuong;
                    DateTime endShow = startShow.AddMinutes(time);
                    if (x.MaPhongChieu == cinemaRoomID)
                    {
                        if ((startShowTime >= startShow && startShowTime <= endShow) ||
                            (endShowTime >= startShow && endShowTime <= endShow))
                        {
                            error = "Trùng lịch chiếu phim khác. Vui lòng chọn lại!!!";
                            return false;
                        }
                    }
                }
                var temp = from b in ctx.BoPhims
                           select b;
                foreach (var x in temp)
                {
                    DateTime startDate = x.NgayKhoiChieu;
                    DateTime endDate = x.NgayKetThuc;
                    if (x.MaBoPhim == filmID)
                    {
                        if (startShowTime < startDate)
                        {
                            error = "Phim chưa khởi chiếu!!!";
                            return false;
                        }
                        if (startShowTime > endDate)
                        {
                            error = "Phim đã kết thúc chiếu!!!";
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        public static bool Update(string showTimeID, DateTime startShowTime, string statusShowTime, string filmID,
            string cinemaRoomID, ref string err)
        {
            if (!CheckShowTime(showTimeID, startShowTime, filmID, cinemaRoomID, ref err))
                return false;
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    SuatChieu showtime = ctx.SuatChieux.SingleOrDefault(c => c.MaSuatChieu == showTimeID);
                    if (showtime != null)
                    {
                        showtime.ThoiGian = startShowTime;
                        showtime.TrangThai = int.Parse(statusShowTime);
                        showtime.MaBoPhim = filmID;
                        showtime.MaPhongChieu = cinemaRoomID;
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
        public static bool Insert(string showTimeID, DateTime startShowTime, string statusShowTime, string filmID,
            string cinemaRoomID, ref string err)
        {
            if (!CheckShowTime(showTimeID, startShowTime, filmID, cinemaRoomID, ref err))
                return false;
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    SuatChieu showtime = new SuatChieu(showTimeID, startShowTime, statusShowTime, filmID, cinemaRoomID);
                    ctx.SuatChieux.Add(showtime);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
        
        public static bool Remove(string showTimeId, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    SuatChieu showtime = new SuatChieu() { MaSuatChieu = showTimeId };
                    ctx.SuatChieux.Attach(showtime);
                    ctx.SuatChieux.Remove(showtime);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    success = false;
                    err = e.InnerException.ToString();
                }
            }
            return success;
        }
    }
}
