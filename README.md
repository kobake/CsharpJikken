# CsharpJikken
Visual Studio 2015 のプロジェクトを Linux 上の mono で実行できるか試すための実験場。

## Requirements
- mono or Visual Studio

## How to build and launch by mono
```
$ cd {SOLUTION_DIR}
$ wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
$ mono nuget.exe restore CsharpJikken.sln
$ xbuild CsharpJikken.sln
$ mono CsharpJikken/bin/Debug/CsharpJikken.exe
```

## How to build and launch by dotnet
```
$ cd {PROJECT_DIR}
$ dotnet restore
$ dotnet run
```
