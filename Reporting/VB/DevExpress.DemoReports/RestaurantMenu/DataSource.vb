Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Namespace XtraReportsDemos.RestaurantMenu

    <DisplayName("Restaurant Menu Report Data Source")>
    Public Class DataSource

        Public Shared Function GetMenuData() As IEnumerable(Of MenuItem)
            Dim menu As List(Of MenuItem) = New List(Of MenuItem)()
            menu.Add(New MenuItem("STEAKS", "Porterhouse", "Expertly aged and cooked to perfection. Finest cuts of filet and New York Strip sliced off the bone and presented Stuffed with Portobello Mushroom", 79.0))
            menu.Add(New MenuItem("STEAKS", "Sirloin Steak", "Our signature center-cut sirloin grilled to perfection served with choice of steak fries or whipped potatoes", 32.0))
            menu.Add(New MenuItem("STEAKS", "Steak & Scallops", "Beef Tenderloin Steak & 6 Large Scallops served with Champagne Butter Sauce", 41.0))
            menu.Add(New MenuItem("STEAKS", "Steak & Chicken Fingers", "Our 8-ounce Ribeye Steak and four strips of breaded white chicken, served with your choice of baked potato, or steak fries", 30.00))
            menu.Add(New MenuItem("STEAKS", "Steak & Ribs", "House Steak Beef & Smoked, wood-fire grilled ribs brushed with our secret sauce", 42.0))
            menu.Add(New MenuItem("STEAKS", "Steak & Chicken Breast", "11 ounces of our most tender cut of lean midwestern beef with our Seasoned and wood-fire grilled chicken breast", 32.0))
            menu.Add(New MenuItem("STEAKS", "Steak & Fried Shrimp", "Garlic Butter Grilled Steak & Cajun Fried Shrimp", 34.0))
            menu.Add(New MenuItem("CHICKEN", "Chicken Breast", "An 8 - ounce boneless, skinless chicken breast marinated and grilled to perfection. Served your choice of baked potato, or steak fries", 26.0))
            menu.Add(New MenuItem("CHICKEN", "Chicken Parmigiana", "Tender pan-fried chicken breast topped with tomato sauce and cheese baked until golden and bubbly", 23.0))
            menu.Add(New MenuItem("CHICKEN", "Alice Springs Chicken", "Marinated chicken breast in honey mustard sauce, topped with mushrooms, bacon, and cheese", 21.0))
            menu.Add(New MenuItem("SEAFOOD", "Baked Scrod", "Baked en casserole with Lemon-Garlic Bread crumbs", 18.0))
            menu.Add(New MenuItem("SEAFOOD", "Grilled Salmon", "8 oz. filet of wild salmon, hand-cut, seasoned and grilled over an open flame", 23.0))
            menu.Add(New MenuItem("SEAFOOD", "Smoked Salmon", "Served on homemade crostini topped with a dollop of crème fresh and Garnished with lemon zest and herbs", 17.00))
            menu.Add(New MenuItem("SEAFOOD", "Octopus", "Braised in sherry grilled and glazed with a tangy ancho chili sauce", 16.00))
            menu.Add(New MenuItem("SEAFOOD", "Seafood platter", "A Feast of Seafood featuring Jumbo Gulf Shrimp, Oysters, Tilapia Filets, and Crab Cakes Served with our homemade Tartar Sauce", 37.0))
            menu.Add(New MenuItem("SEAFOOD", "Fried Shrimp", "Panko Coated with Cajun Seasoning and Air Fried to a Golden Crisp", 28.0))
            menu.Add(New MenuItem("SEAFOOD", "Fried Clam Strips", "Traditional New England Style Fried Clams with Herb Seasonings and Egg Batter", 15.0))
            menu.Add(New MenuItem("SEAFOOD", "Fried Calamari", "Fried Light and Crisp. Served with Garlic Dip and Cocktail Sauce", 21.0))
            menu.Add(New MenuItem("APPETIZERS", "Soup of the Day", "Selection changes daily. Today’s soup roasted butternut squash", 9.00))
            menu.Add(New MenuItem("APPETIZERS", "Barbecued Shrimp", "Fresh shrimp sautéed in a Cajun sauce and flavored with garlic, and lemon juice. Served with crusty French bread", 13.00))
            menu.Add(New MenuItem("APPETIZERS", "Fish and Chips", "Panko Batter, Air Fried Cod served with our homemade Tartar Sauce", 16.00))
            menu.Add(New MenuItem("APPETIZERS", "Mushrooms Stuffed with Crabmeat", "Juicy mushrooms stuffed with tender crab meat and cream cheese filling, topped with seasoned bread crumbs", 18.00))
            menu.Add(New MenuItem("APPETIZERS", "Crispy Lobster Tail", "Cold water lobster tail, lightly fried, tossed in a spicy cream sauce, and served with our tangy cucumber salad", 26.0))
            menu.Add(New MenuItem("APPETIZERS", "Chilled Seafood Tower", "Kona Lobster, Alaskan King Crab, Pacific Oysters, Shrimp Cocktail", 159.0))
            menu.Add(New MenuItem("APPETIZERS", "Sizzling Blue Crab Cakes Lump", "Crab Cakes served with our house made sauce", 28.00))
            menu.Add(New MenuItem("APPETIZERS", "Crab Stack", "Fresh avocado, tomato, cucumber and mango all get pulled together with cilantro lime vinaigrette, and topped with crab", 25.00))
            menu.Add(New MenuItem("SALADS", "Caesar Salad", "Crisp Romaine with our House made Caesar dressing and Reggiano Croutons", 13.00))
            menu.Add(New MenuItem("SALADS", "Seaweed Salad", "Cucumber Seaweed, red onions, bell peppers, cilantro, sesame seeds and seaweed tossed with vinaigrette, and topped off with sesame oil", 11.00))
            menu.Add(New MenuItem("SALADS", "Greek Salad", "Romaine, Tomato, Red Onion, Cucumbers, Feta Cheese and Kalamata Olives tosses in Vinaigrette", 9.00))
            menu.Add(New MenuItem("SALADS", "Tomato Salad", "Ripe Red Heirloom Tomatoes Minced Garlic, Extra Virgin Olive Oil", 8.00))
            menu.Add(New MenuItem("SALADS", "Wedge of Iceberg", "Maytag Blue, Crispy Bacon, Avocado, Tomato", 13.0))
            menu.Add(New MenuItem("SALADS", "Warm Steak Salad", "Top Sirloin Steak pan seared and sliced thinly, paired with , avocado, tomatoes, and a fresh Cilantro Lime Dressing", 17.0))
            menu.Add(New MenuItem("VEGETABLES", "Potatoes", "Au Gratin, Whipped, Baked, Steak Fries", 9.00))
            menu.Add(New MenuItem("VEGETABLES", "Broccoli", "Sautéed, Roasted", 8.00))
            menu.Add(New MenuItem("VEGETABLES", "Spinach", "Creamed, Sautéed", 9.00))
            menu.Add(New MenuItem("VEGETABLES", "Green Beans", "Sautéed with Minced Garlic", 7.00))
            menu.Add(New MenuItem("BURGERS", "All American Burger", "Fresh-ground chuck, cheddar, tomato, lettuce and onion on a toasted bun", 17.00))
            menu.Add(New MenuItem("BURGERS", "Steakburger", "Single Steak Burger Patty on Toasted Bun with Tomato, Onion, Mustard, Pickles", 16.00))
            menu.Add(New MenuItem("BURGERS", "Crisp Chicken Burger", "Made with natural-cut, whole white meat chicken breast. Coated in our very own Southern-style breading, seasoned with onion, garlic and a pinch of cayenne. Served with crispy lettuce, ripe tomato and pickles on a toasted bun", 13.00))
            menu.Add(New MenuItem("DESSERTS", "Chocolate Cheesecake", "Silky Chocolate Cheesecake topped with a layer of Belgian Chocolate Mousse", 9.00))
            menu.Add(New MenuItem("DESSERTS", "Chocolate Mousse", "Light and Airy Mousse set on a Biscuit topped with Whipped Mascarpone", 11.00))
            menu.Add(New MenuItem("DESSERTS", "Carrot Cake", "Exceptionally Moist with a tangy cream cheese icing", 9.00))
            menu.Add(New MenuItem("DESSERTS", "Apple Strudel", "Made in house. Apples rolled in thin Flaky Crust Sprinkled with Brown Sugar & Cinnamon served with Vanilla Bean Ice Cream", 9.00))
            menu.Add(New MenuItem("SOFT DRINKS", "Water Voss (Still or Sparkling)", String.Empty, 8.00))
            menu.Add(New MenuItem("SOFT DRINKS", "Coke, Diet Coke, Dr. Pepper", String.Empty, 4.00))
            menu.Add(New MenuItem("SOFT DRINKS", "Sprite, Lemonade", String.Empty, 4.00))
            menu.Add(New MenuItem("SOFT DRINKS", "Apple Juice, Orange Juice", String.Empty, 3.00))
            menu.Add(New MenuItem("COFFEE & TEA", "Espressso", "Our signature in house blend of several different types of coffee beans", 4, "Hot"))
            menu.Add(New MenuItem("COFFEE & TEA", "Cappuccino", "Espresso Combined with Hot Steamed Milk and topped with Steamed Milk Foam", 7, "Hot"))
            menu.Add(New MenuItem("COFFEE & TEA", "Latte", "Espresso Combined with Hot Steamed Milk", 7, "Hot"))
            menu.Add(New MenuItem("COFFEE & TEA", "Liqueur coffee", "Irish coffee, with whiskey and a layer of cream on top", 9, "Hot"))
            menu.Add(New MenuItem("COFFEE & TEA", "Speciality Tea", "We proudly serve an assortment of Harney & Sons Fine Teas", 6, "Hot"))
            menu.Add(New MenuItem("COFFEE & TEA", "Frappe", "Blended Coffee, milk, sugar and ice drink", 6, "Iced"))
            menu.Add(New MenuItem("COFFEE & TEA", "Freddo espresso", "Made with a double shot of espresso coffee mixed in a mixer with ice cubes", 6, "Iced"))
            menu.Add(New MenuItem("COFFEE & TEA", "Freddo cappuccino", "Iced version of our regular cappuccino coffee, with a small amount of cold frothed milk on top", 6, "Iced"))
            menu.Add(New MenuItem("DRINKS", "Brown Ale", String.Empty, 7, "BEER"))
            menu.Add(New MenuItem("DRINKS", "Amber Ale", String.Empty, 7, "BEER"))
            menu.Add(New MenuItem("DRINKS", "Pale Ale", String.Empty, 6, "BEER"))
            menu.Add(New MenuItem("DRINKS", "Belgian Ale", String.Empty, 6, "BEER"))
            menu.Add(New MenuItem("DRINKS", "Dunkel", String.Empty, 6, "BEER"))
            menu.Add(New MenuItem("DRINKS", "Stout", String.Empty, 6, "BEER"))
            menu.Add(New MenuItem("DRINKS", "Bacardi", String.Empty, 9, "RUM"))
            menu.Add(New MenuItem("DRINKS", "Havana Club", String.Empty, 11, "RUM"))
            menu.Add(New MenuItem("DRINKS", "Captain Morgan", String.Empty, 8, "RUM"))
            menu.Add(New MenuItem("DRINKS", "Johnnie Walker Red Label", String.Empty, 14, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Johnnie Walker Black Label ", String.Empty, 17, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Chivas Regal", String.Empty, 8, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Glenfiddich", String.Empty, 8, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Talisker", String.Empty, 7, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Ballantine’s", String.Empty, 7, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Jim Beam", String.Empty, 7, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Jack Daniels", String.Empty, 8, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Maker's Mark", String.Empty, 11, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Wild Turkey", String.Empty, 9, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Bushmills", String.Empty, 7, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Jameson", String.Empty, 8, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Tullamore Dew", String.Empty, 8, "WHISKEY"))
            menu.Add(New MenuItem("DRINKS", "Smirnoff", String.Empty, 7, "VODKA"))
            menu.Add(New MenuItem("DRINKS", "Absolut", String.Empty, 8, "VODKA"))
            menu.Add(New MenuItem("DRINKS", "Grey Goose", String.Empty, 11, "VODKA"))
            Return menu
        End Function

        Public Shared Function GetMenuData(ByVal categoryName As String) As IEnumerable(Of MenuItem)
            Return GetMenuData().Where(Function(x) Equals(x.CategoryName, categoryName)).ToList()
        End Function
    End Class

    Public Class MenuItem

        Public Property CategoryName As String

        Public Property Name As String

        Public Property Description As String

        Public Property Price As Double

        Public Property SubCategoryName As String

        Public Property IsNew As Boolean

        Public Sub New(ByVal category As String, ByVal name As String, ByVal description As String, ByVal price As Double, ByVal Optional subcategory As String = "")
            CategoryName = category
            Me.Name = name
            Me.Description = description
            Me.Price = price
            SubCategoryName = subcategory
        End Sub
    End Class
End Namespace
