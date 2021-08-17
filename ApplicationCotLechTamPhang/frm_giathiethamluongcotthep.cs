using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationCotLechTamPhang
{
    public partial class frm_giathiethamluongcotthep : Form
    {
        public frm_giathiethamluongcotthep()
        {
            InitializeComponent();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            try
            {
                DuLieuDungChung.hamluongcotthep_giathiet = double.Parse(txt_ham_luong_cot_thep_gia_thiet.Text) / 100;
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
