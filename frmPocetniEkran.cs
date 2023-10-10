using SoftverZaTrgovinu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftverZaTrgovinu
{
    public partial class frmPocetniEkran : Form
    {
        public frmPocetniEkran()
        {
            InitializeComponent();
        }

        private void btnAdministracijaStatistika_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdministracija frm = new frmAdministracija();
            frm.ShowDialog();
            this.Close();
        }

        private void btnProdajaNaplata_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProdaja frm = new frmProdaja();
            frm.ShowDialog();
            this.Close();   
        }
    }
}
