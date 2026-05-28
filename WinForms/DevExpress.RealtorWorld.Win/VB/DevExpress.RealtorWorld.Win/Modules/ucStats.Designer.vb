Namespace DevExpress.RealtorWorld.Win

    Partial Class ucStats

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
            Me.ucStatistics1 = New DevExpress.RealtorWorld.Win.ucStatistics()
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
            Me.pnlList.Size = New System.Drawing.Size(226, 640)
            Me.pnlList.TabIndex = 3
            Me.pnlList.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            AddHandler Me.pnlList.ItemClick, New DevExpress.XtraEditors.TileItemClickEventHandler(AddressOf Me.pnlList_ItemClick_1)
            ' 
            ' ucStatistics1
            ' 
            Me.ucStatistics1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucStatistics1.Location = New System.Drawing.Point(226, 0)
            Me.ucStatistics1.Name = "ucStatistics1"
            Me.ucStatistics1.Size = New System.Drawing.Size(1041, 640)
            Me.ucStatistics1.TabIndex = 4
            ' 
            ' ucStats
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ucStatistics1)
            Me.Controls.Add(Me.pnlList)
            Me.Name = "ucStats"
            Me.Size = New System.Drawing.Size(1267, 640)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pnlList As DevExpress.XtraEditors.TileControl

        Private ucStatistics1 As DevExpress.RealtorWorld.Win.ucStatistics
    End Class
End Namespace
