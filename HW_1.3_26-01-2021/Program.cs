using System;

namespace HW_1._3_26_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            lll:
            Console.WriteLine("Это программа преднозначано для школьников и а также для студентов!");
            Console.WriteLine(@"Выбирите один вариант из нижеперечисленных:
                           1. Математика --> 1
                           2. Геометрия  --> 2 ");
            Console.Write("Ваш выбор: ");
            var check = int.TryParse(Console.ReadLine(), out var myNumber);
            if (check)
            {
                if(myNumber>0 && myNumber < 4)
                {
                    switch (myNumber)
                    {
                        case 1:
                            Console.WriteLine(@"Выбирите операцию:
                                    1. Таблица умножения --> 1
                                    2. Полиндром --> 2
                                    3. Проверка числы на Четность --> 3
                                    4. Простые число на интервале а и b --> 4
                                    5. Сумма N число --> 5 ");
                            Console.WriteLine("Ваш выбор: ");
                            var checkMath = int.TryParse(Console.ReadLine(), out var myNumberMath);
                            if (myNumber > 0 && myNumber < 3)
                            {
                                switch (myNumberMath)
                                {
                                    case 1:
                                        Console.WriteLine("Введите степень: ");
                                        int pow = Convert.ToInt32(Console.ReadLine());
                                        Mathematic math = new Mathematic(pow);
                                        math.getMulTab();
                                        break;
                                    case 2:
                                        Console.Write("Введите текст для проверки :");
                                        string text = Console.ReadLine();
                                        var math1 = new Mathematic(text);
                                        math1.getPolindrom();
                                        break;
                                    case 3:
                                        Console.Write("Введите число : ");
                                        int n = Int32.Parse(Console.ReadLine());
                                        var math3 = new Mathematic(n);
                                        math3.checkEven();
                                        break;
                                    case 4:
                                        int num1, num2;
                                        Console.Write("Введите первый диапозон: ");
                                        num1 = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Введите второй диапозон: ");
                                        num2 = Convert.ToInt32(Console.ReadLine());
                                        var math4 = new Mathematic(num1, num2);
                                        math4.simpleNum();
                                        break;
                                    case 5:
                                        int number;
                                        Console.Write("Введите N : ");
                                        number = Convert.ToInt32(Console.ReadLine());
                                        var math5 = new Mathematic(number);
                                        math5.sumNum();
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Вы выбрали неправылную команду!");
                                        break;
                                }
                            }
                                break;
                        case 2:
                            Geometric geometric;
                            Console.WriteLine(@"Выбирите операцию:
                                    1. Площадь прямоугольника --> 1
                                    2. Периметр прямоугольника --> 2
                                    3. Средное арифметическое --> 3");
                            Console.WriteLine("Ваш выбор: ");
                            var checkGeo = int.TryParse(Console.ReadLine(), out var myNumberGeo);
                            Console.Write($"firstSide = ");
                            double firstSide = double.Parse(Console.ReadLine());
                            Console.Write($"firstSide = ");
                            double secondSide = double.Parse(Console.ReadLine());
                            geometric = new Geometric(firstSide, secondSide);
                            if(myNumber>0 && myNumber < 3)
                            {
                                switch (myNumberGeo)
                                {
                                    case 1:
                                        Console.WriteLine($"Area: {firstSide}*{secondSide} = {geometric.solveGeoArea()}");
                                        break;
                                    case 2:
                                        Console.WriteLine($"Perimeter: {firstSide}*{secondSide}={geometric.solveGeoPerim()}");
                                        break;
                                    case 3:
                                        Console.WriteLine($"Cред. геометрическое: {geometric.getMidGeo()}");
                                        break;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Errorrr!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы вводили не число");
            }
            goto lll;
        }
    }
}
