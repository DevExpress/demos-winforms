namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class AddNewBonus {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.beExpression = new DevExpress.XtraEditors.ButtonEdit();
            this.teBonusName = new DevExpress.XtraEditors.TextEdit();
            this.labelInternalExpression = new DevExpress.XtraEditors.LabelControl();
            this.labelBonusName = new DevExpress.XtraEditors.LabelControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beExpression.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBonusName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(12, 109);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(253, 109);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.beExpression);
            this.panelControl1.Controls.Add(this.teBonusName);
            this.panelControl1.Controls.Add(this.labelInternalExpression);
            this.panelControl1.Controls.Add(this.labelBonusName);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(315, 82);
            this.panelControl1.TabIndex = 0;
            // 
            // beExpression
            // 
            this.beExpression.Enabled = false;
            this.beExpression.Location = new System.Drawing.Point(121, 47);
            this.beExpression.Name = "beExpression";
            this.beExpression.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beExpression.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beExpression.Size = new System.Drawing.Size(174, 20);
            this.beExpression.TabIndex = 18;
            this.beExpression.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beExpression_ButtonClick);
            // 
            // teBonusName
            // 
            this.teBonusName.EditValue = "";
            this.teBonusName.Location = new System.Drawing.Point(121, 12);
            this.teBonusName.Name = "teBonusName";
            this.teBonusName.Size = new System.Drawing.Size(174, 20);
            this.teBonusName.TabIndex = 17;
            this.teBonusName.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teBonusName_EditValueChanging);
            // 
            // labelInternalExpression
            // 
            this.labelInternalExpression.Location = new System.Drawing.Point(17, 50);
            this.labelInternalExpression.Margin = new System.Windows.Forms.Padding(4);
            this.labelInternalExpression.Name = "labelInternalExpression";
            this.labelInternalExpression.Size = new System.Drawing.Size(97, 13);
            this.labelInternalExpression.TabIndex = 16;
            this.labelInternalExpression.Text = "Internal Expression:";
            // 
            // labelBonusName
            // 
            this.labelBonusName.Location = new System.Drawing.Point(51, 15);
            this.labelBonusName.Margin = new System.Windows.Forms.Padding(4);
            this.labelBonusName.Name = "labelBonusName";
            this.labelBonusName.Size = new System.Drawing.Size(63, 13);
            this.labelBonusName.TabIndex = 15;
            this.labelBonusName.Text = "Bonus Name:";
            // 
            // toolTipController1
            // 
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.RightCenter;
            // 
            // AddNewBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(340, 142);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewBonus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beExpression.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBonusName.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton buttonOK;
		private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.LabelControl labelInternalExpression;
        private DevExpress.XtraEditors.LabelControl labelBonusName;
        private DevExpress.XtraEditors.TextEdit teBonusName;
        private DevExpress.XtraEditors.ButtonEdit beExpression;
	}
}
