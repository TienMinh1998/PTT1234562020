using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationCotLechTamPhang.frm;
using ApplicationCotLechTamPhang.TinhToan;

namespace ApplicationCotLechTamPhang
{
    public partial class frm_tietdiencot : Form
    {
        public TrungTamTinhToan trungtamtinhtoan = new TrungTamTinhToan();


        public frm_tietdiencot()
        {
            InitializeComponent();
        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void txt_chieu_cao_tiet_dien_TextChanged(object sender, EventArgs e)
        {       
            Xulysukienthaydoidulieu();
        }
        private void txt_chieu_rong_tiet_dien_TextChanged(object sender, EventArgs e)
        {
            Xulysukienthaydoidulieu();

        }
        private void txt_chieu_Dai_cot_TextChanged(object sender, EventArgs e)
        {
            Xulysukienthaydoidulieu();
        }


        private void Xulysukienthaydoidulieu()
        {
           
            // Nếu chiều cao tiết diện khác rỗng
            if (txt_chieu_cao_tiet_dien.Text != "")
            {
                Main.Intance.txt_chieu_cao_td.Text = txt_chieu_cao_tiet_dien.Text;
                txt_h.Text = txt_chieu_cao_tiet_dien.Text;
                DuLieuDungChung._h = double.Parse(txt_chieu_cao_tiet_dien.Text);
            }
            trungtamtinhtoan.tinhtoan_ho();

            // Nếu chiều Rộng khác rỗng   
            if (txt_chieu_rong_tiet_dien.Text != "")
            {
                Main.Intance.txt_chieu_rong_tiet_dien.Text = txt_chieu_rong_tiet_dien.Text;
                txt_b.Text = txt_chieu_rong_tiet_dien.Text;
                DuLieuDungChung._b = double.Parse(txt_chieu_rong_tiet_dien.Text);
            }

            // chiều dài của cột thay đổi :
            if (txt_chieu_Dai_cot.Text != "")
            {
                Main.Intance.txt_chieu_cao_cot.Text = txt_chieu_Dai_cot.Text;
                // Tính chiều dài tính toán của cột
                HamTinhToan hamtinhtoan = new HamTinhToan();
                Main.Intance.txt_lo.Text = hamtinhtoan.tinhtoan_lo(txt_chieu_Dai_cot.Text, 0.7).ToString(); // 0.7 là hệ số uốn dọc, xem tiêu chuẩn
            }
            // Tinh moment quán tính cho bê tông : 
            trungtamtinhtoan.tinhtoan_I(DuLieuDungChung._b, DuLieuDungChung._h).ToString();
            Main.Intance.txt_momenquantinh.Text = DuLieuDungChung.I.ToString();
            // TÍnh moment quán trính cho cốt thép;
            trungtamtinhtoan.tinhtoan_IS(DuLieuDungChung._b, DuLieuDungChung._h, DuLieuDungChung.ho, double.Parse(DuLieuDungChung.a));
            Main.Intance.txt_is.Text = DuLieuDungChung.IS.ToString();


        }

    

        private void btn_ok_Click(object sender, EventArgs e)
        {
           
         
            // TÍnh toán Ho: 
      
            this.Close();

        }

        private void txt_chieu_cao_tiet_dien_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraNgoaile.BatBuocNhapSo(sender, e);
        }

     
    }
}
