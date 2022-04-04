using System.ComponentModel;

namespace ElectricalElements
{
    public enum TypeOfCapacity
    {
        [Description("Постоянная емкость")]
        CConstantCapacity,
        [Description("Переменная емкость")]
        VariableCapacity
    }
}