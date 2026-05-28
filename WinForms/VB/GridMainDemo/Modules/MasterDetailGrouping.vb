Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for MasterDetailGrouping.
    ''' </summary>
    Public Partial Class MasterDetailGrouping
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            gridControl2.LevelTree.Nodes(0).RelationName = Properties.Resources.Orders
            '<panelControl1>
            ' ~Specify the name of the child level whose grouping state is displayed in the joined group panel: 
            gridView1.ChildGridLevelName = Properties.Resources.Orders ' ~Set ChildGridLevelName to "Orders" 
            '</panelControl1>
            InitNWindData()
            InitMasterDetailAppearance()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"MasterDetailGrouping"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "MasterDetailGrouping"
            End Get
        End Property

        Protected Overrides ReadOnly Property PaintViews As PaintView()
            Get
                Return New PaintView() {New PaintView(gridView1, "Winter"), New PaintView(gridView2, "Spring")}
            End Get
        End Property

#Region "Init"
        Private Sub MasterDetailGrouping_Load(ByVal sender As Object, ByVal e As EventArgs)
            OnButtonChecked(chOwner)
        End Sub

        Private ReadOnly Property CurrentGrid As GridControl
            Get
                Return gridControl2
            End Get
        End Property

        Private ReadOnly Property CurrentView As GridView
            Get
                Return gridView1
            End Get
        End Property

        '<panelControl1>
        Private LevelName As String = Properties.Resources.Orders ' ~Returns "Orders" 

        '</panelControl1>
        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            SetWaitDialogCaption(Properties.Resources.LoadingCustomers)
            Dim dataSet As DataSet = New DataSet()
            dataSet.ReadXml(dataFileName)
            LevelName = "CustomersOrders"
            gridControl2.LevelTree.Nodes(0).RelationName = LevelName
            gridView1.ChildGridLevelName = LevelName
            gridControl2.ShowOnlyPredefinedDetails = True
            gridControl2.DataSource = dataSet.Tables("Customers")
            Return dataSet
        End Function

        Private Sub InitMasterDetailAppearance()
            gridControl2.ForceInitialize()
            gridView1.BeginUpdate()
            gridView1.ExpandAllGroups()
            gridView1.FocusedRowHandle = 2
            gridView1.SetMasterRowExpanded(gridView1.FocusedRowHandle, True)
            gridView1.EndUpdate()
        End Sub

#End Region
#Region "Adjustment"
        '<panelControl1>
        Private Sub SetShowChildrenInGroupPanel(ByVal show As Boolean)
            CurrentView.BeginUpdate()
            CurrentView.OptionsView.ShowChildrenInGroupPanel = show
            If CurrentGrid.LevelTree.Nodes(LevelName) IsNot Nothing Then CType(CurrentGrid.LevelTree.Nodes(LevelName).LevelTemplate, GridView).OptionsView.ShowGroupPanel = Not show
            For i As Integer = 0 To CurrentGrid.Views.Count - 1
                CType(CurrentGrid.Views(i), GridView).ExpandAllGroups()
            Next

            CurrentView.EndUpdate()
        End Sub

        '</panelControl1>
#End Region
#Region "Grid events"
        Private Sub gridControl2_ViewRegistered(ByVal sender As Object, ByVal e As ViewOperationEventArgs)
            CType(e.View, GridView).ExpandAllGroups()
        End Sub

        Private Sub gridView_EndGrouping(ByVal sender As Object, ByVal e As EventArgs)
            Dim gv As GridView = TryCast(sender, GridView)
            gv.ExpandAllGroups()
        End Sub

#End Region
        Private updateInfo As Boolean = False

        Private Sub ch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateInfo Then Return
            OnButtonChecked(TryCast(sender, CheckButton))
        End Sub

        Private Sub OnButtonChecked(ByVal button As CheckButton)
            If button.Tag Is Nothing Then Return
            updateInfo = True
            chOwner.Checked = button Is chOwner
            chJoined.Checked = Not chOwner.Checked
            SetShowChildrenInGroupPanel(button Is chJoined)
            CurrentGrid.Focus()
            updateInfo = False
        End Sub
    End Class
End Namespace
