<<<<<<< HEAD:GameMario/GameMario/Program.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMario
{
	public static class Mario
	{
        public static nguoichoi x { get; set; }
	}
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BatDau());
		}
	}
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMario
{
	public static class Mario
	{
        public static nguoichoi x { get; set; }
	}
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BatDau());
		}
	}
}
>>>>>>> 061aa2bb68e35f8f1ca9690b87dcf623e192f233:PikachuGame/GameMario/GameMario/Program.cs
