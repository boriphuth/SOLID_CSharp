namespace Solid._5.DIP.Before
{
    public class SmartPhone
    {
        private readonly BluetoothDevice _bluetoothDevice;//มีการถือ object BluetoothDevice ใน Class

        public SmartPhone()
        {
            _bluetoothDevice = new BluetoothDevice();// มีการสร้าง Object ใน Class
        }

        public void ConnectBluetooth()
        {
            _bluetoothDevice.Connect();
        }
    }
}
