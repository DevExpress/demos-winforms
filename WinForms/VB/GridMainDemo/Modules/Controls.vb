Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos

    Public Class DemosHelper

        Public Shared Sub ShowDescriptionForm(ByVal location As System.Drawing.Point, ByVal description As String, ByVal caption As String)
            Using frm As XtraForm = New XtraForm()
                Dim tb As TextBox = New TextBox()
                tb.Multiline = True
                tb.Dock = DockStyle.Fill
                tb.ScrollBars = ScrollBars.Vertical
                tb.Text = description
                tb.SelectionLength = 0
                frm.Controls.Add(tb)
                frm.FormBorderStyle = FormBorderStyle.FixedToolWindow
                frm.Text = caption
                frm.ShowInTaskbar = False
                frm.StartPosition = FormStartPosition.Manual
                frm.Location = Utils.ControlUtils.CalcLocation(location, location, frm.Size)
                frm.ShowDialog()
            End Using
        End Sub
    End Class

    Public Class MyGridView
        Inherits GridView

        Public Shared Function IsCondition(ByVal column As GridColumn) As Boolean
            If column Is Nothing Then Return False
            For Each c As StyleFormatCondition In column.View.FormatConditions
                If c.Column.Equals(column) Then Return True
            Next

            Return False
        End Function

        Public Sub SetIcons()
            For Each column As GridColumn In Columns
                column.ImageIndex = If(IsCondition(column), 0, -1)
            Next
        End Sub

        Protected Overrides Sub ApplyColumnFilter(ByVal column As GridColumn, ByVal listBoxItem As FilterItem)
            If listBoxItem Is Nothing Then Return
            If Equals(listBoxItem.Text, Properties.Resources.ConditionsName) Then
                Dim editor As ConditionsEditor = New ConditionsEditor(column, column.View.GridControl.FindForm())
                editor.ShowDialog()
                SetIcons()
            Else
                MyBase.ApplyColumnFilter(column, listBoxItem)
            End If
        End Sub
    End Class

    Public Class ItemFormatRule

        Private gridFormatRule As GridFormatRule

        Public Sub New(ByVal gridFormatRule As GridFormatRule)
            Me.gridFormatRule = gridFormatRule
        End Sub

        Public ReadOnly Property Rule As FormatConditionRuleValue
            Get
                Return TryCast(gridFormatRule.Rule, FormatConditionRuleValue)
            End Get
        End Property

        Public Overrides Function ToString() As String
            If Rule.Condition <> FormatCondition.None Then
                If Rule.Condition = FormatCondition.Between OrElse Rule.Condition = FormatCondition.NotBetween Then
                    Return String.Format("{0} {1}, {2}", Rule.Condition, Rule.Value1, Rule.Value2)
                Else
                    Return String.Format("{0} {1}", Rule.Condition, Rule.Value1)
                End If
            End If

            Return String.Format(Properties.Resources.ConditionItemCaption, Index)
        End Function

        Public ReadOnly Property Index As Integer
            Get
                Return gridFormatRule.Column.View.FormatRules.IndexOf(gridFormatRule)
            End Get
        End Property

        Public ReadOnly Property Condition As GridFormatRule
            Get
                Return gridFormatRule
            End Get
        End Property
    End Class

    Public Class ItemExpressionFormatRule

        Private gridFormatRuleCore As GridFormatRule

        Public Sub New(ByVal gridFormatRule As GridFormatRule)
            gridFormatRuleCore = gridFormatRule
        End Sub

        Public ReadOnly Property Rule As FormatConditionRuleExpression
            Get
                Return TryCast(gridFormatRuleCore.Rule, FormatConditionRuleExpression)
            End Get
        End Property

        Public ReadOnly Property IsExpressionCondition As Boolean
            Get
                Return Rule IsNot Nothing
            End Get
        End Property

        Public Overrides Function ToString() As String
            If Not IsExpressionCondition Then Return MyBase.ToString()
            If String.IsNullOrEmpty(Rule.Expression) Then Return String.Format(Properties.Resources.EmptyConditionCaption, Index)
            Return Rule.Expression
        End Function

        Public ReadOnly Property Index As Integer
            Get
                Return gridFormatRuleCore.Collection.IndexOf(gridFormatRuleCore)
            End Get
        End Property

        Public ReadOnly Property GridFormatRule As GridFormatRule
            Get
                Return gridFormatRuleCore
            End Get
        End Property
    End Class
End Namespace
