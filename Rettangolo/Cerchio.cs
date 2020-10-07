using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Cerchio
    {
        public static double PI = 3.14;

        public double raggio;

        public Cerchio(double r)
        {
            raggio = r;
        }

        public double CalcolaCirconferenza()
        {
            return 2 * PI * raggio;
        }

        public double CalcolaArea()
        {
            return PI * raggio * raggio;
        }
    }
}
