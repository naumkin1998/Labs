﻿using System;

/// <summary>
/// Электрические элементы
/// </summary>
namespace ElectricalElements
{
    /// <summary>
    /// Класс конденсаторов
    /// </summary>
    public class Capacitor
    {
        /// <summary>
        /// Электрическая емкость
        /// </summary>
        private int _electricalCapacity;

        /// <summary>
        /// Допустимое отклонение погрешности
        /// </summary>
        private int _permissibleDeviation;

        /// <summary>
        /// Тип конденсатора
        /// </summary>
        public TypeOfCapacity TypeOfCapacity { get; set; }

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
        /// <param name="electricalCapacity">Электрическая емкость</param>
        /// <param name="permissibleDeviation">Допустимое отклонение погрешности</param>
        /// <param name="typeOfCapacity"></param>
        public Capacitor(int electricalCapacity, int permissibleDeviation, TypeOfCapacity typeOfCapacity)
        {
            ElectricalCapacity = electricalCapacity;
            PermissibleDeviation = permissibleDeviation;
            TypeOfCapacity = typeOfCapacity;
        }

        /// <summary>
        /// Дефолтный конструктор конденсатора
        /// </summary>
        public Capacitor() :this(0, 0, TypeOfCapacity.ConstantCapacity) {}
    }
}
