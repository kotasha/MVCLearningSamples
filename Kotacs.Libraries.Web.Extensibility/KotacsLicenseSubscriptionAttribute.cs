using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Kotacs.Libraries.Web.Extensibility
{
    class KotacsLicenseSubscriptionAttribute: ValidationAttribute, IClientValidatable
    {
        public const string ERROR_MESSAGE = @"Invalid License Key Provided!";

        public int MinKey { get; set; }
        public int MaxKey { get; set; }

        public KotacsLicenseSubscriptionAttribute() : base(ERROR_MESSAGE) { }

        public override bool IsValid(object value)
        {
            var status = value != default(object);

            if (status)
            {
                var licenseSubscription = int.Parse(value.ToString());

                status = licenseSubscription >= MinKey &&
                    licenseSubscription <= MaxKey;
            }

            return status;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            ModelMetadata metadata, ControllerContext context)
        {
            var clientValidationRule = new ModelClientValidationRule
            {
                ErrorMessage = ERROR_MESSAGE,
                ValidationParameters =
                {
                    { "min", MinKey },
                    { "max", MaxKey }
                },
                ValidationType = "subscriptionrange"
            };

            yield return clientValidationRule;
        }
    }
    
}
