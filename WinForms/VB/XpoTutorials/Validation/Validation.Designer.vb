Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class Validation
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Validation))
            Me.xpContacts = New DevExpress.Xpo.XPCollection()
            Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.bSave = New DevExpress.XtraEditors.SimpleButton()
            Me.sbRemoveContact = New DevExpress.XtraEditors.SimpleButton()
            Me.icButtonImages = New DevExpress.Utils.ImageCollection(Me.components)
            Me.sbAddContact = New DevExpress.XtraEditors.SimpleButton()
            Me.dxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.xpContacts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.icButtonImages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xpContacts
            ' 
            Me.xpContacts.DisplayableProperties = "This;Oid;FirstName;LastName;Address;PhoneNumber;Email"
            Me.xpContacts.ObjectType = GetType(DevExpress.Xpo.Demos.Contact)
            Me.xpContacts.Session = Me.unitOfWork1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 48)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(563, 218)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.bSave)
            Me.panelControl1.Controls.Add(Me.sbRemoveContact)
            Me.panelControl1.Controls.Add(Me.sbAddContact)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(563, 40)
            Me.panelControl1.TabIndex = 2
            ' 
            ' bSave
            ' 
            Me.bSave.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.bSave.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.bSave.Image = (CType(resources.GetObject("bSave.Image"), System.Drawing.Image))
            Me.bSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.bSave.Location = New System.Drawing.Point(523, 8)
            Me.bSave.Name = "bSave"
            Me.bSave.Size = New System.Drawing.Size(32, 23)
            Me.bSave.TabIndex = 11
            Me.bSave.ToolTip = "Save Changes to Database"
            '			Me.bSave.Click += New System.EventHandler(Me.bSave_Click);
            ' 
            ' sbRemoveContact
            ' 
            Me.sbRemoveContact.ImageIndex = 1
            Me.sbRemoveContact.ImageList = Me.icButtonImages
            Me.sbRemoveContact.Location = New System.Drawing.Point(120, 8)
            Me.sbRemoveContact.Name = "sbRemoveContact"
            Me.sbRemoveContact.Size = New System.Drawing.Size(120, 23)
            Me.sbRemoveContact.TabIndex = 1
            Me.sbRemoveContact.Text = "Remove Contact"
            '			Me.sbRemoveContact.Click += New System.EventHandler(Me.sbRemoveContact_Click);
            ' 
            ' icButtonImages
            ' 
            Me.icButtonImages.ImageStream = (CType(resources.GetObject("icButtonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' sbAddContact
            ' 
            Me.sbAddContact.ImageIndex = 0
            Me.sbAddContact.ImageList = Me.icButtonImages
            Me.sbAddContact.Location = New System.Drawing.Point(8, 8)
            Me.sbAddContact.Name = "sbAddContact"
            Me.sbAddContact.Size = New System.Drawing.Size(104, 23)
            Me.sbAddContact.TabIndex = 0
            Me.sbAddContact.Text = "Add Contact"
            '			Me.sbAddContact.Click += New System.EventHandler(Me.sbAddContact_Click);
            ' 
            ' dxErrorProvider
            ' 
            Me.dxErrorProvider.ContainerControl = Me
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 40)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(563, 8)
            Me.panelControl2.TabIndex = 5
            ' 
            ' Validation
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Validation"
            Me.Size = New System.Drawing.Size(563, 266)
            '			Me.Load += New System.EventHandler(Me.Validation_Load);
            CType(Me.xpContacts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.icButtonImages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private xpContacts As DevExpress.Xpo.XPCollection
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private dxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
        Private WithEvents sbAddContact As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbRemoveContact As DevExpress.XtraEditors.SimpleButton
        Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
        Private WithEvents bSave As DevExpress.XtraEditors.SimpleButton
        Private icButtonImages As DevExpress.Utils.ImageCollection
        Private components As System.ComponentModel.IContainer
        Private panelControl2 As DevExpress.XtraEditors.PanelControl

    End Class
End Namespace
