Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors

Namespace DevExpress.VideoRent.Reports
	Partial Public Class FilmInfoCardReport
		Inherits ReportBase
		Private Const filmListParameterName As String = "filmListParameter"
		Private Const separatorChar As Char = ";"c
		Private separatorString As String = New String(New Char() { separatorChar, " "c })
		Private isParameterInitialized As Boolean = False

		Public Sub New()
			InitializeComponent()
			DisplayName = ReportConstStrings.FilmCardsReport
			Dim filmListParameter As New Parameter()
			filmListParameter.Name = filmListParameterName
			filmListParameter.Type = GetType(String)
			filmListParameter.Description = "Movies:"
			Me.Parameters.Add(filmListParameter)
		End Sub

		Protected Overrides Sub OnParametersRequestBeforeShow(ByVal e As ParametersRequestEventArgs)
			MyBase.OnParametersRequestBeforeShow(e)

			For Each info As ParameterInfo In e.ParametersInformation
				If info.Parameter.Name = filmListParameterName Then
					info.Editor = CreateCheckedComboBoxEdit()
				End If
			Next info
			If (Not isParameterInitialized) AndAlso ((Not Object.Equals(xpCollectionMovies.Session, Nothing))) Then
				Const filmLimit As Integer = 5
				Dim isFirstIteration As Boolean = True
				Dim films As String = String.Empty
				For filmIndex As Integer = 0 To filmLimit - 1
					If (Not isFirstIteration) Then
						films &= separatorString
					Else
						isFirstIteration = False
					End If
					films &= (CType(xpCollectionMovies(filmIndex), Movie)).Title
				Next filmIndex
				Parameters(filmListParameterName).Value = films
				isParameterInitialized = True
				FilterString = GetFilterString()
			End If
		End Sub
		Private Function CreateCheckedComboBoxEdit() As CheckedComboBoxEdit
			Dim checkedComboBoxEdit As New CheckedComboBoxEdit()
			checkedComboBoxEdit.Properties.DataSource = xpCollectionMovies
			checkedComboBoxEdit.Properties.DisplayMember = "Title"
			checkedComboBoxEdit.Properties.SeparatorChar = separatorChar
			If Object.Equals(checkedComboBoxEdit.Properties.PopupControl, Nothing) Then
				Dim metodInfo As System.Reflection.MethodInfo = GetType(CheckedComboBoxEdit).GetMethod("CreatePopupCheckListControl", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
				checkedComboBoxEdit.Properties.PopupControl = TryCast(metodInfo.Invoke(checkedComboBoxEdit, Nothing), PopupContainerControl)
			End If
			checkedComboBoxEdit.Properties.PopupFormMinSize = New System.Drawing.Size(220, 390)
			checkedComboBoxEdit.Properties.PopupFormSize = checkedComboBoxEdit.Properties.PopupFormMinSize
			Return checkedComboBoxEdit
		End Function
		Protected Overrides Sub OnParametersRequestSubmit(ByVal e As ParametersRequestEventArgs)
			MyBase.OnParametersRequestSubmit(e)

            Dim info As ParameterInfo = e.ParametersInformation.FirstOrDefault(Function(x) x.Parameter.Name = filmListParameterName)
            Dim editor As CheckedComboBoxEdit = If(info IsNot Nothing, TryCast(info.Editor, CheckedComboBoxEdit), Nothing)
            If editor IsNot Nothing AndAlso AreAllItemsChecked(editor) Then
                FilterString = String.Empty
                Return
            End If
            FilterString = GetFilterString()
        End Sub
        Shared _FindEditorParameterName As String

        Private Shared Function GetInfo(ByVal info As ParameterInfo) As Boolean
            Return info.Parameter.Name = _FindEditorParameterName
        End Function

		Private Function GetFilterString() As String
			Dim value As String = TryCast(Parameters(filmListParameterName).Value, String)
			If String.IsNullOrEmpty(value) Then
				Return String.Empty
			End If
			Dim values() As String = value.Split(New String() { separatorString }, StringSplitOptions.None)
			If Object.Equals(values, Nothing) OrElse values.Length = 0 Then
				Return String.Empty
			End If
			Dim isFirstIteration As Boolean = True
			Dim filterBuffer As String = String.Empty
			For Each name As String In values
				If (Not isFirstIteration) Then
					filterBuffer &= " Or "
				End If
				Dim result As String = name.Replace("'", "''")
				filterBuffer &= String.Format("[Movie.Title] = '{0}'", result)
				isFirstIteration = False
			Next name
			Return filterBuffer
		End Function
		Private Function AreAllItemsChecked(ByVal editor As CheckedComboBoxEdit) As Boolean
			If editor.Properties.Items.Count = 0 Then
				Return False
			End If
			For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In editor.Properties.Items
				If item.CheckState = System.Windows.Forms.CheckState.Unchecked Then
					Return False
				End If
			Next item
			Return True
		End Function
		Private Sub xrBarCode2_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrBarCodeMoviItemId.BeforePrint
			Dim barCode As XRBarCode = TryCast(sender, XRBarCode)
			Dim movieItem As MovieItem = TryCast(GetCurrentRow(), MovieItem)
			barCode.Text = String.Format("{0:d6}", movieItem.MovieItemId)
		End Sub
		Private Sub xpCollectionMovieItems_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionMovieItems.ResolveSession
			e.Session = Session
		End Sub
		Private Sub xpCollectionMovies_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionMovies.ResolveSession
			e.Session = Session
		End Sub
	End Class
End Namespace
