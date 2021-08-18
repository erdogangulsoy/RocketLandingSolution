using System;

namespace RocketLanding.App
{
    class Program
    {
        static void Main(string[] args)
        {
            RocketLanding.Domain.RocketLanding lp = new Domain.RocketLanding();
            lp.Land(new Domain.LandingPoint(5,5));
        }
    }
}
