Namespace DevExpress.XtraEditors.Demos.Modules

    Partial Class TimerControl

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
            Me.components = New System.ComponentModel.Container()
            Dim windowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.Modules.TimerControl))
            Dim windowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Me.timeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.windowsUIButtonPanelStart = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.windowsUIButtonPanelCancel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.SuspendLayout()
            ' 
            ' timeLabel
            ' 
            Me.timeLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 48.25F)
            Me.timeLabel.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue
            Me.timeLabel.Appearance.Options.UseFont = True
            Me.timeLabel.Appearance.Options.UseForeColor = True
            Me.timeLabel.Appearance.Options.UseTextOptions = True
            Me.timeLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.timeLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.timeLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.timeLabel.Location = New System.Drawing.Point(35, 0)
            Me.timeLabel.Name = "timeLabel"
            Me.timeLabel.Size = New System.Drawing.Size(274, 62)
            Me.timeLabel.TabIndex = 1
            Me.timeLabel.Text = "05:00:00"
            ' 
            ' windowsUIButtonPanelStart
            ' 
            Me.windowsUIButtonPanelStart.AllowGlyphSkinning = False
            windowsUIButtonImageOptions1.SvgImage = CType((resources.GetObject("windowsUIButtonImageOptions1.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.windowsUIButtonPanelStart.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Start", False, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanelStart.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.windowsUIButtonPanelStart.Dock = System.Windows.Forms.DockStyle.Right
            Me.windowsUIButtonPanelStart.Location = New System.Drawing.Point(309, 0)
            Me.windowsUIButtonPanelStart.Name = "windowsUIButtonPanelStart"
            Me.windowsUIButtonPanelStart.Size = New System.Drawing.Size(35, 62)
            Me.windowsUIButtonPanelStart.TabIndex = 2
            Me.windowsUIButtonPanelStart.Text = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanelStart.UseButtonBackgroundImages = False
            AddHandler Me.windowsUIButtonPanelStart.ButtonClick, New DevExpress.XtraBars.Docking2010.ButtonEventHandler(AddressOf Me.OnButtonClick)
            ' 
            ' timer
            ' 
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTick)
            ' 
            ' windowsUIButtonPanelCancel
            ' 
            Me.windowsUIButtonPanelCancel.AllowGlyphSkinning = False
            windowsUIButtonImageOptions2.SvgImage = CType((resources.GetObject("windowsUIButtonImageOptions2.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.windowsUIButtonPanelCancel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancel", False, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, False, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanelCancel.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.windowsUIButtonPanelCancel.Dock = System.Windows.Forms.DockStyle.Left
            Me.windowsUIButtonPanelCancel.Location = New System.Drawing.Point(0, 0)
            Me.windowsUIButtonPanelCancel.Name = "windowsUIButtonPanelCancel"
            Me.windowsUIButtonPanelCancel.Size = New System.Drawing.Size(35, 62)
            Me.windowsUIButtonPanelCancel.TabIndex = 3
            Me.windowsUIButtonPanelCancel.Text = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanelCancel.UseButtonBackgroundImages = False
            AddHandler Me.windowsUIButtonPanelCancel.ButtonClick, New DevExpress.XtraBars.Docking2010.ButtonEventHandler(AddressOf Me.OnButtonClick)
            ' 
            ' TimerControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.timeLabel)
            Me.Controls.Add(Me.windowsUIButtonPanelCancel)
            Me.Controls.Add(Me.windowsUIButtonPanelStart)
            Me.Name = "TimerControl"
            Me.Size = New System.Drawing.Size(344, 62)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private timeLabel As DevExpress.XtraEditors.LabelControl

        Private windowsUIButtonPanelStart As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private timer As System.Windows.Forms.Timer

        Private windowsUIButtonPanelCancel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    End Class
End Namespace
