Created with dotnet-cli

dotnet new sln
dotnet new console -n Bowling
dotnet sln add Bowling
dotnet new nunit -n Bowling.Test
dotnet sln add Bowling.Test
dotnet add ./Bowling.Test/Bowling.Test.csproj reference ./Bowling/Bowling.csproj

Kata: https://learn.madetech.com/katas/bowling/
