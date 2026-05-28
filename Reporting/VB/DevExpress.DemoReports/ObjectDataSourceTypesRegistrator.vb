Imports DevExpress.Utils

Namespace XtraReportsDemos

    Public Module ObjectDataSourceTypesRegistrator

        Public Sub RegisterTrustedTypes()
            DeserializationSettings.RegisterTrustedClass(GetType(BalanceSheetReport.BalanceSheetData))
            DeserializationSettings.RegisterTrustedClass(GetType(CachedDocumentSourceReport.DataItemList))
            DeserializationSettings.RegisterTrustedClass(GetType(CarryoverSummaryReport.DataSource))
            DeserializationSettings.RegisterTrustedClass(GetType(HierarchicalReport.DataSource))
            DeserializationSettings.RegisterTrustedClass(GetType(MultiColumnReport.DataSource))
            DeserializationSettings.RegisterTrustedClass(GetType(ProfitAndLossReport.Data))
            DeserializationSettings.RegisterTrustedClass(GetType(RestaurantMenu.DataSource))
            DeserializationSettings.RegisterTrustedClass(GetType(SwissQRCode.BillDS))
            DeserializationSettings.RegisterTrustedClass(GetType(NorthwindTraders.SortGroupsType))
            DeserializationSettings.RegisterTrustedClass(GetType(PollingReport.ResultingData))
        End Sub
    End Module
End Namespace
