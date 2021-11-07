using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace onecheatss
{
	// Token: 0x02000011 RID: 17
	public static class encryption
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public static string w4BKdRU4SAQ8zSLVNTrE(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat(Encoding.UTF8.GetString(Convert.FromBase64String("ezA6eDJ9")), b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005D60 File Offset: 0x00003F60
		public static byte[] ZSWKs0TiX8jEScrkBQvW(string hex)
		{
			int length = hex.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public static string 8yRalYARBUEEjIGdIrSM(string plain_text, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] bytes = Encoding.Default.GetBytes(plain_text);
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.FlushFinalBlock();
						byte[] ba = memoryStream.ToArray();
						result = encryption.w4BKdRU4SAQ8zSLVNTrE(ba);
					}
				}
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005E88 File Offset: 0x00004088
		public static string ybGkQMPW11TxY560BlZ3(string cipher_text, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateDecryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] array = encryption.ZSWKs0TiX8jEScrkBQvW(cipher_text);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						@string = Encoding.Default.GetString(array2, 0, array2.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005F60 File Offset: 0x00004160
		public static string ZBgD4fUK6ObKyiXws7T8()
		{
			return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("LQ==")), StringComparison.Ordinal));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003090 File Offset: 0x00001290
		public static string IepaAGfOcfbW2omwvDPb(string r)
		{
			return encryption.w4BKdRU4SAQ8zSLVNTrE(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)));
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005FB4 File Offset: 0x000041B4
		public static string sFpNpJyfH9832qUlLGCX(string message, string enc_key, string iv)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.IepaAGfOcfbW2omwvDPb(enc_key).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.IepaAGfOcfbW2omwvDPb(iv).Substring(0, 16));
			return encryption.8yRalYARBUEEjIGdIrSM(message, bytes, bytes2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006004 File Offset: 0x00004204
		public static string zG7qcOhKv0BoRigDockr(string message, string enc_key, string iv)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.IepaAGfOcfbW2omwvDPb(enc_key).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.IepaAGfOcfbW2omwvDPb(iv).Substring(0, 16));
			return encryption.ybGkQMPW11TxY560BlZ3(message, bytes, bytes2);
		}
	}
}
