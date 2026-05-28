Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports DevExpress.Utils
Imports FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle
Imports SpreadsheetHorizontalAlignment = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class MinesweeperModule
        Inherits DevExpress.XtraSpreadsheet.Demos.SpreadSheetTutorialControlBase

        Friend Enum CellState
            Closed
            Open
            HasMine
        End Enum

        Private ReadOnly closedCellColor As System.Drawing.Color = System.Drawing.Color.FromArgb(222, 222, 222)

        Private ReadOnly hasMineColor As System.Drawing.Color = System.Drawing.Color.FromArgb(159, 203, 87)

        Private ReadOnly openCellColor As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 242, 242)

        Private ReadOnly wrongCellColor As System.Drawing.Color = System.Drawing.Color.FromArgb(236, 111, 105)

        Private map As Integer(,)

        Private vmap As DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState(,)

        Private mapWidth As Integer

        Private mapHeight As Integer

        Private mines As Integer

        Private book As DevExpress.Spreadsheet.IWorkbook

        Private sheet As DevExpress.Spreadsheet.Worksheet

        Private cells As DevExpress.Spreadsheet.CellCollection

        Const Dx As Integer = 3

        Const Dy As Integer = 6

        Private previousCell As String

        Private selectedCell As String

        Private closedCells As Integer

        Private isGameOver As Boolean

        Private ReadOnly offsetX As Integer() = {-1, 0, 1, 1, 1, 0, -1, -1}

        Private ReadOnly offsetY As Integer() = {-1, -1, -1, 0, 1, 1, 1, 0}

        Private leftMouseButton As Boolean

        Private rightMouseButton As Boolean

        Private mouseTicks As Long

        Private ReadOnly flag As System.Drawing.Bitmap

        Private ReadOnly mine As System.Drawing.Bitmap

        Private failedCell As DevExpress.Spreadsheet.Cell

        Private startTime As System.DateTime

        Private ReadOnly Property minesString As String
            Get
                Return " Mines:  " & Me.mines
            End Get
        End Property

        Private ReadOnly Property timerString As String
            Get
                Return If(Me.timer1.Enabled OrElse Me.isGameOver, " Timer:  " & (System.DateTime.Now - Me.startTime).ToString("hh\ \:\ mm\ \:\ ss"), " Timer:  00 : 00 : 00")
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Me.spreadsheetControl.PopupMenuShowing, AddressOf Me.spreadsheetControl_PopupMenuShowing
            AddHandler Me.spreadsheetControl.CustomDrawCell, AddressOf Me.SpreadsheetControlCustomDrawCell
            AddHandler Me.spreadsheetControl.MouseDown, AddressOf Me.SpreadsheetControlMouseDown
            AddHandler Me.spreadsheetControl.MouseMove, AddressOf Me.SpreadsheetControlMouseMove
            AddHandler Me.spreadsheetControl.MouseUp, AddressOf Me.SpreadsheetControlMouseUp
            Me.flag = DevExpress.XtraSpreadsheet.Demos.DemoUtils.LoadImageByName("Flag.png")
            Me.mine = DevExpress.XtraSpreadsheet.Demos.DemoUtils.LoadImageByName("Mine.png")
            Me.spreadsheetControl.[ReadOnly] = True
            Me.spreadsheetControl.BeginUpdate()
            Me.PrepareWorkbook()
            Me.radioGroup1.SelectedIndex = 0
            Me.NewGame()
            Me.spreadsheetControl.EndUpdate()
            Me.spreadsheetControl.Options.Culture = Me.DefaultCulture
            Me.spreadsheetControl.Document.History.Clear()
        End Sub

        Private Sub PrepareMap()
            Me.map = New Integer(Me.mapWidth - 1, Me.mapHeight - 1) {}
            Me.vmap = New DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState(Me.mapWidth - 1, Me.mapHeight - 1) {}
            Dim rnd As DevExpress.Data.Utils.NonCryptographicRandom = DevExpress.Data.Utils.NonCryptographicRandom.System
            For i As Integer = 0 To Me.mines - 1
                Dim x As Integer
                Dim y As Integer
                Do
                    x = rnd.[Next](Me.mapWidth)
                    y = rnd.[Next](Me.mapHeight)
                Loop While Me.map(x, y) = 9

                Me.map(x, y) = 9
                For j As Integer = 0 To 8 - 1
                    If Me.IsCellExistent(x + Me.offsetX(j), y + Me.offsetY(j)) AndAlso Me.map(x + Me.offsetX(j), y + Me.offsetY(j)) <> 9 Then Me.map(x + Me.offsetX(j), y + Me.offsetY(j)) += 1
                Next
            Next

            Me.closedCells = Me.mapWidth * Me.mapHeight
        End Sub

        Private Sub SetCellsSize()
            Dim cellSize As Integer = Me.cellSizeTrack.Value
            For i As Integer = 0 To Me.mapWidth - 1
                Me.sheet.Columns(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx + i))).Width = cellSize
            Next

            For i As Integer = 0 To Me.mapHeight - 1
                Me.sheet.Rows(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy + i))).Height = cellSize
            Next

            Me.sheet.Columns(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx - 1))).Width = 15
            Me.sheet.Columns(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx + Me.mapWidth))).Width = 15
            Me.sheet.Rows(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy - 1))).Height = 15
            Me.sheet.Rows(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy + Me.mapHeight))).Height = 15
            Dim range As DevExpress.Spreadsheet.CellRange = Me.sheet(Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx))).GetReferenceA1() & ":" & Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy + Me.mapHeight - 1)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx + Me.mapWidth - 1))).GetReferenceA1())
            Dim style As DevExpress.Spreadsheet.Formatting = range.BeginUpdateFormatting()
            Try
                style.Font.Size = 0.6 * Me.cellSizeTrack.Value
            Finally
                range.EndUpdateFormatting(style)
            End Try

            range = Me.sheet(Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy - 1)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx - 1))).GetReferenceA1() & ":" & Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy + Me.mapHeight)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx + Me.mapWidth))).GetReferenceA1())
            style = range.BeginUpdateFormatting()
            Try
                style.Borders.SetOutsideBorders(System.Drawing.Color.FromArgb(233, 233, 233), DevExpress.Spreadsheet.BorderLineStyle.Thin)
            Finally
                range.EndUpdateFormatting(style)
            End Try
        End Sub

        Private Sub PrepareWorkbook()
            Me.book = Me.spreadsheetControl.Document
            Me.book.Unit = DevExpress.Office.DocumentUnit.Point
            Me.sheet = Me.book.Worksheets(0)
            Me.sheet.ActiveView.ShowGridlines = False
            Me.cells = Me.sheet.Cells
            Me.sheet.Columns(CStr(("A"))).Width = 20
            Me.sheet.Columns(CStr(("B"))).Width = 10.75
            Me.sheet.Columns(CStr(("C"))).Width = 62
            Me.sheet.Columns(CStr(("D"))).Width = 13
            Me.sheet.Rows(CInt((0))).Height = 21.5
            Me.sheet.Rows(CInt((2))).Height = 22.25
            Me.sheet.Rows(CInt((3))).Height = 14
            Me.sheet.Rows(CInt((4))).Height = 12.75
            Dim range As DevExpress.Spreadsheet.CellRange = Me.sheet("B2:AG2")
            range.Merge()
            Dim style As DevExpress.Spreadsheet.Formatting = range.BeginUpdateFormatting()
            Try
                style.Alignment.Vertical = DevExpress.Spreadsheet.SpreadsheetVerticalAlignment.Center
                style.Alignment.Indent = 1
                style.Font.Size = 24
                style.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Regular
                style.Font.Name = "Segoe UI"
                style.Font.Color = System.Drawing.Color.FromArgb(64, 64, 64)
            Finally
                range.EndUpdateFormatting(style)
            End Try

            Me.cells(CStr(("B2"))).Value = "Minesweeper"
            Me.sheet(CStr(("B3:AG3"))).Merge()
            Me.sheet(CStr(("B4:AG4"))).Merge()
            range = Me.sheet("B3:B4")
            style = range.BeginUpdateFormatting()
            Try
                style.Font.Name = "Segoe UI"
                style.Font.Size = 9.75
                style.Font.Color = System.Drawing.Color.FromArgb(64, 64, 64)
                style.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Regular
                style.Alignment.Indent = 1
            Finally
                range.EndUpdateFormatting(style)
            End Try

            Me.cells(CStr(("B3"))).Value = Me.minesString
            Me.cells(CStr(("B4"))).Value = Me.timerString
        End Sub

        Private Sub ClearFieldOfPlay()
            Dim range As DevExpress.Spreadsheet.CellRange = Me.sheet(Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy - 1)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx - 1))).GetReferenceA1() & ":" & Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy + Me.mapHeight)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx + Me.mapWidth))).GetReferenceA1())
            Me.sheet.Clear(range)
        End Sub

        Private Sub GenerateWorkbook()
            Me.cells(CStr(("B3"))).Value = Me.minesString
            Me.cells(CStr(("B4"))).Value = Me.timerString
            Me.SetCellsSize()
            Dim range As DevExpress.Spreadsheet.CellRange = Me.sheet(Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx))).GetReferenceA1() & ":" & Me.cells(CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy + Me.mapHeight - 1)), CInt((DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx + Me.mapWidth - 1))).GetReferenceA1())
            Dim style As DevExpress.Spreadsheet.Formatting = range.BeginUpdateFormatting()
            Try
                style.Borders.SetAllBorders(System.Drawing.Color.White, DevExpress.Spreadsheet.BorderLineStyle.Medium)
                style.Fill.BackgroundColor = Me.closedCellColor
                style.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
                style.Alignment.Vertical = DevExpress.Spreadsheet.SpreadsheetVerticalAlignment.Center
            Finally
                range.EndUpdateFormatting(style)
            End Try
        End Sub

        Private Sub NewGame()
            Me.isGameOver = False
            Me.timer1.Enabled = False
            Me.cells(CStr(("B4"))).Value = Me.timerString
            Me.spreadsheetControl.BeginUpdate()
            Me.ClearFieldOfPlay()
            If Me.radioGroup1.SelectedIndex = 0 Then
                Me.mapWidth = 8
                Me.mapHeight = 8
                Me.mines = 9
                Me.cellSizeTrack.Value = 35
            ElseIf Me.radioGroup1.SelectedIndex = 1 Then
                Me.mapWidth = 16
                Me.mapHeight = 16
                Me.mines = 40
                Me.cellSizeTrack.Value = 18
            ElseIf Me.radioGroup1.SelectedIndex = 2 Then
                Me.mapWidth = 30
                Me.mapHeight = 16
                Me.mines = 99
                Me.cellSizeTrack.Value = 18
            End If

            Me.PrepareMap()
            Me.GenerateWorkbook()
            Me.failedCell = Nothing
            Me.spreadsheetControl.EndUpdate()
        End Sub

        Private Sub Button1Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.NewGame()
        End Sub

        Private Sub RadioGroup1SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.NewGame()
        End Sub

        Private Sub Timer1Tick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.cells(CStr(("B4"))).Value = Me.timerString
        End Sub

        Private Sub CellSizeTrackValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.book Is Nothing Then Return
            Me.spreadsheetControl.BeginUpdate()
            Me.SetCellsSize()
            Me.spreadsheetControl.EndUpdate()
        End Sub

        Private Function IsCellExistent(ByVal x As Integer, ByVal y As Integer) As Boolean
            Return Not(x < 0 OrElse y < 0 OrElse x >= Me.mapWidth OrElse y >= Me.mapHeight)
        End Function

        Private Sub SpreadsheetControlMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Dim cell As DevExpress.Spreadsheet.Cell = Me.spreadsheetControl.GetCellFromPoint(New System.Drawing.PointF(e.X, e.Y))
            If cell Is Nothing Then Return
            If Not Me.IsCellExistent(cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx, cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy) Then Return
            Dim cellReference As String = cell.GetReferenceA1()
            If Equals(Me.previousCell, cellReference) Then Return
            Me.previousCell = Me.selectedCell
            Me.selectedCell = cellReference
            Me.spreadsheetControl.Refresh()
        End Sub

        Private Sub OpenAllNeighborhood(ByVal cell As DevExpress.Spreadsheet.Cell)
            Dim x As Integer = cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            For i As Integer = 0 To 8 - 1
                If Me.IsCellExistent(x + Me.offsetX(i), y + Me.offsetY(i)) Then Me.OpenCell(Me.cells(cell.RowIndex + Me.offsetY(i), cell.ColumnIndex + Me.offsetX(i)))
            Next
        End Sub

        Private Sub OpenDigit(ByVal cell As DevExpress.Spreadsheet.Cell)
            Dim x As Integer = cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            cell.Fill.BackgroundColor = Me.openCellColor
            Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.Open
            If Me.map(x, y) = 0 Then
                Me.OpenAllNeighborhood(cell)
            Else
                cell.Font.Color = System.Drawing.Color.FromArgb(52, 52, 52)
                cell.Value = Me.map(x, y)
            End If

            Me.closedCells -= 1
            If Me.closedCells = Me.mines Then Me.Win()
        End Sub

        Private Sub OpenCell(ByVal cell As DevExpress.Spreadsheet.Cell)
            Dim x As Integer = cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            If Me.vmap(x, y) <> DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.Closed Then Return
            If Me.map(x, y) = 9 Then
                Me.Failed(cell)
            Else
                Me.OpenDigit(cell)
            End If
        End Sub

        Private Sub Failed(ByVal cell As DevExpress.Spreadsheet.Cell)
            Me.timer1.Enabled = False
            Me.failedCell = cell
            Me.isGameOver = True
            Me.spreadsheetControl.Refresh()
        End Sub

        Private Sub Win()
            Me.timer1.Enabled = False
            Me.isGameOver = True
            For xi As Integer = 0 To Me.mapWidth - 1
                For yi As Integer = 0 To Me.mapHeight - 1
                    If Me.vmap(xi, yi) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.Closed Then Me.vmap(xi, yi) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.HasMine
                Next
            Next

            Me.mines = 0
            Me.cells(CStr(("B3"))).Value = Me.minesString
        End Sub

        Private Sub LeftMouseButtonClick(ByVal cell As DevExpress.Spreadsheet.Cell)
            Me.OpenCell(cell)
        End Sub

        Private Sub RightMouseButtonClick(ByVal cell As DevExpress.Spreadsheet.Cell)
            Dim x As Integer = cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            If Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.HasMine Then
                Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.Closed
                cell.Fill.BackgroundColor = Me.closedCellColor
                Me.mines += 1
                Me.closedCells += 1
            ElseIf Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.Closed Then
                Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.HasMine
                Me.mines -= 1
                Me.closedCells -= 1
            End If

            Me.cells(CStr(("B3"))).Value = Me.minesString
        End Sub

        Private Sub MiddleMouseButtonClick(ByVal cell As DevExpress.Spreadsheet.Cell)
            Dim x As Integer = cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            If Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.Open Then
                Dim need As Integer = 0
                For i As Integer = 0 To 8 - 1
                    If Me.IsCellExistent(x + Me.offsetX(i), y + Me.offsetY(i)) AndAlso Me.vmap(x + Me.offsetX(i), y + Me.offsetY(i)) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.HasMine Then need += 1
                Next

                If need = Me.map(x, y) Then Me.OpenAllNeighborhood(cell)
            End If
        End Sub

        Private Sub SpreadsheetControlMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Dim cell As DevExpress.Spreadsheet.Cell = Me.spreadsheetControl.GetCellFromPoint(New System.Drawing.PointF(e.X, e.Y))
            If cell Is Nothing Then Return
            Dim x As Integer = cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            If Not Me.IsCellExistent(x, y) Then Return
            If Me.isGameOver Then Return
            If Not Me.timer1.Enabled Then
                Me.startTime = System.DateTime.Now
                Me.timer1.Enabled = True
            End If

            Me.spreadsheetControl.BeginUpdate()
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Me.leftMouseButton = True
                If Me.rightMouseButton Then
                    Dim ts As System.TimeSpan = New System.TimeSpan(System.DateTime.Now.Ticks - Me.mouseTicks)
                    If ts.Milliseconds < 600 Then Me.MiddleMouseButtonClick(cell)
                Else
                    Me.mouseTicks = System.DateTime.Now.Ticks
                    Me.LeftMouseButtonClick(cell)
                End If
            ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
                Me.rightMouseButton = True
                If Me.leftMouseButton Then
                    Dim ts As System.TimeSpan = New System.TimeSpan(System.DateTime.Now.Ticks - Me.mouseTicks)
                    If ts.Milliseconds < 600 Then Me.MiddleMouseButtonClick(cell)
                Else
                    Me.mouseTicks = System.DateTime.Now.Ticks
                    Me.RightMouseButtonClick(cell)
                End If
            ElseIf e.Button = System.Windows.Forms.MouseButtons.Middle Then
                Me.MiddleMouseButtonClick(cell)
            End If

            Me.spreadsheetControl.EndUpdate()
            Me.spreadsheetControl.Refresh()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            Me.spreadsheetControl.Focus()
        End Sub

        Private Sub spreadsheetControl_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.PopupMenuShowingEventArgs)
            e.Menu = Nothing
        End Sub

        Private Sub SpreadsheetControlMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Me.leftMouseButton = False
            ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
                Me.rightMouseButton = False
            End If
        End Sub

        Private Sub SpreadsheetControlCustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.CustomDrawCellEventArgs)
            e.DrawDefault()
            Dim x As Integer = e.Cell.ColumnIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dx
            Dim y As Integer = e.Cell.RowIndex - DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.Dy
            Dim fillColor As System.Drawing.Color = System.Drawing.Color.Empty
            Dim image As System.Drawing.Image = Nothing
            If Not Me.IsCellExistent(x, y) Then Return
            If Me.failedCell IsNot Nothing Then
                If Me.map(x, y) = 9 Then
                    If e.Cell Is Me.failedCell Then fillColor = Me.wrongCellColor
                    image = Me.mine
                End If
            End If

            If Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.HasMine Then
                fillColor = If(Me.isGameOver AndAlso Me.map(x, y) <> 9, Me.wrongCellColor, Me.hasMineColor)
                image = Me.flag
            End If

            If Equals(e.Cell.GetReferenceA1(), Me.selectedCell) Then
                fillColor = If(Me.vmap(x, y) = DevExpress.XtraSpreadsheet.Demos.MinesweeperModule.CellState.HasMine, System.Drawing.Color.FromArgb(103, 169, 24), System.Drawing.Color.FromArgb(200, 200, 200))
            End If

            If Not DevExpress.Utils.DXColor.IsEmpty(fillColor) Then
                e.Cache.FillRectangle(fillColor, e.FillBounds)
                e.Cache.DrawRectangle(New System.Drawing.Pen(System.Drawing.Color.White, 1), e.FillBounds)
            End If

            If image IsNot Nothing Then
                Dim l As Integer = System.Convert.ToInt32(e.FillBounds.Left + (e.FillBounds.Width + 1 - Me.mine.Width) \ 2)
                Dim t As Integer = System.Convert.ToInt32(e.Bounds.Top + (e.FillBounds.Height + 1 - Me.mine.Height) \ 2)
                e.Graphics.DrawImageUnscaled(image, l, t)
            End If
        End Sub
    End Class
End Namespace
