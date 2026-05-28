Imports DevExpress.XtraBars.Docking
Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    ''' <summary>
    ''' Summary description for BaseControl.
    ''' </summary>
    Public Partial Class BaseControl
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dockManager1_RegisterDockPanel(ByVal sender As Object, ByVal e As DockPanelEventArgs)
            If Not DesignMode Then e.Panel.ImageIndex = TutorialConstants.Random.Next(svgImageCollection1.Count)
        End Sub

        Public ReadOnly Property Manager As DockManager
            Get
                Return dockManager1
            End Get
        End Property
    End Class
End Namespace
