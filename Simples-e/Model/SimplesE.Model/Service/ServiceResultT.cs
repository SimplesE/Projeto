using System.Runtime.Serialization;

namespace SimplesE.Model.Service {

    [DataContract]
    public class ServiceResult<T> : ServiceResult {

        [DataMember]
        public T Result { get; set; }
    }
}
