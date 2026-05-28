Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for ColumnCustomization.
    ''' </summary>
    Public Partial Class ColumnCustomization
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            AddHandler tmr.Tick, New EventHandler(AddressOf tmr_Tick)
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private _show As Boolean = False

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return advBandedGridView1
            End Get
        End Property

        Private Sub ColumnCustomization_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitVehiclesData()
            InitCustomization()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ColumnCustomization"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ColumnCustomization"
            End Get
        End Property

        Private tmr As Timer = New Timer()

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            _show = True
            tmr.Start()
        End Sub

        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            tmr.Stop()
            If Visible Then ShowColumnSelector()
        End Sub

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            VehiclesData.InitXMLData(dataFileName, gridControl1)
            VehiclesData.InitColumnViewEditors(advBandedGridView1)
        End Sub

        Private initData As Boolean = False

        Private Sub InitCustomization()
            initData = True
            Try
                ccbSnapMode.Properties.SetFlags(GetType(Utils.Controls.SnapMode))
                For i As Integer = ccbSnapMode.Properties.Items.Count - 1 To 0 Step -1
                    If CInt(ccbSnapMode.Properties.Items(i).Value) < 0 OrElse CInt(ccbSnapMode.Properties.Items(i).Value) > 8 Then ccbSnapMode.Properties.Items.RemoveAt(i)
                Next

                checkEdit1.Checked = advBandedGridView1.OptionsCustomization.AllowChangeColumnParent
                checkEdit2.Checked = advBandedGridView1.OptionsCustomization.AllowChangeBandParent
                checkEdit3.Checked = advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm
                checkEdit4.Checked = advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible
                ccbSnapMode.EditValue = advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode
            Finally
                initData = False
            End Try
        End Sub

        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            _show = Not _show
            ShowColumnSelector()
        End Sub

        Private Sub ShowColumnSelector()
            ShowColumnSelector(True)
        End Sub

        Private Sub ShowColumnSelector(ByVal showForm As Boolean)
            If _show Then
                simpleButton1.Text = Properties.Resources.HideColumnsSelector
                If showForm Then advBandedGridView1.ColumnsCustomization()
            Else
                simpleButton1.Text = Properties.Resources.ShowColumnsSelector
                If showForm Then advBandedGridView1.DestroyCustomization()
            End If
        End Sub

        '</simpleButton1>
        Private Sub advBandedGridView1_ShowCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            _show = True
            ShowColumnSelector(False)
        End Sub

        Private Sub advBandedGridView1_HideCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            _show = False
            ShowColumnSelector(False)
        End Sub

        '<checkEdit1>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As XtraEditors.CheckEdit = TryCast(sender, XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = edit.Checked
        End Sub

        '</checkEdit1>
        '<checkEdit2>
        Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As XtraEditors.CheckEdit = TryCast(sender, XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.AllowChangeBandParent = edit.Checked
        End Sub

        '</checkEdit2>
        '<checkEdit3>
        Private Sub checkEdit3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As XtraEditors.CheckEdit = TryCast(sender, XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = edit.Checked
        End Sub

        '</checkEdit3>
        Private Sub checkEdit4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As XtraEditors.CheckEdit = TryCast(sender, XtraEditors.CheckEdit)
            advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = edit.Checked
        End Sub

#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

#End Region
        Private Sub ccbSnapMode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initData Then Return
            Dim edit As XtraEditors.CheckedComboBoxEdit = TryCast(sender, XtraEditors.CheckedComboBoxEdit)
            If Not String.IsNullOrEmpty(edit.Text) Then advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode = CType(edit.EditValue, Utils.Controls.SnapMode)
        End Sub

        Private Sub layoutControlItem6_CustomDraw(ByVal sender As Object, ByVal e As XtraLayout.ItemCustomDrawEventArgs)
            e.DefaultDraw()
            e.Cache.FillRectangle(Color.FromArgb(50, 127, 221, 134), e.Bounds)
            e.Handled = True
        End Sub
    End Class
End Namespace
