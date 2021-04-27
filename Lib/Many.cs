using System;
namespace Lib
{
    public class ManySquare //Площадь многоугольника 
    {
        public int[] Coordin = new int[] {1, 2};
        public static int[,] Input()
        {
            Console.Write("Введите количество вершин: ");
            int n = int.Parse(Console.ReadLine());
            var coord = new int[2, n];
            Console.WriteLine("Введите кординаты вершины через пробел");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите координаты вершины {0}: ", i + 1);
                var input = Console.ReadLine().Split(' ');
                coord[0, i] = int.Parse(input[0]);
                coord[1, i] = int.Parse(input[1]);
            }
            return coord;
        }
 
        public static double Area(int[,] coord)
        {
            int sum1 = 0;
            int sum2 = 0;
 
            for (int i = 0; i < coord.GetLength(1) - 1; i++)
            {
                sum1 += coord[0, i] * coord[1, i + 1];
                sum2 += coord[1, i] * coord[0, i + 1];
            }
            
 
            return Math.Abs((sum1 - sum2) / 2d);
        }

       
          

    }
}