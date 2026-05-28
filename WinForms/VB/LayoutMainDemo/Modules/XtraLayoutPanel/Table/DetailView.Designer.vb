Namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

    Partial Class DetailView

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel.DetailView))
            Me.tablePanel = New DevExpress.Utils.Layout.TablePanel()
            Me.deHireDate = New DevExpress.XtraEditors.DateEdit()
            Me.deBirthDate = New DevExpress.XtraEditors.DateEdit()
            Me.teReportTo = New DevExpress.XtraEditors.TextEdit()
            Me.teLastName = New DevExpress.XtraEditors.TextEdit()
            Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
            Me.labelHireDate = New DevExpress.XtraEditors.LabelControl()
            Me.labelBirthDate = New DevExpress.XtraEditors.LabelControl()
            Me.labelReportTo = New DevExpress.XtraEditors.LabelControl()
            Me.labelLastName = New DevExpress.XtraEditors.LabelControl()
            Me.labelFirstName = New DevExpress.XtraEditors.LabelControl()
            Me.imageList = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.stackPanel = New DevExpress.Utils.Layout.StackPanel()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel.SuspendLayout()
            CType((Me.deHireDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deHireDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deBirthDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deBirthDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teReportTo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teLastName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teFirstName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.stackPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tablePanel
            ' 
            Me.tablePanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.tablePanel.Controls.Add(Me.deHireDate)
            Me.tablePanel.Controls.Add(Me.deBirthDate)
            Me.tablePanel.Controls.Add(Me.teReportTo)
            Me.tablePanel.Controls.Add(Me.teLastName)
            Me.tablePanel.Controls.Add(Me.teFirstName)
            Me.tablePanel.Controls.Add(Me.labelHireDate)
            Me.tablePanel.Controls.Add(Me.labelBirthDate)
            Me.tablePanel.Controls.Add(Me.labelReportTo)
            Me.tablePanel.Controls.Add(Me.labelLastName)
            Me.tablePanel.Controls.Add(Me.labelFirstName)
            Me.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel.Name = "tablePanel"
            Me.tablePanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 38F)})
            Me.tablePanel.ShowGrid = DevExpress.Utils.DefaultBoolean.[True]
            Me.tablePanel.Size = New System.Drawing.Size(720, 320)
            Me.tablePanel.TabIndex = 0
            Me.tablePanel.UseSkinIndents = True
            AddHandler Me.tablePanel.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.OnTablePanelPaint)
            AddHandler Me.tablePanel.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnTablePanelMouseClick)
            AddHandler Me.tablePanel.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnTablePanelMouseDown)
            AddHandler Me.tablePanel.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnTablePanelMouseMove)
            AddHandler Me.tablePanel.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnTablePanelMouseUp)
            ' 
            ' deHireDate
            ' 
            Me.tablePanel.SetColumn(Me.deHireDate, 1)
            Me.deHireDate.EditValue = Nothing
            Me.deHireDate.Location = New System.Drawing.Point(72, 126)
            Me.deHireDate.Name = "deHireDate"
            Me.deHireDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deHireDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.tablePanel.SetRow(Me.deHireDate, 5)
            Me.deHireDate.Size = New System.Drawing.Size(635, 20)
            Me.deHireDate.TabIndex = 9
            ' 
            ' deBirthDate
            ' 
            Me.tablePanel.SetColumn(Me.deBirthDate, 1)
            Me.deBirthDate.EditValue = Nothing
            Me.deBirthDate.Location = New System.Drawing.Point(72, 102)
            Me.deBirthDate.Name = "deBirthDate"
            Me.deBirthDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.tablePanel.SetRow(Me.deBirthDate, 4)
            Me.deBirthDate.Size = New System.Drawing.Size(635, 20)
            Me.deBirthDate.TabIndex = 7
            ' 
            ' teReportTo
            ' 
            Me.tablePanel.SetColumn(Me.teReportTo, 1)
            Me.teReportTo.EditValue = "Sales Representative"
            Me.teReportTo.Location = New System.Drawing.Point(72, 78)
            Me.teReportTo.Name = "teReportTo"
            Me.tablePanel.SetRow(Me.teReportTo, 3)
            Me.teReportTo.Size = New System.Drawing.Size(635, 20)
            Me.teReportTo.TabIndex = 5
            ' 
            ' teLastName
            ' 
            Me.tablePanel.SetColumn(Me.teLastName, 1)
            Me.teLastName.EditValue = "Davolio"
            Me.teLastName.Location = New System.Drawing.Point(72, 54)
            Me.teLastName.Name = "teLastName"
            Me.tablePanel.SetRow(Me.teLastName, 2)
            Me.teLastName.Size = New System.Drawing.Size(635, 20)
            Me.teLastName.TabIndex = 3
            ' 
            ' teFirstName
            ' 
            Me.tablePanel.SetColumn(Me.teFirstName, 1)
            Me.teFirstName.EditValue = "Nancy"
            Me.teFirstName.Location = New System.Drawing.Point(72, 30)
            Me.teFirstName.Name = "teFirstName"
            Me.tablePanel.SetRow(Me.teFirstName, 1)
            Me.teFirstName.Size = New System.Drawing.Size(635, 20)
            Me.teFirstName.TabIndex = 1
            ' 
            ' labelHireDate
            ' 
            Me.tablePanel.SetColumn(Me.labelHireDate, 0)
            Me.labelHireDate.Location = New System.Drawing.Point(13, 129)
            Me.labelHireDate.Name = "labelHireDate"
            Me.tablePanel.SetRow(Me.labelHireDate, 5)
            Me.labelHireDate.Size = New System.Drawing.Size(49, 13)
            Me.labelHireDate.TabIndex = 8
            Me.labelHireDate.Text = "Hire Date:"
            ' 
            ' labelBirthDate
            ' 
            Me.tablePanel.SetColumn(Me.labelBirthDate, 0)
            Me.labelBirthDate.Location = New System.Drawing.Point(13, 105)
            Me.labelBirthDate.Name = "labelBirthDate"
            Me.tablePanel.SetRow(Me.labelBirthDate, 4)
            Me.labelBirthDate.Size = New System.Drawing.Size(52, 13)
            Me.labelBirthDate.TabIndex = 6
            Me.labelBirthDate.Text = "Birth Date:"
            ' 
            ' labelReportTo
            ' 
            Me.tablePanel.SetColumn(Me.labelReportTo, 0)
            Me.labelReportTo.Location = New System.Drawing.Point(13, 81)
            Me.labelReportTo.Name = "labelReportTo"
            Me.tablePanel.SetRow(Me.labelReportTo, 3)
            Me.labelReportTo.Size = New System.Drawing.Size(52, 13)
            Me.labelReportTo.TabIndex = 4
            Me.labelReportTo.Text = "Report To:"
            ' 
            ' labelLastName
            ' 
            Me.tablePanel.SetColumn(Me.labelLastName, 0)
            Me.labelLastName.Location = New System.Drawing.Point(13, 57)
            Me.labelLastName.Name = "labelLastName"
            Me.tablePanel.SetRow(Me.labelLastName, 2)
            Me.labelLastName.Size = New System.Drawing.Size(54, 13)
            Me.labelLastName.TabIndex = 2
            Me.labelLastName.Text = "Last Name:"
            ' 
            ' labelFirstName
            ' 
            Me.tablePanel.SetColumn(Me.labelFirstName, 0)
            Me.labelFirstName.Location = New System.Drawing.Point(13, 33)
            Me.labelFirstName.Name = "labelFirstName"
            Me.tablePanel.SetRow(Me.labelFirstName, 1)
            Me.labelFirstName.Size = New System.Drawing.Size(55, 13)
            Me.labelFirstName.TabIndex = 0
            Me.labelFirstName.Text = "First Name:"
            ' 
            ' imageList
            ' 
            Me.imageList.Add("Actions_AddColumn", CType((resources.GetObject("imageList.Actions_AddColumn")), DevExpress.Utils.Svg.SvgImage))
            Me.imageList.Add("Actions_AddColumn_Hot", CType((resources.GetObject("imageList.Actions_AddColumn_Hot")), DevExpress.Utils.Svg.SvgImage))
            Me.imageList.Add("Actions_AddRow", CType((resources.GetObject("imageList.Actions_AddRow")), DevExpress.Utils.Svg.SvgImage))
            Me.imageList.Add("Actions_AddRow_Hot", CType((resources.GetObject("imageList.Actions_AddRow_Hot")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' stackPanel
            ' 
            Me.stackPanel.Controls.Add(Me.btnCancel)
            Me.stackPanel.Controls.Add(Me.btnOk)
            Me.stackPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft
            Me.stackPanel.Location = New System.Drawing.Point(0, 320)
            Me.stackPanel.Name = "stackPanel"
            Me.stackPanel.Size = New System.Drawing.Size(720, 48)
            Me.stackPanel.TabIndex = 11
            Me.stackPanel.UseSkinIndents = True
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.Location = New System.Drawing.Point(632, 12)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            ' 
            ' btnOk
            ' 
            Me.btnOk.Location = New System.Drawing.Point(553, 12)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(75, 23)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "OK"
            ' 
            ' DetailView
            ' 
            Me.ClientSize = New System.Drawing.Size(720, 368)
            Me.Controls.Add(Me.tablePanel)
            Me.Controls.Add(Me.stackPanel)
            Me.Name = "DetailView"
            CType((Me.tablePanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel.ResumeLayout(False)
            Me.tablePanel.PerformLayout()
            CType((Me.deHireDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deHireDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deBirthDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deBirthDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teReportTo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teLastName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teFirstName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.stackPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tablePanel As DevExpress.Utils.Layout.TablePanel

        Private labelHireDate As DevExpress.XtraEditors.LabelControl

        Private labelBirthDate As DevExpress.XtraEditors.LabelControl

        Private labelReportTo As DevExpress.XtraEditors.LabelControl

        Private labelLastName As DevExpress.XtraEditors.LabelControl

        Private labelFirstName As DevExpress.XtraEditors.LabelControl

        Private deHireDate As DevExpress.XtraEditors.DateEdit

        Private deBirthDate As DevExpress.XtraEditors.DateEdit

        Private teReportTo As DevExpress.XtraEditors.TextEdit

        Private teLastName As DevExpress.XtraEditors.TextEdit

        Private teFirstName As DevExpress.XtraEditors.TextEdit

        Private imageList As DevExpress.Utils.SvgImageCollection

        Private stackPanel As DevExpress.Utils.Layout.StackPanel

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private btnOk As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
