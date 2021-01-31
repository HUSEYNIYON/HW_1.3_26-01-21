using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1._3_26_01_2021
{
    class Mathematic
    {
        public int N { get; set; }
        public string text { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public Mathematic(int n)
        {
            N = n;
        }
        public Mathematic(string text)
        {
            this.text = text;
        }
        public Mathematic(int num1, int num2, int v)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public Mathematic(int n, int num2) : this(n)
        {
            this.num2 = num2;
        }

        public void getMulTab()
        {
            Console.WriteLine("Таблица умножение");
            for (int j = 1; j <= N; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
        }
        public void getPolindrom()
        {
            int len = text.Length;
            bool flag = true;

            //Проверка полиндрома
            for (int i = 0; i < len / 2; i++)
            {
                if (text[i] != text[len - (i + 1)])
                {
                    flag = false;
                    break;
                }
            }


            if (flag)
            {
                Console.WriteLine("{0} Полиндром!", text);
            }
            else
            {
                Console.WriteLine("{0} Не полиндром!", text);
            }
            Console.ReadLine();
        }
        public void checkEven()
        {
            if (N % 2 == 0)
            {
                Console.WriteLine("{0} четный", N);
            }
            else
            {
                Console.WriteLine("{0} не четный", N);
            }
        }
        public void simpleNum()
        {
            int sayac = 0;
            Console.WriteLine("Простые число в диапозоне {0} и {1} : ", num1, num2);
            Console.WriteLine("==============================================");
            for (int i = num1; i < num2; i++)
            {
                sayac = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac = 1;
                            break;
                        }
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public void sumNum()
        {
            int sum = 0;
            if (N < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Пж. Введите положительное число!");
            }
            else
            {
                while (N > 0)
                {
                    sum += N;
                    N -= 1;
                }
            }
            Console.WriteLine("Сумма = " + sum);

        }
    }
    class Geometric
    {
        private double firstSide { get; set; }
        private double secondSide { get; set; }
        public Geometric(double FirstSide, double SecondSide)
        {
            firstSide = FirstSide;
            secondSide = SecondSide;
        }
        public double solveGeoArea()
        {
            return firstSide * secondSide;
           
        }
        public double solveGeoPerim()
        {
            return (2 * firstSide) + (2 * secondSide);
        }
        public double getMidGeo()
        {
            return Math.Sqrt(firstSide * secondSide);
        }

    }
   
}
