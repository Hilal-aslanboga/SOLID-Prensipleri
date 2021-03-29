using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.SRP.GoodExample
{
    public class Logger
    {
        public void LogFile(string filePath, string log) => File.WriteAllText(filePath, log);

        public string BuildLog(string information)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Date: ");
            stringBuilder.Append(DateTime.Now.ToString());
            stringBuilder.AppendLine();
            stringBuilder.Append("Information");
            stringBuilder.Append(information);

            return stringBuilder.ToString();
        }
    }
}
