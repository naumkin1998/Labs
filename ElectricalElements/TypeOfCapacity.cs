using System.ComponentModel;

namespace ElectricalElements
{
    public enum TypeOfCapacity
    {
        [Description("Алюминевый")]
        Aluminum,
        [Description("Керамический")]
        Ceramic,
        [Description("Танталовые")]
        Tantalum,
        [Description("Полиэстеровые")]
        Polyester
    }
}