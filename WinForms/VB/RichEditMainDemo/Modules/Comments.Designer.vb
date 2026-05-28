Namespace DevExpress.XtraRichEdit.Demos

    Partial Class CommentsModule

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
            Me.components = New System.ComponentModel.Container()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.bottomDockArea = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.richEditCommentControl1 = New DevExpress.XtraRichEdit.RichEditCommentControl()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(740, 464)
            Me.richEditControl.TabIndex = 10
            ' 
            ' bottomDockArea
            ' 
            Me.bottomDockArea.AutoSize = True
            Me.bottomDockArea.CausesValidation = False
            Me.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.bottomDockArea.Location = New System.Drawing.Point(2, 245)
            Me.bottomDockArea.Manager = Nothing
            Me.bottomDockArea.Name = "bottomDockArea"
            Me.bottomDockArea.Size = New System.Drawing.Size(841, 0)
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Edit = Nothing
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel1.ID = New System.Guid("0fd6bee2-437d-4493-89fe-a4e8dc81360b")
            Me.dockPanel1.Location = New System.Drawing.Point(740, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(290, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(290, 464)
            Me.dockPanel1.Text = "Main document comments"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.richEditCommentControl1)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(283, 435)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' richEditCommentControl1
            ' 
            Me.richEditCommentControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.richEditCommentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditCommentControl1.Location = New System.Drawing.Point(0, 0)
            Me.richEditCommentControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.richEditCommentControl1.Name = "richEditCommentControl1"
            Me.richEditCommentControl1.[ReadOnly] = False
            Me.richEditCommentControl1.RichEditControl = Me.richEditControl
            Me.richEditCommentControl1.Size = New System.Drawing.Size(283, 435)
            Me.richEditCommentControl1.TabIndex = 0
            ' 
            ' CommentsModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.dockPanel1)
            Me.Name = "CommentsModule"
            Me.Size = New System.Drawing.Size(1030, 464)
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private bottomDockArea As DevExpress.XtraBars.StandaloneBarDockControl

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private richEditCommentControl1 As DevExpress.XtraRichEdit.RichEditCommentControl
    End Class
End Namespace
