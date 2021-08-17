using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLanding.Domain
{
    public record LandingPoint
    {
        public uint X { get; set; }
        public uint Y { get; set; }

        public LandingPoint(uint x, uint y)
        {
            if (x >= 100) throw new ArgumentException($"{nameof(X)} value is out of allowed range");
            if (y >= 100) throw new ArgumentException($"{nameof(Y)} value is out of allowed range");

            X = x;
            Y = y;
        }
    }
}
