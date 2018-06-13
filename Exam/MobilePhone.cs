using System;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace Exam
{
    [Serializable]
    [DataContract]
    public class MobilePhone : Phone
    {
        [DataMember]
        public string Color { set; get; }
        [DataMember]
        public string Memory { set; get; }

        public MobilePhone(){}

        public MobilePhone(string name, string camp, string pri, string col, string mem)
        {
            Name = name;
            Campany = camp;
            Price = pri;
            Color = col;
            Memory = mem;
        }


    }
}
