using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._2_faisalilhammuzaqi
{
    public partial class frmTugas : Form
    {
        public frmTugas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPekerjaan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPesan1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesan2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesan3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("HALLO {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan Anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Aanda Seorang {0}, Hebat !!!!!!", pekerjaan);

        }
    }
}
