Namespace DevExpress.XtraScheduler.Demos

    Partial Class PrintStylesControl

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.btnCalendarDetailsStyle = New DevExpress.XtraEditors.CheckButton()
            Me.btnTriFoldStyle = New DevExpress.XtraEditors.CheckButton()
            Me.btnMonthlyCalendarStyle = New DevExpress.XtraEditors.CheckButton()
            Me.btnWeeklyCalendarStyle = New DevExpress.XtraEditors.CheckButton()
            Me.btnWeeklyAgendaStyle = New DevExpress.XtraEditors.CheckButton()
            Me.btnDailyStyle = New DevExpress.XtraEditors.CheckButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.btnCalendarDetailsStyle)
            Me.layoutControl1.Controls.Add(Me.btnTriFoldStyle)
            Me.layoutControl1.Controls.Add(Me.btnMonthlyCalendarStyle)
            Me.layoutControl1.Controls.Add(Me.btnWeeklyCalendarStyle)
            Me.layoutControl1.Controls.Add(Me.btnWeeklyAgendaStyle)
            Me.layoutControl1.Controls.Add(Me.btnDailyStyle)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(414, 121, 650, 400)
            Me.layoutControl1.OptionsView.AllowItemSkinning = False
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(238, 265)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' btnCalendarDetailsStyle
            ' 
            Me.btnCalendarDetailsStyle.Appearance.Options.UseTextOptions = True
            Me.btnCalendarDetailsStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.btnCalendarDetailsStyle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnCalendarDetailsStyle.GroupIndex = 1
            Me.btnCalendarDetailsStyle.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.small_calendar
            Me.btnCalendarDetailsStyle.Location = New System.Drawing.Point(0, 220)
            Me.btnCalendarDetailsStyle.Name = "btnCalendarDetailsStyle"
            Me.btnCalendarDetailsStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.btnCalendarDetailsStyle.Size = New System.Drawing.Size(221, 44)
            Me.btnCalendarDetailsStyle.StyleController = Me.layoutControl1
            Me.btnCalendarDetailsStyle.TabIndex = 9
            Me.btnCalendarDetailsStyle.TabStop = False
            Me.btnCalendarDetailsStyle.Text = "Calendar Details Style"
            Me.btnCalendarDetailsStyle.Visible = False
            ' 
            ' btnTriFoldStyle
            ' 
            Me.btnTriFoldStyle.Appearance.Options.UseTextOptions = True
            Me.btnTriFoldStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.btnTriFoldStyle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnTriFoldStyle.GroupIndex = 1
            Me.btnTriFoldStyle.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.small_trifold
            Me.btnTriFoldStyle.Location = New System.Drawing.Point(0, 176)
            Me.btnTriFoldStyle.Name = "btnTriFoldStyle"
            Me.btnTriFoldStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.btnTriFoldStyle.Size = New System.Drawing.Size(221, 44)
            Me.btnTriFoldStyle.StyleController = Me.layoutControl1
            Me.btnTriFoldStyle.TabIndex = 8
            Me.btnTriFoldStyle.TabStop = False
            Me.btnTriFoldStyle.Text = "Tri-fold Style"
            ' 
            ' btnMonthlyCalendarStyle
            ' 
            Me.btnMonthlyCalendarStyle.Appearance.Options.UseTextOptions = True
            Me.btnMonthlyCalendarStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.btnMonthlyCalendarStyle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnMonthlyCalendarStyle.GroupIndex = 1
            Me.btnMonthlyCalendarStyle.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.small_monthonepage
            Me.btnMonthlyCalendarStyle.Location = New System.Drawing.Point(0, 132)
            Me.btnMonthlyCalendarStyle.Name = "btnMonthlyCalendarStyle"
            Me.btnMonthlyCalendarStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.btnMonthlyCalendarStyle.Size = New System.Drawing.Size(221, 44)
            Me.btnMonthlyCalendarStyle.StyleController = Me.layoutControl1
            Me.btnMonthlyCalendarStyle.TabIndex = 7
            Me.btnMonthlyCalendarStyle.TabStop = False
            Me.btnMonthlyCalendarStyle.Text = "Monthly Calendar Style"
            ' 
            ' btnWeeklyCalendarStyle
            ' 
            Me.btnWeeklyCalendarStyle.Appearance.Options.UseTextOptions = True
            Me.btnWeeklyCalendarStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.btnWeeklyCalendarStyle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnWeeklyCalendarStyle.GroupIndex = 1
            Me.btnWeeklyCalendarStyle.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.small_weekonepage
            Me.btnWeeklyCalendarStyle.Location = New System.Drawing.Point(0, 88)
            Me.btnWeeklyCalendarStyle.Name = "btnWeeklyCalendarStyle"
            Me.btnWeeklyCalendarStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.btnWeeklyCalendarStyle.Size = New System.Drawing.Size(221, 44)
            Me.btnWeeklyCalendarStyle.StyleController = Me.layoutControl1
            Me.btnWeeklyCalendarStyle.TabIndex = 6
            Me.btnWeeklyCalendarStyle.TabStop = False
            Me.btnWeeklyCalendarStyle.Text = "Weekly Calendar Style"
            ' 
            ' btnWeeklyAgendaStyle
            ' 
            Me.btnWeeklyAgendaStyle.Appearance.Options.UseTextOptions = True
            Me.btnWeeklyAgendaStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.btnWeeklyAgendaStyle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnWeeklyAgendaStyle.GroupIndex = 1
            Me.btnWeeklyAgendaStyle.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.small_weekonepage
            Me.btnWeeklyAgendaStyle.Location = New System.Drawing.Point(0, 44)
            Me.btnWeeklyAgendaStyle.Name = "btnWeeklyAgendaStyle"
            Me.btnWeeklyAgendaStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.btnWeeklyAgendaStyle.Size = New System.Drawing.Size(221, 44)
            Me.btnWeeklyAgendaStyle.StyleController = Me.layoutControl1
            Me.btnWeeklyAgendaStyle.TabIndex = 5
            Me.btnWeeklyAgendaStyle.TabStop = False
            Me.btnWeeklyAgendaStyle.Text = "Weekly Agenda Style"
            ' 
            ' btnDailyStyle
            ' 
            Me.btnDailyStyle.Appearance.Options.UseTextOptions = True
            Me.btnDailyStyle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.btnDailyStyle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.btnDailyStyle.GroupIndex = 1
            Me.btnDailyStyle.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.small_dayonepage
            Me.btnDailyStyle.Location = New System.Drawing.Point(0, 0)
            Me.btnDailyStyle.Name = "btnDailyStyle"
            Me.btnDailyStyle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.btnDailyStyle.Size = New System.Drawing.Size(221, 44)
            Me.btnDailyStyle.StyleController = Me.layoutControl1
            Me.btnDailyStyle.TabIndex = 4
            Me.btnDailyStyle.TabStop = False
            Me.btnDailyStyle.Text = "Daily Style"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(221, 274)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnDailyStyle
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 44)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 264)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(221, 10)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.btnWeeklyAgendaStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 44)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(221, 44)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.btnWeeklyCalendarStyle
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 88)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(221, 44)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.btnMonthlyCalendarStyle
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 132)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(221, 44)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnTriFoldStyle
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 176)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem5.Size = New System.Drawing.Size(221, 44)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.btnCalendarDetailsStyle
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 220)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem6.Size = New System.Drawing.Size(221, 44)
            Me.layoutControlItem6.TextVisible = False
            Me.layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' PrintStylesControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "PrintStylesControl"
            Me.Size = New System.Drawing.Size(238, 265)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private btnDailyStyle As DevExpress.XtraEditors.CheckButton

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private btnWeeklyAgendaStyle As DevExpress.XtraEditors.CheckButton

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private btnWeeklyCalendarStyle As DevExpress.XtraEditors.CheckButton

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private btnCalendarDetailsStyle As DevExpress.XtraEditors.CheckButton

        Private btnTriFoldStyle As DevExpress.XtraEditors.CheckButton

        Private btnMonthlyCalendarStyle As DevExpress.XtraEditors.CheckButton

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
