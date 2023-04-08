using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._04
{
    internal class Sphere
    {
        public int Radius { get; set; }
        public int Values { get; set; }

        public Sphere(int n, int v)
        {
            Radius = n;
            Values = v;
        }

        public override string ToString()
        {
            return new string($"Радиус: {Radius} Объем {Values}");
        }

        public static bool operator >(Sphere u1, Sphere u2)
        {
            if (u1.Radius > u2.Values) return true;
            else return false;
        }

        public static bool operator <(Sphere u1, Sphere u2)
        {
            if (u1.Radius < u2.Values) return true;
            else return false;
        }
    }
}