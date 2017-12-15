using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Log
    {
        public void WriteToLog(string text)
        {
            //string textBody = text;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Chez\Desktop\CSharp\TCPChatMyCopy\Log\log.txt", true))
            {
                file.WriteLine(text);
            }
        }
    }
}
