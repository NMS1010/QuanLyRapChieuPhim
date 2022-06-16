﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using QuanLyRapChieuPhim_EF.DataObjects;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal static class BLMovie
    {
        static BLMovie()
        {
            
        }

        public static DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaBoPhim", typeof(string));
            dt.Columns.Add("TenPhim", typeof(string));
            dt.Columns.Add("MoTa", typeof(string));
            dt.Columns.Add("ThoiLuong", typeof(float));
            dt.Columns.Add("NgayKhoiChieu", typeof(DateTime));
            dt.Columns.Add("NgayKetThuc", typeof(DateTime));
            dt.Columns.Add("NamSX", typeof(int));
            dt.Columns.Add("DaoDien", typeof(string));
            dt.Columns.Add("TenHangPhim", typeof(string));
            dt.Columns.Add("TrangThai", typeof(int));
            dt.Columns.Add("TheLoai", typeof(string));
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<BoPhim> movies = (from a in ctx.BoPhims
                                  select a).ToList();
                foreach (BoPhim movie in movies)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaBoPhim"] = movie.MaBoPhim;
                    dr["TenPhim"] = movie.TenPhim;
                    dr["MoTa"] = movie.MoTa;
                    dr["ThoiLuong"] = movie.ThoiLuong;
                    dr["NgayKhoiChieu"] = movie.NgayKhoiChieu;
                    dr["NgayKetThuc"] = movie.NgayKetThuc;
                    dr["NamSX"] = movie.NamSX;
                    dr["DaoDien"] = movie.DaoDien;
                    dr["TenHangPhim"] = movie.TenHangPhim;
                    dr["TrangThai"] = movie.TrangThai;
                    string str = "";
                    List<string> temp = GetGenreNameFromFilmID(movie.MaBoPhim);
                    if (temp.Count != 0)
                        str = temp.Aggregate((i, j) => i + ", " + j);
                    dr["TheLoai"] = str;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
            }

            return ds;
        }
        public static List<string> GetGenreIDFromGenreName(string genreName)
        {
            List<string> genreIDs = new List<string>();
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<TheLoai> genres = (from a in ctx.TheLoais
                             where a.TenTheLoai == genreName
                             select a).ToList();
                foreach (TheLoai genre in genres)
                {
                    genreIDs.Add(genre.MaTheLoai);
                }
            }
            return genreIDs;
        }
        public static List<string> GetGenreNames()
        {
            List<string> genreNames = new List<string>();
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<TheLoai> genres = (from a in ctx.TheLoais
                             select a).ToList();
                foreach (TheLoai genre in genres)
                {
                    genreNames.Add(genre.TenTheLoai);
                }
            }
            return genreNames;
        }
        public static string GetGenreNameFromGenreID(string genreID)
        {
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                string genreName = ctx.TheLoais.SingleOrDefault(x => x.MaTheLoai == genreID)?.TenTheLoai;
                return genreName;
            }
        }
        public static List<string> GetGenreNameFromFilmID(string filmID)
        {
            List<string> genreNames = new List<string>();
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                IList<TheLoai> genres = (from a in ctx.BoPhims
                             where a.MaBoPhim == filmID
                             select a.TheLoais).SingleOrDefault().ToList();
                foreach (TheLoai genre in genres)
                {
                    genreNames.Add(genre.TenTheLoai);
                }
            }
            return genreNames;
        }
        public static bool Update(string filmId, string filmName, string filmDes, double totalFilmTime,
            DateTime startShow, DateTime endShow, int year, string director, string studioFilm, int movieStatus, ref string err)
        {
            if(endShow < startShow)
            {
                err = "Ngày khởi chiếu phải nhỏ hơn Ngày kết thúc";
                return false;
            }
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    BoPhim entity = ctx.BoPhims.SingleOrDefault(a => a.MaBoPhim == filmId);
                    if (entity != null)
                    {
                        entity.TenPhim = filmName;
                        entity.MoTa = filmDes;
                        entity.ThoiLuong = totalFilmTime;
                        entity.NgayKhoiChieu = startShow;
                        entity.NgayKetThuc = endShow;
                        entity.NamSX = year;
                        entity.DaoDien = director;
                        entity.TenHangPhim = studioFilm;
                        entity.TrangThai = movieStatus;
                        ctx.SaveChanges();

                        IList<SuatChieu> showTimes = (from a in ctx.SuatChieux
                                        where a.MaBoPhim == filmId
                                        select a).ToList();
                        foreach (SuatChieu showTime in showTimes)
                        {
                            string cinemaRoomStatus = ctx.PhongChieux.SingleOrDefault(x => x.MaPhongChieu == showTime.MaPhongChieu)?.TinhTrang.ToString();
                            if (cinemaRoomStatus == "0")
                                continue;
                            try
                            {
                                var e = ctx.SuatChieux.SingleOrDefault(a => a.MaSuatChieu == showTime.MaSuatChieu);
                                if (e != null)
                                {
                                    e.TrangThai = movieStatus;
                                    ctx.SaveChanges();
                                }
                            }
                            catch (EntitySqlException e)
                            {
                                success = false;
                                err = e.Message;
                            }
                            if (!success)
                                return success;
                        }
                    }
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }

            }
            return success;
        }
        public static bool Insert(string filmId, string filmName, string filmDes, double totalFilmTime,
            DateTime startShow, DateTime endShow, int year, string director, string studioFilm, int movieStatus, ref string err)
        {
            if (endShow < startShow)
            {
                err = "Ngày khởi chiếu phải nhỏ hơn Ngày kết thúc";
                return false;
            }
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    BoPhim movie = new BoPhim(filmId, filmName, filmDes, totalFilmTime, startShow, endShow, year, director, studioFilm, movieStatus);
                    ctx.BoPhims.Add(movie);
                    ctx.SaveChanges();
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }
            }
            return success;
        }
        public static bool Modify_Movie_Genre(string filmId, List<string> genreNames, ref string error)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    IList<TheLoai> genres = (from a in ctx.BoPhims
                                  where a.MaBoPhim == filmId
                                  select a.TheLoais).SingleOrDefault().ToList();
                    foreach (TheLoai genre in genres)
                    {
                        ctx.BoPhims.Find(filmId).TheLoais.Remove(ctx.TheLoais.Find(genre.MaTheLoai));
                    }
                    foreach (string genreName in genreNames)
                    {
                        List<string> genreIDs = GetGenreIDFromGenreName(genreName);
                        foreach (string genreID in genreIDs)
                        {
                            ctx.BoPhims.Find(filmId).TheLoais.Add(ctx.TheLoais.Find(genreID));
                            ctx.SaveChanges();
                        }
                    }
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    error = e.Message;
                }
            }
            return success;
        }
        
        public static bool Remove(string filmId, ref string err)
        {
            bool success = true;
            using (CinemaManagementModel ctx = new CinemaManagementModel())
            {
                try
                {
                    BoPhim film = new BoPhim() { MaBoPhim = filmId };
                    ctx.BoPhims.Attach(film);
                    ctx.BoPhims.Remove(film);
                    ctx.SaveChanges();
                }
                catch (EntitySqlException e)
                {
                    success = false;
                    err = e.Message;
                }
            }
            return success;
        }
    }
}
