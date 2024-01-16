using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            string s = Console.ReadLine();
            bool result =int.TryParse(s, out int number);
            if (result)
            {
                if (number == 1)
                {
                    Point pointOne = new Point();
                    Console.WriteLine(pointOne._y);
                    Console.WriteLine();
                    pointOne.PrintPoint();
                    Console.WriteLine();
                    pointOne.PrintX();
                }
                if (number == 2)
                {
                    GetSet getSetX = new GetSet();
                    getSetX.SetX(1);
                    int x = getSetX.GetX();   
                    
                    GetSet getSetY = new GetSet();
                    getSetY.Y = 10;
                    int y = getSetY.Y;

                    GetSet getSetZ=new GetSet();
                    getSetZ.SetX(2);
                    int z = getSetZ.GetX();

                    Console.WriteLine($"Координаты точки равны: ({x},{y},{z})");
                }
            }
            else
            {
                Console.WriteLine("Номер задачи введен не был!");
            }
            Console.ReadLine();
        }
    }    
}
