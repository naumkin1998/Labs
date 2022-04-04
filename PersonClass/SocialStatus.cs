using System.ComponentModel;

namespace PersonClass
{
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
