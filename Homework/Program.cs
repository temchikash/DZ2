using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
{
    enum Alc
    {
        Алкаш,
        Часто_выпивает,
        Чисто_по_праздникам,
        Трезвый
    }
    struct Person
    {
        public string name;
        public string city;
        public int age;
        public string pincod;
        public void Print()
        {
            Console.WriteLine($"{name}, живёт в {city},{age} лет от роду, его пин-код {pincod}");
        }

    }

    struct Student
    {
        public string name;
        public string surname;
        public int number;
        public Alc alc;
        public double lit;
        public void Print()
        {
            Console.WriteLine($"Студент {name} + {surname} с номером {number}, стадией алкоголизма: {alc}, выпил {lit} ");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задание 1\nbyte - максимальное значение: {byte.MaxValue} - минимальное значение: {byte.MinValue} \n" +
                              $"sbyte - максимальное значение: {sbyte.MaxValue} - минимальное значение: {sbyte.MinValue} \n" +
                              $"short - максимальное значение: {short.MaxValue} - минимальное значение: {short.MinValue} \n" +
                              $"ushort - максимальное значение: {ushort.MaxValue} - минимальное значение: {ushort.MinValue} \n" +
                              $"int - максимальное значение: {int.MaxValue} - минимальное значение: {int.MinValue} \n" +
                              $"uint - максимальное значение: {uint.MaxValue} - минимальное значение: {uint.MinValue} \n" +
                              $"long - максимальное значение: {long.MaxValue} - минимальное значение: {long.MinValue} \n" +
                              $"ulong - максимальное значение: {ulong.MaxValue} - минимальное значение: {ulong.MinValue} \n" +
                              $"float - максимальное значение: {float.MaxValue} - минимальное значение: {float.MinValue} \n" +
                              $"double - максимальное значение: {double.MaxValue} - минимальное значение: {double.MinValue} \n" +
                              $"decimal - максимальное значение: {decimal.MaxValue} - минимальное значение: {decimal.MinValue} \n" +
                              $"char - максимальное значение: нет - минимальное значение: нет \n" +
                               "bool - максимальное значение: нет - минимальное значение: нет \n" +
                               "string - максимальное значение: нет - минимальное значение: нет \n" +
                               "object - максимальное значение: нет - минимальное значение: нет");
            Console.WriteLine("Задание 2");
            Person person = new Person();
            Console.WriteLine("Введите ваше имя: ");
            person.name = Console.ReadLine();
            Console.WriteLine("Введите ваш город: ");
            person.city = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            person.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пин-код: ");
            person.pincod = Console.ReadLine();
            person.Print();

            Console.WriteLine("Задание 3 не смог");


            Console.WriteLine("Задание 4 \nВведите строку");
            string new_str;
            int num = 0;

            string str = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string mini_str = Console.ReadLine();

            new_str = str.Replace(mini_str, "1");

            for (int i = 0; i < new_str.Length; i++)
            {
                if (new_str[i] == '1')
                {
                    num += 1;
                }
            }

            Console.WriteLine($"{num} вхождений");

            Console.WriteLine("Задача 5\nВведите стоимость коньяка:");


            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько стоит коньяка в duty:");
            int duty_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какая стоимость отдыха:\n");
            int holiday = Convert.ToInt32(Console.ReadLine());
            double count = holiday / (price - duty_price);
            Console.WriteLine($"Чтобы окупить отдых нужно столько бутылок: {Math.Ceiling(count)}");

            Console.WriteLine("Задание 6\nДиалог");
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать.");
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Задание 7 не смог");
            Console.WriteLine("Задание 8 - 5 структур\n");

            Student student1 = new Student();
            student1.surname = "Вахидов";
            student1.name = "Расул";
            student1.number = 228;
            student1.alc = 0;
            student1.lit = 25;
            student1.Print();

            Student student2 = new Student();
            student2.surname = "Асхабов";
            student2.name = "Мурад";
            student2.number = 1337;
            student2.alc = 0;
            student2.lit = 18;
            student2.Print();

            Student student3 = new Student();
            student3.surname = "Мамедов";
            student3.name = "Хасбик";
            student3.number = 2015;
            student3.alc = 0;
            student3.lit = 50;
            student3.Print();

            Student student4 = new Student();
            student4.surname = "Шпак";
            student4.name = "Абдурозик";
            student4.number = 4;
            student4.alc = 0;
            student4.lit = 0;
            student4.Print();

            Student student5 = new Student();
            student5.surname = "Гопарь";
            student5.name = "Андрей";
            student5.number = 5;
            student5.alc = 0;
            student5.lit = 10;
            student5.Print();

            double lits = student1.lit + student2.lit + student3.lit + student4.lit + student5.lit;
            Console.WriteLine($"{student1.name} {student1.surname} выпил {(student1.lit / lits) * 100} процентов\n{student2.name} {student2.surname} выпил {(student2.lit / lits) * 100} процентов\n{student3.name} {student3.surname} выпил {(student3.lit / lits) * 100} процентов\n{student4.name} {student4.surname} выпил {(student4.lit / lits) * 100} процентов\n {student5.name} {student5.surname} выпил {(student5.lit / lits) * 100} процентов");

            Console.ReadKey();
        }
    }    
}