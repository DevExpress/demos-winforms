Namespace DevExpress.XtraRichEdit.Demos.Forms

    Partial Class MergeDatabaseRecordsForm

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
            Me.rgMergeRecords = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            Me.rgMergeTo = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.rgMergeRecords.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rgMergeTo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' rgMergeRecords
            ' 
            Me.rgMergeRecords.Location = New System.Drawing.Point(13, 31)
            Me.rgMergeRecords.Name = "rgMergeRecords"
            Me.rgMergeRecords.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgMergeRecords.Properties.Appearance.Options.UseBackColor = True
            Me.rgMergeRecords.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgMergeRecords.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Selected"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "All")})
            Me.rgMergeRecords.Size = New System.Drawing.Size(211, 52)
            Me.rgMergeRecords.TabIndex = 0
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl2.LineVisible = True
            Me.labelControl2.Location = New System.Drawing.Point(13, 12)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(205, 13)
            Me.labelControl2.TabIndex = 4
            Me.labelControl2.Text = "Merge records"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(143, 136)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnCancel_Click)
            ' 
            ' btnOk
            ' 
            Me.btnOk.Location = New System.Drawing.Point(62, 136)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(75, 23)
            Me.btnOk.TabIndex = 2
            Me.btnOk.Text = "OK"
            AddHandler Me.btnOk.Click, New System.EventHandler(AddressOf Me.btnOk_Click)
            ' 
            ' rgMergeTo
            ' 
            Me.rgMergeTo.Location = New System.Drawing.Point(13, 108)
            Me.rgMergeTo.Name = "rgMergeTo"
            Me.rgMergeTo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgMergeTo.Properties.Appearance.Options.UseBackColor = True
            Me.rgMergeTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgMergeTo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Window"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "File")})
            Me.rgMergeTo.Size = New System.Drawing.Size(205, 22)
            Me.rgMergeTo.TabIndex = 1
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl3.LineVisible = True
            Me.labelControl3.Location = New System.Drawing.Point(13, 89)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(205, 13)
            Me.labelControl3.TabIndex = 9
            Me.labelControl3.Text = "Merge to"
            ' 
            ' MergeDatabaseRecordsForm
            ' 
            Me.AcceptButton = Me.btnOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(228, 168)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.rgMergeTo)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.rgMergeRecords)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.IconOptions.ShowIcon = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MergeDatabaseRecordsForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Merge Options"
            CType((Me.rgMergeRecords.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rgMergeTo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private rgMergeRecords As DevExpress.XtraEditors.RadioGroup

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private btnOk As DevExpress.XtraEditors.SimpleButton

        Private rgMergeTo As DevExpress.XtraEditors.RadioGroup

        Private labelControl3 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
