using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTest
{
    class Human
    {
        protected string name;
        protected string countory;

        public Human()
        {
            name = "佐藤";
            countory = "日本";
        }

        public Human(string name)
        {
            this.name = name;
        }

        public virtual void SelfIntroduction()
        {
            Console.Out.WriteLine(name + "です。出身地は" + countory + "です。");
        }
    }
}
