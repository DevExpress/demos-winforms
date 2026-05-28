Namespace DevExpress.XtraScheduler.Demos

    Partial Class SelectOutlookCalendarsForm

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lblErrorMessage = New DevExpress.XtraEditors.LabelControl()
            Me.ppWaitData = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.cbCalendars = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciEditor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciProgress = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciErrorMessage = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbCalendars.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciProgress), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciErrorMessage), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.lblErrorMessage)
            Me.layoutControl1.Controls.Add(Me.ppWaitData)
            Me.layoutControl1.Controls.Add(Me.cbCalendars)
            Me.layoutControl1.Controls.Add(Me.btnOk)
            Me.layoutControl1.Controls.Add(Me.btnCancel)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(316, 343, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(346, 81)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' lblErrorMessage
            ' 
            Me.lblErrorMessage.Location = New System.Drawing.Point(164, 12)
            Me.lblErrorMessage.Name = "lblErrorMessage"
            Me.lblErrorMessage.Size = New System.Drawing.Size(63, 13)
            Me.lblErrorMessage.StyleController = Me.layoutControl1
            Me.lblErrorMessage.TabIndex = 8
            Me.lblErrorMessage.Text = "labelControl1"
            ' 
            ' ppWaitData
            ' 
            Me.ppWaitData.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ppWaitData.Appearance.Options.UseBackColor = True
            Me.ppWaitData.BarAnimationElementThickness = 2
            Me.ppWaitData.Location = New System.Drawing.Point(12, 12)
            Me.ppWaitData.Name = "ppWaitData"
            Me.ppWaitData.Size = New System.Drawing.Size(148, 20)
            Me.ppWaitData.StyleController = Me.layoutControl1
            Me.ppWaitData.TabIndex = 7
            Me.ppWaitData.Text = "progressPanel1"
            ' 
            ' cbCalendars
            ' 
            Me.cbCalendars.Location = New System.Drawing.Point(284, 12)
            Me.cbCalendars.Name = "cbCalendars"
            Me.cbCalendars.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbCalendars.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCalendars.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbCalendars.Size = New System.Drawing.Size(50, 20)
            Me.cbCalendars.StyleController = Me.layoutControl1
            Me.cbCalendars.TabIndex = 5
            ' 
            ' btnOk
            ' 
            Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOk.Location = New System.Drawing.Point(188, 46)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(66, 23)
            Me.btnOk.StyleController = Me.layoutControl1
            Me.btnOk.TabIndex = 5
            Me.btnOk.Text = "OK"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(268, 46)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(66, 23)
            Me.btnCancel.StyleController = Me.layoutControl1
            Me.btnCancel.TabIndex = 6
            Me.btnCancel.Text = "Cancel"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.lciEditor, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.lciProgress, Me.emptySpaceItem4, Me.lciErrorMessage})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(346, 81)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 34)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(64, 27)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciEditor
            ' 
            Me.lciEditor.Control = Me.cbCalendars
            Me.lciEditor.Location = New System.Drawing.Point(219, 0)
            Me.lciEditor.MinSize = New System.Drawing.Size(107, 24)
            Me.lciEditor.Name = "lciEditor"
            Me.lciEditor.OptionsTableLayoutItem.ColumnIndex = 1
            Me.lciEditor.Size = New System.Drawing.Size(107, 24)
            Me.lciEditor.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciEditor.Text = "Calendar :"
            Me.lciEditor.TextSize = New System.Drawing.Size(50, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.btnOk
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem4.Location = New System.Drawing.Point(176, 34)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(70, 27)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(70, 27)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem4.Size = New System.Drawing.Size(70, 27)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.Text = "layoutControlItem1"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnCancel
            Me.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem5.Location = New System.Drawing.Point(256, 34)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(70, 27)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(70, 27)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem5.Size = New System.Drawing.Size(70, 27)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.Text = "layoutControlItem2"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(246, 34)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.OptionsTableLayoutItem.RowIndex = 2
            Me.emptySpaceItem2.Size = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.Text = "emptySpaceItem1"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(64, 34)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.OptionsTableLayoutItem.ColumnIndex = 1
            Me.emptySpaceItem3.OptionsTableLayoutItem.RowIndex = 2
            Me.emptySpaceItem3.Size = New System.Drawing.Size(112, 27)
            Me.emptySpaceItem3.Text = "emptySpaceItem2"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciProgress
            ' 
            Me.lciProgress.Control = Me.ppWaitData
            Me.lciProgress.Location = New System.Drawing.Point(0, 0)
            Me.lciProgress.MinSize = New System.Drawing.Size(54, 20)
            Me.lciProgress.Name = "lciProgress"
            Me.lciProgress.OptionsTableLayoutItem.ColumnIndex = 1
            Me.lciProgress.OptionsTableLayoutItem.RowIndex = 3
            Me.lciProgress.Size = New System.Drawing.Size(152, 24)
            Me.lciProgress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciProgress.TextSize = New System.Drawing.Size(0, 0)
            Me.lciProgress.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.OptionsTableLayoutItem.RowIndex = 3
            Me.emptySpaceItem4.Size = New System.Drawing.Size(326, 10)
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciErrorMessage
            ' 
            Me.lciErrorMessage.Control = Me.lblErrorMessage
            Me.lciErrorMessage.Location = New System.Drawing.Point(152, 0)
            Me.lciErrorMessage.Name = "lciErrorMessage"
            Me.lciErrorMessage.Size = New System.Drawing.Size(67, 24)
            Me.lciErrorMessage.TextSize = New System.Drawing.Size(0, 0)
            Me.lciErrorMessage.TextVisible = False
            ' 
            ' SelectOutlookCalendarsForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.ClientSize = New System.Drawing.Size(346, 81)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "SelectOutlookCalendarsForm"
            Me.Text = "Choose outlook calendar"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbCalendars.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciProgress), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciErrorMessage), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private cbCalendars As DevExpress.XtraEditors.ComboBoxEdit

        Private btnOk As DevExpress.XtraEditors.SimpleButton

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private lciEditor As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private ppWaitData As DevExpress.XtraWaitForm.ProgressPanel

        Private lciProgress As DevExpress.XtraLayout.LayoutControlItem

        Private lblErrorMessage As DevExpress.XtraEditors.LabelControl

        Private lciErrorMessage As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
