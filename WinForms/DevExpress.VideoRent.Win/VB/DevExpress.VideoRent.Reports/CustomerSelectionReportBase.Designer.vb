Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class CustomerSelectionReportBase
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xpCollectionCustomers = New DevExpress.Xpo.XPCollection()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' xpCollectionCustomers
			' 
			Me.xpCollectionCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
			Me.xpCollectionCustomers.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
'			Me.xpCollectionCustomers.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionCustomers_ResolveSession);
			' 
			' CustomerSelectionReportBase
			' 
			Me.DataSource = Me.xpCollectionCustomers
			Me.RequestParameters = False
			Me.Version = "10.2"
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private WithEvents xpCollectionCustomers As DevExpress.Xpo.XPCollection
	End Class
End Namespace
