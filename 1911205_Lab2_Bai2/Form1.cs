using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using _1911205_Lab2_Bai2.GiaoVienfolder;
using _1911205_Lab2_Bai2.folderMonHoc;
using _1911205_Lab2_Bai2.Properties;

namespace _1911205_Lab2_Bai2
{

    public partial class Form1 : Form
    {
        QuanLyGiaoVien dsGiaovien = new QuanLyGiaoVien();
        public Form1()
        {
            InitializeComponent();
        }
        private void GiaoVienForm_Load(object sender, System.EventArgs e)
        {
            string lienhe = "http://cntt.dlu.edu.vn/";
            linkWeb.Links.Add(0, lienhe.Length, lienhe);
            cbbMaSo.SelectedItem = "0";
        }
        private void btnAddList_Click(object sender, System.EventArgs e)
        {
            int i = lbxDSMon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbxDSDay.Items.Add(lbxDSMon.SelectedItems[i]);
                lbxDSMon.Items.Remove(lbxDSMon.SelectedItems[i]);
                i--;
            }
        }
        private void btnRemoveList_Click(object sender, System.EventArgs e)
        {
            int i = lbxDSDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbxDSMon.Items.Add(lbxDSDay.SelectedItems[i]);
                lbxDSDay.Items.Add(lbxDSDay.SelectedItems[i]);
                i--;
            }
        }
        private void picCancel_Click(object sender, System.EventArgs e)
        {
            reset();
        }

        void reset()
        {
            cbbMaSo.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            mtbSoDienThoai.Text = "";
            rdNam.Checked = true;
            for (int i = 0; i < cklNgoaiNgu.Items.Count - 1; i++)
            {
                cklNgoaiNgu.SetItemChecked(i, false);
            }
            foreach (object ob in lbxDSDay.Items)
                lbxDSMon.Items.Add(ob);
            lbxDSDay.Items.Clear();
        }
        private void linkWeb_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (cbbMaSo.Text != "")
            {
                ThongTinGiaoVienForm frm = new ThongTinGiaoVienForm(ThemGiaoVien().ToString());
                ThemGiaoVien();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không thể thêm thông tin", "Lỗi", MessageBoxButtons.OK);
            }


        }
        private GiaoVien ThemGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSO = this.cbbMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = txtHoTen.Text;
            gv.NgaySinh = dtpNgaySinh.Value;
            gv.Mail = txtEmail.Text;
            gv.SoDienThoai = mtbSoDienThoai.Text;
            string nn = "";
            for (int i = 0; i < cklNgoaiNgu.Items.Count - 1; i++)
            {
                if (cklNgoaiNgu.GetItemChecked(i))
                    nn += cklNgoaiNgu.Items[i] + ";";
                gv.NgoaiNgu = nn.Split(';');
            }
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbxDSDay.Items)
            {
                mh.Them(new MonHoc(ob.ToString()));
            }
            gv.dsMonHoc = mh;
            return gv;

        }
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (cbbMaSo.Text != "" || txtHoTen.Text != "")
            {
                if (dsGiaovien.Them(ThemGiaoVien()))
                    MessageBox.Show("Thêm thành công", "Thêm thông tin", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Mã số giáo viên đã tồn tại", "Lỗi", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Mã số hoặc họ tên không được để trống", "Lỗi", MessageBoxButtons.OK);

        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            TimThongTinForm frm = new TimThongTinForm();
            GiaoVien temp;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm._return == "")
                    MessageBox.Show("Vui lòng nhập thông tin");
                else
                {
                    temp = dsGiaovien.Tim(frm.type, frm._return);
                    if (temp != null)
                    {
                        ThongTinGiaoVienForm frmThongTin = new ThongTinGiaoVienForm(temp.ToString());
                        frmThongTin.ShowDialog();
                    }
                    else
                        MessageBox.Show("Không có giáo viên tìm kiếm!", "Thông báo");
                }
            }
        }
    }
}
