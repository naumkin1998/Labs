using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    /// <summary>
    /// Class adult
    /// </summary>
    class Adult : PersonBase
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
                    throw new ArgumentException("Данный человек холост");
                }
            }
        }

        /// <summary>
        /// Название места работы
        /// </summary>
        public string NameOfWork
        {
            get => _nameOfWork;
            set => _nameOfWork = value;
        }

        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
