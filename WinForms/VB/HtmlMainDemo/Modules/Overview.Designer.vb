Namespace DevExpress.HTML.Demos

    Partial Class Overview

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.Overview))
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition4 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            Me.textEditPhone = New DevExpress.XtraEditors.TextEdit()
            Me.textEditEmail = New DevExpress.XtraEditors.TextEdit()
            Me.textEditFullName = New DevExpress.XtraEditors.TextEdit()
            Me.textEditDisplayName = New DevExpress.XtraEditors.TextEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.htmlOverviewDescription = New DevExpress.XtraEditors.HtmlContentControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.htmlContentControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.htmlContentControl.SuspendLayout()
            CType((Me.textEditPhone.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditEmail.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditFullName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditDisplayName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.htmlOverviewDescription), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' htmlContentControl
            ' 
            Me.htmlContentControl.Controls.Add(Me.textEditPhone)
            Me.htmlContentControl.Controls.Add(Me.textEditEmail)
            Me.htmlContentControl.Controls.Add(Me.textEditFullName)
            Me.htmlContentControl.Controls.Add(Me.textEditDisplayName)
            Me.htmlContentControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl.HtmlImages = Me.svgImageCollection1
            Me.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles")
            Me.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template")
            Me.htmlContentControl.Location = New System.Drawing.Point(17, 11)
            Me.htmlContentControl.Margin = New System.Windows.Forms.Padding(0)
            Me.htmlContentControl.MinimumSize = New System.Drawing.Size(0, 630)
            Me.htmlContentControl.Name = "htmlContentControl"
            Me.htmlContentControl.Size = New System.Drawing.Size(620, 630)
            Me.htmlContentControl.TabIndex = 0
            AddHandler Me.htmlContentControl.ElementMouseClick, New DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(AddressOf Me.htmlContentControl_ElementMouseClick)
            ' 
            ' textEditPhone
            ' 
            Me.textEditPhone.EditValue = "(562) 559-5830"
            Me.textEditPhone.Location = New System.Drawing.Point(331, 277)
            Me.textEditPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditPhone.Name = "textEditPhone"
            Me.textEditPhone.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditPhone.Properties.Appearance.Options.UseFont = True
            Me.textEditPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditPhone.Size = New System.Drawing.Size(242, 18)
            Me.textEditPhone.TabIndex = 3
            ' 
            ' textEditEmail
            ' 
            Me.textEditEmail.EditValue = "leahs@dx-email.com"
            Me.textEditEmail.Location = New System.Drawing.Point(47, 277)
            Me.textEditEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditEmail.Name = "textEditEmail"
            Me.textEditEmail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditEmail.Properties.Appearance.Options.UseFont = True
            Me.textEditEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditEmail.Size = New System.Drawing.Size(242, 18)
            Me.textEditEmail.TabIndex = 2
            ' 
            ' textEditFullName
            ' 
            Me.textEditFullName.EditValue = "Leah Simpson"
            Me.textEditFullName.Location = New System.Drawing.Point(331, 181)
            Me.textEditFullName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditFullName.Name = "textEditFullName"
            Me.textEditFullName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditFullName.Properties.Appearance.Options.UseFont = True
            Me.textEditFullName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditFullName.Size = New System.Drawing.Size(242, 18)
            Me.textEditFullName.TabIndex = 1
            ' 
            ' textEditDisplayName
            ' 
            Me.textEditDisplayName.EditValue = "Leah Test Coordinator"
            Me.textEditDisplayName.Location = New System.Drawing.Point(47, 181)
            Me.textEditDisplayName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.textEditDisplayName.Name = "textEditDisplayName"
            Me.textEditDisplayName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textEditDisplayName.Properties.Appearance.Options.UseFont = True
            Me.textEditDisplayName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textEditDisplayName.Size = New System.Drawing.Size(242, 18)
            Me.textEditDisplayName.TabIndex = 0
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("employee", "image://svgimages/business objects/bo_lead.svg")
            Me.svgImageCollection1.Add("phone", "image://svgimages/outlook inspired/glyph_phone.svg")
            Me.svgImageCollection1.Add("contact", "image://svgimages/business objects/bo_contact.svg")
            Me.svgImageCollection1.Add("message", "image://svgimages/outlook inspired/glyph_message.svg")
            Me.svgImageCollection1.Add("signin", "image://svgimages/scheduling/timezones.svg")
            ' 
            ' htmlOverviewDescription
            ' 
            Me.htmlOverviewDescription.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlOverviewDescription.HtmlImages = Me.svgImageCollection1
            Me.htmlOverviewDescription.HtmlTemplate.Styles = ".container{" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "display:flex;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "flex-direction: column;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "justify-content: space-betwe" & "en;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "padding:20px;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "color:@ControlText;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "}" & Global.Microsoft.VisualBasic.Constants.vbCrLf & ".text{" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "word-wrap: normal;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "font-s" & "ize:10pt;" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "}"
            Me.htmlOverviewDescription.HtmlTemplate.Template = resources.GetString("htmlOverviewDescription.HtmlTemplate.Template")
            Me.htmlOverviewDescription.Location = New System.Drawing.Point(652, 11)
            Me.htmlOverviewDescription.Margin = New System.Windows.Forms.Padding(0)
            Me.htmlOverviewDescription.Name = "htmlOverviewDescription"
            Me.htmlOverviewDescription.Size = New System.Drawing.Size(382, 630)
            Me.htmlOverviewDescription.TabIndex = 1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.AutoScroll = False
            Me.layoutControl1.Controls.Add(Me.htmlOverviewDescription)
            Me.layoutControl1.Controls.Add(Me.htmlContentControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(5, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1822, 1242, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(1051, 651)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1})
            Me.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.Root.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 100R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute
            columnDefinition2.Width = 620R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute
            columnDefinition3.Width = 397R
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition4.Width = 100R
            Me.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3, columnDefinition4})
            rowDefinition1.Height = 100R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition2.Height = 630R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute
            rowDefinition3.Height = 100R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            Me.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3})
            Me.Root.Size = New System.Drawing.Size(1051, 652)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.htmlOverviewDescription
            Me.layoutControlItem2.Location = New System.Drawing.Point(627, 1)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(397, 630)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.htmlContentControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(7, 1)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(0, 670)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(24, 670)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(620, 630)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' Overview
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Overview"
            Me.Size = New System.Drawing.Size(1056, 656)
            CType((Me.htmlContentControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.htmlContentControl.ResumeLayout(False)
            CType((Me.textEditPhone.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditEmail.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditFullName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditDisplayName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.htmlOverviewDescription), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlContentControl As DevExpress.XtraEditors.HtmlContentControl

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private textEditPhone As DevExpress.XtraEditors.TextEdit

        Private textEditEmail As DevExpress.XtraEditors.TextEdit

        Private textEditFullName As DevExpress.XtraEditors.TextEdit

        Private textEditDisplayName As DevExpress.XtraEditors.TextEdit

        Private htmlOverviewDescription As DevExpress.XtraEditors.HtmlContentControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
