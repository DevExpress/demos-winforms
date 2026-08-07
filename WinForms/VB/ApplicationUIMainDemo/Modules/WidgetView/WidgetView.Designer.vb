Namespace DevExpress.ApplicationUI.Demos

    Partial Class WidgetView

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
#Region "Windows Designer generated code"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.widgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document6 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document7 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document8 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.stackGroup1 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.stackGroup2 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.stackGroup3 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.widgetView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.document8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager
            ' 
            Me.documentManager.ContainerControl = Me
            Me.documentManager.View = Me.widgetView1
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.widgetView1})
            ' 
            ' widgetView1
            ' 
            Me.widgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3, Me.document4, Me.document5, Me.document6, Me.document7, Me.document8})
            Me.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.widgetView1.StackGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() {Me.stackGroup1, Me.stackGroup2, Me.stackGroup3})
            ' 
            ' document1
            ' 
            Me.document1.Caption = "AAPL"
            Me.document1.ControlName = "document1"
            Me.document1.Height = 150
            ' 
            ' document2
            ' 
            Me.document2.Caption = "YHOO"
            Me.document2.ControlName = "document2"
            Me.document2.Height = 150
            ' 
            ' document3
            ' 
            Me.document3.Caption = "CSCO"
            Me.document3.ControlName = "document3"
            Me.document3.Height = 150
            ' 
            ' document4
            ' 
            Me.document4.Caption = "ADBE"
            Me.document4.ControlName = "document4"
            Me.document4.Height = 150
            ' 
            ' document5
            ' 
            Me.document5.Caption = "BAC"
            Me.document5.ControlName = "document5"
            Me.document5.Height = 150
            ' 
            ' document6
            ' 
            Me.document6.Caption = "DELL"
            Me.document6.ControlName = "document6"
            Me.document6.Height = 150
            ' 
            ' document7
            ' 
            Me.document7.Caption = "NVDA"
            Me.document7.ControlName = "document7"
            Me.document7.Height = 150
            ' 
            ' document8
            ' 
            Me.document8.Caption = "HPQ"
            Me.document8.ControlName = "document8"
            Me.document8.Height = 150
            ' 
            ' stackGroup1
            ' 
            Me.stackGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.document1, Me.document5, Me.document7})
            Me.stackGroup1.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.stackGroup1.Length.UnitValue = 200R
            ' 
            ' stackGroup2
            ' 
            Me.stackGroup2.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.document2, Me.document3, Me.document8})
            Me.stackGroup2.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.stackGroup2.Length.UnitValue = 200R
            ' 
            ' stackGroup3
            ' 
            Me.stackGroup3.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.document4, Me.document6})
            Me.stackGroup3.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.stackGroup3.Length.UnitValue = 200R
            ' 
            ' WidgetView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "WidgetView"
            Me.Size = New System.Drawing.Size(620, 479)
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.widgetView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.document8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private widgetView1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView

        Private document1 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document2 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document3 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document4 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document5 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document6 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document7 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private document8 As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private stackGroup1 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup

        Private stackGroup2 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup

        Private stackGroup3 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup

        Private components As System.ComponentModel.IContainer
    End Class
End Namespace
