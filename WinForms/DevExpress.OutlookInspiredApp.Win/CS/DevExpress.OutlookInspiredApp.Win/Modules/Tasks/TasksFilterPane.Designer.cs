namespace DevExpress.DevAV.Modules {
    partial class TasksFilterPane {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnNewTask = new DevExpress.XtraEditors.SimpleButton();
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnNewTaskLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTaskLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.btnNewTask.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnNewTask.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewTasks.svg?Size=16x16";
            this.btnNewTask.Location = new System.Drawing.Point(14, 14);
            this.btnNewTask.MaximumSize = new System.Drawing.Size(150, 0);
            this.btnNewTask.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(150, 22);
            this.btnNewTask.StyleController = this.moduleLayout;
            this.btnNewTask.TabIndex = 0;
            this.btnNewTask.Text = "New Task";
            
            
            
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.accordionControl);
            this.moduleLayout.Controls.Add(this.btnNewTask);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(200, 603);
            this.moduleLayout.TabIndex = 2;
            
            
            
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.btnNewTaskLayoutControlItem,
            this.accordionLayoutControlItem});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 6;
            this.Root.Size = new System.Drawing.Size(200, 603);
            
            
            
            this.btnNewTaskLayoutControlItem.Control = this.btnNewTask;
            this.btnNewTaskLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTaskLayoutControlItem.CustomizationFormText = "btnNewTaskLayoutControlItem";
            this.btnNewTaskLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.btnNewTaskLayoutControlItem.Name = "btnNewTaskLayoutControlItem";
            this.btnNewTaskLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16);
            this.btnNewTaskLayoutControlItem.Size = new System.Drawing.Size(180, 42);
            this.btnNewTaskLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.btnNewTaskLayoutControlItem.TextVisible = false;
            this.btnNewTaskLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            
            
            
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.ExpandGroupOnHeaderClick = false;
            this.accordionControl.Location = new System.Drawing.Point(16, 64);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(168, 523);
            this.accordionControl.StyleController = this.moduleLayout;
            this.accordionControl.TabIndex = 4;
            
            
            
            this.accordionLayoutControlItem.Control = this.accordionControl;
            this.accordionLayoutControlItem.Location = new System.Drawing.Point(0, 48);
            this.accordionLayoutControlItem.Name = "accordionLayoutControlItem";
            this.accordionLayoutControlItem.Size = new System.Drawing.Size(174, 529);
            this.accordionLayoutControlItem.TextVisible = false;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "TasksFilterPane";
            this.Size = new System.Drawing.Size(200, 603);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTaskLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewTask;
        private XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem btnNewTaskLayoutControlItem;
        private XtraBars.Navigation.AccordionControl accordionControl;
        private XtraLayout.LayoutControlItem accordionLayoutControlItem;
    }
}
