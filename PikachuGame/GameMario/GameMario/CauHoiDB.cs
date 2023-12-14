using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GameMario
{
	public class CauHoiDB
	{
		public static DataTable LayDSCauHoi(int mon)
		{
			return Database.SelectQuery("select * from CauHoi where MAMON=" + mon);
		}
	}
}

