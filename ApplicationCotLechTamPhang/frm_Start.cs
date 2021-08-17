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
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm_main = new Main();
            frm_main.ShowDialog();
            this.Show();

        }

        private void GunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
