Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class EditForm
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditForm))
            Me.lbName = New DevExpress.XtraEditors.LabelControl
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl
            Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.teOwner = New DevExpress.XtraEditors.TextEdit
            Me.deCreatedDate = New DevExpress.XtraEditors.DateEdit
            Me.bSave = New DevExpress.XtraEditors.SimpleButton
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teOwner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.deCreatedDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.deCreatedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lbName
            '
            Me.lbName.Appearance.Font = New System.Drawing.Font("Arial Black", 10.0!)
            Me.lbName.Appearance.Options.UseFont = True
            Me.lbName.Appearance.Options.UseTextOptions = True
            Me.lbName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbName.Dock = System.Windows.Forms.DockStyle.Top
            Me.lbName.LineVisible = True
            Me.lbName.Location = New System.Drawing.Point(0, 0)
            Me.lbName.Name = "lbName"
            Me.lbName.Size = New System.Drawing.Size(42, 18)
            Me.lbName.TabIndex = 0
            Me.lbName.Text = "Name"
            '
            'imageComboBoxEdit1
            '
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(153, 97)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(128, 20)
            Me.imageComboBoxEdit1.TabIndex = 1
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(73, 143)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(35, 13)
            Me.labelControl2.TabIndex = 2
            Me.labelControl2.Text = "Status:"
            '
            'labelControl3
            '
            Me.labelControl3.Location = New System.Drawing.Point(73, 101)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(28, 13)
            Me.labelControl3.TabIndex = 3
            Me.labelControl3.Text = "Type:"
            '
            'labelControl4
            '
            Me.labelControl4.Location = New System.Drawing.Point(73, 193)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(69, 13)
            Me.labelControl4.TabIndex = 4
            Me.labelControl4.Text = "Created Date:"
            '
            'labelControl5
            '
            Me.labelControl5.Location = New System.Drawing.Point(74, 56)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(36, 13)
            Me.labelControl5.TabIndex = 5
            Me.labelControl5.Text = "Owner:"
            '
            'imageComboBoxEdit2
            '
            Me.imageComboBoxEdit2.Location = New System.Drawing.Point(153, 143)
            Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
            Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit2.Size = New System.Drawing.Size(128, 20)
            Me.imageComboBoxEdit2.TabIndex = 6
            '
            'teOwner
            '
            Me.teOwner.Location = New System.Drawing.Point(153, 53)
            Me.teOwner.Name = "teOwner"
            Me.teOwner.Size = New System.Drawing.Size(128, 20)
            Me.teOwner.TabIndex = 7
            '
            'deCreatedDate
            '
            Me.deCreatedDate.EditValue = Nothing
            Me.deCreatedDate.Location = New System.Drawing.Point(153, 190)
            Me.deCreatedDate.Name = "deCreatedDate"
            Me.deCreatedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deCreatedDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.deCreatedDate.Size = New System.Drawing.Size(128, 20)
            Me.deCreatedDate.TabIndex = 8
            '
            'bSave
            '
            Me.bSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bSave.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
            Me.bSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.bSave.Location = New System.Drawing.Point(306, 231)
            Me.bSave.Name = "bSave"
            Me.bSave.Size = New System.Drawing.Size(32, 27)
            Me.bSave.TabIndex = 9
            Me.bSave.ToolTip = "Save Changes"
            '
            'EditForm
            '
            Me.AcceptButton = Me.bSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(348, 268)
            Me.Controls.Add(Me.bSave)
            Me.Controls.Add(Me.deCreatedDate)
            Me.Controls.Add(Me.teOwner)
            Me.Controls.Add(Me.imageComboBoxEdit2)
            Me.Controls.Add(Me.labelControl5)
            Me.Controls.Add(Me.labelControl4)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.lbName)
            Me.Controls.Add(Me.imageComboBoxEdit1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Project Edit Form"
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teOwner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.deCreatedDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.deCreatedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing
        Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
        Private labelControl4 As DevExpress.XtraEditors.LabelControl
        Private labelControl5 As DevExpress.XtraEditors.LabelControl
        Private imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private teOwner As DevExpress.XtraEditors.TextEdit
        Private deCreatedDate As DevExpress.XtraEditors.DateEdit
        Private bSave As DevExpress.XtraEditors.SimpleButton
        Private lbName As DevExpress.XtraEditors.LabelControl

    End Class
End Namespace
