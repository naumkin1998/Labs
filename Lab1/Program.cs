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
            Console.WriteLine();
            
            PersonList personlist1 = new PersonList();
            
            personlist1.Add(PersonBase.GetRandomPerson(rnd));
            personlist1.Add(PersonBase.GetRandomPerson(rnd));
            personlist1.Add(PersonBase.GetRandomPerson(rnd));
            ShowPersonList(personlist1, 1);
            Console.ReadLine();

            PersonList personlist2 = new PersonList();
            PersonBase person21 = new PersonBase(Gender.Male, 
                "Ivan", "Ivanov", 23);
            PersonBase person22 = new PersonBase(Gender.Female, 
                "Fariza", "Cmeshko", 22);
            personlist2.Add(new PersonBase(Gender.Female,
                "Tani", "Chernova", 24));
            personlist2.Add(person21);
            personlist2.Add(person22);
            ShowPersonList(personlist2, 2);
            Console.ReadLine();
            
            PersonBase newperson = PersonBase.GetRandomPerson(rnd);
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
            Console.Clear();

            Console.ReadLine();

            var enteredPerson = PersonReadFro();
            Console.WriteLine(enteredPerson.Info());


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

            if (personList.CountElements != 0)
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

        /// <summary>
        /// Список действий  
        /// </summary>
        /// <returns>Созданный персонаж</returns>
        public static PersonBase PersonReadFro()
        {
            PersonBase newPerson = new PersonBase(Gender.Male, null, null, 0);
            
            var actionsTupleList = new List<(Action Action, string Message)>
            {
               (
                    () =>
                    {
                        newPerson.Name = Console.ReadLine();
                    },
                    "Введите имя сотрудника:"),
               (
                    () =>
                    {
                        newPerson.Name = RegisterWords(newPerson.Name );
                    },
                    "Исправить региристр в соответствие с примером?" +
                    "\nпример - Петр" +
                    "\nВведите да или нет"),
                (
                    () =>
                    {
                        newPerson.Surname = Console.ReadLine();
                    }, 
                    "Введите фамилия сотрудника:"),
                (
                    () =>
                    {
                        newPerson.Surname = RegisterWords(newPerson.Surname );
                    },
                    "Исправить региристр в соответствие с примером?" +
                    "\nпример - Петр" +
                    "\nВведите да или нет"),
                (
                    () =>
                    {
                        string age = Console.ReadLine();
                        if(!int.TryParse(age, out var number))
                        {
                            throw new ArgumentException("Введенное значение не является числовым");
                        }
                        else
                        {
                            newPerson.Age = Convert.ToInt32(age);
                        }
                    },
                    "Введите возвраст сотрудника:"),
                (
                    ()=>
                    {
                        int gender = Convert.ToInt32(Console.ReadLine());
                        switch (gender)
                        {
                            case 1:
                                {
                                    newPerson.Gender = Gender.Male;
                                    return;
                                }
                            case 2:
                                {
                                    newPerson.Gender = Gender.Female;
                                    return;
                                }
                            default:
                            {
                                throw new ArgumentException
                                    ("Пожалуйста, выберете 1 или 2");
                            }
                        }
                    },
                    "Выберете пол сотрудника" +
                    "Если 1 - Муж, если 2 - Жен")
            };

            foreach (var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return newPerson;
        }

        /// <summary>
        ///  выполняет действие либо показывает ошибку
        /// </summary>
        /// <param name="action">действие</param>
        /// <param name="inputMessage">сообщение при возникновении ошибки</param>
        private static void ActionHandler(Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message 
                        + "\nПопробуйте заново");
                }
            }
        }

        /// <summary>
        /// Изменение регистра 
        /// </summary>
        /// <param name="enteredString"></param>
        /// <returns>Слово с не/исправленным регистром</returns>
        public static string RegisterWords(string enteredString)
        {
            if (enteredString == null)
            {
                return enteredString;
            }
            else
            {                
                string answer = Console.ReadLine().ToLower();
                if (answer == "да")
                {
                    return enteredString.Substring(0, 1).ToUpper() +
                     enteredString.Substring(1, enteredString.Length - 1).ToLower();
                }                
                if (answer == "нет")
                {
                    return enteredString;
                }
                throw new ArgumentException("Выберете да или нет!");
            }
        }
    }
}