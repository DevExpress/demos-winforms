Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraDiagram.Demos

    Public Class frmMain
        Inherits RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Dim assembly = GetType(frmMain).Assembly
            Icon = ResourceImageHelperCore.CreateIconFromResources(assembly.GetManifestResourceNames().First(Function(x) x.Contains("DemoIcon.ico")), assembly)
        End Sub

        Protected Overrides Sub ShowAbout()
            Call DiagramControl.About()
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.ShowDiagramModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsList, True, NavBarImage.Large)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides ReadOnly Property CustomWidth As Integer
            Get
                Return 1350
            End Get
        End Property

        Protected Overrides ReadOnly Property CustomHeight As Integer
            Get
                Return 950
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Diagram Control"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraDiagramControl"
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
