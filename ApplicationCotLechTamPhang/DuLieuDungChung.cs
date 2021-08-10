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
        public static BeTong betong;
        internal static CotThepTieuChuanMoi cotthep;
        public static string lopbaove;

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
