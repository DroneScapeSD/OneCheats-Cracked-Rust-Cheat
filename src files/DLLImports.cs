using System;
using System.Runtime.InteropServices;

namespace onecheatss
{
	// Token: 0x02000003 RID: 3
	internal class DLLImports
	{
		// Token: 0x06000008 RID: 8
		[DllImport("user32.dll", EntryPoint = "mouse_event")]
		public static extern void tSCUmbIfJQ90xpb6ryiO(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x06000009 RID: 9
		[DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
		public static extern short rw1hdlHyYemibmUm8jx2(int vKey);

		// Token: 0x0600000A RID: 10
		[DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceCounter")]
		public static extern bool UUv1P9pAMYkRsyTwrVhA(out long lpPerformanceCount);

		// Token: 0x0600000B RID: 11
		[DllImport("Kernel32.dll", EntryPoint = "QueryPerformanceFrequency")]
		public static extern bool 3JQ54rpK5pxHAPu6Bz1D(out long lpFrequency);

		// Token: 0x0600000C RID: 12
		[DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
		public static extern bool vGlAt5pc3XuNCxyKDZxY(IntPtr hWnd, int id, uint fsModifiers, uint vk);
	}
}
