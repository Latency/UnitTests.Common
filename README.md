# Unit Tests.Common
 
Dependency library for all XUnit projects named "Unit Test"
 
| | Description |
|---|---|
| CREATED BY: | [Latency McLaughlin] |
| UPDATED: | 10/14/2026 |
| FRAMEWORKS: | net45, net451, net452, net46, net461, net462, net47, net471, net472, net48, net481, netstandard2.0, netstandard2.1, net8.0, net9.0, net10.0, net11.0 |
| LANGUAGE: | [C#] preview |
| OUTPUT TYPE: | Library [API] |
| SUPPORTS: | [Visual Studio] |
| GFX SUBSYS: | [None] |
| TAGS: | [API], [.NET], [Unit Tests] |
| STATUS: | [![workflow-badge](https://github.com/Latency/UnitTests.Common/actions/workflows/status.yml/badge.svg)](https://github.com/Latency/UnitTests.Common/actions/workflows/status.yml) |
| LICENSE: | [![license-badge](https://img.shields.io/github/license/Latency/UnitTests.Common?style=plastic&logo=GitHub&logoColor=black&label=License&color=yellowgreen)](https://github.com/Latency/UnitTests.Common/blob/master/MIT-LICENSE.txt) |
| VERSION: | 1.0.0 |
<!-- VERSION: 1.0.0 -->
 
## Navigation
* [Usage](#usage)
* [Installation](#installation)
* [Donation](#donation)
* [License](#license)

---

## Usage

Derive your test classes from `Tests` (or `Base`) and pass the xUnit `ITestOutputHelper` through the constructor.
`Tests` also loads the environment variables from `Properties\launchSettings.json` (when present) before your tests run.

```csharp
using Unit_Tests.Common;

public class MyTests(ITestOutputHelper console) : Tests(console)
{
    [Fact]
    public void Example()
    {
        Console.WriteLine("Hello from a unit test");
        Assert.True(true);
    }
}
```

The package selects the matching test framework for each target framework:

* .NET Framework 4.5 - 4.7.1 and .NET Standard: xUnit 2.x
* .NET Framework 4.7.2+ and .NET 8+: xUnit v3
 
## Installation

This library can be installed from [NuGet].

## Donation
If you want to donate to my efforts on this project, please use the following link,

[![Donate via Paypal](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG.gif)](https://paypal.me/Latency2?country.x=US&locale.x=en_US)

   ## License

The source code for the site is licensed under the MIT license, which you can find in the [MIT-LICENSE].txt file.
  
---

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job.)

   [NuGet]: <https://github.com/Latency/UnitTests.Common/pkgs/nuget/Unit-Tests.Common/>
   [.NET]: <https://en.wikipedia.org/wiki/.NET_Framework/>
   [Visual Studio]: <https://en.wikipedia.org/wiki/Microsoft_Visual_Studio/>
   [Latency McLaughlin]: <https://www.linkedin.com/in/Latency/>
   [API]: <https://en.wikipedia.org/wiki/Application_programming_interface>
   [C#]: <https://en.wikipedia.org/wiki/C_Sharp_(programming_language)>
   [DLL]: <https://en.wikipedia.org/wiki/Dynamic-link_library>
   [MIT-License]: <http://choosealicense.com/licenses/mit/>
   [Unit Tests]: <https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-xunit>
