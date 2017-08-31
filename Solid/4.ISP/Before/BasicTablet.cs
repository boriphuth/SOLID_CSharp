using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._4.ISP.Before
{
    public class BasicTablet : IPhone
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void Ring()
        {
            throw new NotImplementedException();
        }

        public void InstallApp()
        {
            
        }

        public void AddContact()
        {
            throw new NotImplementedException();
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
