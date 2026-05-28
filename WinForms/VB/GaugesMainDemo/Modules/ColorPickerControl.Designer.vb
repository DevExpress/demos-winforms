Namespace DevExpress.XtraGauges.Demos

    Partial Class ColorPickerControl

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
            Me.xtraTabControl1 = New DevExpress.XtraGauges.Demos.NonFocusableTabControl()
            Me.tabCustom = New DevExpress.XtraTab.XtraTabPage()
            Me.colorPickControl = New DevExpress.XtraEditors.InnerColorPickControl()
            Me.tabWeb = New DevExpress.XtraTab.XtraTabPage()
            Me.webColorListControl = New DevExpress.XtraEditors.InnerColorListControl()
            Me.tabSystem = New DevExpress.XtraTab.XtraTabPage()
            Me.systemColorListControl = New DevExpress.XtraEditors.InnerColorListControl()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.tabCustom.SuspendLayout()
            Me.tabWeb.SuspendLayout()
            Me.tabSystem.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.tabCustom
            Me.xtraTabControl1.Size = New System.Drawing.Size(295, 471)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCustom, Me.tabWeb, Me.tabSystem})
            Me.xtraTabControl1.TabStop = False
            ' 
            ' tabCustom
            ' 
            Me.tabCustom.Controls.Add(Me.colorPickControl)
            Me.tabCustom.Name = "tabCustom"
            Me.tabCustom.Size = New System.Drawing.Size(293, 446)
            Me.tabCustom.Text = "Custom"
            ' 
            ' colorPickControl
            ' 
            Me.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorPickControl.Location = New System.Drawing.Point(0, 0)
            Me.colorPickControl.Name = "colorPickControl"
            Me.colorPickControl.ShowAutomaticButton = False
            Me.colorPickControl.ShowMoreColors = False
            Me.colorPickControl.Size = New System.Drawing.Size(293, 446)
            Me.colorPickControl.TabIndex = 2
            AddHandler Me.colorPickControl.SelectedColorChanged, New DevExpress.XtraEditors.InnerColorPickControlSelectedColorChangedEventHandler(AddressOf Me.OnSelectedColorChanged)
            ' 
            ' tabWeb
            ' 
            Me.tabWeb.Controls.Add(Me.webColorListControl)
            Me.tabWeb.Name = "tabWeb"
            Me.tabWeb.Size = New System.Drawing.Size(293, 446)
            Me.tabWeb.Text = "Web"
            ' 
            ' webColorListControl
            ' 
            Me.webColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.webColorListControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webColorListControl.Location = New System.Drawing.Point(0, 0)
            Me.webColorListControl.Name = "webColorListControl"
            Me.webColorListControl.Size = New System.Drawing.Size(293, 446)
            Me.webColorListControl.TabIndex = 1
            AddHandler Me.webColorListControl.SelectedColorChanged, New DevExpress.XtraEditors.InnerColorPickControlSelectedColorChangedEventHandler(AddressOf Me.OnSelectedColorChanged)
            ' 
            ' tabSystem
            ' 
            Me.tabSystem.Controls.Add(Me.systemColorListControl)
            Me.tabSystem.Name = "tabSystem"
            Me.tabSystem.Size = New System.Drawing.Size(293, 446)
            Me.tabSystem.Text = "System"
            ' 
            ' systemColorListControl
            ' 
            Me.systemColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.systemColorListControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.systemColorListControl.Location = New System.Drawing.Point(0, 0)
            Me.systemColorListControl.Name = "systemColorListControl"
            Me.systemColorListControl.Size = New System.Drawing.Size(293, 446)
            Me.systemColorListControl.TabIndex = 1
            AddHandler Me.systemColorListControl.SelectedColorChanged, New DevExpress.XtraEditors.InnerColorPickControlSelectedColorChangedEventHandler(AddressOf Me.OnSelectedColorChanged)
            ' 
            ' ColorPickerControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ColorPickerControl"
            Me.Size = New System.Drawing.Size(295, 471)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.tabCustom.ResumeLayout(False)
            Me.tabWeb.ResumeLayout(False)
            Me.tabSystem.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private xtraTabControl1 As DevExpress.XtraGauges.Demos.NonFocusableTabControl

        Private tabCustom As DevExpress.XtraTab.XtraTabPage

        Private tabWeb As DevExpress.XtraTab.XtraTabPage

        Private tabSystem As DevExpress.XtraTab.XtraTabPage

        Private colorPickControl As DevExpress.XtraEditors.InnerColorPickControl

        Private webColorListControl As DevExpress.XtraEditors.InnerColorListControl

        Private systemColorListControl As DevExpress.XtraEditors.InnerColorListControl
    End Class
End Namespace
