<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MainForm
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkSelectedPolys = New System.Windows.Forms.CheckBox()
        Me.chkLocalEffects = New System.Windows.Forms.CheckBox()
        Me.cboLCLayer = New System.Windows.Forms.ComboBox()
        Me.txtRainValue = New System.Windows.Forms.TextBox()
        Me.optUseValue = New System.Windows.Forms.RadioButton()
        Me.txtbxRainGrid = New System.Windows.Forms.TextBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBigHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGeneralHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me.cboWaterShedDelineations = New System.Windows.Forms.ComboBox()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me.cboPrecipitationScenarios = New System.Windows.Forms.ComboBox()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdOpenWS = New System.Windows.Forms.Button()
        Me.txtOutputWS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSoilsLayer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fraLC = New System.Windows.Forms.GroupBox()
        Me.cboLandCoverType = New System.Windows.Forms.ComboBox()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me.TabsForGrids = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.dgvPollutants = New System.Windows.Forms.DataGridView()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblErodFactor = New System.Windows.Forms.Label()
        Me.lblKFactor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkCalcErosion = New System.Windows.Forms.CheckBox()
        Me.frameRainFall = New System.Windows.Forms.GroupBox()
        Me.btnOpenRainfallFactorGrid = New System.Windows.Forms.Button()
        Me.optUseGRID = New System.Windows.Forms.RadioButton()
        Me.cboErodFactor = New System.Windows.Forms.ComboBox()
        Me.cboSoilAttribute = New System.Windows.Forms.ComboBox()
        Me.frmSDR = New System.Windows.Forms.GroupBox()
        Me.cmdOpenSDR = New System.Windows.Forms.Button()
        Me.txtSDRGRID = New System.Windows.Forms.TextBox()
        Me.chkSDR = New System.Windows.Forms.CheckBox()
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLandUse = New System.Windows.Forms.DataGridView()
        Me.LUApply = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LUScenario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUScenarioXml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnxtmnuLandUse = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddScenarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditScenarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteScenarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._SSTab1_TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblManageNote = New System.Windows.Forms.Label()
        Me.dgvManagementScen = New System.Windows.Forms.DataGridView()
        Me.ManageApply = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChangeAreaLayer = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ChangeToClass = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cnxtmnuManagement = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AppendRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCurrentRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me._chkIgnoreMgmt_0 = New System.Windows.Forms.CheckBox()
        Me._chkIgnoreLU_0 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboWaterQualityCriteriaStd = New System.Windows.Forms.ComboBox()
        Me.cboTargetLayer = New System.Windows.Forms.ComboBox()
        Me._Label1_19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PollApply = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PollutantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoefSet = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.WhichCoeff = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IndexShapefile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndexFieldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainMenu1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.fraLC.SuspendLayout()
        Me.TabsForGrids.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        CType(Me.dgvPollutants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.frameRainFall.SuspendLayout()
        Me.frmSDR.SuspendLayout()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.dgvLandUse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cnxtmnuLandUse.SuspendLayout()
        Me._SSTab1_TabPage3.SuspendLayout()
        CType(Me.dgvManagementScen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cnxtmnuManagement.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSelectedPolys
        '
        Me.chkSelectedPolys.Location = New System.Drawing.Point(8, 19)
        Me.chkSelectedPolys.Name = "chkSelectedPolys"
        Me.chkSelectedPolys.Size = New System.Drawing.Size(168, 20)
        Me.chkSelectedPolys.TabIndex = 61
        Me.chkSelectedPolys.Text = "Selected Polygons Only"
        Me.ToolTip1.SetToolTip(Me.chkSelectedPolys, "Select to limit analysis to selected polygons from a map layer")
        Me.chkSelectedPolys.UseVisualStyleBackColor = True
        '
        'chkLocalEffects
        '
        Me.chkLocalEffects.Location = New System.Drawing.Point(10, 19)
        Me.chkLocalEffects.Name = "chkLocalEffects"
        Me.chkLocalEffects.Size = New System.Drawing.Size(131, 16)
        Me.chkLocalEffects.TabIndex = 51
        Me.chkLocalEffects.Text = "Include Local Effects"
        Me.ToolTip1.SetToolTip(Me.chkLocalEffects, "Select for analysis of local effects only")
        Me.chkLocalEffects.UseVisualStyleBackColor = True
        '
        'cboLCLayer
        '
        Me.cboLCLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLCLayer.Location = New System.Drawing.Point(87, 25)
        Me.cboLCLayer.Name = "cboLCLayer"
        Me.cboLCLayer.Size = New System.Drawing.Size(149, 21)
        Me.cboLCLayer.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cboLCLayer, "Choose a Land Cover GRID from current layers in map view")
        '
        'txtRainValue
        '
        Me.txtRainValue.AcceptsReturn = True
        Me.txtRainValue.Location = New System.Drawing.Point(159, 53)
        Me.txtRainValue.MaxLength = 0
        Me.txtRainValue.Name = "txtRainValue"
        Me.txtRainValue.Size = New System.Drawing.Size(61, 20)
        Me.txtRainValue.TabIndex = 26
        '
        'optUseValue
        '
        Me.optUseValue.Location = New System.Drawing.Point(19, 53)
        Me.optUseValue.Name = "optUseValue"
        Me.optUseValue.Size = New System.Drawing.Size(134, 19)
        Me.optUseValue.TabIndex = 24
        Me.optUseValue.TabStop = True
        Me.optUseValue.Text = "Use Constant (inches): "
        Me.optUseValue.UseVisualStyleBackColor = True
        '
        'txtbxRainGrid
        '
        Me.txtbxRainGrid.AcceptsReturn = True
        Me.txtbxRainGrid.Location = New System.Drawing.Point(102, 22)
        Me.txtbxRainGrid.MaxLength = 0
        Me.txtbxRainGrid.Name = "txtbxRainGrid"
        Me.txtbxRainGrid.Size = New System.Drawing.Size(122, 20)
        Me.txtbxRainGrid.TabIndex = 69
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuBigHelp})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(644, 24)
        Me.MainMenu1.TabIndex = 59
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSpace, Me.mnuSave, Me.mnuSaveAs, Me.mnuSpace1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(195, 22)
        Me.mnuNew.Text = "New Project"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(195, 22)
        Me.mnuOpen.Text = "Open Project..."
        '
        'mnuSpace
        '
        Me.mnuSpace.Name = "mnuSpace"
        Me.mnuSpace.Size = New System.Drawing.Size(192, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(195, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(195, 22)
        Me.mnuSaveAs.Text = "Save As..."
        '
        'mnuSpace1
        '
        Me.mnuSpace1.Name = "mnuSpace1"
        Me.mnuSpace1.Size = New System.Drawing.Size(192, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(195, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuBigHelp
        '
        Me.mnuBigHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGeneralHelp})
        Me.mnuBigHelp.Name = "mnuBigHelp"
        Me.mnuBigHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuBigHelp.Text = "&Help"
        '
        'mnuGeneralHelp
        '
        Me.mnuGeneralHelp.Name = "mnuGeneralHelp"
        Me.mnuGeneralHelp.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuGeneralHelp.Size = New System.Drawing.Size(234, 22)
        Me.mnuGeneralHelp.Text = "OpenNSPECT Help..."
        '
        '_Label1_6
        '
        Me._Label1_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Label1_6.Location = New System.Drawing.Point(3, 60)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.Size = New System.Drawing.Size(153, 15)
        Me._Label1_6.TabIndex = 60
        Me._Label1_6.Text = "Hydrologic Soils Data Set:"
        '
        'cboWaterShedDelineations
        '
        Me.cboWaterShedDelineations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWaterShedDelineations.Location = New System.Drawing.Point(162, 3)
        Me.cboWaterShedDelineations.Name = "cboWaterShedDelineations"
        Me.cboWaterShedDelineations.Size = New System.Drawing.Size(149, 21)
        Me.cboWaterShedDelineations.TabIndex = 0
        '
        '_Label1_3
        '
        Me._Label1_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Label1_3.Location = New System.Drawing.Point(3, 5)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.Size = New System.Drawing.Size(153, 16)
        Me._Label1_3.TabIndex = 57
        Me._Label1_3.Text = "Watershed Delineation:"
        '
        'cboPrecipitationScenarios
        '
        Me.cboPrecipitationScenarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrecipitationScenarios.Location = New System.Drawing.Point(162, 30)
        Me.cboPrecipitationScenarios.Name = "cboPrecipitationScenarios"
        Me.cboPrecipitationScenarios.Size = New System.Drawing.Size(149, 21)
        Me.cboPrecipitationScenarios.TabIndex = 0
        '
        '_Label1_7
        '
        Me._Label1_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Label1_7.Location = New System.Drawing.Point(3, 31)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.Size = New System.Drawing.Size(153, 18)
        Me._Label1_7.TabIndex = 54
        Me._Label1_7.Text = "Precipitation Scenario: "
        '
        'btnSelect
        '
        Me.btnSelect.CausesValidation = False
        Me.btnSelect.Location = New System.Drawing.Point(182, 12)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(54, 23)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Frame3
        '
        Me.Frame3.Controls.Add(Me.txtProjectName)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Location = New System.Drawing.Point(9, 25)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.Size = New System.Drawing.Size(625, 47)
        Me.Frame3.TabIndex = 0
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Project Information "
        '
        'txtProjectName
        '
        Me.txtProjectName.AcceptsReturn = True
        Me.txtProjectName.Location = New System.Drawing.Point(55, 17)
        Me.txtProjectName.MaxLength = 0
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(192, 20)
        Me.txtProjectName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Name:"
        '
        'cmdOpenWS
        '
        Me.cmdOpenWS.Image = CType(resources.GetObject("cmdOpenWS.Image"), System.Drawing.Image)
        Me.cmdOpenWS.Location = New System.Drawing.Point(578, 14)
        Me.cmdOpenWS.Name = "cmdOpenWS"
        Me.cmdOpenWS.Size = New System.Drawing.Size(23, 21)
        Me.cmdOpenWS.TabIndex = 40
        Me.cmdOpenWS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOpenWS.UseVisualStyleBackColor = True
        '
        'txtOutputWS
        '
        Me.txtOutputWS.AcceptsReturn = True
        Me.txtOutputWS.Location = New System.Drawing.Point(381, 15)
        Me.txtOutputWS.MaxLength = 0
        Me.txtOutputWS.Name = "txtOutputWS"
        Me.txtOutputWS.ReadOnly = True
        Me.txtOutputWS.Size = New System.Drawing.Size(192, 20)
        Me.txtOutputWS.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(278, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Working Directory:"
        '
        'cboSoilsLayer
        '
        Me.cboSoilsLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSoilsLayer.Location = New System.Drawing.Point(162, 57)
        Me.cboSoilsLayer.Name = "cboSoilsLayer"
        Me.cboSoilsLayer.Size = New System.Drawing.Size(149, 21)
        Me.cboSoilsLayer.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(3, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Water Quality Standard:"
        Me.Label6.Visible = False
        '
        'fraLC
        '
        Me.fraLC.Controls.Add(Me.cboLCLayer)
        Me.fraLC.Controls.Add(Me.cboLandCoverType)
        Me.fraLC.Controls.Add(Me._Label1_0)
        Me.fraLC.Controls.Add(Me._Label1_2)
        Me.fraLC.Location = New System.Drawing.Point(9, 78)
        Me.fraLC.Name = "fraLC"
        Me.fraLC.Padding = New System.Windows.Forms.Padding(0)
        Me.fraLC.Size = New System.Drawing.Size(247, 82)
        Me.fraLC.TabIndex = 1
        Me.fraLC.TabStop = False
        Me.fraLC.Text = "Land Cover"
        '
        'cboLandCoverType
        '
        Me.cboLandCoverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLandCoverType.Location = New System.Drawing.Point(87, 52)
        Me.cboLandCoverType.Name = "cboLandCoverType"
        Me.cboLandCoverType.Size = New System.Drawing.Size(149, 21)
        Me.cboLandCoverType.TabIndex = 2
        '
        '_Label1_0
        '
        Me._Label1_0.Location = New System.Drawing.Point(10, 25)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.Size = New System.Drawing.Size(40, 18)
        Me._Label1_0.TabIndex = 7
        Me._Label1_0.Text = "Grid:"
        '
        '_Label1_2
        '
        Me._Label1_2.Location = New System.Drawing.Point(10, 55)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.Size = New System.Drawing.Size(40, 18)
        Me._Label1_2.TabIndex = 6
        Me._Label1_2.Text = "Type:"
        '
        'TabsForGrids
        '
        Me.TabsForGrids.Controls.Add(Me._SSTab1_TabPage0)
        Me.TabsForGrids.Controls.Add(Me._SSTab1_TabPage1)
        Me.TabsForGrids.Controls.Add(Me._SSTab1_TabPage2)
        Me.TabsForGrids.Controls.Add(Me._SSTab1_TabPage3)
        Me.TabsForGrids.ItemSize = New System.Drawing.Size(42, 18)
        Me.TabsForGrids.Location = New System.Drawing.Point(16, 301)
        Me.TabsForGrids.Name = "TabsForGrids"
        Me.TabsForGrids.SelectedIndex = 3
        Me.TabsForGrids.Size = New System.Drawing.Size(618, 235)
        Me.TabsForGrids.TabIndex = 7
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.dgvPollutants)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(610, 209)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Pollutants"
        '
        'dgvPollutants
        '
        Me.dgvPollutants.AllowUserToAddRows = False
        Me.dgvPollutants.AllowUserToDeleteRows = False
        Me.dgvPollutants.AllowUserToResizeColumns = False
        Me.dgvPollutants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPollutants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PollApply, Me.PollutantName, Me.CoefSet, Me.WhichCoeff, Me.IndexShapefile, Me.IndexFieldName, Me.Threshold, Me.TypeDef})
        Me.dgvPollutants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPollutants.Location = New System.Drawing.Point(0, 0)
        Me.dgvPollutants.MultiSelect = False
        Me.dgvPollutants.Name = "dgvPollutants"
        Me.dgvPollutants.ShowEditingIcon = False
        Me.dgvPollutants.Size = New System.Drawing.Size(610, 209)
        Me.dgvPollutants.TabIndex = 0
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.lblErodFactor)
        Me._SSTab1_TabPage1.Controls.Add(Me.lblKFactor)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label3)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label7)
        Me._SSTab1_TabPage1.Controls.Add(Me.chkCalcErosion)
        Me._SSTab1_TabPage1.Controls.Add(Me.frameRainFall)
        Me._SSTab1_TabPage1.Controls.Add(Me.cboErodFactor)
        Me._SSTab1_TabPage1.Controls.Add(Me.cboSoilAttribute)
        Me._SSTab1_TabPage1.Controls.Add(Me.frmSDR)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(610, 209)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Erosion"
        '
        'lblErodFactor
        '
        Me.lblErodFactor.Location = New System.Drawing.Point(15, 178)
        Me.lblErodFactor.Name = "lblErodFactor"
        Me.lblErodFactor.Size = New System.Drawing.Size(129, 14)
        Me.lblErodFactor.TabIndex = 28
        Me.lblErodFactor.Text = "Erodibility Factor Attribute: "
        Me.lblErodFactor.Visible = False
        '
        'lblKFactor
        '
        Me.lblKFactor.Location = New System.Drawing.Point(104, 34)
        Me.lblKFactor.Name = "lblKFactor"
        Me.lblKFactor.Size = New System.Drawing.Size(254, 19)
        Me.lblKFactor.TabIndex = 43
        Me.lblKFactor.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Hydrologic Soil Group Attribute:"
        Me.Label3.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 19)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "K Factor Dataset:"
        '
        'chkCalcErosion
        '
        Me.chkCalcErosion.Location = New System.Drawing.Point(13, 12)
        Me.chkCalcErosion.Name = "chkCalcErosion"
        Me.chkCalcErosion.Size = New System.Drawing.Size(331, 18)
        Me.chkCalcErosion.TabIndex = 15
        Me.chkCalcErosion.Text = "Calculate Erosion for Annual Type Precipitation Scenario"
        Me.chkCalcErosion.UseVisualStyleBackColor = True
        '
        'frameRainFall
        '
        Me.frameRainFall.Controls.Add(Me.txtbxRainGrid)
        Me.frameRainFall.Controls.Add(Me.btnOpenRainfallFactorGrid)
        Me.frameRainFall.Controls.Add(Me.txtRainValue)
        Me.frameRainFall.Controls.Add(Me.optUseValue)
        Me.frameRainFall.Controls.Add(Me.optUseGRID)
        Me.frameRainFall.Location = New System.Drawing.Point(12, 58)
        Me.frameRainFall.Name = "frameRainFall"
        Me.frameRainFall.Padding = New System.Windows.Forms.Padding(0)
        Me.frameRainFall.Size = New System.Drawing.Size(268, 83)
        Me.frameRainFall.TabIndex = 22
        Me.frameRainFall.TabStop = False
        Me.frameRainFall.Text = "Rainfall Factor "
        '
        'btnOpenRainfallFactorGrid
        '
        Me.btnOpenRainfallFactorGrid.Image = CType(resources.GetObject("btnOpenRainfallFactorGrid.Image"), System.Drawing.Image)
        Me.btnOpenRainfallFactorGrid.Location = New System.Drawing.Point(230, 23)
        Me.btnOpenRainfallFactorGrid.Name = "btnOpenRainfallFactorGrid"
        Me.btnOpenRainfallFactorGrid.Size = New System.Drawing.Size(23, 19)
        Me.btnOpenRainfallFactorGrid.TabIndex = 68
        Me.btnOpenRainfallFactorGrid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOpenRainfallFactorGrid.UseVisualStyleBackColor = True
        '
        'optUseGRID
        '
        Me.optUseGRID.Checked = True
        Me.optUseGRID.Enabled = False
        Me.optUseGRID.Location = New System.Drawing.Point(19, 23)
        Me.optUseGRID.Name = "optUseGRID"
        Me.optUseGRID.Size = New System.Drawing.Size(91, 17)
        Me.optUseGRID.TabIndex = 23
        Me.optUseGRID.TabStop = True
        Me.optUseGRID.Text = "Use GRID: "
        Me.optUseGRID.UseVisualStyleBackColor = True
        '
        'cboErodFactor
        '
        Me.cboErodFactor.Location = New System.Drawing.Point(197, 171)
        Me.cboErodFactor.Name = "cboErodFactor"
        Me.cboErodFactor.Size = New System.Drawing.Size(141, 21)
        Me.cboErodFactor.TabIndex = 29
        Me.cboErodFactor.Visible = False
        '
        'cboSoilAttribute
        '
        Me.cboSoilAttribute.Location = New System.Drawing.Point(197, 148)
        Me.cboSoilAttribute.Name = "cboSoilAttribute"
        Me.cboSoilAttribute.Size = New System.Drawing.Size(141, 21)
        Me.cboSoilAttribute.TabIndex = 44
        Me.cboSoilAttribute.Visible = False
        '
        'frmSDR
        '
        Me.frmSDR.Controls.Add(Me.cmdOpenSDR)
        Me.frmSDR.Controls.Add(Me.txtSDRGRID)
        Me.frmSDR.Controls.Add(Me.chkSDR)
        Me.frmSDR.Location = New System.Drawing.Point(295, 59)
        Me.frmSDR.Name = "frmSDR"
        Me.frmSDR.Padding = New System.Windows.Forms.Padding(0)
        Me.frmSDR.Size = New System.Drawing.Size(297, 53)
        Me.frmSDR.TabIndex = 64
        Me.frmSDR.TabStop = False
        Me.frmSDR.Text = "Frame7"
        '
        'cmdOpenSDR
        '
        Me.cmdOpenSDR.Enabled = False
        Me.cmdOpenSDR.Image = CType(resources.GetObject("cmdOpenSDR.Image"), System.Drawing.Image)
        Me.cmdOpenSDR.Location = New System.Drawing.Point(256, 22)
        Me.cmdOpenSDR.Name = "cmdOpenSDR"
        Me.cmdOpenSDR.Size = New System.Drawing.Size(23, 19)
        Me.cmdOpenSDR.TabIndex = 67
        Me.cmdOpenSDR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOpenSDR.UseVisualStyleBackColor = True
        '
        'txtSDRGRID
        '
        Me.txtSDRGRID.AcceptsReturn = True
        Me.txtSDRGRID.Enabled = False
        Me.txtSDRGRID.Location = New System.Drawing.Point(16, 22)
        Me.txtSDRGRID.MaxLength = 0
        Me.txtSDRGRID.Name = "txtSDRGRID"
        Me.txtSDRGRID.Size = New System.Drawing.Size(233, 20)
        Me.txtSDRGRID.TabIndex = 66
        '
        'chkSDR
        '
        Me.chkSDR.Location = New System.Drawing.Point(8, 0)
        Me.chkSDR.Name = "chkSDR"
        Me.chkSDR.Size = New System.Drawing.Size(217, 16)
        Me.chkSDR.TabIndex = 65
        Me.chkSDR.Text = "Sediment Delivery Ratio GRID (optional)"
        Me.chkSDR.UseVisualStyleBackColor = True
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage2.Controls.Add(Me.dgvLandUse)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(610, 209)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Land Uses"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Note: Right-click the table to Add, Edit, and Delete Land Use Scenarios"
        '
        'dgvLandUse
        '
        Me.dgvLandUse.AllowUserToAddRows = False
        Me.dgvLandUse.AllowUserToDeleteRows = False
        Me.dgvLandUse.AllowUserToResizeColumns = False
        Me.dgvLandUse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLandUse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LUApply, Me.LUScenario, Me.LUScenarioXml})
        Me.dgvLandUse.ContextMenuStrip = Me.cnxtmnuLandUse
        Me.dgvLandUse.Location = New System.Drawing.Point(3, 3)
        Me.dgvLandUse.MultiSelect = False
        Me.dgvLandUse.Name = "dgvLandUse"
        Me.dgvLandUse.ShowEditingIcon = False
        Me.dgvLandUse.Size = New System.Drawing.Size(604, 179)
        Me.dgvLandUse.TabIndex = 0
        '
        'LUApply
        '
        Me.LUApply.HeaderText = "Apply"
        Me.LUApply.Name = "LUApply"
        Me.LUApply.Width = 53
        '
        'LUScenario
        '
        Me.LUScenario.HeaderText = "Land Use Scenario"
        Me.LUScenario.Name = "LUScenario"
        Me.LUScenario.ReadOnly = True
        Me.LUScenario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.LUScenario.Width = 250
        '
        'LUScenarioXml
        '
        Me.LUScenarioXml.HeaderText = "LUScenarioXml"
        Me.LUScenarioXml.Name = "LUScenarioXml"
        Me.LUScenarioXml.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.LUScenarioXml.Visible = False
        '
        'cnxtmnuLandUse
        '
        Me.cnxtmnuLandUse.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddScenarioToolStripMenuItem, Me.EditScenarioToolStripMenuItem, Me.DeleteScenarioToolStripMenuItem})
        Me.cnxtmnuLandUse.Name = "cnxtmnuLandUse"
        Me.cnxtmnuLandUse.Size = New System.Drawing.Size(165, 70)
        '
        'AddScenarioToolStripMenuItem
        '
        Me.AddScenarioToolStripMenuItem.Name = "AddScenarioToolStripMenuItem"
        Me.AddScenarioToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddScenarioToolStripMenuItem.Text = "Add Scenario..."
        '
        'EditScenarioToolStripMenuItem
        '
        Me.EditScenarioToolStripMenuItem.Name = "EditScenarioToolStripMenuItem"
        Me.EditScenarioToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditScenarioToolStripMenuItem.Text = "Edit Scenario..."
        '
        'DeleteScenarioToolStripMenuItem
        '
        Me.DeleteScenarioToolStripMenuItem.Name = "DeleteScenarioToolStripMenuItem"
        Me.DeleteScenarioToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DeleteScenarioToolStripMenuItem.Text = "Delete Scenario..."
        '
        '_SSTab1_TabPage3
        '
        Me._SSTab1_TabPage3.Controls.Add(Me.lblManageNote)
        Me._SSTab1_TabPage3.Controls.Add(Me.dgvManagementScen)
        Me._SSTab1_TabPage3.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        Me._SSTab1_TabPage3.Size = New System.Drawing.Size(610, 209)
        Me._SSTab1_TabPage3.TabIndex = 3
        Me._SSTab1_TabPage3.Text = "Management Scenarios"
        '
        'lblManageNote
        '
        Me.lblManageNote.AutoSize = True
        Me.lblManageNote.Location = New System.Drawing.Point(3, 186)
        Me.lblManageNote.Name = "lblManageNote"
        Me.lblManageNote.Size = New System.Drawing.Size(302, 13)
        Me.lblManageNote.TabIndex = 1
        Me.lblManageNote.Text = "Note: Right-click the table to Append, Insert, and Delete Rows"
        '
        'dgvManagementScen
        '
        Me.dgvManagementScen.AllowUserToAddRows = False
        Me.dgvManagementScen.AllowUserToDeleteRows = False
        Me.dgvManagementScen.AllowUserToResizeColumns = False
        Me.dgvManagementScen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManagementScen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManageApply, Me.ChangeAreaLayer, Me.ChangeToClass})
        Me.dgvManagementScen.ContextMenuStrip = Me.cnxtmnuManagement
        Me.dgvManagementScen.Location = New System.Drawing.Point(2, 3)
        Me.dgvManagementScen.MultiSelect = False
        Me.dgvManagementScen.Name = "dgvManagementScen"
        Me.dgvManagementScen.ShowEditingIcon = False
        Me.dgvManagementScen.Size = New System.Drawing.Size(601, 180)
        Me.dgvManagementScen.TabIndex = 0
        '
        'ManageApply
        '
        Me.ManageApply.HeaderText = "Apply"
        Me.ManageApply.Name = "ManageApply"
        Me.ManageApply.Width = 53
        '
        'ChangeAreaLayer
        '
        Me.ChangeAreaLayer.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ChangeAreaLayer.DisplayStyleForCurrentCellOnly = True
        Me.ChangeAreaLayer.HeaderText = "Change Area Layer"
        Me.ChangeAreaLayer.Name = "ChangeAreaLayer"
        Me.ChangeAreaLayer.Width = 180
        '
        'ChangeToClass
        '
        Me.ChangeToClass.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ChangeToClass.DisplayStyleForCurrentCellOnly = True
        Me.ChangeToClass.HeaderText = "Change To Class"
        Me.ChangeToClass.Name = "ChangeToClass"
        Me.ChangeToClass.Width = 180
        '
        'cnxtmnuManagement
        '
        Me.cnxtmnuManagement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppendRowToolStripMenuItem, Me.InsertRowToolStripMenuItem, Me.DeleteCurrentRowToolStripMenuItem})
        Me.cnxtmnuManagement.Name = "cnxtmnuManagement"
        Me.cnxtmnuManagement.Size = New System.Drawing.Size(177, 70)
        '
        'AppendRowToolStripMenuItem
        '
        Me.AppendRowToolStripMenuItem.Name = "AppendRowToolStripMenuItem"
        Me.AppendRowToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AppendRowToolStripMenuItem.Text = "Append Row"
        '
        'InsertRowToolStripMenuItem
        '
        Me.InsertRowToolStripMenuItem.Name = "InsertRowToolStripMenuItem"
        Me.InsertRowToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.InsertRowToolStripMenuItem.Text = "Insert Row"
        '
        'DeleteCurrentRowToolStripMenuItem
        '
        Me.DeleteCurrentRowToolStripMenuItem.Name = "DeleteCurrentRowToolStripMenuItem"
        Me.DeleteCurrentRowToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeleteCurrentRowToolStripMenuItem.Text = "Delete Current Row"
        '
        'cmdRun
        '
        Me.cmdRun.CausesValidation = False
        Me.cmdRun.Location = New System.Drawing.Point(459, 541)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 23)
        Me.cmdRun.TabIndex = 8
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdQuit.Location = New System.Drawing.Point(562, 541)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuit.TabIndex = 9
        Me.cmdQuit.Text = "Cancel"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        '_chkIgnoreMgmt_0
        '
        Me._chkIgnoreMgmt_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._chkIgnoreMgmt_0.Location = New System.Drawing.Point(535, 449)
        Me._chkIgnoreMgmt_0.Name = "_chkIgnoreMgmt_0"
        Me._chkIgnoreMgmt_0.Size = New System.Drawing.Size(15, 12)
        Me._chkIgnoreMgmt_0.TabIndex = 35
        Me._chkIgnoreMgmt_0.Text = "Check2"
        Me._chkIgnoreMgmt_0.UseVisualStyleBackColor = True
        '
        '_chkIgnoreLU_0
        '
        Me._chkIgnoreLU_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._chkIgnoreLU_0.Location = New System.Drawing.Point(467, 461)
        Me._chkIgnoreLU_0.Name = "_chkIgnoreLU_0"
        Me._chkIgnoreLU_0.Size = New System.Drawing.Size(15, 12)
        Me._chkIgnoreLU_0.TabIndex = 36
        Me._chkIgnoreLU_0.Text = "Check2"
        Me._chkIgnoreLU_0.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me._Label1_6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboPrecipitationScenarios, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboWaterShedDelineations, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me._Label1_7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me._Label1_3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboSoilsLayer, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboWaterQualityCriteriaStd, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(291, 95)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(319, 110)
        Me.TableLayoutPanel1.TabIndex = 61
        '
        'cboWaterQualityCriteriaStd
        '
        Me.cboWaterQualityCriteriaStd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWaterQualityCriteriaStd.Enabled = False
        Me.cboWaterQualityCriteriaStd.Location = New System.Drawing.Point(162, 84)
        Me.cboWaterQualityCriteriaStd.Name = "cboWaterQualityCriteriaStd"
        Me.cboWaterQualityCriteriaStd.Size = New System.Drawing.Size(149, 21)
        Me.cboWaterQualityCriteriaStd.TabIndex = 61
        Me.cboWaterQualityCriteriaStd.Visible = False
        '
        'cboTargetLayer
        '
        Me.cboTargetLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTargetLayer.Location = New System.Drawing.Point(87, 41)
        Me.cboTargetLayer.Name = "cboTargetLayer"
        Me.cboTargetLayer.Size = New System.Drawing.Size(149, 21)
        Me.cboTargetLayer.TabIndex = 69
        '
        '_Label1_19
        '
        Me._Label1_19.Location = New System.Drawing.Point(8, 44)
        Me._Label1_19.Name = "_Label1_19"
        Me._Label1_19.Size = New System.Drawing.Size(40, 18)
        Me._Label1_19.TabIndex = 70
        Me._Label1_19.Text = "Layer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdOpenWS)
        Me.GroupBox1.Controls.Add(Me.chkLocalEffects)
        Me.GroupBox1.Controls.Add(Me.txtOutputWS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 49)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSelectedPolys)
        Me.GroupBox2.Controls.Add(Me._Label1_19)
        Me.GroupBox2.Controls.Add(Me.btnSelect)
        Me.GroupBox2.Controls.Add(Me.cboTargetLayer)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 74)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Target Area"
        '
        'PollApply
        '
        Me.PollApply.HeaderText = "Apply"
        Me.PollApply.Name = "PollApply"
        Me.PollApply.Width = 53
        '
        'PollutantName
        '
        Me.PollutantName.HeaderText = "Pollutant Name"
        Me.PollutantName.Name = "PollutantName"
        Me.PollutantName.ReadOnly = True
        Me.PollutantName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PollutantName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PollutantName.Width = 180
        '
        'CoefSet
        '
        Me.CoefSet.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.CoefSet.DisplayStyleForCurrentCellOnly = True
        Me.CoefSet.HeaderText = "Coefficient Set"
        Me.CoefSet.Name = "CoefSet"
        Me.CoefSet.Width = 180
        '
        'WhichCoeff
        '
        Me.WhichCoeff.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.WhichCoeff.DisplayStyleForCurrentCellOnly = True
        Me.WhichCoeff.HeaderText = "Which Coefficient"
        Me.WhichCoeff.Items.AddRange(New Object() {"Type 1", "Type 2", "Type 3", "Type 4", "Use shapefile..."})
        Me.WhichCoeff.Name = "WhichCoeff"
        Me.WhichCoeff.Width = 120
        '
        'IndexShapefile
        '
        Me.IndexShapefile.HeaderText = "IndexShapefile"
        Me.IndexShapefile.Name = "IndexShapefile"
        Me.IndexShapefile.Visible = False
        '
        'IndexFieldName
        '
        Me.IndexFieldName.HeaderText = "IndexFieldName"
        Me.IndexFieldName.Name = "IndexFieldName"
        Me.IndexFieldName.Visible = False
        '
        'Threshold
        '
        Me.Threshold.HeaderText = "Threshold"
        Me.Threshold.Name = "Threshold"
        Me.Threshold.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Threshold.Visible = False
        '
        'TypeDef
        '
        Me.TypeDef.HeaderText = "TypeDef"
        Me.TypeDef.Name = "TypeDef"
        Me.TypeDef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.TypeDef.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdQuit
        Me.ClientSize = New System.Drawing.Size(644, 572)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabsForGrids)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.fraLC)
        Me.Controls.Add(Me._chkIgnoreLU_0)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me._chkIgnoreMgmt_0)
        Me.Controls.Add(Me.cmdQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(157, 105)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.fraLC.ResumeLayout(False)
        Me.TabsForGrids.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        CType(Me.dgvPollutants, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.frameRainFall.ResumeLayout(False)
        Me.frameRainFall.PerformLayout()
        Me.frmSDR.ResumeLayout(False)
        Me.frmSDR.PerformLayout()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        Me._SSTab1_TabPage2.PerformLayout()
        CType(Me.dgvLandUse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cnxtmnuLandUse.ResumeLayout(False)
        Me._SSTab1_TabPage3.ResumeLayout(False)
        Me._SSTab1_TabPage3.PerformLayout()
        CType(Me.dgvManagementScen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cnxtmnuManagement.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Frame3 As System.Windows.Forms.GroupBox
    Private WithEvents fraLC As System.Windows.Forms.GroupBox
    Private WithEvents TabsForGrids As System.Windows.Forms.TabControl
    Private WithEvents cmdRun As System.Windows.Forms.Button
    Private WithEvents cmdQuit As System.Windows.Forms.Button
    Private WithEvents _chkIgnoreMgmt_0 As System.Windows.Forms.CheckBox
    Private WithEvents _chkIgnoreLU_0 As System.Windows.Forms.CheckBox
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuSpace As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuSpace1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuGeneralHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuBigHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Private WithEvents _Label1_6 As System.Windows.Forms.Label
    Private WithEvents _Label1_3 As System.Windows.Forms.Label
    Private WithEvents _Label1_7 As System.Windows.Forms.Label
    Private WithEvents chkSelectedPolys As System.Windows.Forms.CheckBox
    Private WithEvents chkLocalEffects As System.Windows.Forms.CheckBox
    Private WithEvents cmdOpenWS As System.Windows.Forms.Button
    Private WithEvents txtOutputWS As System.Windows.Forms.TextBox
    Private WithEvents txtProjectName As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboSoilsLayer As System.Windows.Forms.ComboBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents cboLCLayer As System.Windows.Forms.ComboBox
    Private WithEvents cboLandCoverType As System.Windows.Forms.ComboBox
    Private WithEvents _Label1_0 As System.Windows.Forms.Label
    Private WithEvents _Label1_2 As System.Windows.Forms.Label
    Private WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Private WithEvents lblErodFactor As System.Windows.Forms.Label
    Private WithEvents lblKFactor As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents chkCalcErosion As System.Windows.Forms.CheckBox
    Private WithEvents txtRainValue As System.Windows.Forms.TextBox
    Private WithEvents optUseValue As System.Windows.Forms.RadioButton
    Private WithEvents optUseGRID As System.Windows.Forms.RadioButton
    Private WithEvents frameRainFall As System.Windows.Forms.GroupBox
    Private WithEvents cboErodFactor As System.Windows.Forms.ComboBox
    Private WithEvents cboSoilAttribute As System.Windows.Forms.ComboBox
    Private WithEvents cmdOpenSDR As System.Windows.Forms.Button
    Private WithEvents txtSDRGRID As System.Windows.Forms.TextBox
    Private WithEvents chkSDR As System.Windows.Forms.CheckBox
    Private WithEvents frmSDR As System.Windows.Forms.GroupBox
    Private WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents dgvPollutants As System.Windows.Forms.DataGridView
    Private WithEvents dgvLandUse As System.Windows.Forms.DataGridView
    Private WithEvents dgvManagementScen As System.Windows.Forms.DataGridView
    Private WithEvents cnxtmnuLandUse As System.Windows.Forms.ContextMenuStrip
    Private WithEvents AddScenarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents EditScenarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents DeleteScenarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cnxtmnuManagement As System.Windows.Forms.ContextMenuStrip
    Private WithEvents AppendRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents InsertRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents DeleteCurrentRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageApply As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ChangeAreaLayer As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ChangeToClass As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblManageNote As System.Windows.Forms.Label
    Friend WithEvents cboWaterShedDelineations As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrecipitationScenarios As System.Windows.Forms.ComboBox
    Private WithEvents btnOpenRainfallFactorGrid As System.Windows.Forms.Button
    Friend WithEvents LUApply As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LUScenario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LUScenarioXml As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents txtbxRainGrid As System.Windows.Forms.TextBox
    Private WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents cboTargetLayer As System.Windows.Forms.ComboBox
    Public WithEvents _Label1_19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboWaterQualityCriteriaStd As System.Windows.Forms.ComboBox
    Friend WithEvents PollApply As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PollutantName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoefSet As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents WhichCoeff As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IndexShapefile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndexFieldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Threshold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDef As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class