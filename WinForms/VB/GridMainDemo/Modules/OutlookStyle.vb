Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for OutlookStyle.
    ''' </summary>
    Public Partial Class OutlookStyle
        Inherits TutorialControl

        Private currentMessageCore As Message

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
        '<gridControl1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' gridView1.OptionsView.GroupDrawMode = Views.Grid.GroupDrawMode.Office;
        ' gridView1.OptionsView.ShowGroupedColumns = true;
        ' gridView1.OptionsView.ShowGroupPanel = false;
        ' gridView1.OptionsView.ShowVerticalLines = Utils.DefaultBoolean.False;
        ' 
        '</gridControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"OutlookStyle"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "OutlookStyle"
            End Get
        End Property

        Private mTimerCore As MailTimer = Nothing

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private Sub OutlookStyle_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsView.ShowPreview = True
            gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False
            gridControl1.DataSource = DataHelper.Messages
            gridView1.SetRowExpanded(-1, True)
            gridView1.SetRowExpanded(-2, True)
            Dim row As Message = TryCast(gridView1.GetRow(0), Message)
            If row IsNot Nothing Then gridView1.FocusedRowHandle = If(row.Subject.StartsWith("FW", StringComparison.Ordinal), 0, 1)
            OnStyleChanged()
            SetAlertControlButtonHint()
            CalcPreviewIndent()
        End Sub

        Private ReadOnly Property MTimer As MailTimer
            Get
                If mTimerCore Is Nothing Then mTimerCore = New MailTimer(DataHelper.Messages, alertControl1, FindForm())
                Return mTimerCore
            End Get
        End Property

        Private Sub SetAlertControlButtonHint()
            alertControl1.Buttons(0).Hint = Properties.Resources.MarkAsRead
            alertControl1.Buttons(1).Hint = Properties.Resources.OpenAttachment
            alertControl1.Buttons(2).Hint = Properties.Resources.DeleteItem
        End Sub

        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As Views.Base.RowObjectCustomDrawEventArgs)
            Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
            If info Is Nothing Then Return
            info.GroupText = info.GroupText.Replace("1 " & Properties.Resources.Items, "1 " & Properties.Resources.Item)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            gridControl1.Focus()
            MTimer.Start()
        End Sub

        Protected Overrides Sub DoHide()
            MTimer.Stop()
        End Sub

#Region "Alerter"
        Private Sub alertControl1_ButtonDownChanged(ByVal sender As Object, ByVal e As AlertButtonDownChangedEventArgs)
            If Equals(e.ButtonName, "Read") Then ToggleRead(TryCast(e.Info.Tag, Message))
        End Sub

        Private Sub RaiseReadMessagesChanged(ByVal rowHandle As Integer)
            Dim current As Message = TryCast(gridView1.GetRow(rowHandle), Message)
            If current Is Nothing Then Return
            current.ToggleRead()
            gridView1.LayoutChanged()
            gridView1.MakeRowVisible(gridView1.FocusedRowHandle)
        End Sub

        Private Sub alertControl1_ButtonClick(ByVal sender As Object, ByVal e As AlertButtonClickEventArgs)
            Dim data As Message = TryCast(e.Info.Tag, Message)
            e.AlertForm.OwnerForm.Activate()
            If Equals(e.ButtonName, "Attachment") Then
                e.AlertForm.Close()
                Call XtraMessageBox.Show(FindForm(), "Open attachment dialog.", String.Format("Mail From: {0}", data.From))
            End If

            If Equals(e.ButtonName, "Delete") Then DeleteItem(e, data)
        End Sub

        Private Sub OpenItem(ByVal message As Message)
            Dim rowIndex As Integer = GetMessageRowHandle(message)
            If rowIndex > -1 Then
                gridView1.FocusedRowHandle = rowIndex
                gridView1.MakeRowVisible(rowIndex, True)
            End If
        End Sub

        Private Function GetMessageRowHandle(ByVal message As Message) As Integer
            For i As Integer = 0 To gridView1.RowCount - 1
                If message.Equals(gridView1.GetRow(i)) Then
                    Return i
                End If
            Next

            Return -1
        End Function

        Private Sub DeleteItem(ByVal args As AlertClickEventArgs, ByVal message As Message)
            args.AlertForm.Close()
            Try
                Dim rowIndex As Integer = GetMessageRowHandle(message)
                If rowIndex > -1 Then gridView1.DeleteRow(rowIndex)
                gridView1.LayoutChanged()
                UpdateCurrentMessage()
            Catch
            End Try
        End Sub

        Private Sub alertControl1_AlertClick(ByVal sender As Object, ByVal e As AlertClickEventArgs)
            Dim data As Message = TryCast(e.Info.Tag, Message)
            OpenItem(data)
        End Sub

#End Region
#Region "AlertPopupMenu"
        Private updatePopupMenu As Boolean = False

        Private Sub popupMenu1_BeforePopup(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim args As AlertClickEventArgs = TryCast(popupMenu1.ItemLinks(0).Item.Tag, AlertClickEventArgs)
            If args Is Nothing Then Return
            Dim data As Message = TryCast(args.Info.Tag, Message)
            updatePopupMenu = True
            If 1.Equals(data.Read) Then
                biRead.Caption = Properties.Resources.UnreadMark
                biRead.ImageIndex = 2
            Else
                biRead.Caption = Properties.Resources.ReadMark
                biRead.ImageIndex = 1
            End If

            If data.Priority = 0 Then bcLow.Checked = True
            If data.Priority = 1 Then bcMedium.Checked = True
            If data.Priority = 2 Then bcHigh.Checked = True
            updatePopupMenu = False
        End Sub

        Private Sub biOpen_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            OpenItem(TryCast(args.Info.Tag, Message))
        End Sub

        Private Sub biRead_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            Dim message As Message = TryCast(args.Info.Tag, Message)
            ToggleRead(message)
            args.AlertForm.Buttons("Read").Down = message.Read = 1
        End Sub

        Private Sub biDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            DeleteItem(args, TryCast(args.Info.Tag, Message))
        End Sub

        Private Sub bc_DownChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If updatePopupMenu Then Return
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            Dim data As Message = TryCast(args.Info.Tag, Message)
            Dim item As BarCheckItem = TryCast(e.Item, BarCheckItem)
            If Not item.Checked Then Return
            If bcLow.Checked Then data.Priority = 0
            If bcMedium.Checked Then data.Priority = 1
            If bcHigh.Checked Then data.Priority = 2
            gridView1.LayoutChanged()
        End Sub

        Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            If args Is Nothing Then Return
            args.AlertForm.OwnerForm.Activate()
        End Sub

        Private Sub ToggleRead(ByVal message As Message)
            message.ToggleRead()
            gridView1.LayoutChanged()
        End Sub

#End Region
        Private Sub gridControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hi As GridHitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
            If hi.InRow AndAlso gridView1.FocusedRowHandle > -1 Then
                mTimerCore.ShowAlert(TryCast(gridView1.GetFocusedRow(), Message))
            End If
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As Views.Base.FocusedRowChangedEventArgs)
            UpdateCurrentMessage()
        End Sub

        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateCurrentMessage()
        End Sub

        Private Property CurrentMessage As Message
            Get
                Return currentMessageCore
            End Get

            Set(ByVal value As Message)
                If currentMessageCore Is value Then Return
                currentMessageCore = value
                ucMailViewer1.ShowMessage(CurrentMessage)
            End Set
        End Property

        Private Sub UpdateCurrentMessage()
            If gridView1.FocusedRowHandle >= 0 Then
                CurrentMessage = TryCast(gridView1.GetFocusedRow(), Message)
            Else
                Dim rows As List(Of Message) = New List(Of Message)()
                ObjectHelper.GetChildDataRowHandles(gridView1, gridView1.FocusedRowHandle, rows)
                ucMailViewer1.ShowMessagesInfo(rows)
                CurrentMessage = Nothing
            End If
        End Sub

        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As Views.Grid.RowCellClickEventArgs)
            If e.Column Is gridColumn7 AndAlso e.Button = MouseButtons.Left Then RaiseReadMessagesChanged(e.RowHandle)
        End Sub

        Private Sub CalcPreviewIndent()
            Dim indent As Integer = 0
            For Each column As GridColumn In gridView1.VisibleColumns
                If "Priority;Read;Attachment".IndexOf(column.FieldName) > -1 Then
                    indent += column.Width
                Else
                    Exit For
                End If
            Next

            gridView1.PreviewIndent = indent
        End Sub

        Private Sub gridView1_ColumnPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            CalcPreviewIndent()
        End Sub

#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
