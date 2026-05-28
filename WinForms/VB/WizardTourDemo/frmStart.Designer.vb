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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.simpleButton1.Location = New System.Drawing.Point(10, 266)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(187, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Start Demo!"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.checkEdit2)
            Me.panelControl1.Controls.Add(Me.checkEdit1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(10, 208)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(187, 58)
            Me.panelControl1.TabIndex = 1
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.EditValue = True
            Me.checkEdit2.Location = New System.Drawing.Point(0, 29)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Allow Form Skin"
            Me.checkEdit2.Size = New System.Drawing.Size(172, 20)
            Me.checkEdit2.TabIndex = 1
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.EditValue = True
            Me.checkEdit1.Location = New System.Drawing.Point(0, 8)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Allow Transition Animation"
            Me.checkEdit1.Size = New System.Drawing.Size(172, 20)
            Me.checkEdit1.TabIndex = 0
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(10, 10)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(187, 198)
            Me.listBoxControl1.TabIndex = 2
            AddHandler Me.listBoxControl1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.listBoxControl1_SelectedIndexChanged)
            ' 
            ' frmStart
            ' 
            Me.AcceptButton = Me.simpleButton1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.simpleButton1
            Me.ClientSize = New System.Drawing.Size(207, 299)
            Me.ControlBox = False
            Me.Controls.Add(Me.listBoxControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.simpleButton1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.IconOptions.Icon = CType((resources.GetObject("frmStart.IconOptions.Icon")), System.Drawing.Icon)
            Me.Name = "frmStart"
            Me.Padding = New System.Windows.Forms.Padding(10)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Choose skin"
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit2 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
