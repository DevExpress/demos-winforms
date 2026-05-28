Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.Internal
Imports DevExpress.XtraLayout.Demos.Modules

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class LayoutPrinting
        Inherits DragDropLayoutControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not Equals(DBFileName, "") Then dsCategories.ReadXml(DBFileName, XmlReadMode.InferSchema)
        End Sub

        Private Sub LayoutPrinting_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not DesignMode Then InitData()
        End Sub
    End Class
End Namespace
