using RedistributableChecker;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VC2017x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x64));
            Console.WriteLine("VC2017x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x86));
            Console.ReadLine();
        }
    }
}
