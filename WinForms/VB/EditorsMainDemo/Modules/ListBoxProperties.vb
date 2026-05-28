Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
' <icbAlignment>
' <icbSelectionMode>
' <icbSortOrder>
Imports DevExpress.XtraEditors.Controls
' </icbSortOrder>
' </icbSelectionMode>
Imports DevExpress.Utils

' </icbAlignment>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ListBoxProperties
        Inherits XtraUserControl

        Private ReadOnly Property CheckedListBox As CheckedListBoxControl
            Get
                Return TryCast(listBoxCore, CheckedListBoxControl)
            End Get
        End Property

        Private ReadOnly Property ImageListBox As ImageListBoxControl
            Get
                Return TryCast(listBoxCore, ImageListBoxControl)
            End Get
        End Property

        Private ReadOnly Property ListBox As ListBoxControl
            Get
                Return TryCast(listBoxCore, ListBoxControl)
            End Get
        End Property

        Private ReadOnly Property IsTemplatedListBox As Boolean
            Get
                Return ListBox IsNot Nothing AndAlso ListBox.Templates.Count > 0
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitComboBoxes()
            InitSearchControlProperties()
        End Sub

        Private listBoxCore As BaseListBoxControl

        Private updateValues As Boolean = False

        Private ReadOnly searchControlPropertyChangedCore As Object = New Object()

        Public Custom Event SearchControlPropertyChanged As PropertyChangedEventHandler
            AddHandler(ByVal value As PropertyChangedEventHandler)
                Events.AddHandler(searchControlPropertyChangedCore, value)
            End AddHandler

            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                Events.RemoveHandler(searchControlPropertyChangedCore, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            End RaiseEvent
        End Event

        ' <ceAllowAutoApply>      
        ' <ceShowSearchButton>        
        ' <ceShowClearButton>
        ' <ceShowMRUButton>
        ' <tbFindDelay>
        ' <cbFilterCondition>
        ' <cbShowDefaultButtonsMode>
        ' <searchControlSample>
        Protected Sub RaiseSearchControlPropertyChanged(ByVal propertyName As String, ByVal value As Object)
            Dim handler As PropertyChangedEventHandler = CType(Events(searchControlPropertyChangedCore), PropertyChangedEventHandler)
            If handler IsNot Nothing Then handler(Me, New PropertyValueChangedEventArgs(propertyName, value))
        End Sub

        ' </ceAllowAutoApply>      
        ' </ceShowSearchButton>        
        ' </ceShowClearButton>
        ' </ceShowMRUButton>
        ' </tbFindDelay>
        ' </cbFilterCondition>
        ' </cbShowDefaultButtonsMode>
        ' </searchControlSample>
        Public Sub InitListBox(ByVal listBox As BaseListBoxControl)
            listBoxCore = listBox
            updateValues = True
            icbSelectionMode.EditValue = listBox.SelectionMode
            icbSortOrder.EditValue = listBox.SortOrder
            icbHighlightedItemStyle.EditValue = listBox.HighlightedItemStyle
            icbHotTrackSelectMode.EditValue = listBox.HotTrackSelectMode
            seColumnWidth.Value = listBox.ColumnWidth
            ceHotTrack.Checked = listBox.HotTrackItems
            ceMultiColumn.Checked = listBox.MultiColumn
            seColumnWidth.Enabled = listBox.MultiColumn
            ' <icbSelectionMode>
            icbSelectionMode.Enabled = CheckedListBox Is Nothing
            ' </icbSelectionMode>
            If ImageListBox IsNot Nothing Then icbAlignment.EditValue = ImageListBox.GlyphAlignment
            If CheckedListBox IsNot Nothing Then ceCheckOnClick.Checked = CheckedListBox.CheckOnClick
            groupControlSearch.Visible = Me.ListBox IsNot Nothing AndAlso Not IsTemplatedListBox AndAlso ceTurnSearch.Checked
            ceMultiColumn.Enabled = Not IsTemplatedListBox
            ceAutoHeight.Enabled = IsTemplatedListBox
            ceAutoHeight.Checked = IsTemplatedListBox AndAlso listBox.ItemAutoHeight
            'ceTurnSearch.Enabled = ListBox != null;
            ceTurnSearch.Checked = TryCast(listBox, ISearchControlClient).IsAttachedToSearchControl
            groupControlChecked.Visible = CheckedListBox IsNot Nothing
            groupControlImage.Visible = ImageListBox IsNot Nothing
            groupControlTemplated.Visible = IsTemplatedListBox
            icbSortOrder.Enabled = listBox.DataSource Is Nothing
            ceHotTrack.Enabled = AllowHotTrack
            ceIncrementalSearch.Checked = listBox.IncrementalSearch
            UpdateHotTrackSelectModeEnabled()
            updateValues = False
        End Sub

        Private Sub InitSearchControlProperties()
            If TypeOf listBoxCore Is ListBoxControl Then
                ceTurnSearch.Checked = True
                ' <ceAllowAutoApply>
                ceAllowAutoApply.Checked = True
                ' </ceAllowAutoApply>
                ' <ceShowSearchButton>
                ceShowSearchButton.Checked = True
                ' </ceShowSearchButton>
                ' <ceShowClearButton>
                ceShowClearButton.Checked = True
                ' </ceShowClearButton>
                ' <ceShowMRUButton>
                ceShowMRUButton.Checked = False
                ' </ceShowMRUButton>
                ' <cbFilterCondition>
                cbFilterCondition.Properties.Items.AddEnum(GetType(DevExpress.Data.Filtering.FilterCondition))
                cbFilterCondition.SelectedIndex = CInt(DevExpress.Data.Filtering.FilterCondition.Default)
                ' </cbFilterCondition>
                ' <tbFindDelay>
                tbFindDelay.Value = 1000
                ' </tbFindDelay>
                ' <cbShowDefaultButtonsMode>
                cbShowDefaultButtonsMode.Properties.Items.AddEnum(GetType(Repository.ShowDefaultButtonsMode))
                cbShowDefaultButtonsMode.SelectedIndex = CInt(Repository.ShowDefaultButtonsMode.Default)
            ' </cbShowDefaultButtonsMode>
            End If
        End Sub

        Private Sub UpdateHotTrackSelectModeEnabled()
            icbHotTrackSelectMode.Enabled = listBoxCore.HighlightedItemStyle = HighlightStyle.Skinned AndAlso listBoxCore.HotTrackItems
        End Sub

        Private Sub InitComboBoxes()
            ' <icbSelectionMode>
            icbSelectionMode.Properties.Items.AddEnum(GetType(SelectionMode))
            ' </icbSelectionMode>
            ' <icbSortOrder>
            icbSortOrder.Properties.Items.AddEnum(GetType(SortOrder))
            ' </icbSortOrder>
            ' <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
            ' </icbAlignment>
            ' <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
            ' </icbHighlightedItemStyle>
            ' <icbHotTrackSelectMode>
            icbHotTrackSelectMode.Properties.Items.AddEnum(GetType(HotTrackSelectMode))
        ' </icbHotTrackSelectMode>
        End Sub

        ' <icbSelectionMode>
        ' <ceHotTrack>
        Private ReadOnly Property AllowHotTrack As Boolean
            Get
                Return listBoxCore.SelectionMode.ToString().IndexOf("Multi") = -1
            End Get
        End Property

        ' </ceHotTrack>
        Private Sub icbSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.SelectionMode = CType(icbSelectionMode.EditValue, SelectionMode)
            ' <ceHotTrack>
            ceHotTrack.Enabled = AllowHotTrack
        ' </ceHotTrack>
        End Sub

        ' </icbSelectionMode>
        ' <icbSortOrder>
        Private Sub icbSortOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' </skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.SortOrder = CType(icbSortOrder.EditValue, SortOrder)
        End Sub

        ' </icbSortOrder>
        ' <seColumnWidth>
        Private Sub seColumnWidth_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.ColumnWidth = Convert.ToInt32(seColumnWidth.Value)
        End Sub

        ' </seColumnWidth>
        ' <ceHotTrack>
        Private Sub ceHotTrack_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.HotTrackItems = ceHotTrack.Checked
            ' <skip>
            UpdateHotTrackSelectModeEnabled()
        ' </skip>
        End Sub

        ' </ceHotTrack>
        ' <ceMultiColumn>
        Private Sub ceMultiColumn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.MultiColumn = ceMultiColumn.Checked
            ' <seColumnWidth>
            seColumnWidth.Enabled = listBoxCore.MultiColumn
        ' </seColumnWidth>
        End Sub

        ' </ceMultiColumn>
        ' <icbAlignment>
        Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            If ImageListBox Is Nothing Then Return
            ImageListBox.GlyphAlignment = CType(icbAlignment.EditValue, HorzAlignment)
        End Sub

        ' </icbAlignment>
        ' <ceCheckOnClick>
        Private Sub ceCheckOnClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            If CheckedListBox Is Nothing Then Return
            CheckedListBox.CheckOnClick = ceCheckOnClick.Checked
        End Sub

        ' </ceCheckOnClick>
        ' <icbHighlightedItemStyle>
        Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
            ' <skip>
            UpdateHotTrackSelectModeEnabled()
        ' </skip>
        End Sub

        ' </icbHighlightedItemStyle>
        ' <icbHotTrackSelectMode>
        Private Sub icbHotTrackSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.HotTrackSelectMode = CType(icbHotTrackSelectMode.EditValue, HotTrackSelectMode)
        End Sub

        ' </icbHotTrackSelectMode>
        ' <ceIncrementalSearch>
        Private Sub ceIncrementalSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            listBoxCore.IncrementalSearch = ceIncrementalSearch.Checked
        End Sub

        ' </ceIncrementalSearch>
        ' <ceAllowAutoApply>
        Private Sub ceAllowAutoApply_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("AllowAutoApply", ceAllowAutoApply.Checked)
        End Sub

        ' </ceAllowAutoApply>
        ' <ceShowSearchButton>
        Private Sub ceShowSearchButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("ShowSearchButton", ceShowSearchButton.Checked)
        End Sub

        ' </ceShowSearchButton>
        ' <ceShowClearButton>
        Private Sub ceShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("ShowClearButton", ceShowClearButton.Checked)
        End Sub

        ' </ceShowClearButton>
        ' <ceShowMRUButton>
        Private Sub ceShowMRUButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("ShowMRUButton", ceShowMRUButton.Checked)
        End Sub

        ' </ceShowMRUButton>
        ' <tbFindDelay>
        Private Sub tbFindDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("FindDelay", tbFindDelay.Value)
        End Sub

        ' </tbFindDelay>
        ' <cbFilterCondition>
        Private Sub cbFilterCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("FilterCondition", cbFilterCondition.EditValue)
        End Sub

        ' </cbFilterCondition>
        ' <searchControlSample>
        Private Sub ceTurnSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseSearchControlPropertyChanged("TurnSearch", ceTurnSearch.Checked)
            ' <skip>
            groupControlSearch.Visible = ListBox IsNot Nothing AndAlso ceTurnSearch.Checked AndAlso Not IsTemplatedListBox
        ' </skip>
        End Sub

        ' </searchControlSample>
        ' <cbShowDefaultButtonsMode>
        Private Sub cbShowDefaultButtonsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            RaiseSearchControlPropertyChanged("ShowDefaultButtonsMode", cbShowDefaultButtonsMode.EditValue)
        End Sub

        ' </cbShowDefaultButtonsMode>
        Private Sub ceShowContextButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            If Not IsTemplatedListBox Then Return
            ' </skip>
            For Each btn As ContextItem In ListBox.ContextButtons
                btn.Visibility = If(ceShowContextButtons.Checked, ContextItemVisibility.Visible, ContextItemVisibility.Hidden)
            Next
        End Sub

        Private Sub ceAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            If Not IsTemplatedListBox Then Return
            ' </skip>
            Dim notesElement = ListBox.Templates(0).Elements("Notes")
            If notesElement IsNot Nothing Then
                ListBox.ItemAutoHeight = ceAutoHeight.Checked
                notesElement.GetRow().AutoHeight = ceAutoHeight.Checked
            End If
        End Sub
    End Class

    Public Class PropertyValueChangedEventArgs
        Inherits PropertyChangedEventArgs

        Private valueCore As Object

        Public Sub New(ByVal propertyName As String, ByVal value As Object)
            MyBase.New(propertyName)
            valueCore = value
        End Sub

        Public ReadOnly Property Value As Object
            Get
                Return valueCore
            End Get
        End Property
    End Class
End Namespace
