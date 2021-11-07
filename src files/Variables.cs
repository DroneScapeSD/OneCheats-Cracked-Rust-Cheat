using System;

namespace onecheatss
{
	// Token: 0x02000014 RID: 20
	internal class Variables
	{
		// Token: 0x02000015 RID: 21
		public class Menu
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600006B RID: 107 RVA: 0x000030DE File Offset: 0x000012DE
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000030E5 File Offset: 0x000012E5
			private static bool Enabled { get; set; }

			// Token: 0x0600006D RID: 109 RVA: 0x0000636C File Offset: 0x0000456C
			public static bool isEnabled()
			{
				return Variables.Menu.Enabled;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x000030ED File Offset: 0x000012ED
			public static void setEnabled(bool boolean)
			{
				Variables.Menu.Enabled = boolean;
			}
		}

		// Token: 0x02000016 RID: 22
		public class DiscordRPCC
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000070 RID: 112 RVA: 0x000030F7 File Offset: 0x000012F7
			// (set) Token: 0x06000071 RID: 113 RVA: 0x000030FE File Offset: 0x000012FE
			private static bool Enabled { get; set; }

			// Token: 0x06000072 RID: 114 RVA: 0x00006384 File Offset: 0x00004584
			public static bool isEnabled()
			{
				return Variables.DiscordRPCC.Enabled;
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00003106 File Offset: 0x00001306
			public static void setEnabled(bool boolean)
			{
				Variables.DiscordRPCC.Enabled = boolean;
			}
		}

		// Token: 0x02000017 RID: 23
		public class hideproc
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00003110 File Offset: 0x00001310
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00003117 File Offset: 0x00001317
			private static bool Enabled { get; set; }

			// Token: 0x06000077 RID: 119 RVA: 0x0000639C File Offset: 0x0000459C
			public static bool isEnabled()
			{
				return Variables.hideproc.Enabled;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x0000311F File Offset: 0x0000131F
			public static void setEnabled(bool boolean)
			{
				Variables.hideproc.Enabled = boolean;
			}
		}

		// Token: 0x02000018 RID: 24
		public class Weapon
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600007A RID: 122 RVA: 0x00003129 File Offset: 0x00001329
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00003130 File Offset: 0x00001330
			private static string Name { get; set; } = string.Empty;

			// Token: 0x0600007C RID: 124 RVA: 0x000063B4 File Offset: 0x000045B4
			public static string getName()
			{
				bool flag = !string.IsNullOrEmpty(Variables.Weapon.Name);
				string result;
				if (flag)
				{
					result = Variables.Weapon.Name;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00003138 File Offset: 0x00001338
			public static void setName(string newName)
			{
				Variables.Weapon.Name = newName;
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00003142 File Offset: 0x00001342
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00003149 File Offset: 0x00001349
			private static int Ammo { get; set; } = 0;

			// Token: 0x06000080 RID: 128 RVA: 0x000063E4 File Offset: 0x000045E4
			public static int getAmmo()
			{
				return Variables.Weapon.Ammo;
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00003151 File Offset: 0x00001351
			public static void setAmmo(int AmmoSize)
			{
				Variables.Weapon.Ammo = AmmoSize;
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000082 RID: 130 RVA: 0x0000315B File Offset: 0x0000135B
			// (set) Token: 0x06000083 RID: 131 RVA: 0x00003162 File Offset: 0x00001362
			private static int[,] ActiveRecoil { get; set; } = new int[1, 2];

			// Token: 0x06000084 RID: 132 RVA: 0x000063FC File Offset: 0x000045FC
			public static int getRecoilX(int Bullet)
			{
				return Variables.Weapon.ActiveRecoil[Bullet, 0];
			}

			// Token: 0x06000085 RID: 133 RVA: 0x0000641C File Offset: 0x0000461C
			public static int getRecoilY(int Bullet)
			{
				return Variables.Weapon.ActiveRecoil[Bullet, 1];
			}

			// Token: 0x06000086 RID: 134 RVA: 0x0000316A File Offset: 0x0000136A
			public static void setRecoilPattern(int[,] Pattern)
			{
				Variables.Weapon.ActiveRecoil = Pattern;
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00003174 File Offset: 0x00001374
			// (set) Token: 0x06000088 RID: 136 RVA: 0x0000317B File Offset: 0x0000137B
			private static double[] Delay { get; set; } = new double[1];

			// Token: 0x06000089 RID: 137 RVA: 0x0000643C File Offset: 0x0000463C
			public static double getShotDelay(int Bullet)
			{
				return Variables.Weapon.Delay[Bullet];
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00003183 File Offset: 0x00001383
			public static void setShotDelay(double[] Delays)
			{
				Variables.Weapon.Delay = Delays;
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600008B RID: 139 RVA: 0x0000318D File Offset: 0x0000138D
			// (set) Token: 0x0600008C RID: 140 RVA: 0x00003194 File Offset: 0x00001394
			private static int ShootingMilliSec { get; set; } = 0;

			// Token: 0x0600008D RID: 141 RVA: 0x00006458 File Offset: 0x00004658
			public static int getShootingMilliSec()
			{
				return Variables.Weapon.ShootingMilliSec;
			}

			// Token: 0x0600008E RID: 142 RVA: 0x0000319C File Offset: 0x0000139C
			public static void setShootingMilliSec(int MilliSec)
			{
				Variables.Weapon.ShootingMilliSec = MilliSec;
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600008F RID: 143 RVA: 0x000031A6 File Offset: 0x000013A6
			// (set) Token: 0x06000090 RID: 144 RVA: 0x000031AD File Offset: 0x000013AD
			public static int scopeIndex { get; set; } = 0;

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000091 RID: 145 RVA: 0x000031B5 File Offset: 0x000013B5
			// (set) Token: 0x06000092 RID: 146 RVA: 0x000031BC File Offset: 0x000013BC
			private static string Scope { get; set; } = "None";

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000093 RID: 147 RVA: 0x000031C4 File Offset: 0x000013C4
			// (set) Token: 0x06000094 RID: 148 RVA: 0x000031CB File Offset: 0x000013CB
			private static double ScopeMulitplier { get; set; } = 1.0;

			// Token: 0x06000095 RID: 149 RVA: 0x00006470 File Offset: 0x00004670
			public static string getActiveScope()
			{
				bool flag = !string.IsNullOrEmpty(Variables.Weapon.Scope) && Variables.Weapon.Scope != "None";
				string result;
				if (flag)
				{
					result = Variables.Weapon.Scope;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x06000096 RID: 150 RVA: 0x000064B4 File Offset: 0x000046B4
			public static void changeScope()
			{
				switch (Variables.Weapon.scopeIndex)
				{
				case 0:
					Variables.Weapon.Scope = "None";
					Variables.Weapon.ScopeMulitplier = 1.0;
					break;
				case 1:
					Variables.Weapon.Scope = "Simple scope";
					Variables.Weapon.ScopeMulitplier = 0.8;
					break;
				case 2:
					Variables.Weapon.Scope = "Holo scope";
					Variables.Weapon.ScopeMulitplier = 1.2;
					break;
				case 3:
					Variables.Weapon.Scope = "8x scope";
					Variables.Weapon.ScopeMulitplier = 3.83721;
					break;
				case 4:
					Variables.Weapon.Scope = "16x scope";
					Variables.Weapon.ScopeMulitplier = 7.65116;
					Variables.Weapon.scopeIndex = -1;
					break;
				}
			}

			// Token: 0x06000097 RID: 151 RVA: 0x0000657C File Offset: 0x0000477C
			public static double getScopeMulitplier()
			{
				return Variables.Weapon.ScopeMulitplier;
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000098 RID: 152 RVA: 0x000031D3 File Offset: 0x000013D3
			// (set) Token: 0x06000099 RID: 153 RVA: 0x000031DA File Offset: 0x000013DA
			public static int barrelIndex { get; set; } = 0;

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600009A RID: 154 RVA: 0x000031E2 File Offset: 0x000013E2
			// (set) Token: 0x0600009B RID: 155 RVA: 0x000031E9 File Offset: 0x000013E9
			private static string Barrel { get; set; } = "None";

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600009C RID: 156 RVA: 0x000031F1 File Offset: 0x000013F1
			// (set) Token: 0x0600009D RID: 157 RVA: 0x000031F8 File Offset: 0x000013F8
			private static double BarrelMultiplier { get; set; } = 1.0;

			// Token: 0x0600009E RID: 158 RVA: 0x00006594 File Offset: 0x00004794
			public static string getActiveBarrel()
			{
				bool flag = !string.IsNullOrEmpty(Variables.Weapon.Barrel) && Variables.Weapon.Barrel != "None";
				string result;
				if (flag)
				{
					result = Variables.Weapon.Barrel;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x0600009F RID: 159 RVA: 0x000065D8 File Offset: 0x000047D8
			public static void changeBarrel()
			{
				switch (Variables.Weapon.barrelIndex)
				{
				case 0:
					Variables.Weapon.Barrel = "None";
					Variables.Weapon.BarrelMultiplier = 1.0;
					break;
				case 1:
					Variables.Weapon.Barrel = "Suppressor";
					Variables.Weapon.BarrelMultiplier = 0.8;
					break;
				case 2:
					Variables.Weapon.Barrel = "Muzzle boost";
					Variables.Weapon.BarrelMultiplier = 1.0;
					Variables.Weapon.MuzzleBoost = true;
					break;
				case 3:
					Variables.Weapon.Barrel = "Muzzle break";
					Variables.Weapon.BarrelMultiplier = 0.5;
					Variables.Weapon.barrelIndex = -1;
					Variables.Weapon.MuzzleBoost = false;
					break;
				}
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00006690 File Offset: 0x00004890
			public static double getBarrelMultiplier()
			{
				return Variables.Weapon.BarrelMultiplier;
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003200 File Offset: 0x00001400
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00003207 File Offset: 0x00001407
			private static bool MuzzleBoost { get; set; } = false;

			// Token: 0x060000A3 RID: 163 RVA: 0x000066A8 File Offset: 0x000048A8
			public static double isMuzzleBoost(double MilliSec)
			{
				bool muzzleBoost = Variables.Weapon.MuzzleBoost;
				double result;
				if (muzzleBoost)
				{
					result = MilliSec - MilliSec * 0.10000000149011612;
				}
				else
				{
					result = MilliSec;
				}
				return result;
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000320F File Offset: 0x0000140F
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x00003216 File Offset: 0x00001416
			private static double Randomness { get; set; } = 5.0;

			// Token: 0x060000A6 RID: 166 RVA: 0x000066D4 File Offset: 0x000048D4
			public static void setRandomness(int RandomnessIndex)
			{
				if (RandomnessIndex != -1)
				{
					if (RandomnessIndex == 1)
					{
						bool flag = Variables.Weapon.Randomness < 10.0;
						if (flag)
						{
							Variables.Weapon.Randomness += 1.0;
						}
					}
				}
				else
				{
					bool flag2 = 0.0 < Variables.Weapon.Randomness;
					if (flag2)
					{
						Variables.Weapon.Randomness -= 1.0;
					}
				}
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00006748 File Offset: 0x00004948
			public static double getRandomness()
			{
				return Variables.Weapon.Randomness;
			}
		}

		// Token: 0x02000019 RID: 25
		public class Settings
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000AA RID: 170 RVA: 0x0000321E File Offset: 0x0000141E
			// (set) Token: 0x060000AB RID: 171 RVA: 0x00003225 File Offset: 0x00001425
			private static double Sensitivity { get; set; } = 1.0;

			// Token: 0x060000AC RID: 172 RVA: 0x000067EC File Offset: 0x000049EC
			public static void setSensitivity(int SensitivityIndex)
			{
				if (SensitivityIndex != -1)
				{
					if (SensitivityIndex == 1)
					{
						bool flag = Variables.Settings.Sensitivity < 2.0;
						if (flag)
						{
							Variables.Settings.Sensitivity += 0.1;
						}
					}
				}
				else
				{
					bool flag2 = 0.2 < Variables.Settings.Sensitivity;
					if (flag2)
					{
						Variables.Settings.Sensitivity -= 0.1;
					}
				}
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00006860 File Offset: 0x00004A60
			public static double getSensitivity()
			{
				return Variables.Settings.Sensitivity;
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000AE RID: 174 RVA: 0x0000322D File Offset: 0x0000142D
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00003234 File Offset: 0x00001434
			private static int FOV { get; set; } = 90;

			// Token: 0x060000B0 RID: 176 RVA: 0x00006878 File Offset: 0x00004A78
			public static void setFOV(int FOVIndex)
			{
				if (FOVIndex != -1)
				{
					if (FOVIndex == 1)
					{
						bool flag = Variables.Settings.FOV < 90;
						if (flag)
						{
							Variables.Settings.FOV++;
						}
					}
				}
				else
				{
					bool flag2 = 71 < Variables.Settings.FOV;
					if (flag2)
					{
						Variables.Settings.FOV--;
					}
				}
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x000068D0 File Offset: 0x00004AD0
			public static int getFOV()
			{
				return Variables.Settings.FOV;
			}
		}
	}
}
