using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplamTutarKdvsizHesaplama
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal genelToplam = Convert.ToDecimal(txtGenelToplam.Text);
            decimal kdv = Convert.ToDecimal(txtKdv.Text);
            decimal birimUcret = Convert.ToDecimal(txtBirimUcret.Text);

            decimal kdvsizTutar = HesaplaKDVsizTutar(genelToplam,kdv);
            decimal miktar = HesaplaMiktar(kdvsizTutar,birimUcret);

            txtKdvsizTutar.Text = kdvsizTutar.ToString();
            txtMiktar.Text = miktar.ToString();
        }

        decimal HesaplaKDVsizTutar(decimal kdvliTutar, decimal kdvOrani)
        {
            return kdvliTutar / (1 + (kdvOrani / 100));
        }
        decimal HesaplaMiktar(decimal kdvsizTutar, decimal birimUcret)
        {
            return kdvsizTutar / birimUcret;
        }
    }
}
