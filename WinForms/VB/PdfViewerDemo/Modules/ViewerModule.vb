Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraPdfViewer.Demos

    Public Partial Class ViewerModule
        Inherits TutorialControlBase

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            pdfViewer1.CreateRibbon()
            pdfViewer1.DocumentCreator = "PDF Viewer Demo"
            pdfViewer1.DocumentProducer = "Developer Express Inc., " & AssemblyInfo.Version
            pdfViewer1.LoadDocument(DemoHelpers.GetDocumentStream())
            AddHandler pdfViewer1.DocumentClosing, AddressOf OnDocumentClosing
        End Sub

        Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
            MyBase.OnParentChanged(e)
            AddHandler ParentForm.FormClosing, AddressOf OnDocumentClosing
        End Sub

        Private Sub OnDocumentClosing(ByVal sender As Object, ByVal e As CancelEventArgs)
            If pdfViewer1.IsDocumentChanged Then e.Cancel = Not pdfViewer1.ShowDocumentClosingWarning()
        End Sub

    End Class
End Namespace
