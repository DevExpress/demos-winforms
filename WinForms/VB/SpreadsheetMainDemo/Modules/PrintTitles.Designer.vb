Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class PrintTitlesModule

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
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.btnManyPages = New DevExpress.XtraEditors.SimpleButton()
            Me.btnWholePage = New DevExpress.XtraEditors.SimpleButton()
            Me.btnPageSetup = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.[ReadOnly] = True
            Me.spreadsheetControl1.Size = New System.Drawing.Size(723, 431)
            Me.spreadsheetControl1.TabIndex = 0
            AddHandler Me.spreadsheetControl1.ContentChanged, New System.EventHandler(AddressOf Me.SpreadsheetControl1_ContentChanged)
            ' 
            ' spreadsheetPreview1
            ' 
            Me.spreadsheetPreview1.CanShowBorders = True
            Me.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetPreview1.Location = New System.Drawing.Point(0, 40)
            Me.spreadsheetPreview1.Name = "spreadsheetPreview1"
            Me.spreadsheetPreview1.PreviewZoom = DevExpress.XtraSpreadsheet.Demos.SpreadhsheetPreviewZoom.[Default]
            Me.spreadsheetPreview1.Size = New System.Drawing.Size(723, 391)
            Me.spreadsheetPreview1.TabIndex = 7
            Me.spreadsheetPreview1.Workbook = Nothing
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage2
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.xtraTabControl1.Size = New System.Drawing.Size(725, 456)
            Me.xtraTabControl1.TabIndex = 8
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.spreadsheetPreview1)
            Me.xtraTabPage2.Controls.Add(Me.sidePanel1)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(723, 431)
            Me.xtraTabPage2.Text = "Preview"
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.spreadsheetControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(723, 431)
            Me.xtraTabPage1.Text = "Content"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.btnManyPages)
            Me.sidePanel1.Controls.Add(Me.btnWholePage)
            Me.sidePanel1.Controls.Add(Me.btnPageSetup)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(723, 40)
            Me.sidePanel1.TabIndex = 8
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' btnManyPages
            ' 
            Me.btnManyPages.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnManyPages.ImageOptions.SvgImage = Global.DevExpress.XtraSpreadsheet.Demos.Properties.Resources.ManyPages
            Me.btnManyPages.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.btnManyPages.Location = New System.Drawing.Point(167, 8)
            Me.btnManyPages.Name = "btnManyPages"
            Me.btnManyPages.Size = New System.Drawing.Size(23, 23)
            Me.btnManyPages.TabIndex = 5
            Me.btnManyPages.ToolTip = "View Many Pages"
            AddHandler Me.btnManyPages.Click, New System.EventHandler(AddressOf Me.ManyPages_Click)
            ' 
            ' btnWholePage
            ' 
            Me.btnWholePage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnWholePage.ImageOptions.SvgImage = Global.DevExpress.XtraSpreadsheet.Demos.Properties.Resources.WholePage
            Me.btnWholePage.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.btnWholePage.Location = New System.Drawing.Point(138, 8)
            Me.btnWholePage.Name = "btnWholePage"
            Me.btnWholePage.Size = New System.Drawing.Size(23, 23)
            Me.btnWholePage.TabIndex = 4
            Me.btnWholePage.ToolTip = "View Whole Page"
            AddHandler Me.btnWholePage.Click, New System.EventHandler(AddressOf Me.WholePage_Click)
            ' 
            ' btnPageSetup
            ' 
            Me.btnPageSetup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.btnPageSetup.Location = New System.Drawing.Point(8, 8)
            Me.btnPageSetup.Name = "btnPageSetup"
            Me.btnPageSetup.Size = New System.Drawing.Size(124, 23)
            Me.btnPageSetup.TabIndex = 3
            Me.btnPageSetup.Text = "Page Setup"
            AddHandler Me.btnPageSetup.Click, New System.EventHandler(AddressOf Me.PageSetup_Click)
            ' 
            ' PrintTitlesModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "PrintTitlesModule"
            Me.Size = New System.Drawing.Size(725, 456)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl

        Private spreadsheetPreview1 As DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private btnManyPages As DevExpress.XtraEditors.SimpleButton

        Private btnWholePage As DevExpress.XtraEditors.SimpleButton

        Private btnPageSetup As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
