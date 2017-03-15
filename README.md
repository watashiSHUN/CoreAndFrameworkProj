# CoreAndFrameworkProj

since it's a dotnet core web project targeting .net framework
ie the difference lies at this line: [`<TargetFramework>net461</TargetFramework>`](https://github.com/watashiSHUN/CoreAndFrameworkProj/blob/master/CoreAndFrameworkProj/CoreAndFrameworkProj.csproj#L4)

and because we are using `projectTypeGuids` and `<PackageReference Include="Microsoft.AspNetCore"...>` to
identify core projects, this repository is qualified.

However running `dotnet restore` will not work for old build system (.net framework)

`D:\CoreAndFrameworkProj>dotnet restore
  Restoring packages for D:\CoreAndFrameworkProj\CoreAndFrameworkProj\CoreAndFrameworkProj.csproj...
  Generating MSBuild file D:\CoreAndFrameworkProj\CoreAndFrameworkProj\obj\CoreAndFrameworkProj.csproj.nuget.g.props.
  Generating MSBuild file D:\CoreAndFrameworkProj\CoreAndFrameworkProj\obj\CoreAndFrameworkProj.csproj.nuget.g.targets.
  Writing lock file to disk. Path: D:\CoreAndFrameworkProj\CoreAndFrameworkProj\obj\project.assets.json
  Restore completed in 784.26 ms for D:\CoreAndFrameworkProj\CoreAndFrameworkProj\CoreAndFrameworkProj.csproj.`

compared to:

`D:\CoreAndFrameworkProj>C:\Users\shucai\Desktop\NuGetCustomBuild.exe restore
MSBuild auto-detection: using msbuild version '15.1.548.43366' from 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\bin'.
Restoring NuGet package Newtonsoft.Json.9.0.1.
Adding package 'Newtonsoft.Json.9.0.1' to folder 'D:\CoreAndFrameworkProj\packages'
Added package 'Newtonsoft.Json.9.0.1' to folder 'D:\CoreAndFrameworkProj\packages'
Restoring packages for D:\CoreAndFrameworkProj\CoreAndFrameworkProj\CoreAndFrameworkProj.csproj...
Committing restore...
Generating MSBuild file D:\CoreAndFrameworkProj\CoreAndFrameworkProj\obj\CoreAndFrameworkProj.csproj.nuget.g.props.
Generating MSBuild file D:\CoreAndFrameworkProj\CoreAndFrameworkProj\obj\CoreAndFrameworkProj.csproj.nuget.g.targets.
Writing lock file to disk. Path: D:\CoreAndFrameworkProj\CoreAndFrameworkProj\obj\project.assets.json
Restore completed in 987.68 ms for D:\CoreAndFrameworkProj\CoreAndFrameworkProj\CoreAndFrameworkProj.csproj.`

IE potential solution:
use nuget to restore(need 4.0 + **msbuild15** to restore core project)
nuget4.0 also works for .net framework(3.5 also works, but 3.5 cannot restore core project)

dotnet build works...but since we need **msbuild15**, might as well just use msbuild15
