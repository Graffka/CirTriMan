using System;
namespace Lib
{
    public class CircleSquare // Площадь круга
    {
        
        
        public double radius;
        private double Area => Math.PI*Math.Pow(radius, 2);
    

        public string MessCr()
        {
            if (radius>0)
            {
                Console.WriteLine("Площадь круга равна:");
                return Area.ToString();
            }
            else
            {
                return "Радиус меньше '0' или меньше, используйте положительные числа больше '0' ";
            }
        }
    }
}