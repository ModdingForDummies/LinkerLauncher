// Decompiled with JetBrains decompiler
// Type: LauncherCS.LightOptionsForm
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LauncherCS
{
  public class LightOptionsForm : Form
  {
    private Button LightOptionsButtonCancel;
    private Button LightOptionsButtonOK;
    private GroupBox LightOptionsGroupBox;
    private GroupBox LightOptionsFastExtraGroupBox;
    private RadioButton LightOptionsExtraRadioButton;
    private RadioButton LightOptionsFastRadioButton;
    private NumericUpDown LightOptionsJitterNumericUpDown;
    private NumericUpDown LightOptionsMaxBouncesNumericUpDown;
    private NumericUpDown LightOptionsTracesNumericUpDown;
    private CheckBox LightOptionsJitterCheckBox;
    private CheckBox LightOptionsMaxBouncesCheckBox;
    private CheckBox LightOptionsTracesCheckBox;
    private CheckBox LightOptionsVerboseCheckBox;
    private CheckBox LightOptionsNoModelShadowsCheckBox;
    private Label LightOptionsExtraOptionsLabelText;
    private TextBox LightOptionsExtraOptionsTextBox;
    private NumericUpDown LightOptionsLGINumericUpDown;
    private CheckBox LightOptionsLGICheckBox;
    private CheckBox LightOptionsHDRCheckBox;
    private IContainer components;

    public LightOptionsForm()
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
      this.LightOptionsButtonCancel = new Button();
      this.LightOptionsButtonOK = new Button();
      this.LightOptionsGroupBox = new GroupBox();
      this.LightOptionsLGINumericUpDown = new NumericUpDown();
      this.LightOptionsLGICheckBox = new CheckBox();
      this.LightOptionsHDRCheckBox = new CheckBox();
      this.LightOptionsExtraOptionsLabelText = new Label();
      this.LightOptionsExtraOptionsTextBox = new TextBox();
      this.LightOptionsFastExtraGroupBox = new GroupBox();
      this.LightOptionsExtraRadioButton = new RadioButton();
      this.LightOptionsFastRadioButton = new RadioButton();
      this.LightOptionsJitterNumericUpDown = new NumericUpDown();
      this.LightOptionsMaxBouncesNumericUpDown = new NumericUpDown();
      this.LightOptionsTracesNumericUpDown = new NumericUpDown();
      this.LightOptionsJitterCheckBox = new CheckBox();
      this.LightOptionsMaxBouncesCheckBox = new CheckBox();
      this.LightOptionsTracesCheckBox = new CheckBox();
      this.LightOptionsVerboseCheckBox = new CheckBox();
      this.LightOptionsNoModelShadowsCheckBox = new CheckBox();
      this.LightOptionsGroupBox.SuspendLayout();
      this.LightOptionsLGINumericUpDown.BeginInit();
      this.LightOptionsFastExtraGroupBox.SuspendLayout();
      this.LightOptionsJitterNumericUpDown.BeginInit();
      this.LightOptionsMaxBouncesNumericUpDown.BeginInit();
      this.LightOptionsTracesNumericUpDown.BeginInit();
      this.SuspendLayout();
      this.LightOptionsButtonCancel.DialogResult = DialogResult.Cancel;
      this.LightOptionsButtonCancel.Location = new Point(268, 198);
      this.LightOptionsButtonCancel.Name = "LightOptionsButtonCancel";
      this.LightOptionsButtonCancel.Size = new Size(75, 23);
      this.LightOptionsButtonCancel.TabIndex = 5;
      this.LightOptionsButtonCancel.Text = "Cancel";
      this.LightOptionsButtonCancel.UseVisualStyleBackColor = true;
      this.LightOptionsButtonCancel.Click += new EventHandler(this.LightOptionsButtonCancel_Click);
      this.LightOptionsButtonOK.Location = new Point(179, 198);
      this.LightOptionsButtonOK.Name = "LightOptionsButtonOK";
      this.LightOptionsButtonOK.Size = new Size(75, 23);
      this.LightOptionsButtonOK.TabIndex = 4;
      this.LightOptionsButtonOK.Text = "OK";
      this.LightOptionsButtonOK.UseVisualStyleBackColor = true;
      this.LightOptionsButtonOK.Click += new EventHandler(this.LightOptionsButtonOK_Click);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsLGINumericUpDown);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsLGICheckBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsHDRCheckBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsExtraOptionsLabelText);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsExtraOptionsTextBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsFastExtraGroupBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsJitterNumericUpDown);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsMaxBouncesNumericUpDown);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsTracesNumericUpDown);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsJitterCheckBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsMaxBouncesCheckBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsTracesCheckBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsVerboseCheckBox);
      this.LightOptionsGroupBox.Controls.Add((Control) this.LightOptionsNoModelShadowsCheckBox);
      this.LightOptionsGroupBox.Location = new Point(15, 15);
      this.LightOptionsGroupBox.Name = "LightOptionsGroupBox";
      this.LightOptionsGroupBox.Size = new Size(325, 177);
      this.LightOptionsGroupBox.TabIndex = 3;
      this.LightOptionsGroupBox.TabStop = false;
      this.LightOptionsGroupBox.Text = "Compile Light Options";
      this.LightOptionsLGINumericUpDown.DecimalPlaces = 2;
      this.LightOptionsLGINumericUpDown.Increment = new Decimal(new int[4]
      {
        1,
        0,
        0,
        131072
      });
      this.LightOptionsLGINumericUpDown.Location = new Point(260, 103);
      this.LightOptionsLGINumericUpDown.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.LightOptionsLGINumericUpDown.Name = "LightOptionsLGINumericUpDown";
      this.LightOptionsLGINumericUpDown.Size = new Size(59, 20);
      this.LightOptionsLGINumericUpDown.TabIndex = 24;
      this.LightOptionsLGICheckBox.AutoSize = true;
      this.LightOptionsLGICheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsLGICheckBox.Location = new Point(147, 103);
      this.LightOptionsLGICheckBox.Name = "LightOptionsLGICheckBox";
      this.LightOptionsLGICheckBox.Size = new Size(108, 17);
      this.LightOptionsLGICheckBox.TabIndex = 23;
      this.LightOptionsLGICheckBox.Text = "LightGrid Intensity";
      this.LightOptionsLGICheckBox.UseVisualStyleBackColor = true;
      this.LightOptionsLGICheckBox.CheckedChanged += new EventHandler(this.LightOptionsLGICheckBox_CheckedChanged);
      this.LightOptionsHDRCheckBox.AutoSize = true;
      this.LightOptionsHDRCheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsHDRCheckBox.Location = new Point(12, 103);
      this.LightOptionsHDRCheckBox.Name = "LightOptionsHDRCheckBox";
      this.LightOptionsHDRCheckBox.Size = new Size(88, 17);
      this.LightOptionsHDRCheckBox.TabIndex = 22;
      this.LightOptionsHDRCheckBox.Text = "HDR Lighting";
      this.LightOptionsHDRCheckBox.UseVisualStyleBackColor = true;
      this.LightOptionsExtraOptionsLabelText.AutoSize = true;
      this.LightOptionsExtraOptionsLabelText.Location = new Point(13, 135);
      this.LightOptionsExtraOptionsLabelText.Name = "LightOptionsExtraOptionsLabelText";
      this.LightOptionsExtraOptionsLabelText.Size = new Size(99, 13);
      this.LightOptionsExtraOptionsLabelText.TabIndex = 21;
      this.LightOptionsExtraOptionsLabelText.Text = "Extra Light Options:";
      this.LightOptionsExtraOptionsTextBox.Location = new Point(12, 151);
      this.LightOptionsExtraOptionsTextBox.Name = "LightOptionsExtraOptionsTextBox";
      this.LightOptionsExtraOptionsTextBox.Size = new Size(298, 20);
      this.LightOptionsExtraOptionsTextBox.TabIndex = 20;
      this.LightOptionsFastExtraGroupBox.Controls.Add((Control) this.LightOptionsExtraRadioButton);
      this.LightOptionsFastExtraGroupBox.Controls.Add((Control) this.LightOptionsFastRadioButton);
      this.LightOptionsFastExtraGroupBox.Location = new Point(12, 19);
      this.LightOptionsFastExtraGroupBox.Name = "LightOptionsFastExtraGroupBox";
      this.LightOptionsFastExtraGroupBox.Size = new Size(117, 32);
      this.LightOptionsFastExtraGroupBox.TabIndex = 9;
      this.LightOptionsFastExtraGroupBox.TabStop = false;
      this.LightOptionsExtraRadioButton.AutoSize = true;
      this.LightOptionsExtraRadioButton.Location = new Point(57, 9);
      this.LightOptionsExtraRadioButton.Name = "LightOptionsExtraRadioButton";
      this.LightOptionsExtraRadioButton.Size = new Size(49, 17);
      this.LightOptionsExtraRadioButton.TabIndex = 1;
      this.LightOptionsExtraRadioButton.Text = "Extra";
      this.LightOptionsExtraRadioButton.UseVisualStyleBackColor = true;
      this.LightOptionsFastRadioButton.AutoSize = true;
      this.LightOptionsFastRadioButton.Checked = true;
      this.LightOptionsFastRadioButton.Location = new Point(6, 9);
      this.LightOptionsFastRadioButton.Name = "LightOptionsFastRadioButton";
      this.LightOptionsFastRadioButton.Size = new Size(45, 17);
      this.LightOptionsFastRadioButton.TabIndex = 0;
      this.LightOptionsFastRadioButton.TabStop = true;
      this.LightOptionsFastRadioButton.Text = "Fast";
      this.LightOptionsFastRadioButton.UseVisualStyleBackColor = true;
      this.LightOptionsJitterNumericUpDown.DecimalPlaces = 3;
      this.LightOptionsJitterNumericUpDown.Increment = new Decimal(new int[4]
      {
        1,
        0,
        0,
        196608
      });
      this.LightOptionsJitterNumericUpDown.Location = new Point(251, 80);
      this.LightOptionsJitterNumericUpDown.Maximum = new Decimal(new int[4]
      {
        4,
        0,
        0,
        0
      });
      this.LightOptionsJitterNumericUpDown.Name = "LightOptionsJitterNumericUpDown";
      this.LightOptionsJitterNumericUpDown.Size = new Size(68, 20);
      this.LightOptionsJitterNumericUpDown.TabIndex = 8;
      this.LightOptionsMaxBouncesNumericUpDown.Location = new Point(251, 57);
      this.LightOptionsMaxBouncesNumericUpDown.Name = "LightOptionsMaxBouncesNumericUpDown";
      this.LightOptionsMaxBouncesNumericUpDown.Size = new Size(68, 20);
      this.LightOptionsMaxBouncesNumericUpDown.TabIndex = 7;
      this.LightOptionsTracesNumericUpDown.Location = new Point(251, 34);
      this.LightOptionsTracesNumericUpDown.Maximum = new Decimal(new int[4]
      {
        500,
        0,
        0,
        0
      });
      this.LightOptionsTracesNumericUpDown.Name = "LightOptionsTracesNumericUpDown";
      this.LightOptionsTracesNumericUpDown.Size = new Size(69, 20);
      this.LightOptionsTracesNumericUpDown.TabIndex = 6;
      this.LightOptionsJitterCheckBox.AutoSize = true;
      this.LightOptionsJitterCheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsJitterCheckBox.Location = new Point(147, 80);
      this.LightOptionsJitterCheckBox.Name = "LightOptionsJitterCheckBox";
      this.LightOptionsJitterCheckBox.Size = new Size(46, 17);
      this.LightOptionsJitterCheckBox.TabIndex = 5;
      this.LightOptionsJitterCheckBox.Text = "Jitter";
      this.LightOptionsJitterCheckBox.UseVisualStyleBackColor = true;
      this.LightOptionsJitterCheckBox.CheckedChanged += new EventHandler(this.LightOptionsJitterCheckBox_CheckedChanged);
      this.LightOptionsMaxBouncesCheckBox.AutoSize = true;
      this.LightOptionsMaxBouncesCheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsMaxBouncesCheckBox.Location = new Point(147, 57);
      this.LightOptionsMaxBouncesCheckBox.Name = "LightOptionsMaxBouncesCheckBox";
      this.LightOptionsMaxBouncesCheckBox.Size = new Size(89, 17);
      this.LightOptionsMaxBouncesCheckBox.TabIndex = 4;
      this.LightOptionsMaxBouncesCheckBox.Text = "Max Bounces";
      this.LightOptionsMaxBouncesCheckBox.UseVisualStyleBackColor = true;
      this.LightOptionsMaxBouncesCheckBox.CheckedChanged += new EventHandler(this.LightOptionsMaxBouncesCheckBox_CheckedChanged);
      this.LightOptionsTracesCheckBox.AutoSize = true;
      this.LightOptionsTracesCheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsTracesCheckBox.Location = new Point(147, 34);
      this.LightOptionsTracesCheckBox.Name = "LightOptionsTracesCheckBox";
      this.LightOptionsTracesCheckBox.Size = new Size(57, 17);
      this.LightOptionsTracesCheckBox.TabIndex = 3;
      this.LightOptionsTracesCheckBox.Text = "Traces";
      this.LightOptionsTracesCheckBox.UseVisualStyleBackColor = true;
      this.LightOptionsTracesCheckBox.CheckedChanged += new EventHandler(this.LightOptionsTracesCheckBox_CheckedChanged);
      this.LightOptionsVerboseCheckBox.AutoSize = true;
      this.LightOptionsVerboseCheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsVerboseCheckBox.Location = new Point(12, 80);
      this.LightOptionsVerboseCheckBox.Name = "LightOptionsVerboseCheckBox";
      this.LightOptionsVerboseCheckBox.Size = new Size(63, 17);
      this.LightOptionsVerboseCheckBox.TabIndex = 2;
      this.LightOptionsVerboseCheckBox.Text = "Verbose";
      this.LightOptionsVerboseCheckBox.UseVisualStyleBackColor = true;
      this.LightOptionsNoModelShadowsCheckBox.AutoSize = true;
      this.LightOptionsNoModelShadowsCheckBox.FlatStyle = FlatStyle.Popup;
      this.LightOptionsNoModelShadowsCheckBox.Location = new Point(12, 57);
      this.LightOptionsNoModelShadowsCheckBox.Name = "LightOptionsNoModelShadowsCheckBox";
      this.LightOptionsNoModelShadowsCheckBox.Size = new Size(117, 17);
      this.LightOptionsNoModelShadowsCheckBox.TabIndex = 1;
      this.LightOptionsNoModelShadowsCheckBox.Text = "No Model Shadows";
      this.LightOptionsNoModelShadowsCheckBox.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(355, 233);
      this.ControlBox = false;
      this.Controls.Add((Control) this.LightOptionsButtonCancel);
      this.Controls.Add((Control) this.LightOptionsButtonOK);
      this.Controls.Add((Control) this.LightOptionsGroupBox);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (LightOptionsForm);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Advanced Users Options";
      this.Load += new EventHandler(this.LightOptionsForm_Load);
      this.LightOptionsGroupBox.ResumeLayout(false);
      this.LightOptionsGroupBox.PerformLayout();
      this.LightOptionsLGINumericUpDown.EndInit();
      this.LightOptionsFastExtraGroupBox.ResumeLayout(false);
      this.LightOptionsFastExtraGroupBox.PerformLayout();
      this.LightOptionsJitterNumericUpDown.EndInit();
      this.LightOptionsMaxBouncesNumericUpDown.EndInit();
      this.LightOptionsTracesNumericUpDown.EndInit();
      this.ResumeLayout(false);
    }

    private void LightOptionsButtonCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void LightOptionsButtonOK_Click(object sender, EventArgs e)
    {
      Launcher.mapSettings.SetBoolean("lightoptions_extra", this.LightOptionsExtraRadioButton.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_nomodelshadow", this.LightOptionsNoModelShadowsCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_verbose", this.LightOptionsVerboseCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_hdr", this.LightOptionsHDRCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_traces", this.LightOptionsTracesCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_maxbounces", this.LightOptionsMaxBouncesCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_jitter", this.LightOptionsJitterCheckBox.Checked);
      Launcher.mapSettings.SetBoolean("lightoptions_lgi", this.LightOptionsLGICheckBox.Checked);
      Launcher.mapSettings.SetDecimal("lightoptions_traces_val", this.LightOptionsTracesNumericUpDown.Value);
      Launcher.mapSettings.SetDecimal("lightoptions_maxbounces_val", this.LightOptionsMaxBouncesNumericUpDown.Value);
      Launcher.mapSettings.SetDecimal("lightoptions_jitter_val", this.LightOptionsJitterNumericUpDown.Value);
      Launcher.mapSettings.SetDecimal("lightoptions_lgi_val", this.LightOptionsLGINumericUpDown.Value);
      Launcher.mapSettings.SetString("lightoptions_extraoptions", this.LightOptionsExtraOptionsTextBox.Text);
      this.Close();
    }

    private void LightOptionsForm_Load(object sender, EventArgs e)
    {
      this.LightOptionsExtraRadioButton.Checked = Launcher.mapSettings.GetBoolean("lightoptions_extra", false);
      this.LightOptionsFastRadioButton.Checked = !this.LightOptionsExtraRadioButton.Checked;
      this.LightOptionsNoModelShadowsCheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_nomodelshadow", false);
      this.LightOptionsVerboseCheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_verbose", false);
      this.LightOptionsHDRCheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_hdr", false);
      this.LightOptionsTracesCheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_traces", false);
      this.LightOptionsMaxBouncesCheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_maxbounces", false);
      this.LightOptionsJitterCheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_jitter", false);
      this.LightOptionsLGICheckBox.Checked = Launcher.mapSettings.GetBoolean("lightoptions_lgi", false);
      Launcher.SetNumericUpDownValue(this.LightOptionsTracesNumericUpDown, Launcher.mapSettings.GetDecimal("lightoptions_traces_val"));
      Launcher.SetNumericUpDownValue(this.LightOptionsMaxBouncesNumericUpDown, Launcher.mapSettings.GetDecimal("lightoptions_maxbounces_val"));
      Launcher.SetNumericUpDownValue(this.LightOptionsJitterNumericUpDown, Launcher.mapSettings.GetDecimal("lightoptions_jitter_val"));
      Launcher.SetNumericUpDownValue(this.LightOptionsLGINumericUpDown, Launcher.mapSettings.GetDecimal("lightoptions_lgi_val"));
      this.LightOptionsExtraOptionsTextBox.Text = Launcher.mapSettings.GetString("lightoptions_extraoptions");
      this.LightOptionsFormUpdate();
    }

    private void LightOptionsFormUpdate()
    {
      this.LightOptionsTracesNumericUpDown.Enabled = this.LightOptionsTracesCheckBox.Checked;
      this.LightOptionsMaxBouncesNumericUpDown.Enabled = this.LightOptionsMaxBouncesCheckBox.Checked;
      this.LightOptionsJitterNumericUpDown.Enabled = this.LightOptionsJitterCheckBox.Checked;
      this.LightOptionsLGINumericUpDown.Enabled = this.LightOptionsLGICheckBox.Checked;
    }

    private void LightOptionsJitterCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.LightOptionsFormUpdate();
    }

    private void LightOptionsMaxBouncesCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.LightOptionsFormUpdate();
    }

    private void LightOptionsTracesCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.LightOptionsFormUpdate();
    }

    private void LightOptionsLGICheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.LightOptionsFormUpdate();
    }
  }
}
