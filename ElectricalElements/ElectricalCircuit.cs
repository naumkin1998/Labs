using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalElements
{
    public class ElectricalCircuit
    {
        /// <summary>
        /// Массив элементов
        /// </summary>
        private RLCBase[] _rlcArray = new RLCBase[0];

        public int Lenght => _rlcArray.Length;

        public void Add(RLCBase rlc)
        {
            Array.Resize<RLCBase>(ref _rlcArray, Lenght + 1);
            _rlcArray[Lenght] = rlc;
        }

        public RLCBase SearchByIndex(int index)
        {
            return _rlcArray[index]; 
        }
    }
}
