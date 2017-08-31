using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._4.ISP.After
{
    public class BasicTablet :ISmartFeatures,IMobileConnect
    {
        public void InstallApp()
        {
           
        }

        public void ConnectWifi()
        {
            
        }

        public void ConnectMobile()
        {
            throw new NotImplementedException();
        }
    }
}
