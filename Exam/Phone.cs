using System;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace Exam
{
    [Serializable]
    [DataContract]
    public class Phone
    {
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public string Campany { set; get; }
        [DataMember]
        public string Price { set; get; }
    }
}
