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
        /// <param name="complex">Индуктивность </param>
        /// <param name="lossResistance">Сопротивление потерь</param>
        /// <param name="qualityFactor">Добротность</param>
        public InductiveСoil(Complex complex, int lossResistance, int qualityFactor) 
            : base(complex)
        {
            LossResistance = lossResistance;
            QualityFactor = qualityFactor;
        }

        /// <summary>
        /// Инфо об элементе
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"Fктивное сопротивление индуктивности:{this.ActiveResistance} " +
                   $"\nРеактивное сопротивление индуктивности: {this.ReactiveInductance}" +
                   $"\nСопротивление потерь: {this.LossResistance} " +
                   $"\nДобротность: {this.QualityFactor} ";
        }
    }
}






