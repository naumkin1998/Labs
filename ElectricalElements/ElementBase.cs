using System;
using System.Numerics;

namespace ElectricalElements
{
    //TODO: ElementBase
    //TODO: Complex
    public abstract class ElementBase
    {
        /// <summary>
        /// Величина активного сопротивления
        /// </summary>
        private double _activeResistance;

        /// <summary>
        /// Величина активного сопротивления
        /// </summary>
        public double ActiveResistance
        {
            get => _activeResistance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Активное сопротивление элемента " +
                                                "не может быть отрицательным!");
                }

                _activeResistance = value;
            }
        }

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
