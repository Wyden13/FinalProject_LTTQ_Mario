using System;
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
