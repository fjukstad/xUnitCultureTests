# .Net Core Localization

Tests pass when run with `dotnet test` but fail when run with `dotnet xunit`. Currently at xUnit `2.3.1`.

## Output with xUnit

`dotnet xunit`

    Detecting target frameworks in xUnitCulture.csproj...
    Building for framework netcoreapp2.0...
      xUnitCulture -> C:\Users\Georg\Desktop\xUnitCulture\bin\Debug\netcoreapp2.0\xUnitCulture.dll
    Running .NET Core 2.0.0 tests for framework netcoreapp2.0...
    xUnit.net Console Runner (64-bit .NET Core 4.6.00001.0)
      Discovering: xUnitCulture
      Discovered:  xUnitCulture
      Starting:    xUnitCulture
        xUnitCulture.UnitTest1.CheckGermanCulture [FAIL]
          Assert.Equal() Failure
                    ↓ (pos 0)
          Expected: Guten Tag
          Actual:   Hello
                    ↑ (pos 0)
          Stack Trace:
            C:\Users\Georg\Desktop\xUnitCulture\UnitTest1.cs(14,0): at xUnitCulture.UnitTest1.CheckGermanCulture()
        xUnitCulture.UnitTest1.CheckFrenchCulture [FAIL]
          Assert.Equal() Failure
                    ↓ (pos 0)
          Expected: Bonjour
          Actual:   Hello
                    ↑ (pos 0)
          Stack Trace:
            C:\Users\Georg\Desktop\xUnitCulture\UnitTest1.cs(22,0): at xUnitCulture.UnitTest1.CheckFrenchCulture()
      Finished:    xUnitCulture
    === TEST EXECUTION SUMMARY ===
       xUnitCulture  Total: 2, Errors: 0, Failed: 2, Skipped: 0, Time: 0,153s

## Output with dotnet test

`dotnet test`

    Build started, please wait...
    Build completed.
    
    Test run for C:\Users\Georg\Desktop\xUnitCulture\bin\Debug\netcoreapp2.0\xUnitCulture.dll(.NETCoreApp,Version=v2.0)
    Microsoft (R) Testausführungs-Befehlszeilentool Version 15.3.0-preview-20170628-02
    Copyright (c) Microsoft Corporation. Alle Rechte vorbehalten.
    
    Die Testausführung wird gestartet, bitte warten...
    [xUnit.net 00:00:00.3232283]   Discovering: xUnitCulture
    [xUnit.net 00:00:00.3934721]   Discovered:  xUnitCulture
    [xUnit.net 00:00:00.3976951]   Starting:    xUnitCulture
    [xUnit.net 00:00:00.5044358]   Finished:    xUnitCulture
    
    Tests gesamt: 2. Bestanden: 2. Fehler: 0. Übersprungen: 0.
    Der Testlauf war erfolgreich.
    Testausführungszeit: 0,9478 Sekunden