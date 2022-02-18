using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuriage
{
    public class kuriage
    {

        public static int Kuriage10(int i)
        {
            if (i == 0) return 0;
            int a = 0;
            if (i < 0)
            {
                a = 1;
                i = i * -1;
            }
            if (i % 10 != 0) i += 10 - i % 10;
            if (a == 1) i = i * -1;

            return i;
        }


    }
}
