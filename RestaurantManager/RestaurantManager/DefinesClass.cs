using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    internal class DefinesClass
    {
        public DefinesClass() { }

        public string GetTableDefine(int state)
        {
            if (state == 1) return "Free";
            if (state == 2) return "Reserved";
            if (state == 3) return "Occupied";

            return "";
        }

        public int GetTableDefine(string state)
        {
            if (state == "Free") return 1 ;
            if (state == "Reserved") return 2;
            if (state == "Occupied") return 3;

            return 1;
        }
    }
}
