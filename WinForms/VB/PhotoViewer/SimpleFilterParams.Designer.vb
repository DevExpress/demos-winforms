Namespace PhotoViewer

    Partial Class SimpleFilterParams

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
            Me.applyFilterButton = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleFilterParamsConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.applyButtonItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.SimpleFilterParamsConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SimpleFilterParamsConvertedLayout.SuspendLayout()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.applyButtonItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' applyFilterButton
            ' 
            Me.applyFilterButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.applyFilterButton.Location = New System.Drawing.Point(132, 208)
            Me.applyFilterButton.Name = "applyFilterButton"
            Me.applyFilterButton.Size = New System.Drawing.Size(76, 24)
            Me.applyFilterButton.StyleController = Me.SimpleFilterParamsConvertedLayout
            Me.applyFilterButton.TabIndex = 1
            Me.applyFilterButton.Text = "Apply"
            ' 
            ' SimpleFilterParamsConvertedLayout
            ' 
            Me.SimpleFilterParamsConvertedLayout.Controls.Add(Me.applyFilterButton)
            Me.SimpleFilterParamsConvertedLayout.Controls.Add(Me.pictureEdit1)
            Me.SimpleFilterParamsConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleFilterParamsConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.SimpleFilterParamsConvertedLayout.Name = "SimpleFilterParamsConvertedLayout"
            Me.SimpleFilterParamsConvertedLayout.Root = Me.layoutControlGroup1
            Me.SimpleFilterParamsConvertedLayout.Size = New System.Drawing.Size(341, 308)
            Me.SimpleFilterParamsConvertedLayout.TabIndex = 5
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Location = New System.Drawing.Point(28, 28)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Size = New System.Drawing.Size(285, 146)
            Me.pictureEdit1.StyleController = Me.SimpleFilterParamsConvertedLayout
            Me.pictureEdit1.TabIndex = 2
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.applyButtonItem, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(26, 26, 26, 26)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(341, 308)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.pictureEdit1
            Me.layoutControlItem3.CustomizationFormText = "pictureEdit1item"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(0, 150)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(24, 24)
            Me.layoutControlItem3.Name = "pictureEdit1item"
            Me.layoutControlItem3.Size = New System.Drawing.Size(289, 150)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' applyButtonItem
            ' 
            Me.applyButtonItem.Control = Me.applyFilterButton
            Me.applyButtonItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.applyButtonItem.CustomizationFormText = "applyButtonItem"
            Me.applyButtonItem.Location = New System.Drawing.Point(0, 150)
            Me.applyButtonItem.MaxSize = New System.Drawing.Size(80, 58)
            Me.applyButtonItem.MinSize = New System.Drawing.Size(42, 58)
            Me.applyButtonItem.Name = "applyButtonItem"
            Me.applyButtonItem.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 32, 2)
            Me.applyButtonItem.Size = New System.Drawing.Size(289, 58)
            Me.applyButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.applyButtonItem.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 208)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(289, 48)
            ' 
            ' SimpleFilterParams
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SimpleFilterParamsConvertedLayout)
            Me.Name = "SimpleFilterParams"
            Me.Size = New System.Drawing.Size(341, 308)
            CType((Me.SimpleFilterParamsConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.SimpleFilterParamsConvertedLayout.ResumeLayout(False)
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.applyButtonItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected applyFilterButton As DevExpress.XtraEditors.SimpleButton

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Protected SimpleFilterParamsConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Protected layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Protected applyButtonItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
