using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911205_Lab2
{
    public partial class TrungTamForm : Form
    {
        public TrungTamForm()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTiengAnhA.Checked)
                s += int.Parse(lbTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s += int.Parse(lbTienTAB.Text.Split('.')[0]); 
            if (chkTinHocA.Checked)
                s += int.Parse(lbTienTHA.Text.Split('.')[0]); 
            if (chkTinHocB.Checked)
                s += int.Parse(lbTienTHB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            cbbMaHV.Text = "";
            txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            rdNam.Checked = true;
            chkTiengAnhA.Checked = false;
            chkTiengAnhB.Checked = false;
            chkTinHocA.Checked = false;
            chkTinHocB.Checked = false;
            txtTongTien.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
