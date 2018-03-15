using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Kotacs.Libraries.SOA.Contracts.Data
{
    [Serializable]
    [DataContract(Name="Customer",Namespace=@"http://schemas.kotacs.com/contracts")]
    //[MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {
        [DataMember]
        public string Customerid { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        //public string BusinessAddress { get; set; }
        //[DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public int CreditLimit { get; set; }
        [DataMember]
        public bool ActiveStatus { get; set; }
        //[DataMember]
        //public string SessionKey { get; set; }
        //[DataMember]
        //public int LicenseKey { get; set; }
        //[DataMember]
        //public string Remarks { get; set; }

        public override string ToString()
            {
                return string.Format(@"{0},{1},{2},{3},{4},{5},{6}",this.Customerid,this.CustomerName,this.Address,this.EmailId,this.PhoneNumber,this.CreditLimit,this.ActiveStatus);
            }
    }
}
