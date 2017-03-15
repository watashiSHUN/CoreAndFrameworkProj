# CoreAndFrameworkProj

since it's a dotnet core web project targeting .net framework
ie the difference lies at this line: [`<TargetFramework>net461</TargetFramework>`](https://github.com/watashiSHUN/CoreAndFrameworkProj/blob/master/CoreAndFrameworkProj/CoreAndFrameworkProj.csproj#L4)

and because we are using `projectTypeGuids` and `<PackageReference Include="Microsoft.AspNetCore"...>` to
identify core projects, this repository is qualified.

However running `dotnet restore` will not work for old build system (.net framework)
