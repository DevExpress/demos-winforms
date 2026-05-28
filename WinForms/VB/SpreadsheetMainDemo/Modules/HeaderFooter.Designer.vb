Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class HeaderFooterModule

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
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.spreadsheetPreview1 = New DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.btnPageSetup = New DevExpress.XtraEditors.SimpleButton()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Location = New System.Drawing.Point(24, 74)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Size = New System.Drawing.Size(509, 303)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Visible = False
            AddHandler Me.spreadsheetControl1.ContentChanged, New System.EventHandler(AddressOf Me.spreadsheetControl1_ContentChanged)
            ' 
            ' spreadsheetPreview1
            ' 
            Me.spreadsheetPreview1.CanShowBorders = True
            Me.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetPreview1.Location = New System.Drawing.Point(0, 40)
            Me.spreadsheetPreview1.Name = "spreadsheetPreview1"
            Me.spreadsheetPreview1.PreviewZoom = DevExpress.XtraSpreadsheet.Demos.SpreadhsheetPreviewZoom.[Default]
            Me.spreadsheetPreview1.Size = New System.Drawing.Size(725, 416)
            Me.spreadsheetPreview1.TabIndex = 7
            Me.spreadsheetPreview1.Workbook = Nothing
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.btnPageSetup)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(725, 40)
            Me.sidePanel1.TabIndex = 8
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' btnPageSetup
            ' 
            Me.btnPageSetup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.btnPageSetup.Location = New System.Drawing.Point(8, 8)
            Me.btnPageSetup.Name = "btnPageSetup"
            Me.btnPageSetup.Size = New System.Drawing.Size(124, 23)
            Me.btnPageSetup.TabIndex = 1
            Me.btnPageSetup.Text = "Headers/Footers"
            AddHandler Me.btnPageSetup.Click, New System.EventHandler(AddressOf Me.btnPageSetup_Click)
            ' 
            ' HeaderFooterModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.spreadsheetPreview1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.spreadsheetControl1)
            Me.Name = "HeaderFooterModule"
            Me.Size = New System.Drawing.Size(725, 456)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl

        Private spreadsheetPreview1 As DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private btnPageSetup As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
