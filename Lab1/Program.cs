using System;
using System.Collections.Generic;
using PersonClass;

namespace Lab1
{
    /// <summary>
    /// Class program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main task verification code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine();
            
            PersonList personlist1 = new PersonList();
            
            personlist1.Add(Person.GetRandomPerson(rnd));
            personlist1.Add(Person.GetRandomPerson(rnd));
            personlist1.Add(Person.GetRandomPerson(rnd));
            ShowPersonList(personlist1, 1);
            Console.ReadLine();

            PersonList personlist2 = new PersonList();
            Person person21 = new Person(Gender.Male, 
                "Ivan", "Ivanov", 23);
            Person person22 = new Person(Gender.Female, 
                "Fariza", "Cmeshko", 22);
            personlist2.Add(new Person(Gender.Female,
                "Tani", "Chernova", 24));
            personlist2.Add(person21);
            personlist2.Add(person22);
            ShowPersonList(personlist2, 2);
            Console.ReadLine();
            
            Person newperson = Person.GetRandomPerson(rnd);
            Console.WriteLine($"Добавление нового человека " +
                $"в первый список: {newperson.Info()}");
            personlist1.Add(person: newperson);
            ShowPersonList(personlist1, 1);
            Console.ReadLine();

            Console.WriteLine($"Копируем второго человека из 2ого списка " +
                $"в первый список: {personlist2.SearchByIndex(1).Info()}");
            personlist1.Add(personlist2.SearchByIndex(1));
            ShowPersonList(personlist1, 1);
            ShowPersonList(personlist2, 2);
            Console.ReadLine();

            Console.WriteLine("Удаляем 2ого человека из 1ого списка");
            personlist1.DeleteLast();
            ShowPersonList(personlist1, 1);
            ShowPersonList(personlist2, 2);
            Console.ReadLine();

            Console.WriteLine("Очистка 2ого списка");
            personlist2.Clear();
            ShowPersonList(personlist1, 1);
            ShowPersonList(personlist2, 2);
            Console.ReadLine();

            Console.ReadLine();
            Console.ReadLine();
        }
        
        /// <summary>
        /// Show person in list
        /// </summary>
        /// <param name="personList"></param>
        /// <param name="number"></param>
        private static void ShowPersonList(PersonList personList, int number)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Список {number}");

            if (personList.CountElements() != 0)
            {
                for (var i = 0; i < personList.Length; i++)
                {
                    Console.WriteLine(personList.SearchByIndex(i).Info());
                }
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }

            Console.WriteLine("-------------------------------");
        }

    }
}
