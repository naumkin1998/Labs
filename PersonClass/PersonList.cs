using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    /// <summary>
    /// List of person
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Array of person
        /// </summary>
        private PersonBase[] _personArray = new PersonBase[0];

        /// <summary>
        /// Length of PersonList
        /// </summary>
        public int Length => _personArray.Length;

        /// <summary>
        /// Add new person in PersonList
        /// </summary>
        /// <param name="person"></param>
        public void Add(PersonBase person)
        {
            int sizeArray = _personArray.Length;
            Array.Resize<PersonBase>(ref _personArray, sizeArray + 1);
            _personArray[sizeArray] = person;
        }

        /// <summary>
        /// Delete last person in array
        /// </summary>
        public void DeleteLast()
        {
            int sizeArray = _personArray.Length;
            Array.Resize<PersonBase>(ref _personArray, sizeArray - 1);
        }

        /// <summary>
        /// Delete person by index
        /// </summary>
        /// <param name="index">Имя которое необходимо удалить</param>
        public void DeletingByIndex(int index)
        {
            if (index < 0 || index > _personArray.Length - 1)
            {
                throw new ArgumentException
                    ("Entered index is not correct!");
            }
            Console.WriteLine(_personArray.Length);
            var newArray = 
                _personArray.SkipWhile(person => person != _personArray[index]);
            _personArray = newArray.ToArray();
            Console.WriteLine(_personArray.Length);
        }
        
        /// <summary>
        /// Search person in array by index
        /// </summary>
        /// <param name="index">Индекс имени которого необходимо найти</param>
        public PersonBase SearchByIndex(int index)
        {
            return _personArray[index];
        }
        
        /// <summary>
        /// Get index in array by person
        /// </summary>
        /// <param name="person">Имя которое необходимое для нахождения индекса</param>
        /// <returns></returns>
        public int GetIndexOfPerson(PersonBase person)
        {
            return Array.IndexOf(_personArray, person);
        }

        /// <summary>
        /// Cleaning array
        /// </summary>
        public void Clear()
        {
            Array.Resize<PersonBase>(ref _personArray, 0);
        }
        
        /// <summary>
        /// Get count elements in array
        /// </summary>
        /// <returns></returns>
        public int CountElements => _personArray.Length;
    }
}
