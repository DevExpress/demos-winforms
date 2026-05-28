using System;
using DevExpress.AIIntegration.WinForms;

namespace DevExpress.AI.Demos {
    public partial class SmartAutoCompleteModule : AITutorialControl {
        public SmartAutoCompleteModule() {
            InitializeComponent();
            InitUserRoles();
            UpdatePaddings();
        }

        void InitUserRoles() {
            comboBoxEditUserRole.SelectedIndexChanged += ComboBoxEditUserRole_SelectedIndexChanged;
            comboBoxEditUserRole.Properties.Items.AddRange(new UserRoleItem[] {
                new UserRoleItem(){ Name = "Technical support agent", Description = "Technical support service agent responding to a customer's question" },
                new UserRoleItem(){ Name = "Sales manager", Description = "Sales manager responding to a client's request for a product quote" },
                new UserRoleItem(){ Name = "Customer Success Manager", Description = "Customer Success Manager onboarding a new client" },
                new UserRoleItem(){ Name = "Product Manager", Description = "Product Manager announcing new feature updates to existing users" },
                new UserRoleItem(){ Name = "Marketing Specialist", Description = "Marketing Specialist drafting a promotional email for a limited-time offer" }
            });
            comboBoxEditUserRole.SelectedIndex = 0;
        }

        void ComboBoxEditUserRole_SelectedIndexChanged(object sender, EventArgs e) {
            UserRoleItem role = comboBoxEditUserRole.SelectedItem as UserRoleItem;
            var behavior = behaviorManager1.GetBehavior<SmartAutoCompleteBehavior>(memoEdit1);
            behavior.Properties.UserRole = role.Description;
            labelControl1.Text = role.Description;
        }

        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
    }

    public class UserRoleItem {
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString() {
            return Name;
        }
    }
}
