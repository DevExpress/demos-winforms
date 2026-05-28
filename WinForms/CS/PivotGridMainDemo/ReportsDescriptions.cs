using System;

namespace DevExpress.XtraPivotGrid.Demos {
    public static class ReportsDescriptions {
        static readonly string ReportDescription = "This demo includes a set of reports which allows you to analyze the same business data in different forms. Use the Radio buttons to switch between the reports.\r\n";

        static readonly string CustomerReportsDescription1 = ReportDescription + "In this report the XtraPivotGrid control summarizes the orders made by customers in a specific time period. The quantities ordered are given for each quarter and for each product which was bought by a customer.";
        static readonly string CustomerReportsDescription2 = ReportDescription + "In this report the XtraPivotGrid control displays the products bought by customers in a particular year. Use the Year and Quarter combo boxes to select which period is displayed and analyze the information in the control.";
        static readonly string CustomerReportsDescription3 = ReportDescription + "In this report the XtraPivotGrid lists the two most popular products for each customer (the ones which generated the most interest). Clicking the 'Product Name' field header reverses the current sort order and the control will show you the least popular products for each customer.";
        static readonly string CustomerReportsDescription4 = ReportDescription + "The XtraPivotGrid control lists the top 10 customers, who purchased the most items. Clicking the 'Customer' field header reverses the sort order and displays the customers who purchased the least amount of items.";

        static readonly string OrderReportsDescription1 = ReportDescription + "This report shows all the orders in a database and for each the details are listed as sub-categories. The XtraPivotGrid control calculates multiple summaries so you can see the Average Unit Price, Total Quantity, Average Discount and Total Price for each order.";
        static readonly string OrderReportsDescription2 = ReportDescription + "This report resembles the previous one. However, it allows you to view only one order at a time. Selecting a value from the OrderID combobox applies a filter to the XtraPivotGrid and thus displays the selected order's details.";
        static readonly string OrderReportsDescription3 = ReportDescription + "This report displays how many units of each product were ordered by customers.";
        static readonly string OrderReportsDescription4 = ReportDescription + "This report calculates the average unit price for each product. To see how unit prices differ between different orders drag the 'Order' field's header to the right of the 'Product Name' field's header.";

        static readonly string ProductReportsDescription1 = ReportDescription + "In this report the XtraPivotGrid control displays the total amount of sales for each category of product.";
        static readonly string ProductReportsDescription2 = ReportDescription + "In this report the XtraPivotGrid control shows the total amount of sales for each product. Check the Show Categories check box to view products by categories. For each category a total will be automatically calculated.";
        static readonly string ProductReportsDescription3 = ReportDescription + "In this report the XtraPivotGrid control allows you to view the amount of sales for each category and product according to the shipping date. You can categorize the information by year, quarter and(or) month.";
        static readonly string ProductReportsDescription4 = ReportDescription + "In this report the XtraPivotGrid calculates multiple summaries (Sum, Average, Max and Min) for each product category. It breaks the information down into years and quarterly intervals so that you can analyze the information according to the shipping date.";
        static readonly string ProductReportsDescription5 = ReportDescription + "In this report the XtraPivotGrid control calculates the total, average and minimum sales amount for each category.";
        static readonly string ProductReportsDescription6 = ReportDescription + "This report shows the three most popular products in each category. Clicking the 'Product Name' field header reverses the current sort order and the report will show you the three least popular products in each category.";

        public static readonly string[] CustomerReportsDescriptions = new string[] { CustomerReportsDescription1, CustomerReportsDescription2, CustomerReportsDescription3, CustomerReportsDescription4 };
        public static readonly string[] OrderReportsDescriptions = new string[] { OrderReportsDescription1, OrderReportsDescription2, OrderReportsDescription3, OrderReportsDescription4 };
        public static readonly string[] ProductReportsDescriptions = new string[] { ProductReportsDescription1, ProductReportsDescription2, ProductReportsDescription3, ProductReportsDescription4, ProductReportsDescription5, ProductReportsDescription6 };
    }
}
