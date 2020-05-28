// Decompiled with JetBrains decompiler
// Type: LauncherCS.DVar
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using System;

namespace LauncherCS
{
  public struct DVar
  {
    public string name;
    public string description;
    public bool isDecimal;
    public Decimal decimalMin;
    public Decimal decimalMax;
    public Decimal decimalIncrement;

    public DVar(string name, string description)
    {
      this.name = name;
      this.description = description;
      this.isDecimal = false;
      this.decimalMin = new Decimal(0);
      this.decimalMax = new Decimal(0);
      this.decimalIncrement = new Decimal(0);
    }

    public DVar(
      string name,
      string description,
      Decimal decimalMin,
      Decimal decimalMax,
      Decimal decimalIncrement)
    {
      this.name = name;
      this.description = description;
      this.isDecimal = true;
      this.decimalMin = decimalMin;
      this.decimalMax = decimalMax;
      this.decimalIncrement = decimalIncrement;
    }

    public DVar(string name, string description, Decimal decimalMin, Decimal decimalMax)
    {
      this.name = name;
      this.description = description;
      this.isDecimal = true;
      this.decimalMin = decimalMin;
      this.decimalMax = decimalMax;
      this.decimalIncrement = new Decimal(1);
    }
  }
}
