using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape3D
    {
        protected float a { get; set; }
        protected float b { get; set; }
        protected float c { get; set; }

        public abstract float Volume { get; }
        public abstract float Surface { get; }
    }
}
