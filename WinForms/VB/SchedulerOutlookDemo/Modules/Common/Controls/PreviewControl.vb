Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrinting.Preview

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ReportPreviewControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public ReadOnly Property DocumentViewer As DocumentViewer
            Get
                Return documentViewerCore
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            DocumentViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            DocumentViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
        Public Property DocumentSource As Object
            Get
                Return documentViewerCore.DocumentSource
            End Get

            Set(ByVal value As Object)
                If Not ReferenceEquals(documentViewerCore.DocumentSource, value) Then
                    documentViewerCore.DocumentSource = value
                End If
            End Set
        End Property
    End Class
End Namespace
