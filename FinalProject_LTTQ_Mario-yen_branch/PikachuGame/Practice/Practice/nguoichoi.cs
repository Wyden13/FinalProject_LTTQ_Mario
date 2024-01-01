using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class nguoichoi
    {
        //public string skin;
        //public int lop { get; set; }
        public int mon { get; set; }
        public int mang
        {
            get; set;
        }
        public int diem
        {
            get; set;
        }
        public nguoichoi(/*int lop, */int mon)
        {
            //this.lop = lop;
            this.mon = mon;
            this.diem = 0;
            this.mang = 3;
        }
    }
}
