Namespace DevExpress.XtraBars.Demos.DockingDemo

    Partial Class ucOutput

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
            Me.textBox = New DevExpress.XtraEditors.MemoEdit()
            Me.comboBox = New DevExpress.XtraEditors.ComboBoxEdit()
            CType((Me.textBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textBox
            ' 
            Me.textBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox.EditValue = ""
            Me.textBox.Location = New System.Drawing.Point(0, 20)
            Me.textBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.textBox.Name = "textBox"
            Me.textBox.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 8.25F)
            Me.textBox.Properties.Appearance.Options.UseFont = True
            Me.textBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textBox.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.textBox.Properties.WordWrap = False
            Me.textBox.Size = New System.Drawing.Size(717, 178)
            Me.textBox.TabIndex = 2
            AddHandler Me.textBox.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.textBox_KeyDown)
            ' 
            ' comboBox
            ' 
            Me.comboBox.Dock = System.Windows.Forms.DockStyle.Top
            Me.comboBox.Location = New System.Drawing.Point(0, 0)
            Me.comboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.comboBox.Name = "comboBox"
            Me.comboBox.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            Me.comboBox.Properties.Appearance.Options.UseFont = True
            Me.comboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBox.Properties.Items.AddRange(New Object() {"Build", "Debug"})
            Me.comboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBox.Size = New System.Drawing.Size(717, 20)
            Me.comboBox.TabIndex = 1
            AddHandler Me.comboBox.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox_SelectedIndexChanged)
            ' 
            ' ucOutput
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.textBox)
            Me.Controls.Add(Me.comboBox)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "ucOutput"
            Me.Size = New System.Drawing.Size(717, 198)
            CType((Me.textBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private textBox As DevExpress.XtraEditors.MemoEdit

        Private comboBox As DevExpress.XtraEditors.ComboBoxEdit
    End Class
End Namespace
