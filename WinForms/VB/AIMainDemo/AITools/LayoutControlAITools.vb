#If NET
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.WinForms;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraLayout;

namespace DevExpress.AI.Demos {
    public static class LayoutControlAITools {
        [AIIntegrationTool("LayoutControl_Populate")]
        [Description("Populate a LayoutControl's fields from a JSON object. Returns a text with the operation result.")]
        public static async Task<string> Populate(
            [AIIntegrationToolTarget("Target LayoutControl to fill.")]
            LayoutControl layoutControl,
            [Description("Field values as a JSON object, for example: { \"FirstName\": \"John\", \"LastName\": \"Doe\" }")]
            string data) {

            ArgumentNullException.ThrowIfNull(layoutControl);

            var behavior = BehaviorManager.Default.GetBehavior<SmartPasteBehavior>(layoutControl);
            try {
                await behavior.SmartPasteAsync(data);
                return "Fields populated in the LayoutControl.";
            }
            catch {
                return "Error: failed to populate fields in the LayoutControl.";
            }
        }
    }
}
#End If
