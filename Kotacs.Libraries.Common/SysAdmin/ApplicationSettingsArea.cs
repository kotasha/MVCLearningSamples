using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.Common.SysAdmin
{
    public class ApplicationSettingsArea
    {
        public string Name { get; set; }
        public IList<ApplicationSetting> Settings { get; set; }
    }
}