using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMario
{
    public class nguoichoiDB
    {
        public static DataTable LayTTNguoiChoi()
        {
            return Database.SelectQuery("select * from Player");
        }
    }
}

