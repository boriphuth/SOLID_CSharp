﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._4.ISP.Before
{
    public class FeaturePhone : IPhone
    {
        public void Call()
        {
            
        }

        public void Ring()
        {
           
        }

        public void InstallApp()
        {
            throw new NotImplementedException();
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
