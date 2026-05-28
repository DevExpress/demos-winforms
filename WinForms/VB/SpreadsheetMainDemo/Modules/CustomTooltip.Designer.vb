Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class CustomTooltipModule

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

        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraSpreadsheet.Demos.CustomTooltipModule))
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.nwindDataSet = New DevExpress.XtraSpreadsheet.Demos.nwindDataSet()
            Me.employeesTableAdapter = New DevExpress.XtraSpreadsheet.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.ToolTipController = Me.toolTipController1
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((0)))))), (CInt(((CByte((192)))))))
            Me.toolTipController1.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))))
            Me.toolTipController1.Appearance.Options.UseBackColor = True
            Me.toolTipController1.Appearance.Options.UseForeColor = True
            Me.toolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.WindowsXP
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' employeesTableAdapter
            ' 
            Me.employeesTableAdapter.ClearBeforeFill = True
            ' 
            ' CustomTooltipModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "CustomTooltipModule"
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private nwindDataSet As DevExpress.XtraSpreadsheet.Demos.nwindDataSet

        Private employeesTableAdapter As DevExpress.XtraSpreadsheet.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter
    End Class
End Namespace
