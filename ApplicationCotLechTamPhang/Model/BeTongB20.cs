using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCotLechTamPhang
{
    // LỚp Bê TÔng B20
    // kế thừ từ lớp bê tông nên có luôn
  public class BeTongB20 :BeTong
    {
        
        public BeTongB20()
        {
            CuongDoChiuNen_Rb = 11.5;
            CuongDOChiuKeo_Rbt = 0.90;
            EB = 27.5;
            name = "B20";
            donvi = "Mpa";
        }
        
    }
}
