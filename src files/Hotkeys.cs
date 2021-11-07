using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace onecheatss
{
	// Token: 0x02000004 RID: 4
	internal class Hotkeys
	{
		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow")]
		private static extern IntPtr 7TpIuX1TgsxJqje1UaaN();

		// Token: 0x0600000F RID: 15
		[DllImport("user32.dll", EntryPoint = "ShowWindow")]
		private static extern bool jYt482SPyRRwpNGMwAbG(IntPtr hWnd, int nCmdShow);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000010 RID: 16 RVA: 0x000041B0 File Offset: 0x000023B0
		// (remove) Token: 0x06000011 RID: 17 RVA: 0x000041E8 File Offset: 0x000023E8
		private static event EventHandler<Hotkeys.HotKeyEventArgs> 5mJ54aDkajz0d4dw9GrKCOAZY
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Hotkeys.HotKeyEventArgs> eventHandler = Hotkeys.N3GEonI4O7swkbOqCgXdCOAZY;
				EventHandler<Hotkeys.HotKeyEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Hotkeys.HotKeyEventArgs> value2 = (EventHandler<Hotkeys.HotKeyEventArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Hotkeys.HotKeyEventArgs>>(ref Hotkeys.N3GEonI4O7swkbOqCgXdCOAZY, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Hotkeys.HotKeyEventArgs> eventHandler = Hotkeys.N3GEonI4O7swkbOqCgXdCOAZY;
				EventHandler<Hotkeys.HotKeyEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Hotkeys.HotKeyEventArgs> value2 = (EventHandler<Hotkeys.HotKeyEventArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Hotkeys.HotKeyEventArgs>>(ref Hotkeys.N3GEonI4O7swkbOqCgXdCOAZY, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004220 File Offset: 0x00002420
		static Hotkeys()
		{
			new Thread(delegate()
			{
				Application.Run(new Hotkeys.MessageWindow());
			})
			{
				Name = Encoding.UTF8.GetString(Convert.FromBase64String("SG90S2V5TWVzc2FnZVRocmVhZA==")),
				IsBackground = true
			}.Start();
		}

		// Token: 0x04000006 RID: 6
		private const int je5X0cQdEmurtdEXYQbyCOAZY = 0;

		// Token: 0x04000007 RID: 7
		private const int BMhHukFDQj3bCDUQaYaRCOAZY = 5;

		// Token: 0x04000008 RID: 8
		private static volatile Hotkeys.MessageWindow OM8g2DTZsbmnoyW6xY2fCOAZY;

		// Token: 0x04000009 RID: 9
		private static volatile IntPtr 7NWUTTppSnmzfUkpeBerCOAZY;

		// Token: 0x0400000A RID: 10
		private static ManualResetEvent 0gKfxfnDgnTMvvjAqNXJCOAZY = new ManualResetEvent(false);

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static EventHandler<Hotkeys.HotKeyEventArgs> N3GEonI4O7swkbOqCgXdCOAZY;

		// Token: 0x02000005 RID: 5
		private class MessageWindow : Form
		{
			// Token: 0x06000014 RID: 20 RVA: 0x00002EE6 File Offset: 0x000010E6
			public MessageWindow()
			{
				Hotkeys.OM8g2DTZsbmnoyW6xY2fCOAZY = this;
				Hotkeys.7NWUTTppSnmzfUkpeBerCOAZY = base.Handle;
				Hotkeys.0gKfxfnDgnTMvvjAqNXJCOAZY.Set();
			}

			// Token: 0x06000015 RID: 21 RVA: 0x0000427C File Offset: 0x0000247C
			protected override void WndProc(ref Message m)
			{
				bool flag = m.Msg == 786;
				if (flag)
				{
					Hotkeys.HotKeyEventArgs e = new Hotkeys.HotKeyEventArgs(m.LParam);
					Hotkeys.Hotkey.OnHotKeyPressed(e);
				}
				base.WndProc(ref m);
			}

			// Token: 0x06000016 RID: 22 RVA: 0x00002F10 File Offset: 0x00001110
			protected override void SetVisibleCore(bool value)
			{
				base.SetVisibleCore(false);
			}

			// Token: 0x0400000C RID: 12
			private const int WM_HOTKEY = 786;
		}

		// Token: 0x02000006 RID: 6
		[Flags]
		public enum KeyModifiers
		{
			// Token: 0x0400000E RID: 14
			Control = 2
		}

		// Token: 0x02000007 RID: 7
		public class HotKeyEventArgs : EventArgs
		{
			// Token: 0x06000017 RID: 23 RVA: 0x000042B8 File Offset: 0x000024B8
			public HotKeyEventArgs(IntPtr hotKeyParam)
			{
				uint num = (uint)hotKeyParam.ToInt64();
				this.Key = (Keys)((num & 4294901760U) >> 16);
				this.Modifiers = (Hotkeys.KeyModifiers)(num & 65535U);
			}

			// Token: 0x0400000F RID: 15
			public readonly Keys Key;

			// Token: 0x04000010 RID: 16
			public readonly Hotkeys.KeyModifiers Modifiers;
		}

		// Token: 0x02000008 RID: 8
		public class Initiate
		{
			// Token: 0x06000018 RID: 24 RVA: 0x000042F4 File Offset: 0x000024F4
			public static int RegisterHotKey(Keys key, Hotkeys.KeyModifiers modifiers)
			{
				Hotkeys.0gKfxfnDgnTMvvjAqNXJCOAZY.WaitOne();
				int num = Interlocked.Increment(ref Hotkeys.Initiate._id);
				Hotkeys.OM8g2DTZsbmnoyW6xY2fCOAZY.Invoke(new Hotkeys.Initiate.RegisterHotKeyDelegate(Hotkeys.Initiate.RegisterHotKeyInternal), new object[]
				{
					Hotkeys.7NWUTTppSnmzfUkpeBerCOAZY,
					num,
					(uint)modifiers,
					(uint)key
				});
				return num;
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002F1B File Offset: 0x0000111B
			private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
			{
				DLLImports.vGlAt5pc3XuNCxyKDZxY(hwnd, id, modifiers, key);
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00004368 File Offset: 0x00002568
			public static void InitiateHotKeys()
			{
				Hotkeys.Initiate.RegisterHotKey(Keys.F1, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D1, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D2, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D3, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D4, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D5, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D6, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D7, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D8, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D9, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Left, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Right, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Up, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Down, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.OemMinus, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Oemcomma, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Prior, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Next, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Insert, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.D0, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.J, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Home, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Delete, Hotkeys.KeyModifiers.Control);
				Hotkeys.5mJ54aDkajz0d4dw9GrKCOAZY += Hotkeys.Hotkey.HotKeys_HotKeyPressed;
			}

			// Token: 0x04000011 RID: 17
			private static int _id;

			// Token: 0x02000009 RID: 9
			// (Invoke) Token: 0x0600001D RID: 29
			private delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);
		}

		// Token: 0x0200000A RID: 10
		public class Hotkey
		{
			// Token: 0x06000020 RID: 32
			[DllImport("kernel32.dll")]
			private static extern IntPtr GetConsoleWindow();

			// Token: 0x06000021 RID: 33
			[DllImport("user32.dll")]
			public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

			// Token: 0x06000022 RID: 34 RVA: 0x00004460 File Offset: 0x00002660
			public static void hide()
			{
				bool flag = Variables.DiscordRPCC.isEnabled();
				if (flag)
				{
					IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
					Hotkeys.Hotkey.ShowWindow(mainWindowHandle, 0);
				}
				else
				{
					IntPtr mainWindowHandle2 = Process.GetCurrentProcess().MainWindowHandle;
					Hotkeys.Hotkey.ShowWindow(mainWindowHandle2, 1);
				}
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00002F28 File Offset: 0x00001128
			public static void OnHotKeyPressed(Hotkeys.HotKeyEventArgs e)
			{
				EventHandler<Hotkeys.HotKeyEventArgs> n3GEonI4O7swkbOqCgXdCOAZY = Hotkeys.N3GEonI4O7swkbOqCgXdCOAZY;
				if (n3GEonI4O7swkbOqCgXdCOAZY != null)
				{
					n3GEonI4O7swkbOqCgXdCOAZY(null, e);
				}
			}

			// Token: 0x06000024 RID: 36 RVA: 0x000044A4 File Offset: 0x000026A4
			public static void HotKeys_HotKeyPressed(object sender, Hotkeys.HotKeyEventArgs e)
			{
				Keys key = e.Key;
				Keys keys = key;
				if (keys <= Keys.J)
				{
					switch (keys)
					{
					case Keys.Prior:
						Variables.Weapon.scopeIndex++;
						Variables.Weapon.changeScope();
						break;
					case Keys.Next:
						Variables.Weapon.barrelIndex++;
						Variables.Weapon.changeBarrel();
						break;
					case Keys.End:
					case Keys.Select:
					case Keys.Print:
					case Keys.Execute:
					case Keys.Snapshot:
					case Keys.Delete:
					case Keys.Help:
						break;
					case Keys.Home:
					{
						IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
						Hotkeys.Hotkey.ShowWindow(mainWindowHandle, 0);
						break;
					}
					case Keys.Left:
						Variables.Weapon.setRandomness(-1);
						break;
					case Keys.Up:
						Variables.Settings.setSensitivity(1);
						break;
					case Keys.Right:
						Variables.Weapon.setRandomness(1);
						break;
					case Keys.Down:
						Variables.Settings.setSensitivity(-1);
						break;
					case Keys.Insert:
						Process.Start("steam://rungameid/252490");
						break;
					case Keys.D0:
						Variables.DiscordRPCC.setEnabled(!Variables.DiscordRPCC.isEnabled());
						break;
					case Keys.D1:
						Weapons.tT4L7CJ9ftBYmwbsoQae(1);
						break;
					case Keys.D2:
						Weapons.tT4L7CJ9ftBYmwbsoQae(2);
						break;
					case Keys.D3:
						Weapons.tT4L7CJ9ftBYmwbsoQae(3);
						break;
					case Keys.D4:
						Weapons.tT4L7CJ9ftBYmwbsoQae(4);
						break;
					case Keys.D5:
						Weapons.tT4L7CJ9ftBYmwbsoQae(5);
						break;
					case Keys.D6:
						Weapons.tT4L7CJ9ftBYmwbsoQae(6);
						break;
					case Keys.D7:
						Weapons.tT4L7CJ9ftBYmwbsoQae(7);
						break;
					case Keys.D8:
						Weapons.tT4L7CJ9ftBYmwbsoQae(8);
						break;
					case Keys.D9:
						Weapons.tT4L7CJ9ftBYmwbsoQae(9);
						break;
					default:
						if (keys == Keys.J)
						{
							Process.Start("https://discord.gg/uSpZZf3dHC");
						}
						break;
					}
				}
				else if (keys != Keys.F1)
				{
					if (keys != Keys.Oemcomma)
					{
						if (keys == Keys.OemMinus)
						{
							Variables.Settings.setFOV(-1);
						}
					}
					else
					{
						Variables.Settings.setFOV(1);
					}
				}
				else
				{
					Variables.Menu.setEnabled(!Variables.Menu.isEnabled());
				}
				Console.Clear();
				Display.7xWtDv29yU9uz0SrPuDh();
			}

			// Token: 0x04000012 RID: 18
			private const int SW_HIDE = 0;

			// Token: 0x04000013 RID: 19
			private const int SW_SHOW = 5;
		}
	}
}
