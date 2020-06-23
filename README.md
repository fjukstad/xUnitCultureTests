# .Net Core Localization

Tests pass when run with `dotnet test` on Windows, but fail on Ubuntu 20.04,
both with `dotnet` version `3.1.301`.

# Reproduce

```
dotnet test
```

or simply try to build the docker image which runs the tests

```
docker build -t cultures .
```

# Results

# Windows

```
> dotnet test
Test run for C:\...\xUnitCultureTests\bin\Debug\netcoreapp3.1\xUnitCulture.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.6.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 3
     Passed: 3
 Total time: 4.0919 Seconds
```

# Ubuntu/Linux

```
$ dotnet test
Test run for /mnt/c/.../xUnityCultureTests/bin/Debug/netcoreapp3.1/xUnitCulture.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.6.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:02.33]     xUnitCulture.UnitTest1.CheckNorwegianCulture [FAIL]
  X xUnitCulture.UnitTest1.CheckNorwegianCulture [9ms]
  Error Message:
   Assert.Equal() Failure
            ↓ (pos 2)
Expected: Hei
Actual:   Hello
            ↑ (pos 2)
  Stack Trace:
     at xUnitCulture.UnitTest1.CheckNorwegianCulture() in /mnt/.../xUnitCultureTests/UnitTest1.cs:line 30

Test Run Failed.
Total tests: 3
     Passed: 2
     Failed: 1
 Total time: 5.8314 Seconds
```
