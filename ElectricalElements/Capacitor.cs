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
                if (value == double.NaN)
                {
                    throw new ArgumentException("Частота электрического тока " +
                                                "не может быть пустым значением!");
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
                if (value == double.NaN)
                {
                    throw new ArgumentException(" Емкость конденсатора " +
                                                "не может быть пустым значением!");
                }
                _capacitance = value;
            }
        }

        /// <summary>
        /// Конструктор конденсатора
        /// </summary>
        /// <param name="capacitance">Емкость</param>
        /// <param name="frequency">Частота</param>        
        public Capacitor(double capacitance, int frequency, string typeOfElements) : base(typeOfElements)
        {
            Capacitance = capacitance;
            Frequency = frequency;
            TypeOfElements = typeOfElements;
        }

        /// <summary>
        ///  Calculated Impedance Capacitor
        /// </summary>
        /// <returns></returns>
        public override Complex CalculatedImpedance()
        {
            return 1/new Complex(0, Capacitance * Frequency);
        }

        /// <summary>
        /// XML
        /// </summary>
        public Capacitor() { }

        /// <summary>
        /// Показать информацию по элементу
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"Емкость конденсатора : {this.Capacitance}" +
                   $"\nЧастота электрического тока : {this.Frequency}" +
                   $"\nКомплексное сопротивление элемента: {Impedance.Real} " +
                   $"{Impedance.Imaginary.ToString("+#.#;-0.000000000000; 0")}i";
                  
        }

    }
}
