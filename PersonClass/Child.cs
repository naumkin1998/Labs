using System;

namespace PersonClass
{
    //TODO: RSDN
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

        /// <inheritdoc>
        protected override int MinAge => 15;

        /// <inheritdoc>
        protected override int MaxAge => 0;

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
