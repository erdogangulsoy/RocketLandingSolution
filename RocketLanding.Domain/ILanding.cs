using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLanding.Domain
{
    public interface ILanding
    {
        LandingCheckStatus Land(LandingPoint point);
    }
}
