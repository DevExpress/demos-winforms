Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class About

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.rtbAbout = New System.Windows.Forms.RichTextBox()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(524, 457)
            Me.xtraTabControl1.TabIndex = 1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.Text = "xtraTabControl1"
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.rtbAbout)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(515, 448)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' rtbAbout
            ' 
            Me.rtbAbout.BackColor = System.Drawing.SystemColors.Window
            Me.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.rtbAbout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rtbAbout.Location = New System.Drawing.Point(0, 0)
            Me.rtbAbout.Name = "rtbAbout"
            Me.rtbAbout.[ReadOnly] = True
            Me.rtbAbout.Size = New System.Drawing.Size(515, 448)
            Me.rtbAbout.TabIndex = 1
            Me.rtbAbout.Text = ""
            ' 
            ' About
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "About"
            Me.Size = New System.Drawing.Size(524, 457)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private rtbAbout As System.Windows.Forms.RichTextBox
    End Class
End Namespace
