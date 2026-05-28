Namespace DevExpress.HTML.Demos

    Partial Class MessageBoxProperties

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
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.txtText = New DevExpress.XtraEditors.MemoEdit()
            Me.icbImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.txtCaption = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.captionItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.textItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.imageItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.txtText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtCaption.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.captionItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("actions_check", "image://svgimages/icon builder/actions_check.svg")
            Me.svgImageCollection1.Add("actions_checkcircled", "image://svgimages/icon builder/actions_checkcircled.svg")
            Me.svgImageCollection1.Add("warning", "image://svgimages/status/warning.svg")
            Me.svgImageCollection1.Add("security_warningcircled1", "image://svgimages/icon builder/security_warningcircled1.svg")
            Me.svgImageCollection1.Add("actions_deletecircled", "image://svgimages/icon builder/actions_deletecircled.svg")
            Me.svgImageCollection1.Add("actions_info", "image://svgimages/icon builder/actions_info.svg")
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.txtText)
            Me.layoutControl1.Controls.Add(Me.icbImage)
            Me.layoutControl1.Controls.Add(Me.txtCaption)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(264, 207)
            Me.layoutControl1.TabIndex = 15
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' txtText
            ' 
            Me.txtText.Location = New System.Drawing.Point(67, 40)
            Me.txtText.Name = "txtText"
            Me.txtText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtText.Size = New System.Drawing.Size(178, 127)
            Me.txtText.StyleController = Me.layoutControl1
            Me.txtText.TabIndex = 3
            AddHandler Me.txtText.EditValueChanged, New System.EventHandler(AddressOf Me.OnEditValueChanged)
            ' 
            ' icbImage
            ' 
            Me.icbImage.EditValue = 0
            Me.icbImage.Location = New System.Drawing.Point(67, 169)
            Me.icbImage.Name = "icbImage"
            Me.icbImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbImage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("check", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("check2", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("warning", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("error", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("cancel", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("info", 5, 5)})
            Me.icbImage.Properties.SmallImages = Me.svgImageCollection1
            Me.icbImage.ShowToolTips = False
            Me.icbImage.Size = New System.Drawing.Size(178, 20)
            Me.icbImage.StyleController = Me.layoutControl1
            Me.icbImage.TabIndex = 0
            AddHandler Me.icbImage.EditValueChanged, New System.EventHandler(AddressOf Me.OnEditValueChanged)
            ' 
            ' txtCaption
            ' 
            Me.txtCaption.Location = New System.Drawing.Point(67, 18)
            Me.txtCaption.Name = "txtCaption"
            Me.txtCaption.Size = New System.Drawing.Size(178, 20)
            Me.txtCaption.StyleController = Me.layoutControl1
            Me.txtCaption.TabIndex = 2
            AddHandler Me.txtCaption.EditValueChanged, New System.EventHandler(AddressOf Me.OnEditValueChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.captionItem, Me.textItem, Me.imageItem})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(18, 18, 17, 17)
            Me.Root.Size = New System.Drawing.Size(264, 207)
            Me.Root.TextVisible = False
            ' 
            ' captionItem
            ' 
            Me.captionItem.Control = Me.txtCaption
            Me.captionItem.Location = New System.Drawing.Point(0, 0)
            Me.captionItem.Name = "captionItem"
            Me.captionItem.Size = New System.Drawing.Size(228, 22)
            Me.captionItem.Text = "Caption:"
            Me.captionItem.TextSize = New System.Drawing.Size(41, 13)
            ' 
            ' textItem
            ' 
            Me.textItem.Control = Me.txtText
            Me.textItem.Location = New System.Drawing.Point(0, 22)
            Me.textItem.Name = "textItem"
            Me.textItem.Size = New System.Drawing.Size(228, 129)
            Me.textItem.Text = "Text:"
            Me.textItem.TextSize = New System.Drawing.Size(41, 13)
            ' 
            ' imageItem
            ' 
            Me.imageItem.Control = Me.icbImage
            Me.imageItem.Location = New System.Drawing.Point(0, 151)
            Me.imageItem.Name = "imageItem"
            Me.imageItem.Size = New System.Drawing.Size(228, 22)
            Me.imageItem.Text = "Image:"
            Me.imageItem.TextSize = New System.Drawing.Size(41, 13)
            ' 
            ' MessageBoxProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "MessageBoxProperties"
            Me.Size = New System.Drawing.Size(264, 207)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.txtText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtCaption.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.captionItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private icbImage As DevExpress.XtraEditors.ImageComboBoxEdit

        Private txtCaption As DevExpress.XtraEditors.TextEdit

        Private txtText As DevExpress.XtraEditors.MemoEdit

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private captionItem As DevExpress.XtraLayout.LayoutControlItem

        Private textItem As DevExpress.XtraLayout.LayoutControlItem

        Private imageItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
