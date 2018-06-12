using System;
using System.Collections.Generic;
using System.IO;

namespace Exam
{
    public class Task
    {    
        public static MobilePhone ReadMobile(StreamReader streamReader)
        {
            MobilePhone c = new MobilePhone
            {
                Name = streamReader.ReadLine(),
                Campany = streamReader.ReadLine(),
                Price = streamReader.ReadLine(),
                Color = streamReader.ReadLine(),
                Memory = streamReader.ReadLine()
            };
            return c;
        }
        public static RadioPhone ReadRadio(StreamReader streamReader)
        {
            RadioPhone c = new RadioPhone
            {
                Name = streamReader.ReadLine(),
                Campany = streamReader.ReadLine(),
                Price = streamReader.ReadLine(),
                Radius = streamReader.ReadLine(),
                AutoAnswering = streamReader.ReadLine()
            };
            return c;
        }

        public static List<MobilePhone> ReadMobileFromFile()
        {
            List<MobilePhone> mobile = new List<MobilePhone>();
            StreamReader streamReader = new StreamReader("/Users/Andriana/Desktop/C#/practice/Exam/Exam/Mobile.txt");
            int ab = Convert.ToInt32(streamReader.ReadLine());
            for (int i = 0; i < ab; i++)
            {
                mobile.Add(ReadMobile(streamReader));
            }
            return mobile;
        }
        public static List<RadioPhone> ReadRadioFromFile()
        {
            List<RadioPhone> radio = new List<RadioPhone>();
            StreamReader streamReader = new StreamReader("/Users/Andriana/Desktop/C#/practice/Exam/Exam/Radio.txt");
            int ab = Convert.ToInt32(streamReader.ReadLine());
            for (int i = 0; i < ab; i++)
            {
                radio.Add(ReadRadio(streamReader));
            }
            return radio;
        }
        public static void WriteInFile(List<Phone> l,StreamWriter wr)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine("Type:{0}", l[i].GetType());
                wr.WriteLine("Type:{0}", l[i].GetType());
                wr.WriteLine("Name:{0}", l[i].Name);
                wr.WriteLine("Campany:{0}", l[i].Campany);
                wr.WriteLine("Price:{0}", l[i].Price);
            }
        }
        public static int TotalPrize(List<Phone> l)
        {
            int sum = 0;
            for (int i = 0; i < l.Count; i++)
            {
                sum += Convert.ToInt32(l[i].Price);
            }
            return sum;
        }
        public static void PhonesWithAutoAnswerInFile(List<RadioPhone> l,StreamWriter wr)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].AutoAnswering == "yes")
                {
                    wr.WriteLine("Name:{0}", l[i].Name);
                    wr.WriteLine("Campany:{0}", l[i].Campany);
                    wr.WriteLine("Price:{0}", l[i].Price);
                }
            }
        }
        public static List<RadioPhone> PhonesWithAutoAnswer(List<RadioPhone> l)
        {
            List<RadioPhone> rad = new List<RadioPhone>();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].AutoAnswering == "yes")
                {
                    rad.Add(l[i]);              
                }
            }
            return rad;
        }
        public static void DoTask()
        {
            StreamWriter writer = new StreamWriter("/Users/Andriana/Desktop/C#/practice/Exam/Exam/Result.txt");

            List<MobilePhone> mob = ReadMobileFromFile();
            List<RadioPhone> rad = ReadRadioFromFile();
            List<Phone> phones = new List<Phone>();
            phones.AddRange(mob);
            phones.AddRange(rad);

            phones.Sort((i,j) => j.Price.CompareTo(i.Price));

            writer.WriteLine("Sorted by prize :");
            WriteInFile(phones,writer);
            int sum = TotalPrize(phones);
            if(sum==0)
            {
                throw new Exception("wrong data");
            }
            writer.WriteLine("Total prize : {0}", sum);

            writer.WriteLine("RadioPhones with auto answering:");
            PhonesWithAutoAnswerInFile(rad,writer);
            writer.Close();

            Serialize.SerializeMobileList(mob);
            Serialize.SerializeRadioList(rad);
        }
    }
}
