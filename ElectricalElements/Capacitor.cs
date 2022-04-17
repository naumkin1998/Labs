﻿using System;
using System.Numerics;

/// <summary>
/// Электрические элементы
/// </summary>
namespace ElectricalElements
{
    /// <summary>
    /// Класс конденсаторов
    /// </summary>
    public class Capacitor : ElementBase
    {
        
        /// <summary>
        /// Допустимое отклонение погрешности
        /// </summary>
        private int _permissibleDeviation;

        /// <summary>
        /// Тип конденсатора
        /// </summary>
        public TypeOfCapacity TypeOfCapacity { get; set; }

        
        /// <summary>
        /// Допустимое отклонение погрешности
        /// </summary>
        public int PermissibleDeviation
        {
            get => _permissibleDeviation;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Погрешность конденсатора " +
                                               "не может быть отрицательной!");
                }
                _permissibleDeviation = value;
            }
        }


        /// <summary>
        /// Конструктор конденсатора
        /// </summary>
        /// <param name="complex">Электрическая емкость</param>
        /// <param name="permissibleDeviation">Допустимое отклонение погрешности</param>
        /// <param name="typeOfCapacity"></param>
        public Capacitor(Complex complex, int permissibleDeviation, TypeOfCapacity typeOfCapacity) 
            : base(complex)
        {
            PermissibleDeviation = permissibleDeviation;
            TypeOfCapacity = typeOfCapacity;
        }

        /// <summary>
        /// Дефолтный конструктор конденсатора
        /// </summary>
        public Capacitor() :this(0, 0, TypeOfCapacity.ConstantCapacity) {}
    }
}