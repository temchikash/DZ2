using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 2.1.\nВведите ваше имя:");

            string name = Console.ReadLine();
            Console.WriteLine($"\nЗдравствуй {name}\nУпражнение 2.2\nВведите первое число:");
            int a = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32( Console.ReadLine() );
            if(b == 0)
            {
                Console.WriteLine("Введите другое число,на ноль делить нельзя");
                b = Convert.ToInt32(Console.ReadLine());
                while(b == 0) 
                {
                    Console.WriteLine("Введите число не равное нулю");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                double rez = a / b;
                Console.WriteLine("Результат: {0}", rez) ;
            }
            else
            {
                double rez = a / b;
                Console.WriteLine("Результат: {0}" , rez);
            }
            Console.WriteLine("Домашнее задание 2.1\nВведите любую английскую маленькую букву");
            char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char letter = char.Parse(Console.ReadLine().ToLower());
            int index = Array.IndexOf(alphabet, letter) + 1;
            if (index == alphabet.Length)
            {
                index = 0;
            }
            Console.WriteLine("Вы ввели букву {0}. Следующая за ней буква {1}", letter, alphabet[index]);

            Console.WriteLine("Домашнее задание 2.2\n");
            Console.WriteLine("Введите первый коэфицент:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй коэфицент:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третий коэфицент:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double D = Math.Pow(num2, 2) - (4 * num1 * num3);
            if (D == 0)
            {
                double xx = (num2 * (-1)) / (2 * num1);
                Console.WriteLine("Имеется один корень, равен {0}", xx);
            }
            else if (D > 0)
            {
                double x1 = (num2 * (-1) + Math.Sqrt(D)) / (2 * num1);
                double x2 = (num2 * (-1) - Math.Sqrt(D)) / (2 * num1);
                Console.WriteLine("Имеется два корня, первый равен {0}, второй равен {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }


            Console.ReadKey();
        }
        /*Написать программу, которая решает квадратное уравнение.
Входные данные – коэффициенты уравнения, выходные – найденные корни*/
        
    }
}