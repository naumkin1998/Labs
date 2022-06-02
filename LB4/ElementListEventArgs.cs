using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalElements;

namespace LB4 
{
    /// <summary>
    /// Класс ElementList
    /// </summary>
    class ElementListEventArgs : EventArgs
    {
         /// <summary>
         /// Добавление элемента
         /// </summary>
        public ElementBase Element { get; }

        /// <summary>
        /// Конструктор ElementListEventArgs
        /// </summary>
        /// <param name="element"></param>
        public ElementListEventArgs(ElementBase element)
        {
            Element = element;
        }
    }
}
