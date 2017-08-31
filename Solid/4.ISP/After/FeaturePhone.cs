using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._4.ISP.After
{
    public class FeaturePhone : IPhone,IMobileConnect
    {
        public void Call()
        {
            
        }

        public void Ring()
        {
            
        }

        public void AddContact()
        {
            
        }

        public void ConnectWifi()
        {
            throw new NotImplementedException();
        }

        public void ConnectMobile()
        {
            
        }
    }
}
