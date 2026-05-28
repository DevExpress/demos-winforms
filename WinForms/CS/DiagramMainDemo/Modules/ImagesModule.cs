namespace DevExpress.XtraDiagram.Demos {
    public partial class ImagesModule : DocumentModuleBase {
        public ImagesModule() {
            InitializeComponent();
            this.diagramControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DiagramControl_MouseClick);//VB
        }
        protected override string DocumentName { get { return "Images.xml"; } }

        void DiagramControl_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            var imageItem = diagramControl.CalcHitItem(new System.Drawing.PointF(e.X, e.Y)) as DiagramImage;
            if(imageItem == null || !object.Equals(imageItem.Tag, typeof(DiagramImage).Name))
                return;
            diagramControl.SelectItem(imageItem);
            diagramControl.LoadImage();
        }
    }
}
