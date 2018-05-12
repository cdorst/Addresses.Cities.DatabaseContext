# Addresses.Cities.DatabaseContext

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-cities-databasecontext.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/addresses-cities-databasecontext)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Cities.DatabaseContext.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Addresses.Cities.DatabaseContext)

## Description

EntityFrameworkCore database context for City entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Addresses.Cities](https://github.com/CDorst/Addresses.Cities) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-cities.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-cities) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Cities.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.Cities)
[CDorst.Addresses.StreetAddresses.DatabaseContext](https://github.com/CDorst/Addresses.StreetAddresses.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-streetaddresses-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-streetaddresses-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StreetAddresses.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StreetAddresses.DatabaseContext)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[Addresses.Cities.ApiController](https://github.com/CDorst/Addresses.Cities.ApiController) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-cities-apicontroller.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-cities-apicontroller) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Cities.ApiController.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.Cities.ApiController)
[Addresses.StateCities.DatabaseContext](https://github.com/CDorst/Addresses.StateCities.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecities-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-statecities-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCities.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StateCities.DatabaseContext)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Addresses.Cities.DatabaseContext](https://www.nuget.org/packages/CDorst.Addresses.Cities.DatabaseContext)

## Version

1.0.5

## Metaproject

Addresses.Cities.DatabaseContext is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

