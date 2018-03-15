using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Kotacs.Libraries.SOA.Contracts.Faults
{
    [Serializable]
    [DataContract(Name="ServiceError",Namespace=@"http://schemas.kotacs.com/contracts")]
    public class ServiceError
    {
        [DataMember]
        public int ErrorId { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Source { get; set; }
        public override string ToString()
        {
            return string.Format(@"{0},{1},{2}",this.ErrorId,this.Message,this.Source);
        }
    }
}
