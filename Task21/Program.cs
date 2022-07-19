//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
    Console.WriteLine("Введите координаты первой точки A: ");
    Console.Write ("x: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write ("y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write ("z: ");
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки B: ");
    Console.Write ("x: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write ("y: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write ("z: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    //double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));

    //Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}), -> {Math.Round (result,2)}");
    Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}), -> {GetDistance (x1,y1,z1,x2,y2,z2)}");
    double GetDistance (int ax, int ay, int az, int bx, int by, int bz)
    {
        return Math.Round(Math.Sqrt(((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1))),2, MidpointRounding.ToZero);
    }