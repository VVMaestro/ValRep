﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
                  
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            
            p2.Draw();

            HorizontalLines line = new HorizontalLines(5, 10, 8, '+');
            line.Drow();

            VerticalLines line1 = new VerticalLines(10, 7, 14, '+');
            line1.Drow();

            Console.ReadLine();

        }

    }
}
