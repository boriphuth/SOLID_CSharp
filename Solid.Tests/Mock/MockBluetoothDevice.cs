using System;
using System.Collections.Generic;
using System.Text;
using Solid._5.DIP.After;

namespace Solid.Tests.Mock
{
    public class MockBluetoothDevice :IBluetooth
    {
        public void Connect()
        {
            Console.WriteLine("just connect");
        }

        public void Scan()
        {
            Console.WriteLine("just scan");
        }
    }
}
