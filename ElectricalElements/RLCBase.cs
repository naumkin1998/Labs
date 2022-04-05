using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalElements
{
    //TODO: ElementBase
    //TODO: Complex
    public abstract class RLCBase
    {
        /// <summary>
        /// Номинальное значение сопротивления
        /// </summary>
        private int _resistance;

        /// <summary>
        /// Номинальное значение сопротивления
        /// </summary>
        public int Resistance
        {
            get => _resistance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сопротивление резистора " +
                                                "не может быть отрицательным!");
                }

                _resistance = value;
            }
        }

        /// <summary>
        /// Индуктивность 
        /// </summary>
        private int _inductance;

        /// <summary>
        /// Индуктивность
        /// </summary>
        public int Inductance
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
        /// Электрическая емкость
        /// </summary>
        private int _electricalCapacity;

        /// <summary>
        /// Электрическая емкость
        /// </summary>
        public int ElectricalCapacity
        {
            get => _electricalCapacity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Емкасть конденсатора " +
                                                "не может быть отрицательным!");
                }

                _electricalCapacity = value;
            }
        }

        /// <summary>
        /// RLC конструктор
        /// </summary>
        /// <param name="resistance">Сопротивление резистора</param>
        /// <param name="inductance">Сопротивление катушки</param>
        /// <param name="electricalCapacity">Сопротивление конденсатора</param>
        protected RLCBase(int resistance, int inductance, int electricalCapacity)
        {
            Resistance = resistance;
            Inductance = inductance;
            ElectricalCapacity = electricalCapacity;
        }

        /// <summary>
        /// Дефолтный конструктор
        /// </summary>
        protected RLCBase(): this(0, 0, 0) {}

        /// <summary>
        /// Информация об RLC
        /// </summary>
        /// <returns></returns>
        public abstract string Info();

    }
}
