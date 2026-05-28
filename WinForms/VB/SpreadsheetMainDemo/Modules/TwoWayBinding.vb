Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Class TwoWayBindingModule
        Inherits SpreadSheetTutorialControlBase

        Private sidePanel1 As SidePanel

        Private gridControl1 As XtraGrid.GridControl

        Private gridView1 As XtraGrid.Views.Grid.GridView

        Private gridColumn1 As XtraGrid.Columns.GridColumn

        Private gridColumn2 As XtraGrid.Columns.GridColumn

        Private gridColumn3 As XtraGrid.Columns.GridColumn

        Private gridColumn4 As XtraGrid.Columns.GridColumn

        Private gridColumn5 As XtraGrid.Columns.GridColumn

        Private gridColumn6 As XtraGrid.Columns.GridColumn

        Private spreadsheet As SpreadsheetControl

        Public Sub New()
            InitializeComponent()
            spreadsheet.LoadDocument(DemoUtils.GetRelativePath("Expenses_template.xlsx"))
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheet.Focus()
        End Sub

        Private Sub Spreadsheet_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim sheet As Worksheet = spreadsheet.Document.Worksheets(0)
            Dim table As Table = sheet.Tables(0)
            Dim options As RangeDataSourceOptions = New RangeDataSourceOptions With {.PreserveFormulas = True, .SkipHiddenRows = True}
            gridControl1.DataSource = table.DataRange.GetDataSource(options)
        End Sub

        Private Sub TwoWayBindingModule_Resize(ByVal sender As Object, ByVal e As EventArgs)
            sidePanel1.Height = Height \ 2
        End Sub

#Region "InitializeComponent"
        Private Sub InitializeComponent()
            sidePanel1 = New SidePanel()
            spreadsheet = New SpreadsheetControl()
            gridControl1 = New XtraGrid.GridControl()
            gridView1 = New XtraGrid.Views.Grid.GridView()
            gridColumn1 = New XtraGrid.Columns.GridColumn()
            gridColumn2 = New XtraGrid.Columns.GridColumn()
            gridColumn3 = New XtraGrid.Columns.GridColumn()
            gridColumn4 = New XtraGrid.Columns.GridColumn()
            gridColumn5 = New XtraGrid.Columns.GridColumn()
            gridColumn6 = New XtraGrid.Columns.GridColumn()
            sidePanel1.SuspendLayout()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' sidePanel1
            ' 
            sidePanel1.Controls.Add(spreadsheet)
            sidePanel1.Dock = Windows.Forms.DockStyle.Top
            sidePanel1.Location = New System.Drawing.Point(0, 0)
            sidePanel1.Name = "sidePanel1"
            sidePanel1.Size = New System.Drawing.Size(1228, 368)
            sidePanel1.TabIndex = 1
            sidePanel1.Text = "sidePanel1"
            ' 
            ' spreadsheet
            ' 
            spreadsheet.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            spreadsheet.Dock = Windows.Forms.DockStyle.Fill
            spreadsheet.Location = New System.Drawing.Point(0, 0)
            spreadsheet.Name = "spreadsheet"
            spreadsheet.Options.Export.Csv.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.Export.Txt.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.Import.Csv.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.Import.Txt.Culture = New Globalization.CultureInfo("")
            spreadsheet.Options.View.Charts.Antialiasing = DocumentCapability.Enabled
            spreadsheet.Options.View.ShowPrintArea = False
            spreadsheet.Size = New System.Drawing.Size(1228, 367)
            spreadsheet.TabIndex = 8
            AddHandler spreadsheet.DocumentLoaded, New EventHandler(AddressOf Spreadsheet_DocumentLoaded)
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = Windows.Forms.DockStyle.Fill
            gridControl1.Location = New System.Drawing.Point(0, 368)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(1228, 326)
            gridControl1.TabIndex = 2
            gridControl1.UseEmbeddedNavigator = True
            gridControl1.ViewCollection.AddRange(New XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            gridView1.Columns.AddRange(New XtraGrid.Columns.GridColumn() {gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6})
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            gridView1.OptionsView.ColumnAutoWidth = False
            gridView1.OptionsView.NewItemRowPosition = XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' gridColumn1
            ' 
            gridColumn1.Caption = "Operation Expenses"
            gridColumn1.FieldName = "Column 0"
            gridColumn1.Name = "gridColumn1"
            gridColumn1.OptionsColumn.FixedWidth = True
            gridColumn1.Visible = True
            gridColumn1.VisibleIndex = 0
            gridColumn1.Width = 215
            ' 
            ' gridColumn2
            ' 
            gridColumn2.Caption = "Q1"
            gridColumn2.DisplayFormat.FormatString = "$ {0:n2}"
            gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            gridColumn2.FieldName = "Column 1"
            gridColumn2.Name = "gridColumn2"
            gridColumn2.OptionsColumn.FixedWidth = True
            gridColumn2.Visible = True
            gridColumn2.VisibleIndex = 1
            gridColumn2.Width = 117
            ' 
            ' gridColumn3
            ' 
            gridColumn3.Caption = "Q2"
            gridColumn3.DisplayFormat.FormatString = "$ {0:n2}"
            gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            gridColumn3.FieldName = "Column 2"
            gridColumn3.Name = "gridColumn3"
            gridColumn3.OptionsColumn.FixedWidth = True
            gridColumn3.Visible = True
            gridColumn3.VisibleIndex = 2
            gridColumn3.Width = 117
            ' 
            ' gridColumn4
            ' 
            gridColumn4.Caption = "Q3"
            gridColumn4.DisplayFormat.FormatString = "$ {0:n2}"
            gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            gridColumn4.FieldName = "Column 3"
            gridColumn4.Name = "gridColumn4"
            gridColumn4.OptionsColumn.FixedWidth = True
            gridColumn4.Visible = True
            gridColumn4.VisibleIndex = 3
            gridColumn4.Width = 117
            ' 
            ' gridColumn5
            ' 
            gridColumn5.Caption = "Q4"
            gridColumn5.DisplayFormat.FormatString = "$ {0:n2}"
            gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            gridColumn5.FieldName = "Column 4"
            gridColumn5.Name = "gridColumn5"
            gridColumn5.OptionsColumn.FixedWidth = True
            gridColumn5.Visible = True
            gridColumn5.VisibleIndex = 4
            gridColumn5.Width = 117
            ' 
            ' gridColumn6
            ' 
            gridColumn6.Caption = "Yearly Total"
            gridColumn6.DisplayFormat.FormatString = "$ {0:n2}"
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            gridColumn6.FieldName = "Column 5"
            gridColumn6.Name = "gridColumn6"
            gridColumn6.OptionsColumn.AllowEdit = False
            gridColumn6.OptionsColumn.FixedWidth = True
            gridColumn6.Visible = True
            gridColumn6.VisibleIndex = 5
            gridColumn6.Width = 145
            ' 
            ' TwoWayBindingModule
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(gridControl1)
            Controls.Add(sidePanel1)
            Name = "TwoWayBindingModule"
            Size = New System.Drawing.Size(1228, 694)
            AddHandler Resize, New EventHandler(AddressOf TwoWayBindingModule_Resize)
            sidePanel1.ResumeLayout(False)
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub
#End Region
    End Class
End Namespace
