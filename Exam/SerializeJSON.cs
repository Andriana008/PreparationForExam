using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Exam
{
    public class SerializeJSON
    {
        public static void SerializeMobileList(List<MobilePhone> lines)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<MobilePhone>));
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeMob.json", FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, lines);
            }
        }

        public static List<MobilePhone> DeserializeMobileList()
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<MobilePhone>));
            List<MobilePhone> lin = null;
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeMob.json", FileMode.Open))
            {
                lin = (List<MobilePhone>)formatter.ReadObject(fs);
            }

            if (lin == null)
            {
                throw new ApplicationException(string.Format("cannot deserialize file  / Users / Andriana / Desktop / C#/practice/Exam/Exam/Serialize"));
            }

            return lin;
        }
        public static void SerializeRadioList(List<RadioPhone> lines)
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<RadioPhone>));
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeRad.json", FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, lines);
            }
        }

        public static List<RadioPhone> DeserializeRadioList()
        {
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<RadioPhone>));
            List<RadioPhone> lin = null;
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeRad.json", FileMode.Open))
            {
                lin = (List<RadioPhone>)formatter.ReadObject(fs);
            }

            if (lin == null)
            {
                throw new ApplicationException(string.Format("cannot deserialize file  / Users / Andriana / Desktop / C#/practice/Exam/Exam/Serialize"));
            }

            return lin;
        }
    }
}
