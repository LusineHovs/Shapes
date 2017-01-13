using Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipsoid elips = new Ellipsoid(10, 20, 70);
            Console.WriteLine("The Volume of ellopsoid = {0}, the Surface of ellipsoid = {1}", elips.Volume, elips.Surface);
            Parallelepiped piped = new Parallelepiped(20, 10, 20);
            Console.WriteLine("The Volume of parallelepiped = {0}, the Surface of parallelepiped = {1}", piped.Volume, piped.Surface);
            Console.Read();
        }
    }
}
