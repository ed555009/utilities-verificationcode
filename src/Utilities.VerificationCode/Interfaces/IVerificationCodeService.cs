namespace Utilities.VerificationCode.Interfaces
{
	/// <summary>
	/// Represents a service for generating verification codes.
	/// </summary>
	public interface IVerificationCodeService
	{
		/// <summary>
		/// Generates a verification code of the specified length.
		/// </summary>
		/// <param name="length">The length of the verification code to generate. Default is 6.</param>
		/// <returns>A string representing the generated verification code.</returns>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown when the length is less than 2 or greater than 8.</exception>
		string Generate(int length = 6);
	}
}
