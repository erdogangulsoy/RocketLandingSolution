using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLanding.Domain
{
    public enum LandingCheckStatus :short
    {
        ok_for_landing=0,
        out_of_platform=1,
        clash=2

    }
}
