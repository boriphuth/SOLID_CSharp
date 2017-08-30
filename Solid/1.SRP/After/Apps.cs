using System.Collections.Generic;
using System.Linq;

namespace Solid._1.SRP.After
{
    public class Apps
    {
        private List<string> _apps;

        public Apps()
        {
            _apps = new List<string>();
        }

        public void Install(string appName)
        {
            _apps.Add(appName);
        }

        public void Launch(string appName)
        {
            var app = _apps.SingleOrDefault(a => a.Contains(appName));
        }
    }
}
