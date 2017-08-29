using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Solid._1.SRP.Before
{
    public class SmartPhone
    {
        private List<string> apps;
        private List<string> contacts;
        private string phoneNumber;
        private string phoneModel;
        private int screenWidth;
        private int screenHigth;

        public void Call(int telNumber)
        {
        }

        public void Ring()
        {
        }

        public void InstallApp(string appName)
        {
            this.apps.Add(appName);
        }

        public void LaunchApp(string appName)
        {
            var app = this.apps.SingleOrDefault(a => a.Contains(appName));
        }

        public void AddContact(string contact)
        {
            this.contacts.Add(contact);
        }

        public int GetScreenPixel()
        {
            return this.screenWidth * this.screenHigth;
        }

        public string GetModel()
        {
            return this.phoneModel;
        }
    }
}
