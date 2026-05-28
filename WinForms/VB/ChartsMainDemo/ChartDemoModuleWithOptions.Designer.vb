Namespace DevExpress.XtraCharts.Demos

    Partial Class ChartDemoModuleWithOptions

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                RemoveHandler Me.tabPaneOptions.StateChanged, AddressOf Me.tabPaneOptions_StateChanged
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(546, 0)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(242, 571)
            Me.sidePanelOptions.TabIndex = 0
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(241, 571)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(241, 571)
            Me.tabPaneOptions.TabIndex = 0
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.BackgroundPadding = New System.Windows.Forms.Padding(0)
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(239, 542)
            ' 
            ' ChartDemoModuleWithOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanelOptions)
            Me.Name = "ChartDemoModuleWithOptions"
            Me.Size = New System.Drawing.Size(788, 571)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
