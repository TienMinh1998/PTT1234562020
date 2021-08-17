using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCotLechTamPhang.TinhToan
{
   public class TinhToanDolechTamTinhHoc
    {
        public double tinhtoandolechtamtinhhoc(string P_m, string p_n)
        {
            try
            {
                double m = double.Parse(P_m);           // đây là moment truyền vào
                double n = double.Parse(p_n);           // đây là lực dọc truyền vào
                DuLieuDungChung.e1 = Math.Round((m / n), 3);  // kết quả làm tròn đến chữ số thứ 3
                return Math.Round((m / n),5)*1000;   // Nhân với 1000 để đổi ra mm.
            }
            catch (Exception)
            {
                return 0;
            }
                 
        }    
    }
}
