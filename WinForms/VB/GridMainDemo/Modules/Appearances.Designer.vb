Namespace DevExpress.XtraGrid.Demos

    Partial Class Appearances

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
            Me.lbcAppearances = New DevExpress.XtraEditors.ListBoxControl()
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.xtraPropertyGrid1 = New DevExpress.DXperience.Demos.XtraPropertyGrid()
            CType((Me.lbcAppearances), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' lbcAppearances
            ' 
            Me.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Left
            Me.lbcAppearances.ItemHeight = 16
            Me.lbcAppearances.Location = New System.Drawing.Point(5, 5)
            Me.lbcAppearances.Name = "lbcAppearances"
            Me.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.lbcAppearances.Size = New System.Drawing.Size(190, 306)
            Me.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending
            Me.lbcAppearances.TabIndex = 22
            AddHandler Me.lbcAppearances.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lbcAppearances_SelectedIndexChanged)
            ' 
            ' splitter1
            ' 
            Me.splitter1.Location = New System.Drawing.Point(195, 5)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(6, 306)
            Me.splitter1.TabIndex = 23
            Me.splitter1.TabStop = False
            ' 
            ' gcProperties
            ' 
            Me.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((153)))))), (CInt(((CByte((217)))))), (CInt(((CByte((255)))))))
            Me.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((78)))))), (CInt(((CByte((207)))))))
            Me.groupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.groupControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
            Me.groupControl1.AppearanceCaption.Options.UseBackColor = True
            Me.groupControl1.AppearanceCaption.Options.UseFont = True
            Me.groupControl1.Controls.Add(Me.xtraPropertyGrid1)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupControl1.Location = New System.Drawing.Point(201, 5)
            Me.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
            Me.groupControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(298, 306)
            Me.groupControl1.TabIndex = 24
            Me.groupControl1.Text = "Properties:"
            ' 
            ' xtraPropertyGrid1
            ' 
            Me.xtraPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraPropertyGrid1.Location = New System.Drawing.Point(2, 19)
            Me.xtraPropertyGrid1.Name = "xtraPropertyGrid1"
            Me.xtraPropertyGrid1.Size = New System.Drawing.Size(294, 285)
            Me.xtraPropertyGrid1.TabIndex = 0
            ' 
            ' Appearances
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(504, 316)
            Me.Controls.Add(Me.groupControl1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.lbcAppearances)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Appearances"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Appearances"
            CType((Me.lbcAppearances), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private lbcAppearances As DevExpress.XtraEditors.ListBoxControl

        Private splitter1 As DevExpress.XtraEditors.SplitterControl

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private xtraPropertyGrid1 As DevExpress.DXperience.Demos.XtraPropertyGrid
    End Class
End Namespace
