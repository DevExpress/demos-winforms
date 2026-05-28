Namespace DevExpress.ApplicationUI.Demos

    Partial Class SalesPerformanceWidgets

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.widgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
            Me.columnDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.columnDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.columnDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.columnDefinition4 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document6 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document7 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document8 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document9 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document10 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.rowDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition4 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition5 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition6 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.widgetView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentManager1.View = Me.widgetView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.widgetView1})
            ' 
            ' widgetView1
            ' 
            Me.widgetView1.AllowStartupAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.widgetView1.Columns.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition() {Me.columnDefinition1, Me.columnDefinition2, Me.columnDefinition3, Me.columnDefinition4})
            Me.widgetView1.DocumentProperties.AllowClose = False
            Me.widgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3, Me.document4, Me.document5, Me.document6, Me.document7, Me.document8, Me.document9, Me.document10})
            Me.widgetView1.DocumentSpacing = 5
            Me.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
            Me.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.widgetView1.Rows.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition() {Me.rowDefinition1, Me.rowDefinition2, Me.rowDefinition3, Me.rowDefinition4, Me.rowDefinition5, Me.rowDefinition6})
            AddHandler Me.widgetView1.QueryControl, New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(AddressOf Me.widgetView1_QueryControl)
            ' 
            ' columnDefinition1
            ' 
            Me.columnDefinition1.Length.UnitValue = 0.8R
            ' 
            ' columnDefinition2
            ' 
            Me.columnDefinition2.Length.UnitValue = 0.8R
            ' 
            ' columnDefinition3
            ' 
            Me.columnDefinition3.Length.UnitValue = 1.6R
            ' 
            ' columnDefinition4
            ' 
            Me.columnDefinition4.Length.UnitValue = 1.4R
            ' 
            ' document1
            ' 
            Me.document1.Caption = "Product Categories - YTD Sales"
            Me.document1.ColumnIndex = 3
            Me.document1.ControlName = "ucCategorySales"
            Me.document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCategorySales"
            Me.document1.RowIndex = 3
            Me.document1.RowSpan = 3
            ' 
            ' document2
            ' 
            Me.document2.Caption = "Product Sales YTD "
            Me.document2.ColumnIndex = 2
            Me.document2.ColumnSpan = 2
            Me.document2.ControlName = "ucProductsGrid"
            Me.document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsGrid"
            Me.document2.RowSpan = 3
            ' 
            ' document3
            ' 
            Me.document3.Caption = "Sales by State - Revenue YTD"
            Me.document3.ColumnSpan = 2
            Me.document3.ControlName = "ucChoroplethMapItem"
            Me.document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem"
            Me.document3.RowSpan = 3
            ' 
            ' document4
            ' 
            Me.document4.Caption = "Top 5 Products"
            Me.document4.ColumnIndex = 2
            Me.document4.ControlName = "ucChartProductItem"
            Me.document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChartProductItem"
            Me.document4.RowIndex = 3
            Me.document4.RowSpan = 3
            ' 
            ' document5
            ' 
            Me.document5.Caption = "Avg Order Size"
            Me.document5.ColumnIndex = 1
            Me.document5.ControlName = "ucCardWidget6"
            Me.document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document5.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            Me.document5.RowIndex = 3
            ' 
            ' document6
            ' 
            Me.document6.Caption = "Revenue YTD"
            Me.document6.ControlName = "ucCardWidget5"
            Me.document6.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document6.Footer = ""
            Me.document6.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            Me.document6.RowIndex = 3
            ' 
            ' document7
            ' 
            Me.document7.Caption = "Exprense YTD"
            Me.document7.ColumnIndex = 1
            Me.document7.ControlName = "ucCardWidget4"
            Me.document7.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document7.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            Me.document7.RowIndex = 5
            ' 
            ' document8
            ' 
            Me.document8.Caption = "Profit YTD"
            Me.document8.ControlName = "ucCardWidget3"
            Me.document8.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document8.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            Me.document8.RowIndex = 4
            ' 
            ' document9
            ' 
            Me.document9.Caption = "New Customers"
            Me.document9.ColumnIndex = 1
            Me.document9.ControlName = "ucCardWidget2"
            Me.document9.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document9.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            Me.document9.RowIndex = 4
            ' 
            ' document10
            ' 
            Me.document10.Caption = "Market Share"
            Me.document10.ControlName = "ucCardWidget1"
            Me.document10.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document10.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            Me.document10.RowIndex = 5
            ' 
            ' SalesPerformanceWidgets
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "SalesPerformanceWidgets"
            Me.Size = New System.Drawing.Size(813, 508)
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.widgetView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager

        Private widgetView1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView

        Private columnDefinition1 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private columnDefinition2 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private columnDefinition3 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private columnDefinition4 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private document1 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document2 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document3 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document4 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document5 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document6 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document7 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document8 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document9 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document10 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private rowDefinition1 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition2 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition3 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition4 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition5 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition6 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition
#Region "Component Designer generated code"
#End Region
    End Class
End Namespace
