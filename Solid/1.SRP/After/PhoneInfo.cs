using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1.SRP.After
{
    public class PhoneInfo
    {
        private string _phoneNumber;
        private string _phoneModel;
        private int _screenWidth;
        private int _screenHeigth;

        public PhoneInfo(string phoneNumber,string phoneModel, int screenWidth,int screenHeigth)
        {
            _phoneModel = phoneModel;
            _screenWidth = screenWidth;
            _screenHeigth = screenHeigth;
            _phoneNumber = phoneNumber;
        }

        public string GePhoneNumber()
        {
            return _phoneNumber;
        }

        public string GetModel()
        {
            return _phoneModel;
        }

        public int GetScreenPixel()
        {
            return _screenWidth * _screenHeigth;
        }
    }
}
