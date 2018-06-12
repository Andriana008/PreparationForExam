using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam
{
    public class Exceptions
    {
        public static void ErrorLogging(Exception ex)
        {
            string strPath = @"/Users/Andriana/Desktop/C#/practice/Exam/Exam/Exception.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }
        }

        public static void ReadError()
        {
            string strPath = @"/Users/Andriana/Desktop/C#/practice/Exam/Exam/Exception.txt";
            using (StreamReader sr = new StreamReader(strPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
