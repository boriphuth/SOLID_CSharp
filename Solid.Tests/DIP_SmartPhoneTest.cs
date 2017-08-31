using Microsoft.VisualStudio.TestPlatform.Utilities;
using Solid.Tests.Mock;
using Solid._5.DIP.After;
using Xunit;

namespace Solid.Tests
{
    public class DipSmartPhoneTest
    {
        [Fact]
        public void SmartPhoneTest()
        {
            var smartPhone = new SmartPhone(new MockBluetoothDevice());
            smartPhone.ConnectBLuetooth();
            smartPhone.ScanBLuetooth();
            Assert.NotNull(smartPhone);

        }
    }
}
