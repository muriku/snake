// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args )
        {
            //Console.SetBufferSize(80, 25);
            //отрисовка рамки
            HorizontalLine Upline = new HorizontalLine(0,118,0, '+'); //создание линии
            HorizontalLine Downline = new HorizontalLine(0, 118, 28, '+'); //создание линии
            Upline.Drow(); //вывожу линию
            Downline.Drow(); //вывожу линию

            VerticalLine LeftLine = new VerticalLine(0, 28, 0, '+'); //создание линии
            VerticalLine RightLine = new VerticalLine(0, 28, 118, '+'); //создание линии
            LeftLine.Drow(); //вывожу линию
            RightLine.Drow(); //вывожу линию

            //отрисовка точек
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }

    }
}

