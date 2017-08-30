using System.Collections.Generic;
using System.Linq;

namespace Solid._1.SRP.Before
{
    public class SmartPhone
    {
        private List<string> _apps;
        private List<string> _contacts;
        private string _phoneNumber;
        private string _phoneModel;
        private int _screenWidth;
        private int _screenHigth;

        public void Call(int telNumber)
        {
        }

        public void Ring()
        {
        }

        public void InstallApp(string appName)
        {
            this._apps.Add(appName);
        }

        public void LaunchApp(string appName)
        {
            var app = this._apps.SingleOrDefault(a => a.Contains(appName));
        }

        public void AddContact(string contact)
        {
            this._contacts.Add(contact);
        }

        public int GetScreenPixel()
        {
            return this._screenWidth * this._screenHigth;
        }

        public string GetModel()
        {
            return this._phoneModel;
        }
    }
}
