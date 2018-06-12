using System;

namespace Exam
{
    [Serializable]
    public class MobilePhone : Phone
    {
        public string Color { set; get; }
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
