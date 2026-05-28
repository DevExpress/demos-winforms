Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class MinesweeperModule

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim columnDefinition6 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition7 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition8 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition9 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition10 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.spreadsheetControl = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.cellSizeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.NewGameBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.cellSizeTrack = New DevExpress.XtraEditors.TrackBarControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cellSizeTrack), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cellSizeTrack.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl
            ' 
            Me.spreadsheetControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl.Location = New System.Drawing.Point(0, 59)
            Me.spreadsheetControl.Name = "spreadsheetControl"
            Me.spreadsheetControl.Options.Behavior.Selection.HideSelection = True
            Me.spreadsheetControl.Options.Behavior.Selection.MoveActiveCellMode = DevExpress.XtraSpreadsheet.MoveActiveCellModeOnEnterPress.None
            Me.spreadsheetControl.Options.Behavior.UseSkinColors = False
            Me.spreadsheetControl.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl.Size = New System.Drawing.Size(784, 373)
            Me.spreadsheetControl.TabIndex = 55
            Me.spreadsheetControl.Text = "spreadsheetControl1"
            ' 
            ' timer1
            ' 
            Me.timer1.Interval = 1000
            AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.Timer1Tick)
            ' 
            ' cellSizeLabel
            ' 
            Me.cellSizeLabel.Location = New System.Drawing.Point(317, 22)
            Me.cellSizeLabel.Name = "cellSizeLabel"
            Me.cellSizeLabel.Size = New System.Drawing.Size(43, 13)
            Me.cellSizeLabel.StyleController = Me.layoutControl1
            Me.cellSizeLabel.TabIndex = 61
            Me.cellSizeLabel.Text = "Cell Size:"
            ' 
            ' NewGameBtn
            ' 
            Me.NewGameBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.NewGameBtn.Location = New System.Drawing.Point(696, 18)
            Me.NewGameBtn.Name = "NewGameBtn"
            Me.NewGameBtn.Size = New System.Drawing.Size(76, 22)
            Me.NewGameBtn.StyleController = Me.layoutControl1
            Me.NewGameBtn.TabIndex = 62
            Me.NewGameBtn.Text = "New Game"
            AddHandler Me.NewGameBtn.Click, New System.EventHandler(AddressOf Me.Button1Click)
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Location = New System.Drawing.Point(12, 12)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Columns = 3
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Beginner"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Intermediate"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Expert")})
            Me.radioGroup1.Size = New System.Drawing.Size(296, 34)
            Me.radioGroup1.StyleController = Me.layoutControl1
            Me.radioGroup1.TabIndex = 59
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroup1SelectedIndexChanged)
            ' 
            ' cellSizeTrack
            ' 
            Me.cellSizeTrack.EditValue = 18
            Me.cellSizeTrack.Location = New System.Drawing.Point(364, 17)
            Me.cellSizeTrack.Name = "cellSizeTrack"
            Me.cellSizeTrack.Properties.AutoSizeMode = DevExpress.XtraEditors.Repository.TrackBarAutoSizeMode.Content
            Me.cellSizeTrack.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.cellSizeTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.cellSizeTrack.Properties.Maximum = 35
            Me.cellSizeTrack.Properties.Minimum = 18
            Me.cellSizeTrack.Size = New System.Drawing.Size(246, 23)
            Me.cellSizeTrack.StyleController = Me.layoutControl1
            Me.cellSizeTrack.TabIndex = 60
            Me.cellSizeTrack.Value = 18
            AddHandler Me.cellSizeTrack.ValueChanged, New System.EventHandler(AddressOf Me.CellSizeTrackValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.AutoScroll = False
            Me.layoutControl1.AutoSize = True
            Me.layoutControl1.Controls.Add(Me.cellSizeTrack)
            Me.layoutControl1.Controls.Add(Me.cellSizeLabel)
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Controls.Add(Me.NewGameBtn)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(784, 58)
            Me.layoutControl1.TabIndex = 57
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.Root.Name = "Root"
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute
            columnDefinition6.Width = 300R
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition7.Width = 52R
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute
            columnDefinition8.Width = 250R
            columnDefinition9.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition9.Width = 100R
            columnDefinition10.SizeType = System.Windows.Forms.SizeType.Absolute
            columnDefinition10.Width = 80R
            Me.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition6, columnDefinition7, columnDefinition8, columnDefinition9, columnDefinition10})
            rowDefinition2.Height = 38R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition2})
            Me.Root.Size = New System.Drawing.Size(784, 58)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem1.Control = Me.NewGameBtn
            Me.layoutControlItem1.Location = New System.Drawing.Point(684, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 4
            Me.layoutControlItem1.Size = New System.Drawing.Size(80, 38)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.radioGroup1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(300, 38)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem3.Control = Me.cellSizeLabel
            Me.layoutControlItem3.Location = New System.Drawing.Point(300, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem3.Size = New System.Drawing.Size(52, 38)
            Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem4.Control = Me.cellSizeTrack
            Me.layoutControlItem4.Location = New System.Drawing.Point(352, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem4.Size = New System.Drawing.Size(250, 38)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.AutoSizeMode = True
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.separatorControl1.Location = New System.Drawing.Point(0, 58)
            Me.separatorControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Size = New System.Drawing.Size(784, 1)
            Me.separatorControl1.TabIndex = 58
            ' 
            ' MinesweeperModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.spreadsheetControl)
            Me.Controls.Add(Me.separatorControl1)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "MinesweeperModule"
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cellSizeTrack.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cellSizeTrack), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private spreadsheetControl As DevExpress.XtraSpreadsheet.SpreadsheetControl

        Private timer1 As System.Windows.Forms.Timer

        Private cellSizeLabel As DevExpress.XtraEditors.LabelControl

        Private NewGameBtn As DevExpress.XtraEditors.SimpleButton

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private cellSizeTrack As DevExpress.XtraEditors.TrackBarControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl
    End Class
End Namespace
