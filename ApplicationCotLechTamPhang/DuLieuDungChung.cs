// Chỗ để lưu dữ liệu của cả chương trình


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationCotLechTamPhang.Model;
using ApplicationCotLechTamPhang.Model.CotThep;
namespace ApplicationCotLechTamPhang
{
   public class DuLieuDungChung
    {
        public static BeTong betong; // khinchonj bê tông xong sẽ lưu ở đây...
        internal static CotThepTieuChuanMoi cotthep;
        public static string a = "0";
        public static double dolechtamtinhhoc = 0;
        public static double _h = 0; // mm
        public static double _b = 0;
        public static double ho = 0; // = chiều cao tiết diện trừ đi lớp bảo vệ.

        public static double chieucaocot;
        
        public static double e1;
        public static double ea;
        public static double eo;
        public static double lo = 0; // lo là chiều dài tính toán của cột.
        public static double I = 0;
        public static double IS = 0;
        public static double hamluongcotthep_giathiet;
        
        // Các thống số khác tính toán ra?
        public static double xichma_e;
        public static double Kb = 0;
        public static double D = 0;
        public static double Ncr; // Lực dọc tới hạn quy ước.
        public static double _n = 0; // neta
        public static double _e = 0;
        public static double e_phay;
        public static double _x1 = 0; // đơn vị  Cm
        public static double _X = 0;
        public static double _Za = 0;  // Cm

    }


    class KiemTraNgoaile
    {
        public static void BatBuocNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
