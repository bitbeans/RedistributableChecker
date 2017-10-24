using Microsoft.Win32;
using System;

namespace RedistributableChecker
{
    /// <summary>
    /// Microsoft Visual C++ Redistributable Package Versions
    /// </summary>
    public enum RedistributablePackageVersion
    {
        VC2017x86,
        VC2017x64,
    };

    /// <summary>
    ///
    /// </summary>
    /// <see cref="//https://stackoverflow.com/questions/12206314/detect-if-visual-c-redistributable-for-visual-studio-2012-is-installed"/>
    public static class RedistributablePackage
    {
        /// <summary>
        /// Check if 
        /// </summary>
        /// <param name="redistributableVersion">The package version to detect.</param>
        /// <returns><c>true</c> if the package is installed, otherwise <c>false</c></returns>
        public static bool IsInstalled(RedistributablePackageVersion redistributableVersion)
        {
            try
            {
                switch (redistributableVersion)
                {
                    case RedistributablePackageVersion.VC2017x86:
                        var parametersVc2017x86 = Registry.ClassesRoot.OpenSubKey(@"Installer\Dependencies\,,x86,14.0,bundle", false);
                        if (parametersVc2017x86 == null) return false;
                        var vc2017x86Version = parametersVc2017x86.GetValue("Version");
                        if (vc2017x86Version == null) return false;
                        if (((string)vc2017x86Version).StartsWith("14"))
                        {
                            return true;
                        }
                        break;
                    case RedistributablePackageVersion.VC2017x64:
                        var parametersVc2017x64 = Registry.ClassesRoot.OpenSubKey(@"Installer\Dependencies\,,amd64,14.0,bundle", false);
                        if (parametersVc2017x64 == null) return false;
                        var vc2017x64Version = parametersVc2017x64.GetValue("Version");
                        if (vc2017x64Version == null) return false;
                        if (((string)vc2017x64Version).StartsWith("14"))
                        {
                            return true;
                        }
                        break;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
