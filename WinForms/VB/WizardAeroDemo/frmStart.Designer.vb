Namespace DevExpress.XtraWizard.Demos

    Partial Class frmStart

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraWizard.Demos.frmStart))
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.simpleButton1.Location = New System.Drawing.Point(10, 224)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(187, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Start Demo!"
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(10, 10)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(187, 201)
            Me.listBoxControl1.TabIndex = 2
            AddHandler Me.listBoxControl1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.listBoxControl1_SelectedIndexChanged)
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl2.Location = New System.Drawing.Point(10, 211)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(187, 13)
            Me.panelControl2.TabIndex = 3
            ' 
            ' frmStart
            ' 
            Me.AcceptButton = Me.simpleButton1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.simpleButton1
            Me.ClientSize = New System.Drawing.Size(207, 257)
            Me.ControlBox = False
            Me.Controls.Add(Me.listBoxControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.simpleButton1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.IconOptions.Icon = CType((resources.GetObject("frmStart.IconOptions.Icon")), System.Drawing.Icon)
            Me.Name = "frmStart"
            Me.Padding = New System.Windows.Forms.Padding(10)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Choose skin"
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
