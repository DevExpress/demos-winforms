Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraLayout.Utils
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Modules

    Public Partial Class TaskView
        Inherits BaseModuleControl

        Private svgYes As SvgImage

        Private svgNo As SvgImage

        Private priorityImages As IDictionary(Of EmployeeTaskPriority, SvgImage)

        Public Sub New()
            MyBase.New(GetType(SynchronizedTaskViewModel))
            InitializeComponent()
            gvTasks.SetViewFontSize(2, 1)
            gvEvaluations.SetViewFontSize(2, 1)
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            AddHandler officeTabFilter.SelectedItemChanged, AddressOf OfficeTabFilter_SelectedItemChanged
            AddHandler tvEvaluations.ItemCustomize, AddressOf tvEvaluations_ItemCustomize
            AddHandler tvTasks.ItemCustomize, AddressOf tvTasks_ItemCustomize
            AddHandler gcTasks.SizeChanged, Sub(s, e)
                If gcTasks.MainView Is tvTasks Then tvTasks.RefreshData()
            End Sub
            Dim asm = GetType(MainForm).Assembly
            svgYes = SvgImage.FromResources("DevExpress.DevAV.Resources.EvaluationYes.svg", asm)
            svgNo = SvgImage.FromResources("DevExpress.DevAV.Resources.EvaluationNo.svg", asm)
            priorityImages = CreateTaskPriorityImages(LookAndFeel, "DevExpress.DevAV.Resources.Tasks.")
        End Sub

        Private Sub OfficeTabFilter_SelectedItemChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.NavigationBarItemEventArgs)
            Dim showTasks As Boolean = e.Item Is navigationItemTasks
            lciTasks.Visibility = If(showTasks, LayoutVisibility.Always, LayoutVisibility.Never)
            lciEvaluations.Visibility = If(Not showTasks, LayoutVisibility.Always, LayoutVisibility.Never)
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler tvTasks.ItemCustomize, AddressOf tvTasks_ItemCustomize
            RemoveHandler tvEvaluations.ItemCustomize, AddressOf tvEvaluations_ItemCustomize
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As TaskViewModel
            Get
                Return GetViewModel(Of TaskViewModel)()
            End Get
        End Property

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            QueueUIUpdate()
        End Sub

        Protected Overrides Sub OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UpdateUI(ViewModel.Entity)
        End Sub

        Private scaleFactor As SizeF

        Protected Overrides Sub ScaleControl(ByVal factor As SizeF, ByVal specified As BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            scaleFactor = factor
        End Sub

        Private Function ContactButton(ByVal index As Integer) As WindowsUIButton
            Return CType(buttonPanel.Buttons(index), WindowsUIButton)
        End Function

        Private Sub UpdateUI(ByVal employee As EmployeeTask)
            If employee IsNot Nothing Then
                If Not Equals(bindingSource.DataSource, employee) Then
                    bindingSource.DataSource = employee.AssignedEmployee
                Else
                    bindingSource.ResetBindings(False)
                End If

                tvTasks.FocusedRowHandle = XtraGrid.GridControl.InvalidRowHandle
                tvEvaluations.FocusedRowHandle = XtraGrid.GridControl.InvalidRowHandle
                gcTasks.DataSource = employee.AssignedEmployee.AssignedTasks
                gcEvaluations.DataSource = employee.AssignedEmployee.Evaluations
            Else
                gcTasks.DataSource = Nothing
                gcEvaluations.DataSource = Nothing
            End If

            modueLayout.Visible = employee IsNot Nothing
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property IsHorizontalLayout As Boolean
            Get
                Return Not colDescription.Visible
            End Get

            Set(ByVal value As Boolean)
                gvEvaluations.OptionsView.ShowPreview = value
                gvTasks.OptionsView.ShowPreview = value
                colDescription.Visible = Not value
            End Set
        End Property

        Private Sub tvEvaluations_ItemCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs)
            Dim details As String = TryCast(tvEvaluations.GetRowCellValue(e.RowHandle, "Details"), String)
            Dim raiseImg = e.Item.GetElementByName("RaiseImage")
            Dim bonusImg = e.Item.GetElementByName("BonusImage")
            Dim hasRaise As Boolean = False
            Dim hasBonus As Boolean = False
            If Not String.IsNullOrEmpty(details) Then
                details = details.ToLower().Replace(" ", String.Empty)
                hasRaise = details.Contains("raise:yes")
                hasBonus = details.Contains("bonus:yes")
            End If

            raiseImg.ImageOptions.SvgImage = If(hasRaise, svgYes, svgNo)
            bonusImg.ImageOptions.SvgImage = If(hasBonus, svgYes, svgNo)
        End Sub

        Private Sub tvTasks_ItemCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs)
            Dim view = TryCast(sender, TileView)
            Dim progressBack = e.Item.GetElementByName("ProgressBack")
            Dim progressFront = e.Item.GetElementByName("ProgressFront")
            Dim priorityElement = e.Item.GetElementByName("PriorityImage")
            Dim rowPriority = CType(view.GetRowCellValue(e.RowHandle, view.Columns("Priority")), EmployeeTaskPriority)
            Dim completion As Integer = CInt(view.GetRowCellValue(e.RowHandle, view.Columns("Completion")))
            priorityElement.ImageOptions.SvgImage = priorityImages(rowPriority)
            progressBack.Width = CInt((view.GetViewInfo().GetItemSize().Width / CSng(scaleFactor.Width))) - view.OptionsTiles.ItemPadding.Horizontal
            progressFront.Width = CInt(progressBack.Width * (completion / 100.0F))
        End Sub
    End Class
End Namespace
