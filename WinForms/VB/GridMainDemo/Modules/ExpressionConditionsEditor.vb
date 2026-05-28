Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ExpressionEditor
Imports DevExpress.XtraEditors.ListControls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Internal
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ExpressionConditionsEditor
        Inherits XtraUserControl

        Private _init As Boolean = False

        Private view As GridView = Nothing

        Public Sub New()
            InitializeComponent()
        End Sub

        Private panel As FilterPanel

        Public Sub Init(ByVal view As GridView)
            Me.view = view
            panel = New FilterPanel(view)
            InitConditions()
            InitColumns()
            If FormatItemList.Items.Count > 0 Then FormatItemList.SelectedIndex = 0
            AddHandler FormatItemList.MeasureItem, AddressOf FormatItemList_MeasureItem
            AddHandler FormatItemList.DrawItem, AddressOf FormatItemList_DrawItem
        End Sub

        Private Sub FormatItemList_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
            Dim exprItem = TryCast(e.Item, ItemExpressionFormatRule)
            Dim criteria = CriteriaOperator.TryParse(exprItem.Rule.Expression)
            Dim padding As Padding = GetPadding(e.Cache)
            Dim content = New Rectangle(e.Bounds.X + padding.Left, e.Bounds.Y + padding.Top, e.Bounds.Width - padding.Horizontal, e.Bounds.Height - padding.Vertical)
            e.DrawItemBackground()
            panel.DrawItem(e, criteria, content)
            e.Handled = True
        End Sub

        Private Sub FormatItemList_MeasureItem(ByVal sender As Object, ByVal e As MeasureItemEventArgs)
            Dim args = TryCast(e, ListBoxMeasureItemEventArgs)
            Dim exprItem = TryCast(FormatItemList.Items(args.Index), ItemExpressionFormatRule)
            Dim criteria = CriteriaOperator.TryParse(exprItem.Rule.Expression)
            Dim itemSize = panel.MeasureItem(args.Cache, criteria)
            Dim padding As Padding = GetPadding(args.Cache)
            e.ItemHeight = itemSize.Height + padding.Vertical
            e.ItemWidth = itemSize.Width + padding.Horizontal
        End Sub

        Private Function GetPadding(ByVal cache As GraphicsCache) As Padding
            Return cache.ScaleDPI.ScalePadding(New Padding(4, 1, 4, 1))
        End Function

        Private Sub InitColumns()
            If view Is Nothing Then Return
            For Each col As GridColumn In view.Columns
                imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem(col.GetTextCaption(), col, -1))
            Next
        End Sub

        Private Sub InitConditions()
            If view Is Nothing Then Return
            FormatItemList.BeginUpdate()
            Try
                FormatItemList.Items.Clear()
                For Each condition As GridFormatRule In view.FormatRules
                    Dim eCondition As ItemExpressionFormatRule = New ItemExpressionFormatRule(condition)
                    If eCondition.IsExpressionCondition Then
                        FormatItemList.Items.Add(eCondition)
                    End If
                Next
            Finally
                FormatItemList.EndUpdate()
            End Try
        End Sub

        Private ReadOnly Property CurrentCondition As GridFormatRule
            Get
                If FormatItemList.SelectedItem IsNot Nothing Then Return CType(FormatItemList.SelectedItem, ItemExpressionFormatRule).GridFormatRule
                Return Nothing
            End Get
        End Property

        Private Sub ShowEditor(ByVal condition As GridFormatRule)
            Dim rule As FormatConditionRuleExpression = TryCast(condition.Rule, FormatConditionRuleExpression)
            If rule Is Nothing Then Return
            Dim context = New GridColumnIDataColumnInfoWrapper(view.Columns(0), GridColumnIDataColumnInfoWrapperEnum.ExpressionEditor)
            Dim expressionString As String = rule.Expression
            If ExpressionEditorHelper.RunExpressionEditor(expressionString, context, LookAndFeel, view.GridControl.MenuManager, True) Then rule.Expression = expressionString
        End Sub

        Private Sub ShowEditor()
            If CurrentCondition Is Nothing Then Return
            ShowEditor(CurrentCondition)
            CType(FormatItemList, Utils.IContextItemCollectionOwner).OnCollectionChanged()
        End Sub

        Private Sub FormatItemList_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            ShowEditor()
        End Sub

        Private Sub SelectObjectUpdate()
            If _updating Then Return
            EnableButtons()
            _init = True
            If CurrentCondition Is Nothing Then
                propertyGrid1.Enabled = False
                propertyGrid1.SelectedObject = Nothing
            Else
                propertyGrid1.Enabled = True
                propertyGrid1.SelectedObject = CType(CurrentCondition.Rule, FormatConditionRuleExpression).Appearance
                checkEdit1.Checked = CurrentCondition.ApplyToRow
                imageComboBoxEdit1.EditValue = CurrentCondition.Column
            End If

            _init = False
        End Sub

        Private Sub FormatItemList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SelectObjectUpdate()
        End Sub

        Private Sub EnableButtons()
            btnDelete.Enabled = CurrentCondition IsNot Nothing
            btnEdit.Enabled = CurrentCondition IsNot Nothing
        End Sub

        Private _updating As Boolean = False

        '<checkEdit1>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentCondition Is Nothing OrElse _init Then Return
            CurrentCondition.ApplyToRow = checkEdit1.Checked
        End Sub

        '</checkEdit1>
        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentCondition Is Nothing OrElse _init Then Return
            Dim col As GridColumn = TryCast(imageComboBoxEdit1.EditValue, GridColumn)
            CurrentCondition.Column = col
        End Sub

        Private Sub propertyGrid1_CustomRecordCellEdit(ByVal sender As Object, ByVal e As XtraVerticalGrid.Events.GetCustomRowCellEditEventArgs)
            If e.Row.Properties.RowType.Equals(GetType(Color)) Then
                e.RepositoryItem = repositoryItemColorPickEdit1
            End If
        End Sub

        '<FormatItemList>
        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim condition As GridFormatRule = New GridFormatRule()
            condition.Rule = New FormatConditionRuleExpression()
            view.FormatRules.Add(condition)
            Dim index As Integer = FormatItemList.Items.Count
            InitConditions()
            FormatItemList.SelectedIndex = index
            ShowEditor()
        End Sub

        Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
            _updating = True
            If CurrentCondition Is Nothing Then Return
            view.FormatRules.Remove(CurrentCondition)
            FormatItemList.Items.RemoveAt(FormatItemList.SelectedIndex)
            _updating = False
            SelectObjectUpdate()
        End Sub

        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            ShowEditor()
        End Sub
    '</FormatItemList>
    End Class
End Namespace
