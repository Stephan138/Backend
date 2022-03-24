using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            float first ;
            float second ;
            char operation ;

            Console.WriteLine();
            Console.WriteLine("Действия над числами:");
            Console.WriteLine(" + : сложение чисел");
            Console.WriteLine(" - : вычетание чисел");
            Console.WriteLine(" * : умножение чисел");
            Console.WriteLine(" / : деление чисел");
            Console.WriteLine();

            while (!flag)
            {
                flag = true;
                

                Console.Write("Введите первое число: ");
             first:
                try
                {
                    first = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Первое значение не число\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите первое число: ");
                    goto first;
                }

                Console.Write("Укажите операцию: ");
                operation = char.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
             second:
                try
                {
                    second = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Второе значение не число\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите второе число: ");
                    goto second;
                }

            
                switch (operation)
                {
                    case '+': Console.WriteLine("Сумма чисел составляет: " + (first + second)); break;
                    case '-': Console.WriteLine("Разность чисел состовляет: " + (first - second)); break;
                    case '*': Console.WriteLine("Произведение чисел составляет: " + (first * second)); break;
                    case '/': Console.WriteLine("Отношение чисел составляет: " + (first / second)); break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\aВНИМАТЕЛЬНО ЧИТАЙТЕ ИНСТРУКЦИЮ!!!");
                        }
                    break;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Нажмите n для продолжения: ");
                string str = Console.ReadLine();
                if (str == "n")
                {
                    flag = false;
                }
                Console.WriteLine();
            }

        }
    }
}