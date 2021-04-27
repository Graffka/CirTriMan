using System;

using Lib;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            CircleSquare NewArea = new CircleSquare() { radius = 0 }; //ввод радиуса 
          
            Console.WriteLine(NewArea.MessCr());

            TriangleSquare NewTriangle = new TriangleSquare() {Sides1 = 5, Sides2 = 3, Sides3 = 4}; //ввод сторон
          
            Console.WriteLine(NewTriangle.MessTr());

            ManySquare NewMany = new ManySquare();
            
            int[,] coord = ManySquare.Input();
            var area = ManySquare.Area(coord);
            Console.WriteLine("Площадь многоугольника равна {0}", area);
            Console.ReadKey();






        }
    }
}