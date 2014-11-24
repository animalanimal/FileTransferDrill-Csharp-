using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTransferApp
{
    class Ftp2
    {

        
        public void FileTransfer()
        {
            string fileName = ".txt";
            string sourcePath = @"C:\tf\hold";
            string destPath = @"C:\tf\rec";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(destPath, fileName);

            if (Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
            }

            if (Directory.Exists(sourcePath))
            {
                
                string[] files = Directory.GetFiles(sourcePath);

                // Copy the files more than 24hrs old, overwrites existing files
                foreach (string s in files)
                {
                    DateTime fileDate = File.GetCreationTime(s);
                    bool timeCheck = fileDate > DateTime.Now.AddHours(-24);

                    if (timeCheck == true)
                    {
                        fileName = Path.GetFileName(s);
                        destFile = Path.Combine(destPath, fileName);
                        File.Copy(s, destFile, true);

                        Console.WriteLine("Transferring file ... ");
                    }                    
                }
                Console.WriteLine("\nFile transfer complete.\n");
            }
            else
            {
                Console.WriteLine("Source path does not exist.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }


    }
}
