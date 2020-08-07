using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policy.API.Enum
{
    public enum PolicyStatus
    {
        Created = 0,
        Confrimed = 1,
        AuditSuccess=2,
        AuditFail=-2,
        CustomerPayed=3,

    }
}
