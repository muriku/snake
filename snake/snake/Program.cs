﻿// See https://aka.ms/new-console-template for more information
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

            
            Console.ReadLine();
        }

    }
}

