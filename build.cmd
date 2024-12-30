@ECHO OFF

dotnet tool restore
dotnet build -- %*

AddToPath .\bin\Debug\
