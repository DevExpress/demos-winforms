Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

Namespace DevExpress.Xpo.Demos
	Partial Public Class SpecifiedTypeObject
		Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property
		Public Shared objectsToDispose() As IDisposable
		Private currentDataLayer As IDataLayer
		Private xpCollection As XPCollection

		Public Sub New()
			InitializeComponent()
			currentDataLayer = ObjectHelper.CreateDataLayer()
			session1.Connect(currentDataLayer)
			xpCollection = New XPCollection(session1, GetType(Worker))
			cbViews.SelectedIndex = 0
		End Sub

		'<cbViews>
		Private Sub cbViews_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbViews.SelectedIndexChanged
			groupControl1.Text = cbViews.Text
			Select Case cbViews.SelectedIndex
				Case 0
					xpCollection.Criteria = Nothing
				Case 1
					xpCollection.Criteria = CriteriaOperator.Parse("IsExactType(This,'Evangelist')", Nothing)
				Case 2
					xpCollection.Criteria = CriteriaOperator.Parse("IsInstanceOfType(This,'Manager')", Nothing)
				Case 3
					xpCollection.Criteria = CriteriaOperator.Parse("IsInstanceOfType(This,'ProductManager')", Nothing)
				Case 4
					xpCollection.Criteria = CriteriaOperator.Parse("IsExactType(This,'Manager')", Nothing)
			End Select
			xpCollection.Reload()
			gridControl1.DataSource = xpCollection
			gridView1.PopulateColumns()
			gridView1.BestFitColumns()
		End Sub
		'</cbViews>
	End Class
End Namespace
