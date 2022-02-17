using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonClass
{

    //TODO: RSDN: +
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
        static bool SpellingOfString(string EnteredString)
        {
            const string matchSubstring = @"a-zA-Zа-яА-ЯёЁ";
            var isTrue = Regex.IsMatch(EnteredString,
                $@"/^[{matchSubstring}'][{matchSubstring}' ]+[{matchSubstring}']?$/");

            return isTrue;
        }

        /// <summary>
        /// Check space in name
        /// </summary>
        /// <param name="EnteredName"></param>
        /// <returns>True if space has in string</returns>
        static bool CheckSpaceInString(string EnteredString)
        {
            return Regex.IsMatch(EnteredString, @" ");
        }

        /// <summary>
        /// Surname of person
        /// </summary>
        private string _surname;

        //TODO: RSDN: +
        /// <summary>
        /// Min age of person
        /// </summary>
        public const int MinAge = 0;

        /// <summary>
        /// Age of person
        /// </summary>
        private int _age;

        //TODO: RSDN +
        /// <summary>
        /// Max age of person
        /// </summary>
        public const int MaxAge = 120;

        /// <summary>
        /// Age of person
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException
                        (string.Format("Entered age is not correct!"));
                }
                _age = value;
            }
        }

        /// <summary>
        /// Check the spilling of name/surname
        /// </summary>
        static void CheckTheSpilling(string value, string condition)
        {
            if (condition == "Name")
            {
                if (!(SpellingOfString(value) || !CheckSpaceInString(value)))
                {
                    throw new ArgumentException
                       (string.Format("Entered name is not correct!"));
                }
            }
            if (condition == "Surname")
            {
                if (!(SpellingOfString(value) || !CheckSpaceInString(value)))
                {
                    throw new ArgumentException
                       (string.Format("Entered surname is not correct!"));
                }
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
                //TODO: дубль +
                CheckTheSpilling(value, "Name");
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
                //TODO: дубль +
                CheckTheSpilling(value, "Surname");

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
        public static Person GetRandomPerson(Random rnd)
        {
            

            string[] names =
            {
                "Alex", "Zhenya", "Valia"
            };

            string[] surnames =
            {
                "Alex-Surname", "Zhenyaalex", "Mysurname"
            };

            //TODO: +
            int rndAge = rnd.Next(MinAge, MaxAge - 1);

            int rndGender = rnd.Next(0, 2);
            var gender = rndGender == 1
                ? Gender.Male
                : Gender.Female;

            //TODO: +
            return new Person(gender,
                names[rnd.Next(0, names.Length)],
                surnames[rnd.Next(0, surnames.Length)],
                rndAge);
        }

        /// <summary>
        /// Info about person
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"{this.Gender} {this._surname} {this._name} {this._age}";
        }

    }
}
