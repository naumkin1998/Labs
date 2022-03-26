using System;

namespace PersonClass
{
    /// <summary>
    /// Class child
    /// </summary>
     public class Child : PersonBase
    {
        /// <summary>
        /// Отец
        /// </summary>
        private string _father;

        /// <summary>
        /// Мать
        /// </summary>
        private string _mother;

        /// <summary>
        /// Наименование школы 
        /// </summary>
        private string _nameOfSchool;

        /// <inheritdoc>
        private const int _minAge = 1;

        /// <inheritdoc>
        private const int _maxAge = 15;

        /// <inheritdoc>
        protected override int MinAge => _minAge;

        /// <inheritdoc>
        protected override int MaxAge => _maxAge;

        /// <summary>
        /// Отец
        /// </summary>
        public string Father
        {
            get => _father;
            set => _father = value;            
        }

        /// <summary>
        /// Мать
        /// </summary>
        public string Mother
        {
            get => _mother;
            set => _mother = value;            
        }

        /// <summary>
        /// Наименование школы
        /// </summary>
        public string NameOfSchool
        {
            get => _nameOfSchool;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Введенное наименование школы не может быть пустым значение!");
                }

                _nameOfSchool = value;
            }
        }

        /// <summary>
        /// Конструктор ребенка
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        /// <param name="father">Отец</param>
        /// <param name="mother">Мать</param>
        /// //TODO: RSDN +
        /// <param name="nameOfSchool">Наименование школы</param>
        public Child (string name, string surname, int age,
            Gender gender, string father, string mother, string nameOfSchool)
            : base(gender, name, surname, age)
        {
            Father = father;
            Mother = mother;
            NameOfSchool = nameOfSchool;
        }

        /// <inheritdoc>
        public override string Info()
        {
            string parent = null;
            if (Father == "-" && Mother == "-")
            {
                parent = "Сирота";
            }
            if (Father == "-" && Mother != "-")
            {
                parent = $"Мать: {Mother}";
            }
            if (Mother == "-" && Father != "-")
            {
                parent = $"Отец: {Father}";
            }
            else
            {
                parent = $"Отец: {Father} Мать: {Mother}";
            }

            return $"{this.Surname}ё {this.Name} {this.Age} лет {GetDescription(this.Gender)} пол" +
                $"\n{parent}," +
                $"\nШкола {this.NameOfSchool} ";
        }

        public void IsChild()
        {
            Console.WriteLine("Это ребенок!");
        }

        /// <summary>
        /// Создание рандомного ребенка
        /// </summary>
        /// <param name="rnd">рандом</param>
        /// <returns>Ребенок с рандомными параметрами</returns>
        public static Child GetRandomChild(Random rnd)
        {
            string[] names =
            {
                "Саша", "Женя", "Валя", "Вася"
            };
            
            string[] surnames =
            {
                "Шапиро", "Живаго", "Никитенко" , "Нетто" , "Грабчак"
            };

            string[] fathers =
            {
                "Князев А. Р.", "Щербаков Д. М.", "-"
            };

            string[] mothers =
            {
                "Субботина С. Л.", "Пастухова В. Ф.", "-"
            };

            string[] shcools = 
            {
                "Пуффендуй", "Когтевран", "Иварускил", "Грифендор", "Слизерин", "Хогвартс"
            };

            int rndAge = rnd.Next(_minAge, _maxAge+1);
            int rndGender = rnd.Next(0, 2);
            var gender = rndGender == 1
                ? Gender.Male
                : Gender.Female;
            
            return new Child
                (
                name: names[rnd.Next(0, names.Length)],
                surname: surnames[rnd.Next(0, surnames.Length)],
                age: rndAge,
                gender: gender,
                father: fathers[rnd.Next(0, fathers.Length)],
                mother: mothers[rnd.Next(0, mothers.Length)],
                nameOfSchool: shcools[rnd.Next(0, shcools.Length)]
                );
        }
     }
}
