Namespace DevExpress.XtraBars.Demos.DockingDemo

    Partial Class ucToolbox

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.DockingDemo.ucToolbox))
            Me.navBar = New DevExpress.XtraNavBar.NavBarControl()
            Me.toolboxSvgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.navBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolboxSvgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navBar
            ' 
            Me.navBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBar.DragDropFlags = CType((((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop) Or DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop)), DevExpress.XtraNavBar.NavBarDragDrop)
            Me.navBar.Location = New System.Drawing.Point(0, 0)
            Me.navBar.Margin = New System.Windows.Forms.Padding(2)
            Me.navBar.Name = "navBar"
            Me.navBar.OptionsNavPane.ExpandedWidth = 139
            Me.navBar.Size = New System.Drawing.Size(139, 373)
            Me.navBar.SmallImages = Me.toolboxSvgImages
            Me.navBar.StoreDefaultPaintStyleName = True
            Me.navBar.TabIndex = 3
            Me.navBar.Text = "navBarControl1"
            ' 
            ' toolboxSvgImages
            ' 
            Me.toolboxSvgImages.Add("Button", CType((resources.GetObject("toolboxSvgImages.Button")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckBox", CType((resources.GetObject("toolboxSvgImages.CheckBox")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckBoxList", CType((resources.GetObject("toolboxSvgImages.CheckBoxList")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckedComboBoxEdit", CType((resources.GetObject("toolboxSvgImages.CheckedComboBoxEdit")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DataGrid", CType((resources.GetObject("toolboxSvgImages.DataGrid")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("GroupBox", CType((resources.GetObject("toolboxSvgImages.GroupBox")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Label", CType((resources.GetObject("toolboxSvgImages.Label")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ListBoxControl", CType((resources.GetObject("toolboxSvgImages.ListBoxControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ListView", CType((resources.GetObject("toolboxSvgImages.ListView")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Panel", CType((resources.GetObject("toolboxSvgImages.Panel")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RadioButton", CType((resources.GetObject("toolboxSvgImages.RadioButton")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SplitterControl", CType((resources.GetObject("toolboxSvgImages.SplitterControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SplitContainerControl", CType((resources.GetObject("toolboxSvgImages.SplitContainerControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TabControl", CType((resources.GetObject("toolboxSvgImages.TabControl")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TableLayoutPanel", CType((resources.GetObject("toolboxSvgImages.TableLayoutPanel")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("BarManager_DX", CType((resources.GetObject("toolboxSvgImages.BarManager_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ButtonEdit_DX", CType((resources.GetObject("toolboxSvgImages.ButtonEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CalcEdit_DX", CType((resources.GetObject("toolboxSvgImages.CalcEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ChartControl_DX", CType((resources.GetObject("toolboxSvgImages.ChartControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckEdit_DX", CType((resources.GetObject("toolboxSvgImages.CheckEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("CheckButton_DX", CType((resources.GetObject("toolboxSvgImages.CheckButton_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ColorEdit_DX", CType((resources.GetObject("toolboxSvgImages.ColorEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DateControl_DX", CType((resources.GetObject("toolboxSvgImages.DateControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DateEdit_DX", CType((resources.GetObject("toolboxSvgImages.DateEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("DocumentManager_DX", CType((resources.GetObject("toolboxSvgImages.DocumentManager_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("GridControl_DX", CType((resources.GetObject("toolboxSvgImages.GridControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("GridLookUpEdit_DX", CType((resources.GetObject("toolboxSvgImages.GridLookUpEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("LabelControl1_DX", CType((resources.GetObject("toolboxSvgImages.LabelControl1_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ListBoxControl_DX", CType((resources.GetObject("toolboxSvgImages.ListBoxControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("LookUpEdit_DX", CType((resources.GetObject("toolboxSvgImages.LookUpEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Map_DX", CType((resources.GetObject("toolboxSvgImages.Map_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("MemoEdit_DX", CType((resources.GetObject("toolboxSvgImages.MemoEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PDFViewer_DX", CType((resources.GetObject("toolboxSvgImages.PDFViewer_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("Picture_DX", CType((resources.GetObject("toolboxSvgImages.Picture_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PivotGridControl_DX", CType((resources.GetObject("toolboxSvgImages.PivotGridControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("PopupMenu_DX", CType((resources.GetObject("toolboxSvgImages.PopupMenu_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RadialMenu_DX", CType((resources.GetObject("toolboxSvgImages.RadialMenu_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RadioGroup_DX", CType((resources.GetObject("toolboxSvgImages.RadioGroup_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("RangeControl_DX", CType((resources.GetObject("toolboxSvgImages.RangeControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SchedulerControl_DX", CType((resources.GetObject("toolboxSvgImages.SchedulerControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SimpleButton_DX", CType((resources.GetObject("toolboxSvgImages.SimpleButton_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SpinEdit_DX", CType((resources.GetObject("toolboxSvgImages.SpinEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("SpreadsheetControl_DX", CType((resources.GetObject("toolboxSvgImages.SpreadsheetControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TextEdit_DX", CType((resources.GetObject("toolboxSvgImages.TextEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TileControl_DX", CType((resources.GetObject("toolboxSvgImages.TileControl_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("TimeEdit_DX", CType((resources.GetObject("toolboxSvgImages.TimeEdit_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("ToggleSwitch_DX", CType((resources.GetObject("toolboxSvgImages.ToggleSwitch_DX")), DevExpress.Utils.Svg.SvgImage))
            Me.toolboxSvgImages.Add("XrtaTabControl_DX", CType((resources.GetObject("toolboxSvgImages.XrtaTabControl_DX")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' ucToolbox
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.navBar)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ucToolbox"
            Me.Size = New System.Drawing.Size(139, 373)
            CType((Me.navBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolboxSvgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private navBar As DevExpress.XtraNavBar.NavBarControl

        Private toolboxSvgImages As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
