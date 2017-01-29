using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTest
{
    class Chainese : Human
    {
        public Chainese(string name) : base (name)
        {
            countory = "中国";
        }
        public override void SelfIntroduction()
        {
            Console.Out.WriteLine("我的名字是 " + name + "。 我来自" + countory);
        }
    }
}
