using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._5.DIP.After
{
    public class SmartPhone
    {
        private readonly IBluetooth _bluetooth; // อ้างถึง Bluetooth ผ่าน Interface ไม่ใช่ Object

        public SmartPhone(IBluetooth bluetooth)// มีการรับ Object ที่มี Interface IBluetooth เป็น Parameter
        {
            _bluetooth = bluetooth;
        }

        public void ConnectBLuetooth()
        {
            _bluetooth.Connect();
        }

        public void ScanBLuetooth()
        {
            _bluetooth.Scan();
        }
    }
}
