Namespace DevExpress.XtraScheduler.Demos

    Partial Class SendAppointmentByMailForm

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
            Me.progressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lblMessage = New DevExpress.XtraEditors.LabelControl()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciProgressPanel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciBtnOk = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciMessage = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciProgressPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciBtnOk), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciMessage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' progressPanel1
            ' 
            Me.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.progressPanel1.Appearance.Options.UseBackColor = True
            Me.progressPanel1.BarAnimationElementThickness = 2
            Me.progressPanel1.Location = New System.Drawing.Point(12, 12)
            Me.progressPanel1.Name = "progressPanel1"
            Me.progressPanel1.Size = New System.Drawing.Size(322, 16)
            Me.progressPanel1.StyleController = Me.layoutControl1
            Me.progressPanel1.TabIndex = 0
            Me.progressPanel1.Text = "progressPanel1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.lblMessage)
            Me.layoutControl1.Controls.Add(Me.progressPanel1)
            Me.layoutControl1.Controls.Add(Me.btnOk)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(478, 296, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(363, 106)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' lblMessage
            ' 
            Me.lblMessage.Location = New System.Drawing.Point(12, 32)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(63, 13)
            Me.lblMessage.StyleController = Me.layoutControl1
            Me.lblMessage.TabIndex = 1
            Me.lblMessage.Text = "labelControl1"
            ' 
            ' btnOk
            ' 
            Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOk.Location = New System.Drawing.Point(258, 73)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(66, 23)
            Me.btnOk.StyleController = Me.layoutControl1
            Me.btnOk.TabIndex = 5
            Me.btnOk.Text = "OK"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciProgressPanel, Me.lciBtnOk, Me.emptySpaceItem1, Me.lciMessage, Me.emptySpaceItem2, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(346, 108)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciProgressPanel
            ' 
            Me.lciProgressPanel.Control = Me.progressPanel1
            Me.lciProgressPanel.Location = New System.Drawing.Point(0, 0)
            Me.lciProgressPanel.MinSize = New System.Drawing.Size(54, 20)
            Me.lciProgressPanel.Name = "lciProgressPanel"
            Me.lciProgressPanel.Size = New System.Drawing.Size(326, 20)
            Me.lciProgressPanel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciProgressPanel.TextSize = New System.Drawing.Size(0, 0)
            Me.lciProgressPanel.TextVisible = False
            ' 
            ' lciBtnOk
            ' 
            Me.lciBtnOk.Control = Me.btnOk
            Me.lciBtnOk.CustomizationFormText = "layoutControlItem1"
            Me.lciBtnOk.Location = New System.Drawing.Point(246, 61)
            Me.lciBtnOk.MaxSize = New System.Drawing.Size(70, 27)
            Me.lciBtnOk.MinSize = New System.Drawing.Size(70, 27)
            Me.lciBtnOk.Name = "lciBtnOk"
            Me.lciBtnOk.Size = New System.Drawing.Size(70, 27)
            Me.lciBtnOk.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciBtnOk.Text = "layoutControlItem1"
            Me.lciBtnOk.TextLocation = DevExpress.Utils.Locations.Left
            Me.lciBtnOk.TextSize = New System.Drawing.Size(0, 0)
            Me.lciBtnOk.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(316, 61)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(10, 27)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciMessage
            ' 
            Me.lciMessage.Control = Me.lblMessage
            Me.lciMessage.Location = New System.Drawing.Point(0, 20)
            Me.lciMessage.Name = "lciMessage"
            Me.lciMessage.Size = New System.Drawing.Size(326, 17)
            Me.lciMessage.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMessage.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 61)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(246, 27)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 37)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(326, 24)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' SendAppointmentByMailForm
            ' 
            Me.AcceptButton = Me.btnOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnOk
            Me.ClientSize = New System.Drawing.Size(363, 106)
            Me.Controls.Add(Me.layoutControl1)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SendAppointmentByMailForm"
            Me.ShowIcon = False
            Me.Text = "Opening Default Mail Client"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciProgressPanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciBtnOk), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciMessage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private progressPanel1 As DevExpress.XtraWaitForm.ProgressPanel

        Private lblMessage As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciProgressPanel As DevExpress.XtraLayout.LayoutControlItem

        Private lciMessage As DevExpress.XtraLayout.LayoutControlItem

        Private btnOk As DevExpress.XtraEditors.SimpleButton

        Private lciBtnOk As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
