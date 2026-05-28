#If NET
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Blazor.Chat;
using DevExpress.AIIntegration.Blazor.Chat.WebView;
using DevExpress.AIIntegration.Tools;
using DevExpress.AIIntegration.WinForms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Behaviors;
using Microsoft.Extensions.AI;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class RuntimeToolsAIModule
        Inherits AITutorialControl

#If NET
        public const string ToolsChatResponseProviderServiceKey = "ToolsChatResponseProviderServiceKey";
        const string SystemMessage =
@"You are an assistant integrated into an application. Your role is to perform all user-requested UI operations exclusively through the provided tools.

Rules:
1. Always use tools to interact with the UI. Do not simulate actions or produce imagined results.
2. If a tool requires a tool-target identifier, obtain it only by calling the GetToolTargets tool. Never invent, guess, or construct identifiers; always use one returned by GetToolTargets.
3. Provide valid parameter values for every tool call, using context or additional tool calls when needed.
4. If the user requests an action that cannot be performed through the available tools, clearly state that it is not supported.";

        AIToolsContext context;
        PromptSuggestion[] gridPromptSuggestions = {
            new ("Sort Grid Column", "Sort the grid against a specific column in ascending order.", "Sort the grid by Country in ascending order.", false),
            new ("Group Grid Data", "Group grid data against a specific column.", "Group grid data by Country.", false),
            new ("Clear Grouping", "Remove all data groupings from the grid.", "Clear all data groupings in the grid.", false),
            new ("Filter Grid Data", "Filter the grid by order total amount.", "Filter the grid and display orders where total amount is greater than 500.", false),
            new ("Clear Filters", "Remove all data filters from the grid.", "Clear all data filters from the grid.", false),
            new ("Application Theme", "Switch to dark mode", "Change the application theme to dark mode", false),
            new ("Application Layout", "Switch to full-window mode", "Switch the application to full-window mode", false)
        };
        PromptSuggestion[] layoutPromptSuggestions = {
            new("Smart Paste", "Auto-populate the DevExpress Layout Control form", "Populate this form with sample data: \r\nPayment: Amount - $123.00\r\nStatement Date: 10/15/2024\r\nAccount Number: 133244556\r\nName: John Smith\r\nContact: (123) 456-7890\r\nEmail: john@myemail.com\r\nAddress:\r\n- 123 Elm St Apt 4B\r\n- New York, NY 10001", false),
            new("Application Theme", "Switch to dark mode", "Change the application theme to dark mode", false),
            new("Application Layout", "Switch to full-screen mode", "Switch the application to full-window mode", false),
        };

        public RuntimeToolsAIModule() {
            InitializeComponent();
            InitLayoutControl();
            UpdatePaddings();
            SetPromptSuggestions();
            UpdatePanelControlBackColor();

            aiChatControl1.ChatResponseProviderServiceKey = ToolsChatResponseProviderServiceKey;

            gridControl1.DataSource = OrderDataHelper.GetData(10);
            gridView1.BestFitColumns();

            aiChatControl1.IncludeFunctionCallInfo = Utils.DefaultBoolean.True;
            aiChatControl1.LoadMessages([ new BlazorChatMessage(ChatRole.System, SystemMessage)]);
            aiChatControl1.ResponseReceived += AiChatControl1_ResponseReceived;
        }

        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
        void UpdatePanelControlBackColor() {
            panelControl2.BackColor = CommonSkins.GetSkin(LookAndFeel).TranslateColor(SystemColors.Window);
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdatePanelControlBackColor();
        }
        protected override void DoShow() {
            SetAIToolsContext();
            base.DoShow();
        }
        protected override void DoHide() {
            context?.Dispose();
            base.DoHide();
        }

        void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e) {
            SetPromptSuggestions();
            SetAIToolsContext();
        }
        // The ResponseReceived event occurs when the AIChatControl receives a response from the AI service.
        // Handle this event to modify metadata about invoked tools/functions.
        void AiChatControl1_ResponseReceived(object sender, AIChatControlResponseReceivedEventArgs e) {
            if(e.Message.FunctionCalls.Count > 0) {
                // Remove the information about the GetToolTargets function used internally by the LLM to select a tool target.
                if(e.Message.FunctionCalls.RemoveAll(fcall => fcall.Request.Name == "GetToolTargets") > 0) {
                    // Remove internal '*_identifier' arguments from function calls.
                    // These arguments specify tool target selection information and are not intended for user display.
                    e.Message.FunctionCalls.ForEach(fcall => {
                        var argumentsToRemove = fcall.Request.Arguments.Keys
                            .Where(k => k.EndsWith("_identifier")).ToList();
                        foreach(var argument in argumentsToRemove)
                                fcall.Request.Arguments.Remove(argument);
                    });
                }
            }
        }

        void InitLayoutControl() {
            var itemsDescriptions = new List<AIItemDescription>() {
                new(layoutControlItem1, "The primary address line, which usually includes the street number and name (e.g., 123 Main St). Can include alphabetic and numeric characters."),
                new(layoutControlItem2, "The secondary address line, which can include apartment or suite number (e.g., Apt 4B). This field is optional. Can include alphabetic and numeric characters."),
                new(layoutControlItem3, "The city name. Only alphabetic characters are expected."),
                new(layoutControlItem4, "The state, province, or region name or abbreviation. Only alphabetic characters are expected."),
                new(layoutControlItem5, "The ZIP or postal code. Numeric characters and sometimes alphabetic characters (e.g., for Canadian postal codes) are expected."),
                new(layoutControlItem6, "The first name of the recipient. Only alphabetic characters are expected."),
                new(layoutControlItem7, "The last name of the recipient. Only alphabetic characters are expected."),
                new(layoutControlItem8, "The phone number of the recipient in the format of (XXX) XXX-XXXX or similar. Only numeric characters and standard phone number formatting characters (e.g., parentheses, dashes, spaces) are expected."),
                new(layoutControlItem10, "The email of the recipient.")
            };
            //
            BehaviorManager.Default.Attach<SmartPasteBehavior>(layoutControl1, b => { b.Properties.ItemDescriptions.AddRange(itemsDescriptions); });
            layoutControl1.AllowCustomization = false;
        }
        void SetPromptSuggestions() {
            aiChatControl1.SetPromptSuggestions(tabPane1.SelectedPage == layoutTabNavigationPage ? layoutPromptSuggestions : gridPromptSuggestions);
        }
        void SetAIToolsContext() {
            context?.Dispose();
            var contextBuilder = new AIToolsContextBuilder()
                .WithToolMethods(SetSkinPalette, SwitchFullScreenMode, CloseApplication)
                .WithToolsFromAssemblies(typeof(RuntimeToolsAIModule).Assembly);

            if(tabPane1.SelectedPage == layoutTabNavigationPage) {
                context = contextBuilder
                    .WithToolTarget(layoutControl1, "LayoutControl containing form fields to be populated.")
                    .Build();
            }
            else {
                context = contextBuilder
                    .WithToolTarget(gridView1, "The main Grid that displays order records.")
                    .Build();
            }
            AIExtensionsContainerDesktop.Default.AddAIToolsContext(context);
        }
        [Description("Change the application theme between dark and light modes.")]
        string SetSkinPalette([Description("If true, applies dark mode; if false, applies light mode.")] bool dark) {
            XtraEditors.WindowsFormsSettings.TrackWindowsAppMode = Utils.DefaultBoolean.False;
            var palette = dark ? SkinSvgPalette.WXI.Darkness : SkinSvgPalette.WXI.Default;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI, palette);
            return $"Current theme: {(dark ? "Dark" : "Light")}";
        }
        [Description("Toggle the application between full-screen and windowed modes.")]
        string SwitchFullScreenMode() {
            ParentFormMain.WindowState = ParentFormMain.WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
            return $"Window state: {ParentFormMain.WindowState.ToString()}";
        }
        [Description("Close the application.")]
        void CloseApplication() {
            ParentFormMain.Close();
        }
    }
    public class Order {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }
    }
    public class OrderDataHelper {
        static readonly string[] Customers = new[] {
            "Alice","Bob","Charlie","Diana","Evan","Fiona","George","Helen","Ivan","Julia",
            "Karl","Laura","Martin","Nina","Oscar"
        };
        static readonly string[] Products = new[] {
            "Laptop","Mouse","Monitor","Keyboard","Webcam","Headset","Docking Station","USB Hub","External SSD","Graphic Tablet"
        };
        static readonly string[] Countries = new[] {
            "USA","Canada","UK","Germany","France","Spain","Italy","Netherlands","Australia","Japan"
        };
        static readonly string[] Statuses = new[] {
            "Pending","Processing","Shipped","Delivered","Cancelled","On Hold"
        };
        static readonly Dictionary<string, decimal> BasePrices = new(StringComparer.OrdinalIgnoreCase) {
            { "Laptop", 950m }, { "Mouse", 20m }, { "Monitor", 180m }, { "Keyboard", 45m },
            { "Webcam", 70m }, { "Headset", 85m }, { "Docking Station", 130m }, { "USB Hub", 25m },
            { "External SSD", 150m }, { "Graphic Tablet", 210m }
        };
        public static BindingList<Order> GetData(int count) {
            var list = new BindingList<Order>();
            var rnd = Data.Utils.NonCryptographicRandom.Default;
            for(int i = 0; i < count; i++) {
                var product = Products[rnd.Next(Products.Length)];
                int quantity = rnd.Next(1, 8);
                decimal basePrice = BasePrices[product];
                decimal variance = basePrice * (decimal)(rnd.NextDouble() * 0.2 - 0.1);
                decimal total = Math.Round((basePrice + variance) * quantity, 2);
                var order = new Order {
                    OrderID = i + 1,
                    CustomerName = Customers[i % Customers.Length],
                    ProductName = product,
                    Quantity = quantity,
                    Country = Countries[rnd.Next(Countries.Length)],
                    Status = Statuses[rnd.Next(Statuses.Length)],
                    OrderDate = DateTime.Today.AddDays(-rnd.Next(0, 30)),
                    TotalAmount = total
                };
                list.Add(order);
            }
            return list;
        }
#End If
    End Class
End Namespace
