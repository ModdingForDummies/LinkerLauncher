// Decompiled with JetBrains decompiler
// Type: LauncherCS.CreateModForm
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LauncherCS
{
  public class CreateModForm : Form
  {
    private IContainer components;
    private GroupBox NewModGroupBox;
    private Label NewModNameLabel;
    private TextBox NewModNameTextBox;
    private Button NewModCreateButton;

    public CreateModForm()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CreateModForm));
      this.NewModGroupBox = new GroupBox();
      this.NewModCreateButton = new Button();
      this.NewModNameTextBox = new TextBox();
      this.NewModNameLabel = new Label();
      this.NewModGroupBox.SuspendLayout();
      this.SuspendLayout();
      this.NewModGroupBox.Controls.Add((Control) this.NewModCreateButton);
      this.NewModGroupBox.Controls.Add((Control) this.NewModNameTextBox);
      this.NewModGroupBox.Controls.Add((Control) this.NewModNameLabel);
      this.NewModGroupBox.Location = new Point(12, 12);
      this.NewModGroupBox.Name = "NewModGroupBox";
      this.NewModGroupBox.Size = new Size(260, 71);
      this.NewModGroupBox.TabIndex = 0;
      this.NewModGroupBox.TabStop = false;
      this.NewModGroupBox.Text = "New Mod";
      this.NewModCreateButton.Location = new Point(124, 42);
      this.NewModCreateButton.Name = "NewModCreateButton";
      this.NewModCreateButton.Size = new Size(130, 23);
      this.NewModCreateButton.TabIndex = 2;
      this.NewModCreateButton.Text = "Create Mod";
      this.NewModCreateButton.UseVisualStyleBackColor = true;
      this.NewModCreateButton.Click += new EventHandler(this.NewModCreateButton_Click);
      this.NewModNameTextBox.Location = new Point(106, 16);
      this.NewModNameTextBox.Name = "NewModNameTextBox";
      this.NewModNameTextBox.Size = new Size(148, 20);
      this.NewModNameTextBox.TabIndex = 1;
      this.NewModNameLabel.AutoSize = true;
      this.NewModNameLabel.Location = new Point(6, 19);
      this.NewModNameLabel.Name = "NewModNameLabel";
      this.NewModNameLabel.Size = new Size(94, 13);
      this.NewModNameLabel.TabIndex = 0;
      this.NewModNameLabel.Text = "Mod Folder Name:";
      this.AcceptButton = (IButtonControl) this.NewModCreateButton;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(284, 95);
      this.Controls.Add((Control) this.NewModGroupBox);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (CreateModForm);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Create a New Mod";
      this.NewModGroupBox.ResumeLayout(false);
      this.NewModGroupBox.PerformLayout();
      this.ResumeLayout(false);
    }

    private void NewModCreateButton_Click(object sender, EventArgs e)
    {
      if (this.NewModNameTextBox.Text == null || !(this.NewModNameTextBox.Text != ""))
      {
        int num1 = (int) MessageBox.Show("Mod folder name is invalid.", "Error");
      }
      else
      {
        string text = this.NewModNameTextBox.Text;
        string path = Path.Combine(Launcher.GetModsDirectory(), text);
        if (Directory.Exists(path))
        {
          int num2 = (int) MessageBox.Show("Mod folder already exists\nwith name: " + text, "Error");
          this.NewModNameTextBox.Text = "";
        }
        else
        {
          Directory.CreateDirectory(path);
          File.Create(path + "/mod.csv").Close();
          this.Close();
          Launcher.TheLauncherForm.SetLauncherTab(LauncherForm.LauncherTabType.Mods);
          Launcher.TheLauncherForm.SetModSelection(text, true);
        }
      }
    }
  }
}
