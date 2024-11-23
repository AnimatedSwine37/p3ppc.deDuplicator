# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/p3ppc.deDuplicator/*" -Force -Recurse
dotnet publish "./p3ppc.deDuplicator.csproj" -c Release -o "$env:RELOADEDIIMODS/p3ppc.deDuplicator" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location