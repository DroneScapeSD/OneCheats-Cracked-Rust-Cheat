using System;
using System.Threading;
using System.Windows.Forms;

namespace onecheatss
{
	// Token: 0x02000013 RID: 19
	internal class Recoil
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00006114 File Offset: 0x00004314
		private static bool jxm5H48wsEM0ZI1I8K2v(Keys key)
		{
			return ((int)DLLImports.rw1hdlHyYemibmUm8jx2((int)key) & 32768) != 0;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006138 File Offset: 0x00004338
		public static void fQEirOAu6Iefy7bxAHIQ()
		{
			for (;;)
			{
				bool flag = Variables.Menu.isEnabled() && !string.IsNullOrEmpty(Variables.Weapon.getName());
				if (flag)
				{
					while (Recoil.jxm5H48wsEM0ZI1I8K2v(Keys.LButton) && Recoil.jxm5H48wsEM0ZI1I8K2v(Keys.RButton))
					{
						for (int i = 0; i <= Variables.Weapon.getAmmo() - 1; i++)
						{
							bool flag2 = !Recoil.jxm5H48wsEM0ZI1I8K2v(Keys.LButton);
							if (flag2)
							{
								break;
							}
							Recoil.3d0kZ71s64I1BLVFwXA8(Variables.Weapon.isMuzzleBoost((double)Variables.Weapon.getShootingMilliSec()), Variables.Weapon.isMuzzleBoost(Variables.Weapon.getShotDelay(i)), (int)(((double)Variables.Weapon.getRecoilX(i) + Recoil.9aThiTIst0a5Bvn3tDdt(0.0, Variables.Weapon.getRandomness())) / 4.0 / Variables.Settings.getSensitivity() * Variables.Weapon.getScopeMulitplier() * Variables.Weapon.getBarrelMultiplier()), (int)(((double)Variables.Weapon.getRecoilY(i) + Recoil.9aThiTIst0a5Bvn3tDdt(0.0, Variables.Weapon.getRandomness())) / 4.0 / Variables.Settings.getSensitivity() * Variables.Weapon.getScopeMulitplier() * Variables.Weapon.getBarrelMultiplier()));
							DLLImports.tSCUmbIfJQ90xpb6ryiO(1, 0, 0, 0, 0);
						}
					}
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006278 File Offset: 0x00004478
		private static double 9aThiTIst0a5Bvn3tDdt(double minimum, double maximum)
		{
			Random random = new Random();
			return random.NextDouble() * (maximum - minimum) + minimum;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000062A0 File Offset: 0x000044A0
		private static void 3d0kZ71s64I1BLVFwXA8(double MS, double ControlledTime, int X, int Y)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= (int)ControlledTime; i++)
			{
				int num4 = i * X / (int)ControlledTime;
				int num5 = i * Y / (int)ControlledTime;
				int num6 = i * (int)ControlledTime / (int)ControlledTime;
				DLLImports.tSCUmbIfJQ90xpb6ryiO(1, num4 - num, num5 - num2, 0, 0);
				Recoil.FHBF8JdDjIEw3PmwJ9RL(num6 - num3);
				num = num4;
				num2 = num5;
				num3 = num6;
			}
			Recoil.FHBF8JdDjIEw3PmwJ9RL((int)MS - (int)ControlledTime);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000631C File Offset: 0x0000451C
		private static void FHBF8JdDjIEw3PmwJ9RL(int ms)
		{
			long num;
			DLLImports.3JQ54rpK5pxHAPu6Bz1D(out num);
			num /= 1000L;
			long num2;
			DLLImports.UUv1P9pAMYkRsyTwrVhA(out num2);
			long num3 = num2 / num + (long)ms;
			for (num2 = 0L; num2 < num3; num2 /= num)
			{
				DLLImports.UUv1P9pAMYkRsyTwrVhA(out num2);
			}
		}
	}
}
