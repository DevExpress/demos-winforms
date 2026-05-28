Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils.Layout
Imports DevExpress.XtraBars.Navigation

' </imageListBoxControlSample>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleListBox
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitListBox()
            InitValues()
            AddHandler tabPane1.SelectedPageChanged, AddressOf SelectedPageChanged
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Tutorials.TutorialHelper.InitFont(imageListBoxControlSample, ScaleDPI)
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            RemoveHandler tabPane1.SelectedPageChanged, AddressOf SelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleListBox", "ListBoxProperties"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "listbox"
            End Get
        End Property

        Protected Overrides ReadOnly Property AllowCenterControls As Boolean
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property CurrentListBox As BaseListBoxControl
            Get
                Select Case tabPane1.SelectedPageIndex
                    Case 1
                        Return listBoxControlSample
                    Case 2
                        Return checkedListBoxControlSample
                    Case 3
                        Return imageListBoxControlSample
                End Select

                Return listBoxTemplated
            End Get
        End Property

        Private ReadOnly Property CurrentSearchControl As SearchControl
            Get
                Select Case tabPane1.SelectedPageIndex
                    Case 0
                        Return searchControlTemplates
                    Case 2
                        Return searchControlCheckedSample
                    Case 3
                        Return searchControlImageSample
                    Case Else
                        Return searchControlSample
                End Select
            End Get
        End Property

        Private ReadOnly Property CurrentContainer As TablePanel
            Get
                Select Case tabPane1.SelectedPageIndex
                    Case 0
                        Return tablePanel1
                    Case 2
                        Return tablePanel3
                    Case 3
                        Return tablePanel4
                    Case Else
                        Return tablePanel2
                End Select
            End Get
        End Property

        Private Sub InitValues()
            properties.InitListBox(CurrentListBox)
        End Sub

        Private Sub properties_SearchControlPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            Dim args As PropertyValueChangedEventArgs = TryCast(e, PropertyValueChangedEventArgs)
            Select Case args.PropertyName
                Case "AllowAutoApply"
                    ' <ceAllowAutoApply>
                    searchControlSample.Properties.AllowAutoApply = CBool(args.Value)
                    ' </ceAllowAutoApply>
                    Return
                Case "ShowSearchButton"
                    ' <ceShowSearchButton>
                    searchControlSample.Properties.ShowSearchButton = CBool(args.Value)
                    ' </ceShowSearchButton>
                    Return
                Case "ShowClearButton"
                    ' <ceShowClearButton>
                    searchControlSample.Properties.ShowClearButton = CBool(args.Value)
                    ' </ceShowClearButton>
                    Return
                Case "ShowMRUButton"
                    ' <ceShowMRUButton>
                    searchControlSample.Properties.ShowMRUButton = CBool(args.Value)
                    ' </ceShowMRUButton>
                    Return
                Case "FindDelay"
                    ' <tbFindDelay>
                    searchControlSample.Properties.FindDelay = CInt(args.Value)
                    ' </tbFindDelay>
                    Return
                Case "FilterCondition"
                    ' <cbFilterCondition>
                    searchControlSample.Properties.FilterCondition = CType(args.Value, DevExpress.Data.Filtering.FilterCondition)
                    ' </cbFilterCondition>
                    Return
                Case "ShowDefaultButtonsMode"
                    ' <cbShowDefaultButtonsMode>
                    ' <cbShowDefaultButtonsMode>
                    searchControlSample.Properties.ShowDefaultButtonsMode = CType(args.Value, Repository.ShowDefaultButtonsMode)
                Case "TurnSearch"
                    CurrentContainer.Rows(0).Visible = CBool(args.Value)
                    ' <searchControlSample>
                    TurnSearch(CBool(args.Value))
                    ' </searchControlSample>
                    Return
            End Select
        End Sub

        ' <searchControlSample>
        Private Sub TurnSearch(ByVal allowSearch As Boolean)
            Dim listBoxControl As BaseListBoxControl = TryCast(CurrentListBox, BaseListBoxControl)
            Dim searchControl As SearchControl = CurrentSearchControl
            If searchControl IsNot Nothing Then
                If allowSearch Then
                    searchControl.Client = listBoxControl
                Else
                    searchControl.Client = Nothing
                End If
            End If
        End Sub

        ' </searchControlSample>        
        Private Sub InitListBox()
            listBoxTemplated.DataSource = GetContacts()
            listBoxControlSample.DataSource = TutorialHelper.Countries
            '
            ' <checkedListBoxControlSample>
            checkedListBoxControlSample.DataSource = GetProducts()
            If checkedListBoxControlSample.DataSource IsNot Nothing Then
                checkedListBoxControlSample.DisplayMember = "ProductName"
                checkedListBoxControlSample.ValueMember = "Discontinued"
                Dim i As Integer = 0
                While checkedListBoxControlSample.GetItem(i) IsNot Nothing
                    checkedListBoxControlSample.SetItemCheckState(i, If(True.Equals(checkedListBoxControlSample.GetItemValue(i)), CheckState.Unchecked, CheckState.Checked))
                    i += 1
                End While
            End If

            ' </checkedListBoxControlSample>
            '
            imageListBoxControlSample.SelectedIndex = 0
        End Sub

        ' <checkedListBoxControlSample>
        Private Function GetProducts() As DataTable
            Return NWindDataSet.Tables("Products")
        End Function

        ' </checkedListBoxControlSample>
        Private Function GetContacts() As DataTable
            Return NWindDataSet.Tables("Employees")
        End Function

        Private Sub SelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            InitValues()
        End Sub

        ' <ceCustomDraw>
        Private Sub checkedListBoxControlSample_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
            If Not ceCustomDraw.Checked Then Return
            If checkedListBoxControlSample.GetItemChecked(e.Index) Then Return
            e.Appearance.FontStyleDelta = FontStyle.Strikeout
        End Sub

        Private Sub ceCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            checkedListBoxControlSample.Refresh()
        End Sub

        ' </ceCustomDraw>
        ' <imageListBoxControlSample>
        Private Sub imageListBoxControlSample_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ilb As ImageListBoxControl = TryCast(sender, ImageListBoxControl)
            Dim fontName As Object = ilb.SelectedValue
            lbSample.Visible = fontName IsNot Nothing
            If fontName Is Nothing Then Return
            lbSample.Font = New Font(fontName.ToString(), 12)
        End Sub

        ' </imageListBoxControlSample>
        ' <seInvert>
        Private Sub seInvert_Click(ByVal sender As Object, ByVal e As EventArgs)
            checkedListBoxControlSample.BeginUpdate()
            Try
                Dim i As Integer = 0
                While checkedListBoxControlSample.GetItem(i) IsNot Nothing
                    checkedListBoxControlSample.SetItemCheckState(i, If(checkedListBoxControlSample.GetItemChecked(i), CheckState.Unchecked, CheckState.Checked))
                    i += 1
                End While
            Finally
                checkedListBoxControlSample.EndUpdate()
            End Try
        End Sub
    ' </seInvert>
    End Class
End Namespace
