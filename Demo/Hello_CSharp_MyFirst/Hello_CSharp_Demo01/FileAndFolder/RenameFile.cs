using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hello_CSharp_Demo01.FileAndFolder
{
    class RenameFile
    {
        public static void Main(string[] args)
        {
            string filePath = "E:/testfile/hoang.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine(filePath + " exist");
                Console.WriteLine("Please enter the new file name!");
                string newname = Console.ReadLine();
                if (filePath != newname)
                {
                    File.Move(filePath, newname);
                    if (File.Exists(newname))
                    {
                        Console.WriteLine("The file " + filePath + " rename to " + newname);
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
            Console.ReadKey();
        }
    }
}
