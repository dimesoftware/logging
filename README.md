<center>
 <img src="assets/collect.svg" width="250" />
</center>

# Dime.Logging

Dime.Logging is a simple wrapper which abstracts logging implementations from logging definitions.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

This repository is split it in several projects. Each one has a very specific focus:

- Dime.Logging: definitions of the `ILogger` and `ILoggerAsync` interfaces.
- Dime.Logging.Log4Net: implementation of the loggers using Log4Net.

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.Logging:

`dotnet add package Dime.Logging.[{SubProjectName}]`

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)