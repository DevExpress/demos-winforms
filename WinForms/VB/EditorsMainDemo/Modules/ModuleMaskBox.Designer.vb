Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleMaskBox

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.tabPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.optionsPanel = New DevExpress.XtraEditors.SidePanel()
            Me.optionsPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.optionsPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.settingsPanel = New DevExpress.XtraEditors.Mask.Design.AdvancedSettingsEditor()
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.optionsPanel.SuspendLayout()
            CType((Me.optionsPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.optionsPane.SuspendLayout()
            Me.optionsPage.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabPane
            ' 
            Me.tabPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane.Location = New System.Drawing.Point(0, 0)
            Me.tabPane.Margin = New System.Windows.Forms.Padding(0)
            Me.tabPane.Name = "tabPane"
            Me.tabPane.RegularSize = New System.Drawing.Size(600, 600)
            Me.tabPane.Size = New System.Drawing.Size(600, 600)
            Me.tabPane.TabIndex = 0
            Me.tabPane.Text = "tabPane"
            AddHandler Me.tabPane.SelectedPageChanged, New DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(AddressOf Me.OnSelectedPageChanged)
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel.Controls.Add(Me.optionsPane)
            Me.optionsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.optionsPanel.Location = New System.Drawing.Point(600, 0)
            Me.optionsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.optionsPanel.MinimumSize = New System.Drawing.Size(250, 0)
            Me.optionsPanel.Name = "optionsPanel"
            Me.optionsPanel.Size = New System.Drawing.Size(250, 600)
            Me.optionsPanel.TabIndex = 1
            ' 
            ' optionsPane
            ' 
            Me.optionsPane.Controls.Add(Me.optionsPage)
            Me.optionsPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.optionsPane.Location = New System.Drawing.Point(1, 0)
            Me.optionsPane.Name = "optionsPane"
            Me.optionsPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.optionsPage})
            Me.optionsPane.RegularSize = New System.Drawing.Size(249, 600)
            Me.optionsPane.SelectedPage = Me.optionsPage
            Me.optionsPane.Size = New System.Drawing.Size(249, 600)
            Me.optionsPane.TabIndex = 1
            Me.optionsPane.Text = "tabPane1"
            ' 
            ' optionsPage
            ' 
            Me.optionsPage.Caption = "Options"
            Me.optionsPage.Controls.Add(Me.settingsPanel)
            Me.optionsPage.Name = "optionsPage"
            Me.optionsPage.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
            Me.optionsPage.Size = New System.Drawing.Size(249, 567)
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.settingsPanel.Location = New System.Drawing.Point(10, 20)
            Me.settingsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Padding = New System.Windows.Forms.Padding(10, 30, 10, 0)
            Me.settingsPanel.Size = New System.Drawing.Size(229, 527)
            Me.settingsPanel.TabIndex = 0
            ' 
            ' ModuleMaskBox
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane)
            Me.Controls.Add(Me.optionsPanel)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "ModuleMaskBox"
            Me.Size = New System.Drawing.Size(850, 600)
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.optionsPanel.ResumeLayout(False)
            CType((Me.optionsPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.optionsPane.ResumeLayout(False)
            Me.optionsPage.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane As DevExpress.XtraBars.Navigation.TabPane

        Private optionsPanel As DevExpress.XtraEditors.SidePanel

        Private settingsPanel As DevExpress.XtraEditors.Mask.Design.AdvancedSettingsEditor

        Private optionsPane As DevExpress.XtraBars.Navigation.TabPane

        Private optionsPage As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
