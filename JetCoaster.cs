using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuriage
{
    public class JetCoaster
    {

        public static int ride
            (int k,int[] g,int r)
        {

            int[] copy = new int[g.Length];
            Array.Copy(g, copy, g.Length);

            //k定員
            //g乗ろうとしてるグループ
            //r動かす回数
            int n = 0;//合計人数
            for (int a = 0; a < r; a++){
                int h = 0;//乗っている人数
                for (int b = 0; b<g.Length; b++)
                {
                    if (h + g[0] > k)
                    {
                        break;
                    }
                    h += g[0];
                    int t = g[0];
                    for(int c = 0; c+1 < g.Length; c++)
                    {
                        g[c] = g[c + 1];
                    }
                    g[g.Length - 1] = t;
                }
                n += h;
            }
            Array.Copy(copy,g,copy.Length);
            return n;
        }

    }
}
