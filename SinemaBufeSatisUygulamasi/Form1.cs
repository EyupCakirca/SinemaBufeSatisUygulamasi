using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _kasaTutar = 0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int misir, su, bilet, cay, toplam;
            misir = Convert.ToInt32(tbxMisir.Text);
            su = Convert.ToInt32(tbxSu.Text);
            cay = Convert.ToInt32(tbxCay.Text);
            bilet = Convert.ToInt32(tbxBilet.Text);

            toplam = misir * 15 + su * 2 + cay * 5 + bilet * 20;

            lblTop.Text = toplam.ToString() + "Tl";

            _kasaTutar =_kasaTutar + toplam;
            lblKToplam.Text = _kasaTutar.ToString() + "Tl";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxBilet.Text = " ";
            tbxCay.Text = " ";
            tbxMisir.Text = " ";
            tbxSu.Text = " ";
            tbxMisir.Focus();
        }
    }
}
