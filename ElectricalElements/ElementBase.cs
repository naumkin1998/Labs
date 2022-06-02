using System;
using System.Numerics;

namespace ElectricalElements
{

    public abstract class ElementBase
    {
        /// <summary>
        /// Импеданс
        /// </summary>
        public abstract Complex Impedance { get; }
        

        /// <summary>
        /// Информация о сопротивление 
        /// </summary>
        /// <returns></returns>
        public abstract string Info();

    }
}
