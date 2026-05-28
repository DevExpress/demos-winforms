Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraNavBar.Demos

    Public Partial Class AccordionControlBusinessModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitVehiclesData()
            InitGrid()
            InitAccordion()
            SetToolTipController(Me, gridControl1)
        End Sub

        Private models As List(Of VehiclesData.Model)

        Protected Overridable Sub InitVehiclesData()
            Dim DBFileName As String = String.Empty
            DBFileName = DataDirectoryHelper.GetDataFile("Vehicles.xml")
            If Not Equals(DBFileName, String.Empty) Then InitXMLData(DBFileName)
        End Sub

        Protected Sub InitXMLData(ByVal fileName As String)
            models = VehiclesData.InitXMLDataCore(fileName)
            gridControl1.DataSource = models
        End Sub

        Private Sub InitGrid()
            winExplorerView1.Columns.Clear()
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "ID"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Name"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Description"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Photo"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "InStock"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "CategoryName"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "TrademarkName"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "TransmissionTypeName"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "BodyStyleName"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Price"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Doors"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "MPGCity"})
            winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "MPGHighway"})
            Dim item As RepositoryItemTextEdit = New RepositoryItemTextEdit()
            winExplorerView1.Columns("Name").ColumnEdit = item
            gridControl1.RepositoryItems.Add(item)
            winExplorerView1.ColumnSet.TextColumn = winExplorerView1.Columns("Name")
            winExplorerView1.ColumnSet.DescriptionColumn = winExplorerView1.Columns("Price")
            winExplorerView1.Columns("Price").DisplayFormat.FormatType = Utils.FormatType.Numeric
            winExplorerView1.Columns("Price").DisplayFormat.FormatString = "c"
            winExplorerView1.ColumnSet.ExtraLargeImageColumn = winExplorerView1.Columns("Photo")
            winExplorerView1.ColumnSet.MediumImageColumn = winExplorerView1.Columns("Photo")
            winExplorerView1.ColumnSet.CheckBoxColumn = winExplorerView1.Columns("InStock")
        End Sub

        Private Sub InitAccordion()
            InitMain()
            InitBody()
            InitEngine()
        End Sub

        Private Sub InitEngine()
            InitMPGCity()
            InitMPGHighway()
        End Sub

        Private Sub InitMPGHighway()
            rtbMPGHighway.Properties.Minimum = Convert.ToInt32(FindMinMax(True, "MPGHighway"))
            rtbMPGHighway.Properties.Maximum = Convert.ToInt32(FindMinMax(False, "MPGHighway"))
            Dim c As Integer =((rtbMPGHighway.Properties.Maximum - rtbMPGHighway.Properties.Minimum) \ rtbMPGHighway.Properties.TickFrequency) * rtbMPGHighway.Properties.TickFrequency + rtbMPGHighway.Properties.Minimum
            rtbMPGHighway.Properties.Labels(0).Value = rtbMPGHighway.Properties.Minimum
            rtbMPGHighway.Properties.Labels(1).Value = c
            rtbMPGHighway.Properties.Labels(1).Label = rtbMPGHighway.Properties.Maximum.ToString()
            rtbMPGHighway.Properties.Labels(0).Label = rtbMPGHighway.Properties.Minimum.ToString()
        End Sub

        Private Sub InitMPGCity()
            rtbMPGCity.Properties.Minimum = Convert.ToInt32(FindMinMax(True, "MPGCity"))
            rtbMPGCity.Properties.Maximum = Convert.ToInt32(FindMinMax(False, "MPGCity"))
            Dim c As Integer =((rtbMPGCity.Properties.Maximum - rtbMPGCity.Properties.Minimum) \ rtbMPGCity.Properties.TickFrequency) * rtbMPGCity.Properties.TickFrequency + rtbMPGCity.Properties.Minimum
            rtbMPGCity.Properties.Labels(0).Value = rtbMPGCity.Properties.Minimum
            rtbMPGCity.Properties.Labels(1).Value = c
            rtbMPGCity.Properties.Labels(1).Label = rtbMPGCity.Properties.Maximum.ToString()
            rtbMPGCity.Properties.Labels(0).Label = rtbMPGCity.Properties.Minimum.ToString()
        End Sub

        Private Sub InitBody()
            InitBodyStyle()
            InitDoorsCount()
        End Sub

        Private Sub InitDoorsCount()
            rgDoorsCount.Properties.Items.Add(New RadioGroupItem("2", "2"))
            rgDoorsCount.Properties.Items.Add(New RadioGroupItem("3", "3"))
            rgDoorsCount.Properties.Items.Add(New RadioGroupItem("4", "4"))
            rgDoorsCount.Properties.Items.Add(New RadioGroupItem("All", "All"))
            rgDoorsCount.SelectedIndex = 3
        End Sub

        Private Sub InitBodyStyle()
            Dim bodyStyles As List(Of String) = GetListFromDB("BodyStyleName")
            For Each str As String In bodyStyles
                clbBodyStyle.Items.Add(str)
            Next
        End Sub

        Private Sub InitMain()
            InitPrice()
            InitTrademarks()
            InitTransmissionType()
        End Sub

        Private Sub InitTransmissionType()
            Dim transmissions As List(Of String) = GetListFromDB("TransmissionTypeName")
            For Each str As String In transmissions
                rgTransmissionType.Properties.Items.Add(New RadioGroupItem(str, str))
            Next

            rgTransmissionType.Properties.Items.Add(New RadioGroupItem("All", "All"))
            rgTransmissionType.SelectedIndex = 2
        End Sub

        Private Sub InitPrice()
            rTBPrice.Properties.Minimum = Convert.ToInt32(FindMinMax(True, "Price"))
            rTBPrice.Properties.Maximum = Convert.ToInt32(FindMinMax(False, "Price"))
            Dim c As Integer =((rTBPrice.Properties.Maximum - rTBPrice.Properties.Minimum) \ rTBPrice.Properties.TickFrequency) * rTBPrice.Properties.TickFrequency + rTBPrice.Properties.Minimum
            rTBPrice.Properties.Labels(1).Value = rTBPrice.Properties.Minimum
            rTBPrice.Properties.Labels(0).Value = c
            rTBPrice.Properties.Labels(0).Label = String.Format("{0:N0}", rTBPrice.Properties.Maximum)
            rTBPrice.Properties.Labels(1).Label = String.Format("{0:N0}", rTBPrice.Properties.Minimum)
        End Sub

        Private Sub InitTrademarks()
            Dim trademarks As List(Of String) = GetListFromDB("TrademarkName")
            For Each str As String In trademarks
                chLBMark.Items.Add(str)
            Next
        End Sub

        Private Function GetValueByName(ByVal model As VehiclesData.Model, ByVal name As String) As Object
            If Equals(name, "MPGCity") Then Return model.MPGCity
            If Equals(name, "MPGHighway") Then Return model.MPGHighway
            If Equals(name, "Price") Then Return model.Price
            If Equals(name, "TransmissionTypeName") Then Return model.TransmissionTypeName
            If Equals(name, "BodyStyleName") Then Return model.BodyStyleName
            Return model.TrademarkName
        End Function

        Private Function FindMinMax(ByVal isMin As Boolean, ByVal column As String) As Integer
            Dim min As Integer = 0, max As Integer = 0
            For Each model As VehiclesData.Model In models
                Dim value As Object = GetValueByName(model, column)
                If value Is Nothing Then Continue For
                Dim cur As Integer
                If Integer.TryParse(value.ToString(), cur) Then
                    min = If(min = 0, cur, Math.Min(min, cur))
                    max = Math.Max(max, cur)
                End If
            Next

            If isMin Then Return min
            Return max
        End Function

        Private Function GetListFromDB(ByVal column As String) As List(Of String)
            Dim list As List(Of String) = New List(Of String)()
            For Each model As VehiclesData.Model In models
                Dim str As String = GetValueByName(model, column).ToString()
                If Not list.Contains(str) Then list.Add(str)
            Next

            list.Sort()
            Return list
        End Function

        Private Sub rTBPrice_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If winExplorerView1.Columns("Price") Is Nothing Then Return
            Dim str As String = "[Price] >= " & rTBPrice.Value.Minimum.ToString() & " AND [Price] <= " & rTBPrice.Value.Maximum.ToString()
            winExplorerView1.Columns("Price").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Function GetFilterString(ByVal column As String, ByVal checkedListBoxItemCollection As CheckedListBoxItemCollection) As String
            Dim str As String = String.Empty
            For Each item As CheckedListBoxItem In checkedListBoxItemCollection
                If item.CheckState <> CheckState.Checked Then Continue For
                If Not Equals(str, String.Empty) Then str = str & "OR"
                str = str & "[" & column & "] = '" & item.Value.ToString() & "' "
            Next

            Return str
        End Function

        Private Sub rgTransmissionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If rgTransmissionType.SelectedIndex = 2 Then
                winExplorerView1.Columns("TransmissionTypeName").FilterInfo = ColumnFilterInfo.Empty
                Return
            End If

            Dim str As String = rgTransmissionType.Properties.Items(rgTransmissionType.SelectedIndex).Value.ToString()
            str = "[TransmissionTypeName] = '" & str & "'"
            winExplorerView1.Columns("TransmissionTypeName").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub rgDoorsCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If rgDoorsCount.SelectedIndex = 3 Then
                winExplorerView1.Columns("Doors").FilterInfo = ColumnFilterInfo.Empty
                Return
            End If

            Dim str As String = rgDoorsCount.Properties.Items(rgDoorsCount.SelectedIndex).Value.ToString()
            str = "[Doors] = '" & str & "'"
            winExplorerView1.Columns("Doors").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub chLBMark_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs)
            Dim str As String = GetFilterString("TrademarkName", chLBMark.Items)
            winExplorerView1.Columns("TrademarkName").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub clbBodyStyle_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs)
            Dim str As String = GetFilterString("BodyStyleName", clbBodyStyle.Items)
            winExplorerView1.Columns("BodyStyleName").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub rtbMPGCity_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If winExplorerView1.Columns("MPGCity") Is Nothing Then Return
            Dim str As String = "[MPGCity] >= " & rtbMPGCity.Value.Minimum.ToString() & " AND [MPGCity] <= " & rtbMPGCity.Value.Maximum.ToString()
            winExplorerView1.Columns("MPGCity").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub rtbMPGHighway_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If winExplorerView1.Columns("MPGHighway") Is Nothing Then Return
            Dim str As String = "[MPGHighway] >= " & rtbMPGHighway.Value.Minimum.ToString() & " AND [MPGHighway] <= " & rtbMPGHighway.Value.Maximum.ToString()
            winExplorerView1.Columns("MPGHighway").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub rTBPrice_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As XtraEditors.TrackBarValueToolTipEventArgs)
            e.ShowArgs.ToolTip = String.Format("{0:C} - {1:C}", rTBPrice.Value.Minimum, rTBPrice.Value.Maximum)
        End Sub

        Private Sub rtbMPGCity_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As XtraEditors.TrackBarValueToolTipEventArgs)
            e.ShowArgs.ToolTip = String.Format("{0} - {1}", rtbMPGCity.Value.Minimum, rtbMPGCity.Value.Maximum)
        End Sub

        Private Sub rtbMPGHighway_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As XtraEditors.TrackBarValueToolTipEventArgs)
            e.ShowArgs.ToolTip = String.Format("{0} - {1}", rtbMPGHighway.Value.Minimum, rtbMPGHighway.Value.Maximum)
        End Sub
    End Class
End Namespace
