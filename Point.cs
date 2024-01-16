﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Point
    {
        private int _x;
        public int _y;


        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void PrintX()
        {
            Console.WriteLine("X: " + _x);
        }
        private void PrintY()
        {
            Console.WriteLine($"Y: {_y}");
        }
        public void PrintPoint()
        {
            Console.WriteLine("X: " + _x);
            PrintY();
        }
        public Point()
        {
            _x = _y = 1;
        }
    }
}