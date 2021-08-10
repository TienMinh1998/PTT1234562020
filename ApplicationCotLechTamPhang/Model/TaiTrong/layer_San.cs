using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeXuanToai_231461_61TH1_main.Model.TaiTrong
{
   public class layer_San
    {

        public int h { set; get; } // chiều dày
        public double y { set; get; } // trọng lượng riêng
        public double hs { get; set; }// Hệ số tin cậy
        public double gttc { get; set; }
        public double gttt { get; set; } // giá trị tính toán ở trong bảng tải trọng;
        public layer_San()
        {

        }
   
        public void tinhtoan_giatri_tinhtoan()
        {
            this.gttt = h * y * hs/1000;
            this.gttc = h * y/1000 ;
        }
    }
}

