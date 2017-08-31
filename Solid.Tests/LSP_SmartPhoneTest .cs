using Solid._3.LSP.Before;
using Xunit;

namespace Solid.Tests
{
    public class LspSmartPhoneTest
    {
        [Fact]
        public void SmartPhoneBeforeTest()
        {
            var phone = new Phone();
            phone.InstallApp();
            Assert.NotNull(phone);

            var smartPhone = new SmartPhone();
            smartPhone.InstallApp();
            Assert.NotNull(smartPhone);

            var featurePhone = new FeaturePhone();
            featurePhone.InstallApp();
            Assert.NotNull(smartPhone);
        }

        [Fact]
        public void SmartPhoneAfterTest()
        {
            var phone = new Solid._3.LSP.After.Phone();
            Assert.NotNull(phone);

            var smartPhone = new Solid._3.LSP.After.SmartPhone();
            smartPhone.InstallApp();
            Assert.NotNull(smartPhone);

            var featurePhone = new Solid._3.LSP.After.FeaturePhone();
            Assert.NotNull(smartPhone);
        }
    }
}
