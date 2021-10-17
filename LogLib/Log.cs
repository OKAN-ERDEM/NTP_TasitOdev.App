
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{//OKAN ERDEM -193801025
    public class Log
    {
        public static void LogAraba(string path, string msg)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
