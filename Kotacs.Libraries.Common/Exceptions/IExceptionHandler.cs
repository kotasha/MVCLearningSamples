using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotacs.Libraries.Common.Exceptions
{
    public interface IExceptionHandler
    {
        bool HandleExcception(Exception exception);
        bool HandlePresentationExcception(Exception exception);
        bool HandleDeliveryFrameworkExcception(Exception exception);
        bool HandleServiceExcception(Exception exception);
        bool HandleBusinessExcception(Exception exception);
        bool HandleDataExcception(Exception exception);
    }

}
