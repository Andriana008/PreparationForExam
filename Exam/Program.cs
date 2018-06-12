using System;

namespace Exam
{
    public class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                Task.DoTask();
                //string str = string.Empty;
                //if (string.IsNullOrEmpty(str))
                //{
                //    throw new Exception("Wrong Data");
                //}
            }
            catch (Exception ex)
            {
                Exceptions.ErrorLogging(ex);
                Exceptions.ReadError();
            }
        }
    }
}
