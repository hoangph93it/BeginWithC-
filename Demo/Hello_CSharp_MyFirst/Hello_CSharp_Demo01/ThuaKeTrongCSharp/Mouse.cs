using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.ThuaKeTrongCSharp
{
    class Mouse : Animal
    {
        public int Weight;
        public Mouse(int weight)
        {
            this.Weight = weight;
        }
        public Mouse() : this(100)
        {

        }
        public Mouse(string name, int weight) : base(name)
        {
            this.Weight = weight;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public void SetWeight(int weight)
        {
            this.Weight = weight;
        }
    }
}
