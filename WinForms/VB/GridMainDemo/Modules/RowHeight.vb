Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for RowHeight.
    ''' </summary>
    Public Partial Class RowHeight
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            sbSwitching.Text = SwitchButtonCaption
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"RowHeight"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "RowHeight"
            End Get
        End Property

#Region "Init"
        Private Sub RowHeight_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitAutoHeight()
        End Sub

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private ReadOnly Property CurrentGrid As GridControl
            Get
                Return gridControl1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = New DataSet()
            SetWaitDialogCaption(Properties.Resources.LoadingTables)
            ds.ReadXml(dataFileName)
            CurrentGrid.DataSource = ds.Tables("Employees")
            Return ds
        End Function

        Private Sub InitAutoHeight()
            If TypeOf CurrentGrid.MainView Is GridView Then
                cheAutoHeight.Checked = gridView1.OptionsView.RowAutoHeight
            Else
                cheAutoHeight.Checked = cardView1.OptionsBehavior.FieldAutoHeight
            End If

            cheMemo.Checked = repositoryItemMemoEdit1.LinesCount = 0
            chePicture.Checked = repositoryItemPictureEdit1.CustomHeight = 0
            InitEnabledAutoHeight()
        End Sub

        Private Sub InitEnabledAutoHeight()
            chePicture.Enabled = cheAutoHeight.Checked
            cheMemo.Enabled = chePicture.Enabled
        End Sub

#End Region
#Region "Editing"
        '<cheAutoHeight>
        Private Sub chbAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            If TypeOf CurrentGrid.MainView Is GridView Then
                gridView1.OptionsView.RowAutoHeight = ce.Checked
            Else
                cardView1.OptionsBehavior.FieldAutoHeight = ce.Checked
            End If

            '<skip>
            InitEnabledAutoHeight()
        '</skip>
        End Sub

        '</cheAutoHeight>
        '<cheMemo>
        Private Sub chbMemo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            repositoryItemMemoEdit1.LinesCount = If(ce.Checked, 0, 1)
        End Sub

        '</cheMemo>
        '<chePicture>
        Private Sub chbPicture_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            repositoryItemPictureEdit1.CustomHeight = If(ce.Checked, 0, 40)
            gridView1.TopRowIndex = 0
        End Sub

        '</chePicture>
        Private ReadOnly Property ActiveViewCaption As String
            Get
                Return If(CurrentGrid.MainView Is gridView1, Properties.Resources.GridView, Properties.Resources.CardView)
            End Get
        End Property

        Private ReadOnly Property SwitchButtonCaption As String
            Get
                Return If(CurrentGrid.MainView Is gridView1, Properties.Resources.ShowCardView, Properties.Resources.ShowGridView)
            End Get
        End Property

        '<sbSwitching>
        Private Sub sbSwitching_Click(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            '</skip>
            If CurrentGrid.MainView Is cardView1 Then
                CurrentGrid.MainView = gridView1
            Else
                CurrentGrid.MainView = cardView1
            End If

            '<skip>
            InitAutoHeight()
            CurrentGrid.Focus()
            CurrentGrid.MainView.LayoutChanged()
            Cursor.Current = currentCursor
            RibbonMenuManager.AllowExport(CurrentGrid.MainView)
            sbSwitching.Text = SwitchButtonCaption
        '</skip>
        End Sub
    '</sbSwitching>
#End Region
    End Class
End Namespace
