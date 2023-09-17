<div align="center">
  <h1>⚠️ This project is no longer maintained ⚠️</h1>
  <p>Use the capabilities of <b>Microsoft.Extensions.Logging</b> instead.</p>
</div>

<br/> 
<p align="center"><img src="assets/collect.svg?raw=true" width="350" alt="Logo"></p>

<div align="center">
<img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" /> 
<img src="https://img.shields.io/badge/License-MIT-brightgreen.svg?style=flat-square" />
</div>

<h1 align="center"> Dime.Logging</h1>

Dime.Logging is a simple wrapper which abstracts logging implementations from logging definitions.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

This repository is split it in several projects. Each one has a very specific focus:

- Dime.Logging: definitions of the `ILogger` and `ILoggerAsync` interfaces.
- Dime.Logging.Log4Net: implementation of the loggers using Log4Net.
- Dime.Logging.NetCore: a wrapper around `Microsoft.Extensions.Logging.ILogger<T>`.

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the NuGet package manager in Visual Studio or use the `dotnet add package` command. The packages are available in Dime Software' Azure Artifacts feed.

| Package | Version | Install |
| --- | --- | --- |
| Dime.Logging |[![Dime.Logging package in Dime.Scheduler feed in Azure Artifacts](https://feeds.dev.azure.com/dimesoftware/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/f0c88f38-3fe8-447f-9050-fc70b66c670f/Badge)](https://dev.azure.com/dimesoftware/Dime.Scheduler%20V2/_packaging?_a=package&feed=a7b896fd-9cd8-4291-afe1-f223483d87f0&package=f0c88f38-3fe8-447f-9050-fc70b66c670f&preferRelease=true) | `dotnet add package Dime.Logging` |
| Dime.Logging.Log4Net | [![Dime.Logging.Log4net package in Dime.Scheduler feed in Azure Artifacts](https://feeds.dev.azure.com/dimesoftware/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/8537b9ca-c5c6-4401-a4b6-d6c66b14a72b/Badge)](https://dev.azure.com/dimesoftware/Dime.Scheduler%20V2/_packaging?_a=package&feed=a7b896fd-9cd8-4291-afe1-f223483d87f0&package=8537b9ca-c5c6-4401-a4b6-d6c66b14a72b&preferRelease=true)| `dotnet add package Dime.Logging.Log4Net` |
| Dime.Logging | [![Dime.Logging.Log4Net.AspNet package in Dime.Scheduler feed in Azure Artifacts](https://feeds.dev.azure.com/dimesoftware/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/b12f01c2-e982-483a-80a2-3970adfc1859/Badge)](https://dev.azure.com/dimesoftware/Dime.Scheduler%20V2/_packaging?_a=package&feed=a7b896fd-9cd8-4291-afe1-f223483d87f0&package=b12f01c2-e982-483a-80a2-3970adfc1859&preferRelease=true) | `dotnet add package Dime.Logging.Log4Net.AspNet` |
| Dime.Logging.NetCore | [![Dime.Logging.NETCore package in Dime.Scheduler feed in Azure Artifacts](https://feeds.dev.azure.com/dimesoftware/_apis/public/Packaging/Feeds/Dime.Scheduler/Packages/bce2e139-09be-4286-8eb2-208eccc6d8dd/Badge)](https://dev.azure.com/dimesoftware/Dime.Scheduler%20V2/_artifacts/feed/Dime.Scheduler/NuGet/Dime.Logging.NETCore/1.0.0) | `dotnet add package Dime.Logging.NetCore` |

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg?style=flat-square)
