Namespace DevExpress.ApplicationUI.Demos

    Partial Class Calendar

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
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateNavigator1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.dateNavigator1.Appearance.Options.UseFont = True
            Me.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.dateNavigator1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.dateNavigator1.CalendarAppearance.Header.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.dateNavigator1.CalendarAppearance.Header.Options.UseFont = True
            Me.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator1.DateTime = New System.DateTime(2013, 11, 22, 0, 0, 0, 0)
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateNavigator1.EditValue = New System.DateTime(2013, 11, 22, 0, 0, 0, 0)
            Me.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.[Single]
            Me.dateNavigator1.ShowTodayButton = False
            Me.dateNavigator1.ShowWeekNumbers = False
            Me.dateNavigator1.Size = New System.Drawing.Size(241, 190)
            Me.dateNavigator1.TabIndex = 0
            ' 
            ' Calendar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dateNavigator1)
            Me.Name = "Calendar"
            Me.Size = New System.Drawing.Size(241, 190)
            CType((Me.dateNavigator1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
    End Class
End Namespace
