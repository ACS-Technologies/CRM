using System;
using System.Runtime.Serialization;

namespace BaseProject.Models
{
    [DataContract]
    [Serializable]
    public class Response
    {
        [DataMember]
        public int ErrorCode { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public bool IsScusses { get; set; }

        [DataMember]
        public object ResponseDetails { get; set; }
    }
}