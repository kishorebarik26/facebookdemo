using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FB.Core
{
    public class FacebookSetting : ConfigurationSection
    {
        [ConfigurationProperty("appId", IsRequired = true)]
        public string AppId
        {
            get { return (string) this["appId"]; }
        }
    }
}
