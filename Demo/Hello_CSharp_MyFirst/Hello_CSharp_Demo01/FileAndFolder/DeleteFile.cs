using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hello_CSharp_Demo01.FileAndFolder
{
    class DeleteFile
    {
        public static void Main(string[] args)
        {
            string filePath = "E:/text.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File delete!");
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
