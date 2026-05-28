Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class FindFilter
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            ucFindOptions1.InitData(gridView1, GetColumn(gridView1.VisibleColumns))
            gridView1.FindFilterText = "ana tr"
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"FindFilter", "ucFindOptions"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "FindFilter"
            End Get
        End Property

        Private Function GetColumn(ByVal gridColumnReadOnlyCollection As Columns.GridColumnReadOnlyCollection) As List(Of ImageComboBoxItem)
            Dim ret As List(Of ImageComboBoxItem) = New List(Of ImageComboBoxItem)()
            ret.Add(New ImageComboBoxItem("*", "*"))
            For i As Integer = 0 To gridColumnReadOnlyCollection.Count - 1
                Dim columns As String = gridColumnReadOnlyCollection(i).GetCaption()
                Dim fields As String = gridColumnReadOnlyCollection(i).FieldName
                For j As Integer = i To gridColumnReadOnlyCollection.Count - 1
                    If j <> i Then
                        columns += String.Format(";{0}", gridColumnReadOnlyCollection(j).GetCaption())
                        fields += String.Format(";{0}", gridColumnReadOnlyCollection(j).FieldName)
                    End If

                    ret.Add(New ImageComboBoxItem(columns, fields, -1))
                Next
            Next

            Return ret
        End Function

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            SetWaitDialogCaption(Properties.Resources.LoadingCustomers)
            dataSet.ReadXml(dataFileName)
            gridControl1.DataSource = dataSet.Tables("Customers")
            Return dataSet
        End Function

        Private Sub gridView1_FilterEditorCreated(ByVal sender As Object, ByVal e As Views.Base.FilterControlEventArgs)
            e.FilterControl.MaxOperandsCount = 5
        End Sub
    End Class
End Namespace
