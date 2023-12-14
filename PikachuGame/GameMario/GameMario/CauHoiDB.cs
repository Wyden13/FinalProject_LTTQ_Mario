<<<<<<< HEAD:GameMario/GameMario/CauHoiDB.cs
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 061aa2bb68e35f8f1ca9690b87dcf623e192f233:PikachuGame/GameMario/GameMario/CauHoiDB.cs
