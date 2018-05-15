# CsharpJikken
Visual Studio 2015 のプロジェクトを Linux 上の mono で実行できるか試すための実験場。

## How to build and launch by mono
### Setup mono
```
# git clone https://github.com/mono/mono.git
# cd mono
# ./autogen.sh
# make
# make install
```

### Build and launch the project by mono
```
$ cd {SOLUTION_DIR}
$ wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
$ mono nuget.exe restore CsharpJikken.sln
$ xbuild CsharpJikken.sln
$ mono CsharpJikken/bin/Debug/CsharpJikken.exe
```
