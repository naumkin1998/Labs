using System;
using System.Numerics;
using System.Xml.Serialization;

namespace ElectricalElements
{
    [XmlInclude(typeof(Capacitor))]
    [XmlInclude(typeof(Resistor))]
    [XmlInclude(typeof(InductiveСoil))]
    public abstract class ElementBase
    {

        /// <summary>
        /// Тип элемента
        /// </summary>
        public string TypeOfElements { get; set; }

        /// <summary>
        /// Импеданс
        /// </summary>
        public Complex Impedance 
        { 
            get => CalculatedImpedance(); 
            set => CalculatedImpedance(); 
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="typeOfElements"></param>
        /// <param name="impedansce"></param>
        protected ElementBase(string typeOfElements, Complex impedansce)
        {
            TypeOfElements = typeOfElements;
            Impedance = impedansce;
        }

        /// <summary>
        /// конструктор
        /// </summary>
        protected ElementBase(string typeOfElements)
        {
            TypeOfElements = typeOfElements; 
        }

        /// <summary>
        /// XML
        /// </summary>
        protected ElementBase() { }

        /// <summary>
        /// Расчет имепеданса
        /// </summary>
        /// <returns></returns>
        public abstract Complex CalculatedImpedance();

        /// <summary>
        /// Информация о сопротивление 
        /// </summary>
        /// <returns></returns>
        public abstract string Info();
    }
}
