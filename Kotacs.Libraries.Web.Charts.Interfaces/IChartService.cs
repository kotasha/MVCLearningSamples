using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kotacs.Libraries.Web.Charts.Interfaces
{
    public interface IChartService
    {
         void Render(string chartType,string chartTitle,string [] xValue,IEnumerable<int> yvalues);
    }
}
