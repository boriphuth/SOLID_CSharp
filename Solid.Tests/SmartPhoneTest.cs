using System;
using Solid._1.SRP.After;
using Xunit;

namespace Solid.Tests
{
    public class SmartPhoneTest
    {
        [Fact]
        public void SmartPhoneInitTest()
        {
            var smartPhone = new SmartPhone(new Apps(), new PhoneInfo("089947521", "Sumsang S8", 400, 800),
                new Contacts());
            smartPhone.InstallApp("GoogleDrive");
            smartPhone.LaunchApp("GoogleDrive");
            smartPhone.AddContact("TestName");
            smartPhone.GetScreenPixel();
            smartPhone.GetModel();
        }
    }
}
