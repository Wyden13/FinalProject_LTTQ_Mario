<<<<<<< HEAD:GameMario/GameMario/nguoichoi.cs
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameMario
{
	public class nguoichoi
	{
		//public string skin;
		public string ten { get; set; }
		public int mon { get; set; }
		public int highest_score { get;set; }
		public int mang
		{
			get; set;
		}
		public int diem
		{
			get; set;
		}
		
		public nguoichoi(string name, int mon)
		{
			this.ten = name;
			this.mon = mon;
			this.diem = 0;
			this.highest_score = 0;
			this.mang = 3;
		}
	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameMario
{
	public class nguoichoi
	{
		//public string skin;
		public string ten { get; set; }
		public int mon { get; set; }
		public int highest_score { get;set; }
		public int mang
		{
			get; set;
		}
		public int diem
		{
			get; set;
		}
		
		public nguoichoi(string name, int mon)
		{
			this.ten = name;
			this.mon = mon;
			this.diem = 0;
			this.highest_score = 0;
			this.mang = 3;
		}
	}
}
>>>>>>> 061aa2bb68e35f8f1ca9690b87dcf623e192f233:PikachuGame/GameMario/GameMario/nguoichoi.cs
