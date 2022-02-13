using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonClass
{
    /// <summary>
    /// Class Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Name of person
        /// </summary>
        private string _name;

        /// <summary>
        /// Name spelling check 
        /// </summary>
        /// <param name="EnteredString"></param>
        /// <returns>True if the name or surname is spelled correctly</returns>
        public bool SpellingOfString(string EnteredString)
        {
            var isTrue = Regex.IsMatch(EnteredString,
                @"/^[a-zA-Zа-яА-ЯёЁ'][a-zA-Z-а-яА-ЯёЁ' ]+[a-zA-Zа-яА-ЯёЁ']?$/");

            return isTrue;
        }

        /// <summary>
        /// Check space in name
        /// </summary>
        /// <param name="EnteredName"></param>
        /// <returns>True if space has in string</returns>
        public bool CheckSpaceInString(string EnteredString)
        {
            return Regex.IsMatch(EnteredString, @" ");
        }

        /// <summary>
        /// Surname of person
        /// </summary>
        private string _surname;

        /// <summary>
        /// Min age of person
        /// </summary>
        public const int minAge = 0;

        /// <summary>
        /// Age of person
        /// </summary>
        private int _age;

        /// <summary>
        /// Max age of person
        /// </summary>
        public const int maxAge = 120;

        /// <summary>
        /// Age of person
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentException
                        (string.Format("Entered age is not correct!"));
                }
                _age = value;
            }
        }

        /// <summary>
        /// Name of person
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!SpellingOfString(value) || CheckSpaceInString(value))
                {
                    throw new ArgumentException
                       (string.Format("Entered name is not correct!"));
                }
                _name = value;
            }
        }

        /// <summary>
        /// Surname of person
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                if (!SpellingOfString(value) || CheckSpaceInString(value))
                {
                    throw new ArgumentException
                       (string.Format("Entered surname is not correct!"));
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Gender of person
        /// </summary>
        public Gender Gender { get; set; }


        /// <summary>
        /// Сonstructor of person class
        /// </summary>
        /// <param name="gender">gender of person</param>
        /// <param name="name">name of person</param>
        /// <param name="surname">surname of person</param>
        /// <param name="age">age of person</param>
        public Person(Gender gender, string name, string surname, int age)
        {
            Gender = gender;
            Name = name;
            Surname = surname;
            Age = age;
        }

        /// <summary>
        /// Create random person
        /// </summary>
        public static Person GetRandomPerson()
        {
            Random rnd = new Random();

            string[] names =
            {
                "Alex", "Igor", "Maks"
            };

            string[] surnames =
            {
                "AlexSurname", "IgorSurname", "MaksSurname"
            };

            int rndAge = rnd.Next(0, 119);

            int rndGender = rnd.Next(0, 2);

            if (rndGender == 1)
            {
                return new Person(Gender.Female,
                    names[rnd.Next(0, 3)],
                    surnames[rnd.Next(0, 3)],
                    rndAge);
            }
            else
            {
                return new Person(Gender.Male,
                    names[rnd.Next(0, 3)],
                    surnames[rnd.Next(0, 3)],
                    rndAge);
            }
        }
    }
}
