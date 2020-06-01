// Decompiled with JetBrains decompiler
// Type: LauncherCS.LauncherForm
// Assembly: Launcher, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BE2EDF30-BDA3-4FE0-9EFC-B0A1BE215D80
// Assembly location: D:\SteamLibrary\steamapps\common\Call of Duty Black Ops\bin\Decompiling\Launcher.exe

using Launcher.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace LauncherCS
{
  public class LauncherForm : Form
  {
    private ComboBox[] dvarComboBoxes = new ComboBox[0];
    private Hashtable processTable = new Hashtable();
    private ArrayList processList = new ArrayList();
    private long consoleTicksWhenLastFocus = DateTime.Now.Ticks;
    private Mutex consoleMutex = new Mutex();
    private int LauncherMapList_WaitingForMouseUp = -1;
    private int LauncherMapListContextMenu_Map = -1;
    private Process consoleProcess;
    private DateTime consoleProcessStartTime;
    private string mapName;
    private string modName;
    private IContainer components;
    private SplitContainer LauncherSplitter;
    private TabControl LauncherTab;
    private TabPage LauncherTabCompileLevel;
    private TabPage LauncherTabModBuilder;
    private ListBox LauncherMapList;
    private Button LauncherButtonCancel;
    private ListBox LauncherProcessList;
    private GroupBox LauncherProcessGroupBox;
    private GroupBox LauncherRunGameModGroupBox;
    private ComboBox LauncherRunGameModComboBox;
    private Button LauncherRunGameButton;
    private GroupBox LauncherRunGameCustomCommandLineGroupBox;
    private TextBox LauncherRunGameCustomCommandLineTextBox;
    private GroupBox LauncherCompileLevelOptionsGroupBox;
    private CheckBox LauncherConnectPathsCheckBox;
    private CheckBox LauncherCompileLightsCheckBox;
    private CheckBox LauncherCompileBSPCheckBox;
    private Button LauncherCompileLightsButton;
    private Button LauncherCompileBSPButton;
    private CheckBox LauncherUseRunGameTypeOptionsCheckBox;
    private CheckBox LauncherRunMapAfterCompileCheckBox;
    private CheckBox LauncherBspInfoCheckBox;
    private CheckBox LauncherBuildFastFilesCheckBox;
    private Button LauncherCompileLevelButton;
    private Label LauncherCustomRunOptionsLabel;
    private TextBox LauncherCustomRunOptionsTextBox;
    private System.Windows.Forms.Timer LauncherTimer;
    internal GroupBox LauncherIwdFileGroupBox;
    internal GroupBox LauncherModGroupBox;
    internal ComboBox LauncherModComboBox;
    private TreeView LauncherIwdFileTree;
    private ComboBox LauncherModSpecificMapComboBox;
    private CheckBox LauncherModSpecificMapCheckBox;
    public RichTextBox LauncherConsole;
    private Button LauncherCreateMapButton;
    private Button LauncherDeleteMapButton;
    private FileSystemWatcher LauncherMapFilesSystemWatcher;
    private FileSystemWatcher LauncherModsDirectorySystemWatcher;
    private CheckBox LauncherGridCollectDotsCheckBox;
    private GroupBox LauncherGridFileGroupBox;
    private Button LauncherGridMakeNewButton;
    private Button LauncherGridEditExistingButton;
    private PictureBox LauncherIconBlops;
    private GroupBox LauncherGameGroupBox;
    private PictureBox LauncherIconMP;
    private PictureBox LauncherIconSP;
    private Button LauncherButtonMP;
    private Button LauncherButtonSP;
    private GroupBox LauncherApplicationsGroupBox;
    private PictureBox LauncherIconRadiant;
    private PictureBox LauncherIconEffectsEditor;
    private PictureBox LauncherIconConverter;
    private PictureBox LauncherIconAssetViewer;
    private PictureBox LauncherIconAssetManager;
    private Button LauncherButtonAssetViewer;
    private Button LauncherButtonRunConverter;
    private Button LauncherButtonAssetManager;
    private Button LauncherButtonEffectsEd;
    private Button LauncherButtonRadiant;
    private TextBox LauncherProcessTimeElapsedTextBox;
    private Button LauncherClearConsoleButton;
    private TextBox LauncherProcessTextBox;
    private GroupBox LauncherRunGameGroupBox;
    private GroupBox LauncherRunGameCustomCommandLineMPGroupBox;
    private TextBox LauncherRunGameCustomCommandLineMPTextBox;
    private CheckBox LauncherRunGameCustomCommandLineCheckBox;
    private CheckBox LauncherRunGameCustomCommandLineMPCheckBox;
    private TextBox LauncherRunGameCommandLineTextBox;
    private Label LauncherRunGameMapNameLabel;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem LauncherfileToolStripMenuItem;
    private ToolStripMenuItem LauncherexitToolStripMenuItem;
    private ToolStripMenuItem LauncherdocsToolStripMenuItem;
    private ToolStripMenuItem LaunchertoolsToolStripMenuItem;
    private ToolStripMenuItem LauncherhelpToolStripMenuItem;
    private ToolStripMenuItem LauncherwikiToolStripMenuItem;
    private Panel panel1;
    private ToolTip LauncherRadiantToolTip;
    private ToolTip LauncherEffectsEdToolTip;
    private ToolTip LauncherAssetViewerToolTip;
    private ToolTip LauncherConverterToolTip;
    private ToolTip LauncherAssetManagerToolTip;
    private CheckBox LauncherRunGameLogfileBox;
    private CheckBox LauncherRunGameDeveloperBox;
    private TextBox LauncherRunGameMapNameTextBox;
    private CheckBox LauncherGameLogfileBox;
    private CheckBox LauncherGameDeveloperBox;
    private ToolStripMenuItem gameDirToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolTip SaveConsoleToolTip;
    private Button LauncherSaveConsoleButton;
    private ToolStripMenuItem mayaExporterToolStripMenuItem;
    private Button LauncherScrollBottomConsoleButton;
    private ToolTip LauncherScrollBottomConsoleToolTip;
    private ComboBox LauncherMapTypeList;
    private Label LauncherMapType;
    private TabPage LauncherTabExplore;
    private GroupBox LauncherExploreGroupBox;
    private GroupBox LauncherExploreRawDirGroupBox;
    private Button LauncherExploreRawDirWeaponsButton;
    private Button LauncherExploreRawDirVisionButton;
    private Button LauncherExploreRawDirLocsButton;
    private Button LauncherExploreRawDirAnimTreesButton;
    private Button LauncherExploreRawDirSoundAliasesButton;
    private Button LauncherExploreRawDirCSCButton;
    private Button LauncherExploreRawDirGSCButton;
    private GroupBox LauncherExploreDevDirGroupBox;
    private Button LauncherExploreDevDirRawButton;
    private Button LauncherExploreDevDirModelExportButton;
    private Button LauncherExploreDevDirTextureAssetsButton;
    private Button LauncherExploreDevDirSrcDataButton;
    private Button LauncherExploreDevDirMapSrcButton;
    private Button LauncherExploreDevDirBinButton;
    private Button LauncherExploreDevDirZoneSourceButton;
    private GroupBox LauncherExploreBlopsDirGroupBox;
    private Button LauncherExploreBlopsDirConfigsButton;
    private Button LauncherExploreBlopsDirModsButton;
    private Button LauncherExploreBlopsDirGameButton;
    private Button LauncherExploreRawDirMPButton;
    private GroupBox LauncherExploreRawMapsDirGroupBox;
    private Button LauncherExploreRawGSCDirMPGametypesButton;
    private Button LauncherExploreRawGSCDirMPFXButton;
    private Button LauncherExploreRawGSCDirMPArtButton;
    private Button LauncherExploreRawGSCDirMPButton;
    private Button LauncherExploreRawGSCDirSPVoiceButton;
    private Button LauncherExploreRawGSCDirSPGametypesButton;
    private Button LauncherExploreRawGSCDirSPFXButton;
    private Button LauncherExploreRawGSCDirSPArtButton;
    private Button LauncherExploreRawGSCDirSPButton;
    private GroupBox LauncherModZoneSourceGroupBox;
    private Button LauncherEditZoneSourceButton;
    private GroupBox LauncherModBuildGroupBox;
    internal Button LauncherModBuildButton;
    internal CheckBox LauncherModBuildSoundsCheckBox;
    private Button LauncherModZoneSourceMissingAssetsButton;
    internal CheckBox LauncherModVerboseCheckBox;
    internal CheckBox LauncherModBuildFastFilesCheckBox;
    internal CheckBox LauncherModBuildIwdFileCheckBox;
    private Button LauncherModZoneSourceCSVButton;
    private GroupBox LauncherModFolderGroupBox;
    private Button LauncherModFolderViewButton;
    private TextBox LauncherModBuildLinkerOptionsTextBox;
    private Label LauncherModBuildLinkerOptionsLabel;
    private Button LauncherExploreRawDirFXButton;
    private PictureBox LauncherErrorsPictureBox;
    private Label LauncherErrorsLabel;
    private NumericUpDown LauncherErrorsNumericUpDown;
    private Label LauncherErrorsCounter;
    private Label LauncherWarningsCounter;
    private NumericUpDown LauncherWarningsNumericUpDown;
    private PictureBox LauncherWarningsPictureBox;
    private Label LauncherWarningsLabel;
    private ToolStripMenuItem mayaPluginSetupToolStripMenuItem;
    private ContextMenuStrip LauncherMapListContextMenuStrip;
    private ToolStripMenuItem runToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem deleteToolStripMenuItem;
    private ToolStripMenuItem renameToolStripMenuItem;
    private CheckBox LauncherCompileReflectionsCheckBox;
    private ToolStripMenuItem newModToolStripMenuItem;
    private ToolStripMenuItem LaunchernewMapToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem exporterTutorialToolStripMenuItem;

    public LauncherForm()
    {
      this.InitializeComponent();
      this.LauncherMapTypeList.SelectedIndex = 0;
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == NativeMethods.WM_SHOWME)
      {
        if (this.WindowState == FormWindowState.Minimized)
          this.WindowState = FormWindowState.Normal;
        bool topMost = this.TopMost;
        this.TopMost = true;
        this.TopMost = topMost;
      }
      base.WndProc(ref m);
    }

    public void SetMapSelection(string mapName, bool updateList = false)
    {
      if (updateList)
        this.UpdateMapList();
      int stringExact = this.LauncherMapList.FindStringExact(mapName);
      if (stringExact == -1)
        return;
      this.LauncherMapList.SelectedIndex = stringExact;
    }

    public void SetModSelection(string modName, bool updateList = false)
    {
      if (updateList)
        this.UpdateModList();
      int stringExact = this.LauncherModComboBox.FindStringExact(modName);
      if (stringExact == -1)
        return;
      this.LauncherModComboBox.SelectedIndex = stringExact;
    }

    public void SetTabToSingleplayer()
    {
      this.LauncherMapTypeList.SelectedIndex = 0;
    }

    public void SetTabToMultiplayer()
    {
      this.LauncherMapTypeList.SelectedIndex = 1;
    }

    public void SetLauncherTab(LauncherForm.LauncherTabType tab)
    {
      switch (tab)
      {
        case LauncherForm.LauncherTabType.Mods:
          this.LauncherTab.SelectedTab = this.LauncherTabModBuilder;
          break;
        case LauncherForm.LauncherTabType.Maps:
          this.LauncherTab.SelectedTab = this.LauncherTabCompileLevel;
          break;
        case LauncherForm.LauncherTabType.Explore:
          this.LauncherTab.SelectedTab = this.LauncherTabExplore;
          break;
      }
    }

    private void AddFilesToTreeView(string Directory, TreeNodeCollection tree, bool firstTime)
    {
      TreeNode treeNode1 = (TreeNode) null;
      if (!firstTime)
      {
        treeNode1 = tree.Add(new DirectoryInfo(Directory).Name);
        tree = treeNode1.Nodes;
      }
      foreach (DirectoryInfo directory in new DirectoryInfo(Directory).GetDirectories())
      {
        if (!directory.Name.StartsWith("."))
          this.AddFilesToTreeView(Path.Combine(Directory, directory.Name), tree, false);
      }
      foreach (FileInfo file in new DirectoryInfo(Directory).GetFiles())
      {
        if (!file.Name.StartsWith(".") && file.Extension.ToLower() != ".ff" && (file.Extension.ToLower() != ".iwd" && file.Extension.ToLower() != ".files"))
        {
          TreeNode treeNode2 = tree.Add(file.Name);
          treeNode2.ForeColor = Color.Blue;
          treeNode2.Tag = (object) file;
        }
      }
      if (treeNode1 == null)
        return;
      if (treeNode1.Nodes.Count != 0)
        treeNode1.ExpandAll();
      else
        treeNode1.Remove();
    }

    private void BuildGridDelegate(int r_vc_makelog)
    {
      this.EnableControls(false);
      string path2 = this.mapName + ".grid";
      LauncherCS.Launcher.CopyFile(Path.Combine(LauncherCS.Launcher.GetMapSourceDirectory(false), path2), Path.Combine(LauncherCS.Launcher.GetRawMapsDirectory(false), Path.Combine(this.IsMP() ? "mp" : "", path2)));
      LauncherForm.ProcessFinishedDelegate nextStage = new LauncherForm.ProcessFinishedDelegate(this.BuildGridFinishedDelegate);
      string gameApplication = LauncherCS.Launcher.GetGameApplication(this.IsMP());
      string str1 = "raw";
      string str2 = "+set developer 1 +set logfile 2 + set r_vc_makelog " + r_vc_makelog.ToString() + "+set r_vc_showlog 16 +set r_cullxmodel " + (LauncherCS.Launcher.mapSettings.GetBoolean("compile_collectdots", false) ? "0" : "1") + " +set thereisacow 1960 +set com_introplayed 1 +set fs_game " + str1;
      string processOptions = (!(str1 == "raw") ? str2 + " +set fs_usedevdir 1" : str2 + " +set fs_useFastFile 0 +set fs_usedevdir 1") + "+devmap " + this.mapName;
      this.LaunchProcessHelper(true, nextStage, (Process) null, gameApplication, processOptions);
    }

    private void BuildGridFinishedDelegate(Process lastProcess)
    {
      string path2 = this.mapName + ".grid";
      LauncherCS.Launcher.MoveFile(Path.Combine(LauncherCS.Launcher.GetRawMapsDirectory(false), Path.Combine(this.IsMP() ? "mp" : "", path2)), Path.Combine(LauncherCS.Launcher.GetMapSourceDirectory(false), path2));
      this.EnableControls(true);
    }

    private void LauncherModSpecificMapCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      this.LauncherModSpecificMapComboBox.Enabled = this.LauncherModSpecificMapCheckBox.Checked;
    }

    private bool CheckZoneSourceFiles()
    {
      if (File.Exists(LauncherCS.Launcher.GetZoneSourceFile(this.mapName)))
        return true;
      if (MessageBox.Show("There are no zone files for " + this.mapName + ". Would you like to create them?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        return false;
      LauncherCS.Launcher.CreateZoneSourceFiles(this.mapName);
      return true;
    }

    private void CompileLevel()
    {
      this.EnableControls(false);
      this.UpdateMapSettings(true, true);
      this.CompileLevelBspDelegate((Process) null);
    }

    private void CompileLevelBspDelegate(Process lastProcess)
    {
      LauncherForm.ProcessFinishedDelegate nextStage = new LauncherForm.ProcessFinishedDelegate(this.CompileLevelVisDelegate);
      LauncherCS.Launcher.DeleteFile(this.GetSourceBsp() + ".lin", false);
      string[] strArray = new string[9]
      {
        "-platform pc ",
        "-loadFrom \"",
        this.GetSourceBsp(),
        ".map\"",
        " ",
        LauncherCS.Launcher.GetBspOptions(),
        " \"",
        this.GetDestinationBsp(),
        "\""
      };
      this.CompileLevelHelper("compile_bsp", nextStage, lastProcess, "cod2map", string.Concat(strArray));
    }

    private void CompileLevelLightsDelegate(Process lastProcess)
    {
      string[] strArray = new string[5]
      {
        "-platform pc ",
        LauncherCS.Launcher.GetLightOptions(),
        "\"",
        this.GetDestinationBsp(),
        "\""
      };
      this.CompileLevelHelper("compile_lights", new LauncherForm.ProcessFinishedDelegate(this.CompileLevelCleanupDelegate), lastProcess, "cod2rad", string.Concat(strArray));
    }

    private void CompileLevelBspInfoDelegate(Process lastProcess)
    {
      this.CompileLevelHelper("compile_bspinfo", new LauncherForm.ProcessFinishedDelegate(this.CompileLevelFastFilesDelegate), lastProcess, "cod2map", "-info \"" + this.GetDestinationBsp() + "\"");
    }

    private void CompileLevelBuildFastFile(
      string name,
      Process lastProcess,
      LauncherForm.ProcessFinishedDelegate nextStage)
    {
      string str = LauncherCS.Launcher.mapSettings.GetBoolean("compile_modenabled", false) ? "-moddir " + LauncherCS.Launcher.mapSettings.GetString("compile_modname") + " " : "";
      this.CompileLevelHelper("compile_buildffs", nextStage, lastProcess, "linker_pc", "-nopause -language " + LauncherCS.Launcher.GetLanguage() + " " + str + name + (File.Exists(LauncherCS.Launcher.GetLoadZone(this.mapName)) ? " " + LauncherCS.Launcher.GetLoadZone(this.mapName) : ""));
    }

    private void CompileLevelCleanupDelegate(Process lastProcess)
    {
      string[] strArray = new string[5]
      {
        ".lin",
        ".map",
        ".d3dpoly",
        ".vclog",
        ".grid"
      };
      foreach (string str in strArray)
        LauncherCS.Launcher.DeleteFile(this.GetDestinationBsp() + str, false);
      this.CompileLevelPathsDelegate(lastProcess);
    }

    private void CompileLevelFastFilesDelegate(Process lastProcess)
    {
      if (!this.CheckZoneSourceFiles())
        this.CompileLevelRunGameDelegate(lastProcess);
      else if (this.IsMP())
        this.CompileLevelBuildFastFile(this.mapName, lastProcess, new LauncherForm.ProcessFinishedDelegate(this.CompileLevelFastFilesLocalizedDelegate));
      else
        this.CompileLevelBuildFastFile(this.mapName, lastProcess, new LauncherForm.ProcessFinishedDelegate(this.CompileLevelMoveFastFilesDelegate));
    }

    private void CompileLevelFastFilesLocalizedDelegate(Process lastProcess)
    {
      this.CompileLevelBuildFastFile("localized_" + this.mapName, lastProcess, new LauncherForm.ProcessFinishedDelegate(this.CompileLevelMoveFastFilesDelegate));
    }

    private void CompileLevelFinished(Process lastProcess)
    {
      this.EnableControls(true);
    }

    private void CompileLevelHelper(
      string mapSettingsOption,
      LauncherForm.ProcessFinishedDelegate nextStage,
      Process lastProcess,
      string processName,
      string processOptions,
      string workingDirectory)
    {
      this.LaunchProcessHelper(LauncherCS.Launcher.mapSettings.GetBoolean(mapSettingsOption, false), nextStage, lastProcess, processName, processOptions, workingDirectory);
    }

    private void CompileLevelHelper(
      string mapSettingsOption,
      LauncherForm.ProcessFinishedDelegate nextStage,
      Process lastProcess,
      string processName,
      string processOptions)
    {
      this.LaunchProcessHelper(LauncherCS.Launcher.mapSettings.GetBoolean(mapSettingsOption, false), nextStage, lastProcess, processName, processOptions);
    }

    private void CompileLevelMoveFastFilesDelegate(Process lastProcess)
    {
      string zoneDirectory = LauncherCS.Launcher.GetZoneDirectory();
      string path1 = LauncherCS.Launcher.mapSettings.GetBoolean("compile_modenabled", false) ? LauncherCS.Launcher.GetModDirectory(LauncherCS.Launcher.mapSettings.GetString("compile_modname"), true) : Path.Combine(LauncherCS.Launcher.GetUsermapsDirectory(), this.mapName);
      string path2_1 = this.mapName + ".ff";
      string path2_2 = this.mapName + "_load.ff";
      LauncherCS.Launcher.MoveFile(Path.Combine(zoneDirectory, path2_1), Path.Combine(path1, path2_1));
      LauncherCS.Launcher.MoveFile(Path.Combine(zoneDirectory, "localized_" + path2_1), Path.Combine(path1, "localized_" + path2_1));
      LauncherCS.Launcher.MoveFile(Path.Combine(zoneDirectory, path2_2), Path.Combine(path1, path2_2));
      LauncherCS.Launcher.Publish();
      this.CompileLevelRunGameDelegate(lastProcess);
    }

    private void CompileLevelPathsDelegate(Process lastProcess)
    {
      this.CompileLevelHelper("compile_paths", new LauncherForm.ProcessFinishedDelegate(this.CompileLevelReflectionsDelegate), lastProcess, LauncherCS.Launcher.GetGameTool(this.IsMP()), "allowdupe +set developer 1 +set logfile 2 +set thereisacow 1960 +set com_introplayed 1 +set r_fullscreen 0 +set fs_usedevdir 1 +set g_connectpaths 2 +set useFastFile 0 +devmap " + this.mapName);
    }

    private void CompileLevelReflectionsDelegate(Process lastProcess)
    {
      this.CompileLevelHelper("compile_reflections", new LauncherForm.ProcessFinishedDelegate(this.CompileLevelBspInfoDelegate), lastProcess, LauncherCS.Launcher.GetGameTool(this.IsMP()), "allowdupe +set developer 1 +set logfile 2 +set thereisacow 1960 +set com_introplayed 1 +set r_fullscreen 0 +set fs_usedevdir 1 +set ui_autoContinue 1 +set r_reflectionProbeGenerateExit 1 +set useFastFile 0 +set r_fullscreen 0 +set r_reflectionProbeRegenerateAll 1 +set r_zFeather 1 +set r_reflectionProbeGenerate 1 +set r_filmusetweaks 1 +seta r_filmtweakcolortemp "8000 8000 8000" +set r_filmtweaklighttint ".1 .1 .1" +set r_filmtweakmidtint ".1 .1 .1" +set r_filmtweakdarktint ".1 .1 .1" +devmap " + this.mapName);
    }

    private void CompileLevelRunGameDelegate(Process lastProcess)
    {
      string str = LauncherCS.Launcher.mapSettings.GetBoolean("compile_modenabled", false) ? "\"mods/" + LauncherCS.Launcher.mapSettings.GetString("compile_modname") + "\"" : "raw";
      LauncherForm.ProcessFinishedDelegate nextStage = new LauncherForm.ProcessFinishedDelegate(this.CompileLevelFinished);
      Process lastProcess1 = lastProcess;
      string gameApplication = LauncherCS.Launcher.GetGameApplication(this.IsMP());
      string[] strArray1 = new string[7];
      strArray1[0] = "+set useFastFile 1 +set fs_usedevdir 1 +set logfile 2 +set thereisacow 1960 +set com_introplayed 1 ";
      string[] strArray2 = strArray1;
      strArray2[1] = this.IsMP() ? "+set sv_pure 0 +set g_gametype tdm " : "";
      strArray2[2] = "+devmap ";
      strArray2[3] = this.mapName;
      strArray2[4] = " +set fs_game ";
      strArray2[5] = str;
      strArray2[6] = " ";
      this.CompileLevelHelper("compile_runafter", nextStage, lastProcess1, gameApplication, string.Concat(strArray2));
    }

    private void CompileLevelVisDelegate(Process lastProcess)
    {
      this.CompileLevelHelper("compile_vis", new LauncherForm.ProcessFinishedDelegate(this.CompileLevelLightsDelegate), lastProcess, "cod2map", "-vis -platform pc \"" + this.GetDestinationBsp() + "\"");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.components != null)
          this.components.Dispose();
        if (this.consoleMutex != null)
          this.consoleMutex.Close();
      }
      base.Dispose(disposing);
    }

    private void EnableControls(bool enabled)
    {
      this.EnableControls(enabled, (TabPage) null);
    }

    private void EnableControls(bool enabled, TabPage onlyForTabPage)
    {
      TabPage[] tabPageArray = new TabPage[2]
      {
        this.LauncherTabCompileLevel,
        this.LauncherTabModBuilder
      };
      foreach (TabPage tabPage in tabPageArray)
      {
        if (onlyForTabPage == null || onlyForTabPage == tabPage)
        {
          foreach (Control control in (ArrangedElementCollection) tabPage.Controls)
            control.Enabled = enabled;
        }
      }
      if (enabled)
        this.LauncherModSpecificMapComboBox.Enabled = this.LauncherModSpecificMapCheckBox.Checked;
      this.LauncherMapTypeList.Enabled = true;
      this.LauncherCreateMapButton.Enabled = true;
    }

    private void EnableMapList()
    {
      bool enabled = this.LauncherMapList.SelectedItem != null;
      this.LauncherCompileLevelButton.Enabled = enabled;
      this.EnableControls(enabled, this.LauncherTabCompileLevel);
      this.LauncherMapList.Enabled = true;
    }

    private void ExploreOpenDir(string dir)
    {
      if (Directory.Exists(dir))
      {
        Process.Start(dir);
      }
      else
      {
        int num = (int) MessageBox.Show("Could not find directory:\n" + dir, "Error");
      }
    }

    private void exporterTutorialToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start(LauncherCS.Launcher.GetRootDirectory() + "/bin/maya/tutorial/trashcan_metal/Treyarch_trashcan_metal_directions01sm.pdf");
    }

    public int FindLauncherConsoleText(string text, int start, int end)
    {
      int num1 = -1;
      if (text.Length > 0 && start >= 0 && end >= 0)
      {
        int num2 = this.LauncherConsole.Find(text, start, end, RichTextBoxFinds.None);
        if (num2 >= 0)
          num1 = num2;
      }
      return num1;
    }

    private string FormatDVar(ComboBox cb)
    {
      string str1 = "";
      if (cb.SelectedItem != null && cb.SelectedIndex > 0)
        str1 = cb.SelectedItem.ToString();
      else if (cb.Items[0].ToString() != cb.Text)
        str1 = cb.Text;
      string str2 = str1.Trim();
      if (str2 == "")
        return "";
      return "+set " + cb.Tag + " " + str2 + " ";
    }

    private string FormatDvars()
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (ComboBox dvarComboBox in this.dvarComboBoxes)
        stringBuilder.Append(this.FormatDVar(dvarComboBox));
      return stringBuilder.ToString();
    }

    private void gameDirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start(LauncherCS.Launcher.GetRootDirectory());
    }

    private string GetDestinationBsp()
    {
      return LauncherCS.Launcher.GetRawMapsDirectory(false) + (this.IsMP() ? "mp\\" : "") + this.mapName;
    }

    private string GetFS_Game(bool allowRaw = false)
    {
      if (this.LauncherRunGameModComboBox.SelectedIndex > 1)
        return "\"mods/" + this.LauncherRunGameModComboBox.Text + "\"";
      return this.LauncherRunGameModComboBox.SelectedIndex > 0 ? (this.LauncherModSpecificMapComboBox.Text.Length <= 0 || !this.LauncherModSpecificMapCheckBox.Checked ? "" : "\"mods/" + this.LauncherModSpecificMapComboBox.Text + "\"") : (allowRaw ? "raw" : "");
    }

    private string GetGameOptions()
    {
      string fsGame = this.GetFS_Game(false);
      return fsGame.Length != 0 ? "+set fs_game " + fsGame + " " + this.FormatDvars() : this.FormatDvars();
    }

    private string GetSourceBsp()
    {
      return LauncherCS.Launcher.GetMapSourceDirectory(false) + this.mapName;
    }

    private void HashTableToTreeView(Hashtable ht, TreeNodeCollection tree)
    {
      if (tree == null)
        return;
      foreach (TreeNode node in tree)
      {
        if (ht.Contains((object) node.FullPath))
        {
          node.Checked = true;
          this.RecursiveCheckNodesUp(node, true);
        }
        this.HashTableToTreeView(ht, node.Nodes);
      }
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LauncherForm));
      this.LauncherConsole = new RichTextBox();
      this.LauncherSplitter = new SplitContainer();
      this.panel1 = new Panel();
      this.LauncherRunGameCustomCommandLineGroupBox = new GroupBox();
      this.LauncherRunGameCustomCommandLineCheckBox = new CheckBox();
      this.LauncherRunGameCustomCommandLineTextBox = new TextBox();
      this.LauncherRunGameGroupBox = new GroupBox();
      this.LauncherRunGameMapNameTextBox = new TextBox();
      this.LauncherRunGameLogfileBox = new CheckBox();
      this.LauncherRunGameDeveloperBox = new CheckBox();
      this.LauncherRunGameMapNameLabel = new Label();
      this.LauncherRunGameButton = new Button();
      this.LauncherRunGameCustomCommandLineMPGroupBox = new GroupBox();
      this.LauncherRunGameCustomCommandLineMPCheckBox = new CheckBox();
      this.LauncherRunGameCustomCommandLineMPTextBox = new TextBox();
      this.LauncherRunGameModGroupBox = new GroupBox();
      this.LauncherRunGameModComboBox = new ComboBox();
      this.LauncherRunGameCommandLineTextBox = new TextBox();
      this.LauncherIconBlops = new PictureBox();
      this.LauncherGameGroupBox = new GroupBox();
      this.LauncherGameLogfileBox = new CheckBox();
      this.LauncherGameDeveloperBox = new CheckBox();
      this.LauncherIconMP = new PictureBox();
      this.LauncherIconSP = new PictureBox();
      this.LauncherButtonMP = new Button();
      this.LauncherButtonSP = new Button();
      this.LauncherTab = new TabControl();
      this.LauncherTabModBuilder = new TabPage();
      this.LauncherIwdFileGroupBox = new GroupBox();
      this.LauncherIwdFileTree = new TreeView();
      this.LauncherModGroupBox = new GroupBox();
      this.LauncherModFolderGroupBox = new GroupBox();
      this.LauncherModFolderViewButton = new Button();
      this.LauncherModBuildGroupBox = new GroupBox();
      this.LauncherModBuildLinkerOptionsTextBox = new TextBox();
      this.LauncherModBuildLinkerOptionsLabel = new Label();
      this.LauncherModVerboseCheckBox = new CheckBox();
      this.LauncherModBuildFastFilesCheckBox = new CheckBox();
      this.LauncherModBuildIwdFileCheckBox = new CheckBox();
      this.LauncherModBuildButton = new Button();
      this.LauncherModBuildSoundsCheckBox = new CheckBox();
      this.LauncherModZoneSourceGroupBox = new GroupBox();
      this.LauncherModZoneSourceCSVButton = new Button();
      this.LauncherModZoneSourceMissingAssetsButton = new Button();
      this.LauncherEditZoneSourceButton = new Button();
      this.LauncherModComboBox = new ComboBox();
      this.LauncherTabCompileLevel = new TabPage();
      this.LauncherMapType = new Label();
      this.LauncherMapTypeList = new ComboBox();
      this.LauncherCreateMapButton = new Button();
      this.LauncherDeleteMapButton = new Button();
      this.LauncherCompileLevelOptionsGroupBox = new GroupBox();
      this.LauncherCompileReflectionsCheckBox = new CheckBox();
      this.LauncherGridFileGroupBox = new GroupBox();
      this.LauncherGridEditExistingButton = new Button();
      this.LauncherGridMakeNewButton = new Button();
      this.LauncherGridCollectDotsCheckBox = new CheckBox();
      this.LauncherModSpecificMapComboBox = new ComboBox();
      this.LauncherModSpecificMapCheckBox = new CheckBox();
      this.LauncherCustomRunOptionsLabel = new Label();
      this.LauncherCustomRunOptionsTextBox = new TextBox();
      this.LauncherCompileLevelButton = new Button();
      this.LauncherCompileLightsButton = new Button();
      this.LauncherCompileBSPButton = new Button();
      this.LauncherUseRunGameTypeOptionsCheckBox = new CheckBox();
      this.LauncherRunMapAfterCompileCheckBox = new CheckBox();
      this.LauncherBspInfoCheckBox = new CheckBox();
      this.LauncherBuildFastFilesCheckBox = new CheckBox();
      this.LauncherConnectPathsCheckBox = new CheckBox();
      this.LauncherCompileLightsCheckBox = new CheckBox();
      this.LauncherCompileBSPCheckBox = new CheckBox();
      this.LauncherMapList = new ListBox();
      this.LauncherTabExplore = new TabPage();
      this.LauncherExploreGroupBox = new GroupBox();
      this.LauncherExploreRawMapsDirGroupBox = new GroupBox();
      this.LauncherExploreRawGSCDirMPGametypesButton = new Button();
      this.LauncherExploreRawGSCDirMPFXButton = new Button();
      this.LauncherExploreRawGSCDirMPArtButton = new Button();
      this.LauncherExploreRawGSCDirMPButton = new Button();
      this.LauncherExploreRawGSCDirSPVoiceButton = new Button();
      this.LauncherExploreRawGSCDirSPGametypesButton = new Button();
      this.LauncherExploreRawGSCDirSPFXButton = new Button();
      this.LauncherExploreRawGSCDirSPArtButton = new Button();
      this.LauncherExploreRawGSCDirSPButton = new Button();
      this.LauncherExploreRawDirGroupBox = new GroupBox();
      this.LauncherExploreRawDirFXButton = new Button();
      this.LauncherExploreRawDirMPButton = new Button();
      this.LauncherExploreRawDirWeaponsButton = new Button();
      this.LauncherExploreRawDirVisionButton = new Button();
      this.LauncherExploreRawDirLocsButton = new Button();
      this.LauncherExploreRawDirAnimTreesButton = new Button();
      this.LauncherExploreRawDirSoundAliasesButton = new Button();
      this.LauncherExploreRawDirCSCButton = new Button();
      this.LauncherExploreRawDirGSCButton = new Button();
      this.LauncherExploreDevDirGroupBox = new GroupBox();
      this.LauncherExploreDevDirRawButton = new Button();
      this.LauncherExploreDevDirModelExportButton = new Button();
      this.LauncherExploreDevDirTextureAssetsButton = new Button();
      this.LauncherExploreDevDirSrcDataButton = new Button();
      this.LauncherExploreDevDirMapSrcButton = new Button();
      this.LauncherExploreDevDirBinButton = new Button();
      this.LauncherExploreDevDirZoneSourceButton = new Button();
      this.LauncherExploreBlopsDirGroupBox = new GroupBox();
      this.LauncherExploreBlopsDirConfigsButton = new Button();
      this.LauncherExploreBlopsDirModsButton = new Button();
      this.LauncherExploreBlopsDirGameButton = new Button();
      this.LauncherApplicationsGroupBox = new GroupBox();
      this.LauncherIconRadiant = new PictureBox();
      this.LauncherIconEffectsEditor = new PictureBox();
      this.LauncherIconConverter = new PictureBox();
      this.LauncherIconAssetViewer = new PictureBox();
      this.LauncherIconAssetManager = new PictureBox();
      this.LauncherButtonAssetViewer = new Button();
      this.LauncherButtonRunConverter = new Button();
      this.LauncherButtonAssetManager = new Button();
      this.LauncherButtonEffectsEd = new Button();
      this.LauncherButtonRadiant = new Button();
      this.LauncherWarningsCounter = new Label();
      this.LauncherWarningsNumericUpDown = new NumericUpDown();
      this.LauncherWarningsPictureBox = new PictureBox();
      this.LauncherWarningsLabel = new Label();
      this.LauncherErrorsCounter = new Label();
      this.LauncherErrorsNumericUpDown = new NumericUpDown();
      this.LauncherErrorsPictureBox = new PictureBox();
      this.LauncherErrorsLabel = new Label();
      this.LauncherScrollBottomConsoleButton = new Button();
      this.LauncherSaveConsoleButton = new Button();
      this.LauncherProcessTimeElapsedTextBox = new TextBox();
      this.LauncherClearConsoleButton = new Button();
      this.LauncherProcessGroupBox = new GroupBox();
      this.LauncherButtonCancel = new Button();
      this.LauncherProcessList = new ListBox();
      this.LauncherProcessTextBox = new TextBox();
      this.LauncherTimer = new System.Windows.Forms.Timer(this.components);
      this.LauncherMapFilesSystemWatcher = new FileSystemWatcher();
      this.LauncherModsDirectorySystemWatcher = new FileSystemWatcher();
      this.menuStrip1 = new MenuStrip();
      this.LauncherfileToolStripMenuItem = new ToolStripMenuItem();
      this.newModToolStripMenuItem = new ToolStripMenuItem();
      this.LaunchernewMapToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.gameDirToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.LauncherexitToolStripMenuItem = new ToolStripMenuItem();
      this.LauncherdocsToolStripMenuItem = new ToolStripMenuItem();
      this.mayaExporterToolStripMenuItem = new ToolStripMenuItem();
      this.exporterTutorialToolStripMenuItem = new ToolStripMenuItem();
      this.LaunchertoolsToolStripMenuItem = new ToolStripMenuItem();
      this.mayaPluginSetupToolStripMenuItem = new ToolStripMenuItem();
      this.LauncherhelpToolStripMenuItem = new ToolStripMenuItem();
      this.LauncherwikiToolStripMenuItem = new ToolStripMenuItem();
      this.LauncherRadiantToolTip = new ToolTip(this.components);
      this.LauncherEffectsEdToolTip = new ToolTip(this.components);
      this.LauncherAssetManagerToolTip = new ToolTip(this.components);
      this.LauncherAssetViewerToolTip = new ToolTip(this.components);
      this.LauncherConverterToolTip = new ToolTip(this.components);
      this.SaveConsoleToolTip = new ToolTip(this.components);
      this.LauncherScrollBottomConsoleToolTip = new ToolTip(this.components);
      this.LauncherMapListContextMenuStrip = new ContextMenuStrip(this.components);
      this.runToolStripMenuItem = new ToolStripMenuItem();
      this.editToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.deleteToolStripMenuItem = new ToolStripMenuItem();
      this.renameToolStripMenuItem = new ToolStripMenuItem();
      Label label = new Label();
      this.LauncherSplitter.Panel1.SuspendLayout();
      this.LauncherSplitter.Panel2.SuspendLayout();
      this.LauncherSplitter.SuspendLayout();
      this.panel1.SuspendLayout();
      this.LauncherRunGameCustomCommandLineGroupBox.SuspendLayout();
      this.LauncherRunGameGroupBox.SuspendLayout();
      this.LauncherRunGameCustomCommandLineMPGroupBox.SuspendLayout();
      this.LauncherRunGameModGroupBox.SuspendLayout();
      ((ISupportInitialize) this.LauncherIconBlops).BeginInit();
      this.LauncherGameGroupBox.SuspendLayout();
      ((ISupportInitialize) this.LauncherIconMP).BeginInit();
      ((ISupportInitialize) this.LauncherIconSP).BeginInit();
      this.LauncherTab.SuspendLayout();
      this.LauncherTabModBuilder.SuspendLayout();
      this.LauncherIwdFileGroupBox.SuspendLayout();
      this.LauncherModGroupBox.SuspendLayout();
      this.LauncherModFolderGroupBox.SuspendLayout();
      this.LauncherModBuildGroupBox.SuspendLayout();
      this.LauncherModZoneSourceGroupBox.SuspendLayout();
      this.LauncherTabCompileLevel.SuspendLayout();
      this.LauncherCompileLevelOptionsGroupBox.SuspendLayout();
      this.LauncherGridFileGroupBox.SuspendLayout();
      this.LauncherTabExplore.SuspendLayout();
      this.LauncherExploreGroupBox.SuspendLayout();
      this.LauncherExploreRawMapsDirGroupBox.SuspendLayout();
      this.LauncherExploreRawDirGroupBox.SuspendLayout();
      this.LauncherExploreDevDirGroupBox.SuspendLayout();
      this.LauncherExploreBlopsDirGroupBox.SuspendLayout();
      this.LauncherApplicationsGroupBox.SuspendLayout();
      ((ISupportInitialize) this.LauncherIconRadiant).BeginInit();
      ((ISupportInitialize) this.LauncherIconEffectsEditor).BeginInit();
      ((ISupportInitialize) this.LauncherIconConverter).BeginInit();
      ((ISupportInitialize) this.LauncherIconAssetViewer).BeginInit();
      ((ISupportInitialize) this.LauncherIconAssetManager).BeginInit();
      this.LauncherWarningsNumericUpDown.BeginInit();
      ((ISupportInitialize) this.LauncherWarningsPictureBox).BeginInit();
      this.LauncherErrorsNumericUpDown.BeginInit();
      ((ISupportInitialize) this.LauncherErrorsPictureBox).BeginInit();
      this.LauncherProcessGroupBox.SuspendLayout();
      this.LauncherMapFilesSystemWatcher.BeginInit();
      this.LauncherModsDirectorySystemWatcher.BeginInit();
      this.menuStrip1.SuspendLayout();
      this.LauncherMapListContextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      label.BackColor = Color.Gainsboro;
      label.CausesValidation = false;
      label.FlatStyle = FlatStyle.Flat;
      label.Location = new Point(0, 107);
      label.Name = "LauncherCompileLevelOptionsSplitterGroupBox";
      label.Size = new Size(473, 1);
      label.TabIndex = 12;
      this.LauncherConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherConsole.BackColor = SystemColors.InfoText;
      this.LauncherConsole.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.LauncherConsole.ForeColor = SystemColors.ScrollBar;
      this.LauncherConsole.Location = new Point(149, 3);
      this.LauncherConsole.Name = "LauncherConsole";
      this.LauncherConsole.ReadOnly = true;
      this.LauncherConsole.Size = new Size(802, 242);
      this.LauncherConsole.TabIndex = 0;
      this.LauncherConsole.Text = "";
      this.LauncherConsole.WordWrap = false;
      this.LauncherSplitter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherSplitter.BackColor = SystemColors.Control;
      this.LauncherSplitter.FixedPanel = FixedPanel.Panel1;
      this.LauncherSplitter.Location = new Point(12, 23);
      this.LauncherSplitter.Name = "LauncherSplitter";
      this.LauncherSplitter.Orientation = Orientation.Horizontal;
      this.LauncherSplitter.Panel1.Controls.Add((Control) this.panel1);
      this.LauncherSplitter.Panel1.Controls.Add((Control) this.LauncherRunGameCommandLineTextBox);
      this.LauncherSplitter.Panel1.Controls.Add((Control) this.LauncherIconBlops);
      this.LauncherSplitter.Panel1.Controls.Add((Control) this.LauncherGameGroupBox);
      this.LauncherSplitter.Panel1.Controls.Add((Control) this.LauncherTab);
      this.LauncherSplitter.Panel1.Controls.Add((Control) this.LauncherApplicationsGroupBox);
      this.LauncherSplitter.Panel1MinSize = 380;
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherWarningsCounter);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherWarningsNumericUpDown);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherWarningsPictureBox);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherWarningsLabel);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherErrorsCounter);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherErrorsNumericUpDown);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherErrorsPictureBox);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherErrorsLabel);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherScrollBottomConsoleButton);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherSaveConsoleButton);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherProcessTimeElapsedTextBox);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherConsole);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherClearConsoleButton);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherProcessGroupBox);
      this.LauncherSplitter.Panel2.Controls.Add((Control) this.LauncherProcessTextBox);
      this.LauncherSplitter.Panel2MinSize = 100;
      this.LauncherSplitter.Size = new Size(954, 653);
      this.LauncherSplitter.SplitterDistance = 380;
      this.LauncherSplitter.TabIndex = 1;
      this.panel1.Controls.Add((Control) this.LauncherRunGameCustomCommandLineGroupBox);
      this.panel1.Controls.Add((Control) this.LauncherRunGameGroupBox);
      this.panel1.Controls.Add((Control) this.LauncherRunGameCustomCommandLineMPGroupBox);
      this.panel1.Controls.Add((Control) this.LauncherRunGameModGroupBox);
      this.panel1.Dock = DockStyle.Right;
      this.panel1.Location = new Point(804, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(150, 380);
      this.panel1.TabIndex = 10;
      this.LauncherRunGameCustomCommandLineGroupBox.Controls.Add((Control) this.LauncherRunGameCustomCommandLineCheckBox);
      this.LauncherRunGameCustomCommandLineGroupBox.Controls.Add((Control) this.LauncherRunGameCustomCommandLineTextBox);
      this.LauncherRunGameCustomCommandLineGroupBox.Location = new Point(3, 49);
      this.LauncherRunGameCustomCommandLineGroupBox.Name = "LauncherRunGameCustomCommandLineGroupBox";
      this.LauncherRunGameCustomCommandLineGroupBox.Size = new Size(145, 63);
      this.LauncherRunGameCustomCommandLineGroupBox.TabIndex = 4;
      this.LauncherRunGameCustomCommandLineGroupBox.TabStop = false;
      this.LauncherRunGameCustomCommandLineGroupBox.Text = "Singleplayer Options";
      this.LauncherRunGameCustomCommandLineCheckBox.AutoSize = true;
      this.LauncherRunGameCustomCommandLineCheckBox.Location = new Point(6, 15);
      this.LauncherRunGameCustomCommandLineCheckBox.Name = "LauncherRunGameCustomCommandLineCheckBox";
      this.LauncherRunGameCustomCommandLineCheckBox.Size = new Size(65, 17);
      this.LauncherRunGameCustomCommandLineCheckBox.TabIndex = 1;
      this.LauncherRunGameCustomCommandLineCheckBox.Text = "Enabled";
      this.LauncherRunGameCustomCommandLineCheckBox.UseVisualStyleBackColor = true;
      this.LauncherRunGameCustomCommandLineTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherRunGameCustomCommandLineTextBox.Location = new Point(6, 37);
      this.LauncherRunGameCustomCommandLineTextBox.Name = "LauncherRunGameCustomCommandLineTextBox";
      this.LauncherRunGameCustomCommandLineTextBox.Size = new Size(136, 20);
      this.LauncherRunGameCustomCommandLineTextBox.TabIndex = 0;
      this.LauncherRunGameCustomCommandLineTextBox.TextChanged += new EventHandler(this.LauncherRunGameCustomCommandLineTextBox_TextChanged);
      this.LauncherRunGameCustomCommandLineTextBox.Validating += new CancelEventHandler(this.LauncherRunGameCustomCommandLineTextBox_Validating);
      this.LauncherRunGameGroupBox.Controls.Add((Control) this.LauncherRunGameMapNameTextBox);
      this.LauncherRunGameGroupBox.Controls.Add((Control) this.LauncherRunGameLogfileBox);
      this.LauncherRunGameGroupBox.Controls.Add((Control) this.LauncherRunGameDeveloperBox);
      this.LauncherRunGameGroupBox.Controls.Add((Control) this.LauncherRunGameMapNameLabel);
      this.LauncherRunGameGroupBox.Controls.Add((Control) this.LauncherRunGameButton);
      this.LauncherRunGameGroupBox.Location = new Point(3, 181);
      this.LauncherRunGameGroupBox.Name = "LauncherRunGameGroupBox";
      this.LauncherRunGameGroupBox.Size = new Size(145, 93);
      this.LauncherRunGameGroupBox.TabIndex = 11;
      this.LauncherRunGameGroupBox.TabStop = false;
      this.LauncherRunGameGroupBox.Text = "Run";
      this.LauncherRunGameMapNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherRunGameMapNameTextBox.Location = new Point(32, 19);
      this.LauncherRunGameMapNameTextBox.Multiline = true;
      this.LauncherRunGameMapNameTextBox.Name = "LauncherRunGameMapNameTextBox";
      this.LauncherRunGameMapNameTextBox.ReadOnly = true;
      this.LauncherRunGameMapNameTextBox.Size = new Size(110, 19);
      this.LauncherRunGameMapNameTextBox.TabIndex = 18;
      this.LauncherRunGameLogfileBox.AutoSize = true;
      this.LauncherRunGameLogfileBox.Location = new Point(82, 44);
      this.LauncherRunGameLogfileBox.Name = "LauncherRunGameLogfileBox";
      this.LauncherRunGameLogfileBox.Size = new Size(57, 17);
      this.LauncherRunGameLogfileBox.TabIndex = 17;
      this.LauncherRunGameLogfileBox.Text = "Logfile";
      this.LauncherRunGameLogfileBox.UseVisualStyleBackColor = true;
      this.LauncherRunGameDeveloperBox.AutoSize = true;
      this.LauncherRunGameDeveloperBox.Location = new Point(6, 44);
      this.LauncherRunGameDeveloperBox.Name = "LauncherRunGameDeveloperBox";
      this.LauncherRunGameDeveloperBox.Size = new Size(75, 17);
      this.LauncherRunGameDeveloperBox.TabIndex = 16;
      this.LauncherRunGameDeveloperBox.Text = "Developer";
      this.LauncherRunGameDeveloperBox.UseVisualStyleBackColor = true;
      this.LauncherRunGameMapNameLabel.AutoSize = true;
      this.LauncherRunGameMapNameLabel.Location = new Point(3, 25);
      this.LauncherRunGameMapNameLabel.Name = "LauncherRunGameMapNameLabel";
      this.LauncherRunGameMapNameLabel.Size = new Size(28, 13);
      this.LauncherRunGameMapNameLabel.TabIndex = 15;
      this.LauncherRunGameMapNameLabel.Text = "Map";
      this.LauncherRunGameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherRunGameButton.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.LauncherRunGameButton.Location = new Point(6, 63);
      this.LauncherRunGameButton.Name = "LauncherRunGameButton";
      this.LauncherRunGameButton.Size = new Size(133, 24);
      this.LauncherRunGameButton.TabIndex = 2;
      this.LauncherRunGameButton.Text = "Run";
      this.LauncherRunGameButton.UseVisualStyleBackColor = true;
      this.LauncherRunGameButton.Click += new EventHandler(this.LauncherRunGameButton_Click);
      this.LauncherRunGameCustomCommandLineMPGroupBox.Controls.Add((Control) this.LauncherRunGameCustomCommandLineMPCheckBox);
      this.LauncherRunGameCustomCommandLineMPGroupBox.Controls.Add((Control) this.LauncherRunGameCustomCommandLineMPTextBox);
      this.LauncherRunGameCustomCommandLineMPGroupBox.Location = new Point(3, 118);
      this.LauncherRunGameCustomCommandLineMPGroupBox.Name = "LauncherRunGameCustomCommandLineMPGroupBox";
      this.LauncherRunGameCustomCommandLineMPGroupBox.Size = new Size(145, 63);
      this.LauncherRunGameCustomCommandLineMPGroupBox.TabIndex = 5;
      this.LauncherRunGameCustomCommandLineMPGroupBox.TabStop = false;
      this.LauncherRunGameCustomCommandLineMPGroupBox.Text = "Multiplayer Options";
      this.LauncherRunGameCustomCommandLineMPCheckBox.AutoSize = true;
      this.LauncherRunGameCustomCommandLineMPCheckBox.Location = new Point(6, 14);
      this.LauncherRunGameCustomCommandLineMPCheckBox.Name = "LauncherRunGameCustomCommandLineMPCheckBox";
      this.LauncherRunGameCustomCommandLineMPCheckBox.Size = new Size(65, 17);
      this.LauncherRunGameCustomCommandLineMPCheckBox.TabIndex = 2;
      this.LauncherRunGameCustomCommandLineMPCheckBox.Text = "Enabled";
      this.LauncherRunGameCustomCommandLineMPCheckBox.UseVisualStyleBackColor = true;
      this.LauncherRunGameCustomCommandLineMPTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherRunGameCustomCommandLineMPTextBox.Location = new Point(6, 37);
      this.LauncherRunGameCustomCommandLineMPTextBox.Name = "LauncherRunGameCustomCommandLineMPTextBox";
      this.LauncherRunGameCustomCommandLineMPTextBox.Size = new Size(136, 20);
      this.LauncherRunGameCustomCommandLineMPTextBox.TabIndex = 0;
      this.LauncherRunGameModGroupBox.Controls.Add((Control) this.LauncherRunGameModComboBox);
      this.LauncherRunGameModGroupBox.Location = new Point(3, 4);
      this.LauncherRunGameModGroupBox.Name = "LauncherRunGameModGroupBox";
      this.LauncherRunGameModGroupBox.Size = new Size(145, 42);
      this.LauncherRunGameModGroupBox.TabIndex = 1;
      this.LauncherRunGameModGroupBox.TabStop = false;
      this.LauncherRunGameModGroupBox.Text = "Mod";
      this.LauncherRunGameModComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherRunGameModComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.LauncherRunGameModComboBox.FormattingEnabled = true;
      this.LauncherRunGameModComboBox.Location = new Point(6, 18);
      this.LauncherRunGameModComboBox.Name = "LauncherRunGameModComboBox";
      this.LauncherRunGameModComboBox.Size = new Size(136, 21);
      this.LauncherRunGameModComboBox.TabIndex = 0;
      this.LauncherRunGameCommandLineTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherRunGameCommandLineTextBox.Location = new Point(147, 357);
      this.LauncherRunGameCommandLineTextBox.Name = "LauncherRunGameCommandLineTextBox";
      this.LauncherRunGameCommandLineTextBox.ReadOnly = true;
      this.LauncherRunGameCommandLineTextBox.Size = new Size(648, 20);
      this.LauncherRunGameCommandLineTextBox.TabIndex = 14;
      this.LauncherIconBlops.BackgroundImage = (Image) Resources.blops;
      this.LauncherIconBlops.BackgroundImageLayout = ImageLayout.Center;
      this.LauncherIconBlops.Location = new Point(5, 3);
      this.LauncherIconBlops.Name = "LauncherIconBlops";
      this.LauncherIconBlops.Size = new Size(138, 108);
      this.LauncherIconBlops.TabIndex = 9;
      this.LauncherIconBlops.TabStop = false;
      this.LauncherGameGroupBox.Controls.Add((Control) this.LauncherGameLogfileBox);
      this.LauncherGameGroupBox.Controls.Add((Control) this.LauncherGameDeveloperBox);
      this.LauncherGameGroupBox.Controls.Add((Control) this.LauncherIconMP);
      this.LauncherGameGroupBox.Controls.Add((Control) this.LauncherIconSP);
      this.LauncherGameGroupBox.Controls.Add((Control) this.LauncherButtonMP);
      this.LauncherGameGroupBox.Controls.Add((Control) this.LauncherButtonSP);
      this.LauncherGameGroupBox.Location = new Point(4, 115);
      this.LauncherGameGroupBox.Name = "LauncherGameGroupBox";
      this.LauncherGameGroupBox.Size = new Size(139, 65);
      this.LauncherGameGroupBox.TabIndex = 10;
      this.LauncherGameGroupBox.TabStop = false;
      this.LauncherGameGroupBox.Text = "Game";
      this.LauncherGameLogfileBox.AutoSize = true;
      this.LauncherGameLogfileBox.Location = new Point(81, 16);
      this.LauncherGameLogfileBox.Name = "LauncherGameLogfileBox";
      this.LauncherGameLogfileBox.Size = new Size(57, 17);
      this.LauncherGameLogfileBox.TabIndex = 22;
      this.LauncherGameLogfileBox.Text = "Logfile";
      this.LauncherGameLogfileBox.UseVisualStyleBackColor = true;
      this.LauncherGameDeveloperBox.AutoSize = true;
      this.LauncherGameDeveloperBox.Location = new Point(5, 16);
      this.LauncherGameDeveloperBox.Name = "LauncherGameDeveloperBox";
      this.LauncherGameDeveloperBox.Size = new Size(75, 17);
      this.LauncherGameDeveloperBox.TabIndex = 21;
      this.LauncherGameDeveloperBox.Text = "Developer";
      this.LauncherGameDeveloperBox.UseVisualStyleBackColor = true;
      this.LauncherIconMP.BackgroundImage = (Image) Resources.icon_mp;
      this.LauncherIconMP.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconMP.Enabled = false;
      this.LauncherIconMP.Location = new Point(85, 39);
      this.LauncherIconMP.Name = "LauncherIconMP";
      this.LauncherIconMP.Size = new Size(16, 16);
      this.LauncherIconMP.TabIndex = 20;
      this.LauncherIconMP.TabStop = false;
      this.LauncherIconSP.BackgroundImage = (Image) Resources.icon_sp;
      this.LauncherIconSP.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconSP.Enabled = false;
      this.LauncherIconSP.Location = new Point(24, 39);
      this.LauncherIconSP.Name = "LauncherIconSP";
      this.LauncherIconSP.Size = new Size(16, 16);
      this.LauncherIconSP.TabIndex = 11;
      this.LauncherIconSP.TabStop = false;
      this.LauncherButtonMP.Location = new Point(71, 35);
      this.LauncherButtonMP.Name = "LauncherButtonMP";
      this.LauncherButtonMP.Size = new Size(64, 24);
      this.LauncherButtonMP.TabIndex = 1;
      this.LauncherButtonMP.Text = "     MP";
      this.LauncherButtonMP.UseVisualStyleBackColor = true;
      this.LauncherButtonMP.Click += new EventHandler(this.LauncherButtonMP_Click);
      this.LauncherButtonSP.Location = new Point(8, 35);
      this.LauncherButtonSP.Name = "LauncherButtonSP";
      this.LauncherButtonSP.Size = new Size(64, 24);
      this.LauncherButtonSP.TabIndex = 0;
      this.LauncherButtonSP.Text = "     SP";
      this.LauncherButtonSP.UseVisualStyleBackColor = true;
      this.LauncherButtonSP.Click += new EventHandler(this.LauncherButtonSP_Click);
      this.LauncherTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherTab.Controls.Add((Control) this.LauncherTabModBuilder);
      this.LauncherTab.Controls.Add((Control) this.LauncherTabCompileLevel);
      this.LauncherTab.Controls.Add((Control) this.LauncherTabExplore);
      this.LauncherTab.Location = new Point(149, 1);
      this.LauncherTab.Name = "LauncherTab";
      this.LauncherTab.SelectedIndex = 0;
      this.LauncherTab.Size = new Size(649, 350);
      this.LauncherTab.TabIndex = 0;
      this.LauncherTabModBuilder.Controls.Add((Control) this.LauncherIwdFileGroupBox);
      this.LauncherTabModBuilder.Controls.Add((Control) this.LauncherModGroupBox);
      this.LauncherTabModBuilder.Location = new Point(4, 22);
      this.LauncherTabModBuilder.Name = "LauncherTabModBuilder";
      this.LauncherTabModBuilder.Padding = new Padding(3);
      this.LauncherTabModBuilder.Size = new Size(641, 324);
      this.LauncherTabModBuilder.TabIndex = 1;
      this.LauncherTabModBuilder.Text = "Mod Builder";
      this.LauncherTabModBuilder.UseVisualStyleBackColor = true;
      this.LauncherIwdFileGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherIwdFileGroupBox.Controls.Add((Control) this.LauncherIwdFileTree);
      this.LauncherIwdFileGroupBox.Location = new Point(298, 6);
      this.LauncherIwdFileGroupBox.Name = "LauncherIwdFileGroupBox";
      this.LauncherIwdFileGroupBox.Size = new Size(340, 312);
      this.LauncherIwdFileGroupBox.TabIndex = 2;
      this.LauncherIwdFileGroupBox.TabStop = false;
      this.LauncherIwdFileGroupBox.Text = "IWD File List";
      this.LauncherIwdFileTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherIwdFileTree.CheckBoxes = true;
      this.LauncherIwdFileTree.Indent = 15;
      this.LauncherIwdFileTree.Location = new Point(6, 19);
      this.LauncherIwdFileTree.Name = "LauncherIwdFileTree";
      this.LauncherIwdFileTree.Size = new Size(328, 287);
      this.LauncherIwdFileTree.TabIndex = 1;
      this.LauncherIwdFileTree.AfterCheck += new TreeViewEventHandler(this.LauncherIwdFileTree_AfterCheck);
      this.LauncherIwdFileTree.DoubleClick += new EventHandler(this.LauncherIwdFileTree_DoubleClick);
      this.LauncherModGroupBox.Controls.Add((Control) this.LauncherModFolderGroupBox);
      this.LauncherModGroupBox.Controls.Add((Control) this.LauncherModBuildGroupBox);
      this.LauncherModGroupBox.Controls.Add((Control) this.LauncherModZoneSourceGroupBox);
      this.LauncherModGroupBox.Controls.Add((Control) this.LauncherModComboBox);
      this.LauncherModGroupBox.Location = new Point(6, 6);
      this.LauncherModGroupBox.Name = "LauncherModGroupBox";
      this.LauncherModGroupBox.Size = new Size(286, 312);
      this.LauncherModGroupBox.TabIndex = 4;
      this.LauncherModGroupBox.TabStop = false;
      this.LauncherModGroupBox.Text = "Mod";
      this.LauncherModFolderGroupBox.Controls.Add((Control) this.LauncherModFolderViewButton);
      this.LauncherModFolderGroupBox.Location = new Point(7, 262);
      this.LauncherModFolderGroupBox.Name = "LauncherModFolderGroupBox";
      this.LauncherModFolderGroupBox.Size = new Size(273, 44);
      this.LauncherModFolderGroupBox.TabIndex = 24;
      this.LauncherModFolderGroupBox.TabStop = false;
      this.LauncherModFolderGroupBox.Text = "Mod Folder";
      this.LauncherModFolderViewButton.Location = new Point(6, 16);
      this.LauncherModFolderViewButton.Name = "LauncherModFolderViewButton";
      this.LauncherModFolderViewButton.Size = new Size(262, 24);
      this.LauncherModFolderViewButton.TabIndex = 0;
      this.LauncherModFolderViewButton.Text = "View Mod";
      this.LauncherModFolderViewButton.UseVisualStyleBackColor = true;
      this.LauncherModFolderViewButton.Click += new EventHandler(this.LauncherModFolderViewButton_Click);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModBuildLinkerOptionsTextBox);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModBuildLinkerOptionsLabel);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModVerboseCheckBox);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModBuildFastFilesCheckBox);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModBuildIwdFileCheckBox);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModBuildButton);
      this.LauncherModBuildGroupBox.Controls.Add((Control) this.LauncherModBuildSoundsCheckBox);
      this.LauncherModBuildGroupBox.Location = new Point(7, 136);
      this.LauncherModBuildGroupBox.Name = "LauncherModBuildGroupBox";
      this.LauncherModBuildGroupBox.Size = new Size(273, 120);
      this.LauncherModBuildGroupBox.TabIndex = 23;
      this.LauncherModBuildGroupBox.TabStop = false;
      this.LauncherModBuildGroupBox.Text = "Build Mod";
      this.LauncherModBuildLinkerOptionsTextBox.Location = new Point(128, 61);
      this.LauncherModBuildLinkerOptionsTextBox.Name = "LauncherModBuildLinkerOptionsTextBox";
      this.LauncherModBuildLinkerOptionsTextBox.Size = new Size(137, 20);
      this.LauncherModBuildLinkerOptionsTextBox.TabIndex = 24;
      this.LauncherModBuildLinkerOptionsLabel.AutoSize = true;
      this.LauncherModBuildLinkerOptionsLabel.Location = new Point(6, 64);
      this.LauncherModBuildLinkerOptionsLabel.Name = "LauncherModBuildLinkerOptionsLabel";
      this.LauncherModBuildLinkerOptionsLabel.Size = new Size(116, 13);
      this.LauncherModBuildLinkerOptionsLabel.TabIndex = 23;
      this.LauncherModBuildLinkerOptionsLabel.Text = "Custom Linker Options:";
      this.LauncherModVerboseCheckBox.AutoSize = true;
      this.LauncherModVerboseCheckBox.Location = new Point(6, 42);
      this.LauncherModVerboseCheckBox.Name = "LauncherModVerboseCheckBox";
      this.LauncherModVerboseCheckBox.Size = new Size(195, 17);
      this.LauncherModVerboseCheckBox.TabIndex = 22;
      this.LauncherModVerboseCheckBox.Text = "Verbose (More Detailed Information)";
      this.LauncherModVerboseCheckBox.UseVisualStyleBackColor = true;
      this.LauncherModBuildFastFilesCheckBox.AutoSize = true;
      this.LauncherModBuildFastFilesCheckBox.Location = new Point(6, 19);
      this.LauncherModBuildFastFilesCheckBox.Name = "LauncherModBuildFastFilesCheckBox";
      this.LauncherModBuildFastFilesCheckBox.Size = new Size(85, 17);
      this.LauncherModBuildFastFilesCheckBox.TabIndex = 21;
      this.LauncherModBuildFastFilesCheckBox.Text = "Link FastFile";
      this.LauncherModBuildFastFilesCheckBox.UseVisualStyleBackColor = true;
      this.LauncherModBuildIwdFileCheckBox.AutoSize = true;
      this.LauncherModBuildIwdFileCheckBox.Location = new Point(97, 19);
      this.LauncherModBuildIwdFileCheckBox.Name = "LauncherModBuildIwdFileCheckBox";
      this.LauncherModBuildIwdFileCheckBox.Size = new Size(74, 17);
      this.LauncherModBuildIwdFileCheckBox.TabIndex = 20;
      this.LauncherModBuildIwdFileCheckBox.Text = "Build IWD";
      this.LauncherModBuildIwdFileCheckBox.UseVisualStyleBackColor = true;
      this.LauncherModBuildButton.Location = new Point(6, 88);
      this.LauncherModBuildButton.Name = "LauncherModBuildButton";
      this.LauncherModBuildButton.Size = new Size(262, 24);
      this.LauncherModBuildButton.TabIndex = 19;
      this.LauncherModBuildButton.Text = "Build Mod";
      this.LauncherModBuildButton.UseVisualStyleBackColor = true;
      this.LauncherModBuildButton.Click += new EventHandler(this.LauncherModBuildButton_Click);
      this.LauncherModBuildSoundsCheckBox.AutoSize = true;
      this.LauncherModBuildSoundsCheckBox.Enabled = false;
      this.LauncherModBuildSoundsCheckBox.Location = new Point(177, 19);
      this.LauncherModBuildSoundsCheckBox.Name = "LauncherModBuildSoundsCheckBox";
      this.LauncherModBuildSoundsCheckBox.Size = new Size(88, 17);
      this.LauncherModBuildSoundsCheckBox.TabIndex = 18;
      this.LauncherModBuildSoundsCheckBox.Text = "Build Sounds";
      this.LauncherModBuildSoundsCheckBox.UseVisualStyleBackColor = true;
      this.LauncherModBuildSoundsCheckBox.Visible = false;
      this.LauncherModZoneSourceGroupBox.Controls.Add((Control) this.LauncherModZoneSourceCSVButton);
      this.LauncherModZoneSourceGroupBox.Controls.Add((Control) this.LauncherModZoneSourceMissingAssetsButton);
      this.LauncherModZoneSourceGroupBox.Controls.Add((Control) this.LauncherEditZoneSourceButton);
      this.LauncherModZoneSourceGroupBox.Location = new Point(6, 47);
      this.LauncherModZoneSourceGroupBox.Name = "LauncherModZoneSourceGroupBox";
      this.LauncherModZoneSourceGroupBox.Size = new Size(274, 83);
      this.LauncherModZoneSourceGroupBox.TabIndex = 22;
      this.LauncherModZoneSourceGroupBox.TabStop = false;
      this.LauncherModZoneSourceGroupBox.Text = "FastFile Zone Source";
      this.LauncherModZoneSourceCSVButton.Location = new Point(138, 50);
      this.LauncherModZoneSourceCSVButton.Name = "LauncherModZoneSourceCSVButton";
      this.LauncherModZoneSourceCSVButton.Size = new Size(130, 23);
      this.LauncherModZoneSourceCSVButton.TabIndex = 24;
      this.LauncherModZoneSourceCSVButton.Text = "Zone Source";
      this.LauncherModZoneSourceCSVButton.UseVisualStyleBackColor = true;
      this.LauncherModZoneSourceCSVButton.Click += new EventHandler(this.LauncherModZoneSourceCSVButton_Click);
      this.LauncherModZoneSourceMissingAssetsButton.Location = new Point(6, 50);
      this.LauncherModZoneSourceMissingAssetsButton.Name = "LauncherModZoneSourceMissingAssetsButton";
      this.LauncherModZoneSourceMissingAssetsButton.Size = new Size(130, 23);
      this.LauncherModZoneSourceMissingAssetsButton.TabIndex = 23;
      this.LauncherModZoneSourceMissingAssetsButton.Text = "Missing Assets";
      this.LauncherModZoneSourceMissingAssetsButton.UseVisualStyleBackColor = true;
      this.LauncherModZoneSourceMissingAssetsButton.Click += new EventHandler(this.LauncherModZoneSourceMissingAssetsButton_Click);
      this.LauncherEditZoneSourceButton.Location = new Point(6, 19);
      this.LauncherEditZoneSourceButton.Name = "LauncherEditZoneSourceButton";
      this.LauncherEditZoneSourceButton.Size = new Size(262, 24);
      this.LauncherEditZoneSourceButton.TabIndex = 22;
      this.LauncherEditZoneSourceButton.Text = "Edit Zone Source";
      this.LauncherEditZoneSourceButton.UseVisualStyleBackColor = true;
      this.LauncherEditZoneSourceButton.Click += new EventHandler(this.LauncherEditZoneSourceButton_Click);
      this.LauncherModComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.LauncherModComboBox.FormattingEnabled = true;
      this.LauncherModComboBox.Location = new Point(6, 20);
      this.LauncherModComboBox.Name = "LauncherModComboBox";
      this.LauncherModComboBox.Size = new Size(274, 21);
      this.LauncherModComboBox.TabIndex = 3;
      this.LauncherModComboBox.SelectedIndexChanged += new EventHandler(this.LauncherModComboBox_SelectedIndexChanged);
      this.LauncherTabCompileLevel.Controls.Add((Control) this.LauncherMapType);
      this.LauncherTabCompileLevel.Controls.Add((Control) this.LauncherMapTypeList);
      this.LauncherTabCompileLevel.Controls.Add((Control) this.LauncherCreateMapButton);
      this.LauncherTabCompileLevel.Controls.Add((Control) this.LauncherDeleteMapButton);
      this.LauncherTabCompileLevel.Controls.Add((Control) this.LauncherCompileLevelOptionsGroupBox);
      this.LauncherTabCompileLevel.Controls.Add((Control) this.LauncherMapList);
      this.LauncherTabCompileLevel.Location = new Point(4, 22);
      this.LauncherTabCompileLevel.Name = "LauncherTabCompileLevel";
      this.LauncherTabCompileLevel.Padding = new Padding(3);
      this.LauncherTabCompileLevel.Size = new Size(641, 324);
      this.LauncherTabCompileLevel.TabIndex = 0;
      this.LauncherTabCompileLevel.Text = "Level";
      this.LauncherTabCompileLevel.UseVisualStyleBackColor = true;
      this.LauncherMapType.AutoSize = true;
      this.LauncherMapType.Location = new Point(6, 9);
      this.LauncherMapType.Name = "LauncherMapType";
      this.LauncherMapType.Size = new Size(34, 13);
      this.LauncherMapType.TabIndex = 6;
      this.LauncherMapType.Text = "Type:";
      this.LauncherMapTypeList.DropDownStyle = ComboBoxStyle.DropDownList;
      this.LauncherMapTypeList.FormattingEnabled = true;
      this.LauncherMapTypeList.Items.AddRange(new object[2]
      {
        (object) "Singleplayer",
        (object) "Multiplayer"
      });
      this.LauncherMapTypeList.Location = new Point(46, 4);
      this.LauncherMapTypeList.Name = "LauncherMapTypeList";
      this.LauncherMapTypeList.Size = new Size(110, 21);
      this.LauncherMapTypeList.TabIndex = 5;
      this.LauncherMapTypeList.SelectedIndexChanged += new EventHandler(this.LauncherMapTypeList_SelectedIndexChanged);
      this.LauncherCreateMapButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.LauncherCreateMapButton.Location = new Point(82, 294);
      this.LauncherCreateMapButton.Name = "LauncherCreateMapButton";
      this.LauncherCreateMapButton.Size = new Size(74, 24);
      this.LauncherCreateMapButton.TabIndex = 4;
      this.LauncherCreateMapButton.Text = "Create Map";
      this.LauncherCreateMapButton.UseVisualStyleBackColor = true;
      this.LauncherCreateMapButton.Click += new EventHandler(this.LauncherCreateMap_Click);
      this.LauncherDeleteMapButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.LauncherDeleteMapButton.Location = new Point(6, 294);
      this.LauncherDeleteMapButton.Name = "LauncherDeleteMapButton";
      this.LauncherDeleteMapButton.Size = new Size(74, 24);
      this.LauncherDeleteMapButton.TabIndex = 4;
      this.LauncherDeleteMapButton.Text = "Delete Map";
      this.LauncherDeleteMapButton.UseVisualStyleBackColor = true;
      this.LauncherDeleteMapButton.Click += new EventHandler(this.LauncherDeleteMap_Click);
      this.LauncherCompileLevelOptionsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCompileReflectionsCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherGridFileGroupBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherModSpecificMapComboBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherModSpecificMapCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCustomRunOptionsLabel);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCustomRunOptionsTextBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) label);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCompileLevelButton);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCompileLightsButton);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCompileBSPButton);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherUseRunGameTypeOptionsCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherRunMapAfterCompileCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherBspInfoCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherBuildFastFilesCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherConnectPathsCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCompileLightsCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Controls.Add((Control) this.LauncherCompileBSPCheckBox);
      this.LauncherCompileLevelOptionsGroupBox.Location = new Point(162, 6);
      this.LauncherCompileLevelOptionsGroupBox.Name = "LauncherCompileLevelOptionsGroupBox";
      this.LauncherCompileLevelOptionsGroupBox.Size = new Size(473, 312);
      this.LauncherCompileLevelOptionsGroupBox.TabIndex = 3;
      this.LauncherCompileLevelOptionsGroupBox.TabStop = false;
      this.LauncherCompileLevelOptionsGroupBox.Text = "Compile Level Options";
      this.LauncherCompileReflectionsCheckBox.AutoSize = true;
      this.LauncherCompileReflectionsCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherCompileReflectionsCheckBox.Location = new Point(9, 88);
      this.LauncherCompileReflectionsCheckBox.Name = "LauncherCompileReflectionsCheckBox";
      this.LauncherCompileReflectionsCheckBox.Size = new Size(117, 17);
      this.LauncherCompileReflectionsCheckBox.TabIndex = 19;
      this.LauncherCompileReflectionsCheckBox.Text = "Compile Reflections";
      this.LauncherCompileReflectionsCheckBox.UseVisualStyleBackColor = true;
      this.LauncherGridFileGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.LauncherGridFileGroupBox.Controls.Add((Control) this.LauncherGridEditExistingButton);
      this.LauncherGridFileGroupBox.Controls.Add((Control) this.LauncherGridMakeNewButton);
      this.LauncherGridFileGroupBox.Controls.Add((Control) this.LauncherGridCollectDotsCheckBox);
      this.LauncherGridFileGroupBox.Location = new Point(6, 230);
      this.LauncherGridFileGroupBox.Name = "LauncherGridFileGroupBox";
      this.LauncherGridFileGroupBox.Size = new Size(223, 76);
      this.LauncherGridFileGroupBox.TabIndex = 18;
      this.LauncherGridFileGroupBox.TabStop = false;
      this.LauncherGridFileGroupBox.Text = "Grid File";
      this.LauncherGridEditExistingButton.Location = new Point(112, 42);
      this.LauncherGridEditExistingButton.Name = "LauncherGridEditExistingButton";
      this.LauncherGridEditExistingButton.Size = new Size(100, 23);
      this.LauncherGridEditExistingButton.TabIndex = 19;
      this.LauncherGridEditExistingButton.Text = "Edit Existing Grid";
      this.LauncherGridEditExistingButton.UseVisualStyleBackColor = true;
      this.LauncherGridEditExistingButton.Click += new EventHandler(this.LauncherGridEditExistingButton_Click);
      this.LauncherGridMakeNewButton.Location = new Point(6, 42);
      this.LauncherGridMakeNewButton.Name = "LauncherGridMakeNewButton";
      this.LauncherGridMakeNewButton.Size = new Size(100, 23);
      this.LauncherGridMakeNewButton.TabIndex = 18;
      this.LauncherGridMakeNewButton.Text = "Make New Grid";
      this.LauncherGridMakeNewButton.UseVisualStyleBackColor = true;
      this.LauncherGridMakeNewButton.Click += new EventHandler(this.LauncherGridMakeNewButton_Click);
      this.LauncherGridCollectDotsCheckBox.AutoSize = true;
      this.LauncherGridCollectDotsCheckBox.Location = new Point(6, 19);
      this.LauncherGridCollectDotsCheckBox.Name = "LauncherGridCollectDotsCheckBox";
      this.LauncherGridCollectDotsCheckBox.Size = new Size(120, 17);
      this.LauncherGridCollectDotsCheckBox.TabIndex = 17;
      this.LauncherGridCollectDotsCheckBox.Text = "Models Collect Dots";
      this.LauncherGridCollectDotsCheckBox.UseVisualStyleBackColor = true;
      this.LauncherModSpecificMapComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherModSpecificMapComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.LauncherModSpecificMapComboBox.Enabled = false;
      this.LauncherModSpecificMapComboBox.FormattingEnabled = true;
      this.LauncherModSpecificMapComboBox.Items.AddRange(new object[3]
      {
        (object) "HumorOneMod",
        (object) "HumorTwoMod",
        (object) "BlahBlahMod"
      });
      this.LauncherModSpecificMapComboBox.Location = new Point(149, 41);
      this.LauncherModSpecificMapComboBox.Name = "LauncherModSpecificMapComboBox";
      this.LauncherModSpecificMapComboBox.Size = new Size(318, 21);
      this.LauncherModSpecificMapComboBox.TabIndex = 4;
      this.LauncherModSpecificMapCheckBox.AutoSize = true;
      this.LauncherModSpecificMapCheckBox.Location = new Point(149, 16);
      this.LauncherModSpecificMapCheckBox.Name = "LauncherModSpecificMapCheckBox";
      this.LauncherModSpecificMapCheckBox.Size = new Size(112, 17);
      this.LauncherModSpecificMapCheckBox.TabIndex = 5;
      this.LauncherModSpecificMapCheckBox.Text = "Mod Specific Map";
      this.LauncherModSpecificMapCheckBox.UseVisualStyleBackColor = true;
      this.LauncherModSpecificMapCheckBox.CheckedChanged += new EventHandler(this.LauncherModSpecificMapCheckBox_CheckedChanged);
      this.LauncherCustomRunOptionsLabel.AutoSize = true;
      this.LauncherCustomRunOptionsLabel.Location = new Point(6, 206);
      this.LauncherCustomRunOptionsLabel.Name = "LauncherCustomRunOptionsLabel";
      this.LauncherCustomRunOptionsLabel.Size = new Size(107, 13);
      this.LauncherCustomRunOptionsLabel.TabIndex = 14;
      this.LauncherCustomRunOptionsLabel.Text = "Custom Run Options:";
      this.LauncherCustomRunOptionsLabel.Visible = false;
      this.LauncherCustomRunOptionsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherCustomRunOptionsTextBox.Location = new Point(119, 203);
      this.LauncherCustomRunOptionsTextBox.Name = "LauncherCustomRunOptionsTextBox";
      this.LauncherCustomRunOptionsTextBox.Size = new Size(348, 20);
      this.LauncherCustomRunOptionsTextBox.TabIndex = 13;
      this.LauncherCustomRunOptionsTextBox.Visible = false;
      this.LauncherCompileLevelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherCompileLevelButton.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LauncherCompileLevelButton.Location = new Point(340, 229);
      this.LauncherCompileLevelButton.Name = "LauncherCompileLevelButton";
      this.LauncherCompileLevelButton.Size = new Size(128, 76);
      this.LauncherCompileLevelButton.TabIndex = 4;
      this.LauncherCompileLevelButton.Text = "Compile Level";
      this.LauncherCompileLevelButton.UseVisualStyleBackColor = true;
      this.LauncherCompileLevelButton.Click += new EventHandler(this.LauncherCompileLevelButton_Click);
      this.LauncherCompileLightsButton.Location = new Point(107, 16);
      this.LauncherCompileLightsButton.Name = "LauncherCompileLightsButton";
      this.LauncherCompileLightsButton.Size = new Size(26, 23);
      this.LauncherCompileLightsButton.TabIndex = 11;
      this.LauncherCompileLightsButton.Text = "...";
      this.LauncherCompileLightsButton.UseVisualStyleBackColor = true;
      this.LauncherCompileLightsButton.Click += new EventHandler(this.LauncherCompileLightsButton_Click);
      this.LauncherCompileBSPButton.Location = new Point(107, 39);
      this.LauncherCompileBSPButton.Name = "LauncherCompileBSPButton";
      this.LauncherCompileBSPButton.Size = new Size(26, 23);
      this.LauncherCompileBSPButton.TabIndex = 10;
      this.LauncherCompileBSPButton.Text = "...";
      this.LauncherCompileBSPButton.UseVisualStyleBackColor = true;
      this.LauncherCompileBSPButton.Click += new EventHandler(this.LauncherCompileBSPButton_Click);
      this.LauncherUseRunGameTypeOptionsCheckBox.AutoSize = true;
      this.LauncherUseRunGameTypeOptionsCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherUseRunGameTypeOptionsCheckBox.Location = new Point(9, 180);
      this.LauncherUseRunGameTypeOptionsCheckBox.Name = "LauncherUseRunGameTypeOptionsCheckBox";
      this.LauncherUseRunGameTypeOptionsCheckBox.Size = new Size(162, 17);
      this.LauncherUseRunGameTypeOptionsCheckBox.TabIndex = 9;
      this.LauncherUseRunGameTypeOptionsCheckBox.Text = "Use 'Run Game Tab' Options";
      this.LauncherUseRunGameTypeOptionsCheckBox.UseVisualStyleBackColor = true;
      this.LauncherUseRunGameTypeOptionsCheckBox.Visible = false;
      this.LauncherRunMapAfterCompileCheckBox.AutoSize = true;
      this.LauncherRunMapAfterCompileCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherRunMapAfterCompileCheckBox.Location = new Point(9, 157);
      this.LauncherRunMapAfterCompileCheckBox.Name = "LauncherRunMapAfterCompileCheckBox";
      this.LauncherRunMapAfterCompileCheckBox.Size = new Size(133, 17);
      this.LauncherRunMapAfterCompileCheckBox.TabIndex = 8;
      this.LauncherRunMapAfterCompileCheckBox.Text = "Run Map After Compile";
      this.LauncherRunMapAfterCompileCheckBox.UseVisualStyleBackColor = true;
      this.LauncherBspInfoCheckBox.AutoSize = true;
      this.LauncherBspInfoCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherBspInfoCheckBox.Location = new Point(9, 134);
      this.LauncherBspInfoCheckBox.Name = "LauncherBspInfoCheckBox";
      this.LauncherBspInfoCheckBox.Size = new Size(66, 17);
      this.LauncherBspInfoCheckBox.TabIndex = 7;
      this.LauncherBspInfoCheckBox.Text = "BSP Info";
      this.LauncherBspInfoCheckBox.UseVisualStyleBackColor = true;
      this.LauncherBuildFastFilesCheckBox.AutoSize = true;
      this.LauncherBuildFastFilesCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherBuildFastFilesCheckBox.Location = new Point(9, 111);
      this.LauncherBuildFastFilesCheckBox.Name = "LauncherBuildFastFilesCheckBox";
      this.LauncherBuildFastFilesCheckBox.Size = new Size(88, 17);
      this.LauncherBuildFastFilesCheckBox.TabIndex = 6;
      this.LauncherBuildFastFilesCheckBox.Text = "Build Fastfiles";
      this.LauncherBuildFastFilesCheckBox.UseVisualStyleBackColor = true;
      this.LauncherConnectPathsCheckBox.AutoSize = true;
      this.LauncherConnectPathsCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherConnectPathsCheckBox.Location = new Point(9, 65);
      this.LauncherConnectPathsCheckBox.Name = "LauncherConnectPathsCheckBox";
      this.LauncherConnectPathsCheckBox.Size = new Size(94, 17);
      this.LauncherConnectPathsCheckBox.TabIndex = 3;
      this.LauncherConnectPathsCheckBox.Text = "Connect Paths";
      this.LauncherConnectPathsCheckBox.UseVisualStyleBackColor = true;
      this.LauncherCompileLightsCheckBox.AutoSize = true;
      this.LauncherCompileLightsCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherCompileLightsCheckBox.Location = new Point(9, 42);
      this.LauncherCompileLightsCheckBox.Name = "LauncherCompileLightsCheckBox";
      this.LauncherCompileLightsCheckBox.Size = new Size(92, 17);
      this.LauncherCompileLightsCheckBox.TabIndex = 1;
      this.LauncherCompileLightsCheckBox.Text = "Compile Lights";
      this.LauncherCompileLightsCheckBox.UseVisualStyleBackColor = true;
      this.LauncherCompileLightsCheckBox.CheckedChanged += new EventHandler(this.LauncherCompileLightsCheckBox_CheckedChanged);
      this.LauncherCompileBSPCheckBox.AutoSize = true;
      this.LauncherCompileBSPCheckBox.FlatStyle = FlatStyle.Popup;
      this.LauncherCompileBSPCheckBox.Location = new Point(9, 19);
      this.LauncherCompileBSPCheckBox.Name = "LauncherCompileBSPCheckBox";
      this.LauncherCompileBSPCheckBox.Size = new Size(85, 17);
      this.LauncherCompileBSPCheckBox.TabIndex = 0;
      this.LauncherCompileBSPCheckBox.Text = "Compile BSP";
      this.LauncherCompileBSPCheckBox.UseVisualStyleBackColor = true;
      this.LauncherMapList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.LauncherMapList.FormattingEnabled = true;
      this.LauncherMapList.IntegralHeight = false;
      this.LauncherMapList.Location = new Point(6, 31);
      this.LauncherMapList.Name = "LauncherMapList";
      this.LauncherMapList.Size = new Size(150, 261);
      this.LauncherMapList.TabIndex = 1;
      this.LauncherMapList.SelectedIndexChanged += new EventHandler(this.LauncherMapList_SelectedIndexChanged);
      this.LauncherMapList.DoubleClick += new EventHandler(this.LauncherMapList_DoubleClick);
      this.LauncherMapList.MouseDown += new MouseEventHandler(this.LauncherMapList_MouseDown);
      this.LauncherMapList.MouseUp += new MouseEventHandler(this.LauncherMapList_MouseUp);
      this.LauncherTabExplore.Controls.Add((Control) this.LauncherExploreGroupBox);
      this.LauncherTabExplore.Location = new Point(4, 22);
      this.LauncherTabExplore.Name = "LauncherTabExplore";
      this.LauncherTabExplore.Padding = new Padding(3);
      this.LauncherTabExplore.Size = new Size(641, 324);
      this.LauncherTabExplore.TabIndex = 3;
      this.LauncherTabExplore.Text = "Explore";
      this.LauncherTabExplore.UseVisualStyleBackColor = true;
      this.LauncherExploreGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherExploreGroupBox.Controls.Add((Control) this.LauncherExploreRawMapsDirGroupBox);
      this.LauncherExploreGroupBox.Controls.Add((Control) this.LauncherExploreRawDirGroupBox);
      this.LauncherExploreGroupBox.Controls.Add((Control) this.LauncherExploreDevDirGroupBox);
      this.LauncherExploreGroupBox.Controls.Add((Control) this.LauncherExploreBlopsDirGroupBox);
      this.LauncherExploreGroupBox.Location = new Point(6, 6);
      this.LauncherExploreGroupBox.Name = "LauncherExploreGroupBox";
      this.LauncherExploreGroupBox.Size = new Size(629, 312);
      this.LauncherExploreGroupBox.TabIndex = 0;
      this.LauncherExploreGroupBox.TabStop = false;
      this.LauncherExploreGroupBox.Text = "Explore";
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirMPGametypesButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirMPFXButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirMPArtButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirMPButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirSPVoiceButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirSPGametypesButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirSPFXButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirSPArtButton);
      this.LauncherExploreRawMapsDirGroupBox.Controls.Add((Control) this.LauncherExploreRawGSCDirSPButton);
      this.LauncherExploreRawMapsDirGroupBox.Location = new Point(463, 19);
      this.LauncherExploreRawMapsDirGroupBox.Name = "LauncherExploreRawMapsDirGroupBox";
      this.LauncherExploreRawMapsDirGroupBox.Size = new Size(142, 226);
      this.LauncherExploreRawMapsDirGroupBox.TabIndex = 20;
      this.LauncherExploreRawMapsDirGroupBox.TabStop = false;
      this.LauncherExploreRawMapsDirGroupBox.Text = "Raw Maps Folders";
      this.LauncherExploreRawGSCDirMPGametypesButton.Location = new Point(6, 198);
      this.LauncherExploreRawGSCDirMPGametypesButton.Name = "LauncherExploreRawGSCDirMPGametypesButton";
      this.LauncherExploreRawGSCDirMPGametypesButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirMPGametypesButton.TabIndex = 29;
      this.LauncherExploreRawGSCDirMPGametypesButton.Text = "Gametypes";
      this.LauncherExploreRawGSCDirMPGametypesButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirMPGametypesButton.Click += new EventHandler(this.LauncherExploreRawGSCDirMPGametypesButton_Click);
      this.LauncherExploreRawGSCDirMPFXButton.Location = new Point(72, 168);
      this.LauncherExploreRawGSCDirMPFXButton.Name = "LauncherExploreRawGSCDirMPFXButton";
      this.LauncherExploreRawGSCDirMPFXButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirMPFXButton.TabIndex = 28;
      this.LauncherExploreRawGSCDirMPFXButton.Text = "CreateFX";
      this.LauncherExploreRawGSCDirMPFXButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirMPFXButton.Click += new EventHandler(this.LauncherExploreRawGSCDirMPFXButton_Click);
      this.LauncherExploreRawGSCDirMPArtButton.Location = new Point(6, 168);
      this.LauncherExploreRawGSCDirMPArtButton.Name = "LauncherExploreRawGSCDirMPArtButton";
      this.LauncherExploreRawGSCDirMPArtButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirMPArtButton.TabIndex = 27;
      this.LauncherExploreRawGSCDirMPArtButton.Text = "CreateArt";
      this.LauncherExploreRawGSCDirMPArtButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirMPArtButton.Click += new EventHandler(this.LauncherExploreRawGSCDirMPArtButton_Click);
      this.LauncherExploreRawGSCDirMPButton.Location = new Point(6, 138);
      this.LauncherExploreRawGSCDirMPButton.Name = "LauncherExploreRawGSCDirMPButton";
      this.LauncherExploreRawGSCDirMPButton.Size = new Size(128, 24);
      this.LauncherExploreRawGSCDirMPButton.TabIndex = 26;
      this.LauncherExploreRawGSCDirMPButton.Text = "Multiplayer";
      this.LauncherExploreRawGSCDirMPButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirMPButton.Click += new EventHandler(this.LauncherExploreRawGSCDirMPButton_Click);
      this.LauncherExploreRawGSCDirSPVoiceButton.Location = new Point(72, 79);
      this.LauncherExploreRawGSCDirSPVoiceButton.Name = "LauncherExploreRawGSCDirSPVoiceButton";
      this.LauncherExploreRawGSCDirSPVoiceButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirSPVoiceButton.TabIndex = 25;
      this.LauncherExploreRawGSCDirSPVoiceButton.Text = "Voice";
      this.LauncherExploreRawGSCDirSPVoiceButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirSPVoiceButton.Click += new EventHandler(this.LauncherExploreRawGSCDirSPVoiceButton_Click);
      this.LauncherExploreRawGSCDirSPGametypesButton.Location = new Point(6, 79);
      this.LauncherExploreRawGSCDirSPGametypesButton.Name = "LauncherExploreRawGSCDirSPGametypesButton";
      this.LauncherExploreRawGSCDirSPGametypesButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirSPGametypesButton.TabIndex = 24;
      this.LauncherExploreRawGSCDirSPGametypesButton.Text = "Gametypes";
      this.LauncherExploreRawGSCDirSPGametypesButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirSPGametypesButton.Click += new EventHandler(this.LauncherExploreRawGSCDirSPGametypesButton_Click);
      this.LauncherExploreRawGSCDirSPFXButton.Location = new Point(72, 49);
      this.LauncherExploreRawGSCDirSPFXButton.Name = "LauncherExploreRawGSCDirSPFXButton";
      this.LauncherExploreRawGSCDirSPFXButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirSPFXButton.TabIndex = 23;
      this.LauncherExploreRawGSCDirSPFXButton.Text = "CreateFX";
      this.LauncherExploreRawGSCDirSPFXButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirSPFXButton.Click += new EventHandler(this.LauncherExploreRawGSCDirSPFXButton_Click);
      this.LauncherExploreRawGSCDirSPArtButton.Location = new Point(6, 49);
      this.LauncherExploreRawGSCDirSPArtButton.Name = "LauncherExploreRawGSCDirSPArtButton";
      this.LauncherExploreRawGSCDirSPArtButton.Size = new Size(64, 24);
      this.LauncherExploreRawGSCDirSPArtButton.TabIndex = 22;
      this.LauncherExploreRawGSCDirSPArtButton.Text = "CreateArt";
      this.LauncherExploreRawGSCDirSPArtButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirSPArtButton.Click += new EventHandler(this.LauncherExploreRawGSCDirSPArtButton_Click);
      this.LauncherExploreRawGSCDirSPButton.Location = new Point(6, 19);
      this.LauncherExploreRawGSCDirSPButton.Name = "LauncherExploreRawGSCDirSPButton";
      this.LauncherExploreRawGSCDirSPButton.Size = new Size(128, 24);
      this.LauncherExploreRawGSCDirSPButton.TabIndex = 21;
      this.LauncherExploreRawGSCDirSPButton.Text = "Singleplayer";
      this.LauncherExploreRawGSCDirSPButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawGSCDirSPButton.Click += new EventHandler(this.LauncherExploreRawGSCDirSPButton_Click);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirFXButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirMPButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirWeaponsButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirVisionButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirLocsButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirAnimTreesButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirSoundAliasesButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirCSCButton);
      this.LauncherExploreRawDirGroupBox.Controls.Add((Control) this.LauncherExploreRawDirGSCButton);
      this.LauncherExploreRawDirGroupBox.Location = new Point(315, 19);
      this.LauncherExploreRawDirGroupBox.Name = "LauncherExploreRawDirGroupBox";
      this.LauncherExploreRawDirGroupBox.Size = new Size(142, 287);
      this.LauncherExploreRawDirGroupBox.TabIndex = 19;
      this.LauncherExploreRawDirGroupBox.TabStop = false;
      this.LauncherExploreRawDirGroupBox.Text = "Raw Folders";
      this.LauncherExploreRawDirFXButton.Location = new Point(6, 109);
      this.LauncherExploreRawDirFXButton.Name = "LauncherExploreRawDirFXButton";
      this.LauncherExploreRawDirFXButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirFXButton.TabIndex = 25;
      this.LauncherExploreRawDirFXButton.Text = "FX";
      this.LauncherExploreRawDirFXButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirFXButton.Click += new EventHandler(this.LauncherExploreRawDirFXButton_Click);
      this.LauncherExploreRawDirMPButton.Location = new Point(6, 168);
      this.LauncherExploreRawDirMPButton.Name = "LauncherExploreRawDirMPButton";
      this.LauncherExploreRawDirMPButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirMPButton.TabIndex = 24;
      this.LauncherExploreRawDirMPButton.Text = "MP";
      this.LauncherExploreRawDirMPButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirMPButton.Click += new EventHandler(this.LauncherExploreRawDirMPButton_Click);
      this.LauncherExploreRawDirWeaponsButton.Location = new Point(6, 258);
      this.LauncherExploreRawDirWeaponsButton.Name = "LauncherExploreRawDirWeaponsButton";
      this.LauncherExploreRawDirWeaponsButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirWeaponsButton.TabIndex = 23;
      this.LauncherExploreRawDirWeaponsButton.Text = "Weapons";
      this.LauncherExploreRawDirWeaponsButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirWeaponsButton.Click += new EventHandler(this.LauncherExploreRawDirWeaponsButton_Click);
      this.LauncherExploreRawDirVisionButton.Location = new Point(6, 228);
      this.LauncherExploreRawDirVisionButton.Name = "LauncherExploreRawDirVisionButton";
      this.LauncherExploreRawDirVisionButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirVisionButton.TabIndex = 22;
      this.LauncherExploreRawDirVisionButton.Text = "Vision";
      this.LauncherExploreRawDirVisionButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirVisionButton.Click += new EventHandler(this.LauncherExploreRawDirVisionButton_Click);
      this.LauncherExploreRawDirLocsButton.Location = new Point(6, 79);
      this.LauncherExploreRawDirLocsButton.Name = "LauncherExploreRawDirLocsButton";
      this.LauncherExploreRawDirLocsButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirLocsButton.TabIndex = 21;
      this.LauncherExploreRawDirLocsButton.Text = "English Strings";
      this.LauncherExploreRawDirLocsButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirLocsButton.Click += new EventHandler(this.LauncherExploreRawDirLocsButton_Click);
      this.LauncherExploreRawDirAnimTreesButton.Location = new Point(6, 19);
      this.LauncherExploreRawDirAnimTreesButton.Name = "LauncherExploreRawDirAnimTreesButton";
      this.LauncherExploreRawDirAnimTreesButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirAnimTreesButton.TabIndex = 20;
      this.LauncherExploreRawDirAnimTreesButton.Text = "AnimTrees";
      this.LauncherExploreRawDirAnimTreesButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirAnimTreesButton.Click += new EventHandler(this.LauncherExploreRawDirAnimTreesButton_Click);
      this.LauncherExploreRawDirSoundAliasesButton.Location = new Point(6, 198);
      this.LauncherExploreRawDirSoundAliasesButton.Name = "LauncherExploreRawDirSoundAliasesButton";
      this.LauncherExploreRawDirSoundAliasesButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirSoundAliasesButton.TabIndex = 19;
      this.LauncherExploreRawDirSoundAliasesButton.Text = "Sound Aliases";
      this.LauncherExploreRawDirSoundAliasesButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirSoundAliasesButton.Click += new EventHandler(this.LauncherExploreRawDirSoundAliasesButton_Click);
      this.LauncherExploreRawDirCSCButton.Location = new Point(6, 49);
      this.LauncherExploreRawDirCSCButton.Name = "LauncherExploreRawDirCSCButton";
      this.LauncherExploreRawDirCSCButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirCSCButton.TabIndex = 18;
      this.LauncherExploreRawDirCSCButton.Text = "Clientscripts";
      this.LauncherExploreRawDirCSCButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirCSCButton.Click += new EventHandler(this.LauncherExploreRawDirCSCButton_Click);
      this.LauncherExploreRawDirGSCButton.Location = new Point(6, 139);
      this.LauncherExploreRawDirGSCButton.Name = "LauncherExploreRawDirGSCButton";
      this.LauncherExploreRawDirGSCButton.Size = new Size(128, 24);
      this.LauncherExploreRawDirGSCButton.TabIndex = 17;
      this.LauncherExploreRawDirGSCButton.Text = "Maps";
      this.LauncherExploreRawDirGSCButton.UseVisualStyleBackColor = true;
      this.LauncherExploreRawDirGSCButton.Click += new EventHandler(this.LauncherExploreRawDirGSCButton_Click);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirRawButton);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirModelExportButton);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirTextureAssetsButton);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirSrcDataButton);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirMapSrcButton);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirBinButton);
      this.LauncherExploreDevDirGroupBox.Controls.Add((Control) this.LauncherExploreDevDirZoneSourceButton);
      this.LauncherExploreDevDirGroupBox.Location = new Point(167, 19);
      this.LauncherExploreDevDirGroupBox.Name = "LauncherExploreDevDirGroupBox";
      this.LauncherExploreDevDirGroupBox.Size = new Size(142, 226);
      this.LauncherExploreDevDirGroupBox.TabIndex = 18;
      this.LauncherExploreDevDirGroupBox.TabStop = false;
      this.LauncherExploreDevDirGroupBox.Text = "Development Directories";
      this.LauncherExploreDevDirRawButton.Location = new Point(6, 108);
      this.LauncherExploreDevDirRawButton.Name = "LauncherExploreDevDirRawButton";
      this.LauncherExploreDevDirRawButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirRawButton.TabIndex = 19;
      this.LauncherExploreDevDirRawButton.Text = "Raw";
      this.LauncherExploreDevDirRawButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirRawButton.Click += new EventHandler(this.LauncherExploreDevDirRawButton_Click);
      this.LauncherExploreDevDirModelExportButton.Location = new Point(6, 78);
      this.LauncherExploreDevDirModelExportButton.Name = "LauncherExploreDevDirModelExportButton";
      this.LauncherExploreDevDirModelExportButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirModelExportButton.TabIndex = 18;
      this.LauncherExploreDevDirModelExportButton.Text = "Model Export";
      this.LauncherExploreDevDirModelExportButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirModelExportButton.Click += new EventHandler(this.LauncherExploreDevDirModelExportButton_Click);
      this.LauncherExploreDevDirTextureAssetsButton.Location = new Point(6, 168);
      this.LauncherExploreDevDirTextureAssetsButton.Name = "LauncherExploreDevDirTextureAssetsButton";
      this.LauncherExploreDevDirTextureAssetsButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirTextureAssetsButton.TabIndex = 17;
      this.LauncherExploreDevDirTextureAssetsButton.Text = "Texture Assets";
      this.LauncherExploreDevDirTextureAssetsButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirTextureAssetsButton.Click += new EventHandler(this.LauncherExploreDevDirTextureAssetsButton_Click);
      this.LauncherExploreDevDirSrcDataButton.Location = new Point(6, 138);
      this.LauncherExploreDevDirSrcDataButton.Name = "LauncherExploreDevDirSrcDataButton";
      this.LauncherExploreDevDirSrcDataButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirSrcDataButton.TabIndex = 16;
      this.LauncherExploreDevDirSrcDataButton.Text = "Source Data";
      this.LauncherExploreDevDirSrcDataButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirSrcDataButton.Click += new EventHandler(this.LauncherExploreDevDirSrcDataButton_Click);
      this.LauncherExploreDevDirMapSrcButton.Location = new Point(6, 48);
      this.LauncherExploreDevDirMapSrcButton.Name = "LauncherExploreDevDirMapSrcButton";
      this.LauncherExploreDevDirMapSrcButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirMapSrcButton.TabIndex = 15;
      this.LauncherExploreDevDirMapSrcButton.Text = "Map Source";
      this.LauncherExploreDevDirMapSrcButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirMapSrcButton.Click += new EventHandler(this.LauncherExploreDevDirMapSrcButton_Click);
      this.LauncherExploreDevDirBinButton.Location = new Point(6, 19);
      this.LauncherExploreDevDirBinButton.Name = "LauncherExploreDevDirBinButton";
      this.LauncherExploreDevDirBinButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirBinButton.TabIndex = 14;
      this.LauncherExploreDevDirBinButton.Text = "Bin";
      this.LauncherExploreDevDirBinButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirBinButton.Click += new EventHandler(this.LauncherExploreDevDirBinButton_Click);
      this.LauncherExploreDevDirZoneSourceButton.Location = new Point(6, 198);
      this.LauncherExploreDevDirZoneSourceButton.Name = "LauncherExploreDevDirZoneSourceButton";
      this.LauncherExploreDevDirZoneSourceButton.Size = new Size(128, 24);
      this.LauncherExploreDevDirZoneSourceButton.TabIndex = 13;
      this.LauncherExploreDevDirZoneSourceButton.Text = "Zone Source";
      this.LauncherExploreDevDirZoneSourceButton.UseVisualStyleBackColor = true;
      this.LauncherExploreDevDirZoneSourceButton.Click += new EventHandler(this.LauncherExploreDevDirZoneSourceButton_Click);
      this.LauncherExploreBlopsDirGroupBox.Controls.Add((Control) this.LauncherExploreBlopsDirConfigsButton);
      this.LauncherExploreBlopsDirGroupBox.Controls.Add((Control) this.LauncherExploreBlopsDirModsButton);
      this.LauncherExploreBlopsDirGroupBox.Controls.Add((Control) this.LauncherExploreBlopsDirGameButton);
      this.LauncherExploreBlopsDirGroupBox.Location = new Point(19, 19);
      this.LauncherExploreBlopsDirGroupBox.Name = "LauncherExploreBlopsDirGroupBox";
      this.LauncherExploreBlopsDirGroupBox.Size = new Size(142, 110);
      this.LauncherExploreBlopsDirGroupBox.TabIndex = 17;
      this.LauncherExploreBlopsDirGroupBox.TabStop = false;
      this.LauncherExploreBlopsDirGroupBox.Text = "Call of Duty: Black Ops";
      this.LauncherExploreBlopsDirConfigsButton.Location = new Point(6, 49);
      this.LauncherExploreBlopsDirConfigsButton.Name = "LauncherExploreBlopsDirConfigsButton";
      this.LauncherExploreBlopsDirConfigsButton.Size = new Size(128, 24);
      this.LauncherExploreBlopsDirConfigsButton.TabIndex = 10;
      this.LauncherExploreBlopsDirConfigsButton.Text = "Player Configs";
      this.LauncherExploreBlopsDirConfigsButton.UseVisualStyleBackColor = true;
      this.LauncherExploreBlopsDirConfigsButton.Click += new EventHandler(this.LauncherExploreBlopsDirConfigsButton_Click);
      this.LauncherExploreBlopsDirModsButton.Location = new Point(6, 79);
      this.LauncherExploreBlopsDirModsButton.Name = "LauncherExploreBlopsDirModsButton";
      this.LauncherExploreBlopsDirModsButton.Size = new Size(128, 24);
      this.LauncherExploreBlopsDirModsButton.TabIndex = 9;
      this.LauncherExploreBlopsDirModsButton.Text = "Mods Folder";
      this.LauncherExploreBlopsDirModsButton.UseVisualStyleBackColor = true;
      this.LauncherExploreBlopsDirModsButton.Click += new EventHandler(this.LauncherExploreBlopsDirModsButton_Click);
      this.LauncherExploreBlopsDirGameButton.Location = new Point(6, 19);
      this.LauncherExploreBlopsDirGameButton.Name = "LauncherExploreBlopsDirGameButton";
      this.LauncherExploreBlopsDirGameButton.Size = new Size(128, 24);
      this.LauncherExploreBlopsDirGameButton.TabIndex = 8;
      this.LauncherExploreBlopsDirGameButton.Text = "Game Directory";
      this.LauncherExploreBlopsDirGameButton.UseVisualStyleBackColor = true;
      this.LauncherExploreBlopsDirGameButton.Click += new EventHandler(this.LauncherExploreBlopsDirGameButton_Click);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherIconRadiant);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherIconEffectsEditor);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherIconConverter);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherIconAssetViewer);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherIconAssetManager);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherButtonAssetViewer);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherButtonRunConverter);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherButtonAssetManager);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherButtonEffectsEd);
      this.LauncherApplicationsGroupBox.Controls.Add((Control) this.LauncherButtonRadiant);
      this.LauncherApplicationsGroupBox.Location = new Point(5, 186);
      this.LauncherApplicationsGroupBox.Name = "LauncherApplicationsGroupBox";
      this.LauncherApplicationsGroupBox.Size = new Size(139, 165);
      this.LauncherApplicationsGroupBox.TabIndex = 8;
      this.LauncherApplicationsGroupBox.TabStop = false;
      this.LauncherApplicationsGroupBox.Text = "Tools";
      this.LauncherIconRadiant.BackgroundImage = (Image) Resources.radiant;
      this.LauncherIconRadiant.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconRadiant.Enabled = false;
      this.LauncherIconRadiant.Location = new Point(13, 139);
      this.LauncherIconRadiant.Name = "LauncherIconRadiant";
      this.LauncherIconRadiant.Size = new Size(16, 16);
      this.LauncherIconRadiant.TabIndex = 10;
      this.LauncherIconRadiant.TabStop = false;
      this.LauncherIconEffectsEditor.BackgroundImage = (Image) Resources.EffectsEd;
      this.LauncherIconEffectsEditor.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconEffectsEditor.Enabled = false;
      this.LauncherIconEffectsEditor.Location = new Point(12, 18);
      this.LauncherIconEffectsEditor.Name = "LauncherIconEffectsEditor";
      this.LauncherIconEffectsEditor.Size = new Size(16, 16);
      this.LauncherIconEffectsEditor.TabIndex = 9;
      this.LauncherIconEffectsEditor.TabStop = false;
      this.LauncherIconConverter.BackgroundImage = (Image) Resources.converter;
      this.LauncherIconConverter.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconConverter.Enabled = false;
      this.LauncherIconConverter.Location = new Point(12, 109);
      this.LauncherIconConverter.Name = "LauncherIconConverter";
      this.LauncherIconConverter.Size = new Size(16, 16);
      this.LauncherIconConverter.TabIndex = 8;
      this.LauncherIconConverter.TabStop = false;
      this.LauncherIconAssetViewer.BackgroundImage = (Image) Resources.asset_viewer;
      this.LauncherIconAssetViewer.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconAssetViewer.Enabled = false;
      this.LauncherIconAssetViewer.Location = new Point(12, 78);
      this.LauncherIconAssetViewer.Name = "LauncherIconAssetViewer";
      this.LauncherIconAssetViewer.Size = new Size(16, 16);
      this.LauncherIconAssetViewer.TabIndex = 7;
      this.LauncherIconAssetViewer.TabStop = false;
      this.LauncherIconAssetManager.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherIconAssetManager.Enabled = false;
      this.LauncherIconAssetManager.Image = (Image) componentResourceManager.GetObject("LauncherIconAssetManager.Image");
      this.LauncherIconAssetManager.InitialImage = (Image) componentResourceManager.GetObject("LauncherIconAssetManager.InitialImage");
      this.LauncherIconAssetManager.Location = new Point(12, 48);
      this.LauncherIconAssetManager.Name = "LauncherIconAssetManager";
      this.LauncherIconAssetManager.Size = new Size(16, 16);
      this.LauncherIconAssetManager.TabIndex = 6;
      this.LauncherIconAssetManager.TabStop = false;
      this.LauncherButtonAssetViewer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherButtonAssetViewer.Location = new Point(8, 74);
      this.LauncherButtonAssetViewer.Name = "LauncherButtonAssetViewer";
      this.LauncherButtonAssetViewer.Size = new Size(128, 24);
      this.LauncherButtonAssetViewer.TabIndex = 5;
      this.LauncherButtonAssetViewer.Text = "     Asset Viewer";
      this.LauncherButtonAssetViewer.TextAlign = ContentAlignment.MiddleLeft;
      this.LauncherAssetViewerToolTip.SetToolTip((Control) this.LauncherButtonAssetViewer, "View converted models");
      this.LauncherButtonAssetViewer.UseVisualStyleBackColor = true;
      this.LauncherButtonAssetViewer.Click += new EventHandler(this.LauncherButtonAssetViewer_Click);
      this.LauncherButtonRunConverter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherButtonRunConverter.Location = new Point(8, 105);
      this.LauncherButtonRunConverter.Name = "LauncherButtonRunConverter";
      this.LauncherButtonRunConverter.Size = new Size(128, 24);
      this.LauncherButtonRunConverter.TabIndex = 3;
      this.LauncherButtonRunConverter.Text = "     Converter";
      this.LauncherButtonRunConverter.TextAlign = ContentAlignment.MiddleLeft;
      this.LauncherConverterToolTip.SetToolTip((Control) this.LauncherButtonRunConverter, "Convert .GDTs to game data");
      this.LauncherButtonRunConverter.UseVisualStyleBackColor = true;
      this.LauncherButtonRunConverter.Click += new EventHandler(this.LauncherButtonRunConverter_Click);
      this.LauncherButtonAssetManager.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherButtonAssetManager.ImageAlign = ContentAlignment.MiddleLeft;
      this.LauncherButtonAssetManager.Location = new Point(8, 44);
      this.LauncherButtonAssetManager.Name = "LauncherButtonAssetManager";
      this.LauncherButtonAssetManager.Size = new Size(128, 24);
      this.LauncherButtonAssetManager.TabIndex = 2;
      this.LauncherButtonAssetManager.Text = "     Asset Manager";
      this.LauncherButtonAssetManager.TextAlign = ContentAlignment.MiddleLeft;
      this.LauncherAssetManagerToolTip.SetToolTip((Control) this.LauncherButtonAssetManager, "Manage .GDT files");
      this.LauncherButtonAssetManager.UseVisualStyleBackColor = true;
      this.LauncherButtonAssetManager.Click += new EventHandler(this.LauncherButtonAssetManager_Click);
      this.LauncherButtonEffectsEd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherButtonEffectsEd.Location = new Point(7, 14);
      this.LauncherButtonEffectsEd.Name = "LauncherButtonEffectsEd";
      this.LauncherButtonEffectsEd.Size = new Size(128, 24);
      this.LauncherButtonEffectsEd.TabIndex = 1;
      this.LauncherButtonEffectsEd.Text = "     Effects Editor";
      this.LauncherButtonEffectsEd.TextAlign = ContentAlignment.MiddleLeft;
      this.LauncherEffectsEdToolTip.SetToolTip((Control) this.LauncherButtonEffectsEd, "Effects Editor");
      this.LauncherButtonEffectsEd.UseVisualStyleBackColor = true;
      this.LauncherButtonEffectsEd.Click += new EventHandler(this.LauncherButtonEffectsEd_Click);
      this.LauncherButtonRadiant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherButtonRadiant.Location = new Point(8, 135);
      this.LauncherButtonRadiant.Name = "LauncherButtonRadiant";
      this.LauncherButtonRadiant.Size = new Size(128, 24);
      this.LauncherButtonRadiant.TabIndex = 0;
      this.LauncherButtonRadiant.Text = "     Radiant";
      this.LauncherButtonRadiant.TextAlign = ContentAlignment.MiddleLeft;
      this.LauncherRadiantToolTip.SetToolTip((Control) this.LauncherButtonRadiant, "Open Radiant, the level editor");
      this.LauncherButtonRadiant.UseVisualStyleBackColor = true;
      this.LauncherButtonRadiant.Click += new EventHandler(this.LauncherButtonRadiant_Click);
      this.LauncherWarningsCounter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherWarningsCounter.Location = new Point(550, 249);
      this.LauncherWarningsCounter.Name = "LauncherWarningsCounter";
      this.LauncherWarningsCounter.Size = new Size(31, 13);
      this.LauncherWarningsCounter.TabIndex = 25;
      this.LauncherWarningsCounter.Text = "0";
      this.LauncherWarningsCounter.TextAlign = ContentAlignment.MiddleRight;
      this.LauncherWarningsNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherWarningsNumericUpDown.Location = new Point(655, 246);
      this.LauncherWarningsNumericUpDown.Maximum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.LauncherWarningsNumericUpDown.Name = "LauncherWarningsNumericUpDown";
      this.LauncherWarningsNumericUpDown.ReadOnly = true;
      this.LauncherWarningsNumericUpDown.Size = new Size(18, 20);
      this.LauncherWarningsNumericUpDown.TabIndex = 24;
      this.LauncherWarningsNumericUpDown.Visible = false;
      this.LauncherWarningsNumericUpDown.ValueChanged += new EventHandler(this.LauncherWarningsNumericUpDown_ValueChanged);
      this.LauncherWarningsPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherWarningsPictureBox.BackgroundImage = (Image) Resources.warning_grey;
      this.LauncherWarningsPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherWarningsPictureBox.Location = new Point(635, 248);
      this.LauncherWarningsPictureBox.Name = "LauncherWarningsPictureBox";
      this.LauncherWarningsPictureBox.Size = new Size(16, 16);
      this.LauncherWarningsPictureBox.TabIndex = 23;
      this.LauncherWarningsPictureBox.TabStop = false;
      this.LauncherWarningsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherWarningsLabel.AutoSize = true;
      this.LauncherWarningsLabel.Location = new Point(580, 249);
      this.LauncherWarningsLabel.Name = "LauncherWarningsLabel";
      this.LauncherWarningsLabel.Size = new Size(52, 13);
      this.LauncherWarningsLabel.TabIndex = 22;
      this.LauncherWarningsLabel.Text = "Warnings";
      this.LauncherWarningsLabel.TextAlign = ContentAlignment.MiddleRight;
      this.LauncherErrorsCounter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherErrorsCounter.Location = new Point(679, 249);
      this.LauncherErrorsCounter.Name = "LauncherErrorsCounter";
      this.LauncherErrorsCounter.Size = new Size(35, 13);
      this.LauncherErrorsCounter.TabIndex = 21;
      this.LauncherErrorsCounter.Text = "0";
      this.LauncherErrorsCounter.TextAlign = ContentAlignment.MiddleRight;
      this.LauncherErrorsNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherErrorsNumericUpDown.Location = new Point(770, 246);
      this.LauncherErrorsNumericUpDown.Maximum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.LauncherErrorsNumericUpDown.Name = "LauncherErrorsNumericUpDown";
      this.LauncherErrorsNumericUpDown.ReadOnly = true;
      this.LauncherErrorsNumericUpDown.Size = new Size(18, 20);
      this.LauncherErrorsNumericUpDown.TabIndex = 20;
      this.LauncherErrorsNumericUpDown.Visible = false;
      this.LauncherErrorsNumericUpDown.ValueChanged += new EventHandler(this.LauncherErrorsNumericUpDown_ValueChanged);
      this.LauncherErrorsPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherErrorsPictureBox.BackgroundImage = (Image) Resources.error_grey;
      this.LauncherErrorsPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
      this.LauncherErrorsPictureBox.Location = new Point(750, 248);
      this.LauncherErrorsPictureBox.Name = "LauncherErrorsPictureBox";
      this.LauncherErrorsPictureBox.Size = new Size(16, 16);
      this.LauncherErrorsPictureBox.TabIndex = 19;
      this.LauncherErrorsPictureBox.TabStop = false;
      this.LauncherErrorsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherErrorsLabel.AutoSize = true;
      this.LauncherErrorsLabel.Location = new Point(713, 249);
      this.LauncherErrorsLabel.Name = "LauncherErrorsLabel";
      this.LauncherErrorsLabel.Size = new Size(34, 13);
      this.LauncherErrorsLabel.TabIndex = 18;
      this.LauncherErrorsLabel.Text = "Errors";
      this.LauncherErrorsLabel.TextAlign = ContentAlignment.MiddleRight;
      this.LauncherScrollBottomConsoleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherScrollBottomConsoleButton.BackgroundImage = (Image) Resources.doubledown;
      this.LauncherScrollBottomConsoleButton.BackgroundImageLayout = ImageLayout.Center;
      this.LauncherScrollBottomConsoleButton.Location = new Point(924, 244);
      this.LauncherScrollBottomConsoleButton.Name = "LauncherScrollBottomConsoleButton";
      this.LauncherScrollBottomConsoleButton.Size = new Size(27, 23);
      this.LauncherScrollBottomConsoleButton.TabIndex = 17;
      this.LauncherScrollBottomConsoleToolTip.SetToolTip((Control) this.LauncherScrollBottomConsoleButton, "Scroll to end");
      this.LauncherScrollBottomConsoleButton.UseVisualStyleBackColor = true;
      this.LauncherScrollBottomConsoleButton.Click += new EventHandler(this.LauncherScrollBottomConsoleButton_Click);
      this.LauncherSaveConsoleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherSaveConsoleButton.BackgroundImage = (Image) Resources.log;
      this.LauncherSaveConsoleButton.BackgroundImageLayout = ImageLayout.Center;
      this.LauncherSaveConsoleButton.Location = new Point(794, 244);
      this.LauncherSaveConsoleButton.Name = "LauncherSaveConsoleButton";
      this.LauncherSaveConsoleButton.Size = new Size(27, 23);
      this.LauncherSaveConsoleButton.TabIndex = 16;
      this.SaveConsoleToolTip.SetToolTip((Control) this.LauncherSaveConsoleButton, "Save console to file");
      this.LauncherSaveConsoleButton.UseVisualStyleBackColor = true;
      this.LauncherSaveConsoleButton.Click += new EventHandler(this.LauncherSaveConsoleButton_Click);
      this.LauncherProcessTimeElapsedTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherProcessTimeElapsedTextBox.Location = new Point(489, 246);
      this.LauncherProcessTimeElapsedTextBox.Name = "LauncherProcessTimeElapsedTextBox";
      this.LauncherProcessTimeElapsedTextBox.ReadOnly = true;
      this.LauncherProcessTimeElapsedTextBox.Size = new Size(55, 20);
      this.LauncherProcessTimeElapsedTextBox.TabIndex = 4;
      this.LauncherClearConsoleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.LauncherClearConsoleButton.Location = new Point(827, 244);
      this.LauncherClearConsoleButton.Name = "LauncherClearConsoleButton";
      this.LauncherClearConsoleButton.Size = new Size(86, 23);
      this.LauncherClearConsoleButton.TabIndex = 13;
      this.LauncherClearConsoleButton.Text = "Clear Console";
      this.LauncherClearConsoleButton.UseVisualStyleBackColor = true;
      this.LauncherClearConsoleButton.Click += new EventHandler(this.LauncherClearConsoleButton_Click);
      this.LauncherProcessGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.LauncherProcessGroupBox.Controls.Add((Control) this.LauncherButtonCancel);
      this.LauncherProcessGroupBox.Controls.Add((Control) this.LauncherProcessList);
      this.LauncherProcessGroupBox.Location = new Point(3, 3);
      this.LauncherProcessGroupBox.Name = "LauncherProcessGroupBox";
      this.LauncherProcessGroupBox.Size = new Size(140, 263);
      this.LauncherProcessGroupBox.TabIndex = 2;
      this.LauncherProcessGroupBox.TabStop = false;
      this.LauncherProcessGroupBox.Text = "Processes";
      this.LauncherButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherButtonCancel.BackColor = Color.LightCoral;
      this.LauncherButtonCancel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.LauncherButtonCancel.ForeColor = SystemColors.Info;
      this.LauncherButtonCancel.Location = new Point(6, 192);
      this.LauncherButtonCancel.Name = "LauncherButtonCancel";
      this.LauncherButtonCancel.Size = new Size(128, 65);
      this.LauncherButtonCancel.TabIndex = 4;
      this.LauncherButtonCancel.Text = "Cancel";
      this.LauncherButtonCancel.UseVisualStyleBackColor = false;
      this.LauncherButtonCancel.Click += new EventHandler(this.LauncherButtonCancel_Click);
      this.LauncherProcessList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherProcessList.BackColor = SystemColors.Info;
      this.LauncherProcessList.BorderStyle = BorderStyle.FixedSingle;
      this.LauncherProcessList.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.LauncherProcessList.ForeColor = SystemColors.HotTrack;
      this.LauncherProcessList.FormattingEnabled = true;
      this.LauncherProcessList.IntegralHeight = false;
      this.LauncherProcessList.ItemHeight = 11;
      this.LauncherProcessList.Location = new Point(6, 19);
      this.LauncherProcessList.Name = "LauncherProcessList";
      this.LauncherProcessList.Size = new Size(128, 167);
      this.LauncherProcessList.TabIndex = 1;
      this.LauncherProcessList.SelectedIndexChanged += new EventHandler(this.LauncherProcessList_SelectedIndexChanged);
      this.LauncherProcessTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.LauncherProcessTextBox.Location = new Point(149, 246);
      this.LauncherProcessTextBox.Name = "LauncherProcessTextBox";
      this.LauncherProcessTextBox.ReadOnly = true;
      this.LauncherProcessTextBox.Size = new Size(334, 20);
      this.LauncherProcessTextBox.TabIndex = 11;
      this.LauncherTimer.Enabled = true;
      this.LauncherTimer.Interval = 1000;
      this.LauncherTimer.Tick += new EventHandler(this.LauncherTimer_Tick);
      this.LauncherMapFilesSystemWatcher.EnableRaisingEvents = true;
      this.LauncherMapFilesSystemWatcher.Filter = "*.map";
      this.LauncherMapFilesSystemWatcher.NotifyFilter = NotifyFilters.FileName;
      this.LauncherMapFilesSystemWatcher.SynchronizingObject = (ISynchronizeInvoke) this;
      this.LauncherMapFilesSystemWatcher.Changed += new FileSystemEventHandler(this.LauncherMapFilesSystemWatcher_Changed);
      this.LauncherMapFilesSystemWatcher.Created += new FileSystemEventHandler(this.LauncherMapFilesSystemWatcher_Created);
      this.LauncherMapFilesSystemWatcher.Deleted += new FileSystemEventHandler(this.LauncherMapFilesSystemWatcher_Deleted);
      this.LauncherMapFilesSystemWatcher.Renamed += new RenamedEventHandler(this.LauncherMapFilesSystemWatcher_Renamed);
      this.LauncherModsDirectorySystemWatcher.EnableRaisingEvents = true;
      this.LauncherModsDirectorySystemWatcher.NotifyFilter = NotifyFilters.DirectoryName;
      this.LauncherModsDirectorySystemWatcher.SynchronizingObject = (ISynchronizeInvoke) this;
      this.LauncherModsDirectorySystemWatcher.Changed += new FileSystemEventHandler(this.LauncherModsDirectorySystemWatcher_Changed);
      this.LauncherModsDirectorySystemWatcher.Created += new FileSystemEventHandler(this.LauncherModsDirectorySystemWatcher_Created);
      this.LauncherModsDirectorySystemWatcher.Deleted += new FileSystemEventHandler(this.LauncherModsDirectorySystemWatcher_Deleted);
      this.LauncherModsDirectorySystemWatcher.Renamed += new RenamedEventHandler(this.LauncherModsDirectorySystemWatcher_Renamed);
      this.menuStrip1.BackColor = SystemColors.ControlLight;
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.LauncherfileToolStripMenuItem,
        (ToolStripItem) this.LauncherdocsToolStripMenuItem,
        (ToolStripItem) this.LaunchertoolsToolStripMenuItem,
        (ToolStripItem) this.LauncherhelpToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(978, 24);
      this.menuStrip1.TabIndex = 9;
      this.menuStrip1.Text = "menuStrip1";
      this.LauncherfileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.newModToolStripMenuItem,
        (ToolStripItem) this.LaunchernewMapToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.gameDirToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.LauncherexitToolStripMenuItem
      });
      this.LauncherfileToolStripMenuItem.Name = "LauncherfileToolStripMenuItem";
      this.LauncherfileToolStripMenuItem.Size = new Size(37, 20);
      this.LauncherfileToolStripMenuItem.Text = "File";
      this.newModToolStripMenuItem.Name = "newModToolStripMenuItem";
      this.newModToolStripMenuItem.ShortcutKeys = Keys.F2;
      this.newModToolStripMenuItem.Size = new Size(170, 22);
      this.newModToolStripMenuItem.Text = "New mod...";
      this.newModToolStripMenuItem.Click += new EventHandler(this.newModToolStripMenuItem_Click);
      this.LaunchernewMapToolStripMenuItem.Name = "LaunchernewMapToolStripMenuItem";
      this.LaunchernewMapToolStripMenuItem.ShortcutKeys = Keys.F3;
      this.LaunchernewMapToolStripMenuItem.Size = new Size(170, 22);
      this.LaunchernewMapToolStripMenuItem.Text = "New map...";
      this.LaunchernewMapToolStripMenuItem.Visible = false;
      this.LaunchernewMapToolStripMenuItem.Click += new EventHandler(this.LaunchernewMapToolStripMenuItem_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(167, 6);
      this.gameDirToolStripMenuItem.Name = "gameDirToolStripMenuItem";
      this.gameDirToolStripMenuItem.ShortcutKeys = Keys.F5;
      this.gameDirToolStripMenuItem.Size = new Size(170, 22);
      this.gameDirToolStripMenuItem.Text = "View Game Dir";
      this.gameDirToolStripMenuItem.Click += new EventHandler(this.gameDirToolStripMenuItem_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(167, 6);
      this.LauncherexitToolStripMenuItem.Name = "LauncherexitToolStripMenuItem";
      this.LauncherexitToolStripMenuItem.Size = new Size(170, 22);
      this.LauncherexitToolStripMenuItem.Text = "Exit";
      this.LauncherexitToolStripMenuItem.Click += new EventHandler(this.LauncherexitToolStripMenuItem_Click);
      this.LauncherdocsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.mayaExporterToolStripMenuItem,
        (ToolStripItem) this.exporterTutorialToolStripMenuItem
      });
      this.LauncherdocsToolStripMenuItem.Name = "LauncherdocsToolStripMenuItem";
      this.LauncherdocsToolStripMenuItem.Size = new Size(45, 20);
      this.LauncherdocsToolStripMenuItem.Text = "Docs";
      this.mayaExporterToolStripMenuItem.Name = "mayaExporterToolStripMenuItem";
      this.mayaExporterToolStripMenuItem.Size = new Size(161, 22);
      this.mayaExporterToolStripMenuItem.Text = "Maya CoDTools";
      this.mayaExporterToolStripMenuItem.Click += new EventHandler(this.mayaExporterToolStripMenuItem_Click);
      this.exporterTutorialToolStripMenuItem.Name = "exporterTutorialToolStripMenuItem";
      this.exporterTutorialToolStripMenuItem.Size = new Size(161, 22);
      this.exporterTutorialToolStripMenuItem.Text = "Exporter Tutorial";
      this.exporterTutorialToolStripMenuItem.Click += new EventHandler(this.exporterTutorialToolStripMenuItem_Click);
      this.LaunchertoolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.mayaPluginSetupToolStripMenuItem
      });
      this.LaunchertoolsToolStripMenuItem.Name = "LaunchertoolsToolStripMenuItem";
      this.LaunchertoolsToolStripMenuItem.Size = new Size(48, 20);
      this.LaunchertoolsToolStripMenuItem.Text = "Tools";
      this.mayaPluginSetupToolStripMenuItem.Name = "mayaPluginSetupToolStripMenuItem";
      this.mayaPluginSetupToolStripMenuItem.Size = new Size(173, 22);
      this.mayaPluginSetupToolStripMenuItem.Text = "Maya Plugin Setup";
      this.mayaPluginSetupToolStripMenuItem.Click += new EventHandler(this.mayaPluginSetupToolStripMenuItem_Click);
      this.LauncherhelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.LauncherwikiToolStripMenuItem
      });
      this.LauncherhelpToolStripMenuItem.Name = "LauncherhelpToolStripMenuItem";
      this.LauncherhelpToolStripMenuItem.Size = new Size(44, 20);
      this.LauncherhelpToolStripMenuItem.Text = "Help";
      this.LauncherwikiToolStripMenuItem.Name = "LauncherwikiToolStripMenuItem";
      this.LauncherwikiToolStripMenuItem.ShortcutKeys = Keys.F1;
      this.LauncherwikiToolStripMenuItem.Size = new Size(116, 22);
      this.LauncherwikiToolStripMenuItem.Text = "Wiki";
      this.LauncherwikiToolStripMenuItem.Click += new EventHandler(this.LauncherwikiToolStripMenuItem_Click);
      this.LauncherMapListContextMenuStrip.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.runToolStripMenuItem,
        (ToolStripItem) this.editToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.deleteToolStripMenuItem,
        (ToolStripItem) this.renameToolStripMenuItem
      });
      this.LauncherMapListContextMenuStrip.Name = "LauncherMapListContextMenuStrip";
      this.LauncherMapListContextMenuStrip.Size = new Size(118, 98);
      this.runToolStripMenuItem.Image = (Image) Resources.icon_sp;
      this.runToolStripMenuItem.Name = "runToolStripMenuItem";
      this.runToolStripMenuItem.Size = new Size(117, 22);
      this.runToolStripMenuItem.Text = "&Run";
      this.runToolStripMenuItem.Click += new EventHandler(this.runToolStripMenuItem_Click);
      this.editToolStripMenuItem.Image = (Image) Resources.radiant;
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new Size(117, 22);
      this.editToolStripMenuItem.Text = "&Edit";
      this.editToolStripMenuItem.Click += new EventHandler(this.editToolStripMenuItem_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(114, 6);
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new Size(117, 22);
      this.deleteToolStripMenuItem.Text = "&Delete";
      this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
      this.renameToolStripMenuItem.Enabled = false;
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new Size(117, 22);
      this.renameToolStripMenuItem.Text = "Re&name";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(978, 688);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.LauncherSplitter);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (LauncherForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Launcher";
      this.FormClosing += new FormClosingEventHandler(this.LauncherForm_FormClosing);
      this.Load += new EventHandler(this.LauncherForm_Load);
      this.LauncherSplitter.Panel1.ResumeLayout(false);
      this.LauncherSplitter.Panel1.PerformLayout();
      this.LauncherSplitter.Panel2.ResumeLayout(false);
      this.LauncherSplitter.Panel2.PerformLayout();
      this.LauncherSplitter.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.LauncherRunGameCustomCommandLineGroupBox.ResumeLayout(false);
      this.LauncherRunGameCustomCommandLineGroupBox.PerformLayout();
      this.LauncherRunGameGroupBox.ResumeLayout(false);
      this.LauncherRunGameGroupBox.PerformLayout();
      this.LauncherRunGameCustomCommandLineMPGroupBox.ResumeLayout(false);
      this.LauncherRunGameCustomCommandLineMPGroupBox.PerformLayout();
      this.LauncherRunGameModGroupBox.ResumeLayout(false);
      ((ISupportInitialize) this.LauncherIconBlops).EndInit();
      this.LauncherGameGroupBox.ResumeLayout(false);
      this.LauncherGameGroupBox.PerformLayout();
      ((ISupportInitialize) this.LauncherIconMP).EndInit();
      ((ISupportInitialize) this.LauncherIconSP).EndInit();
      this.LauncherTab.ResumeLayout(false);
      this.LauncherTabModBuilder.ResumeLayout(false);
      this.LauncherIwdFileGroupBox.ResumeLayout(false);
      this.LauncherModGroupBox.ResumeLayout(false);
      this.LauncherModFolderGroupBox.ResumeLayout(false);
      this.LauncherModBuildGroupBox.ResumeLayout(false);
      this.LauncherModBuildGroupBox.PerformLayout();
      this.LauncherModZoneSourceGroupBox.ResumeLayout(false);
      this.LauncherTabCompileLevel.ResumeLayout(false);
      this.LauncherTabCompileLevel.PerformLayout();
      this.LauncherCompileLevelOptionsGroupBox.ResumeLayout(false);
      this.LauncherCompileLevelOptionsGroupBox.PerformLayout();
      this.LauncherGridFileGroupBox.ResumeLayout(false);
      this.LauncherGridFileGroupBox.PerformLayout();
      this.LauncherTabExplore.ResumeLayout(false);
      this.LauncherExploreGroupBox.ResumeLayout(false);
      this.LauncherExploreRawMapsDirGroupBox.ResumeLayout(false);
      this.LauncherExploreRawDirGroupBox.ResumeLayout(false);
      this.LauncherExploreDevDirGroupBox.ResumeLayout(false);
      this.LauncherExploreBlopsDirGroupBox.ResumeLayout(false);
      this.LauncherApplicationsGroupBox.ResumeLayout(false);
      ((ISupportInitialize) this.LauncherIconRadiant).EndInit();
      ((ISupportInitialize) this.LauncherIconEffectsEditor).EndInit();
      ((ISupportInitialize) this.LauncherIconConverter).EndInit();
      ((ISupportInitialize) this.LauncherIconAssetViewer).EndInit();
      ((ISupportInitialize) this.LauncherIconAssetManager).EndInit();
      this.LauncherWarningsNumericUpDown.EndInit();
      ((ISupportInitialize) this.LauncherWarningsPictureBox).EndInit();
      this.LauncherErrorsNumericUpDown.EndInit();
      ((ISupportInitialize) this.LauncherErrorsPictureBox).EndInit();
      this.LauncherProcessGroupBox.ResumeLayout(false);
      this.LauncherMapFilesSystemWatcher.EndInit();
      this.LauncherModsDirectorySystemWatcher.EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.LauncherMapListContextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private bool IsMP()
    {
      return LauncherCS.Launcher.IsMP(this.mapName);
    }

    private void LauncherButtonAssetManager_Click(object sender, EventArgs e)
    {
      this.LaunchProcess("asset_manager", "", (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherButtonAssetViewer_Click(object sender, EventArgs e)
    {
      this.LaunchProcess("AssetViewer", "", (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherButtonCancel_Click(object sender, EventArgs e)
    {
      int selectedIndex = this.LauncherProcessList.SelectedIndex;
      if (selectedIndex < 0)
        return;
      ((Process) ((DictionaryEntry) this.processList[selectedIndex]).Key).Kill();
    }

    private void LauncherButtonCreateMap_Click(object sender, EventArgs e)
    {
      if (new CreateMapForm().ShowDialog() != DialogResult.OK)
        return;
      this.UpdateMapList();
      this.EnableMapList();
    }

    private void LauncherButtonEffectsEd_Click(object sender, EventArgs e)
    {
      this.LaunchProcess("EffectsEd3", "", (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherButtonMP_Click(object sender, EventArgs e)
    {
      string arguments = "";
      if (this.LauncherGameDeveloperBox.Checked)
        arguments += "+set developer 1 +set developer_script 1 ";
      if (this.LauncherGameLogfileBox.Checked)
        arguments += "+set logfile 1 ";
      this.LaunchProcess(LauncherCS.Launcher.GetGameApplication(true), arguments, (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherButtonRadiant_Click(object sender, EventArgs e)
    {
      this.LaunchProcess("CoDBORadiant", this.mapName != null ? Path.Combine(LauncherCS.Launcher.GetMapSourceDirectory(false), this.mapName + ".map") : "", (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherButtonRunConverter_Click(object sender, EventArgs eventArgs)
    {
      this.LaunchProcess("converter", "-nopause -n -nospam", (string) null, true, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherButtonSP_Click(object sender, EventArgs e)
    {
      string arguments = "";
      if (this.LauncherGameDeveloperBox.Checked)
        arguments += "+set developer 1";
      if (this.LauncherGameLogfileBox.Checked)
        arguments += "+set logfile 1 ";
      this.LaunchProcess(LauncherCS.Launcher.GetGameApplication(false), arguments, (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherClearConsoleButton_Click(object sender, EventArgs e)
    {
      this.LauncherErrorsCounter.Text = "0";
      this.LauncherErrorsPictureBox.BackgroundImage = (Image) Resources.error_grey;
      this.LauncherWarningsCounter.Text = "0";
      this.LauncherWarningsPictureBox.BackgroundImage = (Image) Resources.warning_grey;
      this.LauncherConsole.Clear();
    }

    private void LauncherCompileBSPButton_Click(object sender, EventArgs e)
    {
      int num = (int) new LightOptionsForm().ShowDialog();
    }

    private void LauncherCompileLevelButton_Click(object sender, EventArgs e)
    {
      this.CompileLevel();
    }

    private void LauncherCompileLightsButton_Click(object sender, EventArgs e)
    {
      int num = (int) new BspOptionsForm().ShowDialog();
    }

    private void LauncherCompileLightsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      LauncherCS.Launcher.mapSettings.SetDecimal("lightoptions_quality", new Decimal(20));
    }

    private void LauncherCreateMap_Click(object sender, EventArgs e)
    {
      if (new CreateMapForm().ShowDialog() != DialogResult.OK)
        return;
      this.UpdateMapList();
      this.EnableMapList();
    }

    private void LauncherDeleteMap_Click(object sender, EventArgs e)
    {
      string[] mapFiles1 = LauncherCS.Launcher.GetMapFiles(this.mapName);
      if (DialogResult.Yes != MessageBox.Show("The following files would be deleted:\n\n" + LauncherCS.Launcher.StringArrayToString(mapFiles1), "Are you sure you want me to delete these files?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
        return;
      foreach (string fileName in mapFiles1)
        LauncherCS.Launcher.DeleteFile(fileName);
      string[] mapFiles2 = LauncherCS.Launcher.GetMapFiles(this.mapName);
      if (mapFiles2.Length != 0)
      {
        int num = (int) MessageBox.Show("I could not delete the following files:\n\n" + LauncherCS.Launcher.StringArrayToString(mapFiles2), "There was an error deleting files", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.UpdateMapList();
      this.EnableMapList();
      this.LauncherModSpecificMapComboBox.SelectedIndex = -1;
    }

    private void LauncherEditZoneSourceButton_Click(object sender, EventArgs e)
    {
      int num = (int) new ZoneSourceForm(this.LauncherModComboBox.SelectedItem.ToString()).ShowDialog();
    }

    private void LauncherErrorsNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      if (Convert.ToInt32(this.LauncherErrorsCounter.Text) <= 0)
        return;
      this.LauncherConsole.SelectionStart = this.LauncherErrorsNumericUpDown.Value != new Decimal(0) ? this.FindLauncherConsoleText("ERROR:", this.LauncherConsole.SelectionStart + this.LauncherConsole.SelectionLength, this.LauncherConsole.Text.Length) : this.FindLauncherConsoleText("ERROR:", 0, this.LauncherConsole.SelectionStart);
    }

    private void LauncherexitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void LauncherExploreBlopsDirConfigsButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "players\\");
    }

    private void LauncherExploreBlopsDirGameButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory());
    }

    private void LauncherExploreBlopsDirModsButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "mods\\");
    }

    private void LauncherExploreDevDirBinButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "bin\\");
    }

    private void LauncherExploreDevDirMapSrcButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "map_source\\");
    }

    private void LauncherExploreDevDirModelExportButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "model_export\\");
    }

    private void LauncherExploreDevDirRawButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\");
    }

    private void LauncherExploreDevDirSrcDataButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "source_data\\");
    }

    private void LauncherExploreDevDirTextureAssetsButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "texture_assets\\");
    }

    private void LauncherExploreDevDirZoneSourceButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "zone_source\\");
    }

    private void LauncherExploreRawDirAnimTreesButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\animtrees\\");
    }

    private void LauncherExploreRawDirCSCButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\clientscripts\\");
    }

    private void LauncherExploreRawDirFXButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\fx\\");
    }

    private void LauncherExploreRawDirGSCButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\");
    }

    private void LauncherExploreRawDirLocsButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\english\\localizedstrings\\");
    }

    private void LauncherExploreRawDirMPButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\mp\\");
    }

    private void LauncherExploreRawDirSoundAliasesButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\soundaliases\\");
    }

    private void LauncherExploreRawDirVisionButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\vision\\");
    }

    private void LauncherExploreRawDirWeaponsButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\weapons\\");
    }

    private void LauncherExploreRawGSCDirMPArtButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\mp\\createart\\");
    }

    private void LauncherExploreRawGSCDirMPButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\mp\\");
    }

    private void LauncherExploreRawGSCDirMPFXButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\mp\\createfx\\");
    }

    private void LauncherExploreRawGSCDirMPGametypesButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\mp\\gametypes\\");
    }

    private void LauncherExploreRawGSCDirSPArtButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\createart\\");
    }

    private void LauncherExploreRawGSCDirSPButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\");
    }

    private void LauncherExploreRawGSCDirSPFXButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\createfx\\");
    }

    private void LauncherExploreRawGSCDirSPGametypesButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\gametypes\\");
    }

    private void LauncherExploreRawGSCDirSPVoiceButton_Click(object sender, EventArgs e)
    {
      this.ExploreOpenDir(LauncherCS.Launcher.GetRootDirectory() + "raw\\maps\\voice\\");
    }

    private void LauncherForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.processTable.Count != 0)
      {
        switch (MessageBox.Show("But there are still processes running!\n\nDo you want to close them, or cancel exiting from the application?", "Application will exit!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
        {
          case DialogResult.Cancel:
            e.Cancel = true;
            return;
          case DialogResult.Yes:
            IDictionaryEnumerator enumerator = this.processTable.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
                ((Process) ((DictionaryEntry) enumerator.Current).Key).Kill();
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          default:
            string[] stringArray = new string[this.processTable.Count];
            int index = 0;
            foreach (DictionaryEntry dictionaryEntry in this.processTable)
            {
              try
              {
                stringArray[index] = ((Process) dictionaryEntry.Key).MainModule.FileName;
              }
              catch
              {
                stringArray[index] = (string) dictionaryEntry.Value;
              }
              ++index;
            }
            if (stringArray.Length != 0)
            {
              int num = (int) MessageBox.Show("The following processes are still active:\n\n" + LauncherCS.Launcher.StringArrayToString(stringArray) + "\nPlease close them if neccessary using the Task Manager, or similar program!\n", "Note before exiting the application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
            break;
        }
      }
      this.UpdateMapSettings(true, true);
      this.UpdateModSettings(true, true);
      LauncherCS.Launcher.SaveLauncherSettings(LauncherCS.Launcher.launcherSettings.Get());
    }

    private void LauncherForm_Load(object sender, EventArgs e)
    {
      this.UpdateDVars();
      this.UpdateMapList();
      this.UpdateModList();
      this.EnableMapList();
      this.UpdateStopProcessButton();
      this.LauncherMapFilesSystemWatcher.Path = LauncherCS.Launcher.GetMapSourceDirectory(false);
      this.LauncherModsDirectorySystemWatcher.Path = LauncherCS.Launcher.GetModsDirectory();
      this.LauncherMapFilesSystemWatcher.EnableRaisingEvents = true;
      this.LauncherModsDirectorySystemWatcher.EnableRaisingEvents = true;
      LauncherForm launcherForm = this;
      launcherForm.Text = launcherForm.Text + " - " + LauncherCS.Launcher.GetRootDirectory();
      this.SetModSelection(LauncherCS.Launcher.launcherSettings.GetString("active_mod"), true);
    }

    private void LauncherGameOptionsFlowPanel_Click(object sender, EventArgs e)
    {
      MouseEventArgs mouseEventArgs = (MouseEventArgs) e;
      Control control = (Control) sender;
      if (mouseEventArgs.Button != MouseButtons.Right)
        return;
      ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
      contextMenuStrip.Items.Add("Edit dvar");
      contextMenuStrip.Items.Add("Remove dvar");
      contextMenuStrip.Items.Add("Add new dvar");
      contextMenuStrip.Items.Add("Duplicate dvar");
      contextMenuStrip.Show(control.PointToScreen(mouseEventArgs.Location));
    }

    private void LauncherGridEditExistingButton_Click(object sender, EventArgs e)
    {
      this.BuildGridDelegate(2);
    }

    private void LauncherGridMakeNewButton_Click(object sender, EventArgs e)
    {
      this.BuildGridDelegate(1);
    }

    private void LauncherIwdFileTree_AfterCheck(object sender, TreeViewEventArgs e)
    {
      this.LauncherIwdFileTreeBeginUpdate();
      this.RecursiveCheckNodesDown(e.Node.Nodes, e.Node.Checked);
      if (e.Node.Checked)
        this.RecursiveCheckNodesUp(e.Node.Parent, e.Node.Checked);
      this.LauncherIwdFileTreeEndUpdate();
    }

    private void LauncherIwdFileTree_DoubleClick(object sender, EventArgs e)
    {
      if (this.LauncherIwdFileTree.SelectedNode == null)
        return;
      try
      {
        new Process()
        {
          StartInfo = {
            ErrorDialog = true,
            FileName = Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), this.LauncherIwdFileTree.SelectedNode.FullPath)
          }
        }.Start();
      }
      catch
      {
      }
    }

    private void LauncherIwdFileTreeBeginUpdate()
    {
      this.LauncherIwdFileTree.BeginUpdate();
      this.LauncherIwdFileTree.AfterCheck -= new TreeViewEventHandler(this.LauncherIwdFileTree_AfterCheck);
    }

    private void LauncherIwdFileTreeEndUpdate()
    {
      this.LauncherIwdFileTree.AfterCheck += new TreeViewEventHandler(this.LauncherIwdFileTree_AfterCheck);
      this.LauncherIwdFileTree.EndUpdate();
    }

    private void LauncherMapFilesSystemWatcher_Changed(object sender, FileSystemEventArgs e)
    {
      this.UpdateMapList();
    }

    private void LauncherMapFilesSystemWatcher_Created(object sender, FileSystemEventArgs e)
    {
      this.UpdateMapList();
    }

    private void LauncherMapFilesSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
      this.UpdateMapList();
    }

    private void LauncherMapFilesSystemWatcher_Renamed(object sender, RenamedEventArgs e)
    {
      this.UpdateMapList();
    }

    private void LauncherMapList_DoubleClick(object sender, EventArgs e)
    {
      this.LauncherMapList.SelectedItem = (object) null;
    }

    private void LauncherMapList_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateMapSettings(true, true);
      this.EnableMapList();
      this.LauncherRunGameMapNameTextBox.Text = this.LauncherMapList.SelectedItem != null ? this.LauncherMapList.SelectedItem.ToString() : "";
    }

    private void LauncherMapList_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      for (int index = 0; index < this.LauncherMapList.Items.Count; ++index)
      {
        if (this.LauncherMapList.GetItemRectangle(index).Contains(e.Location))
          this.LauncherMapList_WaitingForMouseUp = index;
      }
    }

    private void LauncherMapList_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right && this.LauncherMapList_WaitingForMouseUp != -1)
      {
        for (int index = 0; index < this.LauncherMapList.Items.Count; ++index)
        {
          if (this.LauncherMapList.GetItemRectangle(index).Contains(e.Location) && this.LauncherMapList_WaitingForMouseUp == index)
          {
            this.LauncherMapListContextMenu_Map = index;
            this.LauncherMapList.SelectedIndex = index;
            this.LauncherMapListContextMenuStrip.Show(Cursor.Position);
          }
        }
      }
      this.LauncherMapList_WaitingForMouseUp = -1;
    }

    private void LauncherMapTypeList_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateMapList();
    }

    private void LauncherModBuildButton_Click(object sender, EventArgs e)
    {
      this.LauncherModComboBoxApplySettings(true, true);
      this.UpdateModSettings(true, true);
      this.ModBuildStart();
    }

    private void LauncherModComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      LauncherCS.Launcher.launcherSettings.SetString("active_mod", this.LauncherModComboBox.Text);
      this.LauncherModComboBoxApplySettings(true, false);
      this.UpdateModSettings(true, true);
      this.LauncherModComboBoxApplySettings(false, true);
    }

    private void LauncherModComboBoxApplySettings(bool save = true, bool load = true)
    {
      bool flag = this.LauncherModComboBox.SelectedItem != null;
      this.LauncherModZoneSourceGroupBox.Enabled = flag;
      this.LauncherModBuildGroupBox.Enabled = flag;
      this.LauncherModFolderGroupBox.Enabled = flag;
      this.LauncherIwdFileGroupBox.Enabled = flag;
      this.LauncherIwdFileTreeBeginUpdate();
      if (save && this.modName != null && Directory.Exists(LauncherCS.Launcher.GetModDirectory(this.modName, false)))
        LauncherCS.Launcher.SaveTextFile(Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), this.modName + ".files"), LauncherCS.Launcher.HashTableToStringArray(this.TreeViewToHashTable(this.LauncherIwdFileTree.Nodes)));
      if (load && this.LauncherModComboBox.SelectedItem != null)
      {
        this.modName = this.LauncherModComboBox.SelectedItem.ToString();
        string textFile = Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), this.modName + ".files");
        this.LauncherIwdFileTree.Nodes.Clear();
        this.AddFilesToTreeView(LauncherCS.Launcher.GetModDirectory(this.modName, true), this.LauncherIwdFileTree.Nodes, true);
        this.HashTableToTreeView(LauncherCS.Launcher.StringArrayToHashTable(LauncherCS.Launcher.LoadTextFile(textFile)), this.LauncherIwdFileTree.Nodes);
      }
      this.LauncherIwdFileTreeEndUpdate();
    }

    private void LauncherModFolderViewButton_Click(object sender, EventArgs e)
    {
      Process.Start(LauncherCS.Launcher.GetModDirectory(this.LauncherModComboBox.SelectedItem.ToString(), true));
    }

    private void LauncherModsDirectorySystemWatcher_Changed(object sender, FileSystemEventArgs e)
    {
      this.UpdateModList();
    }

    private void LauncherModsDirectorySystemWatcher_Created(object sender, FileSystemEventArgs e)
    {
      this.UpdateModList();
    }

    private void LauncherModsDirectorySystemWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
      this.UpdateModList();
    }

    private void LauncherModsDirectorySystemWatcher_Renamed(object sender, RenamedEventArgs e)
    {
      this.UpdateModList();
    }

    private void LauncherModZoneSourceCSVButton_Click(object sender, EventArgs e)
    {
      string str = Path.Combine(LauncherCS.Launcher.GetModDirectory(this.LauncherModComboBox.SelectedItem.ToString(), true), "mod.csv");
      if (!File.Exists(str))
        File.Create(str).Close();
      Process.Start(str);
    }

    private void LauncherModZoneSourceMissingAssetsButton_Click(object sender, EventArgs e)
    {
      string str = Path.Combine(LauncherCS.Launcher.GetModDirectory(this.LauncherModComboBox.SelectedItem.ToString(), true), "missingasset.csv");
      if (File.Exists(str))
      {
        Process.Start(str);
      }
      else
      {
        int num = (int) MessageBox.Show("Could not find missingasset.csv for mod.\nRun the mod with Developer mode to generate it.", "Error");
      }
    }

    private void LaunchernewMapToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (new CreateMapForm().ShowDialog() != DialogResult.OK)
        return;
      this.UpdateMapList();
      this.EnableMapList();
    }

    private void LauncherProcessList_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateStopProcessButton();
    }

    private void LauncherRunGameButton_Click(object sender, EventArgs e)
    {
      foreach (ComboBox dvarComboBox in this.dvarComboBoxes)
      {
        string str1 = dvarComboBox.Text.Trim();
        if (str1 != "")
        {
          foreach (string str2 in dvarComboBox.Items)
          {
            if (!(str1.ToLower() != str2.ToLower()))
            {
              str1 = "";
              break;
            }
          }
        }
        if (str1 != "")
          dvarComboBox.Items.Add((object) dvarComboBox.Text);
      }
      string arguments = this.GetGameOptions();
      if (this.LauncherRunGameDeveloperBox.Checked)
        arguments += "+set developer 1 ";
      if (this.LauncherRunGameLogfileBox.Checked)
        arguments += "+set logfile 1 ";
      if (this.LauncherRunGameMapNameTextBox.Text.Length > 0)
        arguments = arguments + "+devmap " + this.LauncherRunGameMapNameTextBox.Text + " ";
      bool mpVersion = false;
      if (this.LauncherRunGameMapNameTextBox.Text.StartsWith("mp_") || this.LauncherRunGameModComboBox.Text.StartsWith("mp_"))
        mpVersion = true;
      if (mpVersion && this.LauncherRunGameCustomCommandLineMPCheckBox.Checked)
        arguments += this.LauncherRunGameCustomCommandLineMPTextBox.Text;
      else if (!mpVersion && this.LauncherRunGameCustomCommandLineCheckBox.Checked)
        arguments += this.LauncherRunGameCustomCommandLineTextBox.Text;
      this.LaunchProcess(LauncherCS.Launcher.GetGameApplication(mpVersion), arguments, (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void LauncherRunGameCustomCommandLineTextBox_TextChanged(object sender, EventArgs e)
    {
    }

    private void LauncherRunGameCustomCommandLineTextBox_Validating(
      object sender,
      CancelEventArgs e)
    {
    }

    private void LauncherSaveConsoleButton_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "Rich Text File|*.rtf|Text File|*.txt|Log File|*.log";
      saveFileDialog1.Title = "Save console log";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      int num = (int) saveFileDialog2.ShowDialog();
      if (!(saveFileDialog2.FileName != ""))
        return;
      if (Path.GetExtension(saveFileDialog2.FileName) == ".rtf")
        this.LauncherConsole.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.RichText);
      else
        File.WriteAllText(saveFileDialog2.FileName, this.LauncherConsole.Text);
    }

    private void LauncherscriptToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start(LauncherCS.Launcher.GetRootDirectory() + "/docs/script_docs/scriptFunctions/index.htm");
    }

    private void LauncherScrollBottomConsoleButton_Click(object sender, EventArgs e)
    {
      this.LauncherConsole.SelectionStart = this.LauncherConsole.Text.Length;
      this.LauncherConsole.ScrollToCaret();
    }

    private void LauncherTimer_Tick(object sender, EventArgs e)
    {
      if (this.consoleProcess != null)
        this.LauncherProcessTimeElapsedTextBox.Text = (DateTime.Now - this.consoleProcessStartTime).ToString().Substring(0, 8);
      string gameOptions = this.GetGameOptions();
      if (!(this.LauncherRunGameCommandLineTextBox.Text != gameOptions))
        return;
      this.LauncherRunGameCommandLineTextBox.Text = gameOptions;
    }

    private void LauncherWarningsNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      if (Convert.ToInt32(this.LauncherWarningsCounter.Text) <= 0)
        return;
      this.LauncherConsole.SelectionStart = this.LauncherWarningsNumericUpDown.Value != new Decimal(0) ? this.FindLauncherConsoleText("WARNING:", this.LauncherConsole.SelectionStart + this.LauncherConsole.SelectionLength, this.LauncherConsole.Text.Length) : this.FindLauncherConsoleText("WARNING:", 0, this.LauncherConsole.SelectionStart);
    }

    private void LauncherWikiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://moddingfordummies.proboards.com");
    }

    private void LauncherwikiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start("https://moddingfordummies.proboards.com");
    }

    private void LaunchProcess(
      string processFileName,
      string arguments,
      string workingDirectory,
      bool consoleAttached,
      LauncherForm.ProcessFinishedDelegate theProcessFinishedDelegate)
    {
      if (this.consoleProcess != null & consoleAttached)
      {
        this.LauncherConsole.Invoke((Delegate) (() =>
        {
          string text;
          if (!(processFileName == (string) this.processTable[(object) this.consoleProcess]))
            text = "Cannot start console process " + processFileName + "!\n\nAnother console process (" + this.processTable[(object) this.consoleProcess] + ") is already running";
          else
            text = "Console process (" + processFileName + ") is already running!";
          int num = (int) MessageBox.Show(text, "Console Busy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }));
      }
      else
      {
        try
        {
          Dictionary<string, string> dictionary = new Dictionary<string, string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
          dictionary.Add("BlackOps", "game_mod.dll");
          dictionary.Add("AssetViewer", "asset_viewer.dll");
          dictionary.Add("linker_pc", "linker_pc.dll");
          dictionary.Add("CoDBORadiant", "radiant_mod.dll");
          dictionary.Add("cod2map", "cod2map.dll");
          dictionary.Add("cod2rad", "cod2rad.dll");
          string str = processFileName;
          string fileName = Path.GetFileName(processFileName);
          if (dictionary.ContainsKey(fileName))
          {
            arguments = dictionary[fileName] + " " + processFileName + " " + arguments;
            processFileName = "launcher_ldr";
            str = fileName;
          }
          Process process = new Process()
          {
            StartInfo = {
              FileName = Path.Combine(LauncherCS.Launcher.GetStartupDirectory(), processFileName),
              CreateNoWindow = true,
              Arguments = arguments,
              UseShellExecute = false
            }
          };
          process.StartInfo.WorkingDirectory = workingDirectory != null ? workingDirectory : Path.GetDirectoryName(process.StartInfo.FileName);
          process.EnableRaisingEvents = true;
          process.Exited += (EventHandler) ((argument0, argument1) =>
          {
            this.processTable.Remove((object) process);
            this.UpdateProcessList();
          });
          if (consoleAttached)
          {
            this.processFinishedDelegate = theProcessFinishedDelegate;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += (DataReceivedEventHandler) ((s, e) => this.WriteConsole(e.Data, false));
            process.ErrorDataReceived += (DataReceivedEventHandler) ((s, e) => this.WriteConsole(e.Data, true));
            process.Exited += (EventHandler) ((argument2, argument3) => this.LauncherButtonCancel.Invoke((Delegate) (() =>
            {
              this.LauncherProcessTimeElapsedTextBox.Text = process.ExitCode != 0 ? "Error " + process.ExitCode.ToString() : "Success";
              this.LauncherConsole.Focus();
              this.consoleProcess = (Process) null;
              this.UpdateConsoleColor();
              if (this.processFinishedDelegate == null)
                return;
              LauncherForm.ProcessFinishedDelegate finishedDelegate = this.processFinishedDelegate;
              this.processFinishedDelegate = (LauncherForm.ProcessFinishedDelegate) null;
              Process lastProcess = process;
              finishedDelegate(lastProcess);
            })));
          }
          process.Exited += (EventHandler) ((argument4, argument5) => process.Dispose());
          process.Start();
          if (consoleAttached)
          {
            this.consoleProcess = process;
            this.consoleProcessStartTime = DateTime.Now;
            this.UpdateConsoleColor();
            this.LauncherProcessTextBox.Text = (workingDirectory != null ? workingDirectory + "> " : "") + processFileName + " " + arguments;
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
          }
          this.processTable.Add((object) process, (object) str);
          this.UpdateProcessList();
        }
        catch
        {
          this.WriteConsole("Failed to run: " + processFileName + " " + arguments, true);
          if (this.processFinishedDelegate == null)
            return;
          LauncherForm.ProcessFinishedDelegate finishedDelegate = this.processFinishedDelegate;
          this.processFinishedDelegate = (LauncherForm.ProcessFinishedDelegate) null;
          finishedDelegate((Process) null);
        }
      }
    }

    private void LaunchProcessHelper(
      bool shouldRun,
      LauncherForm.ProcessFinishedDelegate nextStage,
      Process lastProcess,
      string processName,
      string processOptions,
      string workingDirectory)
    {
      if (lastProcess != null && lastProcess.ExitCode != 0 || !shouldRun)
        nextStage(lastProcess);
      else
        this.LaunchProcess(processName, processOptions, workingDirectory, true, nextStage);
    }

    private void LaunchProcessHelper(
      bool shouldRun,
      LauncherForm.ProcessFinishedDelegate nextStage,
      Process lastProcess,
      string processName,
      string processOptions)
    {
      this.LaunchProcessHelper(shouldRun, nextStage, lastProcess, processName, processOptions, (string) null);
    }

    private void mayaExporterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start(LauncherCS.Launcher.GetRootDirectory() + "/bin/maya/tools/Help/Model_Exporter.pdf");
    }

    private void mayaPluginSetupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("This will overwrite any existing Maya environment variable file and usersetup.\n     Continue?", "Maya Plugin Setup", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      if (Directory.Exists(folderPath + "/maya"))
      {
        string str1 = folderPath + "/maya";
        string str2;
        bool flag;
        if (!Directory.Exists(str1 + "/2009-x64"))
        {
          if (!Directory.Exists(str1 + "/2009"))
          {
            int num = (int) MessageBox.Show("Error: Couldn not find Maya 2009 folder.", "Maya Plugin Setup");
            return;
          }
          str2 = str1 + "/2009";
          flag = false;
        }
        else
        {
          str2 = str1 + "/2009-x64";
          flag = true;
        }
        if (File.Exists(str2 + "/Maya.env"))
          File.Delete(str2 + "/Maya.env");
        string str3 = Path.Combine(LauncherCS.Launcher.GetBinDirectory(), "maya/tools/");
        string[] contents = new string[2]
        {
          "MAYA_SCRIPT_PATH  = " + str3,
          "MAYA_PLUG_IN_PATH = " + str3
        };
        File.WriteAllLines(str2 + "/Maya.env", contents);
        File.Copy(Path.Combine(LauncherCS.Launcher.GetBinDirectory(), "maya/tools/usersetup.mel"), str2 + "/scripts/usersetup.mel", true);
        File.SetAttributes(str2 + "/scripts/usersetup.mel", FileAttributes.Normal);
        string str4 = "Maya2009_x86.zip";
        if (flag)
          str4 = "Maya2009_x64.zip";
        this.LaunchProcess("7za", "e \"" + str4 + "\" -y", Path.Combine(LauncherCS.Launcher.GetBinDirectory(), "maya/tools/"), false, (LauncherForm.ProcessFinishedDelegate) null);
        string str5 = "(32bit)";
        if (flag)
          str5 = "(64bit)";
        int num1 = (int) MessageBox.Show("Success!\nCoDTools should now be in the menu strip the next time you launch Maya " + str5, "Maya Plugin Setup");
      }
      else
      {
        int num2 = (int) MessageBox.Show("Error: Maya MyDocuments folder doesn't exist, please run Maya at least once.", "Maya Plugin Setup");
      }
    }

    private void ModBuildFastFileDelegate(Process lastProcess)
    {
      if (this.LauncherModBuildFastFilesCheckBox.Checked)
        LauncherCS.Launcher.CopyFileSmart(Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), "mod.csv"), Path.Combine(LauncherCS.Launcher.GetZoneSourceDirectory(), "mod.csv"));
      string str = "";
      if (this.LauncherModBuildLinkerOptionsTextBox.Text != null)
        str = this.LauncherModBuildLinkerOptionsTextBox.Text;
      bool shouldRun = this.LauncherModBuildFastFilesCheckBox.Checked;
      LauncherForm.ProcessFinishedDelegate nextStage = new LauncherForm.ProcessFinishedDelegate(this.ModBuildMoveModFastFileDelegate);
      string[] strArray = new string[6]
      {
        "-nopause -language ",
        LauncherCS.Launcher.GetLanguage(),
        " -moddir ",
        this.modName,
        " mod ",
        str
      };
      this.LaunchProcessHelper(shouldRun, nextStage, lastProcess, "linker_pc", string.Concat(strArray));
    }

    private void ModBuildFinishedDelegate(Process lastProcess)
    {
      LauncherCS.Launcher.Publish();
      this.EnableControls(true);
    }

    private void ModBuildIwdFileDelegate(Process lastProcess)
    {
      string fileName = Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), this.modName + ".iwd");
      if (this.LauncherModBuildIwdFileCheckBox.Checked)
        LauncherCS.Launcher.DeleteFile(fileName, false);
      bool shouldRun = this.LauncherModBuildIwdFileCheckBox.Checked;
      LauncherForm.ProcessFinishedDelegate nextStage = new LauncherForm.ProcessFinishedDelegate(this.ModBuildFinishedDelegate);
      string[] strArray = new string[5]
      {
        "a \"",
        fileName,
        "\" -tzip -r \"@",
        Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), this.modName + ".files"),
        "\""
      };
      this.LaunchProcessHelper(shouldRun, nextStage, lastProcess, "7za", string.Concat(strArray), LauncherCS.Launcher.GetModDirectory(this.modName, true));
    }

    private void ModBuildMoveModFastFileDelegate(Process lastProcess)
    {
      if (this.LauncherModBuildFastFilesCheckBox.Checked)
        LauncherCS.Launcher.MoveFile(Path.Combine(LauncherCS.Launcher.GetZoneDirectory(), "mod.ff"), Path.Combine(LauncherCS.Launcher.GetModDirectory(this.modName, true), "mod.ff"));
      this.ModBuildIwdFileDelegate(lastProcess);
    }

    private void ModBuildSoundDelegate(Process lastProcess)
    {
      this.LaunchProcessHelper(this.LauncherModBuildSoundsCheckBox.Checked, new LauncherForm.ProcessFinishedDelegate(this.ModBuildFastFileDelegate), lastProcess, "MODSound", "-pc -ignore_orphans " + (this.LauncherModVerboseCheckBox.Checked ? "-verbose " : ""));
    }

    private void ModBuildStart()
    {
      this.EnableControls(false);
      this.ModBuildSoundDelegate((Process) null);
    }

    private void newModToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new CreateModForm().ShowDialog();
    }

    private void RecursiveCheckNodesDown(TreeNodeCollection tree, bool checkedFlag)
    {
      if (tree == null)
        return;
      foreach (TreeNode treeNode in tree)
      {
        TreeNodeCollection nodes = treeNode.Nodes;
        bool flag = checkedFlag;
        bool checkedFlag1 = flag;
        treeNode.Checked = flag;
        this.RecursiveCheckNodesDown(nodes, checkedFlag1);
      }
    }

    private void RecursiveCheckNodesUp(TreeNode node, bool checkedFlag)
    {
      if (node == null)
        return;
      TreeNode parent = node.Parent;
      bool flag = checkedFlag;
      bool checkedFlag1 = flag;
      node.Checked = flag;
      this.RecursiveCheckNodesUp(parent, checkedFlag1);
    }

    private void TreeViewToHashTable(TreeNodeCollection tree, Hashtable ht)
    {
      if (tree == null)
        return;
      foreach (TreeNode treeNode in tree)
      {
        if (!treeNode.Checked || treeNode.Tag == null)
          ht.Remove((object) treeNode.FullPath);
        else
          ht.Add((object) treeNode.FullPath, (object) null);
        this.TreeViewToHashTable(treeNode.Nodes, ht);
      }
    }

    private Hashtable TreeViewToHashTable(TreeNodeCollection tree)
    {
      Hashtable ht = new Hashtable();
      this.TreeViewToHashTable(tree, ht);
      return ht;
    }

    private void UpdateConsoleColor()
    {
      this.LauncherConsole.BackColor = this.consoleProcess == null ? Color.Black : Color.Black;
    }

    private void UpdateDVars()
    {
    }

    private void UpdateMapList()
    {
      object selectedItem = this.LauncherMapList.SelectedItem;
      int selectedIndex1 = this.LauncherMapList.SelectedIndex;
      int selectedIndex2 = this.LauncherMapTypeList.SelectedIndex;
      this.LauncherMapList.Items.Clear();
      this.LauncherMapList.Items.AddRange((object[]) LauncherCS.Launcher.GetMapList(selectedIndex2));
      if (this.LauncherMapList.Items.Count == 0)
        return;
      this.LauncherMapList.SelectedItem = selectedItem;
      if (this.LauncherMapList.SelectedItem != null)
        return;
      this.LauncherRunGameMapNameTextBox.Text = (string) null;
    }

    private void UpdateMapSettings(bool save = true, bool load = true)
    {
      if (this.mapName != null & save)
      {
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_bsp", this.LauncherCompileBSPCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_lights", this.LauncherCompileLightsCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_paths", this.LauncherConnectPathsCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_reflections", this.LauncherCompileReflectionsCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_buildffs", this.LauncherBuildFastFilesCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_bspinfo", this.LauncherBspInfoCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_runafter", this.LauncherRunMapAfterCompileCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_useruntab", this.LauncherUseRunGameTypeOptionsCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetString("compile_runoptions", this.LauncherCustomRunOptionsTextBox.Text);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_modenabled", this.LauncherModSpecificMapCheckBox.Checked);
        LauncherCS.Launcher.mapSettings.SetString("compile_modname", this.LauncherModSpecificMapComboBox.Text);
        LauncherCS.Launcher.mapSettings.SetBoolean("compile_collectdots", this.LauncherGridCollectDotsCheckBox.Checked);
        LauncherCS.Launcher.SaveMapSettings(this.mapName, LauncherCS.Launcher.mapSettings.Get());
        this.mapName = (string) null;
      }
      if (!(this.LauncherMapList.SelectedItem != null & load))
        return;
      this.mapName = this.LauncherMapList.SelectedItem.ToString();
      LauncherCS.Launcher.mapSettings.Set(LauncherCS.Launcher.LoadMapSettings(this.mapName));
      this.LauncherCompileBSPCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_bsp", false);
      this.LauncherCompileLightsCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_lights", false);
      this.LauncherConnectPathsCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_paths", false);
      this.LauncherCompileReflectionsCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_reflections", false);
      this.LauncherBuildFastFilesCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_buildffs", false);
      this.LauncherBspInfoCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_bspinfo", false);
      this.LauncherRunMapAfterCompileCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_runafter", false);
      this.LauncherUseRunGameTypeOptionsCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_useruntab", false);
      this.LauncherCustomRunOptionsTextBox.Text = LauncherCS.Launcher.mapSettings.GetString("compile_runoptions");
      this.LauncherGridCollectDotsCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_collectdots", false);
      this.LauncherModSpecificMapCheckBox.Checked = LauncherCS.Launcher.mapSettings.GetBoolean("compile_modenabled", false);
      string str = LauncherCS.Launcher.mapSettings.GetString("compile_modname");
      if (str.Length > 0)
        this.LauncherModSpecificMapComboBox.Text = str;
      else
        this.LauncherModSpecificMapComboBox.SelectedIndex = -1;
    }

    private void UpdateModSettings(bool save = true, bool load = true)
    {
      if (this.modName != null & save)
      {
        LauncherCS.Launcher.modSettings.SetBoolean("build_fastfile", this.LauncherModBuildFastFilesCheckBox.Checked);
        LauncherCS.Launcher.modSettings.SetBoolean("build_iwd", this.LauncherModBuildIwdFileCheckBox.Checked);
        LauncherCS.Launcher.modSettings.SetBoolean("build_sounds", this.LauncherModBuildSoundsCheckBox.Checked);
        LauncherCS.Launcher.modSettings.SetBoolean("build_verbose", this.LauncherModVerboseCheckBox.Checked);
        LauncherCS.Launcher.modSettings.SetString("build_options", this.LauncherModBuildLinkerOptionsTextBox.Text);
        LauncherCS.Launcher.SaveModSettings(this.modName, LauncherCS.Launcher.modSettings.Get());
        this.modName = (string) null;
      }
      if (!(this.LauncherModComboBox.SelectedItem != null & load))
        return;
      this.modName = this.LauncherModComboBox.SelectedItem.ToString();
      LauncherCS.Launcher.modSettings.Set(LauncherCS.Launcher.LoadModSettings(this.modName));
      this.LauncherModBuildFastFilesCheckBox.Checked = LauncherCS.Launcher.modSettings.GetBoolean("build_fastfile", false);
      this.LauncherModBuildIwdFileCheckBox.Checked = LauncherCS.Launcher.modSettings.GetBoolean("build_iwd", false);
      this.LauncherModBuildSoundsCheckBox.Checked = LauncherCS.Launcher.modSettings.GetBoolean("build_sounds", false);
      this.LauncherModVerboseCheckBox.Checked = LauncherCS.Launcher.modSettings.GetBoolean("build_verbose", false);
      this.LauncherModBuildLinkerOptionsTextBox.Text = LauncherCS.Launcher.modSettings.GetString("build_options");
    }

    private void UpdateModList()
    {
      ComboBox[] comboBoxArray = new ComboBox[3]
      {
        this.LauncherRunGameModComboBox,
        this.LauncherModComboBox,
        this.LauncherModSpecificMapComboBox
      };
      string[] strArray = new string[comboBoxArray.Length];
      string[] modList = LauncherCS.Launcher.GetModList();
      for (int index = 0; index < comboBoxArray.Length; ++index)
      {
        strArray[index] = comboBoxArray[index].SelectedItem != null ? comboBoxArray[index].SelectedItem.ToString() : "";
        comboBoxArray[index].Items.Clear();
      }
      this.LauncherRunGameModComboBox.Items.Add((object) "(not set)");
      this.LauncherRunGameModComboBox.Items.Add((object) "(auto)");
      for (int index = 0; index < comboBoxArray.Length; ++index)
      {
        comboBoxArray[index].Items.AddRange((object[]) modList);
        if (comboBoxArray[index].Items.Count > 0)
          comboBoxArray[index].Text = strArray[index];
      }
      this.LauncherModComboBoxApplySettings(true, true);
      if (this.LauncherRunGameModComboBox.SelectedIndex >= 0)
        return;
      this.LauncherRunGameModComboBox.SelectedIndex = 0;
    }

    private void UpdateProcessList()
    {
      this.LauncherProcessList.Invoke((Delegate) (() =>
      {
        this.processList.Clear();
        this.LauncherProcessList.Items.Clear();
        foreach (DictionaryEntry dictionaryEntry in this.processTable)
        {
          this.processList.Add((object) dictionaryEntry);
          this.LauncherProcessList.Items.Add((object) Path.GetFileNameWithoutExtension((string) dictionaryEntry.Value));
        }
        if (this.LauncherProcessList.SelectedIndex < 0 && this.LauncherProcessList.Items.Count > 0)
          this.LauncherProcessList.SelectedIndex = 0;
        this.UpdateStopProcessButton();
      }));
    }

    private void UpdateRunGameCommandLine()
    {
    }

    private void UpdateStopProcessButton()
    {
      int selectedIndex = this.LauncherProcessList.SelectedIndex;
      if (selectedIndex < 0)
      {
        this.LauncherButtonCancel.Enabled = false;
        this.LauncherButtonCancel.Text = "No Active Process\n\nStart one and then use this button to stop it";
      }
      else
      {
        this.LauncherButtonCancel.Enabled = true;
        if (((DictionaryEntry) this.processList[selectedIndex]).Key == this.consoleProcess)
          this.LauncherButtonCancel.Text = "Stop Console Process\n\n" + Path.GetFileNameWithoutExtension(((DictionaryEntry) this.processList[selectedIndex]).Value.ToString());
        else
          this.LauncherButtonCancel.Text = "Stop Application\n\n" + Path.GetFileNameWithoutExtension(((DictionaryEntry) this.processList[selectedIndex]).Value.ToString());
      }
    }

    private void utilityDocsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start(LauncherCS.Launcher.GetRootDirectory() + "/docs/script_docs/UtilityFunctions/index.htm");
    }

    private void WriteConsole(string s, bool isStdError)
    {
      if (s == null)
        return;
      long ticks = DateTime.Now.Ticks;
      bool flag2 = ticks - this.consoleTicksWhenLastFocus > 10000000L;
      if (flag2)
        this.consoleTicksWhenLastFocus = ticks;
      if (s.Contains("Setting breakpad minidump AppID = ") || s.Contains("Steam_SetMinidumpSteamID:  Caching Steam ID:  "))
        s = "";
      else
        this.LauncherConsole.Invoke((Delegate) (() =>
        {
          Color selectionColor = this.LauncherConsole.SelectionColor;
          Font selectionFont = this.LauncherConsole.SelectionFont;
          bool flag1 = isStdError || s.Contains("ERROR:");
          bool flag3 = s.Contains("WARNING:");
          if (flag1 | flag3)
          {
            if (!flag1)
            {
              this.LauncherWarningsPictureBox.BackgroundImage = (Image) Resources.Warning;
              this.LauncherWarningsCounter.Text = Convert.ToString(Convert.ToInt32(this.LauncherWarningsCounter.Text) + 1);
            }
            else
            {
              this.LauncherErrorsPictureBox.BackgroundImage = (Image) Resources.error;
              this.LauncherErrorsCounter.Text = Convert.ToString(Convert.ToInt32(this.LauncherErrorsCounter.Text) + 1);
            }
            this.LauncherConsole.SelectionFont = new Font(this.LauncherConsole.SelectionFont, FontStyle.Bold);
            this.LauncherConsole.SelectionColor = flag1 ? Color.Red : Color.Green;
          }
          this.LauncherConsole.AppendText(s + "\n");
          if (flag2)
            this.LauncherConsole.Focus();
          if (!(flag1 | flag3))
            return;
          this.LauncherConsole.SelectionColor = selectionColor;
          this.LauncherConsole.SelectionFont = selectionFont;
        }));
    }

    private void WriteError(string s)
    {
      this.WriteConsole(s, true);
    }

    private void WriteMessage(string s)
    {
      this.WriteConsole(s, false);
    }

    private event LauncherForm.ProcessFinishedDelegate processFinishedDelegate;

    private void runToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string str1 = this.LauncherMapList.Items[this.LauncherMapListContextMenu_Map].ToString();
      string str2 = "+set fs_game ";
      string arguments = !this.LauncherModSpecificMapCheckBox.Checked ? "" : (this.LauncherModSpecificMapComboBox.Text.Length <= 0 || !this.LauncherModSpecificMapCheckBox.Checked ? "" : str2 + "\"mods/" + this.LauncherModSpecificMapComboBox.Text + "\" ");
      if (str1.Length > 0)
        arguments = arguments + "+devmap " + str1 + " ";
      bool mpVersion = false;
      if (this.LauncherRunGameMapNameTextBox.Text.Contains("mp_"))
        mpVersion = true;
      this.LaunchProcess(LauncherCS.Launcher.GetGameApplication(mpVersion), arguments, (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LaunchProcess("CoDBORadiant", "\"" + Path.Combine(LauncherCS.Launcher.GetMapSourceDirectory(false), this.LauncherMapList.Items[this.LauncherMapListContextMenu_Map].ToString() + ".map") + "\"", (string) null, false, (LauncherForm.ProcessFinishedDelegate) null);
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string mapName = this.LauncherMapList.Items[this.LauncherMapListContextMenu_Map].ToString();
      string[] mapFiles1 = LauncherCS.Launcher.GetMapFiles(mapName);
      if (DialogResult.Yes != MessageBox.Show("The following files would be deleted:\n\n" + LauncherCS.Launcher.StringArrayToString(mapFiles1), "Are you sure you want to delete these files?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
        return;
      foreach (string fileName in mapFiles1)
        LauncherCS.Launcher.DeleteFile(fileName);
      string[] mapFiles2 = LauncherCS.Launcher.GetMapFiles(mapName);
      if (mapFiles2.Length != 0)
      {
        int num = (int) MessageBox.Show("Could not delete the following files:\n\n" + LauncherCS.Launcher.StringArrayToString(mapFiles2), "Error deleting files", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.UpdateMapList();
      this.EnableMapList();
    }

    public enum LauncherTabType
    {
      Mods,
      Maps,
      Explore,
    }

    public delegate void ProcessFinishedDelegate(Process lastProcess);
  }
}
