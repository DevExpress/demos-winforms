Namespace DevExpress.XtraTreeList.Demos

    Partial Class NodesVisibility

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Left
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowExpandOnDblClick = False
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1, Me.repositoryItemComboBox1})
            Me.treeList1.Size = New System.Drawing.Size(536, 360)
            Me.treeList1.TabIndex = 1
            AddHandler Me.treeList1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.treeList1_MouseDown)
            ' 
            ' repositoryItemDateEdit1
            ' 
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Location = New System.Drawing.Point(536, 0)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(10, 360)
            Me.splitterControl1.TabIndex = 2
            Me.splitterControl1.TabStop = False
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(546, 0)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(131, 360)
            Me.listBoxControl1.TabIndex = 3
            AddHandler Me.listBoxControl1.DrawItem, New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(AddressOf Me.listBoxControl1_DrawItem)
            AddHandler Me.listBoxControl1.DoubleClick, New System.EventHandler(AddressOf Me.listBoxControl1_DoubleClick)
            ' 
            ' NodesVisibility
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.listBoxControl1)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.treeList1)
            Me.Name = "NodesVisibility"
            Me.Size = New System.Drawing.Size(677, 360)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl

        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl

        Private components As System.ComponentModel.IContainer = Nothing
    End Class
End Namespace
