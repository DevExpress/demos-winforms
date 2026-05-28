Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class TreeListPictures
        Inherits TutorialControl

        Protected Overrides ReadOnly Property Options As Object
            Get
                Return treeList1.OptionsView
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsName As String
            Get
                Return "View" & Microsoft.VisualBasic.Constants.vbLf & " Options"
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property BarName As String
            Get
                Return "Pictures"
            End Get
        End Property

        Protected Overrides ReadOnly Property Manager As BarManager
            Get
                Return barManager1
            End Get
        End Property

        Protected Overrides Sub InitBarInfo()
            BarInfos.Add(New BarInfo("Print Preview", New ItemClickEventHandler(AddressOf PrintPreviewClick), imageCollection1.Images(0), False, False, False))
            BarInfos.Add(New BarInfo("Print Designer", New ItemClickEventHandler(AddressOf PrintDesignerClick), imageCollection1.Images(1), False, False, False))
        End Sub

        Public Sub New()
            InitializeComponent()
            InitData()
            InitHeaderPanelColor()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"Pictures"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Pictures"
            End Get
        End Property

        Protected Overrides Sub OnSwitchStyle()
            InitHeaderPanelColor()
        End Sub

        '<treeList1>
        Private Sub PrintPreviewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            treeList1.ShowPrintPreview()
            Cursor.Current = currentCursor
        End Sub

        Private Sub PrintDesignerClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Dim frm As XtraForm = New XtraForm()
            frm.Text = "Print Designer"
            Dim _print As XtraTreeList.Frames.TreeListPrinting = New XtraTreeList.Frames.TreeListPrinting()
            _print.InitFrame(treeList1, "PrintingReport management", CType(imageCollection1.Images(0), Bitmap))
            _print.Dock = DockStyle.Fill
            frm.Controls.Add(_print)
            frm.Size = _print.UserControlSize
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            Cursor.Current = currentCursor
        End Sub

        '</treeList1>
        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("BioLife.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                treeList1.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub

        Private Sub InitHeaderPanelColor()
            Dim isDefault As Boolean = UserLookAndFeel.Default.UseWindowsXPTheme OrElse UserLookAndFeel.Default.Style = LookAndFeelStyle.Skin OrElse UserLookAndFeel.Default.Style = LookAndFeelStyle.Office2003
            treeList1.Appearance.HeaderPanel.ForeColor = If(isDefault, Color.Empty, Color.White)
        End Sub
    End Class
End Namespace
