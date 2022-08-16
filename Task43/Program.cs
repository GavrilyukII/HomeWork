//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//k1 * x + b1 = k2 * x + b2
//(k1 - k2) * x = b2 - b1
//x = (b2 - b1) / (k1 - k2)
//y = k1 * x + b1

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoeff()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.WriteLine($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.WriteLine($"Введите коэффициент k: ");
      else Console.WriteLine($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Сalculations(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void PrintResult(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Сalculations(coeff);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoeff();
PrintResult(coeff);