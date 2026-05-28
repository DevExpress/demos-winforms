Imports System
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.AI.Demos

    Public Partial Class PromptToExpressionAIModule
        Inherits AITutorialControl

        Private colTotalCost As GridColumn

        Public Sub New()
            InitializeComponent()
            InitGridControl()
            UpdatePaddings()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Private Sub InitGridControl()
            gridControl1.DataSource = PromptToExpressionDataHelper.GetData(30)
            colTotalCost = New GridColumn()
            colTotalCost.Caption = "Total ($)"
            colTotalCost.FieldName = "Total"
            colTotalCost.DisplayFormat.FormatType = Utils.FormatType.Numeric
            colTotalCost.DisplayFormat.FormatString = "c2"
            colTotalCost.UnboundDataType = GetType(Single)
            colTotalCost.UnboundExpression = "[OrderCost] + [ShippingCost] - [Discount]"
            colTotalCost.AppearanceHeader.Font = New Font(colTotalCost.AppearanceHeader.Font, FontStyle.Bold)
            colTotalCost.Visible = True
            colTotalCost.ShowUnboundExpressionMenu = True
            gridView1.Columns.Add(colTotalCost)
        End Sub

        Private Sub sbFilterEditor_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.ShowFilterEditor(Nothing)
        End Sub

        Private Sub sbExpressionEditor_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.ShowUnboundExpressionEditor(colTotalCost)
        End Sub

        Private Sub gridControl1_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.BestFitColumns()
        End Sub

        Private Class ShippingRecord

            Public Property TrackingID As Integer

            <DisplayName("Initial Delivery Date")>
            Public Property EstimatedDeliveryDate As Date

            <DisplayName("Updated Delivery Date")>
            Public Property UpdatedDeliveryDate As Date

            <DataType(DataType.Currency)>
            <DisplayName("Order Cost ($)")>
            Public Property OrderCost As Single

            <DataType(DataType.Currency)>
            <DisplayName("Shipping Cost ($)")>
            Public Property ShippingCost As Single

            <DataType(DataType.Currency)>
            <DisplayName("Discount ($)")>
            Public Property Discount As Single
        End Class

        Private Class PromptToExpressionDataHelper

            Public Shared Function GetData(ByVal count As Integer) As BindingList(Of ShippingRecord)
                Dim records As BindingList(Of ShippingRecord) = New BindingList(Of ShippingRecord)()
                Dim dateTime As Date = TutorialConstants.Today
                For i As Integer = 0 To count - 1
                    Dim n As Integer = TutorialConstants.Random.Next(10)
                    Dim doubleOrderCost As Double = TutorialConstants.Random.NextDouble()
                    Dim shippingCost As Double = TutorialConstants.Random.NextDouble()
                    Dim record = New ShippingRecord() With {.TrackingID = i + 1000, .EstimatedDeliveryDate = dateTime.AddDays(-(n Mod 3)), .UpdatedDeliveryDate = dateTime.AddDays(n Mod 9 - 2), .OrderCost = CSng(doubleOrderCost * 500 + 50), .ShippingCost = CSng(shippingCost * 50 + 10), .Discount = If(i Mod 3 = 0, 10, 0)}
                    records.Add(record)
                Next

                Return records
            End Function
        End Class
    End Class
End Namespace
