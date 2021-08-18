using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLanding.Domain
{
    public record Platform
    {
        private const uint LANDINGAREA_MAX_X = 100;
        private const uint LANDINGAREA_MAX_Y = 100;
        public uint X { get; set; }
        public uint Y { get; set; }

        public uint Width { get; set; }
        public uint Height { get; set; }

        public Platform(uint x=5, uint y=5, uint width=10, uint height=10)
        {
            if (x >= LANDINGAREA_MAX_X) throw new ArgumentException($"{nameof(X)} value is out of allowed range");
            if (y >= LANDINGAREA_MAX_Y) throw new ArgumentException($"{nameof(Y)} value is out of allowed range");
            if (width == 0) throw new ArgumentException($"{nameof(Width)} value should be greater than zero");
            if (height == 0) throw new ArgumentException($"{nameof(Height)} value should be greater than zero");

            X = x;
            Y = y;
            Width = width;
            Height = height;


            if (!IsPlatformWihtinLandingArea(new LandingPoint(x,y))) throw new ArgumentException("Platform overlaps the landing area");

           
        }

        public bool IsPlatformWihtinLandingArea(LandingPoint point) => (X + Width <= LANDINGAREA_MAX_X && Y + Height <= LANDINGAREA_MAX_Y);

        

    }
}
