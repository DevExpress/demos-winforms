Namespace DevExpress.DevAV

    Partial Class InvoiceSettingsControl

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
            Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
            CType((Me.checkedListBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.checkedListBoxControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.checkedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Header"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Footer"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Status"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Comments")})
            Me.checkedListBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
            Me.checkedListBoxControl1.Size = New System.Drawing.Size(204, 167)
            Me.checkedListBoxControl1.TabIndex = 0
            AddHandler Me.checkedListBoxControl1.ItemCheck, New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(AddressOf Me.checkedListBoxControl1_ItemCheck)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.checkedListBoxControl1)
            Me.Name = "InvoiceSettingsControl"
            Me.Size = New System.Drawing.Size(204, 167)
            CType((Me.checkedListBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    End Class
End Namespace
