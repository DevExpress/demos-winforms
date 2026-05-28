Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class Employees
        Inherits BaseTutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            Call MainFormHelper.UpdateTakeScreenSettings(Me)
            InitData()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "BaseControl"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"BaseControl"}
            End Get
        End Property

        Private Sub InitData()
            layoutControl1.SetDefaultLayout()
            InitPanels()
            lookUpEdit1.Properties.DataSource = Me.GetNWindData(dsEmployees1, "Employees")
        End Sub

        Public Overrides ReadOnly Property BaseLayout As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property FileMask As String
            Get
                Return "nwind_"
            End Get
        End Property
    End Class
End Namespace
