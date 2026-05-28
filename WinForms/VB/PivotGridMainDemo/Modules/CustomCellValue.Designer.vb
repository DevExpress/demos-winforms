Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class CustomCellValue

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldOrderYear
            ' 
            Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Order Year"
            Me.fieldOrderYear.FieldName = "OrderDate"
            Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
            ' 
            ' fieldOrderQuarter
            ' 
            Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderQuarter.AreaIndex = 1
            Me.fieldOrderQuarter.Caption = "Order Quarter"
            Me.fieldOrderQuarter.FieldName = "OrderDate"
            Me.fieldOrderQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldOrderQuarter.Name = "fieldOrderQuarter"
            Me.fieldOrderQuarter.UnboundFieldName = "fieldOrderQuarter"
            Me.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCompanyName, Me.fieldProductAmount, Me.fieldOrderYear, Me.fieldOrderQuarter})
            pivotGridGroup1.Fields.Add(Me.fieldOrderYear)
            pivotGridGroup1.Fields.Add(Me.fieldOrderQuarter)
            pivotGridGroup1.Hierarchy = Nothing
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(634, 506)
            Me.pivotGridControl1.TabIndex = 3
            AddHandler Me.pivotGridControl1.FieldValueDisplayText, New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(AddressOf Me.pivotGridControl1_FieldValueDisplayText)
            AddHandler Me.pivotGridControl1.CustomCellValue, New System.EventHandler(Of DevExpress.XtraPivotGrid.PivotCellValueEventArgs)(AddressOf Me.pivotGridControl1_CustomCellValue)
            ' 
            ' fieldCompanyName
            ' 
            Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCompanyName.AreaIndex = 0
            Me.fieldCompanyName.Caption = "Customer"
            Me.fieldCompanyName.FieldName = "CompanyName"
            Me.fieldCompanyName.Name = "fieldCompanyName"
            Me.fieldCompanyName.Width = 150
            ' 
            ' fieldProductAmount
            ' 
            Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductAmount.AreaIndex = 0
            Me.fieldProductAmount.Caption = "Amount"
            Me.fieldProductAmount.CellFormat.FormatString = "c"
            Me.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldProductAmount.FieldName = "ProductAmount"
            Me.fieldProductAmount.Name = "fieldProductAmount"
            Me.fieldProductAmount.Width = 130
            ' 
            ' CustomCellValue
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "CustomCellValue"
            Me.Size = New System.Drawing.Size(634, 506)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CustomCellValue_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        'private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderQuarter As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
