using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911205_Lab2_Bai2.folderMonHoc
{
    public class MonHoc 
    {

        public int Id { get; set; }
        public int SoTC { get; set; }
        public string TenMH { get; set; }
        public MonHoc()
        {
        }
        public MonHoc(int id, string ten, int soTC)
        {
            Id = id;
            TenMH = ten;
            SoTC = soTC;
        }
        public MonHoc(string ten)
        {
            TenMH = ten;
        }

        public override string ToString()
        {
            return TenMH;
        }
    }
}
