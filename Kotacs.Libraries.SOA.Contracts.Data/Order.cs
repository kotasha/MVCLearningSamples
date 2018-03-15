using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Kotacs.Libraries.SOA.Contracts.Data
{
    [Serializable]
    [DataContract(
        Name = "Order",
        Namespace = @"http://schemas.thomson.com/contracts")]
    public class Order
    {
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string BillingAddress { get; set; }
        [DataMember]
        public string ShippingAddress { get; set; }
        [DataMember]
        public int NoOfUnits { get; set; }
        [DataMember]
        public int OrderValue { get; set; }
        [DataMember]
        public string Remarks { get; set; }

        public override string ToString()
        {
            return string.Format(@"{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                this.OrderId, this.OrderDate.ToString(), this.CustomerId,
                this.BillingAddress, this.ShippingAddress, this.NoOfUnits, this.OrderValue, this.Remarks);
        }

    }
}

