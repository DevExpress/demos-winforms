Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Preview

Namespace DevExpress.DevAV

    Public Partial Class ReportPreviewControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            printPreviewBarItemWholePage.Glyph = Nothing
            printPreviewBarItemScale.Glyph = Nothing
            printPreviewBarItemMultiplePages.Glyph = Nothing
            printPreviewBarItemWholePage.ImageOptions.SvgImage = SvgImage.FromResources("DevExpress.DevAV.Resources.Fluent.Controls.OverviewControl.scale-fluent-light-blue-16.svg", GetType(MainForm).Assembly)
            printPreviewBarItemMultiplePages.ImageOptions.SvgImage = SvgImage.FromResources("DevExpress.DevAV.Resources.Fluent.Controls.OverviewControl.page-multiple-fluent-light-blue-16.svg", GetType(MainForm).Assembly)
            printPreviewBarItemScale.ImageOptions.SvgImage = SvgImage.FromResources("DevExpress.DevAV.Resources.Fluent.Controls.OverviewControl.expand-fluent-light-yellow-16.svg", GetType(MainForm).Assembly)
        End Sub

        Public ReadOnly Property DocumentViewer As DocumentViewer
            Get
                Return documentViewerCore
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            DocumentViewer.BackColor = GetControlColor(LookAndFeel)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            DocumentViewer.BackColor = GetControlColor(LookAndFeel)
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
