Namespace DevExpress.XtraScheduler.Demos

    Partial Class AppointmentOptionsControl

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.cbAppointmentFontSize = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.feAppointment = New DevExpress.XtraEditors.FontEdit()
            Me.chkAppointmentShowRecurrence = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAppointmentShowReminder = New DevExpress.XtraEditors.CheckEdit()
            Me.optionsGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.cbAppointmentFontSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.feAppointment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAppointmentShowRecurrence.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAppointmentShowReminder.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.optionsGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' cbAppointmentFontSize
            ' 
            Me.cbAppointmentFontSize.Location = New System.Drawing.Point(278, 34)
            Me.cbAppointmentFontSize.Name = "cbAppointmentFontSize"
            Me.cbAppointmentFontSize.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbAppointmentFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAppointmentFontSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.cbAppointmentFontSize.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.cbAppointmentFontSize.Size = New System.Drawing.Size(58, 20)
            Me.cbAppointmentFontSize.StyleController = Me.layoutControl2
            Me.cbAppointmentFontSize.TabIndex = 7
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.Controls.Add(Me.feAppointment)
            Me.layoutControl2.Controls.Add(Me.chkAppointmentShowRecurrence)
            Me.layoutControl2.Controls.Add(Me.chkAppointmentShowReminder)
            Me.layoutControl2.Controls.Add(Me.cbAppointmentFontSize)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(505, 96, 650, 400)
            Me.layoutControl2.Root = Me.optionsGroup
            Me.layoutControl2.Size = New System.Drawing.Size(458, 375)
            Me.layoutControl2.TabIndex = 1
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' feAppointment
            ' 
            Me.feAppointment.Location = New System.Drawing.Point(53, 34)
            Me.feAppointment.Name = "feAppointment"
            Me.feAppointment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.feAppointment.Size = New System.Drawing.Size(221, 20)
            Me.feAppointment.StyleController = Me.layoutControl2
            Me.feAppointment.TabIndex = 4
            ' 
            ' chkAppointmentShowRecurrence
            ' 
            Me.chkAppointmentShowRecurrence.Location = New System.Drawing.Point(12, 58)
            Me.chkAppointmentShowRecurrence.Name = "chkAppointmentShowRecurrence"
            Me.chkAppointmentShowRecurrence.Properties.Caption = "Show reccurrence icon"
            Me.chkAppointmentShowRecurrence.Size = New System.Drawing.Size(434, 20)
            Me.chkAppointmentShowRecurrence.StyleController = Me.layoutControl2
            Me.chkAppointmentShowRecurrence.TabIndex = 5
            ' 
            ' chkAppointmentShowReminder
            ' 
            Me.chkAppointmentShowReminder.Location = New System.Drawing.Point(12, 82)
            Me.chkAppointmentShowReminder.Name = "chkAppointmentShowReminder"
            Me.chkAppointmentShowReminder.Properties.Caption = "Show reminder icon"
            Me.chkAppointmentShowReminder.Size = New System.Drawing.Size(434, 20)
            Me.chkAppointmentShowReminder.StyleController = Me.layoutControl2
            Me.chkAppointmentShowReminder.TabIndex = 6
            ' 
            ' optionsGroup
            ' 
            Me.optionsGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.optionsGroup.GroupBordersVisible = False
            Me.optionsGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.optionsGroup.Name = "Root"
            Me.optionsGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.optionsGroup.Size = New System.Drawing.Size(458, 375)
            Me.optionsGroup.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(458, 375)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Display Options"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.feAppointment
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(266, 24)
            Me.layoutControlItem1.Text = "Font :"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(29, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbAppointmentFontSize
            Me.layoutControlItem4.Location = New System.Drawing.Point(266, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(62, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkAppointmentShowRecurrence
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(438, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkAppointmentShowReminder
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(438, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(328, 0)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(110, 24)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 72)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(438, 261)
            ' 
            ' AppointmentOptionsControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl2)
            Me.Name = "AppointmentOptionsControl"
            Me.Size = New System.Drawing.Size(458, 375)
            CType((Me.cbAppointmentFontSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.feAppointment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAppointmentShowRecurrence.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAppointmentShowReminder.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.optionsGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chkAppointmentShowReminder As DevExpress.XtraEditors.CheckEdit

        Private chkAppointmentShowRecurrence As DevExpress.XtraEditors.CheckEdit

        Private feAppointment As DevExpress.XtraEditors.FontEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private cbAppointmentFontSize As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private optionsGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
