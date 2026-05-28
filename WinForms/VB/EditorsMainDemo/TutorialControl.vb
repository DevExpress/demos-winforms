Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos
Imports DevExpress.Export
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraLayout
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraTab
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraEditors.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase

        Private centerControls As List(Of Panel) = New List(Of Panel)()

        Public Sub New()
            Padding = Padding.Empty
            AddHandler SizeChanged, Sub(s, e) UpdatePosition()
            SubscribeOnEvents()
        End Sub

        Protected Overridable ReadOnly Property AllowCenterControls As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "EditorsMainDemo\Modules"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraEditors.Demos.CodeInfo"
            End Get
        End Property

        Private Sub UpdatePosition()
            For Each pnl As Panel In centerControls
                If pnl.Parent Is Nothing Then Continue For
                pnl.Location = New Point((pnl.Parent.Width - pnl.Width) \ 2, (pnl.Parent.Height - pnl.Height) \ 2)
            Next
        End Sub

#Region "Export"
        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.XLS Or ExportFormats.DOCX Or ExportFormats.RTF Or ExportFormats.XLSX, False)
        End Sub

        Public Overridable ReadOnly Property ExportView As BaseView
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", Properties.Resources.PDFFilter)
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", Properties.Resources.HTMLFilter)
        End Sub

        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", Properties.Resources.MHTFilter)
        End Sub

        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", Properties.Resources.XLSFilter)
        End Sub

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", Properties.Resources.XLSXFilter)
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", Properties.Resources.RTFFilter)
        End Sub

        Protected Overrides Sub ExportToDOCX()
            ExportTo("docx", Properties.Resources.DOCXFilter)
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportView Is Nothing Then Return
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "rtf") Then ExportView.ExportToRtf(filename)
            If Equals(ext, "pdf") Then ExportView.ExportToPdf(filename)
            If Equals(ext, "docx") Then ExportView.ExportToDocx(filename)
            If Equals(ext, "html") Then ExportView.ExportToHtml(filename)
            If Equals(ext, "xls") Then ExportViewToXls(filename)
            If Equals(ext, "xlsx") Then ExportViewToXlsx(filename)
            Cursor.Current = currentCursor
        End Sub

        Private Sub ExportViewToXlsx(ByVal filename As String)
            Dim options = New XlsxExportOptionsEx()
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula
            ExportView.ExportToXlsx(filename, options)
        End Sub

        Private Sub ExportViewToXls(ByVal filename As String)
            Dim options = New XlsExportOptionsEx()
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula
            ExportView.ExportToXls(filename, options)
        End Sub

        Protected Overrides Sub PrintPreview()
            If ExportView IsNot Nothing AndAlso ExportView.GridControl IsNot Nothing Then
                AddHandler ExportView.PrintInitialize, AddressOf ExportView_PrintInitialize
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    ExportView.GridControl.ShowRibbonPrintPreview()
                Else
                    ExportView.GridControl.ShowPrintPreview()
                End If

                RemoveHandler ExportView.PrintInitialize, AddressOf ExportView_PrintInitialize
            End If
        End Sub

        Private Sub ExportView_PrintInitialize(ByVal sender As Object, ByVal e As PrintInitializeEventArgs)
            Dim phf As PageHeaderFooter = TryCast(e.Link.PageHeaderFooter, PageHeaderFooter)
            If phf IsNot Nothing Then
                phf.Footer.Content.Clear()
                phf.Footer.Content.AddRange(New String() {"", "", "[Page # of Pages #]"})
                phf.Footer.LineAlignment = BrickAlignment.Far
            End If

            e.Link.RtfReportHeader = "{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\qc\lang9\f0\fs32 " & TutorialName & "\par}\xd\x\a"
        End Sub

#End Region
        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim grid As GridControl = TryCast(ctrl, GridControl)
            If grid IsNot Nothing Then grid.MenuManager = manager
            Dim pGrid As PropertyGridControl = TryCast(ctrl, PropertyGridControl)
            If pGrid IsNot Nothing Then pGrid.MenuManager = manager
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If AllowCenterControls Then
                For Each ctrl As Control In Me.Controls
                    Dim tabControl As XtraTabControl = TryCast(ctrl, XtraTabControl)
                    If tabControl IsNot Nothing Then UpdateTabControlPosition(tabControl)
                    Dim tablePanel = TryCast(ctrl, Utils.Layout.TablePanel)
                    If tablePanel IsNot Nothing Then CalcTablePanelBounds(tablePanel)
                    Dim tabPane As TabPane = TryCast(ctrl, TabPane)
                    If tabPane IsNot Nothing Then UpdateTabPanePosition(tabPane)
                Next

                UpdatePosition()
            End If

            CalcContentCore()
        End Sub

        Protected Overridable Sub CalcContentCore()
        End Sub

        Protected Overridable Overloads Sub OnLookAndFeelChanged(ByVal sender As Object, ByVal e As EventArgs)
            CalcContentCore()
        End Sub

        Protected Overridable Sub SubscribeOnEvents()
            If LookAndFeel IsNot Nothing Then AddHandler LookAndFeel.StyleChanged, AddressOf OnLookAndFeelChanged
        End Sub

        Protected Overridable Sub UnsubscribeOnEvents()
            If LookAndFeel IsNot Nothing Then RemoveHandler LookAndFeel.StyleChanged, AddressOf OnLookAndFeelChanged
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            If lockCalcContentCore = 0 Then CalcContentCore()
        End Sub

        Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
            MyBase.OnVisibleChanged(e)
            If Visible Then CalcContentCore()
        End Sub

        Private lockCalcContentCore As Integer = 0

        Protected Overrides Sub DoDpiChange(ByVal deviceDpiOld As Integer, ByVal deviceDpiNew As Integer)
            lockCalcContentCore += 1
            MyBase.DoDpiChange(deviceDpiOld, deviceDpiNew)
        End Sub

        Protected Overrides Sub DoDpiChangeAfterParent()
            MyBase.DoDpiChangeAfterParent()
            lockCalcContentCore -= 1
            If Visible Then BeginInvoke(New Action(Sub() CalcContentCore()))
        End Sub

        Protected Sub CalcLayoutControlBounds(ByVal layout As LayoutControl)
            If layout Is Nothing OrElse layout.Parent Is Nothing OrElse Not layout.Parent.IsHandleCreated Then Return
            Dim bestSize As Size = CalcBestSize(layout)
            layout.SetBounds((layout.Parent.Width - bestSize.Width) \ 2, (layout.Parent.Height - bestSize.Height) \ 2, bestSize.Width, bestSize.Height)
        End Sub

        Protected Sub CalcTablePanelBounds(ByVal tablePanel As Utils.Layout.TablePanel)
            If tablePanel Is Nothing OrElse tablePanel.Parent Is Nothing OrElse Not tablePanel.Parent.IsHandleCreated Then Return
            Dim bestSize As Size = tablePanel.Size
            tablePanel.SetBounds((tablePanel.Parent.Width - bestSize.Width) \ 2, (tablePanel.Parent.Height - bestSize.Height) \ 2, bestSize.Width, bestSize.Height)
        End Sub

        Private Function CalcBestSize(ByVal layout As LayoutControl) As Size
            Dim minSize As Size = layout.Root.MinSize
            Dim vScrBar As VScrollBar = TryCast(layout.Controls.Cast(Of Control)().FirstOrDefault(Function(control) TypeOf control Is VScrollBar), VScrollBar)
            Dim hScrBar As HScrollBar = TryCast(layout.Controls.Cast(Of Control)().FirstOrDefault(Function(control) TypeOf control Is HScrollBar), HScrollBar)
            If vScrBar Is Nothing OrElse hScrBar Is Nothing Then Return layout.Size
            Dim bestWidth As Integer = Math.Min(layout.Parent.Width, minSize.Width)
            Dim bestHeight As Integer = Math.Min(layout.Parent.Height, minSize.Height)
            Dim wasCalcWidth As Boolean = False
            If bestWidth < minSize.Width Then
                bestHeight += hScrBar.Height
                wasCalcWidth = True
            End If

            If bestHeight < minSize.Height Then
                bestWidth += vScrBar.Width
                If Not wasCalcWidth AndAlso bestWidth < minSize.Width Then
                    bestHeight += hScrBar.Height
                End If
            End If

            Return New Size(Math.Min(layout.Parent.Width, bestWidth), Math.Min(layout.Parent.Height, bestHeight))
        End Function

        Protected Overridable Sub UpdateTabControlPosition(ByVal tabControl As XtraTabControl)
            AddHandler tabControl.SelectedPageChanged, Sub(s, e) UpdatePosition()
            For Each page As XtraTabPage In tabControl.TabPages
                If page IsNot Nothing Then UpdatePagePosition(page)
            Next
        End Sub

        Protected Overridable Sub UpdateTabPanePosition(ByVal tabPane As TabPane)
            AddHandler tabPane.SelectedPageChanged, Sub(s, e) UpdatePosition()
        End Sub

        Protected Sub CalcTrackBarBestSize(ByVal trackBar As TrackBarControl)
            trackBar.Properties.AutoSize = False
            Dim viewInfo = TryCast(trackBar.GetViewInfo(), ViewInfo.TrackBarViewInfo)
            If viewInfo IsNot Nothing Then viewInfo.AllowDrawFocusRect = False
            Dim bestHeight As Integer = trackBar.CalcBestSize().Height
            trackBar.MinimumSize = New Size(trackBar.MinimumSize.Width, bestHeight)
            trackBar.MaximumSize = New Size(trackBar.MaximumSize.Width, bestHeight)
            trackBar.Height = bestHeight
        End Sub

        Protected Overridable Sub UpdatePagePosition(ByVal page As XtraTabPage)
            Dim pnl As Panel = New Panel()
            Dim _left As Integer = 100, _right As Integer = 0, _top As Integer = 100, _bottom As Integer = 0
            For i As Integer = page.Controls.Count - 1 To 0 Step -1
                Dim ctrl As Control = page.Controls(i)
                If TypeOf ctrl Is PopupContainerControl OrElse TypeOf ctrl Is PopupControlContainer OrElse TypeOf ctrl Is FlyoutPanel Then Continue For
                If _left > ctrl.Left Then _left = ctrl.Left
                If _right < ctrl.Right Then _right = ctrl.Right
                If _top > ctrl.Top Then _top = ctrl.Top
                If _bottom < ctrl.Bottom Then _bottom = ctrl.Bottom
                ctrl.Parent = pnl
            Next

            pnl.Parent = page
            pnl.Size = New Size(_right + _left, _bottom + _top)
            centerControls.Add(pnl)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            UnsubscribeOnEvents()
            MyBase.Dispose(disposing)
        End Sub

        Private Shared nwindDataSetField As DataSet

        Protected Shared ReadOnly Property NWindDataSet As DataSet
            Get
                Return If(nwindDataSetField, Function()
                    nwindDataSetField = LoadNWindDataSet()
                    Return nwindDataSetField
                End Function())
            End Get
        End Property

        Private Shared Function LoadNWindDataSet() As DataSet
            Dim nwind = New DataSet()
            Dim dbFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then
                nwind.ReadXml(dbFileName)
                Tutorials.TutorialHelper.DataSetConvertByteToImage(nwind)
            End If

            Return nwind
        End Function
    End Class

    Public Class MatchFunction
        Implements ICustomFunctionDisplayAttributes

        Public Const FunctionName As String = "Match"

        Private Shared ReadOnly Instance As MatchFunction = New MatchFunction()

        Private Sub New()
        End Sub

        '
        Public Shared Sub Register()
            CriteriaOperator.RegisterCustomFunction(Instance)
        End Sub

        Public Shared Function Unregister() As Boolean
            Return CriteriaOperator.UnregisterCustomFunction(Instance)
        End Function

        Public Shared Function Criteria(ByVal [property] As String, ByVal tags As IEnumerable(Of String)) As CriteriaOperator
            Dim operands As List(Of CriteriaOperator) = New List(Of CriteriaOperator)()
            operands.Add(New OperandProperty([property]))
            For Each tag In tags
                operands.Add(New ConstantValue(tag))
            Next

            Return New FunctionOperator(FunctionName, operands)
        End Function

#Region "ICustomFunctionOperatorBrowsable Members"
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.Text
            End Get
        End Property

        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "Selects items that match the specified tags."
            End Get
        End Property

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count > 1
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return type Is GetType(String)
        End Function

        Public ReadOnly Property MaxOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return Integer.MaxValue
            End Get
        End Property

        Public ReadOnly Property MinOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 2
            End Get
        End Property

#End Region
#Region "ICustomFunctionDisplayAttributes"
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Match"
            End Get
        End Property

        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return Nothing
            End Get
        End Property

#End Region
#Region "ICustomFunctionOperator Members"
        Private ReadOnly splitSymbols As String() = New String() {",", ";"}

        Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
            If operands IsNot Nothing AndAlso operands.Length > 1 AndAlso operands(0) IsNot Nothing Then
                Dim sourceParts = operands(0).ToString().Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries).[Select](Function(x) x.Trim())
                Dim sourceTags = New HashSet(Of String)(sourceParts, StringComparer.OrdinalIgnoreCase)
                For Each tag As String In operands.Skip(1)
                    If sourceTags.Contains(tag) Then Return True
                Next
            End If

            Return False
        End Function

        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property

        Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
#End Region
    End Class
End Namespace
