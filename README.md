# CsharpJikken
Visual Studio 2015 のプロジェクトを Linux 上の mono で実行できるか試すための実験場。

## Requirements
- mono or Visual Studio

## How to build by mono
```
$ wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
$ mono nuget.exe restore CsharpJikken.sln
$ xbuild CsharpJikken.sln
```

## How to launch .exe file by mono
```
$ mono CsharpJikken/bin/Debug/CsharpJikken.exe
```
