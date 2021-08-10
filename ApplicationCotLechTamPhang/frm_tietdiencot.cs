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

namespace ApplicationCotLechTamPhang
{
    public partial class frm_tietdiencot : Form
    {
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
            Main.Intance.txt_chieu_cao_td.Text = txt_chieu_cao_tiet_dien.Text;
            txt_h.Text = txt_chieu_cao_tiet_dien.Text;
        }

        private void txt_chieu_rong_tiet_dien_TextChanged(object sender, EventArgs e)
        {
            Main.Intance.txt_chieu_rong_tiet_dien.Text = txt_chieu_rong_tiet_dien.Text;
            txt_b.Text = txt_chieu_rong_tiet_dien.Text;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_chieu_cao_tiet_dien_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraNgoaile.BatBuocNhapSo(sender, e);
        }

        private void txt_chieu_Dai_cot_TextChanged(object sender, EventArgs e)
        {
            Main.Intance.txt_chieu_cao_cot.Text = txt_chieu_Dai_cot.Text;

        }
    }
}
