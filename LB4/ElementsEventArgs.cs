using System;
using ElectricalElements;

namespace LB4
{
    //TODO: Дублируется+
    /// <summary>
    /// Класс DiscountEventArgs
    /// </summary>
    public class ElementsEventArgs
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
