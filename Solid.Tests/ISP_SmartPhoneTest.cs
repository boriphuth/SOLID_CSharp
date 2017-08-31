using Solid._4.ISP.After;
using Xunit;

namespace Solid.Tests
{
    public class IspSmartPhoneTest
    {
        [Fact]
        public void SmartPhoneTest()
        {
            var smartPhone = new SmartPhone();
            Assert.NotNull(smartPhone);
        }

        [Fact]
        public void FeaturePhoneTest()
        {
            var featurePhone = new FeaturePhone();
            Assert.NotNull(featurePhone);
        }

        [Fact]
        public void BasicTabletTest()
        {
            var basicTablet = new BasicTablet();
            Assert.NotNull(basicTablet);
        }
    }
}
