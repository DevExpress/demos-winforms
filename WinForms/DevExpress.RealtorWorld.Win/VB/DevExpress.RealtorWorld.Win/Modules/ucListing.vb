Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucListing
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
                Return "Listings"
            End Get
        End Property

        Friend Overrides Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            Dim group As TileGroup = New TileGroup()
            For Each home As Home In DataHelper.Homes
                Dim item As TileItem = New TileItem()
                item.BackgroundImageScaleMode = TileItemImageScaleMode.ZoomOutside
                item.BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter
                item.ItemSize = TileItemSize.Wide
                item.BackgroundImage = home.Photo
                item.Padding = New Padding(0, 0, 0, 0)
                item.Text2 = String.Format("<backcolor=108,189,69><color=white>{0} Beds <br>{1} Baths", home.BedsString, home.Baths)
                item.Text3 = String.Format("<backcolor=108,189,69><color=white><size=+3>{0}", home.PriceString)
                'item.Text = string.Format("<size=+1>{0}<size=-2> Beds<br><size=+2>{1}<size=-2> Baths", home.BedsString, home.Baths);
                'item.Text3 = string.Format("<size=+3>{0}", home.PriceString);
                item.TextShowMode = TileItemContentShowMode.Hover
                item.Tag = home
                group.Items.Add(item)
            Next

            pnlList.Groups.Add(group)
        End Sub

        Friend Overrides Sub ShowModule(ByVal item As Object)
            MyBase.ShowModule(item)
            ucHomeDetail1.InitData(CType(item, Home))
            DataHelper.SetTileSelectedItem(item, pnlList)
        End Sub

        Private Sub pnlList_ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            ucHomeDetail1.InitData(CType(e.Item.Tag, Home))
        End Sub
    End Class
End Namespace
