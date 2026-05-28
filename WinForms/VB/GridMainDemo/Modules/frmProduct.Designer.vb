Namespace DevExpress.XtraGrid.Demos

    Partial Class frmProduct

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.frmProduct))
            Dim conditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
            Dim conditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceDiscontinued = New DevExpress.XtraEditors.CheckEdit()
            Me.teQuantityPerUnit = New DevExpress.XtraEditors.TextEdit()
            Me.seUnitPrice = New DevExpress.XtraEditors.SpinEdit()
            Me.icbCategory = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.teProductName = New DevExpress.XtraEditors.TextEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciProductName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciOK = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCancel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciCategory = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciQuantityPerUnit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDiscontinued = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceDiscontinued.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teQuantityPerUnit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seUnitPrice.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbCategory.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teProductName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciProductName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciOK), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCancel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCategory), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUnitPrice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciQuantityPerUnit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciDiscontinued), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dxValidationProvider1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.ceDiscontinued)
            Me.layoutControl1.Controls.Add(Me.teQuantityPerUnit)
            Me.layoutControl1.Controls.Add(Me.seUnitPrice)
            Me.layoutControl1.Controls.Add(Me.icbCategory)
            Me.layoutControl1.Controls.Add(Me.simpleButton2)
            Me.layoutControl1.Controls.Add(Me.teProductName)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ceDiscontinued
            ' 
            Me.ceDiscontinued.AllowDrop = True
            resources.ApplyResources(Me.ceDiscontinued, "ceDiscontinued")
            Me.ceDiscontinued.Name = "ceDiscontinued"
            Me.ceDiscontinued.Properties.Caption = resources.GetString("ceDiscontinued.Properties.Caption")
            Me.ceDiscontinued.StyleController = Me.layoutControl1
            ' 
            ' teQuantityPerUnit
            ' 
            resources.ApplyResources(Me.teQuantityPerUnit, "teQuantityPerUnit")
            Me.teQuantityPerUnit.Name = "teQuantityPerUnit"
            Me.teQuantityPerUnit.StyleController = Me.layoutControl1
            ' 
            ' seUnitPrice
            ' 
            resources.ApplyResources(Me.seUnitPrice, "seUnitPrice")
            Me.seUnitPrice.Name = "seUnitPrice"
            Me.seUnitPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seUnitPrice.Properties.Mask.EditMask = resources.GetString("seUnitPrice.Properties.Mask.EditMask")
            Me.seUnitPrice.Properties.Mask.UseMaskAsDisplayFormat =(CBool((resources.GetObject("seUnitPrice.Properties.Mask.UseMaskAsDisplayFormat"))))
            Me.seUnitPrice.StyleController = Me.layoutControl1
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater
            conditionValidationRule3.ErrorText = "Please enter an amount greater than 0"
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
            conditionValidationRule3.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
            Me.dxValidationProvider1.SetValidationRule(Me.seUnitPrice, conditionValidationRule3)
            ' 
            ' icbCategory
            ' 
            resources.ApplyResources(Me.icbCategory, "icbCategory")
            Me.icbCategory.Name = "icbCategory"
            Me.icbCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.icbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbCategory.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbCategory.Properties.DropDownRows = 10
            Me.icbCategory.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items"), (CObj((resources.GetObject("icbCategory.Properties.Items1")))), (CInt((resources.GetObject("icbCategory.Properties.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items3"), (CObj((resources.GetObject("icbCategory.Properties.Items4")))), (CInt((resources.GetObject("icbCategory.Properties.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items6"), (CObj((resources.GetObject("icbCategory.Properties.Items7")))), (CInt((resources.GetObject("icbCategory.Properties.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items9"), (CObj((resources.GetObject("icbCategory.Properties.Items10")))), (CInt((resources.GetObject("icbCategory.Properties.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items12"), (CObj((resources.GetObject("icbCategory.Properties.Items13")))), (CInt((resources.GetObject("icbCategory.Properties.Items14"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items15"), (CObj((resources.GetObject("icbCategory.Properties.Items16")))), (CInt((resources.GetObject("icbCategory.Properties.Items17"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items18"), (CObj((resources.GetObject("icbCategory.Properties.Items19")))), (CInt((resources.GetObject("icbCategory.Properties.Items20"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items21"), (CObj((resources.GetObject("icbCategory.Properties.Items22")))), (CInt((resources.GetObject("icbCategory.Properties.Items23")))))})
            Me.icbCategory.Properties.SmallImages = Me.svgImageCollection1
            Me.icbCategory.StyleController = Me.layoutControl1
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            resources.ApplyResources(Me.simpleButton2, "simpleButton2")
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.StyleController = Me.layoutControl1
            ' 
            ' teProductName
            ' 
            resources.ApplyResources(Me.teProductName, "teProductName")
            Me.teProductName.Name = "teProductName"
            Me.teProductName.StyleController = Me.layoutControl1
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
            conditionValidationRule1.ErrorText = "This value cannot be empty"
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
            Me.dxValidationProvider1.SetValidationRule(Me.teProductName, conditionValidationRule1)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciProductName, Me.emptySpaceItem1, Me.lciOK, Me.lciCancel, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.lciCategory, Me.lciUnitPrice, Me.lciQuantityPerUnit, Me.lciDiscontinued})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(297, 192)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciProductName
            ' 
            Me.lciProductName.Control = Me.teProductName
            resources.ApplyResources(Me.lciProductName, "lciProductName")
            Me.lciProductName.Location = New System.Drawing.Point(0, 0)
            Me.lciProductName.Name = "lciProductName"
            Me.lciProductName.Size = New System.Drawing.Size(297, 24)
            Me.lciProductName.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 120)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(297, 46)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciOK
            ' 
            Me.lciOK.Control = Me.simpleButton1
            resources.ApplyResources(Me.lciOK, "lciOK")
            Me.lciOK.Location = New System.Drawing.Point(111, 166)
            Me.lciOK.MaxSize = New System.Drawing.Size(88, 26)
            Me.lciOK.MinSize = New System.Drawing.Size(88, 26)
            Me.lciOK.Name = "lciOK"
            Me.lciOK.Size = New System.Drawing.Size(88, 26)
            Me.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciOK.TextSize = New System.Drawing.Size(0, 0)
            Me.lciOK.TextVisible = False
            ' 
            ' lciCancel
            ' 
            Me.lciCancel.Control = Me.simpleButton2
            resources.ApplyResources(Me.lciCancel, "lciCancel")
            Me.lciCancel.Location = New System.Drawing.Point(205, 166)
            Me.lciCancel.MaxSize = New System.Drawing.Size(92, 26)
            Me.lciCancel.MinSize = New System.Drawing.Size(92, 26)
            Me.lciCancel.Name = "lciCancel"
            Me.lciCancel.Size = New System.Drawing.Size(92, 26)
            Me.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciCancel.TextSize = New System.Drawing.Size(0, 0)
            Me.lciCancel.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 166)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(111, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
            Me.emptySpaceItem3.Location = New System.Drawing.Point(199, 166)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(6, 0)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(6, 10)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(6, 26)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciCategory
            ' 
            Me.lciCategory.Control = Me.icbCategory
            resources.ApplyResources(Me.lciCategory, "lciCategory")
            Me.lciCategory.Location = New System.Drawing.Point(0, 24)
            Me.lciCategory.Name = "lciCategory"
            Me.lciCategory.Size = New System.Drawing.Size(297, 24)
            Me.lciCategory.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' lciUnitPrice
            ' 
            Me.lciUnitPrice.Control = Me.seUnitPrice
            resources.ApplyResources(Me.lciUnitPrice, "lciUnitPrice")
            Me.lciUnitPrice.Location = New System.Drawing.Point(0, 48)
            Me.lciUnitPrice.Name = "lciUnitPrice"
            Me.lciUnitPrice.Size = New System.Drawing.Size(297, 24)
            Me.lciUnitPrice.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' lciQuantityPerUnit
            ' 
            Me.lciQuantityPerUnit.Control = Me.teQuantityPerUnit
            resources.ApplyResources(Me.lciQuantityPerUnit, "lciQuantityPerUnit")
            Me.lciQuantityPerUnit.Location = New System.Drawing.Point(0, 72)
            Me.lciQuantityPerUnit.Name = "lciQuantityPerUnit"
            Me.lciQuantityPerUnit.Size = New System.Drawing.Size(297, 24)
            Me.lciQuantityPerUnit.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' lciDiscontinued
            ' 
            Me.lciDiscontinued.Control = Me.ceDiscontinued
            resources.ApplyResources(Me.lciDiscontinued, "lciDiscontinued")
            Me.lciDiscontinued.Location = New System.Drawing.Point(0, 96)
            Me.lciDiscontinued.Name = "lciDiscontinued"
            Me.lciDiscontinued.Size = New System.Drawing.Size(297, 24)
            Me.lciDiscontinued.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Beverages", CType((resources.GetObject("svgImageCollection1.Beverages")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("condiments", CType((resources.GetObject("svgImageCollection1.condiments")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("confections", CType((resources.GetObject("svgImageCollection1.confections")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("DairyProduct", CType((resources.GetObject("svgImageCollection1.DairyProduct")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("grains_cereals", CType((resources.GetObject("svgImageCollection1.grains_cereals")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("MeatPoultry", CType((resources.GetObject("svgImageCollection1.MeatPoultry")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("produce", CType((resources.GetObject("svgImageCollection1.produce")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Seafood", CType((resources.GetObject("svgImageCollection1.Seafood")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' frmProduct
            ' 
            Me.AcceptButton = Me.simpleButton1
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.simpleButton2
            Me.Controls.Add(Me.layoutControl1)
            Me.IconOptions.ShowIcon = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmProduct"
            Me.ShowInTaskbar = False
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.frmProduct_FormClosing)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceDiscontinued.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teQuantityPerUnit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seUnitPrice.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbCategory.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teProductName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciProductName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciOK), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCancel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCategory), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUnitPrice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciQuantityPerUnit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciDiscontinued), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dxValidationProvider1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private teProductName As DevExpress.XtraEditors.TextEdit

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private lciProductName As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private lciOK As DevExpress.XtraLayout.LayoutControlItem

        Private lciCancel As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private ceDiscontinued As DevExpress.XtraEditors.CheckEdit

        Private teQuantityPerUnit As DevExpress.XtraEditors.TextEdit

        Private seUnitPrice As DevExpress.XtraEditors.SpinEdit

        Private icbCategory As DevExpress.XtraEditors.ImageComboBoxEdit

        Private lciCategory As DevExpress.XtraLayout.LayoutControlItem

        Private lciUnitPrice As DevExpress.XtraLayout.LayoutControlItem

        Private lciQuantityPerUnit As DevExpress.XtraLayout.LayoutControlItem

        Private lciDiscontinued As DevExpress.XtraLayout.LayoutControlItem

        Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
