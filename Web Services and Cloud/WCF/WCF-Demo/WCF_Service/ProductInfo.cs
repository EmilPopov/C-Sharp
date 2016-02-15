using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Service
{
    [DataContract]
    public class ProductInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}