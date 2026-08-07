using DevExpress.DevAV.Common;
using DevExpress.DXperience.Demos;

namespace DevExpress.DevAV.ViewModels {
    public partial class EvaluationViewModel {
        protected override Evaluation CreateEntity() {
            var evaluation = base.CreateEntity();
            evaluation.CreatedOn = TutorialConstants.Now;
            return evaluation;
        }
        protected override string GetTitle() {
            return (Entity.Employee != null) ? string.Format("Edit Notes <color=#FF646464>{0}</color>", Entity.Employee.FullName) : string.Empty;
        }
        protected override string GetTitleForNewEntity() {
            return "Notes " + CommonResources.Entity_New;
        }
    }
}
