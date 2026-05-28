Imports DevExpress.Utils.Html

Namespace DevExpress.HTML.Demos

    Partial Class ToolTipViewModule

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
            Me.tabPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.pageToolTip = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.previewToolTipView1 = New DevExpress.HTML.Demos.PreviewToolTip()
            Me.pageDialogBox = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.previewSuperToolTip1 = New DevExpress.HTML.Demos.PreviewSuperTip()
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane.SuspendLayout()
            Me.pageToolTip.SuspendLayout()
            Me.pageDialogBox.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabPane
            ' 
            Me.tabPane.Controls.Add(Me.pageToolTip)
            Me.tabPane.Controls.Add(Me.pageDialogBox)
            Me.tabPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane.Location = New System.Drawing.Point(0, 0)
            Me.tabPane.Name = "tabPane"
            Me.tabPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.pageToolTip, Me.pageDialogBox})
            Me.tabPane.RegularSize = New System.Drawing.Size(901, 466)
            Me.tabPane.SelectedPage = Me.pageToolTip
            Me.tabPane.Size = New System.Drawing.Size(901, 466)
            Me.tabPane.TabIndex = 13
            Me.tabPane.Text = "tabPane1"
            ' 
            ' pageToolTip
            ' 
            Me.pageToolTip.Caption = "ToolTip"
            Me.pageToolTip.Controls.Add(Me.previewToolTipView1)
            Me.pageToolTip.Name = "pageToolTip"
            Me.pageToolTip.Size = New System.Drawing.Size(901, 433)
            ' 
            ' previewToolTipView1
            ' 
            Me.previewToolTipView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewToolTipView1.Location = New System.Drawing.Point(0, 0)
            Me.previewToolTipView1.Margin = New System.Windows.Forms.Padding(1)
            Me.previewToolTipView1.Name = "previewToolTipView1"
            Me.previewToolTipView1.Size = New System.Drawing.Size(901, 433)
            Me.previewToolTipView1.TabIndex = 0
            ' 
            ' pageDialogBox
            ' 
            Me.pageDialogBox.Caption = "SuperToolTip"
            Me.pageDialogBox.Controls.Add(Me.previewSuperToolTip1)
            Me.pageDialogBox.Name = "pageDialogBox"
            Me.pageDialogBox.Size = New System.Drawing.Size(900, 434)
            ' 
            ' previewSuperToolTip1
            ' 
            Me.previewSuperToolTip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewSuperToolTip1.Location = New System.Drawing.Point(0, 0)
            Me.previewSuperToolTip1.Margin = New System.Windows.Forms.Padding(6)
            Me.previewSuperToolTip1.Name = "previewSuperToolTip1"
            Me.previewSuperToolTip1.Size = New System.Drawing.Size(900, 434)
            Me.previewSuperToolTip1.TabIndex = 0
            ' 
            ' ToolTipViewModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "ToolTipViewModule"
            Me.Size = New System.Drawing.Size(901, 466)
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane.ResumeLayout(False)
            Me.pageToolTip.ResumeLayout(False)
            Me.pageDialogBox.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane As DevExpress.XtraBars.Navigation.TabPane

        Private pageToolTip As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private pageDialogBox As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private previewToolTipView1 As DevExpress.HTML.Demos.PreviewToolTip

        Private previewSuperToolTip1 As DevExpress.HTML.Demos.PreviewSuperTip
    End Class
End Namespace
