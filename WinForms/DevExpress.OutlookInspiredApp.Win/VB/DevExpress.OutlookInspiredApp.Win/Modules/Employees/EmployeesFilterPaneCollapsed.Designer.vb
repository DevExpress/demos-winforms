Namespace DevExpress.DevAV.Modules

    Partial Class EmployeesFilterPaneCollapsed

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.navigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
            Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
            Me.navigationContainer = New DevExpress.XtraEditors.XtraUserControl()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationBar), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationContainer.SuspendLayout()
            Me.SuspendLayout()
            Me.navigationBar.AnimateItemPressing = False
            Me.navigationBar.AutoSize = False
            Me.navigationBar.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden
            Me.navigationBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.navigationBar.Location = New System.Drawing.Point(0, 28)
            Me.navigationBar.MaximumSize = New System.Drawing.Size(50, 0)
            Me.navigationBar.Name = "navigationBar"
            Me.navigationBar.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.navigationBar.ShowPeekFormOnItemHover = False
            Me.navigationBar.Size = New System.Drawing.Size(50, 572)
            Me.navigationBar.TabIndex = 2
            Me.navigationBar.ViewMode = DevExpress.XtraBars.Navigation.OfficeNavigationBarViewMode.Skinned
            Me.btnNew.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNew.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_new_employee_16
            Me.btnNew.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnNew.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16"
            Me.btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnNew.Location = New System.Drawing.Point(0, 0)
            Me.btnNew.MaximumSize = New System.Drawing.Size(50, 28)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(50, 28)
            Me.btnNew.TabIndex = 0
            Me.btnNew.Visible = False
            Me.navigationContainer.Controls.Add(Me.navigationBar)
            Me.navigationContainer.Controls.Add(Me.btnNew)
            Me.navigationContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationContainer.Location = New System.Drawing.Point(0, 0)
            Me.navigationContainer.Name = "navigationContainer"
            Me.navigationContainer.Size = New System.Drawing.Size(60, 600)
            Me.navigationContainer.TabIndex = 3
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.navigationContainer)
            Me.Name = "EmployeesFilterPaneCollapsed"
            Me.Size = New System.Drawing.Size(60, 600)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationBar), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationContainer.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private btnNew As DevExpress.XtraEditors.SimpleButton

        Private navigationBar As DevExpress.XtraBars.Navigation.OfficeNavigationBar

        Private navigationContainer As DevExpress.XtraEditors.XtraUserControl
    End Class
End Namespace
