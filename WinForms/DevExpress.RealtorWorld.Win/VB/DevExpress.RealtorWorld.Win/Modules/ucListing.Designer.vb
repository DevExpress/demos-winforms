Namespace DevExpress.RealtorWorld.Win

    Partial Class ucListing

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
            Me.pnlList = New DevExpress.XtraEditors.TileControl()
            Me.pnlDetail = New DevExpress.XtraEditors.PanelControl()
            Me.ucHomeDetail1 = New DevExpress.RealtorWorld.Win.ucHomeDetail()
            CType((Me.pnlDetail), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlDetail.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' pnlList
            ' 
            Me.pnlList.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[Default]
            Me.pnlList.AllowItemHover = True
            Me.pnlList.AllowSelectedItem = True
            Me.pnlList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.pnlList.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlList.IndentBetweenItems = 6
            Me.pnlList.ItemPadding = New System.Windows.Forms.Padding(3)
            Me.pnlList.Location = New System.Drawing.Point(0, 0)
            Me.pnlList.Name = "pnlList"
            Me.pnlList.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.pnlList.Padding = New System.Windows.Forms.Padding(6)
            Me.pnlList.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar
            Me.pnlList.Size = New System.Drawing.Size(226, 678)
            Me.pnlList.TabIndex = 2
            Me.pnlList.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            AddHandler Me.pnlList.ItemClick, New DevExpress.XtraEditors.TileItemClickEventHandler(AddressOf Me.pnlList_ItemClick)
            ' 
            ' pnlDetail
            ' 
            Me.pnlDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlDetail.Controls.Add(Me.ucHomeDetail1)
            Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetail.Location = New System.Drawing.Point(226, 0)
            Me.pnlDetail.Name = "pnlDetail"
            Me.pnlDetail.Size = New System.Drawing.Size(1051, 678)
            Me.pnlDetail.TabIndex = 1
            ' 
            ' ucHomeDetail1
            ' 
            Me.ucHomeDetail1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucHomeDetail1.FullLayout = True
            Me.ucHomeDetail1.Location = New System.Drawing.Point(0, 0)
            Me.ucHomeDetail1.Name = "ucHomeDetail1"
            Me.ucHomeDetail1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.ucHomeDetail1.Size = New System.Drawing.Size(1051, 678)
            Me.ucHomeDetail1.TabIndex = 0
            ' 
            ' ucListing
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlDetail)
            Me.Controls.Add(Me.pnlList)
            Me.Name = "ucListing"
            Me.Size = New System.Drawing.Size(1277, 678)
            Me.Tag = ""
            CType((Me.pnlDetail), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlDetail.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pnlList As DevExpress.XtraEditors.TileControl

        Private pnlDetail As DevExpress.XtraEditors.PanelControl

        Private ucHomeDetail1 As DevExpress.RealtorWorld.Win.ucHomeDetail
    End Class
End Namespace
