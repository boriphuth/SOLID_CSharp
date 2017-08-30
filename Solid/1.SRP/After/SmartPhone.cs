namespace Solid._1.SRP.After
{
    public class SmartPhone
    {
        private Apps _apps;
        private PhoneInfo _phoneInfo;
        private Contacts _contacts;

        public SmartPhone(Apps apps, PhoneInfo phoneInfo, Contacts contacts)
        {
            _apps = apps;
            _phoneInfo = phoneInfo;
            _contacts = contacts;
        }

        public void Call(int telNumber)
        {

        }

        public void Ring()
        {

        }

        public void InstallApp(string appName)
        {
            _apps.Install(appName);
        }

        public void LaunchApp(string appName)
        {
            _apps.Launch(appName);
        }

        public void AddContact(string contact)
        {
            _contacts.Add(contact);
        }

        public int GetScreenPixel()
        {
            return _phoneInfo.GetScreenPixel();
        }

        public string GetModel()
        {
            return _phoneInfo.GetModel();
        }
    }
}
