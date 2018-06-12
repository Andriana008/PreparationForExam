using System;

namespace Exam
{
    [Serializable]
    public class RadioPhone:Phone
    {
        public string Radius { set; get; }
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
