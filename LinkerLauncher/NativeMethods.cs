// Decompiled with JetBrains decompiler
// Type: LauncherCS.NativeMethods
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using System;
using System.Runtime.InteropServices;

namespace LauncherCS
{
  internal class NativeMethods
  {
    public static readonly int WM_SHOWME = NativeMethods.RegisterWindowMessage(nameof (WM_SHOWME));
    public const int HWND_BROADCAST = 65535;

    [DllImport("user32", CharSet = CharSet.Unicode)]
    public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

    [DllImport("user32", CharSet = CharSet.Unicode)]
    public static extern int RegisterWindowMessage(string message);
  }
}
