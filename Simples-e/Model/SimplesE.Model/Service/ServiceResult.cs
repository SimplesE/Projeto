using System;
using System.Runtime.Serialization;

namespace SimplesE.Model.Service {

    [DataContract]
    public class ServiceResult {

        [DataMember]
        public bool Completed { get; set; }

        [DataMember]
        public Exception Exception { get; set; }
    }
}
