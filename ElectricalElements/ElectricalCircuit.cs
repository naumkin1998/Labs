using System;

namespace ElectricalElements
{
    public class ElectricalCircuit
    {
        /// <summary>
        /// Массив элементов
        /// </summary>
        private ElementBase[] _rlcArray = new ElementBase[0];

        public int Lenght => _rlcArray.Length;

        public void Add(ElementBase element)
        {
            Array.Resize<ElementBase>(ref _rlcArray, Lenght + 1);
            _rlcArray[Lenght] = element;
        }

        public ElementBase SearchByIndex(int index)
        {
            return _rlcArray[index]; 
        }
    }
}
