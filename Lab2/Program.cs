using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        enum Bank
        {
            Зарплатный,
            Сберегательный
        }
        struct BankСlient
        {
            public int num;
            public Bank type;
            public double balance;
            public void Print()
            {
                Console.WriteLine($"Счёт типа:{type}, под номером: {num} содержит {balance} рублей. Взломать?");
            }
        }
        enum VUZ
        {
            КФУ,
            КАИ,
            КХТИ
        }
        struct Worker
        {
            public string name;
            public VUZ vuz;
            public void Print()
            {
                Console.WriteLine($"{name} работает в {vuz}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1\nВыводит тип банковского аккаунта\n");

            Bank account = Bank.Зарплатный;

            Console.WriteLine($"Тип счёта: {account}\n");

            Console.WriteLine("Упражнение 3.2\nВыводит метод Print, который выводит данные структуры");

            BankСlient client = new BankСlient();
            client.type = Bank.Сберегательный;
            client.num = 1337;
            client.balance = 12345;

            client.Print();

            Console.WriteLine("Домашнее задание 3.1\nСовмещение двух прошлых заданий");

            Worker worker = new Worker();
            worker.name = "Шаукат";
            VUZ vuz = VUZ.КФУ;
            worker.vuz = vuz;

            worker.Print();

            Console.ReadKey();
        }
    }
}
