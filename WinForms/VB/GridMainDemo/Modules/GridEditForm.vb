Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class GridEditForm
        Inherits TutorialControl

        Private pgOptions As RibbonPageGroup = New RibbonPageGroup("Edit Form Options")

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            '<gridControl2>
            advBandedGridView1.OptionsEditForm.CustomEditFormLayout = New AdvancedEditForm()
            '</gridControl2>
            InitVehiclesData()
            If Not MainFormHelper.TakeScreens Then CreateTimer()
            SetToolTipController(Me, gridControl1)
            SetToolTipController(Me, gridControl2)
            SetEditLicenseInfo(repositoryItemPictureEdit2, gridView1)
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GridEditForm"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "GridEditForm"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            CreateRibbonItems()
        End Sub

        Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
            MyBase.SetVisibleCore(value)
            pgOptions.Visible = value
        End Sub

        Private Sub CreateRibbonItems()
            pgOptions.ShowCaptionButton = False
            pgOptions.AllowTextClipping = False
            ParentFormMain.MainPage.Groups.Insert(3, pgOptions)
            Dim bItem As BarButtonItem = New BarButtonItem(ParentFormMain.Ribbon.Manager, "Options")
            bItem.Hint = pgOptions.Text
            bItem.ImageOptions.SvgImage = Properties.Resources.Settings
            bItem.ImageOptions.SvgImageSize = New Size(32, 32)
            AddHandler bItem.ItemClick, New ItemClickEventHandler(AddressOf OptionsItemClick)
            pgOptions.ItemLinks.Add(bItem)
        End Sub

        Private ReadOnly Property CurrentGridView As GridView
            Get
                If gridControl1.Visible Then Return gridView1
                Return advBandedGridView1
            End Get
        End Property

        Private Sub OptionsItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Using frm As EditFormOptions = New EditFormOptions(CurrentGridView, GridRibbonMenuManager.Manager)
                CurrentGridView.CloseEditForm()
                Dim res As DialogResult = frm.ShowDialog(FindForm())
                If(CurrentGridView.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace OrElse CurrentGridView.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplaceHideCurrentRow) AndAlso res = DialogResult.OK Then CurrentGridView.ShowEditForm()
            End Using
        End Sub

        Protected Overrides Sub OnTick()
            If ModulesInfo.CurrentModule Is Me Then
                '<gridControl1>
                ' 
                ' ~Show the EditForm at startup:
                ' 
                gridView1.ShowEditForm()
                '</gridControl1>
                gridControl2.ForceInitialize()
                advBandedGridView1.FocusedRowHandle = 0
            End If
        End Sub

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim tblModel As String = "Model", tblCategory As String = "Category", tblTrademark As String = "Trademark", tblBodyStyle As String = "BodyStyle"
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(dataFileName)
            SetGridDataSource(tblModel, ds, gridControl1)
            SetGridDataSource(tblModel, ds, gridControl2)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblCategory)
            repositoryItemLookUpEdit1.DropDownRows = ds.Tables(tblCategory).Rows.Count
            repositoryItemLookUpEdit2.DataSource = ds.Tables(tblBodyStyle)
            repositoryItemLookUpEdit2.DropDownRows = ds.Tables(tblBodyStyle).Rows.Count
            repositoryItemGridLookUpEdit1.DataSource = ds.Tables(tblTrademark)
            AddHandler repositoryItemGridLookUpEdit1.GetImageByValueEvent, New ImageByValueEventHandler(AddressOf repositoryItemGridLookUpEdit1_GetImageByValue)
            CType(advBandedGridView1.OptionsEditForm.CustomEditFormLayout, AdvancedEditForm).InitData(ds)
        End Sub

        Private Sub SetGridDataSource(ByVal table As String, ByVal ds As DataSet, ByVal grid As GridControl)
            Dim dvManager As DataViewManager = New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(table))
            grid.DataMember = Nothing
            grid.DataSource = dv
        End Sub

        Private Sub repositoryItemGridLookUpEdit1_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            DataHelper.LogoGridLookupGetImageByValue(sender, e)
        End Sub

        '<gridControl1>
        ' 
        ' ~Use the MemoEdit in-place editor for the Description column in the EditForm instead of the MemoExEdit dropdown editor:
        ' 
        Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs)
            If e.Column Is colDescription Then e.RepositoryItem = repositoryItemMemoEdit1
        End Sub
    '</gridControl1>
    End Class
End Namespace
