Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors

Namespace DevExpress.ProductsDemo.Win
	Public Class PivotTileControl
		Inherits TileControl

		<DefaultValue(-1)>
		Public Property LargeItemWidth() As Integer
			Get
				Return DirectCast(Me, ITileControlProperties).LargeItemWidth
			End Get
			Set(ByVal value As Integer)
				DirectCast(Me, ITileControlProperties).LargeItemWidth = value
			End Set
		End Property
	End Class
End Namespace
