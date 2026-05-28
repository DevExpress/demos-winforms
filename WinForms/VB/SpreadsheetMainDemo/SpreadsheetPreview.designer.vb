Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class SpreadsheetPreview

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
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.documentViewerSinglePreview = New DevExpress.XtraPrinting.Preview.DocumentViewer()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(623, 244)
            Me.xtraTabPage2.Text = "xtraTabPage2"
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(623, 244)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(629, 272)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            ' 
            ' documentViewerSinglePreview
            ' 
            Me.documentViewerSinglePreview.Dock = System.Windows.Forms.DockStyle.Fill
            Me.documentViewerSinglePreview.IsMetric = True
            Me.documentViewerSinglePreview.Location = New System.Drawing.Point(0, 0)
            Me.documentViewerSinglePreview.Name = "documentViewerSinglePreview"
            Me.documentViewerSinglePreview.Size = New System.Drawing.Size(629, 272)
            Me.documentViewerSinglePreview.TabIndex = 2
            ' 
            ' SpreadsheetPreview
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Controls.Add(Me.documentViewerSinglePreview)
            Me.Name = "SpreadsheetPreview"
            Me.Size = New System.Drawing.Size(629, 272)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private documentViewerSinglePreview As DevExpress.XtraPrinting.Preview.DocumentViewer
    End Class
End Namespace
