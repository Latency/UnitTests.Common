// ****************************************************************************
// Project:  Unit Tests.Common
// File:     Base.cs
// Author:   Latency McLaughlin
// Date:     10/13/2026
// ****************************************************************************

namespace Unit_Tests.Common;

/// <summary>
///     Primary Constructor
/// </summary>
/// <param name="console"></param>
public abstract class Base(ITestOutputHelper console)
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected readonly ITestOutputHelper Console = console;
}