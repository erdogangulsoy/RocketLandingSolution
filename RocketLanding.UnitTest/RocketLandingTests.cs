using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketLanding.Domain;

namespace RocketLanding.UnitTest
{
    [TestClass]
    public class RocketLandingTests
    {
        [TestMethod]
        public void Land_WithinLandingArea_ReturnsTrue()
        {
            RocketLanding.Domain.RocketLanding rocketLanding = new Domain.RocketLanding();
            LandingCheckStatus result = rocketLanding.Land(new Domain.LandingPoint(25, 25));
            Assert.IsTrue(result==LandingCheckStatus.ok_for_landing);
        }

        [TestMethod]
        public void Land_OutOfPlatform_ReturnsTrue()
        {
            RocketLanding.Domain.RocketLanding rocketLanding = new Domain.RocketLanding();
            LandingCheckStatus result = rocketLanding.Land(new Domain.LandingPoint(95, 25));
            Assert.IsTrue(result == LandingCheckStatus.ok_for_landing);
        }

        [TestMethod]
        public void Land_Clash_ReturnsTrue()
        {
            RocketLanding.Domain.RocketLanding rocketLanding = new Domain.RocketLanding();
            rocketLanding.Land(new Domain.LandingPoint(20, 24));
            LandingCheckStatus result = rocketLanding.Land(new Domain.LandingPoint(25, 25));
            Assert.IsTrue(result == LandingCheckStatus.clash);
        }
    }
}
