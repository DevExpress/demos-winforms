using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.XtraPivotGrid.Demos.Helpers {
    public class OLAPConfigurator {
        public const string CategoriesFieldName = "[Product].[Product Categories].[Category]";
        public const string OrderQuantityFieldName = "[Measures].[Order Quantity]";
        bool connectionError = false;

	    public static bool ConnectToAdventureWorks(PivotGridControl pivot, bool configureFields) {
            if(!Connect(pivot))
                return false;
			if(configureFields)
				ConfigureSampleFields(pivot);
            return true;
        }

        static bool Connect(PivotGridControl pivot) {
            OLAPConfigurator configurator = new OLAPConfigurator();
            try {
				pivot.QueryException += configurator.Pivot_QueryException;
				bool useXmla = !OLAPMetaGetter.IsProviderAvailable;
				pivot.BeginUpdate();
				if(useXmla) {
					pivot.OLAPDataProvider = OLAPDataProvider.Xmla;
					pivot.OLAPConnectionString = OLAPConnectionDesigner.SampleXMLAConnectionString;
				} else {
					pivot.OLAPDataProvider = OLAPDataProvider.OleDb;
					pivot.OLAPConnectionString = OLAPConnectionDesigner.SampleConnectionString;
				}
				pivot.EndUpdate();
			} finally {
                pivot.QueryException -= configurator.Pivot_QueryException;
            }

            bool connected = !configurator.connectionError;
            if(!connected) {
				pivot.OLAPDataProvider = OLAPDataProvider.OleDb;
                pivot.OLAPConnectionString = null;
                pivot.Enabled = false;
            }
            return connected;
        }

        void Pivot_QueryException(object sender, PivotQueryExceptionEventArgs e) {
             connectionError = connectionError || e.Exception is OLAPConnectionException;
        }

        public static bool CreateSampleAdoConfiguration(PivotGridControl pivot) {
            if(!AdomdMetaGetter.IsProviderAvailable)
                return false;
            try {
                PivotGridAdomdDataSource ds = new PivotGridAdomdDataSource();
                ds.ConnectionString = OLAPConnectionDesigner.SampleConnectionString;
                pivot.DataSource = ds;
            } catch(OLAPConnectionException) {
                pivot.DataSource = null;
                pivot.Enabled = false;
                return false;
            }
            ConfigureSampleFields(pivot);
            return true;
        }
        static void ConfigureSampleFields(PivotGridControl pivot) {
            RetrieveFields(pivot);
            PivotGridField fieldQuantity = pivot.Fields[OrderQuantityFieldName];
            if(fieldQuantity != null) {
                fieldQuantity.Visible = true;
                fieldQuantity.Area = PivotArea.DataArea;
            }
            PivotGridField fieldCategories = pivot.Fields[CategoriesFieldName];
            if(fieldCategories != null) {
                fieldCategories.Visible = true;
                fieldCategories.Area = PivotArea.RowArea;
            }
			if(fieldCategories != null && fieldQuantity != null)
				fieldCategories.ExpandAll();
        }
        public static void RetrieveFields(PivotGridControl pivot) {
            pivot.BeginUpdate();
            pivot.RetrieveFields(PivotArea.FilterArea, false);
            for(int i = 0; i < pivot.Fields.Count; i++) {
                pivot.Fields[i].SortMode = PivotSortMode.None;
            }
            pivot.EndUpdate();
        }
    }
}
