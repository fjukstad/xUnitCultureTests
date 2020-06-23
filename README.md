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
