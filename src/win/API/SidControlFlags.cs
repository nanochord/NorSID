using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorSID.API
{
    [Flags]
    public enum SidControlFlag
    {
        Noise = 0x80,
        Square = 0x40,
        Saw = 0x20,
        Triangle = 0x10,
        Test = 0x8,
        Ringmod = 0x4,
        Sync = 0x2,
        Gate = 0x1,
    }

}
