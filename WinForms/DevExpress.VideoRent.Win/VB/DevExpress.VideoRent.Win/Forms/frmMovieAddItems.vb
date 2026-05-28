Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieAddItems
		Inherits frmAddBase
		Private movie As Movie
        Private fmovieItems As XPCollection(Of MovieItem)
        Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal movie As Movie, ByVal manager As IDXMenuManager)
            MyBase.New(parent, session, Nothing, manager)
            InitializeComponent()
            Me.movie = movie
        End Sub
        Public ReadOnly Property MovieItem() As MovieItem
            Get
                Return TryCast(editObject, MovieItem)
            End Get
        End Property
        Public ReadOnly Property MovieItems() As XPCollection(Of MovieItem)
            Get
                Return fmovieItems
            End Get
        End Property
        Protected Overrides Sub CreateNewObject()
            MyBase.CreateNewObject()
            editObject = New MovieItem(Me.movie)
        End Sub
        Protected Overrides Sub InitData()
            MyBase.InitData()
            InitEditors()
            InitValidationRules()
            If Object.Equals(MovieItem, Nothing) Then
                Return
            End If
            lueFormat.EditValue = MovieItem.Format
            ceAvailableForSell.Checked = MovieItem.AvailableForSell
            seSellPrice.Value = MovieItem.SellingPrice
        End Sub

        Private Sub InitValidationRules()
            Dim rule As New ConditionValidationRule()
            rule.ConditionOperator = ConditionOperator.Greater
            rule.Value1 = 0
            rule.ErrorText = ConstStrings.PriceError
            rule.ErrorType = ErrorType.Critical
            dxValidationProvider1.SetValidationRule(seSellPrice, rule)
        End Sub
        Private Sub InitEditors()
            EditorHelper.CreateMovieItemFormatImageComboBox(lueFormat.Properties, Nothing)
            lueFormat.EditValue = MovieItemFormat.DVD
        End Sub
        Protected Overrides Sub InitValidation()
            MyBase.InitValidation()
            ValidationProvider.SetValidationRule(seCount, ValidationRulesHelper.RuleGreaterOrEqual(1))
            ValidationProvider.SetValidationRule(seSellPrice, ValidationRulesHelper.RuleGreaterOrEqualZero)
        End Sub
        Protected Overrides Sub SaveData()
            MyBase.SaveData()
            MovieItem.Format = CType(lueFormat.EditValue, MovieItemFormat)
            MovieItem.AvailableForSell = ceAvailableForSell.Checked
            MovieItem.SellingPrice = seSellPrice.Value
            fmovieItems = MovieItem.CreateFewItems(MovieItem, CInt(Fix(seCount.Value)) - 1)
            fmovieItems.Add(MovieItem)
        End Sub
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			If ceAvailableForSell.Checked AndAlso Object.Equals(DialogResult, DialogResult.OK) Then
				If (Not dxValidationProvider1.Validate()) Then
					e.Cancel = True
					Return
				End If
			End If
			MyBase.OnClosing(e)
		End Sub
	End Class
End Namespace
