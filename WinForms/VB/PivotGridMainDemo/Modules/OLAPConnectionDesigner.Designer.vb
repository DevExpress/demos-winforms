Namespace DevExpress.XtraPivotGrid.Demos

    Partial Class OLAPConnectionDesigner

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
            Me.listCube = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelCube = New DevExpress.XtraEditors.LabelControl()
            Me.listCatalog = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelCatalog = New DevExpress.XtraEditors.LabelControl()
            Me.editServer = New DevExpress.XtraEditors.ButtonEdit()
            Me.labelServer = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.radioFile = New DevExpress.XtraEditors.CheckEdit()
            Me.radioServer = New DevExpress.XtraEditors.CheckEdit()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.buttonSample = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.listCube.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.listCatalog.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editServer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioFile.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioServer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' buttonOK
            ' 
            Me.buttonOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.buttonOK.Location = New System.Drawing.Point(192, 158)
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
            Me.buttonCancel.Location = New System.Drawing.Point(273, 158)
            Me.buttonCancel.Name = "buttonCancel"
            Me.buttonCancel.Size = New System.Drawing.Size(75, 21)
            Me.buttonCancel.TabIndex = 6
            Me.buttonCancel.Text = "Cancel"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.listCube)
            Me.panelControl1.Controls.Add(Me.labelCube)
            Me.panelControl1.Controls.Add(Me.listCatalog)
            Me.panelControl1.Controls.Add(Me.labelCatalog)
            Me.panelControl1.Controls.Add(Me.editServer)
            Me.panelControl1.Controls.Add(Me.labelServer)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.radioFile)
            Me.panelControl1.Controls.Add(Me.radioServer)
            Me.panelControl1.Location = New System.Drawing.Point(12, 12)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(336, 134)
            Me.toolTipController1.SetSuperTip(Me.panelControl1, Nothing)
            Me.panelControl1.TabIndex = 0
            ' 
            ' listCube
            ' 
            Me.listCube.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.listCube.Location = New System.Drawing.Point(104, 96)
            Me.listCube.Margin = New System.Windows.Forms.Padding(4)
            Me.listCube.Name = "listCube"
            Me.listCube.Properties.AutoComplete = False
            Me.listCube.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.listCube.Properties.Sorted = True
            Me.listCube.Size = New System.Drawing.Size(214, 20)
            Me.listCube.TabIndex = 4
            AddHandler Me.listCube.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.listCube_QueryPopUp)
            ' 
            ' labelCube
            ' 
            Me.labelCube.Location = New System.Drawing.Point(16, 99)
            Me.labelCube.Margin = New System.Windows.Forms.Padding(4)
            Me.labelCube.Name = "labelCube"
            Me.labelCube.Size = New System.Drawing.Size(25, 13)
            Me.labelCube.TabIndex = 18
            Me.labelCube.Text = "Cube"
            ' 
            ' listCatalog
            ' 
            Me.listCatalog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.listCatalog.Location = New System.Drawing.Point(104, 68)
            Me.listCatalog.Margin = New System.Windows.Forms.Padding(4)
            Me.listCatalog.Name = "listCatalog"
            Me.listCatalog.Properties.AutoComplete = False
            Me.listCatalog.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.listCatalog.Properties.Sorted = True
            Me.listCatalog.Size = New System.Drawing.Size(214, 20)
            Me.listCatalog.TabIndex = 3
            AddHandler Me.listCatalog.SelectedValueChanged, New System.EventHandler(AddressOf Me.listCatalog_SelectedValueChanged)
            AddHandler Me.listCatalog.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.listCatalog_QueryPopUp)
            ' 
            ' labelCatalog
            ' 
            Me.labelCatalog.Location = New System.Drawing.Point(16, 71)
            Me.labelCatalog.Margin = New System.Windows.Forms.Padding(4)
            Me.labelCatalog.Name = "labelCatalog"
            Me.labelCatalog.Size = New System.Drawing.Size(46, 13)
            Me.labelCatalog.TabIndex = 16
            Me.labelCatalog.Text = "Database"
            ' 
            ' editServer
            ' 
            Me.editServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.editServer.Location = New System.Drawing.Point(104, 40)
            Me.editServer.Margin = New System.Windows.Forms.Padding(4)
            Me.editServer.Name = "editServer"
            Me.editServer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.editServer.Size = New System.Drawing.Size(214, 20)
            Me.editServer.TabIndex = 2
            AddHandler Me.editServer.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.editServer_ButtonClick)
            ' 
            ' labelServer
            ' 
            Me.labelServer.Location = New System.Drawing.Point(16, 43)
            Me.labelServer.Margin = New System.Windows.Forms.Padding(4)
            Me.labelServer.Name = "labelServer"
            Me.labelServer.Size = New System.Drawing.Size(32, 13)
            Me.labelServer.TabIndex = 14
            Me.labelServer.Text = "Server"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(16, 16)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(68, 13)
            Me.labelControl1.TabIndex = 13
            Me.labelControl1.Text = "Connect using"
            ' 
            ' radioFile
            ' 
            Me.radioFile.Location = New System.Drawing.Point(220, 14)
            Me.radioFile.Name = "radioFile"
            Me.radioFile.Properties.Caption = "Cube file"
            Me.radioFile.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.radioFile.Properties.RadioGroupIndex = 0
            Me.radioFile.Size = New System.Drawing.Size(69, 19)
            Me.radioFile.TabIndex = 1
            Me.radioFile.TabStop = False
            AddHandler Me.radioFile.CheckedChanged, New System.EventHandler(AddressOf Me.radioFile_CheckedChanged)
            ' 
            ' radioServer
            ' 
            Me.radioServer.EditValue = True
            Me.radioServer.Location = New System.Drawing.Point(102, 14)
            Me.radioServer.Name = "radioServer"
            Me.radioServer.Properties.Caption = "Analysis server"
            Me.radioServer.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.radioServer.Properties.RadioGroupIndex = 0
            Me.radioServer.Size = New System.Drawing.Size(95, 19)
            Me.radioServer.TabIndex = 0
            AddHandler Me.radioServer.CheckedChanged, New System.EventHandler(AddressOf Me.radioServer_CheckedChanged)
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.RightCenter
            ' 
            ' buttonSample
            ' 
            Me.buttonSample.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.buttonSample.Location = New System.Drawing.Point(12, 158)
            Me.buttonSample.Name = "buttonSample"
            Me.buttonSample.Size = New System.Drawing.Size(75, 21)
            Me.buttonSample.TabIndex = 7
            Me.buttonSample.Text = "Open Sample"
            AddHandler Me.buttonSample.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' OLAPConnectionDesigner
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(360, 189)
            Me.Controls.Add(Me.buttonSample)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.buttonCancel)
            Me.Controls.Add(Me.buttonOK)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "OLAPConnectionDesigner"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.toolTipController1.SetSuperTip(Me, Nothing)
            Me.Text = "OLAP Connection"
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.listCube.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.listCatalog.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editServer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioFile.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioServer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private buttonOK As DevExpress.XtraEditors.SimpleButton

        Private buttonCancel As DevExpress.XtraEditors.SimpleButton

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private listCube As DevExpress.XtraEditors.ComboBoxEdit

        Private labelCube As DevExpress.XtraEditors.LabelControl

        Private listCatalog As DevExpress.XtraEditors.ComboBoxEdit

        Private labelCatalog As DevExpress.XtraEditors.LabelControl

        Private editServer As DevExpress.XtraEditors.ButtonEdit

        Private labelServer As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private radioFile As DevExpress.XtraEditors.CheckEdit

        Private radioServer As DevExpress.XtraEditors.CheckEdit

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private buttonSample As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
