using System;
using DevExpress.Diagram.Core;
using DevExpress.Utils;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DocumentModuleBase : DiagramTutorialControl {
        public DocumentModuleBase() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var document = this.DocumentName;
            if(!string.IsNullOrEmpty(document))
                LoadDocument(document);
            this.diagramControl.SizeChanged += OnSizeChangedHandler;
            diagramControl.OptionsView.PropertiesPanelVisibility = PropertiesPanelVisibility.Collapsed;
        }
        protected virtual string DocumentName { get { return string.Empty; } }
        void OnSizeChangedHandler(object sender, EventArgs e) {
            var diagramControl = (DiagramControl)sender;
            diagramControl.SizeChanged -= OnSizeChangedHandler;
            diagramControl.FitToWidth();
            diagramControl.AlignCanvas(HorzAlignment.Center, VertAlignment.Top);
        }
    }
}
