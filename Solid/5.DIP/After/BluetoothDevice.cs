using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._5.DIP.After
{
    public class BluetoothDevice : IBluetooth // class นี้ทำการ implements interface
    {
        public void Connect()
        {
            Console.WriteLine("bluetooth connect");
        }

        public void Scan()
        {
            Console.WriteLine("bluetooth scan");
        }
    }
}
