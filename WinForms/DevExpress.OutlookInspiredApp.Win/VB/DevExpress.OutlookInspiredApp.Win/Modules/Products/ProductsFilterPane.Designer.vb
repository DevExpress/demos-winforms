Namespace DevExpress.DevAV.Modules

    Partial Class ProductsFilterPane

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
            Me.btnNewProduct = New DevExpress.XtraEditors.SimpleButton()
            Me.accordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.navigationContainer = New DevExpress.XtraEditors.XtraUserControl()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationContainer.SuspendLayout()
            Me.SuspendLayout()
            Me.btnNewProduct.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNewProduct.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnNewProduct.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewProduct.svg?Size=16x16"
            Me.btnNewProduct.Location = New System.Drawing.Point(0, 0)
            Me.btnNewProduct.MaximumSize = New System.Drawing.Size(160, 28)
            Me.btnNewProduct.Name = "btnNewProduct"
            Me.btnNewProduct.Size = New System.Drawing.Size(160, 28)
            Me.btnNewProduct.TabIndex = 0
            Me.btnNewProduct.Text = "New Product"
            Me.btnNewProduct.Visible = False
            Me.accordionControl.AllowItemSelection = True
            Me.accordionControl.Appearance.Item.Normal.Options.UseTextOptions = True
            Me.accordionControl.Appearance.Item.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            Me.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl.ExpandGroupOnHeaderClick = False
            Me.accordionControl.Location = New System.Drawing.Point(0, 28)
            Me.accordionControl.Name = "accordionControl"
            Me.accordionControl.Size = New System.Drawing.Size(200, 672)
            Me.accordionControl.TabIndex = 4
            Me.navigationContainer.Controls.Add(Me.accordionControl)
            Me.navigationContainer.Controls.Add(Me.btnNewProduct)
            Me.navigationContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationContainer.Location = New System.Drawing.Point(0, 0)
            Me.navigationContainer.Name = "navigationContainer"
            Me.navigationContainer.Size = New System.Drawing.Size(200, 700)
            Me.navigationContainer.TabIndex = 5
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.navigationContainer)
            Me.Name = "ProductsFilterPane"
            Me.Size = New System.Drawing.Size(200, 700)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationContainer.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private btnNewProduct As DevExpress.XtraEditors.SimpleButton

        Private accordionControl As DevExpress.XtraBars.Navigation.AccordionControl

        Private navigationContainer As DevExpress.XtraEditors.XtraUserControl
    End Class
End Namespace
