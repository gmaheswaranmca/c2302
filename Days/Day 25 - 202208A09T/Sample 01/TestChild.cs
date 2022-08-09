using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDay06082022
{
    class TestChild
    {
        static void MainTestChild()
        {
            Child valueChild = new Child();
            valueChild.DisplayParent();
            valueChild.DisplayChild();
            Console.Read();
        }
    }
}
