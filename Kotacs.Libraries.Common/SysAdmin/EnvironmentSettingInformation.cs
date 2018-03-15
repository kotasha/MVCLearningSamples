using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Kotacs.Libraries.Common.SysAdmin
{
    public class EnvironmentSettingInformation
    {
        public Collection<ApplicationSetting> Settings { get; set; }
        public string EnvironmentName { get; set; }

    }
}