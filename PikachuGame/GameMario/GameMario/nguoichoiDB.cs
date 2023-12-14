<<<<<<< HEAD:GameMario/GameMario/nguoichoiDB.cs
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 061aa2bb68e35f8f1ca9690b87dcf623e192f233:PikachuGame/GameMario/GameMario/nguoichoiDB.cs
