using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraDiagram.Demos;
using DevExpress.DXperience.Demos;
using DevExpress.Diagram.Core;
using System.Data.OleDb;
using DevExpress.Diagram.Demos;
using System.Collections.ObjectModel;
using DevExpress.Utils;
using DevExpress.Data.Filtering;
using DevExpress.XtraBars;

namespace DevExpress.XtraDiagram.Demos {
    public partial class ProductFlowDiagramModule : DiagramTutorialControl {
        readonly DiagramItemStyleId[] styles = DiagramShapeStyleId.Styles.ToArray();
        readonly ProductFlowInfo info;

        public ProductFlowDiagramModule() : base(false, false) {
            InitializeComponent();
            PlaceOptionsPanelControlsWithoutTabPane();
            diagramControl.Commands.RegisterHotKeys(ClearHotKeys);
            info = OrderDataGenerator.GenerateProductFlowInfo();
            diagramDataBindingController1.BeginInit();
            diagramDataBindingController1.DataSource = info.Items;
            diagramDataBindingController1.ConnectorsSource = info.ProductFlows;
            diagramDataBindingController1.EndInit();
            gridControl.DataSource = info.Orders;
            Diagram.SelectionChanged += OnDiagramSelectionChanged;
            Diagram.SelectItem(Diagram.Items.First());
            Diagram.OptionsProtection.IsReadOnly = true;
        }
        void ClearHotKeys(IHotKeysRegistrator registrator) {
            registrator.ClearHotKeys(DiagramCommandsBase.SaveFileAsCommand);
            registrator.ClearHotKeys(DiagramCommandsBase.SaveFileCommand);
        }
        void OnDiagramSelectionChanged(object sender, DiagramSelectionChangedEventArgs e) {
            var selectedDiagramItem = Diagram.PrimarySelection;
            gridView.ClearGrouping();
            gridView.ActiveFilterCriteria = null;

            if(selectedDiagramItem == null)
                return;

            var customers = GetDataItems<CustomerData>();
            var categories = GetDataItems<CategoryData>();
            var connectors = GetDataItems<ProductFlowData>();

            if(connectors.Any()) {
                var connectorsCriteria = connectors.Select(c => new GroupOperator(GroupOperatorType.And,
                    GetCategoryOperator(c.Category.Name), GetCustomerOperator(c.Customer.Name)));
                gridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.Or, connectorsCriteria);
                GroupGridControl("Category.Name");
                return;
            }
            if(customers.Any() && !categories.Any()) {
                var customersCriteria = customers.Select(c => GetCustomerOperator(c.Name));
                gridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.Or, customersCriteria);
                GroupGridControl("Category.Name");
            }
            if(categories.Any()) {
                var productCriteria = new GroupOperator(GroupOperatorType.Or, categories.Select(c => GetCategoryOperator(c.Name)));
                GroupOperator customersCriteria = null;
                if(customers.Any())
                    customersCriteria = new GroupOperator(GroupOperatorType.Or, customers.Select(c => GetCustomerOperator(c.Name)));
                gridView.ActiveFilterCriteria = customers.Any() ? new GroupOperator(GroupOperatorType.And, customersCriteria, productCriteria) : productCriteria;
                GroupGridControl("Customer.Name");
            }
        }

        void GroupGridControl(string columnName) {
            gridView.Columns[columnName].Group();
            gridView.ExpandAllGroups();
        }

        void diagramDataBindingController1_GenerateItem(object sender, DiagramGenerateItemEventArgs e) {
            var templateName = (e.DataObject is CustomerData) ? "CustomerTemplate" : "CategoryTemplate";
            e.Item = e.CreateItemFromTemplate(templateName);
        }

        void diagramDataBindingController1_CustomLayoutItems(object sender, DiagramCustomLayoutItemsEventArgs e) {
            ArrangeItemsInLine<CategoryData>(e.Items, new PointFloat(600, 50), new Size(150, 105), 20);
            ArrangeItemsInLine<CustomerData>(e.Items, new PointFloat(50, 100), new Size(150, 105), 20);
            foreach(var item in e.Items) {
                var customer = item.DataContext as CustomerData;
                if(customer != null) {
                    item.ThemeStyleId = styles[Array.IndexOf(info.Customers, customer)];
                }
            }
            foreach(var connector in e.DiagramConnectors) {
                var connectorData = (ProductFlowData)connector.DataContext;
                connector.ThemeStyleId = styles[Array.IndexOf(info.Customers, connectorData.Customer)];
            }
            e.Handled = true;
        }
        void ArrangeItemsInLine<TDataContext>(IEnumerable<DiagramItem> items, PointFloat startPosition, Size itemSize, int margin) {
            PointFloat position = startPosition;
            foreach(var diagramItem in items.Where(x => x.DataContext is TDataContext)) {
                diagramItem.Position = position;
                position.Offset(0, itemSize.Height + margin);
            }
        }

        void diagramDataBindingController1_UpdateConnector(object sender, DiagramUpdateConnectorEventArgs e) {
            var connectorData = (ProductFlowData)e.DataObject;
            e.Connector.Appearance.BorderSize = (int)connectorData.Weight;
        }
        IEnumerable<T> GetDataItems<T>() {
            return this.diagramControl.SelectedItems.Select(x => x.DataContext).Where(x => x is T).Cast<T>();
        }
        BinaryOperator GetCategoryOperator(string value) {
            return GetEqualOperator("Category.Name", value);
        }
        BinaryOperator GetCustomerOperator(string value) {
            return GetEqualOperator("Customer.Name", value);
        }
        BinaryOperator GetEqualOperator(string propertyName, string value) {
            return new BinaryOperator(propertyName, value, BinaryOperatorType.Equal);
        }
    }
}
