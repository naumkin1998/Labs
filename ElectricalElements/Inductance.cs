using System;

/// <summary>
/// Электрические элементы
/// </summary>
namespace ElectricalElements
{
    /// <summary>
    /// Класс индуктивности
    /// </summary>
    public class InductiveСoil
    {
        /// <summary>
        /// Индуктивность 
        /// </summary>
        private int _inductance;

        /// <summary>
        /// Сопротивление потерь
        /// </summary>
        private int _lossResistance;

        /// <summary>
        /// Добротность
        /// </summary>
        private int _qualityFactor;

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
        /// Сопротивление потерь
        /// </summary>
        public int LossResistance
        {
            get => _lossResistance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сопротивление потерь " +
                                                "не может быть отрицательным!");
                }

                _lossResistance = value;
            }
        }

        /// <summary>
        /// Добротность
        /// </summary>
        public int QualityFactor
        {
            get => _qualityFactor;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Добротность катушки " +
                                                "не может быть отрицательной!");
                }

                _qualityFactor = value;
            }
        }

        /// <summary>
        /// Конструктор катушки индуктивности
        /// </summary>
        /// <param name="inductance">Индуктивность </param>
        /// <param name="lossResistance">Сопротивление потерь</param>
        /// <param name="qualityFactor">Добротность</param>
        public InductiveСoil(int inductance, int lossResistance, int qualityFactor)
        {
            Inductance = inductance;
            LossResistance = lossResistance;
            QualityFactor = qualityFactor;
        }
    }
}






