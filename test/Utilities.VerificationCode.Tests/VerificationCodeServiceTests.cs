using Utilities.VerificationCode.Services;
using Xunit.Abstractions;

namespace Utilities.VerificationCode.Tests;

public class VerificationCodeServiceTests
{
	private readonly ITestOutputHelper _outputHelper;

	public VerificationCodeServiceTests(ITestOutputHelper outputHelper) =>
		_outputHelper = outputHelper;

	[Fact]
	public void Generate_ShouldSuccess()
	{
		// Given
		var service = new VerificationCodeService();

		// When
		var result = service.Generate();

		_outputHelper.WriteLine(result);

		// Then
		Assert.Equal(6, result.Length);
	}

	[Theory]
	[InlineData(2)]
	[InlineData(3)]
	[InlineData(4)]
	[InlineData(5)]
	[InlineData(7)]
	[InlineData(8)]
	public void Generate_WithGivenLength_ShouldSuccess(int length)
	{
		// Given
		var service = new VerificationCodeService();

		// When
		var result = service.Generate(length);

		_outputHelper.WriteLine(result);

		// Then
		Assert.Equal(length, result.Length);
	}

	[Theory]
	[InlineData(1)]
	[InlineData(9)]
	public void Generate_WithLenghtOutOfRange_ShouldThrow(int length)
	{
		// Given
		var service = new VerificationCodeService();

		// When
		var ex = Assert.Throws<ArgumentOutOfRangeException>(() => service.Generate(length));

		// Then
		Assert.NotNull(ex);
	}
}
