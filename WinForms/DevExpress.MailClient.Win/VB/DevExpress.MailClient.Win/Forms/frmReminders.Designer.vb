Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmReminders
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmReminders))
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lbDueDate = New DevExpress.XtraEditors.LabelControl()
            Me.lbSubject = New DevExpress.XtraEditors.LabelControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDueIn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sbClose = New DevExpress.XtraEditors.SimpleButton()
            Me.sbOpen = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(275, 119)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "Root"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(275, 119)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.lbDueDate)
            Me.layoutControl1.Controls.Add(Me.lbSubject)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.sbClose)
            Me.layoutControl1.Controls.Add(Me.sbOpen)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(738, 385, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup3
            ' 
            ' lbDueDate
            ' 
            resources.ApplyResources(Me.lbDueDate, "lbDueDate")
            Me.lbDueDate.Name = "lbDueDate"
            Me.lbDueDate.StyleController = Me.layoutControl1
            ' 
            ' lbSubject
            ' 
            Me.lbSubject.AllowHtmlString = True
            resources.ApplyResources(Me.lbSubject, "lbSubject")
            Me.lbSubject.Name = "lbSubject"
            Me.lbSubject.StyleController = Me.layoutControl1
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSubject, Me.colDueIn})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDueIn, DevExpress.Data.ColumnSortOrder.Descending)})
            ' 
            ' colSubject
            ' 
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.OptionsColumn.AllowEdit = False
            Me.colSubject.OptionsColumn.AllowFocus = False
            resources.ApplyResources(Me.colSubject, "colSubject")
            ' 
            ' colDueIn
            ' 
            resources.ApplyResources(Me.colDueIn, "colDueIn")
            Me.colDueIn.FieldName = "DueIn"
            Me.colDueIn.Name = "colDueIn"
            Me.colDueIn.OptionsColumn.AllowEdit = False
            Me.colDueIn.OptionsColumn.AllowFocus = False
            Me.colDueIn.UnboundExpression = "DateDiffDay(Now(), [Due Date])"
            Me.colDueIn.UnboundType = DevExpress.Data.UnboundColumnType.Integer
            ' 
            ' sbClose
            ' 
            Me.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            resources.ApplyResources(Me.sbClose, "sbClose")
            Me.sbClose.Name = "sbClose"
            Me.sbClose.StyleController = Me.layoutControl1
            ' 
            ' sbOpen
            ' 
            Me.sbOpen.DialogResult = System.Windows.Forms.DialogResult.OK
            resources.ApplyResources(Me.sbOpen, "sbOpen")
            Me.sbOpen.Name = "sbOpen"
            Me.sbOpen.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup3
            ' 
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem1, Me.layoutControlItem4, Me.emptySpaceItem2, Me.layoutControlItem5, Me.layoutControlItem1, Me.emptySpaceItem3, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(679, 433)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 34)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(659, 16)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.sbOpen
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(465, 387)
            Me.layoutControlItem4.MaxSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(97, 26)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 387)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(465, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.sbClose
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(562, 387)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(97, 26)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(97, 26)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 50)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(659, 326)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 376)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(659, 11)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.lbSubject
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(659, 17)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.lbDueDate
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 17)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(659, 17)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' frmReminders
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.sbClose
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "frmReminders"
            Me.ShowIcon = False
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private layoutControl1 As XtraLayout.LayoutControl
        Private sbClose As XtraEditors.SimpleButton
        Private sbOpen As XtraEditors.SimpleButton
        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private gridControl1 As XtraGrid.GridControl
        Private WithEvents gridView1 As XtraGrid.Views.Grid.GridView
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private colSubject As XtraGrid.Columns.GridColumn
        Private colDueIn As XtraGrid.Columns.GridColumn
        Private lbDueDate As XtraEditors.LabelControl
        Private lbSubject As XtraEditors.LabelControl
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
    End Class
End Namespace
