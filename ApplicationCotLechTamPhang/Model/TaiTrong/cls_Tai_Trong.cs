using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeXuanToai_231461_61TH1_main.Model.TaiTrong
{
  public class cls_Tai_Trong
    {
        public double TongGiaTriTinhToan;
        public double TongGiaTriTieuChuan;


       public cls_lop_gach gach = new cls_lop_gach();
       public Cls_taitrong_betong betong = new Cls_taitrong_betong();
       public cls_lop_vua_lot vualot = new cls_lop_vua_lot();
       public cls_lop_vua_chat vuatrat = new cls_lop_vua_chat();

        public void TinhTongTinhTai()
        {
            this.TongGiaTriTinhToan = gach.gttt + betong.gttt + vualot.gttt + vuatrat.gttt;
            this.TongGiaTriTieuChuan = gach.gttc + betong.gttc + vualot.gttc + vuatrat.gttc;
        }
    }
}
