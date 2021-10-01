using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of persons: ");
            TMan[] persons = CreatePerson(int.Parse(Console.ReadLine()));

            Console.WriteLine("Array: ");
            foreach (var person in persons)
                Console.WriteLine(person.GetData());

            Console.WriteLine();

            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Array of voters with the specified surname: ");
            foreach (var person in persons)
            {
                if (person.CompareSurname(surname) && person.IsVoter)
                {
                    Console.WriteLine(person.GetData());
                }
            }
            Console.ReadKey();
        }
        private static TMan[] CreatePerson(int size)
        {
            TMan[] persons = new TMan[size];
            string[] aFio;
            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write($"Person {i + 1}\n");
                while(true)
                {
                    Console.Write("Enter FIO: ");
                    aFio = Console.ReadLine().Split(' ');

                    if (aFio.Length < 3 || aFio.Length > 3)
                    {
                        Console.WriteLine("Введите ФИО из 3 значений.");
                    }
                    else
                        break;
                }
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
