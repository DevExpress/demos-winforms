Namespace DevExpress.DevAV

    Partial Class SortFilterControl

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
            Me.settingsLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.btnOrderDate = New DevExpress.XtraEditors.CheckButton()
            Me.btnInvoice = New DevExpress.XtraEditors.CheckButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsLayout.SuspendLayout()
            CType((Me.dateEdit2.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsLayout.AllowCustomization = False
            Me.settingsLayout.Controls.Add(Me.dateEdit2)
            Me.settingsLayout.Controls.Add(Me.dateEdit1)
            Me.settingsLayout.Controls.Add(Me.btnOrderDate)
            Me.settingsLayout.Controls.Add(Me.btnInvoice)
            Me.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.settingsLayout.Location = New System.Drawing.Point(0, 0)
            Me.settingsLayout.Name = "settingsLayout"
            Me.settingsLayout.Root = Me.Root
            Me.settingsLayout.Size = New System.Drawing.Size(238, 232)
            Me.settingsLayout.TabIndex = 3
            Me.dateEdit2.EditValue = New System.DateTime(2014, 1, 1, 0, 0, 0, 0)
            Me.dateEdit2.Location = New System.Drawing.Point(0, 160)
            Me.dateEdit2.Name = "dateEdit2"
            Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit2.Size = New System.Drawing.Size(238, 20)
            Me.dateEdit2.StyleController = Me.settingsLayout
            Me.dateEdit2.TabIndex = 5
            AddHandler Me.dateEdit2.DateTimeChanged, New System.EventHandler(AddressOf Me.dateEdit2_DateTimeChanged)
            Me.dateEdit1.EditValue = New System.DateTime(2012, 1, 1, 0, 0, 0, 0)
            Me.dateEdit1.Location = New System.Drawing.Point(0, 132)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Size = New System.Drawing.Size(238, 20)
            Me.dateEdit1.StyleController = Me.settingsLayout
            Me.dateEdit1.TabIndex = 4
            AddHandler Me.dateEdit1.DateTimeChanged, New System.EventHandler(AddressOf Me.dateEdit1_DateTimeChanged)
            Me.btnOrderDate.Checked = True
            Me.btnOrderDate.GroupIndex = 1
            Me.btnOrderDate.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnOrderDate.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortByOrderDate.svg"
            Me.btnOrderDate.Location = New System.Drawing.Point(0, 0)
            Me.btnOrderDate.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnOrderDate.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnOrderDate.Name = "btnOrderDate"
            Me.btnOrderDate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnOrderDate.Size = New System.Drawing.Size(238, 40)
            Me.btnOrderDate.StyleController = Me.settingsLayout
            Me.btnOrderDate.TabIndex = 2
            Me.btnOrderDate.Text = "Sort by Order Date"
            AddHandler Me.btnOrderDate.CheckedChanged, New System.EventHandler(AddressOf Me.btnOrderDate_CheckedChanged)
            Me.btnInvoice.GroupIndex = 1
            Me.btnInvoice.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnInvoice.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortByInvoice.svg"
            Me.btnInvoice.Location = New System.Drawing.Point(0, 40)
            Me.btnInvoice.MaximumSize = New System.Drawing.Size(0, 40)
            Me.btnInvoice.MinimumSize = New System.Drawing.Size(0, 40)
            Me.btnInvoice.Name = "btnInvoice"
            Me.btnInvoice.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnInvoice.Size = New System.Drawing.Size(238, 40)
            Me.btnInvoice.StyleController = Me.settingsLayout
            Me.btnInvoice.TabIndex = 2
            Me.btnInvoice.TabStop = False
            Me.btnInvoice.Text = "Sort by Invoice #"
            AddHandler Me.btnInvoice.CheckedChanged, New System.EventHandler(AddressOf Me.btnInvoice_CheckedChanged)
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.simpleLabelItem1, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(238, 232)
            Me.layoutControlItem1.Control = Me.btnOrderDate
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(238, 40)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.btnInvoice
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(238, 40)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
            Me.simpleLabelItem1.CustomizationFormText = "Range"
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 80)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0)
            Me.simpleLabelItem1.Size = New System.Drawing.Size(238, 48)
            Me.simpleLabelItem1.Text = "Range"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(67, 32)
            Me.layoutControlItem3.Control = Me.dateEdit1
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 128)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(238, 28)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            Me.layoutControlItem4.Control = Me.dateEdit2
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 156)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(238, 76)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.settingsLayout)
            Me.Name = "SortFilterControl"
            Me.Size = New System.Drawing.Size(238, 232)
            CType((Me.settingsLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsLayout.ResumeLayout(False)
            CType((Me.dateEdit2.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private settingsLayout As DevExpress.XtraLayout.LayoutControl

        Private btnOrderDate As DevExpress.XtraEditors.CheckButton

        Private btnInvoice As DevExpress.XtraEditors.CheckButton

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private dateEdit2 As DevExpress.XtraEditors.DateEdit

        Private dateEdit1 As DevExpress.XtraEditors.DateEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
