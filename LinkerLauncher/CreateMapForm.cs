// Decompiled with JetBrains decompiler
// Type: LauncherCS.CreateMapForm
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LauncherCS
{
  public class CreateMapForm : Form
  {
    private IContainer components;
    private GroupBox MapTemplatesGroupBox;
    private ListBox MapTemplatesListBox;
    private GroupBox MapNameGroupBox;
    private TextBox MapNameTextBox;
    private Button MapCreateButtonOK;
    private Button MapCreateButtonCancel;
    private Launcher.MAP_TEMPLATE_TYPE cTemplateType;

    public CreateMapForm()
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
      this.components = (IContainer) new Container();
      this.MapTemplatesGroupBox = new GroupBox();
      this.MapTemplatesListBox = new ListBox();
      this.MapNameGroupBox = new GroupBox();
      this.MapNameTextBox = new TextBox();
      this.MapCreateButtonOK = new Button();
      this.MapCreateButtonCancel = new Button();
      this.MapTemplatesGroupBox.SuspendLayout();
      this.MapNameGroupBox.SuspendLayout();
      this.SuspendLayout();
      this.MapTemplatesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.MapTemplatesGroupBox.Controls.Add((Control) this.MapTemplatesListBox);
      this.MapTemplatesGroupBox.Location = new Point(12, 12);
      this.MapTemplatesGroupBox.Name = "MapTemplatesGroupBox";
      this.MapTemplatesGroupBox.Size = new Size(132, 135);
      this.MapTemplatesGroupBox.TabIndex = 0;
      this.MapTemplatesGroupBox.TabStop = false;
      this.MapTemplatesGroupBox.Text = "Map Templates";
      this.MapTemplatesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.MapTemplatesListBox.FormattingEnabled = true;
      this.MapTemplatesListBox.Location = new Point(6, 19);
      this.MapTemplatesListBox.Name = "MapTemplatesListBox";
      this.MapTemplatesListBox.Size = new Size(120, 108);
      this.MapTemplatesListBox.TabIndex = 0;
      this.MapTemplatesListBox.SelectedIndexChanged += new EventHandler(this.MapTemplatesListBox_SelectedIndexChanged);
      this.MapNameGroupBox.Controls.Add((Control) this.MapNameTextBox);
      this.MapNameGroupBox.Location = new Point(150, 12);
      this.MapNameGroupBox.Name = "MapNameGroupBox";
      this.MapNameGroupBox.Size = new Size(260, 49);
      this.MapNameGroupBox.TabIndex = 1;
      this.MapNameGroupBox.TabStop = false;
      this.MapNameGroupBox.Text = "Map Name";
      this.MapNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.MapNameTextBox.Location = new Point(6, 19);
      this.MapNameTextBox.MaxLength = 15;
      this.MapNameTextBox.Name = "MapNameTextBox";
      this.MapNameTextBox.Size = new Size(248, 20);
      this.MapNameTextBox.TabIndex = 0;
      this.MapCreateButtonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.MapCreateButtonOK.Enabled = false;
      this.MapCreateButtonOK.Location = new Point(246, 124);
      this.MapCreateButtonOK.Name = "MapCreateButtonOK";
      this.MapCreateButtonOK.Size = new Size(75, 23);
      this.MapCreateButtonOK.TabIndex = 2;
      this.MapCreateButtonOK.Text = "OK";
      this.MapCreateButtonOK.UseVisualStyleBackColor = true;
      this.MapCreateButtonOK.Click += new EventHandler(this.MapCreateButtonOK_Click);
      this.MapCreateButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.MapCreateButtonCancel.DialogResult = DialogResult.Cancel;
      this.MapCreateButtonCancel.Location = new Point(327, 124);
      this.MapCreateButtonCancel.Name = "MapCreateButtonCancel";
      this.MapCreateButtonCancel.Size = new Size(75, 23);
      this.MapCreateButtonCancel.TabIndex = 3;
      this.MapCreateButtonCancel.Text = "Cancel";
      this.MapCreateButtonCancel.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.MapCreateButtonOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.MapCreateButtonCancel;
      this.ClientSize = new Size(414, 159);
      this.Controls.Add((Control) this.MapCreateButtonCancel);
      this.Controls.Add((Control) this.MapCreateButtonOK);
      this.Controls.Add((Control) this.MapNameGroupBox);
      this.Controls.Add((Control) this.MapTemplatesGroupBox);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (CreateMapForm);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Create a New Map";
      this.Load += new EventHandler(this.LauncherCreateMapForm_Load);
      this.MapTemplatesGroupBox.ResumeLayout(false);
      this.MapNameGroupBox.ResumeLayout(false);
      this.MapNameGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.cTemplateType = Launcher.MAP_TEMPLATE_TYPE.SELECTION_UNDEFINED_TEMPLATE;
    }

    private void LauncherCreateMapForm_Load(object sender, EventArgs e)
    {
      this.MapTemplatesListBox.Items.Clear();
      this.MapTemplatesListBox.Items.AddRange((object[]) Launcher.GetMapTemplatesList());
      if (this.MapTemplatesListBox.Items.Count < 1)
      {
        this.Close();
        int num = (int) MessageBox.Show("There are no map templates.", "Error");
      }
      else
        this.MapTemplatesListBox.SelectedIndex = 0;
    }

    private void MapCreateButtonOK_Click(object sender, EventArgs e)
    {
      string text = this.MapNameTextBox.Text;
      if (text == null || !(text != ""))
      {
        int num = (int) MessageBox.Show("Map name is invalid.", "Error");
      }
      else
      {
        string mapTemplate = this.MapTemplatesListBox.Items[this.MapTemplatesListBox.SelectedIndex].ToString();
        string mapName = Launcher.FilterMP(this.MapNameTextBox.Text);
        bool flag = true;
        string[] mapFromTemplate = Launcher.CreateMapFromTemplate(mapTemplate, mapName, true);
        if (mapFromTemplate.Length != 0 && DialogResult.No == MessageBox.Show("Certain files would be overwritten:\n\n" + Launcher.StringArrayToString(mapFromTemplate) + "\nDo you want to continue?", "Should overwrite files?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
          flag = false;
        if (flag)
        {
          Launcher.CreateMapFromTemplate(mapTemplate, mapName);
          if (this.cTemplateType == Launcher.MAP_TEMPLATE_TYPE.SELECTION_MP_TEMPLATE)
            Launcher.TheLauncherForm.SetTabToMultiplayer();
          else
            Launcher.TheLauncherForm.SetTabToSingleplayer();
          Launcher.TheLauncherForm.SetMapSelection(text, true);
          Launcher.TheLauncherForm.SetLauncherTab(LauncherForm.LauncherTabType.Maps);
        }
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void MapTemplatesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      int selectedIndex = this.MapTemplatesListBox.SelectedIndex;
      this.MapCreateButtonOK.Enabled = selectedIndex >= 0;
      if (selectedIndex < 0)
      {
        this.cTemplateType = Launcher.MAP_TEMPLATE_TYPE.SELECTION_UNDEFINED_TEMPLATE;
      }
      else
      {
        string mapTemplate = this.MapTemplatesListBox.Items[selectedIndex].ToString();
        string name = Launcher.FilterPrefix(this.MapNameTextBox.Text, this.cTemplateType);
        if (Launcher.IsMultiplayerMapTemplate(mapTemplate))
        {
          this.cTemplateType = Launcher.MAP_TEMPLATE_TYPE.SELECTION_MP_TEMPLATE;
          this.MapNameTextBox.Text = Launcher.MakeMP(name);
        }
        else if (Launcher.IsZombieMapTemplate(mapTemplate))
        {
          this.cTemplateType = Launcher.MAP_TEMPLATE_TYPE.SELECTION_ZM_TEMPLATE;
          this.MapNameTextBox.Text = Launcher.MakeZM(name);
        }
        else
        {
          this.cTemplateType = Launcher.MAP_TEMPLATE_TYPE.SELECTION_CUSTOM_TEMPLATE;
          this.MapNameTextBox.Text = name;
        }
      }
    }
  }
}
