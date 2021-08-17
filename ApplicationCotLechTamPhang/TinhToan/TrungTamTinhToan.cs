using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCotLechTamPhang.TinhToan
{
   public class TrungTamTinhToan
    {
        public void tinhtoan_ho()
        {

            HamTinhToan tinhtoan = new HamTinhToan();
            Main.Intance.txt_ho.Text = tinhtoan.tinhtoan_ho(double.Parse(DuLieuDungChung.a), DuLieuDungChung._h).ToString();
        }
        public double tinhtoan_I(double b_mm, double h_mm)
        {
            try
            {
                double b_m = b_mm / 1000;
                double h_m = h_mm / 1000;
                DuLieuDungChung.I = (b_m * Math.Pow(h_m, 3)) / 12;
            }
            catch (Exception)
            {
                DuLieuDungChung.I = 0;
            }

            return DuLieuDungChung.I;
        }

        public double tinhtoan_IS(double b_mm, double h_mm,double ho_mm,double a_mm)
        {
            try
            {
                double b_m = b_mm / 1000;
                double h_m = h_mm / 1000;
                double ho_m = ho_mm / 1000;
                double a_m = a_mm / 1000;
                double ut = DuLieuDungChung.hamluongcotthep_giathiet;
                double ketqua = Math.Round((ut * b_m * ho_m) * Math.Pow((0.5*h_m - a_m), 2),6);
                DuLieuDungChung.IS = ketqua;
            }
            catch (Exception)
            {
                DuLieuDungChung.IS = 0;
            }

            return DuLieuDungChung.IS;
        }

        public double tinhtoan_xichma_e(double eo, double h)
        {
            try
            {
                return Math.Round((eo / h), 4);
            }
            catch (Exception)
            {
                return 0;             
            }
           

     

        }
    }
}
