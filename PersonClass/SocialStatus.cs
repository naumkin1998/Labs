using System.ComponentModel;

namespace PersonClass
{
    //TODO: XML +
    /// <summary>
    /// Перечисление социального статуса
    /// </summary>
    public enum SocialStatus
    {
        [Description("Безработный")]
        Unemployed,
        [Description("Работает")]
        Working
    }
}
