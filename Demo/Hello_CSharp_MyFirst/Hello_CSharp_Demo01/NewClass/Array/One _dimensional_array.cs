using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Array
{
    class One__dimensional_array
    {
        static void Main(string[] args)
        {
            //mảng 1 chiều.
            int[] MyIntArr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("The element counted of array MyIntArr is {0}", MyIntArr.Length);
            for (int i = 0; i < MyIntArr.Length; i++)
            {
                Console.WriteLine("Element at {0}=>{1}", i, MyIntArr[i]);
            }
            float[] Arr3Ele = new float[3];
            Arr3Ele[0] = 1000;
            Arr3Ele[1] = 2000;
            Arr3Ele[2] = 3000;
            for (int i = 0; i < Arr3Ele.Length; i++)
            {
                Console.WriteLine("Element at {0}=>{1}", i, Arr3Ele[i]);
            }
            //mảng 2 chiều.
            int[,] twodimensional =
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12}
            };
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine("Element at [{0},{1}]={2}", row, col, twodimensional[row, col]);
                }
                Console.WriteLine("+++++++++++++++++++++++++++++++++");
            }
            int[,] b = new int[5, 5];
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.WriteLine("Element at [{0},{1}]={2}", row, col, b[row, col]);
                }
                Console.WriteLine("=======================");
            }
            //mảng của mảng.
            string[][] dienmay = new string[3][];
            string[] viettel_store = { "may giat", "tu lanh", "lo vi song" };
            string[] fpt_shop = { "dien thoai", "tivi", "ban la" };
            string[] thegioididong = { "may loc nuoc", "binh nong lanh", "quat dien" };
            dienmay[0] = viettel_store;
            dienmay[1] = fpt_shop;
            dienmay[2] = thegioididong;
            for (int row = 0; row < dienmay.Length; row++)
            {
                for (int col = 0; col < dienmay[row].Length; col++)
                {
                    Console.WriteLine("Mang cac san pham la:[{0},{1}]={2}", row, col, dienmay[row][col]);
                }
                Console.WriteLine("________________");
            }
            Console.ReadLine();
        }
    }
}
