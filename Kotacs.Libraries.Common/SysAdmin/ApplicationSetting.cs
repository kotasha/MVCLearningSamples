using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.Common.SysAdmin
{
    public class ApplicationSetting
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Area { get; set; }
        public bool IsEnvironmentRelated { get; set; }
        public bool IsReadOnly { get; set; }
    }
}