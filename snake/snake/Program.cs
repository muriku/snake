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
            HorizontalLine LeftLine = new HorizontalLine(0,118,0, '+'); //создание линии
            HorizontalLine RightLine = new HorizontalLine(0, 118, 28, '+'); //создание линии
            VerticalLine Upline = new VerticalLine(0, 28, 0, '+'); //создание линии
            VerticalLine Downline = new VerticalLine(0, 28, 118, '+'); //создание линии
            LeftLine.Drow(); //вывожу линию
            RightLine.Drow(); //вывожу линию
            Upline.Drow(); //вывожу линию
            Downline.Drow(); //вывожу линию

            //отрисовка точек
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if (Console.KeyAvailable) 
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);                                      
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }

    }
}

