# Utilities.VerificationCode

[![GitHub](https://img.shields.io/github/license/ed555009/utilities-verificationcode)](LICENSE)
![Build Status](https://dev.azure.com/edwang/github/_apis/build/status/utilities-verificationcode?branchName=main)
[![Nuget](https://img.shields.io/nuget/v/Utilities.VerificationCode)](https://www.nuget.org/packages/Utilities.VerificationCode)

![Coverage](https://sonarcloud.io/api/project_badges/measure?project=utilities-verificationcode&metric=coverage)
![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=utilities-verificationcode&metric=alert_status)
![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=utilities-verificationcode&metric=reliability_rating)
![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=utilities-verificationcode&metric=security_rating)
![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=utilities-verificationcode&metric=vulnerabilities)


## Installation

```bash
dotnet add package Utilities.VerificationCode
```

## Add services(optional)

You can add the service to the DI container.

```csharp
using Utilities.VerificationCode.Interfaces;
using Utilities.VerificationCode.Services;

ConfigureServices(IServiceCollection services)
{
	// this injects as SINGLETON
	services.AddSingleton<IVerificationCodeService, VerificationCodeService>();
}
```

## Using service

### Simple usage

```csharp
using Utilities.VerificationCode.Services;

public class MyProcess
{
	public string Generate()
	{
		var verificationCodeService = new VerificationCodeService();

		return verificationCodeService.Generate();
	}
}
```

### Generate code with specific length

You can generate 2~8 digits code by specifying the length. (default is 6)

```csharp
using Utilities.VerificationCode.Services;

public class MyProcess
{
	public string Generate()
	{
		var verificationCodeService = new VerificationCodeService();

		return verificationCodeService.Generate(4); // generate 4 digits code
	}
}
```

### Use dependency injection

```csharp
using Utilities.VerificationCode.Interfaces;

public class MyProcess
{
	private readonly IVerificationCodeService _verificationCodeService;

	public MyProcess(IVerificationCodeService verificationCodeService) =>
		_vaultService = vaultService;

	public string Generate() =>
		_verificationCodeService.Generate();
}
```
