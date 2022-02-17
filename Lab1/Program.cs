using System;
using PersonClass;

namespace Lab1
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine();
            PersonList personlist = new PersonList();
            Person person = Person.GetRandomPerson(rnd);
            Person person1 = Person.GetRandomPerson(rnd);
            Person person2 = Person.GetRandomPerson(rnd);

            personlist.Add(person);
            personlist.Add(person1);
            personlist.Add(person2);

            for (int i = 0; i < personlist.Length; i++)
            {
                Console.WriteLine(personlist.SearchByIndex(i).Info());
            }
                
            Console.ReadLine();
        }

    }
}
