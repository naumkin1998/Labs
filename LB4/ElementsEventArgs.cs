using System;
using ElectricalElements;

namespace LB4
{
    /// <summary>
    /// Класс DiscountEventArgs
    /// </summary>
    class ElementsEventArgs
    {
        /// <summary>
        /// Добавление элемента
        /// </summary>
        public ElementBase Element { get; }

        /// <summary>
        /// Конструктор ElementsEventArgs
        /// </summary>
        /// <param name="element"></param>
        public ElementsEventArgs(ElementBase element)
        {
            Element = element;
        }
    }
}
