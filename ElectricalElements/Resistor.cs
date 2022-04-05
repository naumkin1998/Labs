using System;

/// <summary>
/// Электрические элементы
/// </summary>
namespace ElectricalElements
{
    /// <summary>
    /// Класс резистор
    /// </summary>
    public class Resistor : RLCBase
    {
        /// <summary>
        /// Рабочее напряжение
        /// </summary>
        private int _operatingVoltage;


        /// <summary>
        /// Рассеиваемая мощность
        /// </summary>
        private int _powerDissipation;

        /// <summary>
        /// Тип резистора
        /// </summary>
        public TypeOfResistor TypeOfResistor { get; set; }
        
        /// <summary>
        /// Рабочее напряжение
        /// </summary>
        public int OperatingVoltage
        {
            get => _operatingVoltage;
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Рабочее напряжение резистора " +
                                                "не может быть отрицательным!");
                }

                _operatingVoltage = value;
            }
        }

        /// <summary>
        /// Рассеиваемая мощность
        /// </summary>
        public int PowerDissipation
        {
            get => _powerDissipation;
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Мощность рассеивания резистора " +
                                                "не может быть отрицательным!");
                }

                _powerDissipation = value;
            }
        }

        /// <summary>
        /// Конструктор резистора
        /// </summary>
        /// <param name="resistance">Номинальная величина сопротивления</param>
        /// <param name="operatingVoltage">Рабочее напряжение</param>
        /// <param name="powerDissipation">Мощность рассивания</param>
        /// <param name="typeOfResistor">Тип резистора</param>
        public Resistor(int resistance, int operatingVoltage, int powerDissipation, TypeOfResistor typeOfResistor)
        : base(resistance, 0, 0)
        {
            OperatingVoltage = operatingVoltage;
            PowerDissipation = powerDissipation;
            TypeOfResistor = typeOfResistor;
        }

        /// <summary>
        /// Дефолтный конструктор резистора
        /// </summary>
        public Resistor() :this (0, 0, 0, TypeOfResistor.Linear) {}

        public override string Info()
        {
            return $"Номинальное сопротивление:{this.Resistance} " +
                   $"\nРабочее напряжение: {this.OperatingVoltage} " +
                   $"\nМощность рассеивания: {this.PowerDissipation} " +
                   $"\nТип: {this.TypeOfResistor}";
        }
    }
}
