# This PowerShell script builds the FParsec NuGet packages. 
#
# Run this script from the VS2017 Command Prompt, e.g. with 
# powershell -File pack.ps1 -versionSuffix "" > pack.out.txt

Param(
  [string]$versionSuffix = "dev"
)

$ErrorActionPreference = 'Stop'

function invoke([string] $cmd) {
    echo ''
    echo $cmd
    Invoke-Expression $cmd
    if ($LastExitCode -ne 0) {
        throw "Non-zero exit code: $LastExitCode"
    }
}

$config = "Release"

$props = "-c $config -p:VersionSuffix=$versionSuffix"

invoke "dotnet clean FParsec.sln -c $config"

invoke "dotnet build FParsec.sln $props"
invoke "dotnet pack FParsec.sln $props -o ""$pwd\bin\nupkg"""

foreach ($tf in $('netcoreapp2.1', 'net45')) {
    invoke "dotnet run --no-build -p Test $props -f $tf"
}

invoke "dotnet run --no-build -p Test.BigData $props -f net45"
