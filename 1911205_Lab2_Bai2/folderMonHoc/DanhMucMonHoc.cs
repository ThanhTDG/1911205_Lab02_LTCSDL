using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911205_Lab2_Bai2.folderMonHoc
{
    public class DanhMucMonHoc
    {
        public List<MonHoc> ds;
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }

        public DanhMucMonHoc()
        {
            ds = new List<MonHoc>();
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sách môn học:";
            foreach(object mh in ds)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }
    }
}
