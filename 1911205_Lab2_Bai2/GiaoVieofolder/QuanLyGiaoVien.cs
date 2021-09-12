using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1911205_Lab2_Bai2;

namespace _1911205_Lab2_Bai2.GiaoVienfolder
{
    delegate void SoSanh (object a, object b);

    public class QuanLyGiaoVien
    {
        private List<GiaoVien> dsGiaoVien =new List<GiaoVien>();
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set {  dsGiaoVien[index] = value; }
        }
        public QuanLyGiaoVien() { }
    
        public GiaoVien Tim (KieuTim type, string _return)
        {
            if(type == KieuTim.TheoMa)
            return dsGiaoVien.Find(x=>x.MaSO ==_return);
            else if (type == KieuTim.TheoHoTen)
                return dsGiaoVien.Find(x => x.HoTen == _return);
            else
                return dsGiaoVien.Find(x => x.SoDienThoai == _return);
        }
        public void xoa( object a, object b)
        {

        }
        public bool Them(GiaoVien gv)
        {
           if (dsGiaoVien.Count == 0)
            {
                dsGiaoVien.Add(gv);
                return true;
            }
            else if (dsGiaoVien.FindIndex(x => x.MaSO == gv.MaSO) == -1){
                dsGiaoVien.Add(gv);
                return true;
            }
           else
            {
                return false;
            }
        }
        public void SapXep(KieuTim type)
        {
            dsGiaoVien.Sort(delegate (GiaoVien x1, GiaoVien x2)
            {
                if (type == KieuTim.TheoMa)
                    return x1.MaSO.CompareTo(x2.MaSO);
                else if (type == KieuTim.TheoHoTen)
                    return x1.HoTen.CompareTo(x2.HoTen);
                else
                    return x1.NgaySinh.CompareTo(x2.NgaySinh);
            });

        }
    }
}
