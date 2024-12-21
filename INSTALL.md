# GUIDE

https://github.com/isen-ng/homebrew-dotnet-sdk-versions?tab=readme-ov-file

## Command

```shell
brew tap isen-ng/dotnet-sdk-versions
brew install --cask <version>

dotnet --list-sdks
```

## Debug

1. Uninstall official `brew uninstall dotnet`

2. Debug path

```shell
echo $PATH
```

Make sure `/usr/local/share/dotnet` is in the output, if not add the folder to PATH.

```shell
export PATH="$PATH:/usr/local/share/dotnet"
```

## Example on Macbook M1 MacOS 15.1.1 (24B91)

```shell
➜  MyConsoleApp git:(main) ✗ dotnet --info
.NET SDK (reflecting any global.json):
 Version:   6.0.428
 Commit:    ef6f5ce48c

Runtime Environment:
 OS Name:     Mac OS X
 OS Version:  15.1
 OS Platform: Darwin
 RID:         osx-arm64
 Base Path:   /usr/local/share/dotnet/sdk/6.0.428/

Host:
  Version:      9.0.0
  Architecture: arm64
  Commit:       9d5a6a9aa4

.NET SDKs installed:
  6.0.428 [/usr/local/share/dotnet/sdk]
  7.0.410 [/usr/local/share/dotnet/sdk]
  9.0.101 [/usr/local/share/dotnet/sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 6.0.36 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 7.0.20 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 9.0.0 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 6.0.36 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]
  Microsoft.NETCore.App 7.0.20 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]
  Microsoft.NETCore.App 9.0.0 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]

Other architectures found:
  None

Environment variables:
  Not set

global.json file:
  /Users/duc.nguyen/Workspace/oss/c-sharp-dot-net-essential-training-2453257/global.json

Learn more:
  https://aka.ms/dotnet/info

Download .NET:
  https://aka.ms/dotnet/download
➜  MyConsoleApp git:(main) ✗

```
