Namespace DevExpress.XtraDialogs.Demos

    Partial Class Overview

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
            Me.operationsPanel = New DevExpress.XtraEditors.SidePanel()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.loadButton = New DevExpress.XtraEditors.SimpleButton()
            Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
            Me.workingFolderButton = New DevExpress.XtraEditors.SimpleButton()
            Me.mainModule = New DevExpress.XtraDialogs.Demos.MainModule()
            Me.operationsPanel.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' operationsPanel
            ' 
            Me.operationsPanel.AllowResize = False
            Me.operationsPanel.Controls.Add(Me.tableLayoutPanel1)
            Me.operationsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.operationsPanel.Location = New System.Drawing.Point(748, 0)
            Me.operationsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.operationsPanel.Name = "operationsPanel"
            Me.operationsPanel.Padding = New System.Windows.Forms.Padding(0, 24, 0, 24)
            Me.operationsPanel.Size = New System.Drawing.Size(300, 688)
            Me.operationsPanel.TabIndex = 9
            Me.operationsPanel.Text = "sidePanel1"
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 3
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F))
            Me.tableLayoutPanel1.Controls.Add(Me.loadButton, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.saveButton, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.workingFolderButton, 1, 2)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(1, 24)
            Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 4
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(299, 640)
            Me.tableLayoutPanel1.TabIndex = 3
            ' 
            ' loadButton
            ' 
            Me.loadButton.AllowFocus = False
            Me.loadButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
            Me.loadButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.loadButton.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.open
            Me.loadButton.ImageOptions.SvgImageSize = New System.Drawing.Size(90, 90)
            Me.loadButton.Location = New System.Drawing.Point(89, 3)
            Me.loadButton.Name = "loadButton"
            Me.loadButton.Size = New System.Drawing.Size(120, 120)
            Me.loadButton.TabIndex = 0
            Me.loadButton.Text = "Load Document"
            AddHandler Me.loadButton.Click, New System.EventHandler(AddressOf Me.OpenItemClick)
            ' 
            ' saveButton
            ' 
            Me.saveButton.AllowFocus = False
            Me.saveButton.Enabled = False
            Me.saveButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
            Me.saveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.saveButton.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.save
            Me.saveButton.ImageOptions.SvgImageSize = New System.Drawing.Size(90, 90)
            Me.saveButton.Location = New System.Drawing.Point(89, 129)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(120, 120)
            Me.saveButton.TabIndex = 0
            Me.saveButton.Text = "Save Document"
            AddHandler Me.saveButton.Click, New System.EventHandler(AddressOf Me.SaveItemClick)
            ' 
            ' workingFolderButton
            ' 
            Me.workingFolderButton.AllowFocus = False
            Me.workingFolderButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
            Me.workingFolderButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.workingFolderButton.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.folder
            Me.workingFolderButton.ImageOptions.SvgImageSize = New System.Drawing.Size(90, 90)
            Me.workingFolderButton.Location = New System.Drawing.Point(89, 255)
            Me.workingFolderButton.Name = "workingFolderButton"
            Me.workingFolderButton.Size = New System.Drawing.Size(120, 120)
            Me.workingFolderButton.TabIndex = 0
            Me.workingFolderButton.Text = "Set Working Folder"
            AddHandler Me.workingFolderButton.Click, New System.EventHandler(AddressOf Me.SetWorkingFolderItemClick)
            ' 
            ' mainModule
            ' 
            Me.mainModule.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainModule.Location = New System.Drawing.Point(0, 0)
            Me.mainModule.Margin = New System.Windows.Forms.Padding(0)
            Me.mainModule.Name = "mainModule"
            Me.mainModule.Size = New System.Drawing.Size(748, 688)
            Me.mainModule.TabIndex = 3
            AddHandler Me.mainModule.DocumentLoaded, New System.EventHandler(AddressOf Me.MainModule_DocumentLoaded)
            ' 
            ' Overview
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.mainModule)
            Me.Controls.Add(Me.operationsPanel)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "Overview"
            Me.Size = New System.Drawing.Size(1048, 688)
            Me.operationsPanel.ResumeLayout(False)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected operationsPanel As DevExpress.XtraEditors.SidePanel

        Private mainModule As DevExpress.XtraDialogs.Demos.MainModule

        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        Private loadButton As DevExpress.XtraEditors.SimpleButton

        Private saveButton As DevExpress.XtraEditors.SimpleButton

        Private workingFolderButton As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
