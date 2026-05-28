Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class NewContactForm
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
            Me.lcFirstName = New DevExpress.XtraEditors.LabelControl()
            Me.lcLastName = New DevExpress.XtraEditors.LabelControl()
            Me.lcAddress = New DevExpress.XtraEditors.LabelControl()
            Me.lcEmail = New DevExpress.XtraEditors.LabelControl()
            Me.lcPhoneNumber = New DevExpress.XtraEditors.LabelControl()
            Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
            Me.teLastName = New DevExpress.XtraEditors.TextEdit()
            Me.teAddress = New DevExpress.XtraEditors.TextEdit()
            Me.teEmail = New DevExpress.XtraEditors.TextEdit()
            Me.tePhone = New DevExpress.XtraEditors.TextEdit()
            Me.sbOk = New DevExpress.XtraEditors.SimpleButton()
            Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lcFirstName
            '
            Me.lcFirstName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcFirstName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.lcFirstName.Location = New System.Drawing.Point(28, 83)
            Me.lcFirstName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.lcFirstName.Name = "lcFirstName"
            Me.lcFirstName.Size = New System.Drawing.Size(75, 16)
            Me.lcFirstName.TabIndex = 0
            Me.lcFirstName.Text = "*First Name:"
            '
            'lcLastName
            '
            Me.lcLastName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcLastName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.lcLastName.Location = New System.Drawing.Point(28, 117)
            Me.lcLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.lcLastName.Name = "lcLastName"
            Me.lcLastName.Size = New System.Drawing.Size(73, 16)
            Me.lcLastName.TabIndex = 1
            Me.lcLastName.Text = "*Last Name:"
            '
            'lcAddress
            '
            Me.lcAddress.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcAddress.Location = New System.Drawing.Point(28, 151)
            Me.lcAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.lcAddress.Name = "lcAddress"
            Me.lcAddress.Size = New System.Drawing.Size(51, 16)
            Me.lcAddress.TabIndex = 2
            Me.lcAddress.Text = "Address:"
            '
            'lcEmail
            '
            Me.lcEmail.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcEmail.Location = New System.Drawing.Point(28, 186)
            Me.lcEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.lcEmail.Name = "lcEmail"
            Me.lcEmail.Size = New System.Drawing.Size(36, 16)
            Me.lcEmail.TabIndex = 3
            Me.lcEmail.Text = "Email:"
            '
            'lcPhoneNumber
            '
            Me.lcPhoneNumber.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcPhoneNumber.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.lcPhoneNumber.Location = New System.Drawing.Point(28, 220)
            Me.lcPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.lcPhoneNumber.Name = "lcPhoneNumber"
            Me.lcPhoneNumber.Size = New System.Drawing.Size(89, 16)
            Me.lcPhoneNumber.TabIndex = 4
            Me.lcPhoneNumber.Text = "Phone Number:"
            '
            'teFirstName
            '
            Me.teFirstName.Location = New System.Drawing.Point(140, 80)
            Me.teFirstName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.teFirstName.Name = "teFirstName"
            Me.teFirstName.Size = New System.Drawing.Size(187, 22)
            Me.teFirstName.TabIndex = 5
            '
            'teLastName
            '
            Me.teLastName.Location = New System.Drawing.Point(140, 114)
            Me.teLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.teLastName.Name = "teLastName"
            Me.teLastName.Size = New System.Drawing.Size(187, 22)
            Me.teLastName.TabIndex = 6
            '
            'teAddress
            '
            Me.teAddress.Location = New System.Drawing.Point(140, 148)
            Me.teAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.teAddress.Name = "teAddress"
            Me.teAddress.Size = New System.Drawing.Size(187, 22)
            Me.teAddress.TabIndex = 7
            '
            'teEmail
            '
            Me.teEmail.Location = New System.Drawing.Point(140, 182)
            Me.teEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.teEmail.Name = "teEmail"
            Me.teEmail.Size = New System.Drawing.Size(187, 22)
            Me.teEmail.TabIndex = 8
            '
            'tePhone
            '
            Me.tePhone.Location = New System.Drawing.Point(140, 217)
            Me.tePhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.tePhone.Name = "tePhone"
            Me.tePhone.Properties.Mask.EditMask = "(999)000-00-00"
            Me.tePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            Me.tePhone.Size = New System.Drawing.Size(121, 22)
            Me.tePhone.TabIndex = 9
            '
            'sbOk
            '
            Me.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.sbOk.Enabled = False
            Me.sbOk.Location = New System.Drawing.Point(75, 308)
            Me.sbOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbOk.Name = "sbOk"
            Me.sbOk.Size = New System.Drawing.Size(87, 33)
            Me.sbOk.TabIndex = 10
            Me.sbOk.Text = "OK"
            '
            'sbCancel
            '
            Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.sbCancel.Location = New System.Drawing.Point(168, 308)
            Me.sbCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.sbCancel.Name = "sbCancel"
            Me.sbCancel.Size = New System.Drawing.Size(87, 33)
            Me.sbCancel.TabIndex = 11
            Me.sbCancel.Text = "Cancel"
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(269, 16)
            Me.labelControl1.TabIndex = 12
            Me.labelControl1.Text = " * Fields marked with an asterisk are required."
            '
            'NewContactForm
            '
            Me.AcceptButton = Me.sbOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.sbCancel
            Me.ClientSize = New System.Drawing.Size(344, 352)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.lcPhoneNumber)
            Me.Controls.Add(Me.lcEmail)
            Me.Controls.Add(Me.lcAddress)
            Me.Controls.Add(Me.lcLastName)
            Me.Controls.Add(Me.lcFirstName)
            Me.Controls.Add(Me.sbCancel)
            Me.Controls.Add(Me.sbOk)
            Me.Controls.Add(Me.tePhone)
            Me.Controls.Add(Me.teEmail)
            Me.Controls.Add(Me.teAddress)
            Me.Controls.Add(Me.teLastName)
            Me.Controls.Add(Me.teFirstName)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "NewContactForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "New Contact"
            CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private lcFirstName As DevExpress.XtraEditors.LabelControl
        Private lcLastName As DevExpress.XtraEditors.LabelControl
        Private lcAddress As DevExpress.XtraEditors.LabelControl
        Private lcEmail As DevExpress.XtraEditors.LabelControl
        Private lcPhoneNumber As DevExpress.XtraEditors.LabelControl
        Private WithEvents teFirstName As DevExpress.XtraEditors.TextEdit
        Private WithEvents teLastName As DevExpress.XtraEditors.TextEdit
        Private teAddress As DevExpress.XtraEditors.TextEdit
        Private teEmail As DevExpress.XtraEditors.TextEdit
        Private tePhone As DevExpress.XtraEditors.TextEdit
        Private sbOk As DevExpress.XtraEditors.SimpleButton
        Private sbCancel As DevExpress.XtraEditors.SimpleButton
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private components As System.ComponentModel.IContainer = Nothing

    End Class
End Namespace
