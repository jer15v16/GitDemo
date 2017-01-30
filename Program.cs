using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var version = new Version();

            Console.WriteLine(version.GetVersion());
            Console.ReadLine();
        }
    }
}
