Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleRangeControlClients
        Inherits TutorialControl

        Private rangeControl1 As RangeControl

        Private dateTimeRangeControlClient1 As DateTimeRangeControlClient

        Const seriesColumn As String = "Series"

        Public Sub New()
            InitializeComponent()
            TutorialInfo.AboutFile = Nothing
            TutorialInfo.Description = ""
            TutorialInfo.TutorialName = "Chart Range Control Clients Tutorial"
        End Sub

        'protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleRangeControlClients" }; } }
        'protected override string WhatsThisXMLFileName { get { return "rangeControlClients"; } }
        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
        End Sub

        Private Sub InitializeComponent()
            Dim dateTimeRangeClientRuler1 As DateTimeRangeClientRuler = New DateTimeRangeClientRuler()
            Dim dateTimeRangeClientRuler2 As DateTimeRangeClientRuler = New DateTimeRangeClientRuler()
            Dim dateTimeRangeClientRuler3 As DateTimeRangeClientRuler = New DateTimeRangeClientRuler()
            Dim dateTimeRangeClientRuler4 As DateTimeRangeClientRuler = New DateTimeRangeClientRuler()
            rangeControl1 = New RangeControl()
            dateTimeRangeControlClient1 = New DateTimeRangeControlClient()
            panel1 = New Windows.Forms.Panel()
            rangeControl2 = New RangeControl()
            dateTimeRangeControlClient2 = New DateTimeRangeControlClient()
            CType(rangeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(rangeControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' rangeControl1
            ' 
            rangeControl1.Client = dateTimeRangeControlClient1
            rangeControl1.ContentPadding = New Windows.Forms.Padding(16)
            rangeControl1.Dock = Windows.Forms.DockStyle.Top
            rangeControl1.FadeUnselectedArea = False
            rangeControl1.Location = New System.Drawing.Point(17, 17)
            rangeControl1.Name = "rangeControl1"
            rangeControl1.SelectionType = RangeControlSelectionType.Flag
            rangeControl1.Size = New System.Drawing.Size(896, 150)
            rangeControl1.TabIndex = 0
            rangeControl1.Text = "rangeControl1"
            ' 
            ' dateTimeRangeControlClient1
            ' 
            dateTimeRangeControlClient1.FlagFormatString = "{0:d}"
            dateTimeRangeControlClient1.Maximum = New DateTime(2021, 1, 1, 10, 22, 25, 0)
            dateTimeRangeControlClient1.Minimum = New DateTime(2019, 1, 1, 10, 22, 25, 0)
            dateTimeRangeControlClient1.RangeControl = rangeControl1
            dateTimeRangeClientRuler1.MainRuler = True
            dateTimeRangeClientRuler1.MinGridDelta = 25
            dateTimeRangeClientRuler1.ShowInContentArea = True
            dateTimeRangeClientRuler2.AllowAdaptiveTicks = True
            dateTimeRangeClientRuler2.DrawSeparator = Utils.DefaultBoolean.False
            dateTimeRangeClientRuler2.DrawTicks = Utils.DefaultBoolean.False
            dateTimeRangeClientRuler2.LabelAlignment = Alignment.Near
            dateTimeRangeClientRuler2.LabelPadding = New Windows.Forms.Padding(2, 8, 8, 8)
            dateTimeRangeClientRuler2.LabelVerticalAlignment = DateTimeRangeClientLabelVerticalAlignment.Bottom
            dateTimeRangeClientRuler2.ShowInContentArea = True
            dateTimeRangeClientRuler2.Type = DateTimeRangeClientMeasureType.Month
            dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler1)
            dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler2)
            AddHandler dateTimeRangeControlClient1.CustomDrawLabel, New DateTimeRangeClientCustomDrawLabelEventHandler(AddressOf dateTimeRangeControlClient1_CustomDrawLabel)
            ' 
            ' panel1
            ' 
            panel1.Dock = Windows.Forms.DockStyle.Top
            panel1.Location = New System.Drawing.Point(17, 167)
            panel1.Name = "panel1"
            panel1.Size = New System.Drawing.Size(896, 34)
            panel1.TabIndex = 1
            ' 
            ' rangeControl2
            ' 
            rangeControl2.Client = dateTimeRangeControlClient2
            rangeControl2.Dock = Windows.Forms.DockStyle.Top
            rangeControl2.Location = New System.Drawing.Point(17, 201)
            rangeControl2.Name = "rangeControl2"
            rangeControl2.Size = New System.Drawing.Size(896, 100)
            rangeControl2.TabIndex = 2
            rangeControl2.Text = "rangeControl2"
            ' 
            ' dateTimeRangeControlClient2
            ' 
            dateTimeRangeControlClient2.Maximum = New DateTime(2021, 1, 1, 11, 2, 39, 0)
            dateTimeRangeControlClient2.Minimum = New DateTime(2019, 1, 1, 11, 2, 31, 0)
            dateTimeRangeControlClient2.RangeControl = rangeControl2
            dateTimeRangeClientRuler4.Type = DateTimeRangeClientMeasureType.Month
            dateTimeRangeControlClient2.Rulers.Add(dateTimeRangeClientRuler3)
            dateTimeRangeControlClient2.Rulers.Add(dateTimeRangeClientRuler4)
            ' 
            ' ModuleRangeControlClients
            ' 
            Appearance.Options.UseFont = True
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(rangeControl2)
            Me.Controls.Add(panel1)
            Me.Controls.Add(rangeControl1)
            Name = "ModuleRangeControlClients"
            Padding = New Windows.Forms.Padding(17)
            Size = New System.Drawing.Size(930, 364)
            CType(rangeControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(rangeControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            rangeControl1.SelectedRange = New RangeControlRange(New DateTime(2019, 8, 1), New DateTime(2020, 4, 1))
            rangeControl2.SelectedRange = New RangeControlRange(New DateTime(2019, 8, 1), New DateTime(2020, 4, 1))
        End Sub

        Private Sub dateTimeRangeControlClient1_CustomDrawLabel(ByVal sender As Object, ByVal e As DateTimeRangeClientCustomDrawLabelEventArgs)
            If e.Ruler.Type = DateTimeRangeClientMeasureType.Month AndAlso (e.PrevValue Is Nothing OrElse e.PrevValue.Value.Year <> e.Value.Year) Then
                e.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
                Dim sz As Size = e.Cache.CalcTextSize(e.Text, e.Appearance.Font).ToSize()
                e.Bounds = New System.Drawing.Rectangle(e.Bounds.Location, sz)
            End If
        End Sub
    End Class
End Namespace
