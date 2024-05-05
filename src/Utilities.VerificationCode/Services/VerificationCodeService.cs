using System;
using Utilities.VerificationCode.Interfaces;

namespace Utilities.VerificationCode.Services
{
	public class VerificationCodeService : IVerificationCodeService
	{
		public string Generate(int length = 6)
		{
			if (length < 2 || length > 8)
				throw new ArgumentOutOfRangeException(nameof(length), "Length must be between 2 and 8");

			var max = (int)Math.Pow(10, length);
			var random = new Random(Guid.NewGuid().GetHashCode());

			return random.Next(1, max - 1).ToString($"D{length}");
		}
	}
}
