using System.ComponentModel;

namespace ElectricalElements
{
    public enum TypeOfCapacity
    {
        [Description("Постоянная емкость")]
        ConstantCapacity,
        [Description("Переменная емкость")]
        VariableCapacity
    }
}