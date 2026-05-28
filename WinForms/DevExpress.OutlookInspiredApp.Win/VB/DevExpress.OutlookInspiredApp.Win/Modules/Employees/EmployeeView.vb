Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Utils.Svg
Imports System.ComponentModel
Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeeView
        Inherits BaseModuleControl

        Private svgYes As SvgImage

        Private svgNo As SvgImage

        Private priorityImages As IDictionary(Of EmployeeTaskPriority, SvgImage)

        Public Sub New()
            MyBase.New(GetType(SynchronizedEmployeeViewModel))
            InitializeComponent()
            gvTasks.SetViewFontSize(2, 1)
            gvEvaluations.SetViewFontSize(2, 1)
            BindCommands()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            AddHandler tvEvaluations.ItemCustomize, AddressOf tvEvaluations_ItemCustomize
            AddHandler tvTasks.ItemCustomize, AddressOf tvTasks_ItemCustomize
            AddHandler gcTasks.SizeChanged, Sub(s, e)
                If gcTasks.MainView Is tvTasks Then tvTasks.RefreshData()
            End Sub
            Dim asm = GetType(MainForm).Assembly
            svgYes = SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.EvaluationYes.svg"), asm)
            svgNo = SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.EvaluationNo.svg"), asm)
            priorityImages = CreateTaskPriorityImages(LookAndFeel, "DevExpress.DevAV.Resources.Tasks.")
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler tvTasks.ItemCustomize, AddressOf tvTasks_ItemCustomize
            RemoveHandler tvEvaluations.ItemCustomize, AddressOf tvEvaluations_ItemCustomize
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As EmployeeViewModel
            Get
                Return GetViewModel(Of EmployeeViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
        End Sub

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            QueueUIUpdate()
        End Sub

        Protected Overrides Sub OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            If ViewModel IsNot Nothing Then UpdateUI(ViewModel.Entity)
        End Sub

        Private scaleFactor As SizeF

        Protected Overrides Sub ScaleControl(ByVal factor As SizeF, ByVal specified As BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            scaleFactor = factor
        End Sub

        Private Sub BindCommands()
            Dim fluent = mvvmContext.OfType(Of EmployeeViewModel)()
            fluent.BindCommand(ContactButton(0), Sub(x) x.Contacts.Message())
            fluent.BindCommand(ContactButton(1), Sub(x) x.Contacts.Phone())
            fluent.BindCommand(ContactButton(2), Sub(x) x.Contacts.VideoCall())
            fluent.BindCommand(ContactButton(3), Sub(x) x.Contacts.MailTo())
        End Sub

        Private Function ContactButton(ByVal index As Integer) As WindowsUIButton
            Return CType(buttonPanel.Buttons(index), WindowsUIButton)
        End Function

        Private Sub UpdateUI(ByVal employee As Employee)
            If employee IsNot Nothing Then
                If Not Equals(bindingSource.DataSource, employee) Then
                    bindingSource.DataSource = employee
                Else
                    employee.ResetBindable()
                    bindingSource.ResetBindings(False)
                End If

                tvTasks.FocusedRowHandle = XtraGrid.GridControl.InvalidRowHandle
                tvEvaluations.FocusedRowHandle = XtraGrid.GridControl.InvalidRowHandle
                gcTasks.DataSource = employee.AssignedTasks
                gcEvaluations.DataSource = employee.Evaluations
            Else
                gcTasks.DataSource = Nothing
                gcEvaluations.DataSource = Nothing
            End If

            moduleLayout.Visible = employee IsNot Nothing
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
