using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTransferApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Ftp2 Ftp = new Ftp2();

            Ftp.FileTransfer();

            Console.ReadLine();
        }
    }
}
