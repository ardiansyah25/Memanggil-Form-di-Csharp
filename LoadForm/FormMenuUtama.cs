using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadForm
{
    public partial class FormMenuUtama : Form
    {
        //Ubah menjadi object
        FormBarang frmBrg;
        //Buat Procedure Close
        void FrmBrg_FormClosed(Object sender, FormClosedEventArgs e)
        {
            frmBrg = null;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmBrg == null)
            {
                frmBrg = new FormBarang();
                frmBrg.FormClosed += new FormClosedEventHandler(FrmBrg_FormClosed);
                frmBrg.Show();
            }
            else
            {
                frmBrg.Activate();
            }
        }
    }
}
