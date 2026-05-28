Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class AddNewBonus

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
            Me.components = New System.ComponentModel.Container()
            Me.buttonOK = New DevExpress.XtraEditors.SimpleButton()
            Me.buttonCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.beExpression = New DevExpress.XtraEditors.ButtonEdit()
            Me.teBonusName = New DevExpress.XtraEditors.TextEdit()
            Me.labelInternalExpression = New DevExpress.XtraEditors.LabelControl()
            Me.labelBonusName = New DevExpress.XtraEditors.LabelControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.beExpression.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teBonusName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' buttonOK
            ' 
            Me.buttonOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.buttonOK.Enabled = False
            Me.buttonOK.Location = New System.Drawing.Point(12, 109)
            Me.buttonOK.Name = "buttonOK"
            Me.buttonOK.Size = New System.Drawing.Size(75, 21)
            Me.buttonOK.TabIndex = 5
            Me.buttonOK.Text = "OK"
            AddHandler Me.buttonOK.Click, New System.EventHandler(AddressOf Me.buttonOK_Click)
            ' 
            ' buttonCancel
            ' 
            Me.buttonCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.buttonCancel.Location = New System.Drawing.Point(253, 109)
            Me.buttonCancel.Name = "buttonCancel"
            Me.buttonCancel.Size = New System.Drawing.Size(75, 21)
            Me.buttonCancel.TabIndex = 6
            Me.buttonCancel.Text = "Cancel"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.beExpression)
            Me.panelControl1.Controls.Add(Me.teBonusName)
            Me.panelControl1.Controls.Add(Me.labelInternalExpression)
            Me.panelControl1.Controls.Add(Me.labelBonusName)
            Me.panelControl1.Location = New System.Drawing.Point(12, 12)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(315, 82)
            Me.panelControl1.TabIndex = 0
            ' 
            ' beExpression
            ' 
            Me.beExpression.Enabled = False
            Me.beExpression.Location = New System.Drawing.Point(121, 47)
            Me.beExpression.Name = "beExpression"
            Me.beExpression.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.beExpression.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.beExpression.Size = New System.Drawing.Size(174, 20)
            Me.beExpression.TabIndex = 18
            AddHandler Me.beExpression.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.beExpression_ButtonClick)
            ' 
            ' teBonusName
            ' 
            Me.teBonusName.EditValue = ""
            Me.teBonusName.Location = New System.Drawing.Point(121, 12)
            Me.teBonusName.Name = "teBonusName"
            Me.teBonusName.Size = New System.Drawing.Size(174, 20)
            Me.teBonusName.TabIndex = 17
            AddHandler Me.teBonusName.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.teBonusName_EditValueChanging)
            ' 
            ' labelInternalExpression
            ' 
            Me.labelInternalExpression.Location = New System.Drawing.Point(17, 50)
            Me.labelInternalExpression.Margin = New System.Windows.Forms.Padding(4)
            Me.labelInternalExpression.Name = "labelInternalExpression"
            Me.labelInternalExpression.Size = New System.Drawing.Size(97, 13)
            Me.labelInternalExpression.TabIndex = 16
            Me.labelInternalExpression.Text = "Internal Expression:"
            ' 
            ' labelBonusName
            ' 
            Me.labelBonusName.Location = New System.Drawing.Point(51, 15)
            Me.labelBonusName.Margin = New System.Windows.Forms.Padding(4)
            Me.labelBonusName.Name = "labelBonusName"
            Me.labelBonusName.Size = New System.Drawing.Size(63, 13)
            Me.labelBonusName.TabIndex = 15
            Me.labelBonusName.Text = "Bonus Name:"
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.RightCenter
            ' 
            ' AddNewBonus
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.buttonCancel
            Me.ClientSize = New System.Drawing.Size(340, 142)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.buttonCancel)
            Me.Controls.Add(Me.buttonOK)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AddNewBonus"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Add New Bonus"
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.beExpression.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teBonusName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private buttonOK As DevExpress.XtraEditors.SimpleButton

        Private buttonCancel As DevExpress.XtraEditors.SimpleButton

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private labelInternalExpression As DevExpress.XtraEditors.LabelControl

        Private labelBonusName As DevExpress.XtraEditors.LabelControl

        Private teBonusName As DevExpress.XtraEditors.TextEdit

        Private beExpression As DevExpress.XtraEditors.ButtonEdit
    End Class
End Namespace
