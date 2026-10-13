## Navigation
* [Usage](#usage)

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
