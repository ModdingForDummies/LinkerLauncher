// Decompiled with JetBrains decompiler
// Type: LauncherCS.BspOptionsForm
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LauncherCS
{
  public class BspOptionsForm : Form
  {
    private IContainer components;
    private GroupBox BspOptionsGroupBox;
    private Label BspOptionsExtraOptionsLabelText;
    private CheckBox BspOptionsDebugLightsCheckBox;
    private NumericUpDown BspOptionsBlockSizeNumericUpDown;
    private NumericUpDown BspOptionsSampleScaleNumericUpDown;
    private CheckBox BspOptionsSampleScaleCheckBox;
    private CheckBox BspOptionsBlockSizeCheckBox;
    private CheckBox BspOptionsOnlyEntsCheckBox;
    private Button BspOptionsButtonOK;
    private Button BspOptionsButtonCancel;
    private CheckBox BspOptionsLeakTest;
    private CheckBox BspOptionsDebugProbes;
    private TextBox BspOptionsExtraOptionsTextBox;

    public BspOptionsForm()
    {
      this.InitializeComponent();
    }

    private void BspOptionsBlockSizeCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.BspOptionsFormUpdate();
    }

    private void BspOptionsButtonCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void BspOptionsButtonOK_Click(object sender, EventArgs e)
    {
      Launcher.mapSettings.SetBoolean("bspoptions_onlyents", this.BspOptionsOnlyEntsCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("bspoptions_blocksize", this.BspOptionsBlockSizeCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("bspoptions_samplescale", this.BspOptionsSampleScaleCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("bspoptions_debuglightmaps", this.BspOptionsDebugLightsCheckBox.Checked);
      Launcher.mapSettings.SetDecimal("bspoptions_blocksize_val", this.BspOptionsBlockSizeNumericUpDown.Value);
      Launcher.mapSettings.SetDecimal("bspoptions_samplescale_val", this.BspOptionsSampleScaleNumericUpDown.Value);
      Launcher.mapSettings.SetBoolean("bspoptions_leaktest", this.BspOptionsLeakTest.Checked);
      Launcher.mapSettings.SetBoolean("bspoptions_debugprobes", this.BspOptionsDebugProbes.Checked);
      Launcher.mapSettings.SetString("bspoptions_extraoptions", this.BspOptionsExtraOptionsTextBox.Text);
      this.Close();
    }

    private void BspOptionsForm_Load(object sender, EventArgs e)
    {
      this.BspOptionsOnlyEntsCheckBox.Checked = Launcher.mapSettings.GetBoolean("bspoptions_onlyents", false);
      this.BspOptionsBlockSizeCheckBox.Checked = Launcher.mapSettings.GetBoolean("bspoptions_blocksize", false);
      this.BspOptionsSampleScaleCheckBox.Checked = Launcher.mapSettings.GetBoolean("bspoptions_samplescale", false);
      this.BspOptionsDebugLightsCheckBox.Checked = Launcher.mapSettings.GetBoolean("bspoptions_debuglightmaps", false);
      Launcher.SetNumericUpDownValue(this.BspOptionsBlockSizeNumericUpDown, Launcher.mapSettings.GetDecimal("bspoptions_blocksize_val"));
      Launcher.SetNumericUpDownValue(this.BspOptionsSampleScaleNumericUpDown, Launcher.mapSettings.GetDecimal("bspoptions_samplescale_val"));
      this.BspOptionsLeakTest.Checked = Launcher.mapSettings.GetBoolean("bspoptions_leaktest", true);
      this.BspOptionsDebugProbes.Checked = Launcher.mapSettings.GetBoolean("bspoptions_debugprobes", false);
      this.BspOptionsExtraOptionsTextBox.Text = Launcher.mapSettings.GetString("bspoptions_extraoptions");
      this.BspOptionsFormUpdate();
    }

    private void BspOptionsFormUpdate()
    {
      this.BspOptionsBlockSizeNumericUpDown.Enabled = this.BspOptionsBlockSizeCheckBox.Checked;
      this.BspOptionsSampleScaleNumericUpDown.Enabled = this.BspOptionsSampleScaleCheckBox.Checked;
    }

    private void BspOptionsSampleScaleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.BspOptionsFormUpdate();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.BspOptionsGroupBox = new GroupBox();
      this.BspOptionsLeakTest = new CheckBox();
      this.BspOptionsSampleScaleCheckBox = new CheckBox();
      this.BspOptionsExtraOptionsLabelText = new Label();
      this.BspOptionsDebugLightsCheckBox = new CheckBox();
      this.BspOptionsExtraOptionsTextBox = new TextBox();
      this.BspOptionsBlockSizeNumericUpDown = new NumericUpDown();
      this.BspOptionsSampleScaleNumericUpDown = new NumericUpDown();
      this.BspOptionsBlockSizeCheckBox = new CheckBox();
      this.BspOptionsOnlyEntsCheckBox = new CheckBox();
      this.BspOptionsButtonOK = new Button();
      this.BspOptionsButtonCancel = new Button();
      this.BspOptionsDebugProbes = new CheckBox();
      this.BspOptionsGroupBox.SuspendLayout();
      this.BspOptionsBlockSizeNumericUpDown.BeginInit();
      this.BspOptionsSampleScaleNumericUpDown.BeginInit();
      this.SuspendLayout();
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsDebugProbes);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsLeakTest);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsSampleScaleCheckBox);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsExtraOptionsLabelText);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsDebugLightsCheckBox);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsExtraOptionsTextBox);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsBlockSizeNumericUpDown);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsSampleScaleNumericUpDown);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsBlockSizeCheckBox);
      this.BspOptionsGroupBox.Controls.Add((Control) this.BspOptionsOnlyEntsCheckBox);
      this.BspOptionsGroupBox.Location = new Point(12, 12);
      this.BspOptionsGroupBox.Name = "BspOptionsGroupBox";
      this.BspOptionsGroupBox.Size = new Size(291, 157);
      this.BspOptionsGroupBox.TabIndex = 21;
      this.BspOptionsGroupBox.TabStop = false;
      this.BspOptionsGroupBox.Text = "Compile BSP Options";
      this.BspOptionsLeakTest.AutoSize = true;
      this.BspOptionsLeakTest.FlatStyle = FlatStyle.Popup;
      this.BspOptionsLeakTest.Location = new Point(10, 81);
      this.BspOptionsLeakTest.Name = "BspOptionsLeakTest";
      this.BspOptionsLeakTest.Size = new Size(72, 17);
      this.BspOptionsLeakTest.TabIndex = 20;
      this.BspOptionsLeakTest.Tag = (object) "Aborts compilation if a BSP leak is found";
      this.BspOptionsLeakTest.Text = "Leak Test";
      this.BspOptionsLeakTest.UseVisualStyleBackColor = true;
      this.BspOptionsSampleScaleCheckBox.AutoSize = true;
      this.BspOptionsSampleScaleCheckBox.FlatStyle = FlatStyle.Popup;
      this.BspOptionsSampleScaleCheckBox.Location = new Point(116, 50);
      this.BspOptionsSampleScaleCheckBox.Name = "BspOptionsSampleScaleCheckBox";
      this.BspOptionsSampleScaleCheckBox.Size = new Size(89, 17);
      this.BspOptionsSampleScaleCheckBox.TabIndex = 14;
      this.BspOptionsSampleScaleCheckBox.Text = "Sample Scale";
      this.BspOptionsSampleScaleCheckBox.UseVisualStyleBackColor = true;
      this.BspOptionsSampleScaleCheckBox.CheckedChanged += new EventHandler(this.BspOptionsSampleScaleCheckBox_CheckedChanged);
      this.BspOptionsExtraOptionsLabelText.AutoSize = true;
      this.BspOptionsExtraOptionsLabelText.Location = new Point(7, 114);
      this.BspOptionsExtraOptionsLabelText.Name = "BspOptionsExtraOptionsLabelText";
      this.BspOptionsExtraOptionsLabelText.Size = new Size(97, 13);
      this.BspOptionsExtraOptionsLabelText.TabIndex = 19;
      this.BspOptionsExtraOptionsLabelText.Text = "Extra BSP Options:";
      this.BspOptionsDebugLightsCheckBox.AutoSize = true;
      this.BspOptionsDebugLightsCheckBox.FlatStyle = FlatStyle.Popup;
      this.BspOptionsDebugLightsCheckBox.Location = new Point(10, 50);
      this.BspOptionsDebugLightsCheckBox.Name = "BspOptionsDebugLightsCheckBox";
      this.BspOptionsDebugLightsCheckBox.Size = new Size(107, 17);
      this.BspOptionsDebugLightsCheckBox.TabIndex = 18;
      this.BspOptionsDebugLightsCheckBox.Tag = (object) "Fills lightmaps with random colors to show seams";
      this.BspOptionsDebugLightsCheckBox.Text = "Debug Lightmaps";
      this.BspOptionsDebugLightsCheckBox.UseVisualStyleBackColor = true;
      this.BspOptionsExtraOptionsTextBox.Location = new Point(6, 130);
      this.BspOptionsExtraOptionsTextBox.Name = "BspOptionsExtraOptionsTextBox";
      this.BspOptionsExtraOptionsTextBox.Size = new Size(276, 20);
      this.BspOptionsExtraOptionsTextBox.TabIndex = 17;
      this.BspOptionsBlockSizeNumericUpDown.DecimalPlaces = 2;
      this.BspOptionsBlockSizeNumericUpDown.Increment = new Decimal(new int[4]
      {
        1,
        0,
        0,
        131072
      });
      this.BspOptionsBlockSizeNumericUpDown.Location = new Point(211, 19);
      this.BspOptionsBlockSizeNumericUpDown.Name = "BspOptionsBlockSizeNumericUpDown";
      this.BspOptionsBlockSizeNumericUpDown.Size = new Size(71, 20);
      this.BspOptionsBlockSizeNumericUpDown.TabIndex = 16;
      this.BspOptionsBlockSizeNumericUpDown.Tag = (object) "\"Grid size for regular BSP splits; 0 uses largest possible\"";
      this.BspOptionsSampleScaleNumericUpDown.DecimalPlaces = 2;
      this.BspOptionsSampleScaleNumericUpDown.Increment = new Decimal(new int[4]
      {
        1,
        0,
        0,
        131072
      });
      this.BspOptionsSampleScaleNumericUpDown.Location = new Point(211, 50);
      this.BspOptionsSampleScaleNumericUpDown.Name = "BspOptionsSampleScaleNumericUpDown";
      this.BspOptionsSampleScaleNumericUpDown.Size = new Size(71, 20);
      this.BspOptionsSampleScaleNumericUpDown.TabIndex = 15;
      this.BspOptionsSampleScaleNumericUpDown.Tag = (object) "\"Scales all lightmaps; For example 2.00 doubles pixel size, 0.50 halves it\"";
      this.BspOptionsBlockSizeCheckBox.AutoSize = true;
      this.BspOptionsBlockSizeCheckBox.FlatStyle = FlatStyle.Popup;
      this.BspOptionsBlockSizeCheckBox.Location = new Point(116, 19);
      this.BspOptionsBlockSizeCheckBox.Name = "BspOptionsBlockSizeCheckBox";
      this.BspOptionsBlockSizeCheckBox.Size = new Size(74, 17);
      this.BspOptionsBlockSizeCheckBox.TabIndex = 13;
      this.BspOptionsBlockSizeCheckBox.Text = "Block Size";
      this.BspOptionsBlockSizeCheckBox.UseVisualStyleBackColor = true;
      this.BspOptionsBlockSizeCheckBox.CheckedChanged += new EventHandler(this.BspOptionsBlockSizeCheckBox_CheckedChanged);
      this.BspOptionsOnlyEntsCheckBox.AutoSize = true;
      this.BspOptionsOnlyEntsCheckBox.FlatStyle = FlatStyle.Popup;
      this.BspOptionsOnlyEntsCheckBox.Location = new Point(10, 19);
      this.BspOptionsOnlyEntsCheckBox.Name = "BspOptionsOnlyEntsCheckBox";
      this.BspOptionsOnlyEntsCheckBox.Size = new Size(69, 17);
      this.BspOptionsOnlyEntsCheckBox.TabIndex = 12;
      this.BspOptionsOnlyEntsCheckBox.Tag = (object) "Compile doesn't touch triggers, geometry, or lighting";
      this.BspOptionsOnlyEntsCheckBox.Text = "Only Ents";
      this.BspOptionsOnlyEntsCheckBox.UseVisualStyleBackColor = true;
      this.BspOptionsButtonOK.Location = new Point(147, 185);
      this.BspOptionsButtonOK.Name = "BspOptionsButtonOK";
      this.BspOptionsButtonOK.Size = new Size(75, 23);
      this.BspOptionsButtonOK.TabIndex = 22;
      this.BspOptionsButtonOK.Text = "OK";
      this.BspOptionsButtonOK.UseVisualStyleBackColor = true;
      this.BspOptionsButtonOK.Click += new EventHandler(this.BspOptionsButtonOK_Click);
      this.BspOptionsButtonCancel.DialogResult = DialogResult.Cancel;
      this.BspOptionsButtonCancel.Location = new Point(228, 185);
      this.BspOptionsButtonCancel.Name = "BspOptionsButtonCancel";
      this.BspOptionsButtonCancel.Size = new Size(75, 23);
      this.BspOptionsButtonCancel.TabIndex = 23;
      this.BspOptionsButtonCancel.Text = "Cancel";
      this.BspOptionsButtonCancel.UseVisualStyleBackColor = true;
      this.BspOptionsButtonCancel.Click += new EventHandler(this.BspOptionsButtonCancel_Click);
      this.BspOptionsDebugProbes.AutoSize = true;
      this.BspOptionsDebugProbes.FlatStyle = FlatStyle.Popup;
      this.BspOptionsDebugProbes.Location = new Point(116, 81);
      this.BspOptionsDebugProbes.Name = "BspOptionsDebugProbes";
      this.BspOptionsDebugProbes.Size = new Size(92, 17);
      this.BspOptionsDebugProbes.TabIndex = 20;
      this.BspOptionsDebugProbes.Tag = (object) "Adds reflective debug spheres to all reflection probes";
      this.BspOptionsDebugProbes.Text = "Debug Probes";
      this.BspOptionsDebugProbes.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.BspOptionsButtonOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.BspOptionsButtonCancel;
      this.ClientSize = new Size(313, 220);
      this.ControlBox = false;
      this.Controls.Add((Control) this.BspOptionsButtonCancel);
      this.Controls.Add((Control) this.BspOptionsButtonOK);
      this.Controls.Add((Control) this.BspOptionsGroupBox);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = nameof (BspOptionsForm);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Advanced Users Options";
      this.Load += new EventHandler(this.BspOptionsForm_Load);
      this.BspOptionsGroupBox.ResumeLayout(false);
      this.BspOptionsGroupBox.PerformLayout();
      this.BspOptionsBlockSizeNumericUpDown.EndInit();
      this.BspOptionsSampleScaleNumericUpDown.EndInit();
      this.ResumeLayout(false);
    }
  }
}
