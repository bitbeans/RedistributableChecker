# RedistributableChecker

[![License](http://img.shields.io/badge/license-MIT-green.svg?style=flat-square)](https://github.com/bitbeans/RedistributableChecker/blob/master/LICENSE.md) [![NuGet Version](https://img.shields.io/nuget/v/RedistributableChecker.svg?style=flat-square)](https://www.nuget.org/packages/RedistributableChecker/)

### Can check for the following packages ###
- Microsoft Visual C++ Redistributable Package 2015 - 2019 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2015 - 2019 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2017 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2017 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2015 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2015 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2013 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2013 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2012 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2012 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2010 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2010 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2008 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2008 (x64) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2005 (x86) :heavy_check_mark:
- Microsoft Visual C++ Redistributable Package 2005 (x64) :heavy_check_mark:

```csharp 
using RedistributableChecker;

if (RedistributablePackage.IsInstalled(RedistributablePackageVersion.VC2017x64)) {
  //go on
}
```

Tested on: **Windows 10 (x64)**
   
Windows Registry Keys taken from: https://stackoverflow.com/a/34209692/4013391 :green_heart:


