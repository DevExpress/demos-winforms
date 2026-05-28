Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace DevExpress.XtraDialogs.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "DialogsMainDemo\Modules\"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraDialogs.Demos.CodeInfo"
            End Get
        End Property
    End Class

    Public Partial Class MainModule
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            AddHandler memoEdit1.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            LookAndFeel_StyleChanged(memoEdit1, EventArgs.Empty)
        End Sub

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            RemoveHandler memoEdit1.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        Private Sub InitializeComponent()
            memoEdit1 = New MemoEdit()
            labelControl1 = New LabelControl()
            CType(memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' memoEdit1
            ' 
            memoEdit1.Dock = DockStyle.Fill
            memoEdit1.EditValue = "Text"
            memoEdit1.Location = New System.Drawing.Point(0, 0)
            memoEdit1.Name = "memoEdit1"
            memoEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10F)
            memoEdit1.Properties.Appearance.Options.UseFont = True
            memoEdit1.Properties.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            memoEdit1.Size = New System.Drawing.Size(547, 300)
            memoEdit1.TabIndex = 2
            AddHandler memoEdit1.TextChanged, New EventHandler(AddressOf MemoEdit_TextChanged)
            ' 
            ' labelControl1
            ' 
            labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            labelControl1.Appearance.Options.UseBackColor = True
            labelControl1.Appearance.Options.UseFont = True
            labelControl1.Appearance.Options.UseTextOptions = True
            labelControl1.Appearance.TextOptions.HAlignment = Utils.HorzAlignment.Center
            labelControl1.Appearance.TextOptions.VAlignment = Utils.VertAlignment.Center
            labelControl1.Appearance.TextOptions.WordWrap = Utils.WordWrap.Wrap
            labelControl1.AutoSizeMode = LabelAutoSizeMode.None
            labelControl1.Dock = DockStyle.Fill
            labelControl1.Location = New System.Drawing.Point(0, 0)
            labelControl1.Name = "labelControl1"
            labelControl1.Size = New System.Drawing.Size(547, 300)
            labelControl1.TabIndex = 7
            labelControl1.Text = "Click buttons on the right panel to start"
            ' 
            ' MainModule
            ' 
            Appearance.BackColor = System.Drawing.SystemColors.Control
            Appearance.Options.UseBackColor = True
            AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(labelControl1)
            Me.Controls.Add(memoEdit1)
            Name = "MainModule"
            Size = New System.Drawing.Size(547, 300)
            CType(memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private memoEdit1 As MemoEdit

        Private labelControl1 As LabelControl

        Public Event DocumentLoaded As EventHandler

        Protected Sub RaiseDocumentLoaded()
            Dim handler = DocumentLoadedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Sub LoadDocument(ByVal documentPath As String)
            If File.Exists(documentPath) Then
                memoEdit1.Text = File.ReadAllText(documentPath)
                labelControl1.Visible = False
                RaiseDocumentLoaded()
            End If
        End Sub

        Public Sub SaveDocument(ByVal documentPath As String)
            File.WriteAllText(documentPath, memoEdit1.Text)
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            labelControl1.BackColor = memoEdit1.BackColor
        End Sub

        Private Sub MemoEdit_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim vi As MemoEditViewInfo = TryCast(memoEdit1.GetViewInfo(), MemoEditViewInfo)
            Using graphics = memoEdit1.CreateGraphics()
                Using cache = New GraphicsCache(graphics, ScaleDPI)
                    Dim h As Integer = TryCast(vi, IHeightAdaptable).CalcHeight(cache, vi.MaskBoxRect.Width)
                    Dim args As ObjectInfoArgs = New ObjectInfoArgs()
                    args.Bounds = New Rectangle(0, 0, vi.ClientRect.Width, h)
                    Dim rect As Rectangle = vi.BorderPainter.CalcBoundsByClientRectangle(args)
                    memoEdit1.Properties.ScrollBars = If(rect.Height > memoEdit1.Height, ScrollBars.Vertical, ScrollBars.None)
                End Using
            End Using
        End Sub
    End Class
End Namespace
