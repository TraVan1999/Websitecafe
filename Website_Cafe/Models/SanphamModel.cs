using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Website_Cafe.Models
{
    public class SanphamModel
    {
        dataconnection dbsp = new dataconnection();

        //lấy tất cả các sản phẩm
        public List<SanPham> getAllSanPham()
        {
            DataTable dt = dbsp.laydulieu("Select * from SanPham");
            List<SanPham> li = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP =int.Parse(dr[0].ToString());
                sp.TenSP = dr[1].ToString();
                sp.MoTa = dr[2].ToString();
                sp.SoLuong = int.Parse(dr[3].ToString());
                sp.DonGia = int.Parse(dr[4].ToString());
                sp.MaLoai = dr[5].ToString();
                sp.Anh = dr[6].ToString();
                li.Add(sp);
            }
            return li;

        }
        public SanPham get1SanPham(string id)
        {
            DataTable dt = dbsp.laydulieu("Select * from SanPham where MaSP='" + id + "'");

            SanPham sp = new SanPham();
            sp.MaSP =int.Parse(dt.Rows[0][0].ToString());
            sp.TenSP = dt.Rows[0][1].ToString();
            sp.MoTa = dt.Rows[0][2].ToString();
            sp.SoLuong = int.Parse(dt.Rows[0][3].ToString());
            sp.DonGia = int.Parse(dt.Rows[0][4].ToString());
            sp.MaLoai = dt.Rows[0][5].ToString();
            sp.Anh = dt.Rows[0][6].ToString();
            return sp;
        }
        public List<SanPham> getSP_LoaiSP(string id)
        {

            DataTable dt = dbsp.laydulieu("Select * from SanPham where MaLoai = '" + id + "'");
            List<SanPham> li = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP =int.Parse(dr[0].ToString());
                sp.TenSP = dr[1].ToString();
                sp.MoTa = dr[2].ToString();
                sp.SoLuong = int.Parse(dr[3].ToString());
                sp.DonGia = int.Parse(dr[4].ToString());
                sp.MaLoai = dr[5].ToString();
                sp.Anh = dr[6].ToString();
                li.Add(sp);
            }
            return li;
        }
        public List<SanPham> searchTenSP(string id)
        {
            DataTable dt = dbsp.laydulieu(string.Format("Select * from SanPham where TenSP like N'%{0}%'", id));
            List<SanPham> li = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP =int.Parse(dr[0].ToString());
                sp.TenSP = dr[1].ToString();
                sp.MoTa = dr[2].ToString();
                sp.SoLuong = int.Parse(dr[3].ToString());
                sp.DonGia = int.Parse(dr[4].ToString());
                sp.MaLoai = dr[5].ToString();
                sp.Anh = dr[6].ToString();
                li.Add(sp);
            }
            return li;
        }
    }
}