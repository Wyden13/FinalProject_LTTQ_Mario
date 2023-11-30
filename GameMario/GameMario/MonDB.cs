using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GameMario
{
	public class MonDB
	{
		public static DataTable LayDSMon()
		{
			return Database.SelectQuery("select * from Mon");
		}
	}
}
