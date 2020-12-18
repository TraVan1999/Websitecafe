using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_Cafe.Models;
using PagedList;

namespace Website_Cafe.Controllers
{
    public class HomeController : Controller
    {
        //Day la class HomeController
        LoaiSPModel dblsp = new LoaiSPModel();
        SanphamModel dbsp = new SanphamModel();
        // GET: Home
        public ActionResult Index(int? page = 1)
        {
           
            // GET: Home
                List<SanPham> dssp = dbsp.getAllSanPham();
                int pageSize = 5;
                int pageNumber = (page ?? 1);
                return View(dssp.ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult getAllLoaiSP()
        {
            List<LoaiSP> dslsp = dblsp.getAllLoaiSP();
            return View(dslsp);
        }
        public ActionResult getSPByLoaiSP(string id, int? page = 1)
        {
            var loai = dblsp.getAllLoaiSP();
            ViewBag.loaisp = loai;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            var dt = loai.FirstOrDefault(s => s.MaLoai.ToString().Contains(id)).TenLoai;
            ViewBag.tenloai = dt;

            List<SanPham> dssp = dbsp.getSP_LoaiSP(id);
            return View(dssp.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult SPDetail(string id)
        {
            var loai = dblsp.getAllLoaiSP();
            ViewBag.loaisp = loai;

            //lay ve cac san pham tuong tu
            var ds = dbsp.get1SanPham(id);
            //loai bo san pham ma minh da hien thi
            var dssp = dbsp.getSP_LoaiSP(ds.MaLoai).Where(s => s.MaSP != ds.MaSP).ToList();
            ViewBag.sptt = dssp;
            return View(ds);
        }

        public ActionResult timkiemsp(string search)
        {
            List<SanPham> sp = dbsp.searchTenSP(search);
            return View(sp);
        }
        public ActionResult Home()
        {
            List<SanPham> dssp = dbsp.getAllSanPham();
            return View(dssp);
        }
    }

}