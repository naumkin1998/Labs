using System.ComponentModel;

namespace PersonClass
{
    public enum SocialStatus
    {
        [Description("Безработный")]
        Unemployed,
        [Description("Работает")]
        Working
    }
}
