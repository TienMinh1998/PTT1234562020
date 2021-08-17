using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2;
using Guna.UI.WinForms;
using ApplicationCotLechTamPhang.HamDungChung;
using ApplicationCotLechTamPhang.frm;

namespace ApplicationCotLechTamPhang
{
    public partial class Main : Form
    {

        private static Main _instance;

        public static Main Intance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Main();
                }
                return _instance;
            }
        }
        public Main()
        {
            InitializeComponent();
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
            
        }

      
        public  void func_ShowForm(Form _frm)
        {
           pn_main.Controls.Clear();
            _frm.TopLevel = false;
            _frm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(_frm);
           _frm.Show();
        }

  

     

    


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_chon_vat_lieu_Click(object sender, EventArgs e)
        {
            frm_chon_Vat_lieu frm_chon_vat_lieu = new frm_chon_Vat_lieu();
            this.Opacity = 0.7;
            frm_chon_vat_lieu.ShowDialog();
            this.Opacity = 1;
        }

        private void btn_chon_tiet_Dien_Click(object sender, EventArgs e)
        {
            frm_tietdiencot frm = new frm_tietdiencot();
            this.Opacity = 0.7;
            frm.ShowDialog();
            this.Opacity = 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frm_giaodien_noi_luc frm_noi_luc = new frm_giaodien_noi_luc();
            this.Opacity = 0.6;
            frm_noi_luc.ShowDialog();
            this.Opacity = 1;

        }

        private void btn_nhap_noi_luc_Click(object sender, EventArgs e)
        {
            frm_Noiluc frm = new frm_Noiluc();
            this.Opacity = 0.7;
            frm.ShowDialog();
            this.Opacity = 1;
        }

        private void btn_gia_thiet_ham_luong_cot_Thep_Click(object sender, EventArgs e)
        {
            frm_giathiethamluongcotthep frm_giathiet = new frm_giathiethamluongcotthep();
            frm_giathiet.ShowDialog();

        }
    }
}
