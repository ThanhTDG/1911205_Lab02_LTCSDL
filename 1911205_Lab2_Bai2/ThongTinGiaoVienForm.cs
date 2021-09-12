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
    public partial class ThongTinGiaoVienForm : Form
    {
        string _thongtin;
        public ThongTinGiaoVienForm(string thongtin)
        {
            InitializeComponent();
            _thongtin = thongtin;
        }

        private void ThongTinGiaoVienForm_Load(object sender, EventArgs e)
        {
            lbThongTin.Text = _thongtin;
        }
    }
}
