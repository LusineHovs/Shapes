# Shapes
In **Shape** you can find **Shape3D** abstract class, from which **Ellipsoid** and **Parallelepiped** classes were inherited. In **Ellipsoid** and **Parallelepiped** classes were written the formulas of calculation appropriate geometrical objects' *volumes* and *surfaces*.

Below mentioned code you can use to execute the program (**UserProgram** file) with the following inputs:

#Inputs
- Ellipsoid(10, 20, 70)
- Parallelepiped(20, 10, 20)

#UserProgram
```C#
Ellipsoid elips = new Ellipsoid(10, 20, 70);
Console.WriteLine($"The Volume of ellopsoid = {elips.Volume}, the Surface of ellipsoid = {elips.Surface}");
Parallelepiped piped = new Parallelepiped(20, 10, 20);
Console.WriteLine($"The Volume of parallelepiped = {piped.Volume}, the Surface of parallelepiped = {piped.Surface}");
Console.Read();
```
#Outputs
- Ellipsoid Volume = 43960 
- Ellipsoid Surface = 10800.47
- Parallelepiped Volume = 4000
- Parallelepiped Surface = 1600


#Keywords
C# 6.0, .Net Framework 4.6, Microsoft Visual Studio.
