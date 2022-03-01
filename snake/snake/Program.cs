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
            HorizontalLine LeftLine = new HorizontalLine(0,118,0, '+');
            HorizontalLine RightLine = new HorizontalLine(0, 118, 28, '+'); 
            VerticalLine Upline = new VerticalLine(0, 28, 0, '+');
            VerticalLine Downline = new VerticalLine(0, 28, 118, '+'); 
            
            //вывожу линию
            LeftLine.Drow();
            RightLine.Drow();
            Upline.Drow(); 
            Downline.Drow(); 

            //отрисовка точек
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(118, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

        }

    }
}

