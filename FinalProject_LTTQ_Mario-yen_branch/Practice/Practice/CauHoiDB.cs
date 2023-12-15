using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class CauHoiDB
    {
        public static DataTable LayDSCauHoi( int mon)
        {
            return Database.SelectQuery("select * from CauHoi where  MAMON=" + mon);
        }
    }
}
