Imports System.Windows.Forms

Namespace XtraReportsDemos

    Public Class MainFeaturesControl
        Inherits ModuleControl

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private rtbFeatures As RichTextBox

        Private ReadOnly components As System.ComponentModel.IContainer = Nothing

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
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
            xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            rtbFeatures = New RichTextBox()
            CType(xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            xtraTabControl1.SuspendLayout()
            xtraTabPage1.SuspendLayout()
            SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            xtraTabControl1.Dock = DockStyle.Fill
            xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            xtraTabControl1.Name = "xtraTabControl1"
            xtraTabControl1.SelectedTabPage = xtraTabPage1
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            xtraTabControl1.Size = New System.Drawing.Size(184, 124)
            xtraTabControl1.TabIndex = 0
            xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {xtraTabPage1})
            xtraTabControl1.Text = "xtraTabControl1"
            ' 
            ' xtraTabPage1
            ' 
            xtraTabPage1.Controls.Add(rtbFeatures)
            xtraTabPage1.Name = "xtraTabPage1"
            xtraTabPage1.Size = New System.Drawing.Size(175, 115)
            xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' rtbFeatures
            ' 
            rtbFeatures.BackColor = System.Drawing.Color.White
            rtbFeatures.BorderStyle = BorderStyle.None
            rtbFeatures.Dock = DockStyle.Fill
            rtbFeatures.ForeColor = System.Drawing.Color.Black
            rtbFeatures.Location = New System.Drawing.Point(0, 0)
            rtbFeatures.Name = "rtbFeatures"
            rtbFeatures.ReadOnly = True
            rtbFeatures.Size = New System.Drawing.Size(175, 115)
            rtbFeatures.TabIndex = 1
            rtbFeatures.Text = ""
            ' 
            ' MainFeaturesControl
            ' 
            Controls.Add(xtraTabControl1)
            Name = "MainFeaturesControl"
            Size = New System.Drawing.Size(184, 124)
            CType(xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            xtraTabControl1.ResumeLayout(False)
            xtraTabPage1.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

#End Region
        Public Overrides Sub Activate()
            If DesignMode Then Return
            rtbFeatures.Rtf = Properties.Resources.ReportsAbout
        End Sub
    End Class
End Namespace
