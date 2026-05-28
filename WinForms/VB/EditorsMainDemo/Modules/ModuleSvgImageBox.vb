Imports System
Imports System.Drawing
Imports System.Linq

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleSvgImageBox
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitializeComboBoxes()
            DoPreselectSeats()
            AutoMergeRibbon = True
        End Sub

        Private Sub InitializeComboBoxes()
            imgAlignmentComboBox.Properties.Items.AddRange([Enum].GetValues(GetType(ContentAlignment)))
            imgAlignmentComboBox.SelectedItem = svgImageBox.ImageAlignment
            sizeModeComboBox.Properties.Items.AddRange([Enum].GetValues(GetType(SvgImageSizeMode)))
            sizeModeComboBox.SelectedItem = svgImageBox.SizeMode
            hitTestTypeComboBox.Properties.Items.AddRange([Enum].GetValues(GetType(ItemHitTestType)))
            hitTestTypeComboBox.SelectedItem = svgImageBox.ItemHitTestType
            selectionModeComboBox.Properties.Items.AddRange([Enum].GetValues(GetType(SvgImageItemSelectionMode)))
            selectionModeComboBox.SelectedItem = svgImageBox.OptionsSelection.SelectionMode
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            RibbonMenuManager.MergeOptions.PlacePagesInDemoCategory = False
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleSvgImageBox"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "svgImageBox"
            End Get
        End Property

        Private Sub DoPreselectSeats()
            Dim selectedSeatItems = svgImageBox.RootItems.Where(Function(i) CheckSeatId(i)).Skip(47).Take(4).ToArray()
            svgImageBox.Selection.AddRange(selectedSeatItems)
        End Sub

        ' <svgImageBox>
        Private Sub OnSvgImageBoxQueryHoveredItem(ByVal sender As Object, ByVal e As SvgImageQueryHoveredItemEventArgs)
            If e.HoveredItem IsNot Nothing AndAlso Not CheckSeatId(e.HoveredItem) Then e.HoveredItem = e.HoveredItem.FindAncestors(Function(a) CheckSeatId(a)).FirstOrDefault()
        End Sub

        Private Function CheckSeatId(ByVal svgImageItem As SvgImageItem) As Boolean
            Return Not Equals(svgImageItem.Id, Nothing) AndAlso svgImageItem.Id.StartsWith("seat")
        End Function

        ' </svgImageBox>
        '<selectedItemsListBox>
        Private Sub OnSvgImageBoxSelectionChanging(ByVal sender As Object, ByVal e As SvgImageSelectionChangingEventArgs)
            If e.Action = SvgImageSelectionChangeAction.Clear AndAlso svgImageBox.HoveredItem Is Nothing AndAlso Not isManualClear Then e.Cancel = True
        End Sub

        Private Sub OnSvgImageBoxSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            selectedItemsListBox.BeginUpdate()
            selectedItemsListBox.Items.Clear()
            For Each item In svgImageBox.Selection
                Dim itemDisplayName As String = String.Format("Seat number: {0}", (CStr(item.Tag)).ToUpper())
                selectedItemsListBox.Items.Add(itemDisplayName)
            Next

            selectedItemsListBox.EndUpdate()
        End Sub

        Private isManualClear As Boolean

        Private Sub OnClearSelectionButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            isManualClear = True
            svgImageBox.Selection.Clear()
            isManualClear = False
        End Sub

        '</selectedItemsListBox>
        Private Sub OnImageAlignmentComboBoxSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            svgImageBox.ImageAlignment = CType(imgAlignmentComboBox.SelectedItem, ContentAlignment)
        End Sub

        '<useCtrlToMultiSelectToggleSwitch>
        Private Sub OnCtrlToMultiSelectSwitchToggled(ByVal sender As Object, ByVal e As EventArgs)
            svgImageBox.OptionsSelection.UseCtrlToMultiSelect = If(useCtrlToMultiSelectToggleSwitch.IsOn, Utils.DefaultBoolean.True, Utils.DefaultBoolean.False)
        End Sub

        '</useCtrlToMultiSelectToggleSwitch>
        '<sizeModeComboBox>
        Private Sub OnSizeModeComboBoxSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            svgImageBox.SizeMode = CType(sizeModeComboBox.SelectedItem, SvgImageSizeMode)
        End Sub

        '</sizeModeComboBox>
        '<hitTestTypeComboBox>
        Private Sub OnHitTestTypeComboBoxSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            svgImageBox.ItemHitTestType = CType(hitTestTypeComboBox.SelectedItem, ItemHitTestType)
        End Sub

        '</hitTestTypeComboBox>
        '<selectionModeComboBox>
        Private Sub OnSelectionModeComboBoxSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            svgImageBox.OptionsSelection.SelectionMode = CType(selectionModeComboBox.SelectedItem, SvgImageItemSelectionMode)
        End Sub

        '</selectionModeComboBox>
        Private Sub OnBeforeShowToolTip(ByVal sender As Object, ByVal e As Utils.ToolTipControllerShowEventArgs)
            Dim svgImageItem = TryCast(e.SelectedObject, SvgImageItem)
            If svgImageItem Is Nothing Then Return
            e.ToolTip = String.Format(e.ToolTip, TryCast(svgImageItem.Tag, String).ToUpper(), If(svgImageItem.Selected, "Reserved", "Free"))
        End Sub

        Private disabledSeats As String() = {"a7", "a5", "a3", "a1", "b9", "b7", "b5", "b3", "b1", "c10", "c8", "c6", "c4", "c2", "d9", "d7", "d5", "d3", "d1", "e10", "e8", "e6", "e4", "e2", "f9", "f7", "f5", "f3", "f1", "g11", "g9", "g7", "g5", "g3", "g1", "h12", "h10", "h8", "h6", "h4", "h2"}

        Private Sub OnLayoutModeToggled(ByVal sender As Object, ByVal e As EventArgs)
            svgImageBox.BeginUpdate()
            Dim seatItems = svgImageBox.RootItems.Where(Function(i) CheckSeatId(i)).ToList()
            If layoutModeSwitch.IsOn Then
                seatItems.ForEach(Sub(i) i.Enabled = Not disabledSeats.Contains(TryCast(i.Tag, String)))
            Else
                seatItems.ForEach(Sub(i) i.Enabled = True)
            End If

            svgImageBox.EndUpdate()
        End Sub

        Private Sub OnExportBarButtonItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            ExportToSVG()
        End Sub

        Protected Overrides Sub ExportToSVG()
            ExportTo("svg", "SVG document (*.svg)|*.svg")
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            svgImageBox.ExportSvgImage(filename)
        End Sub
    End Class
End Namespace
