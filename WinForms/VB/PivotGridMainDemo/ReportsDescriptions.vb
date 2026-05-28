Namespace DevExpress.XtraPivotGrid.Demos

    Public Module ReportsDescriptions

        Private ReadOnly ReportDescription As String = "This demo includes a set of reports which allows you to analyze the same business data in different forms. Use the Radio buttons to switch between the reports." & Microsoft.VisualBasic.Constants.vbCrLf

        Private ReadOnly CustomerReportsDescription1 As String = ReportDescription & "In this report the XtraPivotGrid control summarizes the orders made by customers in a specific time period. The quantities ordered are given for each quarter and for each product which was bought by a customer."

        Private ReadOnly CustomerReportsDescription2 As String = ReportDescription & "In this report the XtraPivotGrid control displays the products bought by customers in a particular year. Use the Year and Quarter combo boxes to select which period is displayed and analyze the information in the control."

        Private ReadOnly CustomerReportsDescription3 As String = ReportDescription & "In this report the XtraPivotGrid lists the two most popular products for each customer (the ones which generated the most interest). Clicking the 'Product Name' field header reverses the current sort order and the control will show you the least popular products for each customer."

        Private ReadOnly CustomerReportsDescription4 As String = ReportDescription & "The XtraPivotGrid control lists the top 10 customers, who purchased the most items. Clicking the 'Customer' field header reverses the sort order and displays the customers who purchased the least amount of items."

        Private ReadOnly OrderReportsDescription1 As String = ReportDescription & "This report shows all the orders in a database and for each the details are listed as sub-categories. The XtraPivotGrid control calculates multiple summaries so you can see the Average Unit Price, Total Quantity, Average Discount and Total Price for each order."

        Private ReadOnly OrderReportsDescription2 As String = ReportDescription & "This report resembles the previous one. However, it allows you to view only one order at a time. Selecting a value from the OrderID combobox applies a filter to the XtraPivotGrid and thus displays the selected order's details."

        Private ReadOnly OrderReportsDescription3 As String = ReportDescription & "This report displays how many units of each product were ordered by customers."

        Private ReadOnly OrderReportsDescription4 As String = ReportDescription & "This report calculates the average unit price for each product. To see how unit prices differ between different orders drag the 'Order' field's header to the right of the 'Product Name' field's header."

        Private ReadOnly ProductReportsDescription1 As String = ReportDescription & "In this report the XtraPivotGrid control displays the total amount of sales for each category of product."

        Private ReadOnly ProductReportsDescription2 As String = ReportDescription & "In this report the XtraPivotGrid control shows the total amount of sales for each product. Check the Show Categories check box to view products by categories. For each category a total will be automatically calculated."

        Private ReadOnly ProductReportsDescription3 As String = ReportDescription & "In this report the XtraPivotGrid control allows you to view the amount of sales for each category and product according to the shipping date. You can categorize the information by year, quarter and(or) month."

        Private ReadOnly ProductReportsDescription4 As String = ReportDescription & "In this report the XtraPivotGrid calculates multiple summaries (Sum, Average, Max and Min) for each product category. It breaks the information down into years and quarterly intervals so that you can analyze the information according to the shipping date."

        Private ReadOnly ProductReportsDescription5 As String = ReportDescription & "In this report the XtraPivotGrid control calculates the total, average and minimum sales amount for each category."

        Private ReadOnly ProductReportsDescription6 As String = ReportDescription & "This report shows the three most popular products in each category. Clicking the 'Product Name' field header reverses the current sort order and the report will show you the three least popular products in each category."

        Public ReadOnly CustomerReportsDescriptions As String() = New String() {CustomerReportsDescription1, CustomerReportsDescription2, CustomerReportsDescription3, CustomerReportsDescription4}

        Public ReadOnly OrderReportsDescriptions As String() = New String() {OrderReportsDescription1, OrderReportsDescription2, OrderReportsDescription3, OrderReportsDescription4}

        Public ReadOnly ProductReportsDescriptions As String() = New String() {ProductReportsDescription1, ProductReportsDescription2, ProductReportsDescription3, ProductReportsDescription4, ProductReportsDescription5, ProductReportsDescription6}
    End Module
End Namespace
