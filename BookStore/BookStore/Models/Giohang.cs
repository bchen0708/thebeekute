using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Giohang
    {
        dbQuanLyBanSachDataContext data = new dbQuanLyBanSachDataContext();
        public int iMasach { get; set; }
        public string sTenSach { get; set; }
        public string sAnhbia { get; set; }
        public Double dDonGia { get; set; }
        public int iSoluong { get; set; }
        public Double dThanhtien
        {
            get { return iSoluong * dDonGia; }
        }
        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = data.SACHes.Single(n => n.Masach == iMasach);
            sTenSach = sach.Tensach;
            sAnhbia = sach.Hinhminhhoa;
            dDonGia = double.Parse(sach.Dongia.ToString());
            iSoluong = 1;
        }
    }
}