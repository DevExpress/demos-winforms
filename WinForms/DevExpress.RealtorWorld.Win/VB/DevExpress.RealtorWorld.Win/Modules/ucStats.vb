Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucStats
        Inherits BaseModule

        Public Sub New()
            InitializeComponent()
            pnlList.ItemSize = 120
            Dim width As Integer = pnlList.ItemSize * 3 \ 2
            CType(pnlList, ITileControl).Properties.LargeItemWidth = width
            pnlList.Width = width + pnlList.Padding.Horizontal + SystemInformation.VerticalScrollBarWidth + 2
        End Sub

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "Statistics"
            End Get
        End Property

        Friend Overrides Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            If DataHelper.Homes.Count = 0 Then Return
            Dim group As TileGroup = New TileGroup()
            For Each home As Home In DataHelper.Homes
                Dim item As TileItem = New TileItem()
                item.BackgroundImageScaleMode = TileItemImageScaleMode.Squeeze
                item.ItemSize = TileItemSize.Wide
                item.BackgroundImage = home.Photo
                item.Text3 = String.Format("<backcolor=108,189,69><color=white><size=+2>{0}<br><size=-2>{1} Beds / {2} Baths", home.PriceString, home.BedsString, home.BathsString)
                item.TextShowMode = TileItemContentShowMode.Hover
                item.Tag = home
                group.Items.Add(item)
            Next

            pnlList.Groups.Add(group)
            ucStatistics1.InitData(DataHelper.Homes(0))
            DataHelper.SetTileSelectedItem(DataHelper.Homes(0), pnlList)
        End Sub

        Private Sub pnlList_ItemClick_1(ByVal sender As Object, ByVal e As TileItemEventArgs)
            ucStatistics1.InitData(CType(e.Item.Tag, Home))
        End Sub
    End Class
End Namespace
