﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of persons: ");
            TMan[] persons = CreatePerson(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
        private static TMan[] CreatePerson(int size)
        {
            TMan[] persons = new TMan[size];
            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write($"Person {i + 1}\n");
                Console.Write("Enter FIO: ");
                string[]  aFio = Console.ReadLine().Split(' ');

                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.WriteLine();

                persons[i] = new TMan(aFio[0], aFio[1], aFio[2], age, address);
            }
            return persons;
        }
    }
}
