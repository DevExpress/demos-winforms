Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class AdvancedEditForm
        Inherits EditFormUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub InitData(ByVal ds As DataSet)
            Dim tblCategory As String = "Category", tblTrademark As String = "Trademark", tblBodyStyle As String = "BodyStyle", tblTransmissionType As String = "TransmissionType"
            lookUpEdit1.Properties.DataSource = ds.Tables(tblCategory)
            lookUpEdit1.Properties.DropDownRows = ds.Tables(tblCategory).Rows.Count
            lookUpEdit2.Properties.DataSource = ds.Tables(tblBodyStyle)
            lookUpEdit2.Properties.DropDownRows = ds.Tables(tblBodyStyle).Rows.Count
            lookUpEdit3.Properties.DataSource = ds.Tables(tblTransmissionType)
            lookUpEdit3.Properties.DropDownRows = ds.Tables(tblTransmissionType).Rows.Count
            gridLookUpEdit1.Properties.DataSource = ds.Tables(tblTrademark)
            AddHandler CType(gridLookUpEdit1.Properties, RepositoryItemGridLookUpEditWithGlyph).GetImageByValueEvent, New ImageByValueEventHandler(AddressOf repositoryItemGridLookUpEdit1_GetImageByValue)
        End Sub

        Protected Overrides Sub SetMenuManager(ByVal menuManager As Utils.Menu.IDXMenuManager)
            MyBase.SetMenuManager(menuManager)
            For Each ctrl As Control In layoutControl1.Controls
                Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
                If edit IsNot Nothing Then edit.MenuManager = menuManager
            Next
        End Sub

        Private Sub repositoryItemGridLookUpEdit1_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            DataHelper.LogoGridLookupGetImageByValue(sender, e)
        End Sub
    End Class
End Namespace
