Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraEditors

Namespace DevExpress.Xpo.Demos
	<DeferredDeletion(False)> _
	Public Class ServerSideLookUpTest
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public AssignTo As String
		Public Issue As ServerSideGridTest
		Public DueDate As DateTime
		Public PercentComplete As Integer
	End Class
	<DeferredDeletion(False)> _
	Public Class ServerSideGridTest
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		<Indexed> _
		Public Subject As String
		<Indexed> _
		Public [From] As String
		<Indexed> _
		Public Sent As DateTime
		<Indexed> _
		Public Size As Int64
		<Indexed> _
		Public HasAttachment As Boolean
		<Indexed> _
		Public Priority As Integer
	End Class
	Public Class MemoWriter
		Inherits TextWriter
		Public Memo As MemoEdit
		Public Sub New()
		End Sub
		Private ReadOnly enc As Encoding = New UnicodeEncoding(False, False)
		Public Overrides ReadOnly Property Encoding() As Encoding
			Get
				Return enc
			End Get
		End Property
		Public Overrides Overloads Sub Write(ByVal value As Char)
			Write(value.ToString())
		End Sub
		Public Overrides Overloads Sub Write(ByVal value As String)
			If Memo Is Nothing Then
				Return
			End If
			Memo.Text += value
			Memo.SelectionStart = Integer.MaxValue
		End Sub
	End Class
	Public Class WaitCursorWrapper
		Implements IDataStore
		Public ReadOnly Nested As IDataStore
		Public Sub New(ByVal nested As IDataStore)
			Me.Nested = nested
		End Sub
		Public ReadOnly Property AutoCreateOption() As AutoCreateOption Implements IDataStore.AutoCreateOption
			Get
				Return Nested.AutoCreateOption
			End Get
		End Property
		Public Function ModifyData(ParamArray ByVal dmlStatements() As ModificationStatement) As ModificationResult Implements IDataStore.ModifyData
			Try
				Cursor.Current = Cursors.WaitCursor
				Return Nested.ModifyData(dmlStatements)
			Finally
				Cursor.Current = Cursors.Default
			End Try
		End Function
		Public Function SelectData(ParamArray ByVal selects() As SelectStatement) As SelectedData Implements IDataStore.SelectData
			Try
				Cursor.Current = Cursors.WaitCursor
				Return Nested.SelectData(selects)
			Finally
				Cursor.Current = Cursors.Default
			End Try
		End Function
		Public Function UpdateSchema(ByVal dontCreateIfFirstTableNotExist As Boolean, ParamArray ByVal tables() As DBTable) As UpdateSchemaResult Implements IDataStore.UpdateSchema
			Try
				Cursor.Current = Cursors.WaitCursor
				Return Nested.UpdateSchema(dontCreateIfFirstTableNotExist, tables)
			Finally
				Cursor.Current = Cursors.Default
			End Try
		End Function
	End Class
	Public Class ServerModeStrings
		Public Shared SQLConnectionString As String = String.Empty
		Public Shared failedConnection As String = "Failed to connect to the server."
		Public Shared failedConnectionCaption As String = "Connection Error"
		Public Shared dataAdding As String = "Adding next portion of data..."
		Public Shared recordCount As String = "Current record count = {0}"
		Public Shared descriptionSQLConnection As String = "This demo shows a grid control's capabilities when it's bound to a large amount of data. In this example, the grid control needs to be connected to a data table on an MS SQL server. Please use this Configuration Window to configure data and connection settings." & Constants.vbCrLf & "On the first run:" & Constants.vbCrLf & "1) Specify the name of an existing SQL Server which will contain the target database;" & Constants.vbCrLf & "2) Specify the amount of records in the target table and click the Generate Table and Start Demo button. A new table will be generated and the demo will start with the grid control bound to the generated recordset." & Constants.vbCrLf & "On subsequent runs, you can add more records to the database or just start the demo without generating additional data."
		Public Shared descriptionServerSide As String = "This application demonstrates the XtraGrid control functioning in server mode, which is specifically designed to handle large volumes of data. Data is supplied to the grid control in small portions when required; it is never loaded into memory in its entirety. In addition, all data-aware operations are performed on the server side. All of this guarantees rapid data display and processing." & Constants.vbCrLf & "Practice with scrolling records, sorting, grouping and filtering against columns, and calculating summaries. Specific operations that you execute may take some time. In server mode, performance is wholly dependent on the data transfer speed, and the performance of the data server which carries out requested operations." & Constants.vbCrLf & "All operations performed on data are logged, and can be seen in the Tracing pane. To slightly improve performance, you can disable tracing by clearing the Enable Tracing checkbox."
		Public Shared descriptionLookUpServerSide As String = "This application demonstrates the GridLookUpEdit control functioning in server mode. Data is supplied to the control in small portions when required; it's never loaded into memory in its entirety. In addition, all data-aware operations are performed on the server side. All of this guarantees rapid data display and processing." & Constants.vbCrLf & "Open an in-place GridLookUpEdit editor (by clicking on the Issue column's cell) and practice with scrolling records, sorting, grouping and filtering against columns, and calculating summaries. Specific operations that you execute may take some time. In server mode, performance is wholly dependent on the data transfer speed, and the performance of the data server which carries out requested operations." & Constants.vbCrLf & "All operations performed on data are logged, and can be seen in the Tracing pane. To slightly improve performance, you can disable tracing by clearing the Enable Tracing checkbox."

	End Class

End Namespace
