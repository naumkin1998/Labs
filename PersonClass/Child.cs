using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    /// <summary>
    /// Class child
    /// </summary>
    class Child : PersonBase
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

        /// <summary>
        /// Минимальный возраст ребенка
        /// </summary>
        private const int _minAge = 0;

        /// <summary>
        /// Максимальный возраст ребенка
        /// </summary>
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
            set => _nameOfSchool = value;
        }

        /// <inheritdoc>
        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
