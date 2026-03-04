dotnet new classlib -n UseCases
dotnet add reference ../UseCases/UseCases.csproj

tạo thu muc test
dotnet new xunit -n [folderName]

chay test: dotnet test tai thu muc .sln

dotnet clean
dotnet build
