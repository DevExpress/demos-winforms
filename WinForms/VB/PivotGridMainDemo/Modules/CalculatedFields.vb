Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class CalculatedFields
        Inherits TutorialControl

        Private hoverField As PivotGridField = Nothing

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            pivotGridControl.BeginUpdate()
            fieldYear.FilterValues.SetValues(New Object() {2015}, PivotFilterType.Included, False)
            checkExpression.Checked = True
            SetUpYearEndBonus()
            SetUpQuantityBonus()
            pivotGridControl.EndUpdate()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Private Sub CalculatedFields_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.DataSource = GetData()
            pivotGridControl.HeaderImages = HeadersImageList
            fieldSalesPerson.ImageIndex = 0
        End Sub

        Private Function GetData() As List(Of SalesDataRow)
            Dim orders As Dictionary(Of Integer, DataRowView) = GetNWindData("Orders").Cast(Of DataRowView)().ToDictionary(Function(s) CInt(s("OrderID")), Function(s) s)
            Dim employees As Dictionary(Of Integer, DataRowView) = GetNWindData("Employees").Cast(Of DataRowView)().ToDictionary(Function(s) CInt(s("EmployeeID")), Function(s) s)
            Return GetNWindData("Order Details").Cast(Of DataRowView)().[Select](Function(s) CreateSalesDataRow(s, orders, employees)).ToList()
        End Function

        Private Shared Function CreateSalesDataRow(ByVal order As DataRowView, ByVal orders As Dictionary(Of Integer, DataRowView), ByVal employees As Dictionary(Of Integer, DataRowView)) As SalesDataRow
            Dim orderId As Integer = CInt(order("OrderID"))
            Dim employeeID As Integer = CInt(orders(orderId)("EmployeeID"))
            Dim employee As DataRowView = employees(employeeID)
            Return New SalesDataRow With {.OrderID = CInt(order("OrderID")), .UnitPrice = CDec(order("UnitPrice")), .Quantity = CShort(order("Quantity")), .OrderDate = CDate(orders(orderId)("OrderDate")), .LastName = CStr(employee("LastName")), .FirstName = CStr(employee("FirstName")), .EmployeeID = CInt(employee("EmployeeID"))}
        End Function

        Public Class SalesDataRow

            Public Property EmployeeID As Integer

            Public Property OrderID As Integer

            Public Property UnitPrice As Decimal

            Public Property Quantity As Short

            Public Property OrderDate As Date

            Public Property FirstName As String

            Public Property LastName As String
        End Class

        '<checkDataSourceValue>
        Private Sub checkDataSourceValueOnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not checkDataSourceValue.Checked Then Return
            fieldSalesPerson.DataBinding = New DataSourceColumnBinding("EmployeeID")
            pivotGridControl.RefreshData()
        End Sub

        '</checkDataSourceValue>
        '<checkDisplayText>
        Private Sub checkDisplayTextOnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not checkDisplayText.Checked Then Return
            fieldSalesPerson.DataBinding = New DataSourceColumnBinding("EmployeeID")
            pivotGridControl.RefreshData()
        End Sub

        Private Sub pivotGridControlOnFieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If Not checkDisplayText.Checked Then Return
            If e.Field Is fieldSalesPerson Then
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                e.DisplayText = String.Format("{0} {1} ({2})", ds(0)("FirstName"), ds(0)("LastName"), e.Value.ToString())
            End If
        End Sub

        '</checkDisplayText>
        '<checkExpression>
        Private Sub checkExpressionOnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not checkExpression.Checked Then Return
            fieldSalesPerson.DataBinding = New ExpressionDataBinding(String.Format("Concat([{0}], ' ', [{1}], ' (', [{2}], ')')", fieldFirstName.Name, fieldLastName.Name, fieldEmployeeID.Name))
            fieldSalesPerson.Options.ShowExpressionEditorMenu = True
            fieldSalesPerson.FieldName = "4"
            pivotGridControl.RefreshData()
        End Sub

        '</checkExpression>
        '<checkYearEndBonus>
        Private Sub SetUpYearEndBonus()
            fieldYearEndBonus.Options.ShowExpressionEditorMenu = True
            checkYearEndBonus.Checked = True
        End Sub

        Private Sub checkYearEndBonusOnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldYearEndBonus.Visible = checkYearEndBonus.Checked
            If fieldYearEndBonus.Visible Then
                fieldYearEndBonus.DataBinding = New ExpressionDataBinding(String.Format("Iif( Max([{0}]) == 4 And Min([{0}]) == 4, Iif(Sum([{1}]) > 40000, 600, 400), 0)", fieldQuarter.Name, fieldExtendedPrice.Name))
            Else
                fieldYearEndBonus.DataBinding = New ExpressionDataBinding("0")
            End If
        End Sub

        '</checkYearEndBonus>
        '<checkQuantityBonus>
        Private Sub SetUpQuantityBonus()
            fieldQuantityBonus.Options.ShowExpressionEditorMenu = True
            checkQuantityBonus.Checked = True
        End Sub

        Private Sub checkQuantityBonusOnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            fieldQuantityBonus.Visible = checkQuantityBonus.Checked
            If fieldQuantityBonus.Visible Then
                fieldQuantityBonus.DataBinding = New ExpressionDataBinding(String.Format("Iif([{0}] > 100, [{1}] * 0.1, 0)", fieldQuantity.Name, fieldExtendedPrice.Name))
            Else
                fieldQuantityBonus.DataBinding = New ExpressionDataBinding("0")
            End If
        End Sub

        '</checkQuantityBonus>
        '<pivotGridControl>
        Private Sub pivotGridControlOnCellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
            Try
                Using form As DrillDownForm = New DrillDownForm(e.CreateDrillDownDataSource())
                    form.ShowDialog()
                End Using
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
        End Sub

        '</pivotGridControl>
        '<btnAddBonus>
        Private Sub buttonAddNewBonusOnClick(ByVal sender As Object, ByVal e As EventArgs)
            Using addNewBonus As AddNewBonus = New AddNewBonus()
                addNewBonus.PivotGrid = pivotGridControl
                addNewBonus.ShowDialog()
            End Using
        End Sub

        '</btnAddBonus>
        Private Function NeedHighlightField(ByVal field As PivotGridField) As Boolean
            If field IsNot Nothing AndAlso TypeOf field.DataBinding Is ExpressionDataBinding AndAlso field.Options.ShowExpressionEditorMenu Then Return True
            Return False
        End Function

        Private Sub pivotGridControlOnMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim info As PivotGridHitInfo = pivotGridControl.CalcHitInfo(New Point(e.X, e.Y))
            If info.ValueInfo IsNot Nothing AndAlso NeedHighlightField(info.ValueInfo.Field) AndAlso info.ValueInfo.Field.Area = PivotArea.DataArea Then
                hoverField = info.ValueInfo.Field
                pivotGridControl.Cursor = Cursors.Hand
            ElseIf info.HitTest = PivotGridHitTest.HeadersArea AndAlso NeedHighlightField(info.HeaderField) Then
                hoverField = info.HeaderField
                pivotGridControl.Cursor = Cursors.Hand
            Else
                hoverField = Nothing
                pivotGridControl.Cursor = Cursors.Default
            End If

            pivotGridControl.Invalidate()
        End Sub

        Private Sub pivotGridControlOnCustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs)
            If NeedHighlightField(e.Field) AndAlso e.Field.Area = PivotArea.DataArea Then
                If e.Field Is hoverField Then
                    e.Appearance.FontStyleDelta = FontStyle.Underline Or FontStyle.Bold
                Else
                    e.Appearance.FontStyleDelta = FontStyle.Bold
                End If
            Else
                e.DefaultDraw()
            End If
        End Sub

        Private Sub pivotGridControlOnCustomDrawFieldHeader(ByVal sender As Object, ByVal e As PivotCustomDrawFieldHeaderEventArgs)
            If NeedHighlightField(e.Field) Then
                If e.Field Is hoverField Then
                    e.Appearance.FontStyleDelta = FontStyle.Underline Or FontStyle.Bold
                Else
                    e.Appearance.FontStyleDelta = FontStyle.Bold
                End If
            Else
                e.DefaultDraw()
            End If
        End Sub

        Private Sub pivotGridControlOnMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then Return
            Dim info As PivotGridHitInfo = pivotGridControl.CalcHitInfo(New Point(e.X, e.Y))
            If info.ValueInfo IsNot Nothing AndAlso NeedHighlightField(info.ValueInfo.Field) AndAlso info.ValueInfo.Field.Area = PivotArea.DataArea Then
                pivotGridControl.ShowExpressionEditor(info.ValueInfo.Field)
            ElseIf NeedHighlightField(info.HeaderField) Then
                pivotGridControl.ShowExpressionEditor(info.HeaderField)
            End If
        End Sub

        Private Sub pivotGridControlOnPopupMenuShowing(ByVal sender As Object, ByVal args As PopupMenuShowingEventArgs)
            If args.HitInfo.ValueInfo IsNot Nothing Then
                Dim removedField As PivotGridField = args.HitInfo.ValueInfo.Field
                If removedField IsNot Nothing AndAlso Equals(removedField.Tag, "removable") Then
                    Dim item As DXMenuItem = New DXMenuItem("Remove this bonus")
                    AddHandler item.Click, Sub(s, e) pivotGridControl.Fields.Remove(removedField)
                    item.BeginGroup = True
                    args.Menu.Items.Add(item)
                End If
            End If
        End Sub
    End Class
End Namespace
