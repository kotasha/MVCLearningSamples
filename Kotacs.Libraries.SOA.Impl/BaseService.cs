using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Kotacs.Libraries.Common.Logging;
using Kotacs.Libraries.Common.Exceptions;
using Kotacs.Libraries.Common;
using Kotacs.Libraries.SOA.Contracts.Services;
namespace Kotacs.Libraries.SOA.Impl
{
    public class BaseService: IBaseService
    {
        [Dependency]
		public ILogger Logger { get; set; }
		[Dependency]
		public IExceptionHandler ExceptionHandler { get; set; }

		//protected UnityFactory unityFactory = UnityFactory.Instance;

        protected UnityFactory UnityFactory
        {
            get
            {
                return UnityFactory.Instance;
            }
        }


		public BaseService()
		{
			if (Logger == null)
				Logger = LogManager.GetLogger();
			if (ExceptionHandler == null)
				ExceptionHandler = ExceptionManager.GetExceptionHandler();
		}
	}
    }

