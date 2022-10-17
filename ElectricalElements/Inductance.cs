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
        public InductiveСoil(double inductance, int frequency, string typeOfElements) : base(typeOfElements)
        {
            Inductance = inductance;
            Frequency = frequency;
            TypeOfElements = typeOfElements;
        }

        /// <summary>
        /// Calculated Impedance Inductive
        /// </summary>
        /// <returns></returns>
        public override Complex CalculatedImpedance()
        { 
           return new Complex(0, (Frequency * Inductance)); 
        }


        /// <summary>
        /// XML
        /// </summary>
        public InductiveСoil() { }

        /* /// <summary>
         /// Тип элемента
         /// </summary>
         public override string TypeOfElements => "Катушка индуктивности";

         /// <summary>
         /// Расчет имеданса
         /// </summary>
         public override Complex Impedance => new Complex(0, Inductance* Frequency);

         /// <summary>
         /// Инфо об элементе
         /// </summary>
         /// <returns></returns>*/
        public override string Info()
        {
            return $"\nИндуктивность катушки : {this.Inductance}" +
                   $"\nЧастота электрического тока : {this.Frequency}" +
                   $"\nКомплексное сопротивление элемента: {Impedance.Real} {Impedance.Imaginary.ToString("+#.#;-0.000000000000; 0")}i";
        }
    }
}






