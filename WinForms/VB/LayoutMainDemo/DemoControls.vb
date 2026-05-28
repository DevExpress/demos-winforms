Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraLayout.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "LayoutMainDemo\Modules"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraLayout.Demos.CodeInfo"
            End Get
        End Property

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim layout = TryCast(ctrl, DevExpress.XtraLayout.LayoutControl)
            If layout IsNot Nothing Then layout.MenuManager = manager
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Private nwindDS As DataSet

        Protected Function GetNWindData(ByVal data As DataSet, ByVal tableName As String) As DataView
            If nwindDS Is Nothing Then
                Dim dbFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
                If Not String.IsNullOrEmpty(dbFileName) Then
                    SetWaitDialogCaption(String.Format("Loading {0}...", tableName))
                    nwindDS = New DataSet()
                    nwindDS.ReadXml(dbFileName)
                Else
                    Return Nothing
                End If
            End If

            FillTable(tableName, data, nwindDS)
            Return nwindDS.Tables(tableName).DefaultView
        End Function

        Private vehiclesDS As DataSet

        Protected Overridable Sub InitVehiclesData(ByVal vehiclesData As VehiclesDataSet)
            If vehiclesDS Is Nothing Then
                Dim dbFileName As String = DataDirectoryHelper.GetDataFile("Vehicles.xml")
                If Not String.IsNullOrEmpty(dbFileName) Then
                    vehiclesDS = New DataSet()
                    vehiclesDS.ReadXml(dbFileName)
                Else
                    Return
                End If
            End If

            SetWaitDialogCaption("Loading Cars...")
            Me.FillTable("Model", vehiclesData, vehiclesDS)
            Me.FillTable("Trademark", vehiclesData, vehiclesDS)
            Me.FillTable("Category", vehiclesData, vehiclesDS)
            Me.FillTable("BodyStyle", vehiclesData, vehiclesDS)
            Me.FillTable("TransmissionType", vehiclesData, vehiclesDS)
            UpdateModelTable(vehiclesData)
        End Sub

        Private Sub UpdateModelTable(ByVal vehiclesData As VehiclesDataSet)
            vehiclesData.Model.BeginLoadData()
            For Each modelRow As VehiclesDataSet.ModelRow In vehiclesData.Model.Rows
                modelRow.Delivery_Date = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(30))
                modelRow.InStock = TutorialConstants.Random.Next(100) < 95
            Next

            vehiclesData.Model.EndLoadData()
        End Sub

        Protected Sub FillTable(ByVal tableName As String, ByVal data As DataSet, ByVal source As DataSet)
            Dim targetTable = data.Tables(tableName)
            Dim sourceTable = source.Tables(tableName)
            For Each sourceColumn As DataColumn In sourceTable.Columns
                Dim colTarget = targetTable.Columns(sourceColumn.ColumnName)
                If colTarget IsNot Nothing Then
                    If colTarget.Ordinal <> sourceColumn.Ordinal Then colTarget.SetOrdinal(sourceColumn.Ordinal)
                    If colTarget.DataType IsNot sourceColumn.DataType Then
                    End If ' TODO 
                Else
                End If
            Next

            targetTable.BeginLoadData()
            For Each row As DataRow In sourceTable.Rows
                Dim targetRow = targetTable.NewRow()
                targetRow.ItemArray = row.ItemArray
                targetTable.Rows.Add(targetRow)
            Next

            targetTable.EndLoadData()
        End Sub

#Region "Print and Export"
        Public Overridable ReadOnly Property ExportControl As LayoutControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return ExportControl IsNot Nothing
            End Get
        End Property

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportControl Is Nothing Then Return
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "rtf") Then ExportControl.ExportToRtf(filename)
            If Equals(ext, "pdf") Then ExportControl.ExportToPdf(filename)
            If Equals(ext, "mht") Then ExportControl.ExportToMht(filename)
            If Equals(ext, "html") Then ExportControl.ExportToHtml(filename)
            If Equals(ext, "txt") Then ExportControl.ExportToText(filename)
            If Equals(ext, "xls") Then ExportControl.ExportToXls(filename)
            If Equals(ext, "xlsx") Then ExportControl.ExportToXlsx(filename)
            Cursor.Current = currentCursor
        End Sub

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", "HTML document (*.html)|*.html")
        End Sub

        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", "MHT document (*.mht)|*.mht")
        End Sub

        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", "XLS document (*.xls)|*.xls")
        End Sub

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub PrintPreview()
            If ExportControl IsNot Nothing Then
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    ExportControl.ShowRibbonPrintPreview()
                Else
                    ExportControl.ShowPrintPreview()
                End If
            End If
        End Sub
#End Region
    End Class
End Namespace
