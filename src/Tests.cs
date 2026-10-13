// ****************************************************************************
// Project:  Unit Tests.Common
// File:     Tests.cs
// Author:   Latency McLaughlin
// Date:     10/13/2026
// ****************************************************************************

#if NET45 || NET451 || NET452 || NET46 || NET461
using Newtonsoft.Json.Linq;
#else
using System.Text.Json;
#endif

namespace Unit_Tests.Common;

// ReSharper disable once UnusedMember.Global
// ReSharper disable once PartialTypeWithSinglePart
public partial class Tests : Base
{
    private const string LaunchSettings = "Properties\\launchSettings.json";

    /// <summary>
    ///     Initializes a new instance of the <see cref="Tests" /> class.
    ///     Sets up the environment variables from the launch settings file if it exists.
    /// </summary>
    /// <param name="console">The test output helper for logging.</param>
    public Tests(ITestOutputHelper console) : base(console)
    {
        if (!File.Exists(LaunchSettings))
            return;

        #if NET45 || NET451 || NET452 || NET46 || NET461
        var variables = JObject.Parse(File.ReadAllText(LaunchSettings))["profiles"]!
                               .Children<JProperty>()
                               .SelectMany(profile => profile.Value.Children<JProperty>())
                               .Where(prop => prop.Name == "environmentVariables")
                               .SelectMany(prop => prop.Value.Children<JProperty>())
                               .Select(variable => new KeyValuePair<string, string>(variable.Name, variable.Value.ToString())).ToList();
        #else
        using var document = JsonDocument.Parse(File.ReadAllText(LaunchSettings));

        var variables = document.RootElement.GetProperty("profiles") //select a proper profile here
                                .EnumerateObject()
                                .SelectMany(profile => profile.Value.EnumerateObject())
                                .Where(prop => prop.Name == "environmentVariables")
                                .SelectMany(prop => prop.Value.EnumerateObject())
                                .Select(variable => new KeyValuePair<string, string>(variable.Name, variable.Value.ToString()))
                                .ToList();
        #endif

        foreach (var variable in variables)
            Environment.SetEnvironmentVariable(variable.Key ?? throw new InvalidOperationException("Environment variable key is null"), variable.Value ?? string.Empty);
    }
}