using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonClass
{
    
    /// <summary>
    /// Class Person
    /// </summary>
    public abstract class  PersonBase
    {
        /// <summary>
        /// Name of person
        /// </summary>
        private string _name;

        /// <summary>
        /// Язык написания
        /// </summary>
        private string _language = null;
        
        //TODO: RSDN +
        /// <summary>
        /// Name spelling check 
        /// </summary>
        /// <param name="enteredString"></param>
        /// <returns>True if the name or surname is spelled correctly</returns>
        private bool SpellingOfString(string enteredString)
        {
            var dictionarylanguage = new Dictionary<string, string>()
            {
                {"русский", "[а-яА-яёЁ]+"},
                {"english", "[a-zA-Z]+" }
            };

            if (enteredString == null)
            {
                return true;
            }          

            bool isTrue = false;

            foreach (var language in dictionarylanguage)
            {
                string matchSubstring = language.Value;
                isTrue = Regex.IsMatch(enteredString,
                    $@"^{matchSubstring}(-)?{matchSubstring}?$");
                if (isTrue)
                {
                    if (_language == null)
                    {
                        _language = language.Key;
                    }
                    else
                    {
                        if (_language != language.Key)
                        {
                            throw new ArgumentException("Языки имени и фамилии не совпадают");
                        } 
                    }
                    break;
                }                
            }
            return isTrue;
        }
       
        
        /// <summary>
        /// Check space in name
        /// </summary>
        /// <param name="enteredString"></param>
        /// <returns>True if space has in string</returns>
        private static bool CheckSpaceInString(string enteredString)
        {
            if (enteredString == null)
            {
                return false;
            }
            return Regex.IsMatch(enteredString, @" ");
        }

        /// <summary>
        /// Surname of person
        /// </summary>
        private string _surname;

        /// <summary>
        /// Min age of person
        /// </summary>
        protected abstract int MinAge { get; }

        /// <summary>
        /// Age of person
        /// </summary>
        private int _age;

        /// <summary>
        /// Max age of person
        /// </summary>
        protected abstract int MaxAge { get; }

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
                        (string.Format($"Введенный возвраст не верный! " +
                        $"Пожалуйста введите возвраст в диапозоне от {MinAge} до {MaxAge}"));
                }
                _age = value;
            }
        }

        //TODO: RSDN +
        /// <summary>
        /// Check the spilling of name/surname
        /// </summary>
        private void CheckTheSpilling(string value, string condition)
        {      
            if (!SpellingOfString(value) || CheckSpaceInString(value))
            {
                throw new ArgumentException
                ($"Введенное {condition} не правильно!");
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
                CheckTheSpilling(value, nameof(Name));
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
                //TODO: nameof +
                CheckTheSpilling(value, nameof(Surname));
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
        protected PersonBase(Gender gender, string name, string surname, int age)
        {
            Gender = gender;
            Name = name;
            Surname = surname;
            Age = age;
        }

        protected PersonBase(): this(Gender.Male, null, null, 0) { }

        
        /// <summary>
        /// Приведение значения перечисления в удобочитаемый формат. 
        /// </summary>
        /// <param name="enumElement"></param>
        /// <returns>Название элемента на русском языке</returns>
        protected static string GetDescription(Enum enumElement)
        {
            Type type = enumElement.GetType();

            //TODO: RSDN +
            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                //TODO: RSDN
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return enumElement.ToString();
        }

        /// <summary>
        /// Info about person
        /// </summary>
        /// <returns></returns>
        public abstract string Info();
     
    }
}
