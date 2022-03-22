using System;

namespace PersonClass
{
    //TODO: RSDN +
    /// <summary>
    /// Class adult
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Номер паспорта 
        /// </summary>
        private int _id;

        /// <summary>
        /// Семейное положение
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }
        
        /// <summary>
        /// Социальный статус
        /// </summary>
        public SocialStatus SocialStatus { get; set; }

        /// <summary>
        /// Супруга
        /// </summary>
        private string _spouse;

        /// <summary>
        /// Название места работы
        /// </summary>
        private string _nameOfWork;

        /// <summary>
        /// Номер паспорта 
        /// </summary>
        public int Id 
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// Минимальный возраст взрослого человека
        /// </summary>
        private const int _minAge = 16;

        /// <summary>
        /// Максимальный возраст взрослого человека
        /// </summary>
        private const int _maxAge = 120;

        /// <inheritdoc>
        protected override int MinAge => _minAge;

        /// <inheritdoc>
        protected override int MaxAge => _maxAge;


        /// <summary>
        /// Супруг/супруга
        /// </summary>
        public string Spouse
        {
            get => _spouse;
            set
            {
                if (MaritalStatus == MaritalStatus.Family) 
                {
                    _spouse = value;
                }
                else
                {
                    _spouse = null;
                }
            }
        }

        /// <summary>
        /// Название места работы
        /// </summary>
        public string NameOfWork
        {
            get => _nameOfWork;
            set
            {
                if (value != string.Empty && value != null)
                {
                    _nameOfWork = value;
                }
                else
                {
                    throw new ArgumentException("Название местра работы не ");
                }
            }
        }

        /// <summary>
        /// Конструктор взрослого человека
        /// </summary>
        /// <param name="id">Номер паспорта</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        /// <param name="nameofwork">Наименование работы</param>
        /// <param name="maritalstatus">Статус семейного положения</param>
        /// <param name="spouse">Супруг/супруга</param>
        public Adult (int id, string name, string surname, int age, 
            Gender gender, SocialStatus socialstatus, string nameofwork, MaritalStatus maritalstatus, string spouse)
            : base(gender, name, surname, age)
        {
            Id = id;
            SocialStatus = socialstatus;
            NameOfWork = nameofwork;
            MaritalStatus = maritalstatus;
            Spouse = spouse;
        }

        /// <inheritdoc>
        public override string Info()
        {
            string nameSpouse = null;
            if (MaritalStatus == MaritalStatus.Family)
            {
                if (Gender == Gender.Male)
                {
                    nameSpouse = $"\nСупруга: {Spouse}";
                }
                if (Gender == Gender.Female)
                {
                    nameSpouse = $"\nСупруг: {Spouse}";
                }
            }
            
            if (MaritalStatus == MaritalStatus.Single)
            {
                nameSpouse = null;
            }

          
            return $"Номер паспорта: {Id} " +
                $"\n{Surname} {Name} {Age} лет {GetDescription(Gender)} пол" +
                $"\nСемейное положение: {GetDescription(MaritalStatus)}" +
                $"{nameSpouse}" + 
                $"\nСоциальный статус: {GetDescription(SocialStatus)} " +
                $"\nНазвание места работы: {NameOfWork}";

        }

        /// <summary>
        /// Создание взрослого человека с рандомными параметрами
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>взрослый человек с рандомными параметрами</returns>
        public static Adult GetRandomAdult(Random rnd)
        {

            string[] namesMale =
            {
                "Алексей", "Святослав", "Михаил",
                "Александр", "Фёдор", "Мирон",
                "Евгений", "Даниил", "Иван"
            };

            string[] namesFemale =
            {
                "Дарина", "Анна", "Мия",
                "Варвара", "Мария", "Алиса",
                "Елизавета", "Диана", "Виктория"
            };

            string[] surnamesMale =
           {
                "Шевцов", "Медведев", "Черняев",
                "Королёв", "Гурьев", "Потапов",
                "Уваров", "Родионов", "Иванов"
            };

            string[] surnamesFemale =
           {
                "Ерема", "Михеева", "Смешко",
                "Устинова", "Ширяева", "Шарова",
                "Лебедева", "Кудряшова", "Котова"
            };

            string[] nameWorks =
            {
                "СИБУР", "ПАО «Газпром нефть»", "Госкорпорация Росатом",
                "МТС", "Норильский никель", "ВТБ24",
                "АО «Райффайзенбанк»", "Bayer", "МегаФон", "Tele2"
            };

            int rndAge = rnd.Next(_minAge, _maxAge - 1);

            int rndGender = rnd.Next(0, 2);
            var gender = rndGender == 1
                ? Gender.Male
                : Gender.Female;


            string name = null;
            string surname = null;
            if (gender == Gender.Male)
            {
                 name = namesMale[rnd.Next(0, namesMale.Length)];
                 surname = surnamesMale[rnd.Next(0, surnamesMale.Length)];
            }
            if (gender == Gender.Female)
            {
                 name = namesFemale[rnd.Next(0, namesFemale.Length)];
                 surname = surnamesFemale[rnd.Next(0, surnamesFemale.Length)];
            }


            
            int rndMaritalStatus = rnd.Next(0, 2);
            var status = rndMaritalStatus == 1
                ? MaritalStatus.Family
                : MaritalStatus.Single;
            string Spouse = null;
            if (status == MaritalStatus.Family && gender == Gender.Male)
            {
                Spouse = $"{namesFemale[rnd.Next(0, namesFemale.Length)]} " +
                    $"{surnamesFemale[rnd.Next(0, surnamesFemale.Length)]}";
            }
            if (status == MaritalStatus.Family && gender == Gender.Female)
            {
                Spouse = $"{namesMale[rnd.Next(0, namesMale.Length)]} " +
                    $" {surnamesMale[rnd.Next(0, surnamesMale.Length)]}";
            }
            if (status == MaritalStatus.Single)
            {
                Spouse = string.Empty;
            }



            int rndCosialStatud = rnd.Next(0, 2);
            var cosialstatus = rndCosialStatud == 1
                ? SocialStatus.Unemployed
                : SocialStatus.Working;

            string nameofwork = null;
                        
            if (cosialstatus == SocialStatus.Working)
            {
                nameofwork = nameWorks[rnd.Next(0, nameWorks.Length)];
            }
            else
            {
                nameofwork = "ТУНЕЯДЕЦ!!!";
            }

            return new Adult
                (
                id: rnd.Next(10000000, 100000000),
                name: name,
                surname: surname,
                age: rndAge,
                gender: gender,
                socialstatus: cosialstatus,
                nameofwork: nameofwork,
                maritalstatus: status,
                spouse: Spouse
                ); 
        }
    }
}
