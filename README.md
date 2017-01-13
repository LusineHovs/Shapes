# Shapes
In **Shape** you can find **Shape3D** abstract class, from which **Ellipsoid** and **Parallelepiped** classes were inherited. In **Ellipsoid** and **Parallelepiped** classes were written the calculation of *volumes* and *surfaces* of appropriate geometrical objects.

Below mentioned code you can use to execute the program (**UserProgram** file).

#UserProgram
~~~
Ellipsoid elips = new Ellipsoid(10, 20, 70);
Console.WriteLine("The Volume of ellopsoid = {0}, the Surface of ellipsoid = {1}", elips.Volume, elips.Surface);
Parallelepiped piped = new Parallelepiped(20, 10, 20);
Console.WriteLine("The Volume of parallelepiped = {0}, the Surface of parallelepiped = {1}", piped.Volume, piped.Surface);
Console.Read();

#Outputs
The Volume of ellopsoid = 43960, the Surface of ellipsoid = 10800.47
The Volume of parallelepiped = 4000, the Surface of parallelepiped = 1600
