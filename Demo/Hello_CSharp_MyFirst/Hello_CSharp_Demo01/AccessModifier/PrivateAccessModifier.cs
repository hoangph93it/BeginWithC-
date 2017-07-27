using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.AccessModifier
{
    class PrivateAccessModifier
    {
        private string Name;
        private int Rank;
        public PrivateAccessModifier(string name)
        {
            this.Name = name;
        }
        private PrivateAccessModifier(int rank)
        {
            this.Rank = rank;
        }
        private void ShowSecret()
        {
            Console.WriteLine("The secret is:{0}", Name);
        }
        private static void DoSomething(String job)
        {
            Console.WriteLine("Do job:" + job);
        }
        class Diary
        {
            public void Loggin()
            {
                DoSomething("Coding C#");//Các thành viên private static có thể truy cập trong inner class.
                //ShowSecret(); Lỗi do phương thức này không phải static.
            }
        }
    }
}
