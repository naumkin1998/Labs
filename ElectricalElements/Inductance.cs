using System;

/// <summary>
/// Электрические элементы
/// </summary>
namespace ElectricalElements
{
    /// <summary>
    /// Класс индуктивности
    /// </summary>
    public class InductiveСoil : RLCBase
    {

        /// <summary>
        /// Сопротивление потерь
        /// </summary>
        private int _lossResistance;

        /// <summary>
        /// Добротность
        /// </summary>
        private int _qualityFactor;
        
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
            : base(0, inductance, 0)
        {
            LossResistance = lossResistance;
            QualityFactor = qualityFactor;
        }

        /// <summary>
        /// Дефолтный конструктор катушки
        /// </summary>
        public InductiveСoil(): this(0, 0, 0) { }
    }
}






