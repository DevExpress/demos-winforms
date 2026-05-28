Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.Internal

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class Bands
        Inherits TutorialControl

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

        Protected Overrides ReadOnly Property Options As Object
            Get
                Return MainControl.OptionsView
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsName As String
            Get
                Return "View Options"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\Bands", "TreeListMainDemo\Options\ucBandOptions"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Bands"
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitSpaceObjectsData()
            ucBandOptions1.InitData(MainControl)
        End Sub

        Private spaceObjectsTable As DataTable

        Private Sub InitSpaceObjectsData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("SpaceObjects.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                spaceObjectsTable = dataSet.Tables(0)
                spaceObjectsTable.PrimaryKey = New DataColumn() {spaceObjectsTable.Columns("ObjectId")}
                treeList1.DataSource = spaceObjectsTable
                treeList1.KeyFieldName = "ObjectId"
                treeList1.ParentFieldName = "ParentId"
                treeList1.ExpandAll()
            End If
        End Sub
    End Class
End Namespace
