using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.Common.SysAdmin
{
    public class ApplicationSettingAreas
    {
        public IList<ApplicationSettingsArea> EnvironmentalSettingAreas { get; set; }
        public IList<ApplicationSettingsArea> NonEnvironmentalSettingAreas { get; set; }
        public string EnvironmentName { get; set; }
    }
}