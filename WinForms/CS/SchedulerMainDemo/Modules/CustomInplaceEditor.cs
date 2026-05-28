using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Demos.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos {
    public partial class CustomInplaceEditorModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public CustomInplaceEditorModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        void CustomInplaceEditorModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
        void schedulerControl_InplaceEditorShowing(object sender, InplaceEditorEventArgs e) {
            MyInplaceEditorControl inplaceEditor = new MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs);
            inplaceEditor.SetMenuManager(this.schedulerControl.MenuManager);
            e.InplaceEditorEx = inplaceEditor;
        }
    }
    public class MyInplaceEditorControl : ISchedulerInplaceEditorEx {
        MyInplaceEditor _editor;
        Appointment _appointment;
        SchedulerControl control;
        public MyInplaceEditorControl(SchedulerInplaceEditorEventArgs inplaceEditorArgs) {
            this._appointment = inplaceEditorArgs.ViewInfo.Appointment;
            this.control = inplaceEditorArgs.Control;
            CreateEditor(inplaceEditorArgs);
        }

        event EventHandler ISchedulerInplaceEditorEx.CommitChanges {
            add { CommitChangesEvent += value; }
            remove { CommitChangesEvent -= value; }
        }

        event EventHandler ISchedulerInplaceEditorEx.RollbackChanges {
            add { RollbackChangesEvent += value; }
            remove { RollbackChangesEvent -= value; }
        }

        MyInplaceEditor Editor { get { return _editor; } }
        Appointment Appointment { get { return _appointment; } }
        SchedulerControl SchedulerControl { get { return control; } }

        event EventHandler CommitChangesEvent;
        event EventHandler RollbackChangesEvent;

        void CreateEditor(SchedulerInplaceEditorEventArgs inplaceEditorArgs) {
            this._editor = new MyInplaceEditor();
            Editor.Bounds = AdjustEditorBounds(inplaceEditorArgs.Control, inplaceEditorArgs.Bounds);
        }

        public void SetMenuManager(IDXMenuManager menuManager) {
            SetMenuManagerCore(Editor.Controls, menuManager);
        }
        void SetMenuManagerCore(Control.ControlCollection controls, IDXMenuManager menuManager) {
            int count = controls.Count;
            for (int i = 0; i < count; i++) {
                Control control = controls[i];
                SetMenuManagerCore(control.Controls, menuManager);
                BaseEdit baseEdit = control as BaseEdit;
                if (baseEdit == null)
                    continue;
                baseEdit.MenuManager = menuManager;
            }
        }
        Rectangle AdjustEditorBounds(SchedulerControl control, Rectangle editorBounds) {
            Rectangle screenControlBounds = control.Parent.RectangleToScreen(control.Bounds);
            editorBounds.Offset(0, -3);
            Rectangle screenEditorBounds = control.RectangleToScreen(editorBounds);

            Size preferredSize = _editor.GetPreferredSize(editorBounds.Size);
            int height = Math.Max(preferredSize.Height, editorBounds.Height);
            int width = preferredSize.Width;

            Rectangle rect = screenEditorBounds;
            rect.Offset(editorBounds.Width + 6, 0);

            int maxBottom = Math.Min(screenControlBounds.Bottom, rect.Top + height);
            int top = maxBottom - height;

            Rectangle result = new Rectangle(rect.Left, top, width, height);
            if (screenControlBounds.Right < rect.Right) {
                int horzOffset = control.ActiveView is DayView ? 12 : 8;
                result = new Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height);
            }
            return result;
        }
        void DisposeInplaceEditor() {
            DisposeInplaceEditor(true);
            GC.SuppressFinalize(this);
        }
        ~MyInplaceEditorControl() {
            DisposeInplaceEditor(false);
        }
        protected virtual void DisposeInplaceEditor(bool disposing) {
            if (disposing) {
                if (Editor != null) {
                    Editor.Dispose();
                    this._editor = null;
                }
                this._appointment = null;
            }
        }
        void ActivateInplaceEditor() {
            Editor.FillForm(control, _appointment);
            SubscribeEditorEvents();
            Editor.Show(SchedulerControl.FindForm());
        }
        void DeactivateInplaceEditor() {
            UnsibscribeEditorEvents();
            Editor.Close();
        }
        void ApplyChangesInplaceEditor() {
            Editor.ApplyChanges();
        }
        protected internal virtual void SubscribeEditorEvents() {
            Editor.FormClosed += new FormClosedEventHandler(Editor_FormClosed);
            Editor.Deactivate += new EventHandler(Editor_Deactivate);
            Editor.CommitChanges += new EventHandler(Editor_CommitChanges);
            Editor.RollbackChanges += new EventHandler(Editor_RollbackChanges);
        }

        protected internal virtual void UnsibscribeEditorEvents() {
            Editor.FormClosed -= new FormClosedEventHandler(Editor_FormClosed);
            Editor.Deactivate -= new EventHandler(Editor_Deactivate);
            Editor.CommitChanges -= new EventHandler(Editor_CommitChanges);
            Editor.RollbackChanges -= new EventHandler(Editor_RollbackChanges);
        }
        void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            OnCommitChanges();
        }

        void Editor_Deactivate(object sender, EventArgs e) {
            OnCommitChanges();
        }


        void Editor_RollbackChanges(object sender, EventArgs e) {
            OnRollbackChanges();
        }

        void Editor_CommitChanges(object sender, EventArgs e) {
            OnCommitChanges();
        }
        protected internal virtual void TextBox_LostFocus(object sender, EventArgs e) {
            Editor.Close();
            OnCommitChanges();
        }

        protected internal virtual void OnRollbackChanges() {
            if (RollbackChangesEvent != null)
                RollbackChangesEvent(this, EventArgs.Empty);
        }
        protected internal virtual void OnCommitChanges() {
            RaiseCommitChanges();
        }
        protected internal virtual void RaiseCommitChanges() {
            if (CommitChangesEvent != null)
                CommitChangesEvent(this, EventArgs.Empty);
        }

        void ISchedulerInplaceEditorEx.Activate() {
            ActivateInplaceEditor();
        }
        void ISchedulerInplaceEditorEx.Deactivate() {
            DeactivateInplaceEditor();
        }
        void ISchedulerInplaceEditorEx.ApplyChanges() {
            ApplyChangesInplaceEditor();
        }

        void IDisposable.Dispose() {
            DisposeInplaceEditor();
        }
    }
}
