using System.ComponentModel;

namespace ElectricalElements
{
    /// <summary>
    /// Типы резисторов
    /// </summary>
    public enum TypeOfResistor
    {
        [Description("Линейный")]
        Linear,
        [Description("Варистор")]
        Varistor,
        [Description("Терморезистор")]
        Thermistors,
        [Description("Фоторезистор")]
        Photoresistors,
        [Description("Тензорезистор")]
        Tensoresistors,
        [Description("Магниторезистор")]
        Magnetoresistors
    }
}
