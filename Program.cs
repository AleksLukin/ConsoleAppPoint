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
            Point pointOne=new Point();
            Console.WriteLine(pointOne.y);

            Console.ReadLine();
        }
    }
    class Point
    {
        private int x = 5;
        public int y = 4;

        public void PrintX()
        {
            Console.WriteLine("X: "+ x);
        }
        private void PrintY()
        {
            Console.WriteLine("Y: "+ y);
        }
        public void PrintPoint()
        {
            Console.WriteLine("X: "+ x);
            Console.WriteLine("Y: "+ y);
        }
    }
}
