# Introduction

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

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)