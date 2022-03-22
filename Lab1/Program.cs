using System;
using System.Collections.Generic;
using System.Text;
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
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Random rnd = new Random();

            PersonList personlist1 = new PersonList();


            for (int i = 0; i < 7; i++)
            {
                int rndPerson = rnd.Next(1, 3);
                if (rndPerson == 1)
                {
                    personlist1.Add(Adult.GetRandomAdult(rnd));
                    //personlist1.Add(Child.GetRandomChild(rnd));                   
                }
                if (rndPerson == 2)
                {
                    personlist1.Add(Adult.GetRandomAdult(rnd));                    
                }
            }

            ShowPersonList(personlist1, 1);
            
            Console.ReadLine();

/*            PersonBase person21 = new PersonBase(Gender.Male, 
                "Ivan", "Ivanov", 23);*/




            Console.ReadLine();
        }
        
        /// <summary>
        /// Show person in list
        /// </summary>
        /// <param name="personList">список персон</param>
        /// <param name="number">нумерация списка</param>
        private static void ShowPersonList(PersonList personList, int number)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Список {number}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();


            if (personList.CountElements != 0)
            {
                for (var i = 0; i < personList.Length; i++)
                {
                    Console.WriteLine(personList.SearchByIndex(i).Info());
                    Console.WriteLine();
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