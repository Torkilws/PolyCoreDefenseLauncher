using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyCoreDefenseLauncher
{
    internal class VersionItem
    {
        public string VersionName { get; set; }
        public string VersionDownloadUrl { get; set; }

        public VersionItem(string friendlyName, string value)
        {
            VersionName = friendlyName;
            VersionDownloadUrl = value;
        }

        public override string ToString()
        {
            return VersionName;
        }

    }
}
