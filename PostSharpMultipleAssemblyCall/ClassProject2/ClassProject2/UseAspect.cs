using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassProject1;

namespace ClassProject2
{
    public class UseAspect
    {
        [TestAspect]
        public void TestingAspect()
        {
            Console.Write("TestingAspect Called");

        }
    }
}
