Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class ExcelFiltering
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitVehiclesData()
            SetToolTipController(Me, treeList1)
        End Sub

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\ExcelFiltering"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ExcelFiltering"
            End Get
        End Property

        ' Addding custom Filters and Data Items customization
        '<treeList1>
        Private Sub TreeList_FilterPopupExcelData(ByVal sender As Object, ByVal e As FilterPopupExcelDataEventArgs)
            ' Removing unwanted data
            If e.Column Is bcName OrElse e.Column Is bcTrademark Then e.RemoveData(0)
            If e.Column Is bcModification OrElse e.Column Is bcBodyStyle OrElse e.Column Is bcCategory Then e.RemoveData(Nothing)
            ' Adding custom Filters
            Dim fieldName As String = e.Column.FieldName
            If e.Column Is bcModification Then
                ' Filter Items
                e.AddFilter("<image=A><nbsp>Automatic Transmission (6-speed)", "Contains([" & fieldName & "], '6A')", True)
                e.AddFilter("<image=A><nbsp>Automatic Transmission (8-speed)", "Contains([" & fieldName & "], '8A')", True)
                e.AddFilter("<image=M><nbsp>Manual Transmission (6-speed)", "Contains([" & fieldName & "], '6M')", True)
                e.AddFilter("<image=M><nbsp>Manual Transmission (7-speed)", "Contains([" & fieldName & "], '7M')", True)
                e.AddFilter("<image=V><nbsp>Variomatic Transmission", "Contains([" & fieldName & "], 'VA')", True)
                e.AddFilter("<b>Limited Edition</b>", "Contains([" & fieldName & "], 'Limited')", True)
                ' Data Items
                For Each _item In e.DataItems
                    If _item.Text.Contains("V6") Then _item.HtmlText = _item.Text.Replace("V6", "<b>V6</b>")
                    If _item.Text.Contains("V8") Then _item.HtmlText = _item.Text.Replace("V8", "<b>V8</b>")
                    If _item.Text.Contains("Limited") Then _item.HtmlText = "<image=Ltd><nbsp>" & _item.Text
                Next
            End If

            If e.Column Is bcMPGCity Then ' 12-28
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" & fieldName & "]>25", True)
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" & fieldName & "]>=15 AND [" & fieldName & "]<=25", True)
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" & fieldName & "]<15", True)
            End If

            If e.Column Is bcMPGHighway Then ' 15-36
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" & fieldName & "]>30", True)
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" & fieldName & "]>=20 AND [" & fieldName & "]<=30", True)
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" & fieldName & "]<20", True)
            End If
        End Sub

        '</treeList1>
#Region "Init Data"
        Private Sub InitVehiclesData()
            Dim dbFileName As String = DataDirectoryHelper.GetDataFile("Vehicles.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then InitMDBData(dbFileName)
        End Sub

        Private Sub InitMDBData(ByVal dbFileName As String)
            treeList1.LoadingPanelVisible = True
            Call VehiclesData.InitOrdersData(dbFileName, treeList1, 10000, 400, Sub()
                VehiclesData.InitEditors(treeList1)
                treeList1.HtmlImages = VehiclesData.GetTransmissionGlyphs()
                treeList1.ExpandAll()
                If Not MainFormHelper.TakeScreens Then
                    treeList1.ActiveFilterString = "InRange([ModelPrice], 25000, 80000) And (IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate]))"
                    treeList1.MRUFilters.Add(New TreeListFilterInfo("InRange([ModelPrice], 50000, 150000)"))
                    treeList1.MRUFilters.Add(New TreeListFilterInfo("IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate])"))
                    treeList1.MRUFilters.Add(New TreeListFilterInfo("[SalesDate] > AddDays(LocalDateTimeToday(), -25)"))
                Else
                    treeList1.ActiveFilterString = "InRange([ModelPrice], 25000, 80000)"
                End If

                SubscribeEvents()
                ' Hide loading panel
                treeList1.LoadingPanelVisible = False
            End Sub)
        End Sub

#End Region
#Region "Events"
        Private Sub SubscribeEvents()
            AddHandler treeList1.ShowingEditor, AddressOf TreeList_ShowingEditor
            AddHandler treeList1.CustomNodeCellEdit, AddressOf TreeList_CustomNodeCellEdit
        End Sub

        Private Sub TreeList_CustomNodeCellEdit(ByVal sender As Object, ByVal e As GetCustomNodeCellEditEventArgs)
            If treeList1.IsRootNode(e.Node) Then e.RepositoryItem = textEditForRoots
        End Sub

        Private Sub TreeList_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If treeList1.IsRootNode(treeList1.FocusedNode) Then e.Cancel = True
        End Sub

#End Region
#Region "Export"
        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region  ' Export
    End Class
End Namespace
