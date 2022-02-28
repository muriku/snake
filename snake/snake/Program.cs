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
            Point p1 = new Point(1, 3, '*'); //инкапсуляция (это свойство системы, позволяющее обьединить данные и методы работающие с ними в классе, и скрыть все детали от пользователя)
           
            p1.Draw();
        
            Point p2 = new Point(4, 5, '#');
         
            p2.Draw();

            Point p3 = new Point(10, 10, ':');

            p3.Draw();

            Point p4 = new Point(11, 11, ':');

            p4.Draw();

            Point p5 = new Point(12, 12, ':');

            p5.Draw();

            Point p6 = new Point(13, 13, ':');

            p6.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1); 
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);


            char sharp = '#';
            char star = '*';

            List<char> simbols = new List<char>();
            simbols.Add(star);
            simbols.Add(sharp);

            char _char = simbols[0];
            char _star = simbols[1];

            foreach(int j in simbols)
            {
                Console.WriteLine(j);
                Console.WriteLine(sharp);
                Console.WriteLine(star);
            }




            Console.ReadLine();
        }

    }
}

