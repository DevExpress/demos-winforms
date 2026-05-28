Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for ConditionsItem.
    ''' </summary>
    Public Partial Class ConditionsItem
        Inherits XtraUserControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            InitializeComponent()
            propertyGrid1.ShowDescription = False
            propertyGrid1.ShowCategories = propertyGrid1.ShowDescription
            propertyGrid1.ShowButtons = propertyGrid1.ShowCategories
            BackColor = Color.Transparent
            InitConditions()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Private be1 As BaseEdit = Nothing

        Private be2 As BaseEdit = Nothing

        Private item As GridFormatRule = Nothing

        Private init As Boolean = False

        Public Event RefreshValues As EventHandler

        Private ReadOnly Property Rule As FormatConditionRuleValue
            Get
                If item Is Nothing Then Return Nothing
                Return TryCast(item.Rule, FormatConditionRuleValue)
            End Get
        End Property

        Private Sub InitConditions()
            For Each mode As FormatCondition In [Enum].GetValues(GetType(FormatCondition))
                If mode = FormatCondition.Expression Then Continue For
                icbCondition.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FormatCondition).GetTitle(mode), mode, -1))
            Next
        End Sub

        Private Sub SetCheckEditStyle(ByVal be As BaseEdit, ByVal s As String)
            Dim ce As CheckEdit = CType(be, CheckEdit)
            ce.Properties.AllowGrayed = True
            ce.Text = s
        End Sub

        Private Sub SetSpinStyle(ByVal be As BaseEdit, ByVal type As Type)
            Dim se As SpinEdit = CType(be, SpinEdit)
            If "System.Int16System.Int32System.Int64System.Byte".IndexOf(type.ToString()) > -1 Then se.Properties.IsFloatValue = False
        End Sub

        Private Sub CreateValues(ByVal type As Type)
            If type.Equals(GetType(Boolean)) Then
                be1 = New CheckEdit()
                be2 = New CheckEdit()
                SetCheckEditStyle(be1, String.Format("{0}1", Properties.Resources.Value))
                SetCheckEditStyle(be2, String.Format("{0}2", Properties.Resources.Value))
                lbVal2.Visible = False
                lbVal1.Visible = lbVal2.Visible
            ElseIf type.IsValueType Then
                be1 = New SpinEdit()
                be2 = New SpinEdit()
                SetSpinStyle(be1, type)
                SetSpinStyle(be2, type)
            Else
                be1 = New TextEdit()
                be2 = New TextEdit()
            End If

            be2.Size = New Size(icbCondition.Width, icbCondition.Height)
            be1.Size = be2.Size
            If type.Equals(GetType(Boolean)) Then
                be1.Location = lbVal1.Location
                be2.Location = lbVal2.Location
            Else
                be1.Location = New Point(icbCondition.Location.X, lbVal1.Location.Y)
                be2.Location = New Point(icbCondition.Location.X, lbVal2.Location.Y)
            End If

            AddHandler be1.Validated, New EventHandler(AddressOf val1_Validate)
            AddHandler be2.Validated, New EventHandler(AddressOf val2_Validate)
            be1.TabIndex = 2
            be2.TabIndex = 3
            Me.Controls.Add(be1)
            Me.Controls.Add(be2)
        End Sub

        Public Sub InitItem(ByVal item As GridFormatRule)
            Me.item = item
            init = True
            Dim IsNull As Boolean = item Is Nothing
            If Not IsNull Then
                If be1 Is Nothing Then CreateValues(item.Column.ColumnType)
                ceRow.Checked = item.ApplyToRow
                propertyGrid1.PropertyGrid.SelectedObject = Rule.Appearance
                icbCondition.EditValue = Rule.Condition
                be1.EditValue = Rule.Value1
                be2.EditValue = Rule.Value2
            End If

            icbCondition.Enabled = Not IsNull
            ceRow.Enabled = icbCondition.Enabled
            If be1 IsNot Nothing Then
                be2.Visible = Not IsNull
                be1.Visible = be2.Visible
            End If

            If IsNull Then propertyGrid1.PropertyGrid.SelectedObject = Nothing
            init = False
        End Sub

        Private Sub RaiseRefreshValues()
            RaiseEvent RefreshValues(Me, EventArgs.Empty)
        End Sub

        Private Sub icbCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If init OrElse item Is Nothing Then Return
            Rule.Condition = CType(icbCondition.EditValue, FormatCondition)
            RaiseRefreshValues()
        End Sub

        Private Sub ceRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If init OrElse item Is Nothing Then Return
            item.ApplyToRow = ceRow.Checked
        End Sub

        Private Sub SetValue(ByVal value1 As Boolean, ByVal val As Object)
            Try
                If val IsNot Nothing Then val = Convert.ChangeType(val, item.Column.ColumnType)
                If value1 Then
                    Rule.Value1 = val
                Else
                    Rule.Value2 = val
                End If
            Catch
            End Try

            init = True
            If value1 Then
                be1.EditValue = Rule.Value1
            Else
                be2.EditValue = Rule.Value2
            End If

            init = False
            RaiseRefreshValues()
        End Sub

        Private Sub val1_Validate(ByVal sender As Object, ByVal e As EventArgs)
            If init OrElse item Is Nothing Then Return
            SetValue(True, be1.EditValue)
        End Sub

        Private Sub val2_Validate(ByVal sender As Object, ByVal e As EventArgs)
            If init OrElse item Is Nothing Then Return
            SetValue(False, be2.EditValue)
        End Sub
    End Class
End Namespace
