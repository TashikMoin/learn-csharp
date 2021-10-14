using System;
using System.IO;

namespace WindowsService_Tutorial
{
    static class Log_Class
    /* a static class for a single static instance blueprint, no other instances can be created
    from this static class */
    {

        public static void Write_Logs(string Message)
        {
            try
            {
                string Date = System.DateTime.Now.ToString("dd-MM-yyyy");
                StreamWriter Writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFiles\\LogFile-" + Date + ".txt", true);
                Writer.WriteLine("Date: " + DateTime.Now.ToString());
                Writer.WriteLine(Message);
                Writer.Flush();
                Writer.Close();
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
            }
        }
    }
}
