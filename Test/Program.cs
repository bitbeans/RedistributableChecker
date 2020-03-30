using RedistributableChecker;
using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("VC2005x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2005x64));
			Console.WriteLine("VC2005x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2005x86));
			Console.WriteLine("VC2008x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2008x64));
			Console.WriteLine("VC2008x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2008x86));
			Console.WriteLine("VC2010x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2010x64));
			Console.WriteLine("VC2010x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2010x86));
			Console.WriteLine("VC2012x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2012x64));
			Console.WriteLine("VC2012x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2012x86));
			Console.WriteLine("VC2013x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2013x64));
			Console.WriteLine("VC2013x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2013x86));
			Console.WriteLine("VC2015x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015x64));
			Console.WriteLine("VC2015x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015x86));
			Console.WriteLine("VC2017x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x64));
            Console.WriteLine("VC2017x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x86));
			Console.WriteLine("VC2015-2019x64 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015to2019x64));
			Console.WriteLine("VC2015-2019x86 installed {0}", RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2015to2019x86));
        }
    }
}
