using System;
using System.Collections.Generic;

namespace Lib
{
    public class TriangleSquare // Площадь треугольника

    {
        public double Sides1, Sides2, Sides3;

        
        private double PPerimetr => (Sides1 + Sides2 + Sides3) / 2; //Периметр треугольника
        private double Area => Math.Sqrt(PPerimetr * (PPerimetr - Sides1) * (PPerimetr - Sides2) * (PPerimetr - Sides3)); //Площадь треугольника

        private Boolean Degree() //Проверка треугольника на прямоугольность
        {
            double S1, S2, S3;
            if (Sides1>Sides2 & Sides1>Sides3)
            {
                
                S1 = Sides1;
                S2 = Sides2;
                S3 = Sides3;
                //Console.WriteLine(S1 +" "+" "+ S2 +" "+ S3+" 1");
            }
            else if (Sides2>Sides1 & Sides2>Sides3)
            {
                S1 = Sides2;
                S2 = Sides1;
                S3 = Sides3;
                //Console.WriteLine(S1 +" "+" "+ S2 +" "+ S3+" 2");
            }
            else
            {
                S1 = Sides3;
                S2 = Sides2;
                S3 = Sides1;
                //Console.WriteLine(S1 +" "+" "+ S2 +" "+ S3+" 3");
            }
            
            
            if (Math.Pow(S1, 2)==Math.Pow(S2, 2)+Math.Pow(S3, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public String MessTr()
        {
            if (Sides1>0 & Sides2>0 & Sides3>0 & double.IsNaN(0 / Area) != true )
            {
                
                if (Degree() == true)
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                //Console.WriteLine(Degree());
                Console.WriteLine("Площадь треугольника равна:");
                return Area.ToString();    
            }
            else
            {
                return "Такого треугольника не существует, используйте положительные числа больше 0 или не выполняется условие C<A+B, уменьшите или увеличьте сторону(ы)";
            }
        }
        
        
    }
}