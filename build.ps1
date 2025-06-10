$ErrorActionPreference = "Stop"

dotnet tool restore
dotnet build

AddToPath .\bin\Debug\

