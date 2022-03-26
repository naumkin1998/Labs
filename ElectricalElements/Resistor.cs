using System;

namespace ElectricalElements
{
    /// <summary>
    /// Класс резистор
    /// </summary>
    public class Resistor
    {
        /// <summary>
        /// Номинальное значение сопротивления
        /// </summary>
        private int _nominalValue;

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
        /// Номинальное значение сопротивления
        /// </summary>
        public int NominalValue
        {
            get => _nominalValue;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сопротивление резистора " +
                                                "не может быть отрицательным!");
                }

                _nominalValue = value;
            }
        }

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
        /// <param name="nominalValue">Номинальная величина сопротивления</param>
        /// <param name="operatingVoltage">Рабочее напряжение</param>
        /// <param name="powerDissipation">Мощность рассивания</param>
        /// <param name="typeOfResistor">Тип резистора</param>
        public Resistor(int nominalValue, int operatingVoltage, int powerDissipation, TypeOfResistor typeOfResistor)
        {
            NominalValue = nominalValue;
            OperatingVoltage = operatingVoltage;
            PowerDissipation = powerDissipation;
            TypeOfResistor = typeOfResistor;
        }

    }
}
