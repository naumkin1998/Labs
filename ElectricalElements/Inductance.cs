using System;
using System.Numerics;

/// <summary>
/// Электрические элементы
/// </summary>
namespace ElectricalElements
{
    /// <summary>
    /// Класс индуктивности
    /// </summary>
    public class InductiveСoil : ElementBase
    {
        /// <summary>
        /// Частота электрического тока
        /// </summary>
        private int _frequency;

        /// <summary>
        /// Индуктивность катушки
        /// </summary>
        private double _inductance;

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
        /// Индуктивность катушки
        /// </summary>
        public double Inductance
        {
            get => _inductance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Индуктивность катушки " +
                                                "не может быть отрицательной!");
                }
                _inductance = value;
            }
        }

        /// <summary>
        /// Конструктор индуктивности
        /// </summary>
        /// <param name="inductance">Индуктивность</param>
        /// <param name="frequency">Частота</param>
        /// <param name="complex">Комплексное сопротивление катушки индуктивности</param>
        public InductiveСoil(double inductance, int frequency, Complex complex) :base(complex)
        {
            Inductance = inductance;
            Frequency = frequency;
        }

        /// <summary>
        /// Инфо об элементе
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"\nИндуктивность катушки : {this.Inductance}" +
                   $"\nЧастота электрического тока : {this.Frequency}" +
                   $"\nКомплексное сопротивление элемента: {this.ActiveResistance} + j{this.ReactiveInductance}";
        }
    }
}






