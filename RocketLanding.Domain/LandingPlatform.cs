using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLanding.Domain
{
    public class LandingPlatform : ILanding
    {
        public LandingPoint LastCheckedInPoint { get; private set; }
        public Platform Platform { get; private set; }
        public LandingPlatform(Platform platform)
        {
            Platform = platform ?? new Platform(5, 5, 0, 10);
        }

        public LandingCheckStatus Land(LandingPoint point)
        {
            if (point == null) throw new ArgumentNullException($"{nameof(point)} can not be null");

            if (!Platform.IsPlatformWihtinLandingArea(point))
            {
                return LandingCheckStatus.out_of_platform;
            }
            
            LastCheckedInPoint = point;
            if (LastCheckedInPoint == null)
            {
                return LandingCheckStatus.ok_for_landing;
            }
            else if (!isNearBy(point, LastCheckedInPoint))
            {
                return LandingCheckStatus.ok_for_landing;
            }
            else
            {
                return LandingCheckStatus.clash;
            }
        }

        private bool isNearBy(LandingPoint point1, LandingPoint point2)
        {
            return ((Math.Abs(point1.X - point2.X) == 1) || (Math.Abs(point1.Y - point2.Y) == 1));
        }


    }
}
