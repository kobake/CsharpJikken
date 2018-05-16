# Vs2015-no-nuget
Visual Studio 2017 の .NET Core プロジェクトを Linux 上の dotnet で実行できるか試すための実験場。

## How to build and launch by dotnet
### Setup dotnet
```
# yum install -y libunwind libicu
# rpm --import https://packages.microsoft.com/keys/microsoft.asc
# vi /etc/yum.repos.d/dotnetdev.repo
[packages-microsoft-com-prod]
name=packages-microsoft-com-prod
baseurl=https://packages.microsoft.com/yumrepos/microsoft-rhel7.3-prod
enabled=1
gpgcheck=1
gpgkey=https://packages.microsoft.com/keys/microsoft.asc

# yum -y install dotnet-sdk-2.1.4
```

### Build and launch the project by mono
```
$ cd {PROJECT_DIR}
$ dotnet restore
$ dotnet run
```
