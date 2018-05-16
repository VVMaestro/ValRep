using System;
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

            Console.SetBufferSize(120, 30);      

            //Отрисовка рамки
            HorizontalLines upLine = new HorizontalLines(0, 118, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, 118, 29, '+');
            VerticalLines leftLine = new VerticalLines(0, 0, 29, '+');
            VerticalLines rightLine = new VerticalLines(118, 0, 29, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();         
        }

    }
}
