using System;
using System.Security.Cryptography;
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

			using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
			{
				byte[] data = new byte[4];
				rng.GetBytes(data);
				int value = BitConverter.ToInt32(data, 0);

				return (Math.Abs(value) % (max - 1)).ToString($"D{length}");
			}
		}
	}
}
