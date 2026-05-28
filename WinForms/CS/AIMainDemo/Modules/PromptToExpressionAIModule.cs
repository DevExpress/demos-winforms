using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.AI.Demos {
    public partial class PromptToExpressionAIModule : AITutorialControl {
        GridColumn colTotalCost;
        public PromptToExpressionAIModule() {
            InitializeComponent();
            InitGridControl();
            UpdatePaddings();
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
        void InitGridControl() {
            gridControl1.DataSource = PromptToExpressionDataHelper.GetData(30);

            colTotalCost = new GridColumn();
            colTotalCost.Caption = "Total ($)";
            colTotalCost.FieldName = "Total";
            colTotalCost.DisplayFormat.FormatType = Utils.FormatType.Numeric;
            colTotalCost.DisplayFormat.FormatString = "c2";
            colTotalCost.UnboundDataType = typeof(float);
            colTotalCost.UnboundExpression = "[OrderCost] + [ShippingCost] - [Discount]";
            colTotalCost.AppearanceHeader.Font = new Font(colTotalCost.AppearanceHeader.Font, FontStyle.Bold);
            colTotalCost.Visible = true;
            colTotalCost.ShowUnboundExpressionMenu = true;
            gridView1.Columns.Add(colTotalCost);
        }
        void sbFilterEditor_Click(object sender, EventArgs e) {
            gridView1.ShowFilterEditor(null);
        }
        void sbExpressionEditor_Click(object sender, EventArgs e) {
            gridView1.ShowUnboundExpressionEditor(colTotalCost);
        }
        private void gridControl1_Load(object sender, EventArgs e) {
            gridView1.BestFitColumns();
        }

        class ShippingRecord {
            public int TrackingID { get; set; }
            [DisplayName("Initial Delivery Date")]
            public DateTime EstimatedDeliveryDate { get; set; }
            [DisplayName("Updated Delivery Date")]
            public DateTime UpdatedDeliveryDate { get; set; }
            [DataType(DataType.Currency)]
            [DisplayName("Order Cost ($)")]
            public float OrderCost { get; set; }
            [DataType(DataType.Currency)]
            [DisplayName("Shipping Cost ($)")]
            public float ShippingCost { get; set; }
            [DataType(DataType.Currency)]
            [DisplayName("Discount ($)")]
            public float Discount { get; set; }
        }

        class PromptToExpressionDataHelper {
            public static BindingList<ShippingRecord> GetData(int count) {
                BindingList<ShippingRecord> records = new BindingList<ShippingRecord>();
                DateTime dateTime = TutorialConstants.Today;
                for(int i = 0; i < count; i++) {
                    int n = TutorialConstants.Random.Next(10);
                    double doubleOrderCost = TutorialConstants.Random.NextDouble();
                    double shippingCost = TutorialConstants.Random.NextDouble();
                    var record = new ShippingRecord() {
                        TrackingID = i + 1000,
                        EstimatedDeliveryDate = dateTime.AddDays(-(n % 3)),
                        UpdatedDeliveryDate = dateTime.AddDays(n % 9 - 2),
                        OrderCost = (float)(doubleOrderCost * 500 + 50),
                        ShippingCost = (float)(shippingCost * 50 + 10),
                        Discount = (i % 3 == 0) ? 10 : 0
                    };
                    records.Add(record);
                }
                return records;
            }
        }
    }
}
