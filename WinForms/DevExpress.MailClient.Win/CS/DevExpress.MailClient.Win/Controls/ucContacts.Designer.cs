namespace DevExpress.MailClient.Win.Controls {
    partial class ucContacts {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContacts));
            this.ceList = new DevExpress.XtraEditors.CheckEdit();
            this.ceAlphabetical = new DevExpress.XtraEditors.CheckEdit();
            this.ceState = new DevExpress.XtraEditors.CheckEdit();
            this.ceCards = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pcCheckControls = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ceList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAlphabetical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCards.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckControls)).BeginInit();
            this.pcCheckControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // ceList
            // 
            resources.ApplyResources(this.ceList, "ceList");
            this.ceList.Name = "ceList";
            this.ceList.Properties.AccessibleDescription = resources.GetString("ceList.Properties.AccessibleDescription");
            this.ceList.Properties.AccessibleName = resources.GetString("ceList.Properties.AccessibleName");
            this.ceList.Properties.AutoHeight = ((bool)(resources.GetObject("ceList.Properties.AutoHeight")));
            this.ceList.Properties.AutoWidth = true;
            this.ceList.Properties.Caption = resources.GetString("ceList.Properties.Caption");
            this.ceList.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceList.Properties.DisplayValueChecked = resources.GetString("ceList.Properties.DisplayValueChecked");
            this.ceList.Properties.DisplayValueGrayed = resources.GetString("ceList.Properties.DisplayValueGrayed");
            this.ceList.Properties.DisplayValueUnchecked = resources.GetString("ceList.Properties.DisplayValueUnchecked");
            this.ceList.Properties.RadioGroupIndex = 0;
            this.ceList.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // ceAlphabetical
            // 
            resources.ApplyResources(this.ceAlphabetical, "ceAlphabetical");
            this.ceAlphabetical.Name = "ceAlphabetical";
            this.ceAlphabetical.Properties.AccessibleDescription = resources.GetString("ceAlphabetical.Properties.AccessibleDescription");
            this.ceAlphabetical.Properties.AccessibleName = resources.GetString("ceAlphabetical.Properties.AccessibleName");
            this.ceAlphabetical.Properties.AutoHeight = ((bool)(resources.GetObject("ceAlphabetical.Properties.AutoHeight")));
            this.ceAlphabetical.Properties.AutoWidth = true;
            this.ceAlphabetical.Properties.Caption = resources.GetString("ceAlphabetical.Properties.Caption");
            this.ceAlphabetical.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceAlphabetical.Properties.DisplayValueChecked = resources.GetString("ceAlphabetical.Properties.DisplayValueChecked");
            this.ceAlphabetical.Properties.DisplayValueGrayed = resources.GetString("ceAlphabetical.Properties.DisplayValueGrayed");
            this.ceAlphabetical.Properties.DisplayValueUnchecked = resources.GetString("ceAlphabetical.Properties.DisplayValueUnchecked");
            this.ceAlphabetical.Properties.RadioGroupIndex = 0;
            this.ceAlphabetical.TabStop = false;
            this.ceAlphabetical.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // ceState
            // 
            resources.ApplyResources(this.ceState, "ceState");
            this.ceState.Name = "ceState";
            this.ceState.Properties.AccessibleDescription = resources.GetString("ceState.Properties.AccessibleDescription");
            this.ceState.Properties.AccessibleName = resources.GetString("ceState.Properties.AccessibleName");
            this.ceState.Properties.AutoHeight = ((bool)(resources.GetObject("ceState.Properties.AutoHeight")));
            this.ceState.Properties.AutoWidth = true;
            this.ceState.Properties.Caption = resources.GetString("ceState.Properties.Caption");
            this.ceState.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceState.Properties.DisplayValueChecked = resources.GetString("ceState.Properties.DisplayValueChecked");
            this.ceState.Properties.DisplayValueGrayed = resources.GetString("ceState.Properties.DisplayValueGrayed");
            this.ceState.Properties.DisplayValueUnchecked = resources.GetString("ceState.Properties.DisplayValueUnchecked");
            this.ceState.Properties.RadioGroupIndex = 0;
            this.ceState.TabStop = false;
            this.ceState.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // ceCards
            // 
            resources.ApplyResources(this.ceCards, "ceCards");
            this.ceCards.Name = "ceCards";
            this.ceCards.Properties.AccessibleDescription = resources.GetString("ceCards.Properties.AccessibleDescription");
            this.ceCards.Properties.AccessibleName = resources.GetString("ceCards.Properties.AccessibleName");
            this.ceCards.Properties.AutoHeight = ((bool)(resources.GetObject("ceCards.Properties.AutoHeight")));
            this.ceCards.Properties.AutoWidth = true;
            this.ceCards.Properties.Caption = resources.GetString("ceCards.Properties.Caption");
            this.ceCards.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceCards.Properties.DisplayValueChecked = resources.GetString("ceCards.Properties.DisplayValueChecked");
            this.ceCards.Properties.DisplayValueGrayed = resources.GetString("ceCards.Properties.DisplayValueGrayed");
            this.ceCards.Properties.DisplayValueUnchecked = resources.GetString("ceCards.Properties.DisplayValueUnchecked");
            this.ceCards.Properties.RadioGroupIndex = 0;
            this.ceCards.TabStop = false;
            this.ceCards.CheckedChanged += new System.EventHandler(this.ce_CheckedChanged);
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.LineVisible = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // pcCheckControls
            // 
            resources.ApplyResources(this.pcCheckControls, "pcCheckControls");
            this.pcCheckControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcCheckControls.Controls.Add(this.ceList);
            this.pcCheckControls.Controls.Add(this.labelControl1);
            this.pcCheckControls.Controls.Add(this.ceAlphabetical);
            this.pcCheckControls.Controls.Add(this.ceCards);
            this.pcCheckControls.Controls.Add(this.ceState);
            this.pcCheckControls.Name = "pcCheckControls";
            // 
            // ucContacts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcCheckControls);
            this.Name = "ucContacts";
            this.Resize += new System.EventHandler(this.ucContacts_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ceList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAlphabetical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCards.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckControls)).EndInit();
            this.pcCheckControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit ceList;
        private DevExpress.XtraEditors.CheckEdit ceAlphabetical;
        private DevExpress.XtraEditors.CheckEdit ceState;
        private DevExpress.XtraEditors.CheckEdit ceCards;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private XtraEditors.PanelControl pcCheckControls;
    }
}
