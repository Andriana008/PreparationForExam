using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exam
{
    public class SerializeXML
    {
        
        public static void SerializeMobileList(List<MobilePhone> lines)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<MobilePhone>));
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeMobile.xml", FileMode.Open))
            {
                formatter.Serialize(fs, lines);
            }
        }

        public static List<MobilePhone> DeserializeMobileList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<MobilePhone>));
            List<MobilePhone> lin = null;
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeMobile.xml", FileMode.Open))
            {
                lin = (List<MobilePhone>)formatter.Deserialize(fs);
            }

            if (lin == null)
            {
                throw new ApplicationException(string.Format("cannot deserialize file  / Users / Andriana / Desktop / C#/practice/Exam/Exam/Serialize"));
            }

            return lin;
        }
        public static void SerializeRadioList(List<RadioPhone> lines)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<RadioPhone>));
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeRadio.xml", FileMode.Open))
            {
                formatter.Serialize(fs, lines);
            }
        }

        public static List<RadioPhone> DeserializeRadioList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<RadioPhone>));
            List<RadioPhone> lin = null;
            using (FileStream fs = new FileStream("/Users/Andriana/Desktop/C#/practice/Exam/PreparationForExam/Exam/SerializeRadio.xml", FileMode.Open))
            {
                lin = (List<RadioPhone>)formatter.Deserialize(fs);
            }

            if (lin == null)
            {
                throw new ApplicationException(string.Format("cannot deserialize file  / Users / Andriana / Desktop / C#/practice/Exam/Exam/Serialize"));
            }

            return lin;
        }
    }
}
