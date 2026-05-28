Imports System

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class FormatRules
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            treeList1.DataSource = SalesDataGenerator.CreateData()
            treeList1.ExpandAll()
        End Sub

        Private Sub treeList1_Load(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.BestFitColumns()
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
