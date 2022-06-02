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
        /// Конструктор резистора
        /// </summary>
        /// <param name="resistance">Сопротивлене резистора</param>
        /// <param name="typeOfResistor">Тип резистора</param>
        public Resistor(double resistance)
        {
            Resistance = resistance;            
        }

        /// <summary>
        /// Расчет имеданса
        /// </summary>
        public override Complex Impedance => new Complex(Resistance, 0);
        
        /// <summary>
        /// Инфо об элемента
        /// </summary>s
        /// <returns></returns>
        public override string Info()
        {
            return $"Сопротивление резистора:{this.Resistance} " +                   
                   $"\nКомплексное сопротивление элемента: {Impedance.Real} {Impedance.Imaginary.ToString("+#.#;-0.000000000000; 0")}i";
        }

    }
}
