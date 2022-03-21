using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PersonClass
{
    //TODO: XML
    public enum MaritalStatus
    {
        [Description("Холост")]
        Single,
        [Description("Семейный")]
        Family
    }
}
