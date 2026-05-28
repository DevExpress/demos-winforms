Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraPdfViewer.Demos

    Public Partial Class MainForm
        Inherits RibbonMainForm

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property CreateFeedbackPanel As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property ShowPanelDescription As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraPdfViewer"
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property NavigationControl As Control
            Get
                Return Nothing
            End Get

            Set(ByVal value As Control)
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.DoShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub ShowAbout()
            PdfViewer.About()
        End Sub
    End Class
End Namespace
