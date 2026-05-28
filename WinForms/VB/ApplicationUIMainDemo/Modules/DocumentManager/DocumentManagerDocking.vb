Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerDocking
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddDocument()
            AddDocument()
            AddDocument()
        End Sub

        Private i As Integer = 0

        Private Sub AddDocument()
            Dim child As XtraUserControl = New XtraUserControl()
            Dim settings As DocumentSettings = New DocumentSettings()
            settings.Caption = "Document" & Math.Min(Threading.Interlocked.Increment(i), i - 1).ToString()
            settings.Image = svgImageCollection1.GetImage(i Mod (svgImageCollection1.Count - 1))
            Utils.Base.BasePropertiesProvider.Attach(child, settings)
            child.Padding = New Padding(16)
            Dim label As LabelControl = New LabelControl()
            label.Text = DemosInfo.GetLoremIpsumText(i)
            label.AutoSizeMode = LabelAutoSizeMode.Vertical
            label.Parent = child
            label.Dock = DockStyle.Fill
            tabbedView.AddDocument(child)
        End Sub
    End Class
End Namespace
