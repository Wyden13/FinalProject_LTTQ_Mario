using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MonBus
    {
        public int id { get; set; }
        public string Ten { get; set; }
        public static List<MonBus> LayDSMon()
        {
            DataTable dt = MonDB.LayDSMon();
            List<MonBus> list = new List<MonBus>();
            foreach (DataRow dr in dt.Rows)
            {
                MonBus item = new MonBus();
                item.id = Convert.ToInt32(dr["MAMON"]);
                item.Ten = Convert.ToString(dr["TEN"]).Trim();
                list.Add(item);
            }
            return list;
        }
        public override string ToString()
        {
            return this.Ten;
        }
    }
}
