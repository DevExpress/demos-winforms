Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class ModifiedProperties
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim ScaleIndicatorState1 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState2 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState3 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState4 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState5 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState6 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState7 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState8 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState9 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim ScaleIndicatorState10 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.xtpGeneral = New DevExpress.XtraTab.XtraTabPage
            Me.lcModifiedProperties = New DevExpress.XtraLayout.LayoutControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.gcProgress = New DevExpress.XtraGauges.Win.GaugeControl
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
            Me.linearScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
            Me.linearScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.linearScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.linearScaleStateIndicatorComponent8 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.linearScaleStateIndicatorComponent10 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
            Me.sbNext = New DevExpress.XtraEditors.SimpleButton
            Me.sbReset = New DevExpress.XtraEditors.SimpleButton
            Me.teC2Phone = New DevExpress.XtraEditors.TextEdit
            Me.teC1Phone = New DevExpress.XtraEditors.TextEdit
            Me.teC2City = New DevExpress.XtraEditors.TextEdit
            Me.teC1City = New DevExpress.XtraEditors.TextEdit
            Me.pnlHint = New DevExpress.Utils.Frames.NotePanel8_1
            Me.teC2Country = New DevExpress.XtraEditors.TextEdit
            Me.teC1Country = New DevExpress.XtraEditors.TextEdit
            Me.teC2CompanyName = New DevExpress.XtraEditors.TextEdit
            Me.teC1CompanyName = New DevExpress.XtraEditors.TextEdit
            Me.teC2ContactName = New DevExpress.XtraEditors.TextEdit
            Me.teC1ContactName = New DevExpress.XtraEditors.TextEdit
            Me.teC2ContactTitle = New DevExpress.XtraEditors.TextEdit
            Me.teC1ContactTitle = New DevExpress.XtraEditors.TextEdit
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lcgCustomer1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciC1ContactTitle = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC1Phone = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC1City = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC1Country = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC1CompanyName = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC1ContactName = New DevExpress.XtraLayout.LayoutControlItem
            Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.lcgCustomer2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciC2ContactTitle = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC2ContactName = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC2CompanyName = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC2Country = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC2City = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciC2Phone = New DevExpress.XtraLayout.LayoutControlItem
            Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
            Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
            Me.xtpCustom = New DevExpress.XtraTab.XtraTabPage
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.buttonEdit12 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit11 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit10 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit9 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit8 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit7 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit6 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit5 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit4 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit3 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit2 = New DevExpress.XtraEditors.ButtonEdit
            Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
            Me.uow2CommitChangesButton = New DevExpress.XtraEditors.SimpleButton
            Me.reloadButton2 = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl12 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl11 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl10 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl9 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl8 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl7 = New DevExpress.XtraEditors.LabelControl
            Me.comboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.uow1CommitChangesButton = New DevExpress.XtraEditors.SimpleButton
            Me.reloadButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciComboBox1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator
            Me.lciLabel2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciLabel1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciLabel3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciLabel5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciLabel6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
            Me.simpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator
            Me.layoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
            Me.simpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem
            Me.simpleSeparator4 = New DevExpress.XtraLayout.SimpleSeparator
            Me.layoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit8 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit10 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit11 = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciButtonEdit12 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtpGeneral.SuspendLayout()
            CType(Me.lcModifiedProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcModifiedProperties.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC2Phone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC1Phone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC2City.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC1City.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC2Country.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC1Country.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC2CompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC1CompanyName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC2ContactName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC1ContactName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC2ContactTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teC1ContactTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgCustomer1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC1ContactTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC1Phone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC1City, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC1Country, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC1CompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC1ContactName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgCustomer2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC2ContactTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC2ContactName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC2CompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC2Country, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC2City, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciC2Phone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtpCustom.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.buttonEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciButtonEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtpGeneral
            Me.xtraTabControl1.Size = New System.Drawing.Size(915, 645)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGeneral, Me.xtpCustom})
            '
            'xtpGeneral
            '
            Me.xtpGeneral.Controls.Add(Me.lcModifiedProperties)
            Me.xtpGeneral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 64)
            Me.xtpGeneral.Name = "xtpGeneral"
            Me.xtpGeneral.Size = New System.Drawing.Size(884, 639)
            Me.xtpGeneral.Text = "General"
            '
            'lcModifiedProperties
            '
            Me.lcModifiedProperties.Controls.Add(Me.panelControl1)
            Me.lcModifiedProperties.Controls.Add(Me.teC2Phone)
            Me.lcModifiedProperties.Controls.Add(Me.teC1Phone)
            Me.lcModifiedProperties.Controls.Add(Me.teC2City)
            Me.lcModifiedProperties.Controls.Add(Me.teC1City)
            Me.lcModifiedProperties.Controls.Add(Me.pnlHint)
            Me.lcModifiedProperties.Controls.Add(Me.teC2Country)
            Me.lcModifiedProperties.Controls.Add(Me.teC1Country)
            Me.lcModifiedProperties.Controls.Add(Me.teC2CompanyName)
            Me.lcModifiedProperties.Controls.Add(Me.teC1CompanyName)
            Me.lcModifiedProperties.Controls.Add(Me.teC2ContactName)
            Me.lcModifiedProperties.Controls.Add(Me.teC1ContactName)
            Me.lcModifiedProperties.Controls.Add(Me.teC2ContactTitle)
            Me.lcModifiedProperties.Controls.Add(Me.teC1ContactTitle)
            Me.lcModifiedProperties.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcModifiedProperties.Location = New System.Drawing.Point(0, 0)
            Me.lcModifiedProperties.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.lcModifiedProperties.Name = "lcModifiedProperties"
            Me.lcModifiedProperties.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(582, 233, 1012, 404)
            Me.lcModifiedProperties.Root = Me.layoutControlGroup1
            Me.lcModifiedProperties.Size = New System.Drawing.Size(884, 639)
            Me.lcModifiedProperties.TabIndex = 4
            Me.lcModifiedProperties.Text = "layoutControl1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.gcProgress)
            Me.panelControl1.Controls.Add(Me.sbNext)
            Me.panelControl1.Controls.Add(Me.sbReset)
            Me.panelControl1.Location = New System.Drawing.Point(12, 12)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(860, 59)
            Me.panelControl1.TabIndex = 3
            '
            'gcProgress
            '
            Me.gcProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gcProgress.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gcProgress.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(5)
            Me.gcProgress.Location = New System.Drawing.Point(248, 9)
            Me.gcProgress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.gcProgress.Name = "gcProgress"
            Me.gcProgress.Size = New System.Drawing.Size(350, 42)
            Me.gcProgress.TabIndex = 8
            '
            'linearGauge1
            '
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(5, 5, 340, 32)
            Me.linearGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent() {Me.linearScaleStateIndicatorComponent2, Me.linearScaleStateIndicatorComponent4, Me.linearScaleStateIndicatorComponent6, Me.linearScaleStateIndicatorComponent8, Me.linearScaleStateIndicatorComponent10})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1})
            '
            'linearScaleStateIndicatorComponent2
            '
            Me.linearScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 202.7778!)
            Me.linearScaleStateIndicatorComponent2.IndicatorScale = Me.linearScaleComponent1
            Me.linearScaleStateIndicatorComponent2.Name = "Indicator1"
            Me.linearScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(21.22528!, 21.22528!)
            ScaleIndicatorState1.IntervalLength = 90.0!
            ScaleIndicatorState1.Name = "Colored"
            ScaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            ScaleIndicatorState1.StartValue = 10.0!
            ScaleIndicatorState2.IntervalLength = 10.0!
            ScaleIndicatorState2.Name = "Empty"
            ScaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState1, ScaleIndicatorState2})
            Me.linearScaleStateIndicatorComponent2.ZOrder = 99
            '
            'linearScaleComponent1
            '
            Me.linearScaleComponent1.AppearanceScale.Width = 5.0!
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScaleComponent1.AutoRescaling = True
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 300.0!)
            Me.linearScaleComponent1.MajorTickCount = 2
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -20.0!
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScaleComponent1.MajorTickmark.ShowText = False
            Me.linearScaleComponent1.MajorTickmark.ShowTick = False
            Me.linearScaleComponent1.MajorTickmark.TextOffset = -32.0!
            Me.linearScaleComponent1.MaxValue = 7.753408E+21!
            Me.linearScaleComponent1.MinorTickCount = 0
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14.0!
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScaleComponent1.MinorTickmark.ShowTick = False
            Me.linearScaleComponent1.MinValue = -4.79187E+21!
            Me.linearScaleComponent1.Name = "scale"
            Me.linearScaleComponent1.RescalingThresholdMax = 1.0!
            Me.linearScaleComponent1.RescalingThresholdMin = 1.0!
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 0.0!)
            Me.linearScaleComponent1.Value = 35.0!
            '
            'linearScaleStateIndicatorComponent4
            '
            Me.linearScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 158.3333!)
            Me.linearScaleStateIndicatorComponent4.IndicatorScale = Me.linearScaleComponent1
            Me.linearScaleStateIndicatorComponent4.Name = "Indicator3"
            Me.linearScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(21.22528!, 21.22528!)
            ScaleIndicatorState3.IntervalLength = 70.0!
            ScaleIndicatorState3.Name = "Colored"
            ScaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            ScaleIndicatorState3.StartValue = 30.0!
            ScaleIndicatorState4.IntervalLength = 30.0!
            ScaleIndicatorState4.Name = "Empty"
            ScaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState3, ScaleIndicatorState4})
            Me.linearScaleStateIndicatorComponent4.ZOrder = 97
            '
            'linearScaleStateIndicatorComponent6
            '
            Me.linearScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 113.8889!)
            Me.linearScaleStateIndicatorComponent6.IndicatorScale = Me.linearScaleComponent1
            Me.linearScaleStateIndicatorComponent6.Name = "Indicator5"
            Me.linearScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(21.22528!, 21.22528!)
            ScaleIndicatorState5.IntervalLength = 50.0!
            ScaleIndicatorState5.Name = "Colored"
            ScaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            ScaleIndicatorState5.StartValue = 50.0!
            ScaleIndicatorState6.IntervalLength = 50.0!
            ScaleIndicatorState6.Name = "Empty"
            ScaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState5, ScaleIndicatorState6})
            Me.linearScaleStateIndicatorComponent6.ZOrder = 95
            '
            'linearScaleStateIndicatorComponent8
            '
            Me.linearScaleStateIndicatorComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 69.44446!)
            Me.linearScaleStateIndicatorComponent8.IndicatorScale = Me.linearScaleComponent1
            Me.linearScaleStateIndicatorComponent8.Name = "Indicator7"
            Me.linearScaleStateIndicatorComponent8.Size = New System.Drawing.SizeF(21.22528!, 21.22528!)
            ScaleIndicatorState7.IntervalLength = 30.0!
            ScaleIndicatorState7.Name = "Colored"
            ScaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            ScaleIndicatorState7.StartValue = 70.0!
            ScaleIndicatorState8.IntervalLength = 70.0!
            ScaleIndicatorState8.Name = "Empty"
            ScaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent8.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState7, ScaleIndicatorState8})
            Me.linearScaleStateIndicatorComponent8.ZOrder = 93
            '
            'linearScaleStateIndicatorComponent10
            '
            Me.linearScaleStateIndicatorComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 25.0!)
            Me.linearScaleStateIndicatorComponent10.IndicatorScale = Me.linearScaleComponent1
            Me.linearScaleStateIndicatorComponent10.Name = "Indicator9"
            Me.linearScaleStateIndicatorComponent10.Size = New System.Drawing.SizeF(21.22528!, 21.22528!)
            ScaleIndicatorState9.IntervalLength = 10.0!
            ScaleIndicatorState9.Name = "Colored"
            ScaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem4
            ScaleIndicatorState9.StartValue = 90.0!
            ScaleIndicatorState10.IntervalLength = 90.0!
            ScaleIndicatorState10.Name = "Empty"
            ScaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem0
            Me.linearScaleStateIndicatorComponent10.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState9, ScaleIndicatorState10})
            Me.linearScaleStateIndicatorComponent10.ZOrder = 91
            '
            'sbNext
            '
            Me.sbNext.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.sbNext.Location = New System.Drawing.Point(702, 17)
            Me.sbNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbNext.Name = "sbNext"
            Me.sbNext.Size = New System.Drawing.Size(140, 26)
            Me.sbNext.TabIndex = 7
            Me.sbNext.Text = "Next"
            '
            'sbReset
            '
            Me.sbReset.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.sbReset.Location = New System.Drawing.Point(17, 17)
            Me.sbReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbReset.Name = "sbReset"
            Me.sbReset.Size = New System.Drawing.Size(140, 26)
            Me.sbReset.TabIndex = 6
            Me.sbReset.Text = "Reset"
            '
            'teC2Phone
            '
            Me.teC2Phone.Location = New System.Drawing.Point(514, 293)
            Me.teC2Phone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC2Phone.Name = "teC2Phone"
            Me.teC2Phone.Size = New System.Drawing.Size(346, 22)
            Me.teC2Phone.StyleController = Me.lcModifiedProperties
            Me.teC2Phone.TabIndex = 15
            '
            'teC1Phone
            '
            Me.teC1Phone.Location = New System.Drawing.Point(118, 293)
            Me.teC1Phone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC1Phone.Name = "teC1Phone"
            Me.teC1Phone.Size = New System.Drawing.Size(274, 22)
            Me.teC1Phone.StyleController = Me.lcModifiedProperties
            Me.teC1Phone.TabIndex = 9
            '
            'teC2City
            '
            Me.teC2City.Location = New System.Drawing.Point(514, 267)
            Me.teC2City.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC2City.Name = "teC2City"
            Me.teC2City.Size = New System.Drawing.Size(346, 22)
            Me.teC2City.StyleController = Me.lcModifiedProperties
            Me.teC2City.TabIndex = 14
            '
            'teC1City
            '
            Me.teC1City.Location = New System.Drawing.Point(118, 267)
            Me.teC1City.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC1City.Name = "teC1City"
            Me.teC1City.Size = New System.Drawing.Size(274, 22)
            Me.teC1City.StyleController = Me.lcModifiedProperties
            Me.teC1City.TabIndex = 8
            '
            'pnlHint
            '
            Me.pnlHint.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.pnlHint.Location = New System.Drawing.Point(12, 75)
            Me.pnlHint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.pnlHint.MaxRows = 25
            Me.pnlHint.Name = "pnlHint"
            Me.pnlHint.ParentAutoHeight = True
            Me.pnlHint.Size = New System.Drawing.Size(860, 50)
            Me.pnlHint.TabIndex = 5
            Me.pnlHint.TabStop = False
            '
            'teC2Country
            '
            Me.teC2Country.Location = New System.Drawing.Point(514, 241)
            Me.teC2Country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC2Country.Name = "teC2Country"
            Me.teC2Country.Size = New System.Drawing.Size(346, 22)
            Me.teC2Country.StyleController = Me.lcModifiedProperties
            Me.teC2Country.TabIndex = 13
            '
            'teC1Country
            '
            Me.teC1Country.Location = New System.Drawing.Point(118, 241)
            Me.teC1Country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC1Country.Name = "teC1Country"
            Me.teC1Country.Size = New System.Drawing.Size(274, 22)
            Me.teC1Country.StyleController = Me.lcModifiedProperties
            Me.teC1Country.TabIndex = 7
            '
            'teC2CompanyName
            '
            Me.teC2CompanyName.Location = New System.Drawing.Point(514, 215)
            Me.teC2CompanyName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC2CompanyName.Name = "teC2CompanyName"
            Me.teC2CompanyName.Size = New System.Drawing.Size(346, 22)
            Me.teC2CompanyName.StyleController = Me.lcModifiedProperties
            Me.teC2CompanyName.TabIndex = 12
            '
            'teC1CompanyName
            '
            Me.teC1CompanyName.Location = New System.Drawing.Point(118, 215)
            Me.teC1CompanyName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC1CompanyName.Name = "teC1CompanyName"
            Me.teC1CompanyName.Size = New System.Drawing.Size(274, 22)
            Me.teC1CompanyName.StyleController = Me.lcModifiedProperties
            Me.teC1CompanyName.TabIndex = 6
            '
            'teC2ContactName
            '
            Me.teC2ContactName.Location = New System.Drawing.Point(514, 189)
            Me.teC2ContactName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC2ContactName.Name = "teC2ContactName"
            Me.teC2ContactName.Size = New System.Drawing.Size(346, 22)
            Me.teC2ContactName.StyleController = Me.lcModifiedProperties
            Me.teC2ContactName.TabIndex = 11
            '
            'teC1ContactName
            '
            Me.teC1ContactName.Location = New System.Drawing.Point(118, 189)
            Me.teC1ContactName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC1ContactName.Name = "teC1ContactName"
            Me.teC1ContactName.Size = New System.Drawing.Size(274, 22)
            Me.teC1ContactName.StyleController = Me.lcModifiedProperties
            Me.teC1ContactName.TabIndex = 5
            '
            'teC2ContactTitle
            '
            Me.teC2ContactTitle.Location = New System.Drawing.Point(514, 163)
            Me.teC2ContactTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC2ContactTitle.Name = "teC2ContactTitle"
            Me.teC2ContactTitle.Size = New System.Drawing.Size(346, 22)
            Me.teC2ContactTitle.StyleController = Me.lcModifiedProperties
            Me.teC2ContactTitle.TabIndex = 10
            '
            'teC1ContactTitle
            '
            Me.teC1ContactTitle.Location = New System.Drawing.Point(118, 163)
            Me.teC1ContactTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.teC1ContactTitle.Name = "teC1ContactTitle"
            Me.teC1ContactTitle.Size = New System.Drawing.Size(274, 22)
            Me.teC1ContactTitle.StyleController = Me.lcModifiedProperties
            Me.teC1ContactTitle.TabIndex = 4
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgCustomer1, Me.lcgCustomer2, Me.layoutControlItem13, Me.LayoutControlItem16})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(884, 639)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'lcgCustomer1
            '
            Me.lcgCustomer1.CustomizationFormText = "lcgCustomer1"
            Me.lcgCustomer1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciC1ContactTitle, Me.lciC1Phone, Me.lciC1City, Me.lciC1Country, Me.lciC1CompanyName, Me.lciC1ContactName, Me.EmptySpaceItem5})
            Me.lcgCustomer1.Location = New System.Drawing.Point(0, 117)
            Me.lcgCustomer1.Name = "lcgCustomer1"
            Me.lcgCustomer1.Size = New System.Drawing.Size(396, 502)
            Me.lcgCustomer1.Text = "Customer (unit of work #1)"
            '
            'lciC1ContactTitle
            '
            Me.lciC1ContactTitle.Control = Me.teC1ContactTitle
            Me.lciC1ContactTitle.CustomizationFormText = "Contact Title"
            Me.lciC1ContactTitle.Location = New System.Drawing.Point(0, 0)
            Me.lciC1ContactTitle.Name = "lciC1ContactTitle"
            Me.lciC1ContactTitle.Size = New System.Drawing.Size(372, 26)
            Me.lciC1ContactTitle.Text = "Contact Title"
            Me.lciC1ContactTitle.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC1Phone
            '
            Me.lciC1Phone.Control = Me.teC1Phone
            Me.lciC1Phone.CustomizationFormText = "Phone"
            Me.lciC1Phone.Location = New System.Drawing.Point(0, 130)
            Me.lciC1Phone.Name = "lciC1Phone"
            Me.lciC1Phone.Size = New System.Drawing.Size(372, 26)
            Me.lciC1Phone.Text = "Phone"
            Me.lciC1Phone.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC1City
            '
            Me.lciC1City.Control = Me.teC1City
            Me.lciC1City.CustomizationFormText = "City"
            Me.lciC1City.Location = New System.Drawing.Point(0, 104)
            Me.lciC1City.Name = "lciC1City"
            Me.lciC1City.Size = New System.Drawing.Size(372, 26)
            Me.lciC1City.Text = "City"
            Me.lciC1City.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC1Country
            '
            Me.lciC1Country.Control = Me.teC1Country
            Me.lciC1Country.CustomizationFormText = "Country"
            Me.lciC1Country.Location = New System.Drawing.Point(0, 78)
            Me.lciC1Country.Name = "lciC1Country"
            Me.lciC1Country.Size = New System.Drawing.Size(372, 26)
            Me.lciC1Country.Text = "Country"
            Me.lciC1Country.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC1CompanyName
            '
            Me.lciC1CompanyName.Control = Me.teC1CompanyName
            Me.lciC1CompanyName.CustomizationFormText = "Company Name"
            Me.lciC1CompanyName.Location = New System.Drawing.Point(0, 52)
            Me.lciC1CompanyName.Name = "lciC1CompanyName"
            Me.lciC1CompanyName.Size = New System.Drawing.Size(372, 26)
            Me.lciC1CompanyName.Text = "Company Name"
            Me.lciC1CompanyName.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC1ContactName
            '
            Me.lciC1ContactName.Control = Me.teC1ContactName
            Me.lciC1ContactName.CustomizationFormText = "Contact Name"
            Me.lciC1ContactName.Location = New System.Drawing.Point(0, 26)
            Me.lciC1ContactName.Name = "lciC1ContactName"
            Me.lciC1ContactName.Size = New System.Drawing.Size(372, 26)
            Me.lciC1ContactName.Text = "Contact Name"
            Me.lciC1ContactName.TextSize = New System.Drawing.Size(90, 16)
            '
            'EmptySpaceItem5
            '
            Me.EmptySpaceItem5.AllowHotTrack = False
            Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
            Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 156)
            Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
            Me.EmptySpaceItem5.Size = New System.Drawing.Size(372, 300)
            Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
            Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            '
            'lcgCustomer2
            '
            Me.lcgCustomer2.CustomizationFormText = "layoutControlGroup2"
            Me.lcgCustomer2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciC2ContactTitle, Me.lciC2ContactName, Me.lciC2CompanyName, Me.lciC2Country, Me.lciC2City, Me.lciC2Phone, Me.EmptySpaceItem4})
            Me.lcgCustomer2.Location = New System.Drawing.Point(396, 117)
            Me.lcgCustomer2.Name = "lcgCustomer2"
            Me.lcgCustomer2.Size = New System.Drawing.Size(468, 502)
            Me.lcgCustomer2.Text = "Customer (unit of work #2)"
            '
            'lciC2ContactTitle
            '
            Me.lciC2ContactTitle.Control = Me.teC2ContactTitle
            Me.lciC2ContactTitle.CustomizationFormText = "layoutControlItem13"
            Me.lciC2ContactTitle.Location = New System.Drawing.Point(0, 0)
            Me.lciC2ContactTitle.Name = "lciC2ContactTitle"
            Me.lciC2ContactTitle.Size = New System.Drawing.Size(444, 26)
            Me.lciC2ContactTitle.Text = "Contact Title"
            Me.lciC2ContactTitle.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC2ContactName
            '
            Me.lciC2ContactName.Control = Me.teC2ContactName
            Me.lciC2ContactName.CustomizationFormText = "layoutControlItem14"
            Me.lciC2ContactName.Location = New System.Drawing.Point(0, 26)
            Me.lciC2ContactName.Name = "lciC2ContactName"
            Me.lciC2ContactName.Size = New System.Drawing.Size(444, 26)
            Me.lciC2ContactName.Text = "Contact Name"
            Me.lciC2ContactName.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC2CompanyName
            '
            Me.lciC2CompanyName.Control = Me.teC2CompanyName
            Me.lciC2CompanyName.CustomizationFormText = "layoutControlItem15"
            Me.lciC2CompanyName.Location = New System.Drawing.Point(0, 52)
            Me.lciC2CompanyName.Name = "lciC2CompanyName"
            Me.lciC2CompanyName.Size = New System.Drawing.Size(444, 26)
            Me.lciC2CompanyName.Text = "Company Name"
            Me.lciC2CompanyName.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC2Country
            '
            Me.lciC2Country.Control = Me.teC2Country
            Me.lciC2Country.CustomizationFormText = "layoutControlItem16"
            Me.lciC2Country.Location = New System.Drawing.Point(0, 78)
            Me.lciC2Country.Name = "lciC2Country"
            Me.lciC2Country.Size = New System.Drawing.Size(444, 26)
            Me.lciC2Country.Text = "Country"
            Me.lciC2Country.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC2City
            '
            Me.lciC2City.Control = Me.teC2City
            Me.lciC2City.CustomizationFormText = "layoutControlItem17"
            Me.lciC2City.Location = New System.Drawing.Point(0, 104)
            Me.lciC2City.Name = "lciC2City"
            Me.lciC2City.Size = New System.Drawing.Size(444, 26)
            Me.lciC2City.Text = "City"
            Me.lciC2City.TextSize = New System.Drawing.Size(90, 16)
            '
            'lciC2Phone
            '
            Me.lciC2Phone.Control = Me.teC2Phone
            Me.lciC2Phone.CustomizationFormText = "layoutControlItem18"
            Me.lciC2Phone.Location = New System.Drawing.Point(0, 130)
            Me.lciC2Phone.Name = "lciC2Phone"
            Me.lciC2Phone.Size = New System.Drawing.Size(444, 26)
            Me.lciC2Phone.Text = "Phone"
            Me.lciC2Phone.TextSize = New System.Drawing.Size(90, 16)
            '
            'EmptySpaceItem4
            '
            Me.EmptySpaceItem4.AllowHotTrack = False
            Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
            Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 156)
            Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
            Me.EmptySpaceItem4.Size = New System.Drawing.Size(444, 300)
            Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
            Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem13
            '
            Me.layoutControlItem13.Control = Me.pnlHint
            Me.layoutControlItem13.CustomizationFormText = "layoutControlItem13"
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 63)
            Me.layoutControlItem13.MaxSize = New System.Drawing.Size(0, 54)
            Me.layoutControlItem13.MinSize = New System.Drawing.Size(204, 54)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(864, 54)
            Me.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem13.Text = "layoutControlItem13"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem13.TextToControlDistance = 0
            Me.layoutControlItem13.TextVisible = False
            '
            'LayoutControlItem16
            '
            Me.LayoutControlItem16.Control = Me.panelControl1
            Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
            Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(0, 63)
            Me.LayoutControlItem16.MinSize = New System.Drawing.Size(226, 63)
            Me.LayoutControlItem16.Name = "LayoutControlItem16"
            Me.LayoutControlItem16.Size = New System.Drawing.Size(864, 63)
            Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem16.Text = "LayoutControlItem16"
            Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem16.TextToControlDistance = 0
            Me.LayoutControlItem16.TextVisible = False
            '
            'xtpCustom
            '
            Me.xtpCustom.Controls.Add(Me.layoutControl1)
            Me.xtpCustom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.xtpCustom.Name = "xtpCustom"
            Me.xtpCustom.Size = New System.Drawing.Size(884, 639)
            Me.xtpCustom.Text = "Custom"
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.buttonEdit12)
            Me.layoutControl1.Controls.Add(Me.buttonEdit11)
            Me.layoutControl1.Controls.Add(Me.buttonEdit10)
            Me.layoutControl1.Controls.Add(Me.buttonEdit9)
            Me.layoutControl1.Controls.Add(Me.buttonEdit8)
            Me.layoutControl1.Controls.Add(Me.buttonEdit7)
            Me.layoutControl1.Controls.Add(Me.buttonEdit6)
            Me.layoutControl1.Controls.Add(Me.buttonEdit5)
            Me.layoutControl1.Controls.Add(Me.buttonEdit4)
            Me.layoutControl1.Controls.Add(Me.buttonEdit3)
            Me.layoutControl1.Controls.Add(Me.buttonEdit2)
            Me.layoutControl1.Controls.Add(Me.buttonEdit1)
            Me.layoutControl1.Controls.Add(Me.labelControl4)
            Me.layoutControl1.Controls.Add(Me.uow2CommitChangesButton)
            Me.layoutControl1.Controls.Add(Me.reloadButton2)
            Me.layoutControl1.Controls.Add(Me.labelControl12)
            Me.layoutControl1.Controls.Add(Me.labelControl11)
            Me.layoutControl1.Controls.Add(Me.labelControl10)
            Me.layoutControl1.Controls.Add(Me.labelControl9)
            Me.layoutControl1.Controls.Add(Me.labelControl8)
            Me.layoutControl1.Controls.Add(Me.labelControl7)
            Me.layoutControl1.Controls.Add(Me.comboBoxEdit2)
            Me.layoutControl1.Controls.Add(Me.uow1CommitChangesButton)
            Me.layoutControl1.Controls.Add(Me.reloadButton1)
            Me.layoutControl1.Controls.Add(Me.labelControl6)
            Me.layoutControl1.Controls.Add(Me.labelControl5)
            Me.layoutControl1.Controls.Add(Me.labelControl3)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(924, 310, 672, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup2
            Me.layoutControl1.Size = New System.Drawing.Size(884, 639)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'buttonEdit12
            '
            Me.buttonEdit12.Location = New System.Drawing.Point(523, 314)
            Me.buttonEdit12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit12.Name = "buttonEdit12"
            Me.buttonEdit12.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit12.Size = New System.Drawing.Size(337, 22)
            Me.buttonEdit12.StyleController = Me.layoutControl1
            Me.buttonEdit12.TabIndex = 53
            '
            'buttonEdit11
            '
            Me.buttonEdit11.Location = New System.Drawing.Point(523, 268)
            Me.buttonEdit11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit11.Name = "buttonEdit11"
            Me.buttonEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit11.Size = New System.Drawing.Size(337, 22)
            Me.buttonEdit11.StyleController = Me.layoutControl1
            Me.buttonEdit11.TabIndex = 52
            '
            'buttonEdit10
            '
            Me.buttonEdit10.Location = New System.Drawing.Point(523, 222)
            Me.buttonEdit10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit10.Name = "buttonEdit10"
            Me.buttonEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit10.Size = New System.Drawing.Size(337, 22)
            Me.buttonEdit10.StyleController = Me.layoutControl1
            Me.buttonEdit10.TabIndex = 51
            '
            'buttonEdit9
            '
            Me.buttonEdit9.Location = New System.Drawing.Point(523, 176)
            Me.buttonEdit9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit9.Name = "buttonEdit9"
            Me.buttonEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit9.Size = New System.Drawing.Size(337, 22)
            Me.buttonEdit9.StyleController = Me.layoutControl1
            Me.buttonEdit9.TabIndex = 50
            '
            'buttonEdit8
            '
            Me.buttonEdit8.Location = New System.Drawing.Point(523, 130)
            Me.buttonEdit8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit8.Name = "buttonEdit8"
            Me.buttonEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit8.Size = New System.Drawing.Size(337, 22)
            Me.buttonEdit8.StyleController = Me.layoutControl1
            Me.buttonEdit8.TabIndex = 49
            '
            'buttonEdit7
            '
            Me.buttonEdit7.Location = New System.Drawing.Point(523, 84)
            Me.buttonEdit7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit7.Name = "buttonEdit7"
            Me.buttonEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit7.Size = New System.Drawing.Size(337, 22)
            Me.buttonEdit7.StyleController = Me.layoutControl1
            Me.buttonEdit7.TabIndex = 48
            '
            'buttonEdit6
            '
            Me.buttonEdit6.Location = New System.Drawing.Point(104, 314)
            Me.buttonEdit6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit6.Name = "buttonEdit6"
            Me.buttonEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit6.Size = New System.Drawing.Size(311, 22)
            Me.buttonEdit6.StyleController = Me.layoutControl1
            Me.buttonEdit6.TabIndex = 47
            '
            'buttonEdit5
            '
            Me.buttonEdit5.Location = New System.Drawing.Point(104, 268)
            Me.buttonEdit5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit5.Name = "buttonEdit5"
            Me.buttonEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject8, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit5.Size = New System.Drawing.Size(311, 22)
            Me.buttonEdit5.StyleController = Me.layoutControl1
            Me.buttonEdit5.TabIndex = 46
            '
            'buttonEdit4
            '
            Me.buttonEdit4.Location = New System.Drawing.Point(104, 222)
            Me.buttonEdit4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit4.Name = "buttonEdit4"
            Me.buttonEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit4.Size = New System.Drawing.Size(311, 22)
            Me.buttonEdit4.StyleController = Me.layoutControl1
            Me.buttonEdit4.TabIndex = 45
            '
            'buttonEdit3
            '
            Me.buttonEdit3.Location = New System.Drawing.Point(104, 176)
            Me.buttonEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject10, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit3.Size = New System.Drawing.Size(311, 22)
            Me.buttonEdit3.StyleController = Me.layoutControl1
            Me.buttonEdit3.TabIndex = 44
            '
            'buttonEdit2
            '
            Me.buttonEdit2.Location = New System.Drawing.Point(104, 130)
            Me.buttonEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject11, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit2.Size = New System.Drawing.Size(311, 22)
            Me.buttonEdit2.StyleController = Me.layoutControl1
            Me.buttonEdit2.TabIndex = 43
            '
            'buttonEdit1
            '
            Me.buttonEdit1.EditValue = ""
            Me.buttonEdit1.Location = New System.Drawing.Point(104, 84)
            Me.buttonEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject12, "Reset Modifications", Nothing, Nothing, True)})
            Me.buttonEdit1.Size = New System.Drawing.Size(311, 22)
            Me.buttonEdit1.StyleController = Me.layoutControl1
            Me.buttonEdit1.TabIndex = 42
            '
            'labelControl4
            '
            Me.labelControl4.Location = New System.Drawing.Point(24, 248)
            Me.labelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(391, 16)
            Me.labelControl4.StyleController = Me.layoutControl1
            Me.labelControl4.TabIndex = 41
            '
            'uow2CommitChangesButton
            '
            Me.uow2CommitChangesButton.Location = New System.Drawing.Point(652, 372)
            Me.uow2CommitChangesButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.uow2CommitChangesButton.Name = "uow2CommitChangesButton"
            Me.uow2CommitChangesButton.Size = New System.Drawing.Size(208, 23)
            Me.uow2CommitChangesButton.StyleController = Me.layoutControl1
            Me.uow2CommitChangesButton.TabIndex = 40
            Me.uow2CommitChangesButton.Text = "Commit Changes"
            '
            'reloadButton2
            '
            Me.reloadButton2.Location = New System.Drawing.Point(443, 372)
            Me.reloadButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.reloadButton2.Name = "reloadButton2"
            Me.reloadButton2.Size = New System.Drawing.Size(205, 23)
            Me.reloadButton2.StyleController = Me.layoutControl1
            Me.reloadButton2.TabIndex = 39
            Me.reloadButton2.Text = "Reload"
            '
            'labelControl12
            '
            Me.labelControl12.Location = New System.Drawing.Point(443, 340)
            Me.labelControl12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl12.Name = "labelControl12"
            Me.labelControl12.Size = New System.Drawing.Size(417, 16)
            Me.labelControl12.StyleController = Me.layoutControl1
            Me.labelControl12.TabIndex = 38
            '
            'labelControl11
            '
            Me.labelControl11.Location = New System.Drawing.Point(443, 294)
            Me.labelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl11.Name = "labelControl11"
            Me.labelControl11.Size = New System.Drawing.Size(417, 16)
            Me.labelControl11.StyleController = Me.layoutControl1
            Me.labelControl11.TabIndex = 36
            '
            'labelControl10
            '
            Me.labelControl10.Location = New System.Drawing.Point(443, 248)
            Me.labelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl10.Name = "labelControl10"
            Me.labelControl10.Size = New System.Drawing.Size(417, 16)
            Me.labelControl10.StyleController = Me.layoutControl1
            Me.labelControl10.TabIndex = 34
            '
            'labelControl9
            '
            Me.labelControl9.Location = New System.Drawing.Point(443, 202)
            Me.labelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl9.Name = "labelControl9"
            Me.labelControl9.Size = New System.Drawing.Size(417, 16)
            Me.labelControl9.StyleController = Me.layoutControl1
            Me.labelControl9.TabIndex = 32
            '
            'labelControl8
            '
            Me.labelControl8.Location = New System.Drawing.Point(443, 156)
            Me.labelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl8.Name = "labelControl8"
            Me.labelControl8.Size = New System.Drawing.Size(417, 16)
            Me.labelControl8.StyleController = Me.layoutControl1
            Me.labelControl8.TabIndex = 30
            '
            'labelControl7
            '
            Me.labelControl7.Location = New System.Drawing.Point(443, 110)
            Me.labelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl7.Name = "labelControl7"
            Me.labelControl7.Size = New System.Drawing.Size(417, 16)
            Me.labelControl7.StyleController = Me.layoutControl1
            Me.labelControl7.TabIndex = 28
            '
            'comboBoxEdit2
            '
            Me.comboBoxEdit2.Location = New System.Drawing.Point(628, 46)
            Me.comboBoxEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.comboBoxEdit2.Name = "comboBoxEdit2"
            Me.comboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit2.Size = New System.Drawing.Size(232, 22)
            Me.comboBoxEdit2.StyleController = Me.layoutControl1
            Me.comboBoxEdit2.TabIndex = 25
            '
            'uow1CommitChangesButton
            '
            Me.uow1CommitChangesButton.Location = New System.Drawing.Point(228, 372)
            Me.uow1CommitChangesButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.uow1CommitChangesButton.Name = "uow1CommitChangesButton"
            Me.uow1CommitChangesButton.Size = New System.Drawing.Size(187, 23)
            Me.uow1CommitChangesButton.StyleController = Me.layoutControl1
            Me.uow1CommitChangesButton.TabIndex = 24
            Me.uow1CommitChangesButton.Text = "Commit Changes"
            '
            'reloadButton1
            '
            Me.reloadButton1.Location = New System.Drawing.Point(24, 372)
            Me.reloadButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.reloadButton1.Name = "reloadButton1"
            Me.reloadButton1.Size = New System.Drawing.Size(200, 23)
            Me.reloadButton1.StyleController = Me.layoutControl1
            Me.reloadButton1.TabIndex = 23
            Me.reloadButton1.Text = "Reload"
            '
            'labelControl6
            '
            Me.labelControl6.Location = New System.Drawing.Point(24, 340)
            Me.labelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(391, 16)
            Me.labelControl6.StyleController = Me.layoutControl1
            Me.labelControl6.TabIndex = 22
            '
            'labelControl5
            '
            Me.labelControl5.Location = New System.Drawing.Point(24, 294)
            Me.labelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(391, 16)
            Me.labelControl5.StyleController = Me.layoutControl1
            Me.labelControl5.TabIndex = 21
            '
            'labelControl3
            '
            Me.labelControl3.Location = New System.Drawing.Point(24, 202)
            Me.labelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(391, 16)
            Me.labelControl3.StyleController = Me.layoutControl1
            Me.labelControl3.TabIndex = 19
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(24, 156)
            Me.labelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(391, 16)
            Me.labelControl2.StyleController = Me.layoutControl1
            Me.labelControl2.TabIndex = 9
            '
            'comboBoxEdit1
            '
            Me.comboBoxEdit1.Location = New System.Drawing.Point(209, 46)
            Me.comboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(206, 22)
            Me.comboBoxEdit1.StyleController = Me.layoutControl1
            Me.comboBoxEdit1.TabIndex = 6
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(24, 110)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(391, 16)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 5
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.CustomizationFormText = "Root"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "Root"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(884, 639)
            Me.layoutControlGroup2.Text = "Root"
            Me.layoutControlGroup2.TextVisible = False
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciComboBox1, Me.emptySpaceItem2, Me.simpleSeparator1, Me.lciLabel2, Me.lciLabel1, Me.lciLabel3, Me.lciLabel5, Me.lciLabel6, Me.layoutControlItem14, Me.layoutControlItem15, Me.simpleSeparator2, Me.layoutControlItem32, Me.lciButtonEdit1, Me.lciButtonEdit2, Me.lciButtonEdit3, Me.lciButtonEdit4, Me.lciButtonEdit5, Me.lciButtonEdit6})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(419, 619)
            Me.layoutControlGroup3.Text = "Person (unit of work #1)"
            '
            'lciComboBox1
            '
            Me.lciComboBox1.Control = Me.comboBoxEdit1
            Me.lciComboBox1.CustomizationFormText = "lciComboBox1"
            Me.lciComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.lciComboBox1.Name = "lciComboBox1"
            Me.lciComboBox1.Size = New System.Drawing.Size(395, 26)
            Me.lciComboBox1.Text = "OptimisticLockingReadBehavior:"
            Me.lciComboBox1.TextSize = New System.Drawing.Size(181, 16)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 353)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(395, 220)
            Me.emptySpaceItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'simpleSeparator1
            '
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 26)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(395, 12)
            Me.simpleSeparator1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.simpleSeparator1.Text = "simpleSeparator1"
            '
            'lciLabel2
            '
            Me.lciLabel2.Control = Me.labelControl2
            Me.lciLabel2.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.lciLabel2.CustomizationFormText = "lciLabel2"
            Me.lciLabel2.Location = New System.Drawing.Point(0, 110)
            Me.lciLabel2.Name = "lciLabel2"
            Me.lciLabel2.Size = New System.Drawing.Size(395, 20)
            Me.lciLabel2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciLabel2.Text = "lciLabel2"
            Me.lciLabel2.TextSize = New System.Drawing.Size(0, 0)
            Me.lciLabel2.TextToControlDistance = 0
            Me.lciLabel2.TextVisible = False
            '
            'lciLabel1
            '
            Me.lciLabel1.Control = Me.labelControl1
            Me.lciLabel1.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.lciLabel1.CustomizationFormText = "lciLabel1"
            Me.lciLabel1.Location = New System.Drawing.Point(0, 64)
            Me.lciLabel1.Name = "lciLabel1"
            Me.lciLabel1.Size = New System.Drawing.Size(395, 20)
            Me.lciLabel1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciLabel1.Text = "lciLabel1"
            Me.lciLabel1.TextSize = New System.Drawing.Size(0, 0)
            Me.lciLabel1.TextToControlDistance = 0
            Me.lciLabel1.TextVisible = False
            '
            'lciLabel3
            '
            Me.lciLabel3.Control = Me.labelControl3
            Me.lciLabel3.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.lciLabel3.CustomizationFormText = "lciLabel3"
            Me.lciLabel3.Location = New System.Drawing.Point(0, 156)
            Me.lciLabel3.Name = "lciLabel3"
            Me.lciLabel3.Size = New System.Drawing.Size(395, 20)
            Me.lciLabel3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciLabel3.Text = "lciLabel3"
            Me.lciLabel3.TextSize = New System.Drawing.Size(0, 0)
            Me.lciLabel3.TextToControlDistance = 0
            Me.lciLabel3.TextVisible = False
            '
            'lciLabel5
            '
            Me.lciLabel5.Control = Me.labelControl5
            Me.lciLabel5.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.lciLabel5.CustomizationFormText = "lciLabel5"
            Me.lciLabel5.Location = New System.Drawing.Point(0, 248)
            Me.lciLabel5.Name = "lciLabel5"
            Me.lciLabel5.Size = New System.Drawing.Size(395, 20)
            Me.lciLabel5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciLabel5.Text = "lciLabel5"
            Me.lciLabel5.TextSize = New System.Drawing.Size(0, 0)
            Me.lciLabel5.TextToControlDistance = 0
            Me.lciLabel5.TextVisible = False
            '
            'lciLabel6
            '
            Me.lciLabel6.Control = Me.labelControl6
            Me.lciLabel6.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.lciLabel6.CustomizationFormText = "lciLabel6"
            Me.lciLabel6.Location = New System.Drawing.Point(0, 294)
            Me.lciLabel6.Name = "lciLabel6"
            Me.lciLabel6.Size = New System.Drawing.Size(395, 20)
            Me.lciLabel6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciLabel6.Text = "lciLabel6"
            Me.lciLabel6.TextSize = New System.Drawing.Size(0, 0)
            Me.lciLabel6.TextToControlDistance = 0
            Me.lciLabel6.TextVisible = False
            '
            'layoutControlItem14
            '
            Me.layoutControlItem14.Control = Me.reloadButton1
            Me.layoutControlItem14.CustomizationFormText = "layoutControlItem14"
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 326)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(204, 27)
            Me.layoutControlItem14.Text = "layoutControlItem14"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem14.TextToControlDistance = 0
            Me.layoutControlItem14.TextVisible = False
            '
            'layoutControlItem15
            '
            Me.layoutControlItem15.Control = Me.uow1CommitChangesButton
            Me.layoutControlItem15.CustomizationFormText = "layoutControlItem15"
            Me.layoutControlItem15.Location = New System.Drawing.Point(204, 326)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(191, 27)
            Me.layoutControlItem15.Text = "layoutControlItem15"
            Me.layoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem15.TextToControlDistance = 0
            Me.layoutControlItem15.TextVisible = False
            '
            'simpleSeparator2
            '
            Me.simpleSeparator2.AllowHotTrack = False
            Me.simpleSeparator2.CustomizationFormText = "simpleSeparator2"
            Me.simpleSeparator2.Location = New System.Drawing.Point(0, 314)
            Me.simpleSeparator2.Name = "simpleSeparator2"
            Me.simpleSeparator2.Size = New System.Drawing.Size(395, 12)
            Me.simpleSeparator2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.simpleSeparator2.Text = "simpleSeparator2"
            '
            'layoutControlItem32
            '
            Me.layoutControlItem32.Control = Me.labelControl4
            Me.layoutControlItem32.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem32.CustomizationFormText = "layoutControlItem32"
            Me.layoutControlItem32.Location = New System.Drawing.Point(0, 202)
            Me.layoutControlItem32.Name = "layoutControlItem32"
            Me.layoutControlItem32.Size = New System.Drawing.Size(395, 20)
            Me.layoutControlItem32.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem32.Text = "layoutControlItem32"
            Me.layoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem32.TextToControlDistance = 0
            Me.layoutControlItem32.TextVisible = False
            '
            'lciButtonEdit1
            '
            Me.lciButtonEdit1.Control = Me.buttonEdit1
            Me.lciButtonEdit1.CustomizationFormText = "layoutControlItem19"
            Me.lciButtonEdit1.Location = New System.Drawing.Point(0, 38)
            Me.lciButtonEdit1.Name = "lciButtonEdit1"
            Me.lciButtonEdit1.Size = New System.Drawing.Size(395, 26)
            Me.lciButtonEdit1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit1.Text = "Contact Title"
            Me.lciButtonEdit1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit1.TextSize = New System.Drawing.Size(75, 13)
            Me.lciButtonEdit1.TextToControlDistance = 5
            '
            'lciButtonEdit2
            '
            Me.lciButtonEdit2.Control = Me.buttonEdit2
            Me.lciButtonEdit2.CustomizationFormText = "Contact Name"
            Me.lciButtonEdit2.Location = New System.Drawing.Point(0, 84)
            Me.lciButtonEdit2.Name = "lciButtonEdit2"
            Me.lciButtonEdit2.Size = New System.Drawing.Size(395, 26)
            Me.lciButtonEdit2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit2.Text = "Contact Name"
            Me.lciButtonEdit2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit2.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit2.TextToControlDistance = 5
            '
            'lciButtonEdit3
            '
            Me.lciButtonEdit3.Control = Me.buttonEdit3
            Me.lciButtonEdit3.CustomizationFormText = "Company Name"
            Me.lciButtonEdit3.Location = New System.Drawing.Point(0, 130)
            Me.lciButtonEdit3.Name = "lciButtonEdit3"
            Me.lciButtonEdit3.Size = New System.Drawing.Size(395, 26)
            Me.lciButtonEdit3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit3.Text = "Company Name"
            Me.lciButtonEdit3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit3.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit3.TextToControlDistance = 5
            '
            'lciButtonEdit4
            '
            Me.lciButtonEdit4.Control = Me.buttonEdit4
            Me.lciButtonEdit4.CustomizationFormText = "Country"
            Me.lciButtonEdit4.Location = New System.Drawing.Point(0, 176)
            Me.lciButtonEdit4.Name = "lciButtonEdit4"
            Me.lciButtonEdit4.Size = New System.Drawing.Size(395, 26)
            Me.lciButtonEdit4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit4.Text = "Country"
            Me.lciButtonEdit4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit4.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit4.TextToControlDistance = 5
            '
            'lciButtonEdit5
            '
            Me.lciButtonEdit5.Control = Me.buttonEdit5
            Me.lciButtonEdit5.CustomizationFormText = "City"
            Me.lciButtonEdit5.Location = New System.Drawing.Point(0, 222)
            Me.lciButtonEdit5.Name = "lciButtonEdit5"
            Me.lciButtonEdit5.Size = New System.Drawing.Size(395, 26)
            Me.lciButtonEdit5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit5.Text = "City"
            Me.lciButtonEdit5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit5.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit5.TextToControlDistance = 5
            '
            'lciButtonEdit6
            '
            Me.lciButtonEdit6.Control = Me.buttonEdit6
            Me.lciButtonEdit6.CustomizationFormText = "Phone"
            Me.lciButtonEdit6.Location = New System.Drawing.Point(0, 268)
            Me.lciButtonEdit6.Name = "lciButtonEdit6"
            Me.lciButtonEdit6.Size = New System.Drawing.Size(395, 26)
            Me.lciButtonEdit6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit6.Text = "Phone"
            Me.lciButtonEdit6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit6.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit6.TextToControlDistance = 5
            '
            'layoutControlGroup4
            '
            Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem18, Me.simpleSeparator3, Me.layoutControlItem17, Me.layoutControlItem21, Me.layoutControlItem23, Me.layoutControlItem25, Me.layoutControlItem27, Me.layoutControlItem29, Me.simpleSeparator4, Me.layoutControlItem30, Me.emptySpaceItem1, Me.layoutControlItem31, Me.lciButtonEdit7, Me.lciButtonEdit8, Me.lciButtonEdit9, Me.lciButtonEdit10, Me.lciButtonEdit11, Me.lciButtonEdit12})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(419, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(445, 619)
            Me.layoutControlGroup4.Text = "Person (unit of work #2)"
            '
            'layoutControlItem18
            '
            Me.layoutControlItem18.Control = Me.comboBoxEdit2
            Me.layoutControlItem18.CustomizationFormText = "lciComboBox2"
            Me.layoutControlItem18.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Size = New System.Drawing.Size(421, 26)
            Me.layoutControlItem18.Text = "OptimisticLockingReadBehavior:"
            Me.layoutControlItem18.TextSize = New System.Drawing.Size(181, 16)
            '
            'simpleSeparator3
            '
            Me.simpleSeparator3.AllowHotTrack = False
            Me.simpleSeparator3.CustomizationFormText = "simpleSeparator3"
            Me.simpleSeparator3.Location = New System.Drawing.Point(0, 26)
            Me.simpleSeparator3.Name = "simpleSeparator3"
            Me.simpleSeparator3.Size = New System.Drawing.Size(421, 12)
            Me.simpleSeparator3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.simpleSeparator3.Text = "simpleSeparator3"
            '
            'layoutControlItem17
            '
            Me.layoutControlItem17.Control = Me.labelControl7
            Me.layoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem17.CustomizationFormText = "layoutControlItem17"
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(421, 20)
            Me.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem17.Text = "layoutControlItem17"
            Me.layoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem17.TextToControlDistance = 0
            Me.layoutControlItem17.TextVisible = False
            '
            'layoutControlItem21
            '
            Me.layoutControlItem21.Control = Me.labelControl8
            Me.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem21.CustomizationFormText = "layoutControlItem21"
            Me.layoutControlItem21.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlItem21.Name = "layoutControlItem21"
            Me.layoutControlItem21.Size = New System.Drawing.Size(421, 20)
            Me.layoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem21.Text = "layoutControlItem21"
            Me.layoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem21.TextToControlDistance = 0
            Me.layoutControlItem21.TextVisible = False
            '
            'layoutControlItem23
            '
            Me.layoutControlItem23.Control = Me.labelControl9
            Me.layoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem23.CustomizationFormText = "layoutControlItem23"
            Me.layoutControlItem23.Location = New System.Drawing.Point(0, 156)
            Me.layoutControlItem23.Name = "layoutControlItem23"
            Me.layoutControlItem23.Size = New System.Drawing.Size(421, 20)
            Me.layoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem23.Text = "layoutControlItem23"
            Me.layoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem23.TextToControlDistance = 0
            Me.layoutControlItem23.TextVisible = False
            '
            'layoutControlItem25
            '
            Me.layoutControlItem25.Control = Me.labelControl10
            Me.layoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem25.CustomizationFormText = "layoutControlItem25"
            Me.layoutControlItem25.Location = New System.Drawing.Point(0, 202)
            Me.layoutControlItem25.Name = "layoutControlItem25"
            Me.layoutControlItem25.Size = New System.Drawing.Size(421, 20)
            Me.layoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem25.Text = "layoutControlItem25"
            Me.layoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem25.TextToControlDistance = 0
            Me.layoutControlItem25.TextVisible = False
            '
            'layoutControlItem27
            '
            Me.layoutControlItem27.Control = Me.labelControl11
            Me.layoutControlItem27.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem27.CustomizationFormText = "layoutControlItem27"
            Me.layoutControlItem27.Location = New System.Drawing.Point(0, 248)
            Me.layoutControlItem27.Name = "layoutControlItem27"
            Me.layoutControlItem27.Size = New System.Drawing.Size(421, 20)
            Me.layoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem27.Text = "layoutControlItem27"
            Me.layoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem27.TextToControlDistance = 0
            Me.layoutControlItem27.TextVisible = False
            '
            'layoutControlItem29
            '
            Me.layoutControlItem29.Control = Me.labelControl12
            Me.layoutControlItem29.ControlAlignment = System.Drawing.ContentAlignment.TopRight
            Me.layoutControlItem29.CustomizationFormText = "layoutControlItem29"
            Me.layoutControlItem29.Location = New System.Drawing.Point(0, 294)
            Me.layoutControlItem29.Name = "layoutControlItem29"
            Me.layoutControlItem29.Size = New System.Drawing.Size(421, 20)
            Me.layoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem29.Text = "layoutControlItem29"
            Me.layoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem29.TextToControlDistance = 0
            Me.layoutControlItem29.TextVisible = False
            '
            'simpleSeparator4
            '
            Me.simpleSeparator4.AllowHotTrack = False
            Me.simpleSeparator4.CustomizationFormText = "simpleSeparator4"
            Me.simpleSeparator4.Location = New System.Drawing.Point(0, 314)
            Me.simpleSeparator4.Name = "simpleSeparator4"
            Me.simpleSeparator4.Size = New System.Drawing.Size(421, 12)
            Me.simpleSeparator4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.simpleSeparator4.Text = "simpleSeparator4"
            '
            'layoutControlItem30
            '
            Me.layoutControlItem30.Control = Me.reloadButton2
            Me.layoutControlItem30.CustomizationFormText = "layoutControlItem30"
            Me.layoutControlItem30.Location = New System.Drawing.Point(0, 326)
            Me.layoutControlItem30.Name = "layoutControlItem30"
            Me.layoutControlItem30.Size = New System.Drawing.Size(209, 27)
            Me.layoutControlItem30.Text = "layoutControlItem30"
            Me.layoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem30.TextToControlDistance = 0
            Me.layoutControlItem30.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 353)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(421, 220)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem31
            '
            Me.layoutControlItem31.Control = Me.uow2CommitChangesButton
            Me.layoutControlItem31.CustomizationFormText = "layoutControlItem31"
            Me.layoutControlItem31.Location = New System.Drawing.Point(209, 326)
            Me.layoutControlItem31.Name = "layoutControlItem31"
            Me.layoutControlItem31.Size = New System.Drawing.Size(212, 27)
            Me.layoutControlItem31.Text = "layoutControlItem31"
            Me.layoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem31.TextToControlDistance = 0
            Me.layoutControlItem31.TextVisible = False
            '
            'lciButtonEdit7
            '
            Me.lciButtonEdit7.Control = Me.buttonEdit7
            Me.lciButtonEdit7.CustomizationFormText = "Contact Title"
            Me.lciButtonEdit7.Location = New System.Drawing.Point(0, 38)
            Me.lciButtonEdit7.Name = "lciButtonEdit7"
            Me.lciButtonEdit7.Size = New System.Drawing.Size(421, 26)
            Me.lciButtonEdit7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit7.Text = "Contact Title"
            Me.lciButtonEdit7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit7.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit7.TextToControlDistance = 5
            '
            'lciButtonEdit8
            '
            Me.lciButtonEdit8.Control = Me.buttonEdit8
            Me.lciButtonEdit8.CustomizationFormText = "Conact Name"
            Me.lciButtonEdit8.Location = New System.Drawing.Point(0, 84)
            Me.lciButtonEdit8.Name = "lciButtonEdit8"
            Me.lciButtonEdit8.Size = New System.Drawing.Size(421, 26)
            Me.lciButtonEdit8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit8.Text = "Conact Name"
            Me.lciButtonEdit8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit8.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit8.TextToControlDistance = 5
            '
            'lciButtonEdit9
            '
            Me.lciButtonEdit9.Control = Me.buttonEdit9
            Me.lciButtonEdit9.CustomizationFormText = "Company Name"
            Me.lciButtonEdit9.Location = New System.Drawing.Point(0, 130)
            Me.lciButtonEdit9.Name = "lciButtonEdit9"
            Me.lciButtonEdit9.Size = New System.Drawing.Size(421, 26)
            Me.lciButtonEdit9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit9.Text = "Company Name"
            Me.lciButtonEdit9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit9.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit9.TextToControlDistance = 5
            '
            'lciButtonEdit10
            '
            Me.lciButtonEdit10.Control = Me.buttonEdit10
            Me.lciButtonEdit10.CustomizationFormText = "Country"
            Me.lciButtonEdit10.Location = New System.Drawing.Point(0, 176)
            Me.lciButtonEdit10.Name = "lciButtonEdit10"
            Me.lciButtonEdit10.Size = New System.Drawing.Size(421, 26)
            Me.lciButtonEdit10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit10.Text = "Country"
            Me.lciButtonEdit10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit10.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit10.TextToControlDistance = 5
            '
            'lciButtonEdit11
            '
            Me.lciButtonEdit11.Control = Me.buttonEdit11
            Me.lciButtonEdit11.CustomizationFormText = "City"
            Me.lciButtonEdit11.Location = New System.Drawing.Point(0, 222)
            Me.lciButtonEdit11.Name = "lciButtonEdit11"
            Me.lciButtonEdit11.Size = New System.Drawing.Size(421, 26)
            Me.lciButtonEdit11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit11.Text = "City"
            Me.lciButtonEdit11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit11.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit11.TextToControlDistance = 5
            '
            'lciButtonEdit12
            '
            Me.lciButtonEdit12.Control = Me.buttonEdit12
            Me.lciButtonEdit12.CustomizationFormText = "Phone"
            Me.lciButtonEdit12.Location = New System.Drawing.Point(0, 268)
            Me.lciButtonEdit12.Name = "lciButtonEdit12"
            Me.lciButtonEdit12.Size = New System.Drawing.Size(421, 26)
            Me.lciButtonEdit12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.lciButtonEdit12.Text = "Phone"
            Me.lciButtonEdit12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciButtonEdit12.TextSize = New System.Drawing.Size(75, 20)
            Me.lciButtonEdit12.TextToControlDistance = 5
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.teC1ContactTitle
            Me.layoutControlItem1.CustomizationFormText = "Contact Title"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "lciC1ContactTitle"
            Me.layoutControlItem1.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem1.Text = "Contact Title"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(108, 16)
            Me.layoutControlItem1.TextToControlDistance = 5
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.teC1Phone
            Me.layoutControlItem2.CustomizationFormText = "Phone"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 130)
            Me.layoutControlItem2.Name = "lciC1Phone"
            Me.layoutControlItem2.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem2.Text = "Phone"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(108, 16)
            Me.layoutControlItem2.TextToControlDistance = 5
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.teC1City
            Me.layoutControlItem3.CustomizationFormText = "City"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 104)
            Me.layoutControlItem3.Name = "lciC1City"
            Me.layoutControlItem3.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem3.Text = "City"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(108, 16)
            Me.layoutControlItem3.TextToControlDistance = 5
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.teC1Country
            Me.layoutControlItem4.CustomizationFormText = "Country"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 78)
            Me.layoutControlItem4.Name = "lciC1Country"
            Me.layoutControlItem4.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem4.Text = "Country"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(108, 16)
            Me.layoutControlItem4.TextToControlDistance = 5
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.teC1CompanyName
            Me.layoutControlItem5.CustomizationFormText = "Company Name"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 52)
            Me.layoutControlItem5.Name = "lciC1CompanyName"
            Me.layoutControlItem5.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem5.Text = "Company Name"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(108, 16)
            Me.layoutControlItem5.TextToControlDistance = 5
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.teC1ContactName
            Me.layoutControlItem6.CustomizationFormText = "Contact Name"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem6.Name = "lciC1ContactName"
            Me.layoutControlItem6.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem6.Text = "Contact Name"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(108, 16)
            Me.layoutControlItem6.TextToControlDistance = 5
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.teC1ContactTitle
            Me.layoutControlItem7.CustomizationFormText = "Contact Title"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "lciC1ContactTitle"
            Me.layoutControlItem7.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem7.Text = "Contact Title"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(90, 16)
            Me.layoutControlItem7.TextToControlDistance = 5
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.teC1ContactName
            Me.layoutControlItem8.CustomizationFormText = "Contact Name"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem8.Name = "lciC1ContactName"
            Me.layoutControlItem8.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem8.Text = "Contact Name"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(90, 16)
            Me.layoutControlItem8.TextToControlDistance = 5
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.teC1CompanyName
            Me.layoutControlItem9.CustomizationFormText = "Company Name"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 52)
            Me.layoutControlItem9.Name = "lciC1CompanyName"
            Me.layoutControlItem9.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem9.Text = "Company Name"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(90, 16)
            Me.layoutControlItem9.TextToControlDistance = 5
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.Control = Me.teC1Country
            Me.layoutControlItem10.CustomizationFormText = "Country"
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 78)
            Me.layoutControlItem10.Name = "lciC1Country"
            Me.layoutControlItem10.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem10.Text = "Country"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(90, 16)
            Me.layoutControlItem10.TextToControlDistance = 5
            '
            'layoutControlItem11
            '
            Me.layoutControlItem11.Control = Me.teC1City
            Me.layoutControlItem11.CustomizationFormText = "City"
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 104)
            Me.layoutControlItem11.Name = "lciC1City"
            Me.layoutControlItem11.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem11.Text = "City"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(90, 16)
            Me.layoutControlItem11.TextToControlDistance = 5
            '
            'layoutControlItem12
            '
            Me.layoutControlItem12.Control = Me.teC1Phone
            Me.layoutControlItem12.CustomizationFormText = "Phone"
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 130)
            Me.layoutControlItem12.Name = "lciC1Phone"
            Me.layoutControlItem12.Size = New System.Drawing.Size(871, 26)
            Me.layoutControlItem12.Text = "Phone"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(90, 16)
            Me.layoutControlItem12.TextToControlDistance = 5
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 272)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(249, 163)
            Me.emptySpaceItem3.Text = "emptySpaceItem3"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'timer1
            '
            '
            'ModifiedProperties
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "ModifiedProperties"
            Me.Size = New System.Drawing.Size(915, 645)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtpGeneral.ResumeLayout(False)
            CType(Me.lcModifiedProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcModifiedProperties.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleStateIndicatorComponent10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC2Phone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC1Phone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC2City.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC1City.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC2Country.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC1Country.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC2CompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC1CompanyName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC2ContactName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC1ContactName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC2ContactTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teC1ContactTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgCustomer1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC1ContactTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC1Phone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC1City, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC1Country, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC1CompanyName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC1ContactName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgCustomer2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC2ContactTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC2ContactName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC2CompanyName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC2Country, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC2City, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciC2Phone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtpCustom.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.buttonEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciButtonEdit12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbReset As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbNext As DevExpress.XtraEditors.SimpleButton
        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private linearScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private linearScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private linearScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private linearScaleStateIndicatorComponent8 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private linearScaleStateIndicatorComponent10 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleStateIndicatorComponent
        Private gcProgress As DevExpress.XtraGauges.Win.GaugeControl
        Private lcModifiedProperties As DevExpress.XtraLayout.LayoutControl
        Private teC1CompanyName As DevExpress.XtraEditors.TextEdit
        Private teC1ContactName As DevExpress.XtraEditors.TextEdit
        Private teC1ContactTitle As DevExpress.XtraEditors.TextEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private teC1Phone As DevExpress.XtraEditors.TextEdit
        Private teC1City As DevExpress.XtraEditors.TextEdit
        Private teC1Country As DevExpress.XtraEditors.TextEdit
        Private lcgCustomer1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciC1ContactTitle As DevExpress.XtraLayout.LayoutControlItem
        Private lciC1Phone As DevExpress.XtraLayout.LayoutControlItem
        Private lciC1City As DevExpress.XtraLayout.LayoutControlItem
        Private lciC1Country As DevExpress.XtraLayout.LayoutControlItem
        Private lciC1CompanyName As DevExpress.XtraLayout.LayoutControlItem
        Private lciC1ContactName As DevExpress.XtraLayout.LayoutControlItem
        Private lcgCustomer2 As DevExpress.XtraLayout.LayoutControlGroup
        Private teC2Phone As DevExpress.XtraEditors.TextEdit
        Private teC2City As DevExpress.XtraEditors.TextEdit
        Private teC2Country As DevExpress.XtraEditors.TextEdit
        Private teC2CompanyName As DevExpress.XtraEditors.TextEdit
        Private teC2ContactName As DevExpress.XtraEditors.TextEdit
        Private teC2ContactTitle As DevExpress.XtraEditors.TextEdit
        Private lciC2ContactTitle As DevExpress.XtraLayout.LayoutControlItem
        Private lciC2ContactName As DevExpress.XtraLayout.LayoutControlItem
        Private lciC2CompanyName As DevExpress.XtraLayout.LayoutControlItem
        Private lciC2Country As DevExpress.XtraLayout.LayoutControlItem
        Private lciC2City As DevExpress.XtraLayout.LayoutControlItem
        Private lciC2Phone As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Private pnlHint As DevExpress.Utils.Frames.NotePanel8_1
        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtpCustom As DevExpress.XtraTab.XtraTabPage
        Private xtpGeneral As DevExpress.XtraTab.XtraTabPage
        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciLabel1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private lciComboBox1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
        Private lciLabel2 As DevExpress.XtraLayout.LayoutControlItem
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
        Private lciLabel3 As DevExpress.XtraLayout.LayoutControlItem
        Private labelControl6 As DevExpress.XtraEditors.LabelControl
        Private labelControl5 As DevExpress.XtraEditors.LabelControl
        Private lciLabel5 As DevExpress.XtraLayout.LayoutControlItem
        Private lciLabel6 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents comboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents uow1CommitChangesButton As DevExpress.XtraEditors.SimpleButton
        Private WithEvents reloadButton1 As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
        Private simpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
        Private simpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
        Private labelControl8 As DevExpress.XtraEditors.LabelControl
        Private labelControl7 As DevExpress.XtraEditors.LabelControl
        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents reloadButton2 As DevExpress.XtraEditors.SimpleButton
        Private labelControl12 As DevExpress.XtraEditors.LabelControl
        Private labelControl11 As DevExpress.XtraEditors.LabelControl
        Private labelControl10 As DevExpress.XtraEditors.LabelControl
        Private labelControl9 As DevExpress.XtraEditors.LabelControl
        Private layoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
        Private simpleSeparator4 As DevExpress.XtraLayout.SimpleSeparator
        Private layoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents uow2CommitChangesButton As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
        Private labelControl4 As DevExpress.XtraEditors.LabelControl
        Private layoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
        Private lciButtonEdit1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents buttonEdit2 As DevExpress.XtraEditors.ButtonEdit
        Private lciButtonEdit2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents buttonEdit3 As DevExpress.XtraEditors.ButtonEdit
        Private lciButtonEdit3 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents buttonEdit6 As DevExpress.XtraEditors.ButtonEdit
        Private WithEvents buttonEdit5 As DevExpress.XtraEditors.ButtonEdit
        Private WithEvents buttonEdit4 As DevExpress.XtraEditors.ButtonEdit
        Private lciButtonEdit4 As DevExpress.XtraLayout.LayoutControlItem
        Private lciButtonEdit5 As DevExpress.XtraLayout.LayoutControlItem
        Private lciButtonEdit6 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents buttonEdit9 As DevExpress.XtraEditors.ButtonEdit
        Private WithEvents buttonEdit8 As DevExpress.XtraEditors.ButtonEdit
        Private WithEvents buttonEdit7 As DevExpress.XtraEditors.ButtonEdit
        Private lciButtonEdit7 As DevExpress.XtraLayout.LayoutControlItem
        Private lciButtonEdit8 As DevExpress.XtraLayout.LayoutControlItem
        Private lciButtonEdit9 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents buttonEdit12 As DevExpress.XtraEditors.ButtonEdit
        Private WithEvents buttonEdit11 As DevExpress.XtraEditors.ButtonEdit
        Private WithEvents buttonEdit10 As DevExpress.XtraEditors.ButtonEdit
        Private lciButtonEdit10 As DevExpress.XtraLayout.LayoutControlItem
        Private lciButtonEdit11 As DevExpress.XtraLayout.LayoutControlItem
        Private lciButtonEdit12 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents timer1 As System.Windows.Forms.Timer
        Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
