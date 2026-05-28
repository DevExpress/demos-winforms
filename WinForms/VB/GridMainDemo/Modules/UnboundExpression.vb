Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class UnboundExpression
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        '<gridControl1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' 
        ' ~Discount Amount column:
        ' gridColumn7.OptionsColumn.AllowEdit = false;
        ' gridColumn7.ShowUnboundExpressionMenu = true;
        ' gridColumn7.UnboundExpression = "[UnitPrice] * [Quantity] - [Total]";
        ' gridColumn7.UnboundDataType = typeof(decimal);
        ' 
        ' ~Total column:
        ' gridColumn6.OptionsColumn.AllowEdit = false;
        ' gridColumn6.ShowUnboundExpressionMenu = true;
        ' gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])";
        ' gridColumn6.UnboundDataType = typeof(decimal);
        ' 
        '</gridControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"UnboundExpression"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "UnboundExpression"
            End Get
        End Property

        Private Sub UnboundExpression_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitNWindData()
            InitCombo()
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub InitCombo()
            For Each column As GridColumn In gridView1.Columns
                If column.ShowUnboundExpressionMenu Then imageListBoxControl1.Items.Add(New ImageListBoxItem(column, column.GetTextCaption(), column.ImageIndex))
            Next

            imageListBoxControl1.SelectedIndex = 0
        End Sub

        Private tblGrid As String = "Order Details"

        Private tblLookUp As String = "Products"

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            Return ds
        End Function

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridControl1.MainView
            End Get
        End Property

        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim column As GridColumn = TryCast(imageListBoxControl1.SelectedValue, GridColumn)
            If column Is Nothing Then Return
            gridView1.ShowUnboundExpressionEditor(column)
        End Sub

        '</simpleButton1>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
