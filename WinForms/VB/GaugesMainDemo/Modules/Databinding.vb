Imports DevExpress.Internal

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class Databinding
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitData()
        End Sub

        Protected Sub InitData()
            Dim dbFileName As String = DevAVDataDirectoryHelper.GetFile("nwind.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then
                SetWaitDialogCaption("Loading Products...")
                Dim ds = New System.Data.DataSet()
                ds.ReadXml(dbFileName)
                ' datasource for runtime
                productsBindingSource.DataSource = ds.Tables("Products")
            End If
        End Sub
    End Class
End Namespace
