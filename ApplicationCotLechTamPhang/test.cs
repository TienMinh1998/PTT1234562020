using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationCotLechTamPhang.Model;
using ApplicationCotLechTamPhang.HamDungChung;
using ApplicationCotLechTamPhang.Model.CotThep;


namespace ApplicationCotLechTamPhang
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            ThemTimKiem();
            ThemKhoahoc("Sức bền vật liệu 1.");
            ThemKhoahoc("Sức bền vật liệu 2.");

            ThemKhoahoc("Bê Tông 1");
            ThemKhoahoc("Bê Tông 2");
            ThemKhoahoc("Nền Móng");
           

        }

        private void ThemKhoahoc(string tenkhoahoc)
        {
         
        }
        private void ThemTimKiem()
        {
           
        }








        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
          
        }

        private void pn_DanhSachPhongBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_chon_betong_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (btn_chon_betong.SelectedIndex)
            {
                case 0:
                DuLieuDungChung.betong = new BeTongB20(); // nếu là 0 thì khởi tạo B20
                    break;
                case 1:
                  DuLieuDungChung.betong = new BeTongB25(); // Nếu là 1 thì khởi tạo B25
                    break;
                default:
                 DuLieuDungChung.betong = new BeTongB20(); // mặc định thì chọn B20
                    break;
            }
        }

        private void btn_chon_thep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (btn_chon_betong.SelectedIndex)
            {
                case 0:
                   DuLieuDungChung.cotthep = new CB_240_T(); // nếu là 0 thì khởi tạo B20
                    break;
                case 1:
                    DuLieuDungChung.cotthep = new CB_300_V(); // Nếu là 1 thì khởi tạo B25
                    break;
                default:
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_chieu_cao_tiet_dien_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txt_chieu_rong_tiet_dien_TextChanged(object sender, EventArgs e)
        {
       

        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Main.Intance.txt_betong.Text = DuLieuDungChung.betong.name;
            Main.Intance.txt_thep.Text = DuLieuDungChung.cotthep.Ten_Cot_Thep;
            this.Close();

        }

        private void txt_lop_bao_ve_TextChanged(object sender, EventArgs e)
        {
            DuLieuDungChung.lopbaove = txt_lop_bao_ve.Text;
            Main.Intance.txt_lop_bao_ve.Text = DuLieuDungChung.lopbaove;

        }

        private void txt_lop_bao_ve_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraNgoaile.BatBuocNhapSo(sender,e);

        }
    }
}
