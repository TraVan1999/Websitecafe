using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Website_Cafe.Models
{
    public class LoaiSPModel
    {
        dataconnection dblsp = new dataconnection();

        public List<LoaiSP> getAllLoaiSP()
        {
            DataTable dt = dblsp.laydulieu("Select * from LoaiSP");
            List<LoaiSP> li = new List<LoaiSP>();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiSP lsp = new LoaiSP();
                lsp.MaLoai =int.Parse(dr[0].ToString());
                lsp.TenLoai = dr[1].ToString();
                lsp.GhiChu = dr[2].ToString();

                li.Add(lsp);
            }
            return li;

        }
    }
}