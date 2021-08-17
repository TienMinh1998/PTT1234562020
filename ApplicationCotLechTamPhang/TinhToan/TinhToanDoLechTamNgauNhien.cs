using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCotLechTamPhang.TinhToan
{
   public class TinhToanDoLechTamNgauNhien
    {
        public double DoLechTamNgauNhien(double h, double H )
        {
            // lấy min của 3 kết quả : h/30, H/600 và 10.
            try
            {
             // Chiều cao của cột.
                double ketqua = (h/30) > (H/600) ? (h/30) : (H/600);
                DuLieuDungChung.ea = Math.Round((ketqua > 10 ? ketqua : 10), 2);
                return Math.Round((ketqua > 10 ? ketqua : 10),2);
            }
            catch (Exception)
            {

                return 0;
            }
         
        }
    }
}
