using System;

namespace RocketLanding.App
{
    class Program
    {
        static void Main(string[] args)
        {

            RocketLanding.Domain.Platform p = new Domain.Platform(6, 66, 60, 5);
            RocketLanding.Domain.LandingPlatform lp = new Domain.LandingPlatform();
            lp.Land(new Domain.LandingPoint(5,5));
        }
    }
}
