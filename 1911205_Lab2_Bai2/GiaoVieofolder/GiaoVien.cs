using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1911205_Lab2_Bai2.folderMonHoc;

namespace _1911205_Lab2_Bai2.GiaoVienfolder
{
    public class GiaoVien
    {
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string Mail;
        public DateTime NgaySinh;
        public string[] NgoaiNgu;
        public string SoDienThoai;
        public string HoTen { get; set; }
        public string MaSO { get; set;}
        

        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maSO, string hoten, string gioiTinh, DanhMucMonHoc ds, string mail, DateTime ngaySinh, string soDienThoai, string[] nn)
        {
            MaSO = maSO;
            HoTen = hoten;
            GioiTinh = gioiTinh;
            Mail = mail;
            dsMonHoc = ds;
            NgaySinh = ngaySinh;   
            SoDienThoai = soDienThoai;
            NgoaiNgu = nn;
            
         }
        public override string ToString()
        {
            string s = "Mã số:" + MaSO
                + "\n" + "Họ tên:" + HoTen
                + "\n" + "Ngày sinh:"+NgaySinh
                + "\n" + "Giới tính:"+GioiTinh
                + "\n" + "Số điện thoại:"+SoDienThoai
                + "\n" + "Mail:"
                +"\n";
            string sNgoaiNgu = "Ngọai ngữ";
            foreach(string sNN in NgoaiNgu)
            {
                sNgoaiNgu += sNN + "; ";
            }
            string SMonDay = "Danh sách môn dạy";
            foreach (MonHoc smonday in dsMonHoc.ds)
                SMonDay += smonday + "; ";
               s+="\n" +sNgoaiNgu + "\n"+ SMonDay;
            return s;
        }
    }
}
