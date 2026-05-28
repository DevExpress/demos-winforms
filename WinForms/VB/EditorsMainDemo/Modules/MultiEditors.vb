Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraEditors.Demos

    ''' <summary>
    ''' Summary description for MultiEditors.
    ''' </summary>
    Public Partial Class MultiEditors
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            gridView1.OptionsMenu.ShowAutoFilterRowItem = False
            'TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\MultiEditors.cs";
            'TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.MultiEditors.xml";
            gridControl1.ForceInitialize()
            InitData()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

#Region "Init"
        Private Function ImageToByteArray(ByVal image As Image) As Byte()
            Dim mStream As IO.MemoryStream = New IO.MemoryStream()
            image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim ret As Byte() = mStream.ToArray()
            mStream.Close()
            Return ret
        End Function

        Private Sub InitData()
            Dim records As RecordOrder() = New RecordOrder(9) {}
            records(0) = New RecordOrder(Properties.Resources.ProductName, "Mishi Kobe Niku", "Teatime Chocolate Biscuits", "Ipoh Coffee")
            records(1) = New RecordOrder(Properties.Resources.Category, 6, 3, 1)
            records(2) = New RecordOrder(Properties.Resources.Supplier, "Tokyo Traders", "Specialty Biscuits, Ltd.", "Leka Trading")
            records(3) = New RecordOrder(Properties.Resources.QuantityPerUnit, "18 - 500 g pkgs.", "10 boxes x 12 pieces", "16 - 500 g tins")
            records(4) = New RecordOrder(Properties.Resources.UnitPrice, 97.00, 9.20, 46.00)
            records(5) = New RecordOrder(Properties.Resources.UnitsInStock, 29, 25, 17)
            records(6) = New RecordOrder(Properties.Resources.Discontinued, False, True, True)
            records(7) = New RecordOrder(Properties.Resources.LastOrder, New DateTime(2001, 12, 14), New DateTime(2003, 7, 20), New DateTime(2002, 1, 7))
            records(8) = New RecordOrder(Properties.Resources.Picture, Properties.Resources.product1, Properties.Resources.product2, Properties.Resources.product3)
            records(9) = New RecordOrder(Properties.Resources.Relevance, 70, 90, 50)
            gridControl1.DataSource = records
        End Sub

#End Region
#Region "Grid events"
        '<gridControl1>
        Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.CustomRowCellEditEventArgs)
            If Not Equals(e.Column.FieldName, "Category") Then
                Dim rec As RecordOrder = TryCast(gridView1.GetRow(e.RowHandle), RecordOrder)
                If Equals(rec.Category, Properties.Resources.Category) Then e.RepositoryItem = repositoryItemImageComboBox1
                If Equals(rec.Category, Properties.Resources.Supplier) Then e.RepositoryItem = repositoryItemComboBox1
                If Equals(rec.Category, Properties.Resources.UnitPrice) Then e.RepositoryItem = repositoryItemCalcEdit1
                If Equals(rec.Category, Properties.Resources.UnitsInStock) Then e.RepositoryItem = repositoryItemSpinEdit1
                If Equals(rec.Category, Properties.Resources.Discontinued) Then e.RepositoryItem = repositoryItemCheckEdit1
                If Equals(rec.Category, Properties.Resources.Discontinued) Then e.RepositoryItem = repositoryItemCheckEdit1
                If Equals(rec.Category, Properties.Resources.LastOrder) Then e.RepositoryItem = repositoryItemDateEdit1
                If Equals(rec.Category, Properties.Resources.Picture) Then e.RepositoryItem = repositoryItemPictureEdit1
                If Equals(rec.Category, Properties.Resources.Relevance) Then e.RepositoryItem = repositoryItemProgressBar1
            End If
        End Sub

        '</gridControl1>
        Private Sub gridView1_RowCellDefaultAlignment(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.RowCellAlignmentEventArgs)
            If Not Equals(e.Column.FieldName, "Category") Then
                If e.RowHandle = 4 OrElse e.RowHandle = 5 Then e.HorzAlignment = Utils.HorzAlignment.Far
                If e.RowHandle = 9 Then e.HorzAlignment = Utils.HorzAlignment.Center
            End If
        End Sub

        '<gridControl1>
        ' 
        ' ~Set custom height for row 8:
        ' 
        Private Sub gridView1_CalcRowHeight(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowHeightEventArgs)
            If e.RowHandle = 8 Then e.RowHeight = 150
        End Sub

        '</gridControl1>
#End Region
#Region "RepositoryItems events"
        Private Sub repositoryItemProgressBar1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            Dim i As Integer = 0
            If gridView1.ActiveEditor Is Nothing Then Return
            If e.KeyChar = "+"c Then
                i = CInt(gridView1.ActiveEditor.EditValue)
                If i < 100 Then gridView1.ActiveEditor.EditValue = i + 1
            End If

            If e.KeyChar = "-"c Then
                i = CInt(gridView1.ActiveEditor.EditValue)
                If i > 0 Then gridView1.ActiveEditor.EditValue = i - 1
            End If
        End Sub
#End Region
    End Class
End Namespace
