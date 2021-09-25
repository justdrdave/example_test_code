# capitalontap-demo-part2

API Test Automation

## Getting started

1. Install latest .Net Core 3.1 - <https://dotnet.microsoft.com/download> as well as the 3.1.102 SDK
2. Open a command window or powershell
3. Restore Dependancies. ```sh $ dotnet restore```
4. Run tests. ```sh $ dotnet test```

## Test Reports

Tests are logged to a .trx file which is the default Microsoft standard, these provide nice visual reports when viewed in Visual Studio, Azure DevOps or Visual Studio Code with the approprate plugin.

## CICD

Test will run in Azure DevOps using azure-pipelines.yml, tests will automaticly get logged as part of the test run
