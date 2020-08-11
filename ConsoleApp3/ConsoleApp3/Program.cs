using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        delegate float processDelegate(float a, float b);
        static float Add(float a,float b) {
            return a + b;
        }
        static void Main(string[] args)
        {
            processDelegate pD = new processDelegate(Program.Add);
            float i = 3.14f;
            float j = 2.0f;
            float result = pD(i, j);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
