Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for DataSummaries.
    ''' </summary>
    Public Partial Class DataSummaries
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            InitSummaries()
            InitEditing()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"DataSummaries"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "DataSummaries"
            End Get
        End Property

        '<gridControl1>
        Private gsiSummary, gsiMultiSummary, gsiMultiSummaryDetail, gsiDisplaySummary, gsiDisplaySummaryDetails As GridGroupSummaryItemCollection

        '</gridControl1>
        Private displaySummary As Boolean = False

#Region "Init"
        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return advBandedGridView1
            End Get
        End Property

        Private ReadOnly Property CurrentGrid As GridControl
            Get
                Return gridControl1
            End Get
        End Property

        Private ReadOnly Property CurrentView As GridView
            Get
                Return advBandedGridView1
            End Get
        End Property

        Private ReadOnly Property CurrentDetailView As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            dsNWindProducts1.ReadXml(dataFileName, XmlReadMode.InferSchema)
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1)
            Return dsNWindProducts1
        End Function

        Private Sub InitEditing()
            gridControl1.ForceInitialize()
            colSupplierID.GroupIndex = 0
            colPrice.GroupIndex = 0
            SetShowFooter(chShowFooter.Checked)
            chAlignSummary.Checked = True
            OnSummaryChecked(chDisplaySummary)
        End Sub

        Private Sub UpdateMasterDetailSettings()
            CurrentView.BeginUpdate()
            CurrentView.ExpandAllGroups()
            CurrentView.FocusedRowHandle = 0
            CurrentView.TopRowIndex = 0
            CurrentView.SetMasterRowExpanded(CurrentView.FocusedRowHandle, True)
            If ceMasterDetail.Checked Then
                If FirstDetailView IsNot Nothing Then FirstDetailView.ExpandGroupRow(-1)
            Else
                CurrentDetailView.ExpandAllGroups()
            End If

            CurrentView.EndUpdate()
        End Sub

        Private ReadOnly Property FirstDetailView As GridView
            Get
                Return TryCast(CurrentView.GetDetailView(0, 0), GridView)
            End Get
        End Property

        '<gridControl1>
        Private Sub InitSummaries()
            ' ~row summary 
            gsiSummary = New GridGroupSummaryItemCollection(CurrentView)
            gsiSummary.Add(SummaryItemType.Count, "ProductID")
            ' ~multi row summary 
            gsiMultiSummary = New GridGroupSummaryItemCollection(CurrentView)
            gsiMultiSummary.Add(SummaryItemType.Count, "ProductID")
            gsiMultiSummary.Add(SummaryItemType.Average, "UnitPrice", Nothing, Properties.Resources.AvgByPriceFormatCurrency)
            ' ~multi row summary for detail 
            gsiMultiSummaryDetail = New GridGroupSummaryItemCollection(CurrentDetailView)
            gsiMultiSummaryDetail.Add(SummaryItemType.Count, "OrderID")
            gsiMultiSummaryDetail.Add(SummaryItemType.Sum, "SubTotal", Nothing, Properties.Resources.SubTotalFormatCurrency)
            ' ~row footer summary 
            gsiDisplaySummary = New GridGroupSummaryItemCollection(CurrentView)
            gsiDisplaySummary.Add(SummaryItemType.Max, "UnitsOnOrder", colUnitsOnOrder, Properties.Resources.MaxFormat)
            gsiDisplaySummary.Add(SummaryItemType.Sum, "UnitsInStock", colUnitsInStock, Properties.Resources.SumFormat)
            gsiDisplaySummary.Add(SummaryItemType.Average, "UnitPrice", colUnitPrice, Properties.Resources.AvgFormatCurrency)
            gsiDisplaySummary.Add(SummaryItemType.Count, "ProductName", colProductName)
            ' ~row footer summary for details 
            gsiDisplaySummaryDetails = New GridGroupSummaryItemCollection(CurrentDetailView)
            gsiDisplaySummaryDetails.Add(SummaryItemType.Sum, "SubTotal", colSubTotal, Properties.Resources.SumFormatCurrency)
            gsiDisplaySummaryDetails.Add(SummaryItemType.Min, "Quantity", colQuantity, Properties.Resources.MinFormat)
        End Sub

        '</gridControl1>
        Private Sub DataSummaries_Load(ByVal sender As Object, ByVal e As EventArgs)
            UpdateMasterDetailSettings()
        End Sub

#End Region
#Region "Editing"
        '<chShowFooter>
        Private Sub SetShowFooter(ByVal show As Boolean)
            CurrentView.OptionsView.ShowFooter = show
            CurrentDetailView.OptionsView.ShowFooter = show
        End Sub

        Private Sub chShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim chb As CheckEdit = TryCast(sender, CheckEdit)
            SetShowFooter(chb.Checked)
        End Sub

        '</chShowFooter>
        Private Sub SaveDisplaySummary()
            If displaySummary Then
                gsiDisplaySummary.Assign(CurrentView.GroupSummary)
                gsiDisplaySummaryDetails.Assign(CurrentDetailView.GroupSummary)
                CurrentView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded
                CurrentDetailView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded
            End If

            displaySummary = False
        End Sub

#End Region
        Private Function GetSubTotalFromDataRow(ByVal row As DataRow) As Decimal
            Dim q As Decimal = Convert.ToDecimal(row("Quantity"))
            Dim p As Decimal = Convert.ToDecimal(row("UnitPrice"))
            Dim d As Decimal = Convert.ToDecimal(row("Discount"))
            Return q * p * (1 - d)
        End Function

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs)
            If e.IsSetData OrElse Not Equals(e.Column.FieldName, "SubTotal") Then Return
            Dim view As GridView = TryCast(sender, GridView)
            e.Value = GetSubTotalFromDataRow(CType(e.Row, DataRowView).Row)
        End Sub

        Private updateInfo As Boolean = False

        Private Sub chSummary_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateInfo Then Return
            OnSummaryChecked(TryCast(sender, CheckEdit))
        End Sub

        '<gridControl1>
        Private Sub OnSummaryChecked(ByVal edit As CheckEdit)
            If edit.Properties.Tag Is Nothing Then Return
            updateInfo = True
            Dim _caption As String = edit.Properties.Tag.ToString()
            Select Case _caption
                Case "Summary"
                    chSummary.Checked = True
                    chAlignSummary.Enabled = False
                    SaveDisplaySummary()
                    CurrentView.GroupSummary.Assign(gsiSummary)
                    CurrentDetailView.GroupSummary.Assign(gsiSummary)
                Case "Multi Summary"
                    chMultiSummary.Checked = True
                    chAlignSummary.Enabled = False
                    SaveDisplaySummary()
                    CurrentView.GroupSummary.Assign(gsiMultiSummary)
                    CurrentDetailView.GroupSummary.Assign(gsiMultiSummaryDetail)
                Case "Display Summary"
                    chDisplaySummary.Checked = True
                    chAlignSummary.Enabled = True
                    displaySummary = True
                    CurrentView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
                    CurrentDetailView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways
                    CurrentView.GroupSummary.Assign(gsiDisplaySummary)
                    CurrentDetailView.GroupSummary.Assign(gsiDisplaySummaryDetails)
            End Select

            UpdateAlignSummary()
            UpdateMasterDetailSettings()
            updateInfo = False
        End Sub

        Private Sub UpdateAlignSummary()
            CurrentDetailView.OptionsBehavior.AlignGroupSummaryInGroupRow = If(chAlignSummary.Enabled AndAlso chAlignSummary.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</gridControl1>
        Private Sub chAlignSummary_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateAlignSummary()
        End Sub

        Private Sub ceMasterDetail_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ceMasterDetail.Checked Then
                colOrderID.GroupIndex = -1
                colPrice.GroupIndex = 0
                gridControl1.MainView = CurrentView
                gridControl1.DataSource = dsNWindProducts1.Products
                colProduct.Visible = False
            Else
                colPrice.GroupIndex = -1
                colOrderID.GroupIndex = 0
                gridControl1.MainView = CurrentDetailView
                gridControl1.DataSource = dsNWindProducts1.Order_Details
                colProduct.VisibleIndex = 0
            End If

            UpdateMasterDetailSettings()
        End Sub

#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
