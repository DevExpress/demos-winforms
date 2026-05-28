Imports DevExpress.Utils.Html

Namespace DevExpress.HTML.Demos

    Partial Class MessageViewModule

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
            Me.pageMessageBox = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.viewMessageBox = New DevExpress.HTML.Demos.MessageBoxView()
            Me.pageDialogBox = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.viewDialogBox = New DevExpress.HTML.Demos.DialogBoxView()
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane.SuspendLayout()
            Me.pageMessageBox.SuspendLayout()
            Me.pageDialogBox.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabPane
            ' 
            Me.tabPane.Controls.Add(Me.pageMessageBox)
            Me.tabPane.Controls.Add(Me.pageDialogBox)
            Me.tabPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane.Location = New System.Drawing.Point(0, 0)
            Me.tabPane.Margin = New System.Windows.Forms.Padding(2)
            Me.tabPane.Name = "tabPane"
            Me.tabPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.pageMessageBox, Me.pageDialogBox})
            Me.tabPane.RegularSize = New System.Drawing.Size(900, 467)
            Me.tabPane.SelectedPage = Me.pageMessageBox
            Me.tabPane.Size = New System.Drawing.Size(900, 467)
            Me.tabPane.TabIndex = 13
            Me.tabPane.Text = "tabPane1"
            ' 
            ' pageMessageBox
            ' 
            Me.pageMessageBox.Caption = "MessageBox"
            Me.pageMessageBox.Controls.Add(Me.viewMessageBox)
            Me.pageMessageBox.Margin = New System.Windows.Forms.Padding(2)
            Me.pageMessageBox.Name = "pageMessageBox"
            Me.pageMessageBox.Size = New System.Drawing.Size(900, 434)
            ' 
            ' viewMessageBox
            ' 
            Me.viewMessageBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.viewMessageBox.Location = New System.Drawing.Point(0, 0)
            Me.viewMessageBox.Margin = New System.Windows.Forms.Padding(1)
            Me.viewMessageBox.Name = "viewMessageBox"
            Me.viewMessageBox.Size = New System.Drawing.Size(900, 434)
            Me.viewMessageBox.TabIndex = 0
            ' 
            ' pageDialogBox
            ' 
            Me.pageDialogBox.Caption = "DialogBox"
            Me.pageDialogBox.Controls.Add(Me.viewDialogBox)
            Me.pageDialogBox.Margin = New System.Windows.Forms.Padding(2)
            Me.pageDialogBox.Name = "pageDialogBox"
            Me.pageDialogBox.Size = New System.Drawing.Size(900, 430)
            ' 
            ' viewDialogBox
            ' 
            Me.viewDialogBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.viewDialogBox.Location = New System.Drawing.Point(0, 0)
            Me.viewDialogBox.Margin = New System.Windows.Forms.Padding(1)
            Me.viewDialogBox.Name = "viewDialogBox"
            Me.viewDialogBox.Size = New System.Drawing.Size(900, 430)
            Me.viewDialogBox.TabIndex = 0
            ' 
            ' MessageViewModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane)
            Me.Name = "MessageViewModule"
            Me.Size = New System.Drawing.Size(900, 467)
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane.ResumeLayout(False)
            Me.pageMessageBox.ResumeLayout(False)
            Me.pageDialogBox.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane As DevExpress.XtraBars.Navigation.TabPane

        Private pageMessageBox As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private pageDialogBox As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private viewMessageBox As DevExpress.HTML.Demos.MessageBoxView

        Private viewDialogBox As DevExpress.HTML.Demos.DialogBoxView
    End Class
End Namespace
