using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Core
{
    public static class ConnectionString
    {
        public static string Connection()
        {
            string txtpath = @"c:\connection.txt";
            string server = "";
            try
            {
                if (File.Exists(txtpath))
                {
                    using (StreamReader sr = new StreamReader(txtpath))
                    {
                        while (sr.Peek() >= 0)
                        {
                            server = sr.ReadLine();

                            
                           
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
            }


            return server;

            
        }
    }
}
