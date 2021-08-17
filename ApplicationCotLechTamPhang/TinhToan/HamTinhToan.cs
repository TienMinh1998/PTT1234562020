using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCotLechTamPhang.TinhToan
{
   public  class HamTinhToan
    {
        // Tính toán ra giá trị Eo
        public double tinhtoanhEo(double e1, double ea)
        {
            try
            {
                return e1 > ea ? e1 : ea;
            }
            catch (Exception)
            {

                return 0;
            }
         
        }
        // Tính toán ra giá trị ho
        /// <summary>
        /// Hàm tính toán ra ho
        /// </summary>
        /// <param name="a">Là lớp bảo vệ</param>
        /// <param name="h">H là chiều cao của nột</param>
        /// <returns></returns>
        public double tinhtoan_ho(double a,double h)
        {
            // truyền vào a và H, từ đó tính ra ho.
            try
            {
                DuLieuDungChung.ho = h - a;              
            }
            catch (Exception)
            {
                DuLieuDungChung.ho=0;
            }
            return DuLieuDungChung.ho;
        }

        public double tinhtoan_lo(string chieudai, double he_so_uon_doc)
        {
            if (chieudai !="")
            {
                try
                {
                    double l = double.Parse(chieudai);
                    DuLieuDungChung.lo = l * he_so_uon_doc;
                }
                catch (Exception)
                {
                    DuLieuDungChung.lo = 0;
                }
              
            }
            return DuLieuDungChung.lo;

        }

       
    }
}
