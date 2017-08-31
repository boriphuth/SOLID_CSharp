using System;
using Solid._1.SRP.After;
using Solid._2.OCP.After;
using Xunit;

namespace Solid.Tests
{
    public class OcpSmartPhoneTest
    {
        [Fact]
        public void SmartPhoneTest()
        {
            var i8SPhone = new i8sPhone();
            Assert.NotNull(i8SPhone);

            var nx9Phonee = new Nx9Phone();
            Assert.NotNull(nx9Phonee);

            var s10Phone = new S10Phone();
            Assert.NotNull(s10Phone);

        }
    }
}
