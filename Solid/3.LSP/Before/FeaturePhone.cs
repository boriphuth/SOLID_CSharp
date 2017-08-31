using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._3.LSP.Before
{
    public class FeaturePhone : Phone
    {
        public void InstallApp()
        {
            throw new Exception("Feature Phone does not support install app...");
        }
    }
}
