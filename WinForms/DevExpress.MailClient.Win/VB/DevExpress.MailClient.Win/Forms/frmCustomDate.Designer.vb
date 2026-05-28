Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmCustomDate
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmCustomDate))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Image = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutItem.GradientMode = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutItem.Image = (DirectCast(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.layoutControl1.Controls.Add(Me.dateEdit2)
            Me.layoutControl1.Controls.Add(Me.dateEdit1)
            Me.layoutControl1.Controls.Add(Me.sbCancel)
            Me.layoutControl1.Controls.Add(Me.sbOK)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(738, 385, 450, 350)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Image = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Image = (DirectCast(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.OptionsView.RightToLeftMirroringApplied = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' dateEdit2
            ' 
            resources.ApplyResources(Me.dateEdit2, "dateEdit2")
            Me.dateEdit2.Name = "dateEdit2"
            Me.dateEdit2.Properties.AccessibleDescription = resources.GetString("dateEdit2.Properties.AccessibleDescription")
            Me.dateEdit2.Properties.AccessibleName = resources.GetString("dateEdit2.Properties.AccessibleName")
            Me.dateEdit2.Properties.AutoHeight = (DirectCast(resources.GetObject("dateEdit2.Properties.AutoHeight"), Boolean))
            Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("dateEdit2.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.dateEdit2.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("dateEdit2.Properties.CalendarTimeProperties.AccessibleDescription")
            Me.dateEdit2.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("dateEdit2.Properties.CalendarTimeProperties.AccessibleName")
            Me.dateEdit2.Properties.CalendarTimeProperties.AutoHeight = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.AutoHeight"), Boolean))
            Me.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.AutoComplete = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.BeepOnError = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("dateEdit2.Properties.CalendarTimeProperties.Mask.EditMask")
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.MaskType = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.PlaceHolder = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.SaveLiteral = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean))
            Me.dateEdit2.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.dateEdit2.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("dateEdit2.Properties.CalendarTimeProperties.NullValuePrompt")
            Me.dateEdit2.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("dateEdit2.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.dateEdit2.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.dateEdit2.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.BeepOnError"), Boolean))
            Me.dateEdit2.Properties.Mask.EditMask = resources.GetString("dateEdit2.Properties.Mask.EditMask")
            Me.dateEdit2.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.dateEdit2.Properties.Mask.MaskType = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.dateEdit2.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.PlaceHolder"), Char))
            Me.dateEdit2.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.SaveLiteral"), Boolean))
            Me.dateEdit2.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.dateEdit2.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("dateEdit2.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.dateEdit2.Properties.NullValuePrompt = resources.GetString("dateEdit2.Properties.NullValuePrompt")
            Me.dateEdit2.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("dateEdit2.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.dateEdit2.StyleController = Me.layoutControl1
            ' 
            ' dateEdit1
            ' 
            resources.ApplyResources(Me.dateEdit1, "dateEdit1")
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.AccessibleDescription = resources.GetString("dateEdit1.Properties.AccessibleDescription")
            Me.dateEdit1.Properties.AccessibleName = resources.GetString("dateEdit1.Properties.AccessibleName")
            Me.dateEdit1.Properties.AutoHeight = (DirectCast(resources.GetObject("dateEdit1.Properties.AutoHeight"), Boolean))
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("dateEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.dateEdit1.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("dateEdit1.Properties.CalendarTimeProperties.AccessibleDescription")
            Me.dateEdit1.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("dateEdit1.Properties.CalendarTimeProperties.AccessibleName")
            Me.dateEdit1.Properties.CalendarTimeProperties.AutoHeight = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.AutoHeight"), Boolean))
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.AutoComplete = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.BeepOnError = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("dateEdit1.Properties.CalendarTimeProperties.Mask.EditMask")
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.MaskType = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.PlaceHolder = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.SaveLiteral = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean))
            Me.dateEdit1.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.dateEdit1.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("dateEdit1.Properties.CalendarTimeProperties.NullValuePrompt")
            Me.dateEdit1.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.dateEdit1.Properties.Mask.AutoComplete = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.dateEdit1.Properties.Mask.BeepOnError = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.BeepOnError"), Boolean))
            Me.dateEdit1.Properties.Mask.EditMask = resources.GetString("dateEdit1.Properties.Mask.EditMask")
            Me.dateEdit1.Properties.Mask.IgnoreMaskBlank = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.dateEdit1.Properties.Mask.MaskType = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.dateEdit1.Properties.Mask.PlaceHolder = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.PlaceHolder"), Char))
            Me.dateEdit1.Properties.Mask.SaveLiteral = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.SaveLiteral"), Boolean))
            Me.dateEdit1.Properties.Mask.ShowPlaceHolders = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("dateEdit1.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.dateEdit1.Properties.NullValuePrompt = resources.GetString("dateEdit1.Properties.NullValuePrompt")
            Me.dateEdit1.Properties.NullValuePromptShowForEmptyValue = (DirectCast(resources.GetObject("dateEdit1.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.dateEdit1.StyleController = Me.layoutControl1
            ' 
            ' sbCancel
            ' 
            resources.ApplyResources(Me.sbCancel, "sbCancel")
            Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.sbCancel.Name = "sbCancel"
            Me.sbCancel.StyleController = Me.layoutControl1
            ' 
            ' sbOK
            ' 
            resources.ApplyResources(Me.sbOK, "sbOK")
            Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.sbOK.Name = "sbOK"
            Me.sbOK.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem1, Me.layoutControlItem4, Me.emptySpaceItem2, Me.layoutControlItem5, Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(275, 119)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(255, 25)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem4
            ' 
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Control = Me.sbOK
            Me.layoutControlItem4.Location = New System.Drawing.Point(99, 73)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(77, 26)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 73)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(99, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem5
            ' 
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Control = Me.sbCancel
            Me.layoutControlItem5.Location = New System.Drawing.Point(176, 73)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(79, 26)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Control = Me.dateEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(255, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' layoutControlItem2
            ' 
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Control = Me.dateEdit2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(255, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' dxValidationProvider1
            ' 
            Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
            ' 
            ' frmCustomDate
            ' 
            Me.AcceptButton = Me.sbOK
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.sbCancel
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "frmCustomDate"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private sbOK As DevExpress.XtraEditors.SimpleButton
        Private sbCancel As DevExpress.XtraEditors.SimpleButton
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
        Private dateEdit2 As DevExpress.XtraEditors.DateEdit
        Private dateEdit1 As DevExpress.XtraEditors.DateEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
