using System.Windows.Forms;

namespace DevExpress.MVVM.Demos.TodoApp {
    public class TodoAppModule : TutorialControl {
        Form todoAppForm;
        public TodoAppModule() {
            todoAppForm = new global::TodoApp.MainView();
            Tutorials.TodoApp.PresentationHelper.CenterParent(this, todoAppForm, true);
        }
        protected override void DoShow() {
            base.DoShow();
            if(todoAppForm != null && !todoAppForm.Visible)
                todoAppForm.Show();
        }
        protected override void DoHide() {
            if(todoAppForm != null && todoAppForm.Visible)
                todoAppForm.Hide();
            base.DoHide();
        }
    }
}
