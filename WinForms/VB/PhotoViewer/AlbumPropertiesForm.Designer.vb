Namespace PhotoViewer

    Partial Class AlbumPropertiesForm

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
            Me.albumNameEdit = New DevExpress.XtraEditors.TextEdit()
            Me.AlbumPropertiesFormConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.albumDescriptionCore = New DevExpress.XtraEditors.MemoEdit()
            Me._albumDate = New DevExpress.XtraEditors.DateEdit()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            CType((Me.albumNameEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.AlbumPropertiesFormConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AlbumPropertiesFormConvertedLayout.SuspendLayout()
            CType((Me.albumDescriptionCore.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me._albumDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me._albumDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' albumNameEdit
            ' 
            Me.albumNameEdit.Location = New System.Drawing.Point(86, 12)
            Me.albumNameEdit.Name = "albumNameEdit"
            Me.albumNameEdit.Size = New System.Drawing.Size(301, 20)
            Me.albumNameEdit.StyleController = Me.AlbumPropertiesFormConvertedLayout
            Me.albumNameEdit.TabIndex = 1
            ' 
            ' AlbumPropertiesFormConvertedLayout
            ' 
            Me.AlbumPropertiesFormConvertedLayout.Controls.Add(Me.albumDescriptionCore)
            Me.AlbumPropertiesFormConvertedLayout.Controls.Add(Me._albumDate)
            Me.AlbumPropertiesFormConvertedLayout.Controls.Add(Me.albumNameEdit)
            Me.AlbumPropertiesFormConvertedLayout.Controls.Add(Me.simpleButton2)
            Me.AlbumPropertiesFormConvertedLayout.Controls.Add(Me.simpleButton1)
            Me.AlbumPropertiesFormConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AlbumPropertiesFormConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.AlbumPropertiesFormConvertedLayout.Name = "AlbumPropertiesFormConvertedLayout"
            Me.AlbumPropertiesFormConvertedLayout.Root = Me.layoutControlGroup1
            Me.AlbumPropertiesFormConvertedLayout.Size = New System.Drawing.Size(399, 207)
            Me.AlbumPropertiesFormConvertedLayout.TabIndex = 8
            ' 
            ' albumDescriptionCore
            ' 
            Me.albumDescriptionCore.Location = New System.Drawing.Point(86, 60)
            Me.albumDescriptionCore.Name = "albumDescriptionCore"
            Me.albumDescriptionCore.Size = New System.Drawing.Size(301, 109)
            Me.albumDescriptionCore.StyleController = Me.AlbumPropertiesFormConvertedLayout
            Me.albumDescriptionCore.TabIndex = 5
            ' 
            ' _albumDate
            ' 
            Me._albumDate.EditValue = Nothing
            Me._albumDate.Location = New System.Drawing.Point(86, 36)
            Me._albumDate.Name = "_albumDate"
            Me._albumDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me._albumDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me._albumDate.Size = New System.Drawing.Size(301, 20)
            Me._albumDate.StyleController = Me.AlbumPropertiesFormConvertedLayout
            Me._albumDate.TabIndex = 3
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(231, 173)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(75, 22)
            Me.simpleButton2.StyleController = Me.AlbumPropertiesFormConvertedLayout
            Me.simpleButton2.TabIndex = 7
            Me.simpleButton2.Text = "OK"
            AddHandler Me.simpleButton2.Click, New System.EventHandler(AddressOf Me.simpleButton2_Click)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.simpleButton1.Location = New System.Drawing.Point(312, 173)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 22)
            Me.simpleButton1.StyleController = Me.AlbumPropertiesFormConvertedLayout
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "Cancel"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(399, 207)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.albumDescriptionCore
            Me.layoutControlItem1.CustomizationFormText = "Description:"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem1.Name = "albumDescriptionitem"
            Me.layoutControlItem1.Size = New System.Drawing.Size(379, 113)
            Me.layoutControlItem1.Text = "Description:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me._albumDate
            Me.layoutControlItem2.CustomizationFormText = "Date:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "albumDateitem"
            Me.layoutControlItem2.Size = New System.Drawing.Size(379, 24)
            Me.layoutControlItem2.Text = "Date:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.albumNameEdit
            Me.layoutControlItem3.CustomizationFormText = "Album name:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "albumNameEdititem"
            Me.layoutControlItem3.Size = New System.Drawing.Size(379, 24)
            Me.layoutControlItem3.Text = "Album name:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.simpleButton2
            Me.layoutControlItem4.CustomizationFormText = "simpleButton2item"
            Me.layoutControlItem4.Location = New System.Drawing.Point(219, 161)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(80, 26)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(29, 26)
            Me.layoutControlItem4.Name = "simpleButton2item"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 3, 2, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(80, 26)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.simpleButton1
            Me.layoutControlItem5.CustomizationFormText = "simpleButton1item"
            Me.layoutControlItem5.Location = New System.Drawing.Point(299, 161)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(80, 26)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(47, 26)
            Me.layoutControlItem5.Name = "simpleButton1item"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 2, 2, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(80, 26)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 161)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(219, 26)
            ' 
            ' AlbumPropertiesForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(399, 207)
            Me.Controls.Add(Me.AlbumPropertiesFormConvertedLayout)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "AlbumPropertiesForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "NewAlbumForm"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.NewAlbumForm_Load)
            CType((Me.albumNameEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.AlbumPropertiesFormConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.AlbumPropertiesFormConvertedLayout.ResumeLayout(False)
            CType((Me.albumDescriptionCore.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me._albumDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me._albumDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private albumNameEdit As DevExpress.XtraEditors.TextEdit

        Private _albumDate As DevExpress.XtraEditors.DateEdit

        Private albumDescriptionCore As DevExpress.XtraEditors.MemoEdit

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private AlbumPropertiesFormConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    End Class
End Namespace
