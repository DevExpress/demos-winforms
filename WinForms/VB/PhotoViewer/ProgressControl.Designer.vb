Namespace PhotoViewer

    Partial Class ProgressControl

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
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(136, 9)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(82, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Processing folder"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.progressBarControl1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(355, 57)
            Me.panelControl1.TabIndex = 1
            ' 
            ' progressBarControl1
            ' 
            Me.progressBarControl1.Location = New System.Drawing.Point(5, 31)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Size = New System.Drawing.Size(345, 18)
            Me.progressBarControl1.TabIndex = 1
            ' 
            ' ProgressControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "ProgressControl"
            Me.Size = New System.Drawing.Size(355, 57)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    End Class
End Namespace
