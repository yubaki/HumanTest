using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTest
{
    class American : Human
    {
        public American(string name) : base (name)
        {
            countory = "America";
        }
        public override void SelfIntroduction()
        {
            Console.Out.WriteLine("My name is " + name + ". I'm from " + countory + ".");
        }
    }
}
