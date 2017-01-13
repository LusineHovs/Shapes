using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Ellipsoid : Shape3D
    {
        public Ellipsoid(float a, float b, float c)
        {
            base.a = a;
            base.b = b;
            base.c = c;
        }

        public override float Volume
        {
            get
            {
                return (float)(4 / 3 * 3.14 * a * b * c);
            }
        }

        public override float Surface
        {
            get { return (float)(4 * Math.PI * Math.Pow(((Math.Pow(a * b, 1.6) + Math.Pow(a * c, 1.6) + Math.Pow(b * c, 1.6)) / 3), 1 / 1.6)); }
        }
    }
}
