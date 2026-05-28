Namespace DevExpress.HTML.Demos

    Partial Class PreviewCoreContentProperties

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
            Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' propertyGridControl1
            ' 
            Me.propertyGridControl1.ActiveViewType = DevExpress.XtraVerticalGrid.PropertyGridView.Office
            Me.propertyGridControl1.AutoGenerateRows = False
            Me.propertyGridControl1.BandsInterval = 1
            Me.propertyGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGridControl1.Location = New System.Drawing.Point(4, 8)
            Me.propertyGridControl1.Name = "propertyGridControl1"
            Me.propertyGridControl1.OptionsBehavior.AllowSort = False
            Me.propertyGridControl1.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort
            Me.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl1.OptionsView.EditorAlignment = DevExpress.XtraVerticalGrid.EditorAlignment.Stretch
            Me.propertyGridControl1.OptionsView.MinRowAutoHeight = 19
            Me.propertyGridControl1.AutoSize = True
            Me.propertyGridControl1.Size = New System.Drawing.Size(92, 88)
            Me.propertyGridControl1.TabIndex = 0
            ' 
            ' PreviewCoreContentProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(Me.propertyGridControl1)
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.Name = "PreviewCoreContentProperties"
            Me.Padding = New System.Windows.Forms.Padding(4, 8, 4, 4)
            Me.Size = New System.Drawing.Size(100, 100)
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
    End Class
End Namespace
