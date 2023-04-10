// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
bool isParsed1 = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("Введите значение k1: ");
bool isParsed2 = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("Введите значение b2: ");
bool isParsed3 = double.TryParse(Console.ReadLine(), out double b2);
Console.Write("Введите значение k2: ");
bool isParsed4 = double.TryParse(Console.ReadLine(), out double k2);

if (!isParsed1 || !isParsed2 || !isParsed3 || !isParsed4)
{
   Console.Write("На одной из позиций введено не число");
   return;
}

double[] lineData1 = new double[2] { k1, b1 };
double[] lineData2 = new double[2] { k2, b2 };

if (lineData1[0] == lineData2[0])
{
   if (lineData1[1] == lineData2[1])
   {
      Console.Write("Прямые совпадают");
      return;
   }
   else
   {
      Console.Write("Прямые параллельны");
      return;
   }
}

double[] SearchCoor(double[] line1, double[] line2)
{
   double[] coor = new double[2];
   coor[0] = (line1[1] - line2[1]) / (line2[0] - line1[0]);
   coor[1] = line1[0] * coor[0] + line1[1];
   return coor;
}


void PrintArray(double[] array)
{
   Console.Write($"Координаты точки пересечения {string.Join(", ", array)}");
}

PrintArray(SearchCoor(lineData1, lineData2));

