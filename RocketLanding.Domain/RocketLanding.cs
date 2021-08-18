using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLanding.Domain
{
    public class RocketLanding : ILanding
    {
        public LandingPoint LastCheckedInPoint { get; private set; }
        public Platform Platform { get; private set; }
        public RocketLanding(Platform platform)
        {
            Platform = platform ?? new Platform(5, 5, 10, 10);
        }

        public RocketLanding() : this(null) { }
        

        public LandingCheckStatus Land(LandingPoint point)
        {
            if (point == null) throw new ArgumentNullException($"{nameof(point)} can not be null");

            if (!Platform.IsPlatformWihtinLandingArea(point))
            {
                return LandingCheckStatus.out_of_platform;
            }

            if (LastCheckedInPoint == null)
            {
                LastCheckedInPoint = point;
                return LandingCheckStatus.ok_for_landing;
            }
            else if (isNearBy(point, LastCheckedInPoint))
            {
                LastCheckedInPoint = point;
                return LandingCheckStatus.clash;
            }
            else
            {
                LastCheckedInPoint = point;
                return LandingCheckStatus.ok_for_landing;
            }
        }

        private bool isNearBy(LandingPoint point1, LandingPoint point2)
        {
            return ((Math.Abs(point1.X - point2.X) == 1) || (Math.Abs(point1.Y - point2.Y) == 1));
        }

    }
}
