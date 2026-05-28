Namespace PhotoViewer

    Partial Class DateFilter

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
            Dim dateRange1 As DevExpress.XtraEditors.Controls.DateRange = New DevExpress.XtraEditors.Controls.DateRange()
            Dim dateRange2 As DevExpress.XtraEditors.Controls.DateRange = New DevExpress.XtraEditors.Controls.DateRange()
            Me.separator = New DevExpress.XtraEditors.LabelControl()
            Me.calendarStartDate = New DevExpress.XtraEditors.Controls.CalendarControl()
            Me.allowFilterCheck = New DevExpress.XtraEditors.CheckEdit()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType((Me.calendarStartDate.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowFilterCheck.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' separator
            ' 
            Me.separator.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.separator.Dock = System.Windows.Forms.DockStyle.Top
            Me.separator.LineVisible = True
            Me.separator.Location = New System.Drawing.Point(0, 0)
            Me.separator.Name = "separator"
            Me.separator.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.separator.Size = New System.Drawing.Size(448, 13)
            Me.separator.TabIndex = 5
            ' 
            ' startDate
            ' 
            Me.calendarStartDate.AutoSize = False
            Me.calendarStartDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.calendarStartDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.calendarStartDate.DateTime = New System.DateTime(2025, 7, 23, 0, 0, 0, 0)
            Me.calendarStartDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.calendarStartDate.EditValue = New System.DateTime(2025, 7, 23, 0, 0, 0, 0)
            Me.calendarStartDate.Location = New System.Drawing.Point(0, 0)
            Me.calendarStartDate.Name = "startDate"
            dateRange1.EndDate = New System.DateTime(2025, 7, 24, 0, 0, 0, 0)
            dateRange1.StartDate = New System.DateTime(2025, 7, 23, 0, 0, 0, 0)
            dateRange2.EndDate = New System.DateTime(2025, 7, 24, 0, 0, 0, 0)
            dateRange2.StartDate = New System.DateTime(2025, 7, 23, 0, 0, 0, 0)
            Me.calendarStartDate.SelectedRanges.Add(dateRange1)
            Me.calendarStartDate.SelectedRanges.Add(dateRange2)
            Me.calendarStartDate.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple
            Me.calendarStartDate.Size = New System.Drawing.Size(448, 262)
            Me.calendarStartDate.TabIndex = 3
            AddHandler Me.calendarStartDate.SelectionChanged, New System.EventHandler(AddressOf Me.startDate_SelectionChanged)
            ' 
            ' allowFilterCheck
            ' 
            Me.allowFilterCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.allowFilterCheck.Location = New System.Drawing.Point(11, 17)
            Me.allowFilterCheck.Name = "allowFilterCheck"
            Me.allowFilterCheck.Properties.Caption = "Apply Filter"
            Me.allowFilterCheck.Size = New System.Drawing.Size(75, 19)
            Me.allowFilterCheck.TabIndex = 6
            AddHandler Me.allowFilterCheck.CheckedChanged, New System.EventHandler(AddressOf Me.allowFilterCheck_CheckedChanged)
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.allowFilterCheck)
            Me.panel1.Controls.Add(Me.separator)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 262)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(448, 46)
            Me.panel1.TabIndex = 7
            ' 
            ' DateFilter
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.calendarStartDate)
            Me.Controls.Add(Me.panel1)
            Me.Name = "DateFilter"
            Me.Size = New System.Drawing.Size(448, 308)
            CType((Me.calendarStartDate.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowFilterCheck.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private separator As DevExpress.XtraEditors.LabelControl

        Private calendarStartDate As DevExpress.XtraEditors.Controls.CalendarControl

        Private allowFilterCheck As DevExpress.XtraEditors.CheckEdit

        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace
