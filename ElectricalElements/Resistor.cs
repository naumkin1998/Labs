using System;
using System.Numerics;

namespace ElectricalElements
{
    /// <summary>
    /// Класс резистор
    /// </summary>
    public class Resistor : ElementBase
    {
        /// <summary>
        /// Сопротивление резистора
        /// </summary>
        private double _resistance;

        /// <summary>
        /// Сопротивление резистора
        /// </summary>
        public double Resistance
        {
            get => _resistance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Активное сопротивление элемента " +
                                                "не может быть отрицательным!");
                }

                _resistance = value;
            }
        }
        
        /// <summary>
        /// Тип резистора
        /// </summary>
        public TypeOfResistor TypeOfResistor { get; set; }

        /// <summary>
        /// Конструктор резистора
        /// </summary>
        /// <param name="complex">комплексная величина сопротивления</param>
        /// <param name="operatingVoltage">Рабочее напряжение</param>
        /// <param name="powerDissipation">Мощность рассивания</param>
        /// <param name="typeOfResistor">Тип резистора</param>
        public Resistor(double resistance , TypeOfResistor typeOfResistor, Complex complex)
        : base(complex)
        {
            Resistance = resistance;
            TypeOfResistor = typeOfResistor;
        }
        
        /// <summary>
        /// Инфо об элемента
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"Сопротивление резистора:{this.Resistance} " +
                   $"\nТип: {this.TypeOfResistor} " +
                   $"\nКомплексное сопротивление элемента: {this.ActiveResistance} + j{this.ReactiveInductance}";
        }
    }
}
