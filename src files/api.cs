using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace onecheatss
{
	// Token: 0x0200000C RID: 12
	public class api
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00004694 File Offset: 0x00002894
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogIEFwcGxpY2F0aW9uIG5vdCBzZXR1cCBjb3JyZWN0bHkuIFBsZWFzZSB3YXRjaCB2aWRlbyBsaW5rIGZvdW5kIGluIFByb2dyYW0uY3M=")));
				Thread.Sleep(3500);
				Environment.Exit(0);
			}
			this.sYYmfR0Mmxmc0IBwXfFkCOAZY = name;
			this; .4; wRYhSAC80oObr9ho9iUCOAZY = ownerid;
			this.bIrffrtq2IbeGyOwGzEWCOAZY = secret;
			this.RXeVI8B99THowlJWFcipCOAZY = version;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004748 File Offset: 0x00002948
		public void mDLo5db7t8i7Cg7TKsl4()
		{
			this.qTRIBniUprr4ROxHnO7yCOAZY = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
			string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdA=="))));
			nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dmVy"))] = encryption.sFpNpJyfH9832qUlLGCX(this.RXeVI8B99THowlJWFcipCOAZY, this.bIrffrtq2IbeGyOwGzEWCOAZY, text);
			nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("ZW5ja2V5"))] = encryption.sFpNpJyfH9832qUlLGCX(this.qTRIBniUprr4ROxHnO7yCOAZY, this.bIrffrtq2IbeGyOwGzEWCOAZY, text);
			nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
			nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this,.4,wRYhSAC80oObr9ho9iUCOAZY));
			nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
			bool flag = text2 == Encoding.UTF8.GetString(Convert.FromBase64String("S2V5QXV0aF9JbnZhbGlk"));
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogIEFwcGxpY2F0aW9uIG5vdCBmb3VuZA==")));
				Thread.Sleep(3500);
				Environment.Exit(0);
			}
			text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.bIrffrtq2IbeGyOwGzEWCOAZY, text);
			api.response_structure response_structure = this; .3; IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
			bool success = response_structure.success;
			if (success)
			{
				this.ZJaZoKHccdao4WCN456HCOAZY = response_structure.sessionid;
				this; .0; ZwvjTTaivs9FbzFs2YBCOAZY = true;
			}
			else
			{
				bool flag2 = response_structure.message == Encoding.UTF8.GetString(Convert.FromBase64String("aW52YWxpZHZlcg=="));
				if (flag2)
				{
					Process.Start(response_structure.download);
					Environment.Exit(0);
				}
				else
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000049B0 File Offset: 0x00002BB0
		public void hrA7fFY2BDnLLmu0xnYV(string username, string pass, string key)
		{
			bool flag = !this; .0; ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("cmVnaXN0ZXI="))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dXNlcm5hbWU="))] = encryption.sFpNpJyfH9832qUlLGCX(username, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("cGFzcw=="))] = encryption.sFpNpJyfH9832qUlLGCX(pass, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("a2V5"))] = encryption.sFpNpJyfH9832qUlLGCX(key, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aHdpZA=="))] = encryption.sFpNpJyfH9832qUlLGCX(value, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this,.4,wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this; .3; IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
				else
				{
					this.PD18es2abCwzaNfRXbN6(response_structure.info);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004C2C File Offset: 0x00002E2C
		public void frmgIiRJxN2lZevvCdJZ(string username, string pass)
		{
			bool flag = !this; .0; ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("bG9naW4="))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dXNlcm5hbWU="))] = encryption.sFpNpJyfH9832qUlLGCX(username, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("cGFzcw=="))] = encryption.sFpNpJyfH9832qUlLGCX(pass, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aHdpZA=="))] = encryption.sFpNpJyfH9832qUlLGCX(value, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this,.4,wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this; .3; IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
				else
				{
					this.PD18es2abCwzaNfRXbN6(response_structure.info);
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004E80 File Offset: 0x00003080
		public void OI6ql7VQmHWX3ZopFUZx(string username, string key)
		{
			bool flag = !this; .0; ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("dXBncmFkZQ=="))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dXNlcm5hbWU="))] = encryption.sFpNpJyfH9832qUlLGCX(username, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("a2V5"))] = encryption.sFpNpJyfH9832qUlLGCX(key, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this,.4,wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this.3IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000509C File Offset: 0x0000329C
		public void nO4obCl6qzXTeyH7Vvub(string key)
		{
			bool flag = !this.0ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("bGljZW5zZQ=="))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("a2V5"))] = encryption.sFpNpJyfH9832qUlLGCX(key, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aHdpZA=="))] = encryption.sFpNpJyfH9832qUlLGCX(value, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.4wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this.3IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogIA==")) + response_structure.message);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
				else
				{
					this.PD18es2abCwzaNfRXbN6(response_structure.info);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000052D0 File Offset: 0x000034D0
		public void WBXqqFRzqGqhOLcAehPj()
		{
			bool flag = !this.0ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("YmFu"))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.4wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this.3IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005488 File Offset: 0x00003688
		public string lo0njCi4SR3J0oamqex5(string varid)
		{
			bool flag = !this.0ZwvjTTaivs9FbzFs2YBCOAZY;
			string result;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
				result = Encoding.UTF8.GetString(Convert.FromBase64String(""));
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("dmFy"))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dmFyaWQ="))] = encryption.sFpNpJyfH9832qUlLGCX(varid, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.4wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this.3IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					Thread.Sleep(3500);
					result = Encoding.UTF8.GetString(Convert.FromBase64String(""));
				}
				else
				{
					result = response_structure.message;
				}
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000056B0 File Offset: 0x000038B0
		public void klgjIfF2WHsdgLp7aaGn(string webid, string param)
		{
			bool flag = !this.0ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("d2ViaG9vaw=="))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("d2ViaWQ="))] = encryption.sFpNpJyfH9832qUlLGCX(webid, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("cGFyYW1z"))] = encryption.sFpNpJyfH9832qUlLGCX(param, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.4wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this.3IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000058A8 File Offset: 0x00003AA8
		public byte[] Xnh8dhR0bqJAkjyAHgeD(string fileid)
		{
			bool flag = !this.0ZwvjTTaivs9FbzFs2YBCOAZY;
			byte[] result;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3QuIEZpbGUgaXMgZW1wdHkgc2luY2Ugbm8gcmVxdWVzdCBjb3VsZCBiZSBtYWRlLg==")));
				result = new byte[0];
			}
			else
			{
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("ZmlsZQ=="))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("ZmlsZWlk"))] = encryption.sFpNpJyfH9832qUlLGCX(fileid, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.4wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.Yfr6xstxMoZtvDqHf6Jn(post_data);
				text2 = encryption.zG7qcOhKv0BoRigDockr(text2, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				api.response_structure response_structure = this.3IcuzRZfPrPUq56ddLJcCOAZY.vmcQkI6Mluj8BV9Ig3q3<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Cgog")) + response_structure.message);
					result = new byte[0];
				}
				else
				{
					result = encryption.ZSWKs0TiX8jEScrkBQvW(response_structure.contents);
				}
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005A9C File Offset: 0x00003C9C
		public void xPHLZp2OyCLQ7JIwEIG1(string message)
		{
			bool flag = !this.0ZwvjTTaivs9FbzFs2YBCOAZY;
			if (flag)
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogUGxlYXNlIGluaXR6YWxpemUgZmlyc3Q=")));
			}
			else
			{
				string text = encryption.IepaAGfOcfbW2omwvDPb(encryption.ZBgD4fUK6ObKyiXws7T8());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("dHlwZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("bG9n"))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("cGN1c2Vy"))] = encryption.sFpNpJyfH9832qUlLGCX(Environment.UserName, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bWVzc2FnZQ=="))] = encryption.sFpNpJyfH9832qUlLGCX(message, this.qTRIBniUprr4ROxHnO7yCOAZY, text);
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("c2Vzc2lvbmlk"))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.ZJaZoKHccdao4WCN456HCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("bmFtZQ=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.sYYmfR0Mmxmc0IBwXfFkCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("b3duZXJpZA=="))] = encryption.w4BKdRU4SAQ8zSLVNTrE(Encoding.Default.GetBytes(this.4wRYhSAC80oObr9ho9iUCOAZY));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String("aW5pdF9pdg=="))] = text;
				NameValueCollection post_data = nameValueCollection;
				api.Yfr6xstxMoZtvDqHf6Jn(post_data);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005C3C File Offset: 0x00003E3C
		private static string Yfr6xstxMoZtvDqHf6Jn(NameValueCollection post_data)
		{
			string @string;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9rZXlhdXRoLnVrL2FwaS8xLjAv")), post_data);
					@string = Encoding.Default.GetString(bytes);
				}
			}
			catch
			{
				Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CgogIENvbm5lY3Rpb24gZmFpbHVyZS4gUGxlYXNlIHRyeSBhZ2Fpbiwgb3IgY29udGFjdCB1cyBmb3IgaGVscC4=")));
				Thread.Sleep(3500);
				Environment.Exit(0);
				@string = Encoding.UTF8.GetString(Convert.FromBase64String("bm90aGluZw=="));
			}
			return @string;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002F58 File Offset: 0x00001158
		private void PD18es2abCwzaNfRXbN6(api.user_data_structure data)
		{
			this.1mmlmG7QZu0Py8h0XVZhCOAZY.username = data.username;
			this.1mmlmG7QZu0Py8h0XVZhCOAZY.ip = data.ip;
			this.1mmlmG7QZu0Py8h0XVZhCOAZY.subscriptions = data.subscriptions;
		}

		// Token: 0x04000015 RID: 21
		public string sYYmfR0Mmxmc0IBwXfFkCOAZY;

		// Token: 0x04000016 RID: 22
		public string 4wRYhSAC80oObr9ho9iUCOAZY;

		// Token: 0x04000017 RID: 23
		public string bIrffrtq2IbeGyOwGzEWCOAZY;

		// Token: 0x04000018 RID: 24
		public string RXeVI8B99THowlJWFcipCOAZY;

		// Token: 0x04000019 RID: 25
		private string ZJaZoKHccdao4WCN456HCOAZY;

		// Token: 0x0400001A RID: 26
		private string qTRIBniUprr4ROxHnO7yCOAZY;

		// Token: 0x0400001B RID: 27
		private bool 0ZwvjTTaivs9FbzFs2YBCOAZY;

		// Token: 0x0400001C RID: 28
		public api.user_data_class 1mmlmG7QZu0Py8h0XVZhCOAZY = new api.user_data_class();

		// Token: 0x0400001D RID: 29
		private json_wrapper 3IcuzRZfPrPUq56ddLJcCOAZY = new json_wrapper(new api.response_structure());

		// Token: 0x0200000D RID: 13
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000036 RID: 54 RVA: 0x00002F91 File Offset: 0x00001191
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00002F99 File Offset: 0x00001199
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00002FA2 File Offset: 0x000011A2
			// (set) Token: 0x06000039 RID: 57 RVA: 0x00002FAA File Offset: 0x000011AA
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002FB3 File Offset: 0x000011B3
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002FBB File Offset: 0x000011BB
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002FC4 File Offset: 0x000011C4
			// (set) Token: 0x0600003D RID: 61 RVA: 0x00002FCC File Offset: 0x000011CC
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00002FD5 File Offset: 0x000011D5
			// (set) Token: 0x0600003F RID: 63 RVA: 0x00002FDD File Offset: 0x000011DD
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00002FE6 File Offset: 0x000011E6
			// (set) Token: 0x06000041 RID: 65 RVA: 0x00002FEE File Offset: 0x000011EE
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00002FF7 File Offset: 0x000011F7
			// (set) Token: 0x06000043 RID: 67 RVA: 0x00002FFF File Offset: 0x000011FF
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }
		}

		// Token: 0x0200000E RID: 14
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00003008 File Offset: 0x00001208
			// (set) Token: 0x06000046 RID: 70 RVA: 0x00003010 File Offset: 0x00001210
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000047 RID: 71 RVA: 0x00003019 File Offset: 0x00001219
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00003021 File Offset: 0x00001221
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000049 RID: 73 RVA: 0x0000302A File Offset: 0x0000122A
			// (set) Token: 0x0600004A RID: 74 RVA: 0x00003032 File Offset: 0x00001232
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x0200000F RID: 15
		public class user_data_class
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600004C RID: 76 RVA: 0x0000303B File Offset: 0x0000123B
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00003043 File Offset: 0x00001243
			public string username { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600004E RID: 78 RVA: 0x0000304C File Offset: 0x0000124C
			// (set) Token: 0x0600004F RID: 79 RVA: 0x00003054 File Offset: 0x00001254
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000050 RID: 80 RVA: 0x0000305D File Offset: 0x0000125D
			// (set) Token: 0x06000051 RID: 81 RVA: 0x00003065 File Offset: 0x00001265
			public string ip { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class Data
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000053 RID: 83 RVA: 0x0000306E File Offset: 0x0000126E
			// (set) Token: 0x06000054 RID: 84 RVA: 0x00003076 File Offset: 0x00001276
			public string subscription { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000055 RID: 85 RVA: 0x0000307F File Offset: 0x0000127F
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00003087 File Offset: 0x00001287
			public string expiry { get; set; }
		}
	}
}
