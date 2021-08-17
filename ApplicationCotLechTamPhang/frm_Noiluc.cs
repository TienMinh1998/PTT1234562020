using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationCotLechTamPhang.TinhToan;

namespace ApplicationCotLechTamPhang
{
    public partial class frm_Noiluc : Form
    {
        public HamTinhToan hamtinhtoan;
        public frm_Noiluc()
        {
            InitializeComponent();
        }

        private void txt_moment_TextChanged(object sender, EventArgs e)
        {
            TinhToanDolechTamTinhHoc tinhtoandolechtamtinhhoc = new TinhToanDolechTamTinhHoc();
            DuLieuDungChung.e1 = tinhtoandolechtamtinhhoc.tinhtoandolechtamtinhhoc(txt_m.Text, txt_n.Text);
            txt_e1.Text = DuLieuDungChung.e1.ToString();

            TinhToanDoLechTamNgauNhien tinhToanDoLechTamNgauNhien = new TinhToanDoLechTamNgauNhien();
            DuLieuDungChung.ea = tinhToanDoLechTamNgauNhien.DoLechTamNgauNhien(DuLieuDungChung._h, DuLieuDungChung.chieucaocot);

            txt_ea.Text = tinhToanDoLechTamNgauNhien.DoLechTamNgauNhien(DuLieuDungChung._h, DuLieuDungChung.chieucaocot).ToString();
            // Tính toán eo :

            hamtinhtoan = new HamTinhToan();
            txt_eo.Text = hamtinhtoan.tinhtoanhEo(DuLieuDungChung.e1, DuLieuDungChung.ea).ToString();
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void txt_luc_doc_TextChanged(object sender, EventArgs e)
        {
            // TÍnh toán E1
            TinhToanDolechTamTinhHoc tinhtoandolechtamtinhhoc = new TinhToanDolechTamTinhHoc();
            DuLieuDungChung.e1 = tinhtoandolechtamtinhhoc.tinhtoandolechtamtinhhoc(txt_m.Text, txt_n.Text);
            txt_e1.Text = DuLieuDungChung.e1.ToString();

            // Tính Toán ea
            TinhToanDoLechTamNgauNhien tinhToanDoLechTamNgauNhien = new TinhToanDoLechTamNgauNhien();
            DuLieuDungChung.ea = tinhToanDoLechTamNgauNhien.DoLechTamNgauNhien(DuLieuDungChung._h, DuLieuDungChung.chieucaocot);
            txt_ea.Text = tinhToanDoLechTamNgauNhien.DoLechTamNgauNhien(DuLieuDungChung._h, DuLieuDungChung.chieucaocot).ToString();
            // Tính toán eo :

            hamtinhtoan = new HamTinhToan();
            txt_eo.Text = hamtinhtoan.tinhtoanhEo(DuLieuDungChung.e1, DuLieuDungChung.ea).ToString();
        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_tinh_toan_Click(object sender, EventArgs e)
        {
            tinhtoanlaieo();
            double m = double.Parse(txt_m.Text);
            double n = double.Parse(txt_n.Text); // Lực DỌc
            double mtt = double.Parse(txt_mtt.Text);
            double ntt = double.Parse(txt_ntt.Text);

            double ml1 = mtt + ntt * (0.5 * DuLieuDungChung._h/1000 - double.Parse(DuLieuDungChung.a)/1000); // chia  1000 để đổi ra m
            double ml = m + n * (0.5 * DuLieuDungChung._h/1000 - double.Parse(DuLieuDungChung.a)/1000);       // chia 1000 để đổi ra m 

            double phi = Math.Round(( 1 + ml1 / ml),2);
            txt_phi_l.Text = phi.ToString();

            txt_ml1.Text = ml1.ToString();
            txt_ml.Text = ml.ToString();

            // TÍnh xích ma e : 
            TrungTamTinhToan trungTamTinhToan = new TrungTamTinhToan();
            txt_xichmae.Text = trungTamTinhToan.tinhtoan_xichma_e(DuLieuDungChung.eo, DuLieuDungChung._h).ToString();
            DuLieuDungChung.xichma_e = double.Parse(txt_xichmae.Text);

            // có xich ma e rồi thì đi tính Kb : 
            double kb = Math.Round((0.15 / (phi * (0.3 + DuLieuDungChung.xichma_e))), 3);
            DuLieuDungChung.Kb = kb;
            txt_kb.Text = kb.ToString();
            // Tính toán D áp dụng công thức trong tiêu chuẩn 5574-2018
            double D, Kb, I, Is, Ks, Es, Eb;
            Kb = kb;
            I = DuLieuDungChung.I;
            Eb = DuLieuDungChung.betong.EB;
            Ks = 0.7;
            Es = 2*Math.Pow(10,8);
            Is = DuLieuDungChung.IS;

            // TÍnh Toán và lưu lại D  :D
            D = Kb * Eb*Math.Pow(10,6) * I + Ks * Es * Is; //nhân 10^6 để đổi ra KN
            txt_d.Text = D.ToString();
            DuLieuDungChung.D = D;

            // TÍnh toán xong D ta đi tính Ncr:======================================
            double pi = Math.PI;
            double lo = DuLieuDungChung.lo;
            lo = lo / 1000; // đổi đơn vị ra m;
                double Ncr = (Math.Pow(pi, 2) * D) / lo;
            DuLieuDungChung.Ncr = Ncr; // Tính xong thì lưu lại thôi;=================

            // ===== TÍNH TOÁN Neta (n)===================================================
            double _n, ms, ts;

            ms = 1 - (n / Ncr);
            ts = 1;
            _n = ts / ms; 
            _n = Math.Round(_n, 2); // làm tròn 2 chữ số
            DuLieuDungChung._n = _n;
            txt_neta.Text = _n.ToString();

            //TÍnh toán xong neta thì ta đi tính e:
            //e là khoảng cách từ điểm đặt lực dọc cho đến trọng tâm tiết diện cốt thép chịu kéo hoặc chịu nén
            // ít hơn
            // Công thức tính e : Mục 8.1.2.4.1 TCVN 5574 - 2018

            double _e, eo, ho, a;
            eo = DuLieuDungChung.eo;  // lấy dữ liệu eo về
            ho = DuLieuDungChung.ho;  // lấy dữ liệu Ho về
            a = double.Parse(DuLieuDungChung.a); // lấy dữ liệu lớp bảo vệ về;
            _e = eo * _n + ((ho - a) / 2); // áp dụng công thức
            _e = Math.Round(_e, 2); // làm tròn
            DuLieuDungChung._e = _e; // đơn vị mm
            txt_e.Text = _e.ToString();

            // Xác định sơ bộ chiều cao cùng nén, Áp dụng công thức trong tiêu chuẩn : 
            double x1, yb, Rb, b;
            yb = 1;
            Rb = DuLieuDungChung.betong.CuongDoChiuNen_Rb;
            b = DuLieuDungChung._b;
            b = b / 1000;
            x1 = n / (yb * Rb * Math.Pow(10, 3) * b); // đổi sang đơn vị Kn/m2 nên nhân với 10^3
            x1 = Math.Round(x1, 3);
            x1 = x1 * 100;
            txt_x1.Text = x1.ToString(); // đổi ra cm để hiển thị

            // ---------------------------Tính 2a' :
            double ax2 = (double.Parse(DuLieuDungChung.a) / 10) * 2; // Tính 2 lần a', chia 10 để đổi đơn vị sang cm
            double ErxHo = 0.5333 * (DuLieuDungChung.ho / 10); // chia 10 để đổi ra cm;
       
            // -----------------------so sánh x1 với 2a và Erxho:
            if (x1<ax2)
            {
                // trường hơp đặc biệt 2
                DuLieuDungChung._X = 0;
                #region "Tinhs E'" 
                //----------------------------- TÍNH  e'---------------------------------------- : 
                double e_phay;
                e_phay = _e - ho + a;
                e_phay = e_phay / 10; // đổi sang cm;
                txt_e_phay.Text = e_phay.ToString();
                DuLieuDungChung.e_phay = e_phay;
                //--------------------------------------------------------------------------------;
                #endregion
                // TÍNH Za : 
                double za;
                za = (DuLieuDungChung.ho / 10) - (double.Parse(DuLieuDungChung.a)/10);
                DuLieuDungChung._Za = za;
                // TÍnh diện Tích của cố thép :
                double As, As_phay,Rs, NN;
                Rs = DuLieuDungChung.cotthep.Rs;
                As = (n * e_phay) / (Rs * za);
                As = As * 10000; // đổi từ m2 sang cm2

                MessageBox.Show(As.ToString());

                
                
            }

        }

        private void tinhtoanlaieo()
        {
            TinhToanDolechTamTinhHoc tinhtoandolechtamtinhhoc = new TinhToanDolechTamTinhHoc();
            DuLieuDungChung.e1 = tinhtoandolechtamtinhhoc.tinhtoandolechtamtinhhoc(txt_m.Text, txt_n.Text);
            txt_e1.Text = DuLieuDungChung.e1.ToString();

            TinhToanDoLechTamNgauNhien tinhToanDoLechTamNgauNhien = new TinhToanDoLechTamNgauNhien();
            DuLieuDungChung.ea = tinhToanDoLechTamNgauNhien.DoLechTamNgauNhien(DuLieuDungChung._h, DuLieuDungChung.chieucaocot);

            txt_ea.Text = tinhToanDoLechTamNgauNhien.DoLechTamNgauNhien(DuLieuDungChung._h, DuLieuDungChung.chieucaocot).ToString();
            // Tính toán eo :
            hamtinhtoan = new HamTinhToan();
            txt_eo.Text = hamtinhtoan.tinhtoanhEo(DuLieuDungChung.e1, DuLieuDungChung.ea).ToString();
            DuLieuDungChung.eo = double.Parse(txt_eo.Text);

        }
    }
}
