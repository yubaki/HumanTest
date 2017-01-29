using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTest
{
    class French : Human
    {
        public French(string name) : base (name)
        {
            countory = "France";
        }
        public override void SelfIntroduction()
        {
            Console.Out.WriteLine("Je m'appelle " + name + ". La " + countory + " est né.");
        }
    }
}
