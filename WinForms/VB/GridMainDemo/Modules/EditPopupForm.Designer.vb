Namespace DevExpress.XtraGrid.Demos

    Partial Class PopupForm

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.cardView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(336, 259)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cardView1})
            ' 
            ' cardView1
            ' 
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.MaximumCardColumns = 1
            Me.cardView1.MaximumCardRows = 1
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.AutoHorzWidth = True
            Me.cardView1.OptionsView.ShowHorzScrollBar = False
            Me.cardView1.OptionsView.ShowLines = False
            Me.cardView1.OptionsView.ShowQuickCustomizeButton = False
            Me.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.simpleButton1.Location = New System.Drawing.Point(172, 222)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(76, 30)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "&OK"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.simpleButton2.Location = New System.Drawing.Point(252, 222)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(80, 30)
            Me.simpleButton2.TabIndex = 2
            Me.simpleButton2.Text = "&Cancel"
            ' 
            ' PopupForm
            ' 
            Me.AcceptButton = Me.simpleButton1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.simpleButton2
            Me.ClientSize = New System.Drawing.Size(336, 259)
            Me.Controls.Add(Me.simpleButton2)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.gridControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "PopupForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Record Editor"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace
