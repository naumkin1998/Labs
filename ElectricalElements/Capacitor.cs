using System;
using System.Numerics;

namespace ElectricalElements
{
    /// <summary>
    /// Класс конденсаторов
    /// </summary>
    public class Capacitor : ElementBase
    {
        /// <summary>
        /// Частота электрического тока
        /// </summary>
        private int _frequency;

        /// <summary>
        /// Емкость конденсатора
        /// </summary>
        private double _capacitance;

        /// <summary>
        /// Частота электрического тока
        /// </summary>
        public int Frequency
        {
            get => _frequency;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Частота электрического тока " +
                                                "не может быть отрицательной!");
                }
                _frequency = value;
            }
        }

        /// <summary>
        /// Емкость конденсатора
        /// </summary>
        public double Capacitance
        {
            get => _capacitance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Емкость конденсатора " +
                                                "не может быть отрицательной!");
                }
                _capacitance = value;
            }
        }

        /// <summary>
        /// Конструктор конденсатора
        /// </summary>
        /// <param name="capacitance">Емкость</param>
        /// <param name="frequency">Частота</param>        
        public Capacitor(double capacitance, int frequency)
        {
            Capacitance = capacitance;
            Frequency = frequency;            
        }

        /// <summary>
        /// Расчет имеданса
        /// </summary>
        public override Complex Impedance => 1 / new Complex(0,  (Capacitance * Frequency));

        /// <summary>
        /// Показать информацию по элементу
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"Емкость конденсатора : {this.Capacitance}" +
                   $"\nЧастота электрического тока : {this.Frequency}" +                   
                   $"\nКомплексное сопротивление элемента: {Impedance.Real} {Impedance.Imaginary.ToString("+#.#;-0.000000000000; 0")}i";
        }

    }
}
