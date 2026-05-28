using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.XtraTreeList.Demos {
    public partial class BusinessObjectBinding : TutorialControl {
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override TreeList MainControl {
            get { return treeList1; }
        }
        private TreeList treeList1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;

        public BusinessObjectBinding() {
            InitializeComponent();
            InitEditors();
            InitData();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "BusinessObjectBinding", "BusinessObject" }; } }
        protected override string WhatsThisXMLFileName { get { return "BusinessObjectBinding"; } }
        private void InitEditors() {
            repositoryItemImageComboBox1.Items.AddEnum(typeof(Priority));
            repositoryItemImageComboBox1.Items[0].ImageIndex = 0;
            repositoryItemImageComboBox1.Items[1].ImageIndex = 1;
            repositoryItemImageComboBox1.Items[2].ImageIndex = 2;
        }

        //<treeList1>
        private void InitData() {
            Projects projects = new Projects();
            projects.Add(new Project("Project: Betaron", "", new DateTime(2011, 05, 01), new DateTime(2011, 09, 20), Priority.Normal, false));
            projects.Add(new Project("Project: Stanton", "", new DateTime(2011, 03, 04), new DateTime(2011, 05, 01), Priority.Normal, false));
            projects[0].Projects.Add(new Project("Planning", "", new DateTime(2011, 05, 12), new DateTime(2011, 06, 15), Priority.Normal, false));
            projects[0].Projects.Add(new Project("Design", "", new DateTime(2011, 07, 16), new DateTime(2011, 09, 20), Priority.Normal, false));
            projects[0].Projects.Add(new Project("Development", "", new DateTime(2011, 07, 16), new DateTime(2011, 08, 20), Priority.Normal, false));
            projects[0].Projects.Add(new Project("Testing and Delivery", "", new DateTime(2011, 08, 12), new DateTime(2011, 10, 17), Priority.Normal, false));
            projects[0].Projects[0].Projects.Add(new Project("Market research", "", new DateTime(2011, 05, 01), new DateTime(2011, 05, 13), Priority.Normal, true));
            projects[0].Projects[0].Projects.Add(new Project("Making specification", "", new DateTime(2011, 05, 14), new DateTime(2011, 06, 04), Priority.Low, true));
            projects[0].Projects[0].Projects.Add(new Project("Documentation", "", new DateTime(2011, 06, 05), new DateTime(2011, 06, 15), Priority.Normal, true));
            projects[0].Projects[1].Projects.Add(new Project("Design of a web pages", "", new DateTime(2011, 07, 16), new DateTime(2011, 07, 28), Priority.Low, true));
            projects[0].Projects[1].Projects.Add(new Project("Pages layout", "", new DateTime(2011, 08, 01), new DateTime(2011, 09, 20), Priority.Normal, true));
            projects[0].Projects[2].Projects.Add(new Project("Design", "", new DateTime(2011, 07, 16), new DateTime(2011, 07, 28), Priority.Low, true));
            projects[0].Projects[2].Projects.Add(new Project("Coding", "", new DateTime(2011, 08, 01), new DateTime(2011, 09, 20), Priority.Normal, true));
            projects[0].Projects[3].Projects.Add(new Project("Testing", "", new DateTime(2011, 08, 12), new DateTime(2011, 08, 28), Priority.Low, true));
            projects[0].Projects[3].Projects.Add(new Project("Content", "", new DateTime(2011, 09, 1), new DateTime(2011, 09, 24), Priority.Normal, true));

            projects[1].Projects.Add(new Project("Planning", "", new DateTime(2012, 03, 01), new DateTime(2012, 04, 15), Priority.Normal, true));
            projects[1].Projects.Add(new Project("Design", "", new DateTime(2012, 04, 12), new DateTime(2012, 05, 12), Priority.Low, true));
            projects[1].Projects.Add(new Project("Development", "", new DateTime(2012, 05, 16), new DateTime(2012, 05, 23), Priority.Low, true));
            projects[1].Projects.Add(new Project("Testing and Delivery", "", new DateTime(2012, 06, 16), new DateTime(2012, 06, 25), Priority.Low, true));
            projects[1].Projects[0].Projects.Add(new Project("Market research", "", new DateTime(2012, 05, 01), new DateTime(2012, 05, 13), Priority.Normal, true));
            projects[1].Projects[0].Projects.Add(new Project("Making specification", "", new DateTime(2012, 05, 14), new DateTime(2012, 06, 04), Priority.Low, true));
            projects[1].Projects[0].Projects.Add(new Project("Documentation", "", new DateTime(2012, 06, 05), new DateTime(2012, 06, 15), Priority.Normal, true));
            projects[1].Projects[1].Projects.Add(new Project("Design of a web pages", "", new DateTime(2012, 07, 16), new DateTime(2012, 07, 28), Priority.Low, true));
            projects[1].Projects[1].Projects.Add(new Project("Pages layout", "", new DateTime(2012, 08, 01), new DateTime(2012, 09, 20), Priority.Normal, true));
            projects[1].Projects[2].Projects.Add(new Project("Design", "", new DateTime(2012, 07, 16), new DateTime(2012, 07, 28), Priority.Low, true));
            projects[1].Projects[2].Projects.Add(new Project("Coding", "", new DateTime(2012, 08, 01), new DateTime(2012, 09, 20), Priority.Normal, true));
            projects[1].Projects[3].Projects.Add(new Project("Testing", "", new DateTime(2012, 08, 12), new DateTime(2012, 08, 28), Priority.Low, true));
            projects[1].Projects[3].Projects.Add(new Project("Content", "", new DateTime(2012, 09, 1), new DateTime(2012, 09, 24), Priority.Normal, true));

            treeList1.DataSource = projects;
        }
        //</treeList1>
        void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessObjectBinding));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.propertyGridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(792, 406);
            this.splitContainerControl1.SplitterPosition = 560;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemImageComboBox1,
            this.repositoryItemProgressBar1});
            this.treeList1.Size = new System.Drawing.Size(560, 406);
            this.treeList1.StateImageList = this.imageCollection1;
            this.treeList1.TabIndex = 0;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            this.treeList1.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterExpand);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 33;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "StartDate";
            this.treeListColumn3.ColumnEdit = this.repositoryItemDateEdit1;
            this.treeListColumn3.FieldName = "StartDate";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "EndDate";
            this.treeListColumn4.ColumnEdit = this.repositoryItemDateEdit2;
            this.treeListColumn4.FieldName = "EndDate";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Priority";
            this.treeListColumn5.ColumnEdit = this.repositoryItemImageComboBox1;
            this.treeListColumn5.FieldName = "Priority";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 3;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowFocused = false;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection2;
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(0, "Normal1.png");
            this.imageCollection2.Images.SetKeyName(1, "Low1.png");
            this.imageCollection2.Images.SetKeyName(2, "High1.png");
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Object_Project.png");
            this.imageCollection1.Images.SetKeyName(1, "Object_Task.png");
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.DefaultEditors.AddRange(new DevExpress.XtraVerticalGrid.Rows.DefaultEditor[] {
            new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(bool), this.repositoryItemCheckEdit1),
            new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(System.DateTime), this.repositoryItemDateEdit3)});
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort;
            this.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl1.OptionsView.ShowRootCategories = false;
            this.propertyGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit3});
            this.propertyGridControl1.Size = new System.Drawing.Size(222, 406);
            this.propertyGridControl1.TabIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // BusinessObjectBinding
            // 
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "BusinessObjectBinding";
            this.Size = new System.Drawing.Size(792, 406);
            this.Load += new System.EventHandler(this.businessObjectBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            this.ResumeLayout(false);

        }
        //<propertyGridControl1>
        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            propertyGridControl1.SelectedObject = treeList1.GetDataRecordByNode(e.Node);
        }
        //</propertyGridControl1>
        private void businessObjectBinding_Load(object sender, EventArgs e) {
            treeList1.ForceInitialize();
            treeList1.ExpandAll();
            treeList1.FocusedNode = treeList1.Nodes.FirstNode;
            treeList1.BestFitColumns();
        }
        private void treeList1_CellValueChanged(object sender, CellValueChangedEventArgs e) {
            propertyGridControl1.Refresh();
        }
        private void treeList1_AfterExpand(object sender, NodeEventArgs e) {
            treeList1.BestFitColumns();
        }
        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e) {
            Project project = (Project)treeList1.GetDataRecordByNode(e.Node);
            if(project == null) return;
            e.NodeImageIndex = project.IsTask ? 1 : 0;
        }
    }
}
