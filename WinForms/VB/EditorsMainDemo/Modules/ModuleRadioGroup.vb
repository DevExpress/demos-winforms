Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
' <comboGlyphAlign>
Imports DevExpress.Utils
' </comboGlyphAlign>
' <btnPopulateItems>
Imports DevExpress.XtraEditors.Controls

' </btnPopulateItems>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleRadioGroup
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            radioGroupSample.AutoSizeInLayoutControl = True
            AddHandler tabPane1.SizeChanged, Sub(s, e) UpdateLayout()
            AddHandler tabPane1.SelectedPageChanged, Sub(s, e) UpdateLayout()
            AddHandler comboItemAlign.EditValueChanged, AddressOf comboItemAlign_EditValueChanged
            comboItemAlign.Properties.Items.AddRange([Enum].GetValues(GetType(RadioItemHorzAlignment)))
            comboItemAlign.Properties.Items.Remove(RadioItemHorzAlignment.Justify)
            comboItemAlign.EditValue = RadioItemHorzAlignment.Center
            InitPageNavigation()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleRadioGroup"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "radioGroup"
            End Get
        End Property

        ' <radioGroupPager>
        Private Sub InitPageNavigation()
            radioGroupPager.BackColor = Color.Transparent
            radioGroupPager.Properties.BorderStyle = BorderStyles.NoBorder
            radioGroupPager.Properties.ItemsLayout = RadioGroupItemsLayout.Flow
            TryCast(radioGroupPager, IPagerControl).PageNavigationClient = tileBar1
        End Sub

        ' </radioGroupPager>
        ' <comboItemAlign>
        Private Sub comboItemAlign_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            radioGroupPager.Properties.ItemHorzAlignment = CType(comboItemAlign.EditValue, RadioItemHorzAlignment)
        End Sub

        ' </comboItemAlign>
        Private updateValues As Boolean = False

        ' <btnSelectNext>
        Private Sub btnSelectNext_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentSelectedIndex As Integer = radioGroupSample.SelectedIndex
            currentSelectedIndex += 1
            If currentSelectedIndex = radioGroupSample.Properties.Items.Count Then currentSelectedIndex = 0
            radioGroupSample.SelectedIndex = currentSelectedIndex
        End Sub

        ' </btnSelectNext>
        ' <comboGlyphAlign>
        Private Sub comboGlyphAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim alignments As HorzAlignment() = New HorzAlignment() {HorzAlignment.Near, HorzAlignment.Center, HorzAlignment.Far}
            Dim selectedIndex As Integer = comboGlyphAlign.SelectedIndex
            radioGroupSample.Properties.GlyphAlignment = alignments(selectedIndex)
            radioGroupSample.Properties.Appearance.TextOptions.HAlignment = alignments(selectedIndex)
        End Sub

        ' </comboGlyphAlign>
        ' <spinColumns>
        Private Sub spinColumns_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            radioGroupSample.Properties.Columns = CInt(spinColumns.Value)
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        ' </spinColumns>
        ' <comboSetEditValue>
        Private Sub comboSetEditValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim editValues As String() = New String() {"Circle", "Rectangle", "Ellipse", "Triangle", "Square", "Nothing"}
            Dim selectedIndex As Integer = comboSetEditValue.SelectedIndex
            radioGroupSample.EditValue = editValues(selectedIndex)
        End Sub

        ' </comboSetEditValue>
        Private Sub ModuleRadioGroup_Load(ByVal sender As Object, ByVal e As EventArgs)
            btnPopulateItems_Click(btnPopulateItems, New EventArgs())
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        ' <btnPopulateItems>
        Private Sub btnPopulateItems_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim strings As String() = New String() {"Circle", "Rectangle", "Ellipse", "Triangle", "Square"}
            Dim values As String() = New String() {"Circle", "Rectangle", "Ellipse", "Triangle", "Square", "Nothing"}
            For i As Integer = 0 To strings.Length - 1
                radioGroupSample.Properties.Items.Add(New RadioGroupItem(values(i), strings(i)))
            Next

            comboSetEditValue.Properties.Items.Clear()
            For i As Integer = 0 To values.Length - 1
                comboSetEditValue.Properties.Items.Add(values(i))
            Next

            radioGroupSample.SelectedIndex = 0
            SetControlsEnabled(True)
        End Sub

        ' </btnPopulateItems>
        ' <btnClearItems>
        Private Sub btnClearItems_Click(ByVal sender As Object, ByVal e As EventArgs)
            radioGroupSample.Properties.Items.Clear()
            comboSetEditValue.Properties.Items.Clear()
            checkEditAllowMnemonics.Checked = False
            SetControlsEnabled(False)
        End Sub

        ' <btnPopulateItems>
        Private Sub SetControlsEnabled(ByVal listPopulated As Boolean)
            btnPopulateItems.Enabled = Not listPopulated
            Dim _controls As ArrayList = New ArrayList()
            _controls.AddRange(New Control() {btnClearItems, spinColumns, comboGlyphAlign, checkEditAllowMnemonics, spinSelectedIndex, comboSetEditValue, txtSelectedIndexValue})
            For Each ctrl As Control In _controls
                ctrl.Enabled = listPopulated
            Next
        End Sub

        ' </btnClearItems> </btnPopulateItems>
        ' <spinSelectedIndex>
        Private Sub spinSelectedIndex_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            radioGroupSample.SelectedIndex = CInt(spinSelectedIndex.Value)
        End Sub

        ' </spinSelectedIndex>
        ' <txtSelectedIndexValue>
        Private Sub radioGroupSample_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            txtSelectedIndexValue.Text = radioGroupSample.SelectedIndex.ToString() & " / " & radioGroupSample.EditValue.ToString()
            updateValues = True
            spinSelectedIndex.Value = radioGroupSample.SelectedIndex
            comboSetEditValue.EditValue = radioGroupSample.EditValue
            updateValues = False
        End Sub

        ' </txtSelectedIndexValue>
        ' <checkEditAllowMnemonics>
        Private Sub checkEditAllowMnemonics_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As RadioGroupItem In radioGroupSample.Properties.Items
                If checkEditAllowMnemonics.Checked Then
                    item.Description = "&" & item.Description
                Else
                    item.Description = item.Description.Substring(1)
                End If
            Next
        End Sub

        ' </checkEditAllowMnemonics>
        Private Sub UpdateLayout()
            layoutControl2.Location = New Point(tabNavigationPage2.ClientSize.Width \ 2 - layoutControl2.Width \ 2, layoutControl2.Location.Y)
        End Sub
    End Class
End Namespace
