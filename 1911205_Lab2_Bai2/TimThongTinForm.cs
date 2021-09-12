using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911205_Lab2_Bai2
{
    public partial class TimThongTinForm : Form
    {
        public string _return;
        public KieuTim type;
        public TimThongTinForm()
        {
            InitializeComponent();
        }

        private void TimThongTinForm_Load(object sender, EventArgs e)
        {
            rdMa.Checked = true;
            lbText.Text = rdMa.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdMa.Checked)
                type = KieuTim.TheoMa;
            else if (rdTen.Checked)
                type = KieuTim.TheoHoTen;
            else
                type = KieuTim.TheoSDT;
            _return = txtFind.Text;
            DialogResult= DialogResult.OK;
        }
    }
}
