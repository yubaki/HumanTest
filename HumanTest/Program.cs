using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Humanクラスに各敬称クラスのインスタンスを生成する。
            Human[] testHumans = new Human[4];
            testHumans[0] = new Human();
            testHumans[1] = new American("Smith");
            testHumans[2] = new Chainese("王");
            testHumans[3] = new French("Martin");

            foreach (Human human in testHumans)
            {
                human.SelfIntroduction();
            }
        }
    }
}
