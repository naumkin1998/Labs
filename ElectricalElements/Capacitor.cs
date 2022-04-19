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
        /// Тип конденсатора
        /// </summary>
        public TypeOfCapacity TypeOfCapacity { get; set; }

        /// <summary>
        /// Конструктор конденсатора
        /// </summary>
        /// <param name="capacitance">Емкость</param>
        /// <param name="frequency">Частота</param>
        /// <param name="typeOfCapacity">Тип</param>
        /// <param name="complex">Комплексное сопротивление</param>
        public Capacitor(double capacitance, int frequency, TypeOfCapacity typeOfCapacity, Complex complex)
            : base(complex)
        {
            Capacitance = capacitance;
            Frequency = frequency;
            TypeOfCapacity = typeOfCapacity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"Емкость конденсатора : {this.Capacitance}" +
                   $"\nЧастота электрического тока : {this.Frequency}" +
                   $"\nТип конденсатора : {this.TypeOfCapacity}" +
                   $"\nКомплексное сопротивление элемента: {this.ActiveResistance} + j{this.ReactiveInductance}";
        }
    }
}
