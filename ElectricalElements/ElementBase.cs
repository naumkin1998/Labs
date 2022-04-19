using System;
using System.Numerics;

namespace ElectricalElements
{

    public abstract class ElementBase
    {
        /// <summary>
        /// Величина активного сопротивления
        /// </summary>
        private double _activeResistance;

        /// <summary>
        /// Величина активного сопротивления
        /// </summary>
        public double ActiveResistance { get; set; }
        

        /// <summary>
        /// Величина реактивного сопротивления
        /// </summary>
        public double ReactiveInductance { get; set; }

        /// <summary>
        /// Базовый конструктор сопротивления
        /// </summary>
        /// <param name="complex">Коплексное сопротивление</param>
        protected ElementBase(Complex complex)
        {
            ActiveResistance = complex.Real;
            ReactiveInductance = complex.Imaginary;
        }

        /// <summary>
        /// Информация о сопротивление 
        /// </summary>
        /// <returns></returns>
        public abstract string Info();
    }
}
