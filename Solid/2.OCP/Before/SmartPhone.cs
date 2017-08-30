namespace Solid._2.OCP.Before
{
    public class SmartPhone
    {
        private string _phoneModel;
        private string _phoneFullName;
        private int _screenWidth;
        private int _screenHeigth;

        public SmartPhone(string model)
        {
            if (model == "S10")
            {
                _phoneModel = "S10";
                _screenWidth = 5;
                _screenHeigth = 10;
                _phoneFullName = "Samsung Galaxy S10";
            }
            else if (model == "8s")
            {
                _phoneModel = "8s";
                _screenWidth = 4;
                _screenHeigth = 3;
                _phoneFullName = "Apple iPhone 8s";
            }
            else if (model == "Nexus 9")
            {
                _phoneModel = "Nx9";
                _screenWidth = 5;
                _screenHeigth = 5;
                _phoneFullName = "Google Nexus 9";
            }
        }
    }
}
