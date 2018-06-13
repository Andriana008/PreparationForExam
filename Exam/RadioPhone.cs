using System;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace Exam
{
    [Serializable]
    [DataContract]
    public class RadioPhone:Phone
    {
        [DataMember]
        public string Radius { set; get; }
        [DataMember]
        public string AutoAnswering { set; get; }

        public RadioPhone(){}

        public RadioPhone(string name, string camp, string pri, string r, string a)
        {
            Name = name;
            Campany = camp;
            Price = pri;
            Radius = r;
            AutoAnswering = a;
        }

    }
}
