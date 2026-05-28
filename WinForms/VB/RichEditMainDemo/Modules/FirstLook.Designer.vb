Namespace DevExpress.XtraRichEdit.Demos

    Partial Class FirstLookModule

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
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.documentStatisticsTimer = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Annotations.Comments.Visibility = DevExpress.XtraRichEdit.RichEditCommentVisibility.Hidden
            Me.richEditControl.Options.Behavior.MaxZoomFactor = 5F
            Me.richEditControl.Options.Behavior.MinZoomFactor = 0.1F
            Me.richEditControl.Size = New System.Drawing.Size(845, 369)
            Me.richEditControl.TabIndex = 0
            AddHandler Me.richEditControl.SelectionChanged, New System.EventHandler(AddressOf Me.richEditControl_SelectionChanged)
            AddHandler Me.richEditControl.DocumentClosing, New System.ComponentModel.CancelEventHandler(AddressOf Me.richEditControl_DocumentClosing)
            AddHandler Me.richEditControl.ContentChanged, New System.EventHandler(AddressOf Me.richEditControl_ContentChanged)
            AddHandler Me.richEditControl.ZoomChanged, New System.EventHandler(AddressOf Me.richEditControl_ZoomChanged)
            AddHandler Me.richEditControl.InvalidFormatException, New DevExpress.XtraRichEdit.RichEditInvalidFormatExceptionEventHandler(AddressOf Me.richEditControl_InvalidFormatException)
            AddHandler Me.richEditControl.VisiblePagesChanged, New System.EventHandler(AddressOf Me.richEditControl_VisiblePagesChanged)
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 369)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(845, 20)
            ' 
            ' documentStatisticsTimer
            ' 
            AddHandler Me.documentStatisticsTimer.Tick, New System.EventHandler(AddressOf Me.documentStatisticsTimer_Tick)
            ' 
            ' FirstLookModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Name = "FirstLookModule"
            Me.Size = New System.Drawing.Size(845, 389)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FirstLookModule_Load)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private documentStatisticsTimer As System.Windows.Forms.Timer
    End Class
End Namespace
