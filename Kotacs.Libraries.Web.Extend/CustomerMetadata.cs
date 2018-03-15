using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Kotacs.Libraries.SOA.Contracts.Data;
namespace Kotacs.Libraries.Web.Extensibility
{
    //[MetadataType(typeof(CustomerMetadata))]
    //partial class Customer
    //{
    //}
    public class CustomerMetadata
    {
        [Required(
           ErrorMessageResourceName = "CustomerId",
           ErrorMessageResourceType = typeof(ModelErrors))]
        [Remote("Validate", "Customer", ErrorMessage = "Customer Id Already Exists!")]
        public string Customerid { get; set; }

        [Required]
        [StringLength(10,
            ErrorMessage = "Customer Name Should be having min. of 10 characters")]
        public string CustomerName { get; set; }

        //[Required]
        //[Compare("BusinessAddress")]
        //public string Address { get; set; }
        //public string BusinessAddress { get; set; }

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string EmailId { get; set; }

        [Required]
        [RegularExpression(@"\d{3,5}-\d{5,8}")]
        public string PhoneNumber { get; set; }

        //[Required]
        //[KotacsLicenseSubscription(MinKey = 10000, MaxKey = 100000)]
        //public int LicenseKey { get; set; }

        [Required]
        [Range(1000, 50000)]
        public int CreditLimit { get; set; }
    }
}
