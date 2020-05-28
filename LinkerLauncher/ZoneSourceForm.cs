// Decompiled with JetBrains decompiler
// Type: LauncherCS.ZoneSourceForm
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
  public class ZoneSourceForm : Form
  {
    private IContainer components;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem ZoneSourceFileMenuItem;
    private ToolStripMenuItem ZoneSourceSaveCSVMenuItem;
    private SplitContainer ZoneSourcePanel;
    private GroupBox ZoneSourceMissingAssetsGroupBox;
    internal RichTextBox ZoneSourceMissingAssetsCSVList;
    private GroupBox ZoneSourceCSVGroupBox;
    internal RichTextBox ZoneSourceCSVList;
    private GroupBox ZoneSourceInfoGroupBox;
    private TextBox ZoneSourceInfoCSVTextBox;
    private Label ZoneSourceInfoCSVLabel;
    private TextBox ZoneSourceInfoModTextBox;
    private Label ZoneSourceInfoModLabel;
    private Button ZoneSourceBottomSaveButton;

    public ZoneSourceForm(string modName)
    {
      this.InitializeComponent();
      this.ZoneSourceInfoModTextBox.Text = modName;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.menuStrip1 = new MenuStrip();
      this.ZoneSourceFileMenuItem = new ToolStripMenuItem();
      this.ZoneSourceSaveCSVMenuItem = new ToolStripMenuItem();
      this.ZoneSourcePanel = new SplitContainer();
      this.ZoneSourceMissingAssetsGroupBox = new GroupBox();
      this.ZoneSourceMissingAssetsCSVList = new RichTextBox();
      this.ZoneSourceCSVGroupBox = new GroupBox();
      this.ZoneSourceBottomSaveButton = new Button();
      this.ZoneSourceCSVList = new RichTextBox();
      this.ZoneSourceInfoGroupBox = new GroupBox();
      this.ZoneSourceInfoCSVTextBox = new TextBox();
      this.ZoneSourceInfoCSVLabel = new Label();
      this.ZoneSourceInfoModTextBox = new TextBox();
      this.ZoneSourceInfoModLabel = new Label();
      this.menuStrip1.SuspendLayout();
      this.ZoneSourcePanel.Panel1.SuspendLayout();
      this.ZoneSourcePanel.Panel2.SuspendLayout();
      this.ZoneSourcePanel.SuspendLayout();
      this.ZoneSourceMissingAssetsGroupBox.SuspendLayout();
      this.ZoneSourceCSVGroupBox.SuspendLayout();
      this.ZoneSourceInfoGroupBox.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ZoneSourceFileMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(762, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      this.ZoneSourceFileMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ZoneSourceSaveCSVMenuItem
      });
      this.ZoneSourceFileMenuItem.Name = "ZoneSourceFileMenuItem";
      this.ZoneSourceFileMenuItem.Size = new Size(37, 20);
      this.ZoneSourceFileMenuItem.Text = "File";
      this.ZoneSourceSaveCSVMenuItem.Name = "ZoneSourceSaveCSVMenuItem";
      this.ZoneSourceSaveCSVMenuItem.Size = new Size(98, 22);
      this.ZoneSourceSaveCSVMenuItem.Text = "Save";
      this.ZoneSourceSaveCSVMenuItem.Click += new EventHandler(this.ZoneSourceSaveCSVMenuItem_Click);
      this.ZoneSourcePanel.Dock = DockStyle.Fill;
      this.ZoneSourcePanel.IsSplitterFixed = true;
      this.ZoneSourcePanel.Location = new Point(0, 24);
      this.ZoneSourcePanel.Name = "ZoneSourcePanel";
      this.ZoneSourcePanel.Panel1.Controls.Add((Control) this.ZoneSourceMissingAssetsGroupBox);
      this.ZoneSourcePanel.Panel2.Controls.Add((Control) this.ZoneSourceCSVGroupBox);
      this.ZoneSourcePanel.Size = new Size(762, 706);
      this.ZoneSourcePanel.SplitterDistance = 381;
      this.ZoneSourcePanel.TabIndex = 3;
      this.ZoneSourceMissingAssetsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.ZoneSourceMissingAssetsGroupBox.Controls.Add((Control) this.ZoneSourceMissingAssetsCSVList);
      this.ZoneSourceMissingAssetsGroupBox.Location = new Point(3, 46);
      this.ZoneSourceMissingAssetsGroupBox.Name = "ZoneSourceMissingAssetsGroupBox";
      this.ZoneSourceMissingAssetsGroupBox.Size = new Size(375, 657);
      this.ZoneSourceMissingAssetsGroupBox.TabIndex = 6;
      this.ZoneSourceMissingAssetsGroupBox.TabStop = false;
      this.ZoneSourceMissingAssetsGroupBox.Text = "Missing Assets";
      this.ZoneSourceMissingAssetsCSVList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.ZoneSourceMissingAssetsCSVList.BackColor = SystemColors.Info;
      this.ZoneSourceMissingAssetsCSVList.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ZoneSourceMissingAssetsCSVList.Location = new Point(6, 16);
      this.ZoneSourceMissingAssetsCSVList.Name = "ZoneSourceMissingAssetsCSVList";
      this.ZoneSourceMissingAssetsCSVList.Size = new Size(363, 632);
      this.ZoneSourceMissingAssetsCSVList.TabIndex = 3;
      this.ZoneSourceMissingAssetsCSVList.Text = "";
      this.ZoneSourceMissingAssetsCSVList.WordWrap = false;
      this.ZoneSourceCSVGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.ZoneSourceCSVGroupBox.Controls.Add((Control) this.ZoneSourceBottomSaveButton);
      this.ZoneSourceCSVGroupBox.Controls.Add((Control) this.ZoneSourceCSVList);
      this.ZoneSourceCSVGroupBox.Location = new Point(3, 46);
      this.ZoneSourceCSVGroupBox.Name = "ZoneSourceCSVGroupBox";
      this.ZoneSourceCSVGroupBox.Size = new Size(373, 657);
      this.ZoneSourceCSVGroupBox.TabIndex = 8;
      this.ZoneSourceCSVGroupBox.TabStop = false;
      this.ZoneSourceCSVGroupBox.Text = "Zone Source";
      this.ZoneSourceBottomSaveButton.Dock = DockStyle.Bottom;
      this.ZoneSourceBottomSaveButton.Location = new Point(3, 630);
      this.ZoneSourceBottomSaveButton.Name = "ZoneSourceBottomSaveButton";
      this.ZoneSourceBottomSaveButton.Size = new Size(367, 24);
      this.ZoneSourceBottomSaveButton.TabIndex = 3;
      this.ZoneSourceBottomSaveButton.Text = "Save";
      this.ZoneSourceBottomSaveButton.UseVisualStyleBackColor = true;
      this.ZoneSourceBottomSaveButton.Click += new EventHandler(this.ZoneSourceBottomSaveButton_Click);
      this.ZoneSourceCSVList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.ZoneSourceCSVList.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ZoneSourceCSVList.Location = new Point(6, 16);
      this.ZoneSourceCSVList.Name = "ZoneSourceCSVList";
      this.ZoneSourceCSVList.Size = new Size(361, 605);
      this.ZoneSourceCSVList.TabIndex = 2;
      this.ZoneSourceCSVList.Text = "";
      this.ZoneSourceCSVList.WordWrap = false;
      this.ZoneSourceInfoGroupBox.Controls.Add((Control) this.ZoneSourceInfoCSVTextBox);
      this.ZoneSourceInfoGroupBox.Controls.Add((Control) this.ZoneSourceInfoCSVLabel);
      this.ZoneSourceInfoGroupBox.Controls.Add((Control) this.ZoneSourceInfoModTextBox);
      this.ZoneSourceInfoGroupBox.Controls.Add((Control) this.ZoneSourceInfoModLabel);
      this.ZoneSourceInfoGroupBox.Dock = DockStyle.Top;
      this.ZoneSourceInfoGroupBox.Location = new Point(0, 24);
      this.ZoneSourceInfoGroupBox.Name = "ZoneSourceInfoGroupBox";
      this.ZoneSourceInfoGroupBox.Size = new Size(762, 40);
      this.ZoneSourceInfoGroupBox.TabIndex = 5;
      this.ZoneSourceInfoGroupBox.TabStop = false;
      this.ZoneSourceInfoGroupBox.Text = "Info";
      this.ZoneSourceInfoCSVTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.ZoneSourceInfoCSVTextBox.Location = new Point(284, 12);
      this.ZoneSourceInfoCSVTextBox.Multiline = true;
      this.ZoneSourceInfoCSVTextBox.Name = "ZoneSourceInfoCSVTextBox";
      this.ZoneSourceInfoCSVTextBox.ReadOnly = true;
      this.ZoneSourceInfoCSVTextBox.Size = new Size(472, 22);
      this.ZoneSourceInfoCSVTextBox.TabIndex = 21;
      this.ZoneSourceInfoCSVLabel.AutoSize = true;
      this.ZoneSourceInfoCSVLabel.Location = new Point(203, 16);
      this.ZoneSourceInfoCSVLabel.Name = "ZoneSourceInfoCSVLabel";
      this.ZoneSourceInfoCSVLabel.Size = new Size(75, 13);
      this.ZoneSourceInfoCSVLabel.TabIndex = 20;
      this.ZoneSourceInfoCSVLabel.Text = "CSV Location:";
      this.ZoneSourceInfoModTextBox.Location = new Point(47, 12);
      this.ZoneSourceInfoModTextBox.Multiline = true;
      this.ZoneSourceInfoModTextBox.Name = "ZoneSourceInfoModTextBox";
      this.ZoneSourceInfoModTextBox.ReadOnly = true;
      this.ZoneSourceInfoModTextBox.Size = new Size(150, 22);
      this.ZoneSourceInfoModTextBox.TabIndex = 19;
      this.ZoneSourceInfoModLabel.AutoSize = true;
      this.ZoneSourceInfoModLabel.Location = new Point(6, 16);
      this.ZoneSourceInfoModLabel.Name = "ZoneSourceInfoModLabel";
      this.ZoneSourceInfoModLabel.Size = new Size(31, 13);
      this.ZoneSourceInfoModLabel.TabIndex = 0;
      this.ZoneSourceInfoModLabel.Text = "Mod:";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(762, 730);
      this.Controls.Add((Control) this.ZoneSourceInfoGroupBox);
      this.Controls.Add((Control) this.ZoneSourcePanel);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MainMenuStrip = this.menuStrip1;
      this.MinimizeBox = false;
      this.Name = nameof (ZoneSourceForm);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Zone Source";
      this.Load += new EventHandler(this.LauncherZoneSourceForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ZoneSourcePanel.Panel1.ResumeLayout(false);
      this.ZoneSourcePanel.Panel2.ResumeLayout(false);
      this.ZoneSourcePanel.ResumeLayout(false);
      this.ZoneSourceMissingAssetsGroupBox.ResumeLayout(false);
      this.ZoneSourceCSVGroupBox.ResumeLayout(false);
      this.ZoneSourceInfoGroupBox.ResumeLayout(false);
      this.ZoneSourceInfoGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void LauncherZoneSourceForm_Load(object sender, EventArgs e)
    {
      string text = this.ZoneSourceInfoModTextBox.Text;
      string str1 = Path.Combine(Launcher.GetModDirectory(text, true), "mod.csv");
      string str2 = Path.Combine(Launcher.GetModDirectory(text, true), "missingasset.csv");
      this.ZoneSourceInfoCSVTextBox.Text = str1;
      if (!File.Exists(str1))
        File.Create(str1).Close();
      this.ZoneSourceCSVList.Lines = Launcher.LoadTextFile(str1);
      if (!File.Exists(str2))
        return;
      this.ZoneSourceMissingAssetsCSVList.Lines = Launcher.LoadTextFile(str2);
    }

    private void SaveCSV()
    {
      string text = this.ZoneSourceInfoModTextBox.Text;
      string str1 = Path.Combine(Launcher.GetModDirectory(text, true), "mod.csv");
      string str2 = Path.Combine(Launcher.GetModDirectory(text, true), "missingasset.csv");
      if (!File.Exists(str1))
        File.Create(str1).Close();
      Launcher.SaveTextFile(str1, this.ZoneSourceCSVList.Lines);
      if (File.Exists(str2))
        Launcher.SaveTextFile(str2, this.ZoneSourceMissingAssetsCSVList.Lines);
      this.Close();
    }

    private void ZoneSourceBottomSaveButton_Click(object sender, EventArgs e)
    {
      this.SaveCSV();
    }

    private void ZoneSourceSaveCSVMenuItem_Click(object sender, EventArgs e)
    {
      this.SaveCSV();
    }
  }
}
