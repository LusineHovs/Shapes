using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Parallelepiped : Shape3D
    {
        public Parallelepiped(float a, float b, float c)
        {
            base.a = a;
            base.b = b;
            base.c = c;
        }


        public override float Volume
        {
            get
            {
                return (a * b * c);
            }
        }

        public override float Surface
        {
            get
            {
                return 2 * (a * b + a * c + b * c);
            }
        }
    }
}
