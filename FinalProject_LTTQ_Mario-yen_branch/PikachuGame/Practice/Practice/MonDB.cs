using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MonDB
    {
        public static DataTable LayDSMon()
        {
            return Database.SelectQuery("select * from Mon");
        }
    }
}
