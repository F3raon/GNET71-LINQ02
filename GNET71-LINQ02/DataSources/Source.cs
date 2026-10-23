using LINQ.Models;

namespace LINQ.DataSources
{
	public static class Source
	{
		public static List<Product> ProductList = new()
		{
			new Product { ProductID = 1, ProductName = "Black Tea 250g", Category = "Beverages", UnitPrice = 60.0000M, UnitsInStock = 39 },
			new Product { ProductID = 2, ProductName = "Green Tea 100g", Category = "Beverages", UnitPrice = 45.0000M, UnitsInStock = 17 },
			new Product { ProductID = 3, ProductName = "Tahini 500g", Category = "Spices & Condiments", UnitPrice = 95.0000M, UnitsInStock = 13 },
			new Product { ProductID = 4, ProductName = "Cumin Powder 200g", Category = "Spices & Condiments", UnitPrice = 45.0000M, UnitsInStock = 53 },
			new Product { ProductID = 5, ProductName = "Coriander Powder 200g", Category = "Spices & Condiments", UnitPrice = 42.5000M, UnitsInStock = 0 },
			new Product { ProductID = 6, ProductName = "Dukkah Mix 250g", Category = "Spices & Condiments", UnitPrice = 55.0000M, UnitsInStock = 120 },
			new Product { ProductID = 7, ProductName = "Dried Apricots 500g", Category = "Fruits & Vegetables", UnitPrice = 110.0000M, UnitsInStock = 15 },
			new Product { ProductID = 8, ProductName = "Pomegranate Molasses 500ml", Category = "Spices & Condiments", UnitPrice = 65.0000M, UnitsInStock = 6 },
			new Product { ProductID = 9, ProductName = "Beef Fillet 1kg", Category = "Meat & Poultry", UnitPrice = 480.0000M, UnitsInStock = 29 },
			new Product { ProductID = 10, ProductName = "Tilapia Fish 1kg", Category = "Seafood", UnitPrice = 95.0000M, UnitsInStock = 31 },
			new Product { ProductID = 11, ProductName = "Rumi Cheese 500g", Category = "Dairy & Cheese", UnitPrice = 140.0000M, UnitsInStock = 22 },
			new Product { ProductID = 12, ProductName = "White Cheese 1kg", Category = "Dairy & Cheese", UnitPrice = 120.0000M, UnitsInStock = 86 },
			new Product { ProductID = 13, ProductName = "Canned Tuna 185g", Category = "Seafood", UnitPrice = 45.0000M, UnitsInStock = 24 },
			new Product { ProductID = 14, ProductName = "Fresh Molokhia 500g", Category = "Fruits & Vegetables", UnitPrice = 18.7500M, UnitsInStock = 35 },
			new Product { ProductID = 15, ProductName = "White Vinegar 500ml", Category = "Spices & Condiments", UnitPrice = 18.5000M, UnitsInStock = 39 },
			new Product { ProductID = 16, ProductName = "Basbousa Tray 500g", Category = "Sweets & Desserts", UnitPrice = 65.0000M, UnitsInStock = 29 },
			new Product { ProductID = 17, ProductName = "Lamb Leg 1kg", Category = "Meat & Poultry", UnitPrice = 420.0000M, UnitsInStock = 0 },
			new Product { ProductID = 18, ProductName = "Jumbo Shrimp 1kg", Category = "Seafood", UnitPrice = 550.0000M, UnitsInStock = 42 },
			new Product { ProductID = 19, ProductName = "Tea Biscuits 300g", Category = "Sweets & Desserts", UnitPrice = 18.5000M, UnitsInStock = 25 },
			new Product { ProductID = 20, ProductName = "Konafa with Cream Tray 1kg", Category = "Sweets & Desserts", UnitPrice = 220.0000M, UnitsInStock = 40 },
			new Product { ProductID = 21, ProductName = "Halawa Tahiniya 500g", Category = "Sweets & Desserts", UnitPrice = 85.0000M, UnitsInStock = 3 },
			new Product { ProductID = 22, ProductName = "Egyptian Rice 1kg", Category = "Grains & Pasta", UnitPrice = 32.0000M, UnitsInStock = 104 },
			new Product { ProductID = 23, ProductName = "Freekeh 500g", Category = "Grains & Pasta", UnitPrice = 55.0000M, UnitsInStock = 61 },
			new Product { ProductID = 24, ProductName = "Orange Juice 1L", Category = "Beverages", UnitPrice = 35.0000M, UnitsInStock = 20 },
			new Product { ProductID = 25, ProductName = "Chocolate Hazelnut Spread 350g", Category = "Sweets & Desserts", UnitPrice = 75.0000M, UnitsInStock = 76 },
			new Product { ProductID = 26, ProductName = "Jelly Candy 500g", Category = "Sweets & Desserts", UnitPrice = 48.5000M, UnitsInStock = 15 },
			new Product { ProductID = 27, ProductName = "Milk Chocolate Bar 200g", Category = "Sweets & Desserts", UnitPrice = 55.0000M, UnitsInStock = 49 },
			new Product { ProductID = 28, ProductName = "Pickled Cucumbers 1kg", Category = "Fruits & Vegetables", UnitPrice = 39.5000M, UnitsInStock = 26 },
			new Product { ProductID = 29, ProductName = "Beef Sausage 500g", Category = "Meat & Poultry", UnitPrice = 129.7500M, UnitsInStock = 0 },
			new Product { ProductID = 30, ProductName = "Smoked Herring 500g", Category = "Seafood", UnitPrice = 85.5000M, UnitsInStock = 10 },
			new Product { ProductID = 31, ProductName = "Mish Cheese 500g", Category = "Dairy & Cheese", UnitPrice = 65.0000M, UnitsInStock = 0 },
			new Product { ProductID = 32, ProductName = "Cream Cheese 500g", Category = "Dairy & Cheese", UnitPrice = 85.0000M, UnitsInStock = 9 },
			new Product { ProductID = 33, ProductName = "Full Cream Milk 1L", Category = "Dairy & Cheese", UnitPrice = 32.0000M, UnitsInStock = 112 },
			new Product { ProductID = 34, ProductName = "Hibiscus Drink 1L", Category = "Beverages", UnitPrice = 30.0000M, UnitsInStock = 111 },
			new Product { ProductID = 35, ProductName = "Mango Juice 1L", Category = "Beverages", UnitPrice = 35.0000M, UnitsInStock = 20 },
			new Product { ProductID = 36, ProductName = "Salted Mullet (Fesikh) 1kg", Category = "Seafood", UnitPrice = 180.0000M, UnitsInStock = 112 },
			new Product { ProductID = 37, ProductName = "Frozen Salmon Fillet 500g", Category = "Seafood", UnitPrice = 320.0000M, UnitsInStock = 11 },
			new Product { ProductID = 38, ProductName = "Turkish Coffee 500g", Category = "Beverages", UnitPrice = 265.5000M, UnitsInStock = 17 },
			new Product { ProductID = 39, ProductName = "Mint Tea Bags 25 pcs", Category = "Beverages", UnitPrice = 60.0000M, UnitsInStock = 69 },
			new Product { ProductID = 40, ProductName = "Crab Meat 250g", Category = "Seafood", UnitPrice = 210.0000M, UnitsInStock = 123 },
			new Product { ProductID = 41, ProductName = "Canned Sardines 125g", Category = "Seafood", UnitPrice = 22.5000M, UnitsInStock = 85 },
			new Product { ProductID = 42, ProductName = "Vermicelli 400g", Category = "Grains & Pasta", UnitPrice = 15.5000M, UnitsInStock = 26 },
			new Product { ProductID = 43, ProductName = "Instant Coffee 200g", Category = "Beverages", UnitPrice = 140.0000M, UnitsInStock = 17 },
			new Product { ProductID = 44, ProductName = "Black Honey 500g", Category = "Spices & Condiments", UnitPrice = 85.0000M, UnitsInStock = 27 },
			new Product { ProductID = 45, ProductName = "Canned Mackerel 155g", Category = "Seafood", UnitPrice = 28.7500M, UnitsInStock = 5 },
			new Product { ProductID = 46, ProductName = "Frozen Calamari 500g", Category = "Seafood", UnitPrice = 155.0000M, UnitsInStock = 95 },
			new Product { ProductID = 47, ProductName = "Ghorayeba Cookies 500g", Category = "Sweets & Desserts", UnitPrice = 90.0000M, UnitsInStock = 36 },
			new Product { ProductID = 48, ProductName = "Dark Chocolate 100g", Category = "Sweets & Desserts", UnitPrice = 28.7500M, UnitsInStock = 15 },
			new Product { ProductID = 49, ProductName = "Petit Four Biscuits 400g", Category = "Sweets & Desserts", UnitPrice = 60.0000M, UnitsInStock = 10 },
			new Product { ProductID = 50, ProductName = "White Chocolate Bar 100g", Category = "Sweets & Desserts", UnitPrice = 32.2500M, UnitsInStock = 65 },
			new Product { ProductID = 51, ProductName = "Dried Figs 500g", Category = "Fruits & Vegetables", UnitPrice = 135.0000M, UnitsInStock = 20 },
			new Product { ProductID = 52, ProductName = "Koshary Mix 500g", Category = "Grains & Pasta", UnitPrice = 32.5000M, UnitsInStock = 38 },
			new Product { ProductID = 53, ProductName = "Frozen Chicken Liver 1kg", Category = "Meat & Poultry", UnitPrice = 95.5000M, UnitsInStock = 0 },
			new Product { ProductID = 54, ProductName = "Chicken Mortadella 250g", Category = "Meat & Poultry", UnitPrice = 45.0000M, UnitsInStock = 21 },
			new Product { ProductID = 55, ProductName = "Ground Beef 1kg", Category = "Meat & Poultry", UnitPrice = 290.0000M, UnitsInStock = 115 },
			new Product { ProductID = 56, ProductName = "Spaghetti 400g", Category = "Grains & Pasta", UnitPrice = 14.5000M, UnitsInStock = 21 },
			new Product { ProductID = 57, ProductName = "Red Lentils 1kg", Category = "Grains & Pasta", UnitPrice = 60.0000M, UnitsInStock = 36 },
			new Product { ProductID = 58, ProductName = "Frozen Fish Fillet 1kg", Category = "Seafood", UnitPrice = 130.0000M, UnitsInStock = 62 },
			new Product { ProductID = 59, ProductName = "Kashkaval Cheese 500g", Category = "Dairy & Cheese", UnitPrice = 155.0000M, UnitsInStock = 79 },
			new Product { ProductID = 60, ProductName = "Processed Cheese Triangles 8 pcs", Category = "Dairy & Cheese", UnitPrice = 40.0000M, UnitsInStock = 19 },
			new Product { ProductID = 61, ProductName = "Date Molasses 500ml", Category = "Spices & Condiments", UnitPrice = 60.0000M, UnitsInStock = 113 },
			new Product { ProductID = 62, ProductName = "Assorted Baklava 1kg", Category = "Sweets & Desserts", UnitPrice = 350.0000M, UnitsInStock = 17 },
			new Product { ProductID = 63, ProductName = "Tomato Paste 400g", Category = "Spices & Condiments", UnitPrice = 24.7500M, UnitsInStock = 24 },
			new Product { ProductID = 64, ProductName = "Bulgur Wheat 1kg", Category = "Grains & Pasta", UnitPrice = 42.5000M, UnitsInStock = 22 },
			new Product { ProductID = 65, ProductName = "Hot Chili Sauce 250ml", Category = "Spices & Condiments", UnitPrice = 27.2500M, UnitsInStock = 76 },
			new Product { ProductID = 66, ProductName = "Pickled Turnips 700g", Category = "Spices & Condiments", UnitPrice = 38.0000M, UnitsInStock = 4 },
			new Product { ProductID = 67, ProductName = "Mineral Water 1.5L", Category = "Beverages", UnitPrice = 30.0000M, UnitsInStock = 52 },
			new Product { ProductID = 68, ProductName = "Date Maamoul 500g", Category = "Sweets & Desserts", UnitPrice = 75.0000M, UnitsInStock = 6 },
			new Product { ProductID = 69, ProductName = "Natural Yogurt 1kg", Category = "Dairy & Cheese", UnitPrice = 48.0000M, UnitsInStock = 26 },
			new Product { ProductID = 70, ProductName = "Guava Juice 1L", Category = "Beverages", UnitPrice = 32.0000M, UnitsInStock = 15 },
			new Product { ProductID = 71, ProductName = "Butter 250g", Category = "Dairy & Cheese", UnitPrice = 90.0000M, UnitsInStock = 26 },
			new Product { ProductID = 72, ProductName = "Mozzarella Cheese 500g", Category = "Dairy & Cheese", UnitPrice = 132.5000M, UnitsInStock = 14 },
			new Product { ProductID = 73, ProductName = "Fish Roe (Batarekh) 100g", Category = "Seafood", UnitPrice = 350.0000M, UnitsInStock = 101 },
			new Product { ProductID = 74, ProductName = "Dried Dates 1kg", Category = "Fruits & Vegetables", UnitPrice = 95.0000M, UnitsInStock = 4 },
			new Product { ProductID = 75, ProductName = "Cola Drink 1L", Category = "Beverages", UnitPrice = 15.5000M, UnitsInStock = 125 },
			new Product { ProductID = 76, ProductName = "Instant Sahlab Drink 200g", Category = "Beverages", UnitPrice = 60.0000M, UnitsInStock = 57 },
			new Product { ProductID = 77, ProductName = "Tomato Ketchup 500g", Category = "Spices & Condiments", UnitPrice = 32.0000M, UnitsInStock = 32 }
		};

		public static List<Customer> CustomerList = new()
		{
			new Customer
			{
				CustomerID = "CUS-001",
				CustomerName = "Ahmed Mahmoud",
				Address = "15 Abbas El Akkad St., Nasr City",
				City = "Cairo",
				Region = "",
				PostalCode = "11765",
				Country = "Egypt",
				Phone = "010-21456789",
				Orders = new Order[]
				{
					new() { OrderID = 10643, OrderDate = new DateTime(1997, 8, 25), Total = 814.50m },
					new() { OrderID = 10692, OrderDate = new DateTime(1997, 10, 3), Total = 878.00m },
					new() { OrderID = 10702, OrderDate = new DateTime(1997, 10, 13), Total = 330.00m },
					new() { OrderID = 10835, OrderDate = new DateTime(1998, 1, 15), Total = 845.80m },
					new() { OrderID = 10952, OrderDate = new DateTime(1998, 3, 16), Total = 471.20m },
					new() { OrderID = 11011, OrderDate = new DateTime(1998, 4, 9), Total = 933.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-002",
				CustomerName = "Mohamed Salah",
				Address = "24 El Tahrir St., Dokki",
				City = "Giza",
				Region = "",
				PostalCode = "12611",
				Country = "Egypt",
				Phone = "011-30567812",
				Orders = new Order[]
				{
					new() { OrderID = 10308, OrderDate = new DateTime(1996, 9, 18), Total = 88.80m },
					new() { OrderID = 10625, OrderDate = new DateTime(1997, 8, 8), Total = 479.75m },
					new() { OrderID = 10759, OrderDate = new DateTime(1997, 11, 28), Total = 320.00m },
					new() { OrderID = 10926, OrderDate = new DateTime(1998, 3, 4), Total = 514.40m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-003",
				CustomerName = "Mahmoud Hassan",
				Address = "8 Saad Zaghloul St., Raml Station",
				City = "Alexandria",
				Region = "",
				PostalCode = "21519",
				Country = "Egypt",
				Phone = "012-24378965",
				Orders = new Order[]
				{
					new() { OrderID = 10365, OrderDate = new DateTime(1996, 11, 27), Total = 403.20m },
					new() { OrderID = 10507, OrderDate = new DateTime(1997, 4, 15), Total = 749.06m },
					new() { OrderID = 10535, OrderDate = new DateTime(1997, 5, 13), Total = 1940.85m },
					new() { OrderID = 10573, OrderDate = new DateTime(1997, 6, 19), Total = 2082.00m },
					new() { OrderID = 10677, OrderDate = new DateTime(1997, 9, 22), Total = 813.36m },
					new() { OrderID = 10682, OrderDate = new DateTime(1997, 9, 25), Total = 375.50m },
					new() { OrderID = 10856, OrderDate = new DateTime(1998, 1, 28), Total = 660.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-004",
				CustomerName = "Mostafa Ibrahim",
				Address = "42 Road 9, Maadi",
				City = "Cairo",
				Region = "",
				PostalCode = "11431",
				Country = "Egypt",
				Phone = "015-35789012",
				Orders = new Order[]
				{
					new() { OrderID = 10355, OrderDate = new DateTime(1996, 11, 15), Total = 480.00m },
					new() { OrderID = 10383, OrderDate = new DateTime(1996, 12, 16), Total = 899.00m },
					new() { OrderID = 10453, OrderDate = new DateTime(1997, 2, 21), Total = 407.70m },
					new() { OrderID = 10558, OrderDate = new DateTime(1997, 6, 4), Total = 2142.90m },
					new() { OrderID = 10707, OrderDate = new DateTime(1997, 10, 16), Total = 1641.00m },
					new() { OrderID = 10741, OrderDate = new DateTime(1997, 11, 14), Total = 228.00m },
					new() { OrderID = 10743, OrderDate = new DateTime(1997, 11, 17), Total = 319.20m },
					new() { OrderID = 10768, OrderDate = new DateTime(1997, 12, 8), Total = 1477.00m },
					new() { OrderID = 10793, OrderDate = new DateTime(1997, 12, 24), Total = 191.10m },
					new() { OrderID = 10864, OrderDate = new DateTime(1998, 2, 2), Total = 282.00m },
					new() { OrderID = 10920, OrderDate = new DateTime(1998, 3, 3), Total = 390.00m },
					new() { OrderID = 10953, OrderDate = new DateTime(1998, 3, 16), Total = 4441.25m },
					new() { OrderID = 11016, OrderDate = new DateTime(1998, 4, 10), Total = 491.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-005",
				CustomerName = "Omar Khaled",
				Address = "17 El Gomhoreya St.",
				City = "Mansoura",
				Region = "Dakahlia",
				PostalCode = "35511",
				Country = "Egypt",
				Phone = "010-46890123",
				Orders = new Order[]
				{
					new() { OrderID = 10278, OrderDate = new DateTime(1996, 8, 12), Total = 1488.80m },
					new() { OrderID = 10280, OrderDate = new DateTime(1996, 8, 14), Total = 613.20m },
					new() { OrderID = 10384, OrderDate = new DateTime(1996, 12, 16), Total = 2222.40m },
					new() { OrderID = 10444, OrderDate = new DateTime(1997, 2, 12), Total = 1031.70m },
					new() { OrderID = 10445, OrderDate = new DateTime(1997, 2, 13), Total = 174.90m },
					new() { OrderID = 10524, OrderDate = new DateTime(1997, 5, 1), Total = 3192.65m },
					new() { OrderID = 10572, OrderDate = new DateTime(1997, 6, 18), Total = 1501.08m },
					new() { OrderID = 10626, OrderDate = new DateTime(1997, 8, 11), Total = 1503.60m },
					new() { OrderID = 10654, OrderDate = new DateTime(1997, 9, 2), Total = 601.83m },
					new() { OrderID = 10672, OrderDate = new DateTime(1997, 9, 17), Total = 3815.25m },
					new() { OrderID = 10689, OrderDate = new DateTime(1997, 10, 1), Total = 472.50m },
					new() { OrderID = 10733, OrderDate = new DateTime(1997, 11, 7), Total = 1459.00m },
					new() { OrderID = 10778, OrderDate = new DateTime(1997, 12, 16), Total = 96.50m },
					new() { OrderID = 10837, OrderDate = new DateTime(1998, 1, 16), Total = 1064.50m },
					new() { OrderID = 10857, OrderDate = new DateTime(1998, 1, 28), Total = 2048.21m },
					new() { OrderID = 10866, OrderDate = new DateTime(1998, 2, 3), Total = 1096.20m },
					new() { OrderID = 10875, OrderDate = new DateTime(1998, 2, 6), Total = 709.55m },
					new() { OrderID = 10924, OrderDate = new DateTime(1998, 3, 4), Total = 1835.70m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-006",
				CustomerName = "Khaled Youssef",
				Address = "63 Mostafa El Nahas St., Nasr City",
				City = "Cairo",
				Region = "",
				PostalCode = "11765",
				Country = "Egypt",
				Phone = "011-57901234",
				Orders = new Order[]
				{
					new() { OrderID = 10501, OrderDate = new DateTime(1997, 4, 9), Total = 149.00m },
					new() { OrderID = 10509, OrderDate = new DateTime(1997, 4, 17), Total = 136.80m },
					new() { OrderID = 10582, OrderDate = new DateTime(1997, 6, 27), Total = 330.00m },
					new() { OrderID = 10614, OrderDate = new DateTime(1997, 7, 29), Total = 464.00m },
					new() { OrderID = 10853, OrderDate = new DateTime(1998, 1, 27), Total = 625.00m },
					new() { OrderID = 10956, OrderDate = new DateTime(1998, 3, 17), Total = 677.00m },
					new() { OrderID = 11058, OrderDate = new DateTime(1998, 4, 29), Total = 858.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-007",
				CustomerName = "Youssef Adel",
				Address = "5 El Bahr St.",
				City = "Tanta",
				Region = "Gharbia",
				PostalCode = "31511",
				Country = "Egypt",
				Phone = "012-68012345",
				Orders = new Order[]
				{
					new() { OrderID = 10265, OrderDate = new DateTime(1996, 7, 25), Total = 1176.00m },
					new() { OrderID = 10297, OrderDate = new DateTime(1996, 9, 4), Total = 1420.00m },
					new() { OrderID = 10360, OrderDate = new DateTime(1996, 11, 22), Total = 7390.20m },
					new() { OrderID = 10436, OrderDate = new DateTime(1997, 2, 5), Total = 1994.52m },
					new() { OrderID = 10449, OrderDate = new DateTime(1997, 2, 18), Total = 1838.20m },
					new() { OrderID = 10559, OrderDate = new DateTime(1997, 6, 5), Total = 520.41m },
					new() { OrderID = 10566, OrderDate = new DateTime(1997, 6, 12), Total = 1761.00m },
					new() { OrderID = 10584, OrderDate = new DateTime(1997, 6, 30), Total = 593.75m },
					new() { OrderID = 10628, OrderDate = new DateTime(1997, 8, 12), Total = 450.00m },
					new() { OrderID = 10679, OrderDate = new DateTime(1997, 9, 23), Total = 660.00m },
					new() { OrderID = 10826, OrderDate = new DateTime(1998, 1, 12), Total = 730.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-008",
				CustomerName = "Ali Hamdy",
				Address = "31 Faisal St., Haram",
				City = "Giza",
				Region = "",
				PostalCode = "12511",
				Country = "Egypt",
				Phone = "015-79123456",
				Orders = new Order[]
				{
					new() { OrderID = 10326, OrderDate = new DateTime(1996, 10, 10), Total = 982.00m },
					new() { OrderID = 10801, OrderDate = new DateTime(1997, 12, 29), Total = 3026.85m },
					new() { OrderID = 10970, OrderDate = new DateTime(1998, 3, 24), Total = 224.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-009",
				CustomerName = "Hassan Fathy",
				Address = "56 El Corniche Rd., Sidi Bishr",
				City = "Alexandria",
				Region = "",
				PostalCode = "21411",
				Country = "Egypt",
				Phone = "010-80234567",
				Orders = new Order[]
				{
					new() { OrderID = 10331, OrderDate = new DateTime(1996, 10, 16), Total = 88.50m },
					new() { OrderID = 10340, OrderDate = new DateTime(1996, 10, 29), Total = 2436.18m },
					new() { OrderID = 10362, OrderDate = new DateTime(1996, 11, 25), Total = 1549.60m },
					new() { OrderID = 10470, OrderDate = new DateTime(1997, 3, 11), Total = 1820.80m },
					new() { OrderID = 10511, OrderDate = new DateTime(1997, 4, 18), Total = 2550.00m },
					new() { OrderID = 10525, OrderDate = new DateTime(1997, 5, 2), Total = 818.40m },
					new() { OrderID = 10663, OrderDate = new DateTime(1997, 9, 10), Total = 1930.40m },
					new() { OrderID = 10715, OrderDate = new DateTime(1997, 10, 23), Total = 1296.00m },
					new() { OrderID = 10730, OrderDate = new DateTime(1997, 11, 5), Total = 484.26m },
					new() { OrderID = 10732, OrderDate = new DateTime(1997, 11, 6), Total = 360.00m },
					new() { OrderID = 10755, OrderDate = new DateTime(1997, 11, 26), Total = 1948.50m },
					new() { OrderID = 10827, OrderDate = new DateTime(1998, 1, 12), Total = 843.00m },
					new() { OrderID = 10871, OrderDate = new DateTime(1998, 2, 5), Total = 1979.23m },
					new() { OrderID = 10876, OrderDate = new DateTime(1998, 2, 9), Total = 917.00m },
					new() { OrderID = 10932, OrderDate = new DateTime(1998, 3, 6), Total = 1788.63m },
					new() { OrderID = 10940, OrderDate = new DateTime(1998, 3, 11), Total = 360.00m },
					new() { OrderID = 11076, OrderDate = new DateTime(1998, 5, 6), Total = 792.75m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-010",
				CustomerName = "Ibrahim Saeed",
				Address = "12 Ahmed Orabi St., Heliopolis",
				City = "Cairo",
				Region = "",
				PostalCode = "11341",
				Country = "Egypt",
				Phone = "011-91345678",
				Orders = new Order[]
				{
					new() { OrderID = 10389, OrderDate = new DateTime(1996, 12, 20), Total = 1832.80m },
					new() { OrderID = 10410, OrderDate = new DateTime(1997, 1, 10), Total = 802.00m },
					new() { OrderID = 10411, OrderDate = new DateTime(1997, 1, 10), Total = 966.80m },
					new() { OrderID = 10431, OrderDate = new DateTime(1997, 1, 30), Total = 1892.25m },
					new() { OrderID = 10492, OrderDate = new DateTime(1997, 4, 1), Total = 851.20m },
					new() { OrderID = 10742, OrderDate = new DateTime(1997, 11, 14), Total = 3118.00m },
					new() { OrderID = 10918, OrderDate = new DateTime(1998, 3, 2), Total = 1447.50m },
					new() { OrderID = 10944, OrderDate = new DateTime(1998, 3, 12), Total = 1025.32m },
					new() { OrderID = 10949, OrderDate = new DateTime(1998, 3, 13), Total = 4422.00m },
					new() { OrderID = 10975, OrderDate = new DateTime(1998, 3, 25), Total = 717.50m },
					new() { OrderID = 10982, OrderDate = new DateTime(1998, 3, 27), Total = 1014.00m },
					new() { OrderID = 11027, OrderDate = new DateTime(1998, 4, 16), Total = 877.72m },
					new() { OrderID = 11045, OrderDate = new DateTime(1998, 4, 23), Total = 1309.50m },
					new() { OrderID = 11048, OrderDate = new DateTime(1998, 4, 24), Total = 525.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-011",
				CustomerName = "Tarek Nabil",
				Address = "9 Palestine St.",
				City = "Port Said",
				Region = "Port Said",
				PostalCode = "42511",
				Country = "Egypt",
				Phone = "012-02456789",
				Orders = new Order[]
				{
					new() { OrderID = 10289, OrderDate = new DateTime(1996, 8, 26), Total = 479.40m },
					new() { OrderID = 10471, OrderDate = new DateTime(1997, 3, 11), Total = 1328.00m },
					new() { OrderID = 10484, OrderDate = new DateTime(1997, 3, 24), Total = 386.20m },
					new() { OrderID = 10538, OrderDate = new DateTime(1997, 5, 15), Total = 139.80m },
					new() { OrderID = 10539, OrderDate = new DateTime(1997, 5, 16), Total = 355.50m },
					new() { OrderID = 10578, OrderDate = new DateTime(1997, 6, 24), Total = 477.00m },
					new() { OrderID = 10599, OrderDate = new DateTime(1997, 7, 15), Total = 493.00m },
					new() { OrderID = 10943, OrderDate = new DateTime(1998, 3, 11), Total = 711.00m },
					new() { OrderID = 10947, OrderDate = new DateTime(1998, 3, 13), Total = 220.00m },
					new() { OrderID = 11023, OrderDate = new DateTime(1998, 4, 14), Total = 1500.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-012",
				CustomerName = "Hesham Samir",
				Address = "27 Saad Zaghloul St.",
				City = "Zagazig",
				Region = "Sharqia",
				PostalCode = "44511",
				Country = "Egypt",
				Phone = "015-13567890",
				Orders = new Order[]
				{
					new() { OrderID = 10521, OrderDate = new DateTime(1997, 4, 29), Total = 225.50m },
					new() { OrderID = 10782, OrderDate = new DateTime(1997, 12, 17), Total = 12.50m },
					new() { OrderID = 10819, OrderDate = new DateTime(1998, 1, 7), Total = 477.00m },
					new() { OrderID = 10881, OrderDate = new DateTime(1998, 2, 11), Total = 150.00m },
					new() { OrderID = 10937, OrderDate = new DateTime(1998, 3, 10), Total = 644.80m },
					new() { OrderID = 11054, OrderDate = new DateTime(1998, 4, 28), Total = 305.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-013",
				CustomerName = "Amr Ashraf",
				Address = "14 El Galaa St.",
				City = "Suez",
				Region = "Suez",
				PostalCode = "43511",
				Country = "Egypt",
				Phone = "010-24678901",
				Orders = new Order[]
				{
					new() { OrderID = 10259, OrderDate = new DateTime(1996, 7, 18), Total = 100.80m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-014",
				CustomerName = "Karim Waleed",
				Address = "88 El Nozha St., Heliopolis",
				City = "Cairo",
				Region = "",
				PostalCode = "11341",
				Country = "Egypt",
				Phone = "011-35789023",
				Orders = new Order[]
				{
					new() { OrderID = 10254, OrderDate = new DateTime(1996, 7, 11), Total = 556.62m },
					new() { OrderID = 10370, OrderDate = new DateTime(1996, 12, 3), Total = 1117.60m },
					new() { OrderID = 10519, OrderDate = new DateTime(1997, 4, 28), Total = 2314.20m },
					new() { OrderID = 10731, OrderDate = new DateTime(1997, 11, 6), Total = 1890.50m },
					new() { OrderID = 10746, OrderDate = new DateTime(1997, 11, 19), Total = 2311.70m },
					new() { OrderID = 10966, OrderDate = new DateTime(1998, 3, 20), Total = 1098.46m },
					new() { OrderID = 11029, OrderDate = new DateTime(1998, 4, 16), Total = 1286.80m },
					new() { OrderID = 11041, OrderDate = new DateTime(1998, 4, 22), Total = 1773.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-015",
				CustomerName = "Sherif Magdy",
				Address = "6 Sultan Hussein St.",
				City = "Ismailia",
				Region = "Ismailia",
				PostalCode = "41511",
				Country = "Egypt",
				Phone = "012-46890134",
				Orders = new Order[]
				{
					new() { OrderID = 10290, OrderDate = new DateTime(1996, 8, 27), Total = 2169.00m },
					new() { OrderID = 10466, OrderDate = new DateTime(1997, 3, 6), Total = 216.00m },
					new() { OrderID = 10494, OrderDate = new DateTime(1997, 4, 2), Total = 912.00m },
					new() { OrderID = 10969, OrderDate = new DateTime(1998, 3, 23), Total = 108.00m },
					new() { OrderID = 11042, OrderDate = new DateTime(1998, 4, 22), Total = 405.75m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-016",
				CustomerName = "Walid Ramadan",
				Address = "19 El Mohandessin St., Mohandessin",
				City = "Giza",
				Region = "",
				PostalCode = "12611",
				Country = "Egypt",
				Phone = "015-57901245",
				Orders = new Order[]
				{
					new() { OrderID = 10435, OrderDate = new DateTime(1997, 2, 4), Total = 631.60m },
					new() { OrderID = 10462, OrderDate = new DateTime(1997, 3, 3), Total = 156.00m },
					new() { OrderID = 10848, OrderDate = new DateTime(1998, 1, 23), Total = 931.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-017",
				CustomerName = "Yasser Abdelrahman",
				Address = "33 El Nasr St.",
				City = "Assiut",
				Region = "Assiut",
				PostalCode = "71511",
				Country = "Egypt",
				Phone = "010-68012356",
				Orders = new Order[]
				{
					new() { OrderID = 10363, OrderDate = new DateTime(1996, 11, 26), Total = 447.20m },
					new() { OrderID = 10391, OrderDate = new DateTime(1996, 12, 23), Total = 86.40m },
					new() { OrderID = 10797, OrderDate = new DateTime(1997, 12, 25), Total = 420.00m },
					new() { OrderID = 10825, OrderDate = new DateTime(1998, 1, 9), Total = 1030.76m },
					new() { OrderID = 11036, OrderDate = new DateTime(1998, 4, 20), Total = 1692.00m },
					new() { OrderID = 11067, OrderDate = new DateTime(1998, 5, 4), Total = 86.85m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-018",
				CustomerName = "Hany Shawky",
				Address = "72 Port Said St., Sporting",
				City = "Alexandria",
				Region = "",
				PostalCode = "21500",
				Country = "Egypt",
				Phone = "011-79123467",
				Orders = new Order[]
				{
					new() { OrderID = 10311, OrderDate = new DateTime(1996, 9, 20), Total = 268.80m },
					new() { OrderID = 10609, OrderDate = new DateTime(1997, 7, 24), Total = 424.00m },
					new() { OrderID = 10683, OrderDate = new DateTime(1997, 9, 26), Total = 63.00m },
					new() { OrderID = 10890, OrderDate = new DateTime(1998, 2, 16), Total = 860.10m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-019",
				CustomerName = "Ashraf Gamal",
				Address = "21 Road 82, Maadi",
				City = "Cairo",
				Region = "",
				PostalCode = "11431",
				Country = "Egypt",
				Phone = "012-80234578",
				Orders = new Order[]
				{
					new() { OrderID = 10364, OrderDate = new DateTime(1996, 11, 26), Total = 950.00m },
					new() { OrderID = 10400, OrderDate = new DateTime(1997, 1, 1), Total = 3063.00m },
					new() { OrderID = 10532, OrderDate = new DateTime(1997, 5, 9), Total = 796.35m },
					new() { OrderID = 10726, OrderDate = new DateTime(1997, 11, 3), Total = 655.00m },
					new() { OrderID = 10987, OrderDate = new DateTime(1998, 3, 31), Total = 2772.00m },
					new() { OrderID = 11024, OrderDate = new DateTime(1998, 4, 15), Total = 1966.81m },
					new() { OrderID = 11047, OrderDate = new DateTime(1998, 4, 24), Total = 817.88m },
					new() { OrderID = 11056, OrderDate = new DateTime(1998, 4, 28), Total = 3740.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-020",
				CustomerName = "Sameh Farouk",
				Address = "4 Karnak St.",
				City = "Luxor",
				Region = "Luxor",
				PostalCode = "85511",
				Country = "Egypt",
				Phone = "010-91345689",
				Orders = new Order[]
				{
					new() { OrderID = 10258, OrderDate = new DateTime(1996, 7, 17), Total = 1614.88m },
					new() { OrderID = 10263, OrderDate = new DateTime(1996, 7, 23), Total = 1873.80m },
					new() { OrderID = 10351, OrderDate = new DateTime(1996, 11, 11), Total = 5398.72m },
					new() { OrderID = 10368, OrderDate = new DateTime(1996, 11, 29), Total = 1689.78m },
					new() { OrderID = 10382, OrderDate = new DateTime(1996, 12, 13), Total = 2900.00m },
					new() { OrderID = 10390, OrderDate = new DateTime(1996, 12, 23), Total = 2090.88m },
					new() { OrderID = 10402, OrderDate = new DateTime(1997, 1, 2), Total = 2713.50m },
					new() { OrderID = 10403, OrderDate = new DateTime(1997, 1, 3), Total = 855.02m },
					new() { OrderID = 10430, OrderDate = new DateTime(1997, 1, 30), Total = 4899.20m },
					new() { OrderID = 10442, OrderDate = new DateTime(1997, 2, 11), Total = 1792.00m },
					new() { OrderID = 10514, OrderDate = new DateTime(1997, 4, 22), Total = 8623.45m },
					new() { OrderID = 10571, OrderDate = new DateTime(1997, 6, 17), Total = 550.59m },
					new() { OrderID = 10595, OrderDate = new DateTime(1997, 7, 10), Total = 4725.00m },
					new() { OrderID = 10633, OrderDate = new DateTime(1997, 8, 15), Total = 5510.59m },
					new() { OrderID = 10667, OrderDate = new DateTime(1997, 9, 12), Total = 1536.80m },
					new() { OrderID = 10698, OrderDate = new DateTime(1997, 10, 9), Total = 3436.44m },
					new() { OrderID = 10764, OrderDate = new DateTime(1997, 12, 3), Total = 2286.00m },
					new() { OrderID = 10771, OrderDate = new DateTime(1997, 12, 10), Total = 344.00m },
					new() { OrderID = 10773, OrderDate = new DateTime(1997, 12, 11), Total = 2030.40m },
					new() { OrderID = 10776, OrderDate = new DateTime(1997, 12, 15), Total = 6635.28m },
					new() { OrderID = 10795, OrderDate = new DateTime(1997, 12, 24), Total = 2158.00m },
					new() { OrderID = 10836, OrderDate = new DateTime(1998, 1, 16), Total = 4705.50m },
					new() { OrderID = 10854, OrderDate = new DateTime(1998, 1, 27), Total = 2966.50m },
					new() { OrderID = 10895, OrderDate = new DateTime(1998, 2, 18), Total = 6379.40m },
					new() { OrderID = 10968, OrderDate = new DateTime(1998, 3, 23), Total = 1408.00m },
					new() { OrderID = 10979, OrderDate = new DateTime(1998, 3, 26), Total = 4813.50m },
					new() { OrderID = 10990, OrderDate = new DateTime(1998, 4, 1), Total = 4288.85m },
					new() { OrderID = 11008, OrderDate = new DateTime(1998, 4, 8), Total = 4680.90m },
					new() { OrderID = 11017, OrderDate = new DateTime(1998, 4, 13), Total = 6750.00m },
					new() { OrderID = 11072, OrderDate = new DateTime(1998, 5, 5), Total = 5218.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-021",
				CustomerName = "Adel Mansour",
				Address = "10 El Corniche St.",
				City = "Aswan",
				Region = "Aswan",
				PostalCode = "81511",
				Country = "Egypt",
				Phone = "011-02456790",
				Orders = new Order[]
				{
					new() { OrderID = 10347, OrderDate = new DateTime(1996, 11, 6), Total = 814.42m },
					new() { OrderID = 10386, OrderDate = new DateTime(1996, 12, 18), Total = 166.00m },
					new() { OrderID = 10414, OrderDate = new DateTime(1997, 1, 14), Total = 224.83m },
					new() { OrderID = 10512, OrderDate = new DateTime(1997, 4, 21), Total = 525.30m },
					new() { OrderID = 10581, OrderDate = new DateTime(1997, 6, 26), Total = 310.00m },
					new() { OrderID = 10650, OrderDate = new DateTime(1997, 8, 29), Total = 1779.20m },
					new() { OrderID = 10725, OrderDate = new DateTime(1997, 10, 31), Total = 287.80m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-022",
				CustomerName = "Essam Zaki",
				Address = "45 El Hegaz St., Heliopolis",
				City = "Cairo",
				Region = "",
				PostalCode = "11341",
				Country = "Egypt",
				Phone = "012-13567801",
				Orders = new Order[]
				{
				}
			},
			new Customer
			{
				CustomerID = "CUS-023",
				CustomerName = "Nader Fouad",
				Address = "3 El Thawra St.",
				City = "Damietta",
				Region = "Damietta",
				PostalCode = "34511",
				Country = "Egypt",
				Phone = "015-24678912",
				Orders = new Order[]
				{
					new() { OrderID = 10408, OrderDate = new DateTime(1997, 1, 8), Total = 1622.40m },
					new() { OrderID = 10480, OrderDate = new DateTime(1997, 3, 20), Total = 756.00m },
					new() { OrderID = 10634, OrderDate = new DateTime(1997, 8, 15), Total = 4985.50m },
					new() { OrderID = 10763, OrderDate = new DateTime(1997, 12, 3), Total = 616.00m },
					new() { OrderID = 10789, OrderDate = new DateTime(1997, 12, 22), Total = 3687.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-024",
				CustomerName = "Hossam Anwar",
				Address = "16 Lebanon Sq., Mohandessin",
				City = "Giza",
				Region = "",
				PostalCode = "12611",
				Country = "Egypt",
				Phone = "010-35789034",
				Orders = new Order[]
				{
					new() { OrderID = 10264, OrderDate = new DateTime(1996, 7, 24), Total = 695.62m },
					new() { OrderID = 10327, OrderDate = new DateTime(1996, 10, 11), Total = 1810.00m },
					new() { OrderID = 10378, OrderDate = new DateTime(1996, 12, 10), Total = 103.20m },
					new() { OrderID = 10434, OrderDate = new DateTime(1997, 2, 3), Total = 321.12m },
					new() { OrderID = 10460, OrderDate = new DateTime(1997, 2, 28), Total = 176.10m },
					new() { OrderID = 10533, OrderDate = new DateTime(1997, 5, 12), Total = 2222.20m },
					new() { OrderID = 10561, OrderDate = new DateTime(1997, 6, 6), Total = 2844.50m },
					new() { OrderID = 10703, OrderDate = new DateTime(1997, 10, 14), Total = 2545.00m },
					new() { OrderID = 10762, OrderDate = new DateTime(1997, 12, 2), Total = 4337.00m },
					new() { OrderID = 10774, OrderDate = new DateTime(1997, 12, 11), Total = 868.75m },
					new() { OrderID = 10824, OrderDate = new DateTime(1998, 1, 9), Total = 250.80m },
					new() { OrderID = 10880, OrderDate = new DateTime(1998, 2, 10), Total = 1500.00m },
					new() { OrderID = 10902, OrderDate = new DateTime(1998, 2, 23), Total = 863.43m },
					new() { OrderID = 10955, OrderDate = new DateTime(1998, 3, 17), Total = 74.40m },
					new() { OrderID = 10977, OrderDate = new DateTime(1998, 3, 26), Total = 2233.00m },
					new() { OrderID = 10980, OrderDate = new DateTime(1998, 3, 27), Total = 248.00m },
					new() { OrderID = 10993, OrderDate = new DateTime(1998, 4, 1), Total = 4895.44m },
					new() { OrderID = 11001, OrderDate = new DateTime(1998, 4, 6), Total = 2769.00m },
					new() { OrderID = 11050, OrderDate = new DateTime(1998, 4, 27), Total = 810.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-025",
				CustomerName = "Mina Girgis",
				Address = "11 El Galaa St.",
				City = "Minya",
				Region = "Minya",
				PostalCode = "61511",
				Country = "Egypt",
				Phone = "011-46890145",
				Orders = new Order[]
				{
					new() { OrderID = 10267, OrderDate = new DateTime(1996, 7, 29), Total = 3536.60m },
					new() { OrderID = 10337, OrderDate = new DateTime(1996, 10, 24), Total = 2467.00m },
					new() { OrderID = 10342, OrderDate = new DateTime(1996, 10, 30), Total = 1840.64m },
					new() { OrderID = 10396, OrderDate = new DateTime(1996, 12, 27), Total = 1903.80m },
					new() { OrderID = 10488, OrderDate = new DateTime(1997, 3, 27), Total = 1512.00m },
					new() { OrderID = 10560, OrderDate = new DateTime(1997, 6, 6), Total = 1072.42m },
					new() { OrderID = 10623, OrderDate = new DateTime(1997, 8, 7), Total = 1336.95m },
					new() { OrderID = 10653, OrderDate = new DateTime(1997, 9, 2), Total = 1083.15m },
					new() { OrderID = 10670, OrderDate = new DateTime(1997, 9, 16), Total = 2301.75m },
					new() { OrderID = 10675, OrderDate = new DateTime(1997, 9, 19), Total = 1423.00m },
					new() { OrderID = 10717, OrderDate = new DateTime(1997, 10, 24), Total = 1270.75m },
					new() { OrderID = 10791, OrderDate = new DateTime(1997, 12, 23), Total = 1829.76m },
					new() { OrderID = 10859, OrderDate = new DateTime(1998, 1, 29), Total = 1078.69m },
					new() { OrderID = 10929, OrderDate = new DateTime(1998, 3, 5), Total = 1174.75m },
					new() { OrderID = 11012, OrderDate = new DateTime(1998, 4, 9), Total = 2825.30m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-026",
				CustomerName = "Bishoy Nagy",
				Address = "29 El Mahatta St.",
				City = "Sohag",
				Region = "Sohag",
				PostalCode = "82511",
				Country = "Egypt",
				Phone = "012-57901256",
				Orders = new Order[]
				{
					new() { OrderID = 10671, OrderDate = new DateTime(1997, 9, 17), Total = 920.10m },
					new() { OrderID = 10860, OrderDate = new DateTime(1998, 1, 29), Total = 519.00m },
					new() { OrderID = 10971, OrderDate = new DateTime(1998, 3, 24), Total = 1733.06m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-027",
				CustomerName = "Fatma Ahmed",
				Address = "37 Makram Ebeid St., Nasr City",
				City = "Cairo",
				Region = "",
				PostalCode = "11765",
				Country = "Egypt",
				Phone = "015-68012367",
				Orders = new Order[]
				{
					new() { OrderID = 10422, OrderDate = new DateTime(1997, 1, 22), Total = 49.80m },
					new() { OrderID = 10710, OrderDate = new DateTime(1997, 10, 20), Total = 93.50m },
					new() { OrderID = 10753, OrderDate = new DateTime(1997, 11, 25), Total = 88.00m },
					new() { OrderID = 10807, OrderDate = new DateTime(1997, 12, 31), Total = 18.40m },
					new() { OrderID = 11026, OrderDate = new DateTime(1998, 4, 15), Total = 1030.00m },
					new() { OrderID = 11060, OrderDate = new DateTime(1998, 4, 30), Total = 266.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-028",
				CustomerName = "Mona Abdelaziz",
				Address = "50 Abu Qir St., Ibrahimia",
				City = "Alexandria",
				Region = "",
				PostalCode = "21411",
				Country = "Egypt",
				Phone = "010-79123478",
				Orders = new Order[]
				{
					new() { OrderID = 10328, OrderDate = new DateTime(1996, 10, 14), Total = 1168.00m },
					new() { OrderID = 10352, OrderDate = new DateTime(1996, 11, 12), Total = 136.30m },
					new() { OrderID = 10464, OrderDate = new DateTime(1997, 3, 4), Total = 1609.28m },
					new() { OrderID = 10491, OrderDate = new DateTime(1997, 3, 31), Total = 259.50m },
					new() { OrderID = 10551, OrderDate = new DateTime(1997, 5, 28), Total = 1677.30m },
					new() { OrderID = 10604, OrderDate = new DateTime(1997, 7, 18), Total = 230.85m },
					new() { OrderID = 10664, OrderDate = new DateTime(1997, 9, 10), Total = 1288.39m },
					new() { OrderID = 10963, OrderDate = new DateTime(1998, 3, 19), Total = 57.80m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-029",
				CustomerName = "Heba Mostafa",
				Address = "8 Gamal Abdel Nasser St.",
				City = "Fayoum",
				Region = "Fayoum",
				PostalCode = "63511",
				Country = "Egypt",
				Phone = "011-80234589",
				Orders = new Order[]
				{
					new() { OrderID = 10366, OrderDate = new DateTime(1996, 11, 28), Total = 136.00m },
					new() { OrderID = 10426, OrderDate = new DateTime(1997, 1, 27), Total = 338.20m },
					new() { OrderID = 10568, OrderDate = new DateTime(1997, 6, 13), Total = 155.00m },
					new() { OrderID = 10887, OrderDate = new DateTime(1998, 2, 13), Total = 70.00m },
					new() { OrderID = 10928, OrderDate = new DateTime(1998, 3, 5), Total = 137.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-030",
				CustomerName = "Nourhan Sayed",
				Address = "22 El Nile St.",
				City = "Beni Suef",
				Region = "Beni Suef",
				PostalCode = "62511",
				Country = "Egypt",
				Phone = "012-91345690",
				Orders = new Order[]
				{
					new() { OrderID = 10303, OrderDate = new DateTime(1996, 9, 11), Total = 1117.80m },
					new() { OrderID = 10550, OrderDate = new DateTime(1997, 5, 28), Total = 683.30m },
					new() { OrderID = 10629, OrderDate = new DateTime(1997, 8, 12), Total = 2775.05m },
					new() { OrderID = 10872, OrderDate = new DateTime(1998, 2, 5), Total = 2058.46m },
					new() { OrderID = 10874, OrderDate = new DateTime(1998, 2, 6), Total = 310.00m },
					new() { OrderID = 10888, OrderDate = new DateTime(1998, 2, 16), Total = 605.00m },
					new() { OrderID = 10911, OrderDate = new DateTime(1998, 2, 26), Total = 858.00m },
					new() { OrderID = 10948, OrderDate = new DateTime(1998, 3, 13), Total = 2362.25m },
					new() { OrderID = 11009, OrderDate = new DateTime(1998, 4, 8), Total = 616.50m },
					new() { OrderID = 11037, OrderDate = new DateTime(1998, 4, 21), Total = 60.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-031",
				CustomerName = "Youssef Adel",
				Address = "8 El Nasr St., Nasr City",
				City = "Cairo",
				Region = "",
				PostalCode = "11765",
				Country = "Egypt",
				Phone = "010-2145678",
				Orders = new Order[]
				{
					new() { OrderID = 10423, OrderDate = new DateTime(1997, 1, 23), Total = 1020.00m },
					new() { OrderID = 10652, OrderDate = new DateTime(1997, 9, 1), Total = 318.84m },
					new() { OrderID = 10685, OrderDate = new DateTime(1997, 9, 29), Total = 801.10m },
					new() { OrderID = 10709, OrderDate = new DateTime(1997, 10, 17), Total = 3424.00m },
					new() { OrderID = 10734, OrderDate = new DateTime(1997, 11, 7), Total = 1498.35m },
					new() { OrderID = 10777, OrderDate = new DateTime(1997, 12, 15), Total = 224.00m },
					new() { OrderID = 10790, OrderDate = new DateTime(1997, 12, 22), Total = 722.50m },
					new() { OrderID = 10959, OrderDate = new DateTime(1998, 3, 18), Total = 131.75m },
					new() { OrderID = 11049, OrderDate = new DateTime(1998, 4, 24), Total = 273.60m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-032",
				CustomerName = "Karim Hassan",
				Address = "15 El Horreya St., Mohandessin",
				City = "Giza",
				Region = "Giza",
				PostalCode = "12566",
				Country = "Egypt",
				Phone = "011-2162999",
				Orders = new Order[]
				{
					new() { OrderID = 10528, OrderDate = new DateTime(1997, 5, 6), Total = 392.20m },
					new() { OrderID = 10589, OrderDate = new DateTime(1997, 7, 4), Total = 72.00m },
					new() { OrderID = 10616, OrderDate = new DateTime(1997, 7, 31), Total = 4807.00m },
					new() { OrderID = 10617, OrderDate = new DateTime(1997, 7, 31), Total = 1402.50m },
					new() { OrderID = 10656, OrderDate = new DateTime(1997, 9, 4), Total = 604.22m },
					new() { OrderID = 10681, OrderDate = new DateTime(1997, 9, 25), Total = 1287.40m },
					new() { OrderID = 10816, OrderDate = new DateTime(1998, 1, 6), Total = 8446.45m },
					new() { OrderID = 10936, OrderDate = new DateTime(1998, 3, 9), Total = 456.00m },
					new() { OrderID = 11006, OrderDate = new DateTime(1998, 4, 7), Total = 329.68m },
					new() { OrderID = 11040, OrderDate = new DateTime(1998, 4, 22), Total = 200.00m },
					new() { OrderID = 11061, OrderDate = new DateTime(1998, 4, 30), Total = 510.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-033",
				CustomerName = "Hany Ibrahim",
				Address = "22 El Tahrir St.",
				City = "Alexandria",
				Region = "Alexandria",
				PostalCode = "21524",
				Country = "Egypt",
				Phone = "012-2180320",
				Orders = new Order[]
				{
					new() { OrderID = 10268, OrderDate = new DateTime(1996, 7, 30), Total = 1101.20m },
					new() { OrderID = 10785, OrderDate = new DateTime(1997, 12, 18), Total = 387.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-034",
				CustomerName = "Tamer Nabil",
				Address = "29 Gamal Abdel Nasser St.",
				City = "Mansoura",
				Region = "Dakahlia",
				PostalCode = "35518",
				Country = "Egypt",
				Phone = "015-2197641",
				Orders = new Order[]
				{
					new() { OrderID = 10250, OrderDate = new DateTime(1996, 7, 8), Total = 1552.60m },
					new() { OrderID = 10253, OrderDate = new DateTime(1996, 7, 10), Total = 1444.80m },
					new() { OrderID = 10541, OrderDate = new DateTime(1997, 5, 19), Total = 1946.52m },
					new() { OrderID = 10645, OrderDate = new DateTime(1997, 8, 26), Total = 1535.00m },
					new() { OrderID = 10690, OrderDate = new DateTime(1997, 10, 2), Total = 862.50m },
					new() { OrderID = 10770, OrderDate = new DateTime(1997, 12, 9), Total = 236.25m },
					new() { OrderID = 10783, OrderDate = new DateTime(1997, 12, 18), Total = 1442.50m },
					new() { OrderID = 10886, OrderDate = new DateTime(1998, 2, 13), Total = 3127.50m },
					new() { OrderID = 10903, OrderDate = new DateTime(1998, 2, 24), Total = 932.05m },
					new() { OrderID = 10922, OrderDate = new DateTime(1998, 3, 3), Total = 742.50m },
					new() { OrderID = 10925, OrderDate = new DateTime(1998, 3, 4), Total = 475.15m },
					new() { OrderID = 10981, OrderDate = new DateTime(1998, 3, 27), Total = 15810.00m },
					new() { OrderID = 11022, OrderDate = new DateTime(1998, 4, 14), Total = 1402.00m },
					new() { OrderID = 11052, OrderDate = new DateTime(1998, 4, 27), Total = 1332.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-035",
				CustomerName = "Sherif Ahmed",
				Address = "36 Saad Zaghloul St.",
				City = "Tanta",
				Region = "Gharbia",
				PostalCode = "31511",
				Country = "Egypt",
				Phone = "010-2214962",
				Orders = new Order[]
				{
					new() { OrderID = 10257, OrderDate = new DateTime(1996, 7, 16), Total = 1119.90m },
					new() { OrderID = 10395, OrderDate = new DateTime(1996, 12, 26), Total = 2122.92m },
					new() { OrderID = 10476, OrderDate = new DateTime(1997, 3, 17), Total = 180.48m },
					new() { OrderID = 10486, OrderDate = new DateTime(1997, 3, 26), Total = 1272.00m },
					new() { OrderID = 10490, OrderDate = new DateTime(1997, 3, 31), Total = 3163.20m },
					new() { OrderID = 10498, OrderDate = new DateTime(1997, 4, 7), Total = 575.00m },
					new() { OrderID = 10552, OrderDate = new DateTime(1997, 5, 29), Total = 880.50m },
					new() { OrderID = 10601, OrderDate = new DateTime(1997, 7, 16), Total = 2285.00m },
					new() { OrderID = 10613, OrderDate = new DateTime(1997, 7, 29), Total = 353.20m },
					new() { OrderID = 10641, OrderDate = new DateTime(1997, 8, 22), Total = 2054.00m },
					new() { OrderID = 10705, OrderDate = new DateTime(1997, 10, 15), Total = 378.00m },
					new() { OrderID = 10796, OrderDate = new DateTime(1997, 12, 25), Total = 2341.36m },
					new() { OrderID = 10863, OrderDate = new DateTime(1998, 2, 2), Total = 441.15m },
					new() { OrderID = 10901, OrderDate = new DateTime(1998, 2, 23), Total = 934.50m },
					new() { OrderID = 10957, OrderDate = new DateTime(1998, 3, 18), Total = 1762.70m },
					new() { OrderID = 10960, OrderDate = new DateTime(1998, 3, 19), Total = 265.35m },
					new() { OrderID = 10976, OrderDate = new DateTime(1998, 3, 25), Total = 912.00m },
					new() { OrderID = 11055, OrderDate = new DateTime(1998, 4, 28), Total = 1727.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-036",
				CustomerName = "Amr Samir",
				Address = "43 El Gomhoreya St.",
				City = "Zagazig",
				Region = "Sharqia",
				PostalCode = "44512",
				Country = "Egypt",
				Phone = "011-2232283",
				Orders = new Order[]
				{
					new() { OrderID = 10375, OrderDate = new DateTime(1996, 12, 6), Total = 338.00m },
					new() { OrderID = 10394, OrderDate = new DateTime(1996, 12, 25), Total = 442.00m },
					new() { OrderID = 10415, OrderDate = new DateTime(1997, 1, 15), Total = 102.40m },
					new() { OrderID = 10600, OrderDate = new DateTime(1997, 7, 16), Total = 479.80m },
					new() { OrderID = 10660, OrderDate = new DateTime(1997, 9, 8), Total = 1701.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-037",
				CustomerName = "Khaled Mostafa",
				Address = "50 Port Said St.",
				City = "Ismailia",
				Region = "Ismailia",
				PostalCode = "41511",
				Country = "Egypt",
				Phone = "012-2249604",
				Orders = new Order[]
				{
					new() { OrderID = 10298, OrderDate = new DateTime(1996, 9, 5), Total = 2645.00m },
					new() { OrderID = 10309, OrderDate = new DateTime(1996, 9, 19), Total = 1762.00m },
					new() { OrderID = 10335, OrderDate = new DateTime(1996, 10, 22), Total = 2036.16m },
					new() { OrderID = 10373, OrderDate = new DateTime(1996, 12, 5), Total = 1366.40m },
					new() { OrderID = 10380, OrderDate = new DateTime(1996, 12, 12), Total = 1313.82m },
					new() { OrderID = 10429, OrderDate = new DateTime(1997, 1, 29), Total = 1441.38m },
					new() { OrderID = 10503, OrderDate = new DateTime(1997, 4, 11), Total = 2048.50m },
					new() { OrderID = 10516, OrderDate = new DateTime(1997, 4, 24), Total = 2381.05m },
					new() { OrderID = 10567, OrderDate = new DateTime(1997, 6, 12), Total = 2519.00m },
					new() { OrderID = 10646, OrderDate = new DateTime(1997, 8, 27), Total = 1446.00m },
					new() { OrderID = 10661, OrderDate = new DateTime(1997, 9, 9), Total = 562.60m },
					new() { OrderID = 10687, OrderDate = new DateTime(1997, 9, 30), Total = 4960.90m },
					new() { OrderID = 10701, OrderDate = new DateTime(1997, 10, 13), Total = 2864.50m },
					new() { OrderID = 10712, OrderDate = new DateTime(1997, 10, 21), Total = 1233.48m },
					new() { OrderID = 10736, OrderDate = new DateTime(1997, 11, 11), Total = 997.00m },
					new() { OrderID = 10897, OrderDate = new DateTime(1998, 2, 19), Total = 10835.24m },
					new() { OrderID = 10912, OrderDate = new DateTime(1998, 2, 26), Total = 6200.55m },
					new() { OrderID = 10985, OrderDate = new DateTime(1998, 3, 30), Total = 2023.38m },
					new() { OrderID = 11063, OrderDate = new DateTime(1998, 4, 30), Total = 1342.95m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-038",
				CustomerName = "Wael Gamal",
				Address = "10 El Geish St.",
				City = "Suez",
				Region = "Suez",
				PostalCode = "43512",
				Country = "Egypt",
				Phone = "015-2266925",
				Orders = new Order[]
				{
					new() { OrderID = 10315, OrderDate = new DateTime(1996, 9, 26), Total = 516.80m },
					new() { OrderID = 10318, OrderDate = new DateTime(1996, 10, 1), Total = 240.40m },
					new() { OrderID = 10321, OrderDate = new DateTime(1996, 10, 3), Total = 144.00m },
					new() { OrderID = 10473, OrderDate = new DateTime(1997, 3, 13), Total = 230.40m },
					new() { OrderID = 10621, OrderDate = new DateTime(1997, 8, 5), Total = 758.50m },
					new() { OrderID = 10674, OrderDate = new DateTime(1997, 9, 18), Total = 45.00m },
					new() { OrderID = 10749, OrderDate = new DateTime(1997, 11, 20), Total = 1080.00m },
					new() { OrderID = 10798, OrderDate = new DateTime(1997, 12, 26), Total = 446.60m },
					new() { OrderID = 10829, OrderDate = new DateTime(1998, 1, 13), Total = 1764.00m },
					new() { OrderID = 10933, OrderDate = new DateTime(1998, 3, 6), Total = 920.60m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-039",
				CustomerName = "Ayman Fathy",
				Address = "17 Abbas El Akkad St.",
				City = "Port Said",
				Region = "Port Said",
				PostalCode = "42514",
				Country = "Egypt",
				Phone = "010-2284246",
				Orders = new Order[]
				{
					new() { OrderID = 10323, OrderDate = new DateTime(1996, 10, 7), Total = 164.40m },
					new() { OrderID = 10325, OrderDate = new DateTime(1996, 10, 9), Total = 1497.00m },
					new() { OrderID = 10456, OrderDate = new DateTime(1997, 2, 25), Total = 557.60m },
					new() { OrderID = 10457, OrderDate = new DateTime(1997, 2, 25), Total = 1584.00m },
					new() { OrderID = 10468, OrderDate = new DateTime(1997, 3, 7), Total = 717.60m },
					new() { OrderID = 10506, OrderDate = new DateTime(1997, 4, 15), Total = 415.80m },
					new() { OrderID = 10542, OrderDate = new DateTime(1997, 5, 20), Total = 469.11m },
					new() { OrderID = 10630, OrderDate = new DateTime(1997, 8, 13), Total = 903.60m },
					new() { OrderID = 10718, OrderDate = new DateTime(1997, 10, 27), Total = 3463.00m },
					new() { OrderID = 10799, OrderDate = new DateTime(1997, 12, 26), Total = 1553.50m },
					new() { OrderID = 10817, OrderDate = new DateTime(1998, 1, 6), Total = 10952.84m },
					new() { OrderID = 10849, OrderDate = new DateTime(1998, 1, 23), Total = 967.82m },
					new() { OrderID = 10893, OrderDate = new DateTime(1998, 2, 18), Total = 5502.11m },
					new() { OrderID = 11028, OrderDate = new DateTime(1998, 4, 16), Total = 2160.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-040",
				CustomerName = "Islam Mahmoud",
				Address = "24 Mostafa El Nahas St.",
				City = "Damietta",
				Region = "Damietta",
				PostalCode = "34511",
				Country = "Egypt",
				Phone = "011-2301567",
				Orders = new Order[]
				{
					new() { OrderID = 10858, OrderDate = new DateTime(1998, 1, 29), Total = 649.00m },
					new() { OrderID = 10927, OrderDate = new DateTime(1998, 3, 5), Total = 800.00m },
					new() { OrderID = 10972, OrderDate = new DateTime(1998, 3, 24), Total = 251.50m },
					new() { OrderID = 10973, OrderDate = new DateTime(1998, 3, 24), Total = 291.55m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-041",
				CustomerName = "Mahmoud Adel",
				Address = "31 Ahmed Orabi St.",
				City = "Minya",
				Region = "Minya",
				PostalCode = "61512",
				Country = "Egypt",
				Phone = "012-2318888",
				Orders = new Order[]
				{
					new() { OrderID = 10350, OrderDate = new DateTime(1996, 11, 11), Total = 642.06m },
					new() { OrderID = 10358, OrderDate = new DateTime(1996, 11, 20), Total = 429.40m },
					new() { OrderID = 10371, OrderDate = new DateTime(1996, 12, 3), Total = 72.96m },
					new() { OrderID = 10413, OrderDate = new DateTime(1997, 1, 14), Total = 2123.20m },
					new() { OrderID = 10425, OrderDate = new DateTime(1997, 1, 24), Total = 360.00m },
					new() { OrderID = 10454, OrderDate = new DateTime(1997, 2, 21), Total = 331.20m },
					new() { OrderID = 10493, OrderDate = new DateTime(1997, 4, 2), Total = 608.40m },
					new() { OrderID = 10500, OrderDate = new DateTime(1997, 4, 9), Total = 523.26m },
					new() { OrderID = 10610, OrderDate = new DateTime(1997, 7, 25), Total = 299.25m },
					new() { OrderID = 10631, OrderDate = new DateTime(1997, 8, 14), Total = 55.80m },
					new() { OrderID = 10787, OrderDate = new DateTime(1997, 12, 19), Total = 2622.76m },
					new() { OrderID = 10832, OrderDate = new DateTime(1998, 1, 14), Total = 475.11m },
					new() { OrderID = 10923, OrderDate = new DateTime(1998, 3, 3), Total = 748.80m },
					new() { OrderID = 11051, OrderDate = new DateTime(1998, 4, 27), Total = 36.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-042",
				CustomerName = "Hossam Youssef",
				Address = "38 El Farouk St.",
				City = "Assiut",
				Region = "Assiut",
				PostalCode = "71513",
				Country = "Egypt",
				Phone = "015-2336209",
				Orders = new Order[]
				{
					new() { OrderID = 10495, OrderDate = new DateTime(1997, 4, 3), Total = 278.00m },
					new() { OrderID = 10620, OrderDate = new DateTime(1997, 8, 5), Total = 57.50m },
					new() { OrderID = 10810, OrderDate = new DateTime(1998, 1, 1), Total = 187.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-043",
				CustomerName = "Ehab Mohamed",
				Address = "45 El Mahatta St.",
				City = "Sohag",
				Region = "Sohag",
				PostalCode = "82511",
				Country = "Egypt",
				Phone = "010-2353530",
				Orders = new Order[]
				{
					new() { OrderID = 10482, OrderDate = new DateTime(1997, 3, 21), Total = 147.00m },
					new() { OrderID = 10545, OrderDate = new DateTime(1997, 5, 22), Total = 210.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-044",
				CustomerName = "Marwan Ali",
				Address = "52 El Bahr St.",
				City = "Qena",
				Region = "Qena",
				PostalCode = "83512",
				Country = "Egypt",
				Phone = "011-2370851",
				Orders = new Order[]
				{
					new() { OrderID = 10279, OrderDate = new DateTime(1996, 8, 13), Total = 351.00m },
					new() { OrderID = 10284, OrderDate = new DateTime(1996, 8, 19), Total = 1170.38m },
					new() { OrderID = 10343, OrderDate = new DateTime(1996, 10, 31), Total = 1584.00m },
					new() { OrderID = 10497, OrderDate = new DateTime(1997, 4, 4), Total = 1380.60m },
					new() { OrderID = 10522, OrderDate = new DateTime(1997, 4, 30), Total = 2318.24m },
					new() { OrderID = 10534, OrderDate = new DateTime(1997, 5, 12), Total = 465.70m },
					new() { OrderID = 10536, OrderDate = new DateTime(1997, 5, 14), Total = 1645.00m },
					new() { OrderID = 10557, OrderDate = new DateTime(1997, 6, 3), Total = 1152.50m },
					new() { OrderID = 10592, OrderDate = new DateTime(1997, 7, 8), Total = 516.47m },
					new() { OrderID = 10593, OrderDate = new DateTime(1997, 7, 9), Total = 1994.40m },
					new() { OrderID = 10772, OrderDate = new DateTime(1997, 12, 10), Total = 3603.22m },
					new() { OrderID = 10862, OrderDate = new DateTime(1998, 1, 30), Total = 581.00m },
					new() { OrderID = 10891, OrderDate = new DateTime(1998, 2, 17), Total = 368.93m },
					new() { OrderID = 10934, OrderDate = new DateTime(1998, 3, 9), Total = 500.00m },
					new() { OrderID = 11070, OrderDate = new DateTime(1998, 5, 5), Total = 1629.98m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-045",
				CustomerName = "Sameh Ibrahim",
				Address = "12 El Salam St.",
				City = "Luxor",
				Region = "Luxor",
				PostalCode = "85953",
				Country = "Egypt",
				Phone = "012-2388172",
				Orders = new Order[]
				{
					new() { OrderID = 10579, OrderDate = new DateTime(1997, 6, 25), Total = 317.75m },
					new() { OrderID = 10719, OrderDate = new DateTime(1997, 10, 27), Total = 844.25m },
					new() { OrderID = 10735, OrderDate = new DateTime(1997, 11, 10), Total = 536.40m },
					new() { OrderID = 10884, OrderDate = new DateTime(1998, 2, 12), Total = 1378.07m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-046",
				CustomerName = "Ahmed Tarek",
				Address = "19 El Wadi St.",
				City = "Aswan",
				Region = "Aswan",
				PostalCode = "81511",
				Country = "Egypt",
				Phone = "015-2405493",
				Orders = new Order[]
				{
					new() { OrderID = 10283, OrderDate = new DateTime(1996, 8, 16), Total = 1414.80m },
					new() { OrderID = 10296, OrderDate = new DateTime(1996, 9, 3), Total = 1050.60m },
					new() { OrderID = 10330, OrderDate = new DateTime(1996, 10, 16), Total = 1649.00m },
					new() { OrderID = 10357, OrderDate = new DateTime(1996, 11, 19), Total = 1167.68m },
					new() { OrderID = 10381, OrderDate = new DateTime(1996, 12, 12), Total = 112.00m },
					new() { OrderID = 10461, OrderDate = new DateTime(1997, 2, 28), Total = 1538.70m },
					new() { OrderID = 10499, OrderDate = new DateTime(1997, 4, 8), Total = 1412.00m },
					new() { OrderID = 10543, OrderDate = new DateTime(1997, 5, 21), Total = 1504.50m },
					new() { OrderID = 10780, OrderDate = new DateTime(1997, 12, 16), Total = 720.00m },
					new() { OrderID = 10823, OrderDate = new DateTime(1998, 1, 9), Total = 2826.00m },
					new() { OrderID = 10899, OrderDate = new DateTime(1998, 2, 20), Total = 122.40m },
					new() { OrderID = 10997, OrderDate = new DateTime(1998, 4, 3), Total = 1885.00m },
					new() { OrderID = 11065, OrderDate = new DateTime(1998, 5, 1), Total = 189.42m },
					new() { OrderID = 11071, OrderDate = new DateTime(1998, 5, 5), Total = 484.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-047",
				CustomerName = "Mohamed Hany",
				Address = "26 El Nasr Road",
				City = "Fayoum",
				Region = "Fayoum",
				PostalCode = "63512",
				Country = "Egypt",
				Phone = "010-2422814",
				Orders = new Order[]
				{
					new() { OrderID = 10405, OrderDate = new DateTime(1997, 1, 6), Total = 400.00m },
					new() { OrderID = 10485, OrderDate = new DateTime(1997, 3, 25), Total = 1584.00m },
					new() { OrderID = 10638, OrderDate = new DateTime(1997, 8, 20), Total = 2720.05m },
					new() { OrderID = 10697, OrderDate = new DateTime(1997, 10, 8), Total = 805.42m },
					new() { OrderID = 10729, OrderDate = new DateTime(1997, 11, 4), Total = 1850.00m },
					new() { OrderID = 10811, OrderDate = new DateTime(1998, 1, 2), Total = 852.00m },
					new() { OrderID = 10838, OrderDate = new DateTime(1998, 1, 19), Total = 1938.38m },
					new() { OrderID = 10840, OrderDate = new DateTime(1998, 1, 19), Total = 211.20m },
					new() { OrderID = 10919, OrderDate = new DateTime(1998, 3, 2), Total = 1122.80m },
					new() { OrderID = 10954, OrderDate = new DateTime(1998, 3, 17), Total = 1659.54m },
					new() { OrderID = 11014, OrderDate = new DateTime(1998, 4, 10), Total = 243.18m },
					new() { OrderID = 11039, OrderDate = new DateTime(1998, 4, 21), Total = 3090.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-048",
				CustomerName = "Mostafa Samir",
				Address = "33 El Nile St.",
				City = "Beni Suef",
				Region = "Beni Suef",
				PostalCode = "62514",
				Country = "Egypt",
				Phone = "011-2440135",
				Orders = new Order[]
				{
					new() { OrderID = 10307, OrderDate = new DateTime(1996, 9, 17), Total = 424.00m },
					new() { OrderID = 10317, OrderDate = new DateTime(1996, 9, 30), Total = 288.00m },
					new() { OrderID = 10544, OrderDate = new DateTime(1997, 5, 21), Total = 417.20m },
					new() { OrderID = 10662, OrderDate = new DateTime(1997, 9, 9), Total = 125.00m },
					new() { OrderID = 10665, OrderDate = new DateTime(1997, 9, 11), Total = 1295.00m },
					new() { OrderID = 10867, OrderDate = new DateTime(1998, 2, 3), Total = 98.40m },
					new() { OrderID = 10883, OrderDate = new DateTime(1998, 2, 12), Total = 36.00m },
					new() { OrderID = 11018, OrderDate = new DateTime(1998, 4, 13), Total = 1575.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-049",
				CustomerName = "Omar Adel",
				Address = "40 El Mostashfa St., New Cairo",
				City = "Cairo",
				Region = "",
				PostalCode = "11566",
				Country = "Egypt",
				Phone = "012-2457456",
				Orders = new Order[]
				{
					new() { OrderID = 10275, OrderDate = new DateTime(1996, 8, 7), Total = 291.84m },
					new() { OrderID = 10300, OrderDate = new DateTime(1996, 9, 9), Total = 608.00m },
					new() { OrderID = 10404, OrderDate = new DateTime(1997, 1, 3), Total = 1591.25m },
					new() { OrderID = 10467, OrderDate = new DateTime(1997, 3, 6), Total = 235.20m },
					new() { OrderID = 10635, OrderDate = new DateTime(1997, 8, 18), Total = 1326.22m },
					new() { OrderID = 10754, OrderDate = new DateTime(1997, 11, 25), Total = 55.20m },
					new() { OrderID = 10784, OrderDate = new DateTime(1997, 12, 18), Total = 1488.00m },
					new() { OrderID = 10818, OrderDate = new DateTime(1998, 1, 7), Total = 833.00m },
					new() { OrderID = 10939, OrderDate = new DateTime(1998, 3, 10), Total = 637.50m },
					new() { OrderID = 10950, OrderDate = new DateTime(1998, 3, 16), Total = 110.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-050",
				CustomerName = "Mahmoud Tarek",
				Address = "47 El Nasr St., Haram",
				City = "Giza",
				Region = "Giza",
				PostalCode = "12566",
				Country = "Egypt",
				Phone = "015-2474777",
				Orders = new Order[]
				{
					new() { OrderID = 10529, OrderDate = new DateTime(1997, 5, 7), Total = 946.00m },
					new() { OrderID = 10649, OrderDate = new DateTime(1997, 8, 28), Total = 1434.00m },
					new() { OrderID = 10760, OrderDate = new DateTime(1997, 12, 1), Total = 2917.00m },
					new() { OrderID = 10892, OrderDate = new DateTime(1998, 2, 17), Total = 2090.00m },
					new() { OrderID = 10896, OrderDate = new DateTime(1998, 2, 19), Total = 750.50m },
					new() { OrderID = 10978, OrderDate = new DateTime(1998, 3, 26), Total = 1303.20m },
					new() { OrderID = 11004, OrderDate = new DateTime(1998, 4, 7), Total = 295.38m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-051",
				CustomerName = "Yasser Khaled",
				Address = "54 El Horreya St.",
				City = "Alexandria",
				Region = "Alexandria",
				PostalCode = "21524",
				Country = "Egypt",
				Phone = "010-2492098",
				Orders = new Order[]
				{
					new() { OrderID = 10332, OrderDate = new DateTime(1996, 10, 17), Total = 1786.88m },
					new() { OrderID = 10339, OrderDate = new DateTime(1996, 10, 28), Total = 3354.00m },
					new() { OrderID = 10376, OrderDate = new DateTime(1996, 12, 9), Total = 399.00m },
					new() { OrderID = 10424, OrderDate = new DateTime(1997, 1, 23), Total = 9194.56m },
					new() { OrderID = 10439, OrderDate = new DateTime(1997, 2, 7), Total = 1078.00m },
					new() { OrderID = 10505, OrderDate = new DateTime(1997, 4, 14), Total = 147.90m },
					new() { OrderID = 10565, OrderDate = new DateTime(1997, 6, 11), Total = 639.90m },
					new() { OrderID = 10570, OrderDate = new DateTime(1997, 6, 17), Total = 2465.25m },
					new() { OrderID = 10590, OrderDate = new DateTime(1997, 7, 7), Total = 1101.00m },
					new() { OrderID = 10605, OrderDate = new DateTime(1997, 7, 21), Total = 4109.70m },
					new() { OrderID = 10618, OrderDate = new DateTime(1997, 8, 1), Total = 2697.50m },
					new() { OrderID = 10619, OrderDate = new DateTime(1997, 8, 4), Total = 1260.00m },
					new() { OrderID = 10724, OrderDate = new DateTime(1997, 10, 30), Total = 638.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-052",
				CustomerName = "Bassem Ahmed",
				Address = "14 El Tahrir St.",
				City = "Mansoura",
				Region = "Dakahlia",
				PostalCode = "35514",
				Country = "Egypt",
				Phone = "011-2509419",
				Orders = new Order[]
				{
					new() { OrderID = 10277, OrderDate = new DateTime(1996, 8, 9), Total = 1200.80m },
					new() { OrderID = 10575, OrderDate = new DateTime(1997, 6, 20), Total = 2147.40m },
					new() { OrderID = 10699, OrderDate = new DateTime(1997, 10, 9), Total = 114.00m },
					new() { OrderID = 10779, OrderDate = new DateTime(1997, 12, 16), Total = 1335.00m },
					new() { OrderID = 10945, OrderDate = new DateTime(1998, 3, 12), Total = 245.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-053",
				CustomerName = "Fady Ibrahim",
				Address = "21 Gamal Abdel Nasser St.",
				City = "Tanta",
				Region = "Gharbia",
				PostalCode = "31516",
				Country = "Egypt",
				Phone = "012-2526740",
				Orders = new Order[]
				{
					new() { OrderID = 10517, OrderDate = new DateTime(1997, 4, 24), Total = 352.00m },
					new() { OrderID = 10752, OrderDate = new DateTime(1997, 11, 24), Total = 252.00m },
					new() { OrderID = 11057, OrderDate = new DateTime(1998, 4, 29), Total = 45.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-054",
				CustomerName = "Mina George",
				Address = "28 Saad Zaghloul St.",
				City = "Zagazig",
				Region = "Sharqia",
				PostalCode = "44516",
				Country = "Egypt",
				Phone = "015-2544061",
				Orders = new Order[]
				{
					new() { OrderID = 10409, OrderDate = new DateTime(1997, 1, 9), Total = 319.20m },
					new() { OrderID = 10531, OrderDate = new DateTime(1997, 5, 8), Total = 110.00m },
					new() { OrderID = 10898, OrderDate = new DateTime(1998, 2, 20), Total = 30.00m },
					new() { OrderID = 10958, OrderDate = new DateTime(1998, 3, 18), Total = 781.00m },
					new() { OrderID = 10986, OrderDate = new DateTime(1998, 3, 30), Total = 2220.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-055",
				CustomerName = "George Samy",
				Address = "35 El Gomhoreya St.",
				City = "Ismailia",
				Region = "Ismailia",
				PostalCode = "41511",
				Country = "Egypt",
				Phone = "010-2561382",
				Orders = new Order[]
				{
					new() { OrderID = 10260, OrderDate = new DateTime(1996, 7, 19), Total = 1504.65m },
					new() { OrderID = 10305, OrderDate = new DateTime(1996, 9, 13), Total = 3741.30m },
					new() { OrderID = 10338, OrderDate = new DateTime(1996, 10, 25), Total = 934.50m },
					new() { OrderID = 10441, OrderDate = new DateTime(1997, 2, 10), Total = 1755.00m },
					new() { OrderID = 10594, OrderDate = new DateTime(1997, 7, 9), Total = 565.50m },
					new() { OrderID = 10680, OrderDate = new DateTime(1997, 9, 24), Total = 1261.88m },
					new() { OrderID = 10706, OrderDate = new DateTime(1997, 10, 16), Total = 1893.00m },
					new() { OrderID = 10855, OrderDate = new DateTime(1998, 1, 27), Total = 2227.89m },
					new() { OrderID = 10965, OrderDate = new DateTime(1998, 3, 20), Total = 848.00m },
					new() { OrderID = 11034, OrderDate = new DateTime(1998, 4, 20), Total = 539.40m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-056",
				CustomerName = "Peter Nabil",
				Address = "42 Port Said St.",
				City = "Suez",
				Region = "Suez",
				PostalCode = "43512",
				Country = "Egypt",
				Phone = "011-2578703",
				Orders = new Order[]
				{
					new() { OrderID = 10407, OrderDate = new DateTime(1997, 1, 7), Total = 1194.00m },
					new() { OrderID = 10508, OrderDate = new DateTime(1997, 4, 16), Total = 240.00m },
					new() { OrderID = 10554, OrderDate = new DateTime(1997, 5, 30), Total = 1728.52m },
					new() { OrderID = 10580, OrderDate = new DateTime(1997, 6, 26), Total = 1013.74m },
					new() { OrderID = 10684, OrderDate = new DateTime(1997, 9, 26), Total = 1768.00m },
					new() { OrderID = 10766, OrderDate = new DateTime(1997, 12, 5), Total = 2310.00m },
					new() { OrderID = 10833, OrderDate = new DateTime(1998, 1, 15), Total = 906.93m },
					new() { OrderID = 10999, OrderDate = new DateTime(1998, 4, 3), Total = 1197.95m },
					new() { OrderID = 11020, OrderDate = new DateTime(1998, 4, 14), Total = 632.40m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-057",
				CustomerName = "Mina Sameh",
				Address = "49 El Geish St.",
				City = "Port Said",
				Region = "Port Said",
				PostalCode = "42514",
				Country = "Egypt",
				Phone = "012-2596024",
				Orders = new Order[]
				{
				}
			},
			new Customer
			{
				CustomerID = "CUS-058",
				CustomerName = "Ramy Hossam",
				Address = "9 Abbas El Akkad St.",
				City = "Damietta",
				Region = "Damietta",
				PostalCode = "34511",
				Country = "Egypt",
				Phone = "015-2613345",
				Orders = new Order[]
				{
					new() { OrderID = 10322, OrderDate = new DateTime(1996, 10, 4), Total = 112.00m },
					new() { OrderID = 10354, OrderDate = new DateTime(1996, 11, 14), Total = 568.80m },
					new() { OrderID = 10474, OrderDate = new DateTime(1997, 3, 13), Total = 1249.10m },
					new() { OrderID = 10502, OrderDate = new DateTime(1997, 4, 10), Total = 816.30m },
					new() { OrderID = 10995, OrderDate = new DateTime(1998, 4, 2), Total = 1196.00m },
					new() { OrderID = 11073, OrderDate = new DateTime(1998, 5, 5), Total = 300.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-059",
				CustomerName = "Sherif Mostafa",
				Address = "16 Mostafa El Nahas St.",
				City = "Minya",
				Region = "Minya",
				PostalCode = "61512",
				Country = "Egypt",
				Phone = "010-2630666",
				Orders = new Order[]
				{
					new() { OrderID = 10353, OrderDate = new DateTime(1996, 11, 13), Total = 8593.28m },
					new() { OrderID = 10392, OrderDate = new DateTime(1996, 12, 24), Total = 1440.00m },
					new() { OrderID = 10427, OrderDate = new DateTime(1997, 1, 27), Total = 651.00m },
					new() { OrderID = 10489, OrderDate = new DateTime(1997, 3, 28), Total = 439.20m },
					new() { OrderID = 10530, OrderDate = new DateTime(1997, 5, 8), Total = 4180.00m },
					new() { OrderID = 10597, OrderDate = new DateTime(1997, 7, 11), Total = 718.08m },
					new() { OrderID = 10686, OrderDate = new DateTime(1997, 9, 30), Total = 1404.45m },
					new() { OrderID = 10747, OrderDate = new DateTime(1997, 11, 19), Total = 1912.85m },
					new() { OrderID = 10844, OrderDate = new DateTime(1998, 1, 21), Total = 735.00m },
					new() { OrderID = 11053, OrderDate = new DateTime(1998, 4, 27), Total = 3055.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-060",
				CustomerName = "Alaa Mahmoud",
				Address = "23 Ahmed Orabi St.",
				City = "Assiut",
				Region = "Assiut",
				PostalCode = "71513",
				Country = "Egypt",
				Phone = "011-2647987",
				Orders = new Order[]
				{
					new() { OrderID = 10336, OrderDate = new DateTime(1996, 10, 23), Total = 285.12m },
					new() { OrderID = 10397, OrderDate = new DateTime(1996, 12, 27), Total = 716.72m },
					new() { OrderID = 10433, OrderDate = new DateTime(1997, 2, 3), Total = 851.20m },
					new() { OrderID = 10477, OrderDate = new DateTime(1997, 3, 17), Total = 558.00m },
					new() { OrderID = 10808, OrderDate = new DateTime(1998, 1, 1), Total = 1411.00m },
					new() { OrderID = 11007, OrderDate = new DateTime(1998, 4, 8), Total = 2633.90m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-061",
				CustomerName = "Reham Ahmed",
				Address = "30 El Farouk St.",
				City = "Sohag",
				Region = "Sohag",
				PostalCode = "82511",
				Country = "Egypt",
				Phone = "012-2665308",
				Orders = new Order[]
				{
					new() { OrderID = 10261, OrderDate = new DateTime(1996, 7, 19), Total = 448.00m },
					new() { OrderID = 10291, OrderDate = new DateTime(1996, 8, 27), Total = 497.52m },
					new() { OrderID = 10379, OrderDate = new DateTime(1996, 12, 11), Total = 863.28m },
					new() { OrderID = 10421, OrderDate = new DateTime(1997, 1, 21), Total = 1194.27m },
					new() { OrderID = 10587, OrderDate = new DateTime(1997, 7, 2), Total = 807.38m },
					new() { OrderID = 10647, OrderDate = new DateTime(1997, 8, 27), Total = 636.00m },
					new() { OrderID = 10720, OrderDate = new DateTime(1997, 10, 28), Total = 550.00m },
					new() { OrderID = 10794, OrderDate = new DateTime(1997, 12, 24), Total = 314.76m },
					new() { OrderID = 10989, OrderDate = new DateTime(1998, 3, 31), Total = 1353.60m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-062",
				CustomerName = "Dina Khaled",
				Address = "37 El Mahatta St.",
				City = "Qena",
				Region = "Qena",
				PostalCode = "83512",
				Country = "Egypt",
				Phone = "015-2682629",
				Orders = new Order[]
				{
					new() { OrderID = 10372, OrderDate = new DateTime(1996, 12, 4), Total = 9210.90m },
					new() { OrderID = 10406, OrderDate = new DateTime(1997, 1, 7), Total = 1830.78m },
					new() { OrderID = 10487, OrderDate = new DateTime(1997, 3, 26), Total = 889.70m },
					new() { OrderID = 10637, OrderDate = new DateTime(1997, 8, 19), Total = 2761.94m },
					new() { OrderID = 10659, OrderDate = new DateTime(1997, 9, 5), Total = 1227.02m },
					new() { OrderID = 10704, OrderDate = new DateTime(1997, 10, 14), Total = 595.50m },
					new() { OrderID = 10728, OrderDate = new DateTime(1997, 11, 4), Total = 1296.75m },
					new() { OrderID = 10786, OrderDate = new DateTime(1997, 12, 19), Total = 1531.08m },
					new() { OrderID = 10868, OrderDate = new DateTime(1998, 2, 4), Total = 1920.60m },
					new() { OrderID = 10913, OrderDate = new DateTime(1998, 2, 26), Total = 768.75m },
					new() { OrderID = 10914, OrderDate = new DateTime(1998, 2, 27), Total = 537.50m },
					new() { OrderID = 10961, OrderDate = new DateTime(1998, 3, 19), Total = 1119.90m },
					new() { OrderID = 11068, OrderDate = new DateTime(1998, 5, 4), Total = 2027.08m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-063",
				CustomerName = "Sara Mostafa",
				Address = "44 El Bahr St.",
				City = "Luxor",
				Region = "Luxor",
				PostalCode = "85953",
				Country = "Egypt",
				Phone = "010-2699950",
				Orders = new Order[]
				{
					new() { OrderID = 10273, OrderDate = new DateTime(1996, 8, 5), Total = 2037.28m },
					new() { OrderID = 10285, OrderDate = new DateTime(1996, 8, 20), Total = 1743.36m },
					new() { OrderID = 10286, OrderDate = new DateTime(1996, 8, 21), Total = 3016.00m },
					new() { OrderID = 10313, OrderDate = new DateTime(1996, 9, 24), Total = 182.40m },
					new() { OrderID = 10345, OrderDate = new DateTime(1996, 11, 4), Total = 2924.80m },
					new() { OrderID = 10361, OrderDate = new DateTime(1996, 11, 22), Total = 2046.24m },
					new() { OrderID = 10418, OrderDate = new DateTime(1997, 1, 17), Total = 1814.80m },
					new() { OrderID = 10451, OrderDate = new DateTime(1997, 2, 19), Total = 3849.66m },
					new() { OrderID = 10515, OrderDate = new DateTime(1997, 4, 23), Total = 9921.30m },
					new() { OrderID = 10527, OrderDate = new DateTime(1997, 5, 5), Total = 1503.00m },
					new() { OrderID = 10540, OrderDate = new DateTime(1997, 5, 19), Total = 10191.70m },
					new() { OrderID = 10549, OrderDate = new DateTime(1997, 5, 27), Total = 3554.28m },
					new() { OrderID = 10588, OrderDate = new DateTime(1997, 7, 3), Total = 3120.00m },
					new() { OrderID = 10658, OrderDate = new DateTime(1997, 9, 5), Total = 4464.60m },
					new() { OrderID = 10691, OrderDate = new DateTime(1997, 10, 3), Total = 10164.80m },
					new() { OrderID = 10694, OrderDate = new DateTime(1997, 10, 6), Total = 4825.00m },
					new() { OrderID = 10721, OrderDate = new DateTime(1997, 10, 29), Total = 923.88m },
					new() { OrderID = 10745, OrderDate = new DateTime(1997, 11, 18), Total = 4529.80m },
					new() { OrderID = 10765, OrderDate = new DateTime(1997, 12, 4), Total = 1515.60m },
					new() { OrderID = 10788, OrderDate = new DateTime(1997, 12, 22), Total = 731.50m },
					new() { OrderID = 10845, OrderDate = new DateTime(1998, 1, 21), Total = 3812.70m },
					new() { OrderID = 10865, OrderDate = new DateTime(1998, 2, 2), Total = 16387.50m },
					new() { OrderID = 10878, OrderDate = new DateTime(1998, 2, 10), Total = 1539.00m },
					new() { OrderID = 10938, OrderDate = new DateTime(1998, 3, 10), Total = 2731.88m },
					new() { OrderID = 10962, OrderDate = new DateTime(1998, 3, 19), Total = 3584.00m },
					new() { OrderID = 10991, OrderDate = new DateTime(1998, 4, 1), Total = 2296.00m },
					new() { OrderID = 10996, OrderDate = new DateTime(1998, 4, 2), Total = 560.00m },
					new() { OrderID = 11021, OrderDate = new DateTime(1998, 4, 14), Total = 6306.24m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-064",
				CustomerName = "Menna Youssef",
				Address = "51 El Salam St.",
				City = "Aswan",
				Region = "Aswan",
				PostalCode = "81511",
				Country = "Egypt",
				Phone = "011-2717271",
				Orders = new Order[]
				{
					new() { OrderID = 10448, OrderDate = new DateTime(1997, 2, 17), Total = 443.40m },
					new() { OrderID = 10716, OrderDate = new DateTime(1997, 10, 24), Total = 706.00m },
					new() { OrderID = 10828, OrderDate = new DateTime(1998, 1, 13), Total = 932.00m },
					new() { OrderID = 10916, OrderDate = new DateTime(1998, 2, 27), Total = 686.70m },
					new() { OrderID = 11019, OrderDate = new DateTime(1998, 4, 13), Total = 76.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-065",
				CustomerName = "Mai Hany",
				Address = "11 El Wadi St.",
				City = "Fayoum",
				Region = "Fayoum",
				PostalCode = "63512",
				Country = "Egypt",
				Phone = "012-2734592",
				Orders = new Order[]
				{
					new() { OrderID = 10262, OrderDate = new DateTime(1996, 7, 22), Total = 584.00m },
					new() { OrderID = 10272, OrderDate = new DateTime(1996, 8, 2), Total = 1456.00m },
					new() { OrderID = 10294, OrderDate = new DateTime(1996, 8, 30), Total = 1887.60m },
					new() { OrderID = 10314, OrderDate = new DateTime(1996, 9, 25), Total = 2094.30m },
					new() { OrderID = 10316, OrderDate = new DateTime(1996, 9, 27), Total = 2835.00m },
					new() { OrderID = 10346, OrderDate = new DateTime(1996, 11, 5), Total = 1618.88m },
					new() { OrderID = 10401, OrderDate = new DateTime(1997, 1, 1), Total = 3868.60m },
					new() { OrderID = 10479, OrderDate = new DateTime(1997, 3, 19), Total = 10495.60m },
					new() { OrderID = 10564, OrderDate = new DateTime(1997, 6, 10), Total = 1234.05m },
					new() { OrderID = 10569, OrderDate = new DateTime(1997, 6, 16), Total = 890.00m },
					new() { OrderID = 10598, OrderDate = new DateTime(1997, 7, 14), Total = 2388.50m },
					new() { OrderID = 10761, OrderDate = new DateTime(1997, 12, 2), Total = 507.00m },
					new() { OrderID = 10820, OrderDate = new DateTime(1998, 1, 7), Total = 1140.00m },
					new() { OrderID = 10852, OrderDate = new DateTime(1998, 1, 26), Total = 2984.00m },
					new() { OrderID = 10889, OrderDate = new DateTime(1998, 2, 16), Total = 11380.00m },
					new() { OrderID = 10988, OrderDate = new DateTime(1998, 3, 31), Total = 3574.80m },
					new() { OrderID = 11000, OrderDate = new DateTime(1998, 4, 6), Total = 903.75m },
					new() { OrderID = 11077, OrderDate = new DateTime(1998, 5, 6), Total = 1255.72m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-066",
				CustomerName = "Salma Adel",
				Address = "18 El Nasr Road",
				City = "Beni Suef",
				Region = "Beni Suef",
				PostalCode = "62514",
				Country = "Egypt",
				Phone = "015-2751913",
				Orders = new Order[]
				{
					new() { OrderID = 10288, OrderDate = new DateTime(1996, 8, 23), Total = 80.10m },
					new() { OrderID = 10428, OrderDate = new DateTime(1997, 1, 28), Total = 192.00m },
					new() { OrderID = 10443, OrderDate = new DateTime(1997, 2, 12), Total = 517.44m },
					new() { OrderID = 10562, OrderDate = new DateTime(1997, 6, 9), Total = 488.70m },
					new() { OrderID = 10586, OrderDate = new DateTime(1997, 7, 2), Total = 23.80m },
					new() { OrderID = 10655, OrderDate = new DateTime(1997, 9, 3), Total = 154.40m },
					new() { OrderID = 10727, OrderDate = new DateTime(1997, 11, 3), Total = 1624.50m },
					new() { OrderID = 10812, OrderDate = new DateTime(1998, 1, 2), Total = 1692.80m },
					new() { OrderID = 10908, OrderDate = new DateTime(1998, 2, 26), Total = 663.10m },
					new() { OrderID = 10942, OrderDate = new DateTime(1998, 3, 11), Total = 560.00m },
					new() { OrderID = 11010, OrderDate = new DateTime(1998, 4, 9), Total = 645.00m },
					new() { OrderID = 11062, OrderDate = new DateTime(1998, 4, 30), Total = 406.40m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-067",
				CustomerName = "Aya Ibrahim",
				Address = "25 El Nile St., Heliopolis",
				City = "Cairo",
				Region = "",
				PostalCode = "11431",
				Country = "Egypt",
				Phone = "010-2769234",
				Orders = new Order[]
				{
					new() { OrderID = 10287, OrderDate = new DateTime(1996, 8, 22), Total = 819.00m },
					new() { OrderID = 10299, OrderDate = new DateTime(1996, 9, 6), Total = 349.50m },
					new() { OrderID = 10447, OrderDate = new DateTime(1997, 2, 14), Total = 914.40m },
					new() { OrderID = 10481, OrderDate = new DateTime(1997, 3, 20), Total = 1472.00m },
					new() { OrderID = 10563, OrderDate = new DateTime(1997, 6, 10), Total = 965.00m },
					new() { OrderID = 10622, OrderDate = new DateTime(1997, 8, 6), Total = 560.00m },
					new() { OrderID = 10648, OrderDate = new DateTime(1997, 8, 28), Total = 372.38m },
					new() { OrderID = 10813, OrderDate = new DateTime(1998, 1, 5), Total = 602.40m },
					new() { OrderID = 10851, OrderDate = new DateTime(1998, 1, 26), Total = 2603.00m },
					new() { OrderID = 10877, OrderDate = new DateTime(1998, 2, 9), Total = 1955.12m },
					new() { OrderID = 11059, OrderDate = new DateTime(1998, 4, 29), Total = 1838.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-068",
				CustomerName = "Nada Samir",
				Address = "32 El Mostashfa St., Mohandessin",
				City = "Giza",
				Region = "Giza",
				PostalCode = "12566",
				Country = "Egypt",
				Phone = "011-2786555",
				Orders = new Order[]
				{
					new() { OrderID = 10255, OrderDate = new DateTime(1996, 7, 12), Total = 2490.50m },
					new() { OrderID = 10419, OrderDate = new DateTime(1997, 1, 20), Total = 2097.60m },
					new() { OrderID = 10537, OrderDate = new DateTime(1997, 5, 14), Total = 1823.80m },
					new() { OrderID = 10666, OrderDate = new DateTime(1997, 9, 12), Total = 4666.94m },
					new() { OrderID = 10751, OrderDate = new DateTime(1997, 11, 24), Total = 1631.48m },
					new() { OrderID = 10758, OrderDate = new DateTime(1997, 11, 28), Total = 1644.60m },
					new() { OrderID = 10931, OrderDate = new DateTime(1998, 3, 6), Total = 799.20m },
					new() { OrderID = 10951, OrderDate = new DateTime(1998, 3, 16), Total = 458.76m },
					new() { OrderID = 11033, OrderDate = new DateTime(1998, 4, 17), Total = 3232.80m },
					new() { OrderID = 11075, OrderDate = new DateTime(1998, 5, 6), Total = 498.10m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-069",
				CustomerName = "Rania Tarek",
				Address = "39 El Nasr St.",
				City = "Alexandria",
				Region = "Alexandria",
				PostalCode = "21524",
				Country = "Egypt",
				Phone = "012-2803876",
				Orders = new Order[]
				{
					new() { OrderID = 10281, OrderDate = new DateTime(1996, 8, 14), Total = 86.50m },
					new() { OrderID = 10282, OrderDate = new DateTime(1996, 8, 15), Total = 155.40m },
					new() { OrderID = 10306, OrderDate = new DateTime(1996, 9, 16), Total = 498.50m },
					new() { OrderID = 10917, OrderDate = new DateTime(1998, 3, 2), Total = 365.89m },
					new() { OrderID = 11013, OrderDate = new DateTime(1998, 4, 9), Total = 361.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-070",
				CustomerName = "Heba Ahmed",
				Address = "46 El Horreya St.",
				City = "Mansoura",
				Region = "Dakahlia",
				PostalCode = "35518",
				Country = "Egypt",
				Phone = "015-2821197",
				Orders = new Order[]
				{
					new() { OrderID = 10387, OrderDate = new DateTime(1996, 12, 18), Total = 1058.40m },
					new() { OrderID = 10520, OrderDate = new DateTime(1997, 4, 29), Total = 200.00m },
					new() { OrderID = 10639, OrderDate = new DateTime(1997, 8, 20), Total = 500.00m },
					new() { OrderID = 10831, OrderDate = new DateTime(1998, 1, 14), Total = 2684.40m },
					new() { OrderID = 10909, OrderDate = new DateTime(1998, 2, 26), Total = 670.00m },
					new() { OrderID = 11015, OrderDate = new DateTime(1998, 4, 10), Total = 622.35m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-071",
				CustomerName = "Esraa Mahmoud",
				Address = "53 El Tahrir St.",
				City = "Tanta",
				Region = "Gharbia",
				PostalCode = "31511",
				Country = "Egypt",
				Phone = "010-2838518",
				Orders = new Order[]
				{
					new() { OrderID = 10324, OrderDate = new DateTime(1996, 10, 8), Total = 5275.72m },
					new() { OrderID = 10393, OrderDate = new DateTime(1996, 12, 25), Total = 2556.95m },
					new() { OrderID = 10398, OrderDate = new DateTime(1996, 12, 30), Total = 2505.60m },
					new() { OrderID = 10440, OrderDate = new DateTime(1997, 2, 10), Total = 4924.14m },
					new() { OrderID = 10452, OrderDate = new DateTime(1997, 2, 20), Total = 2018.50m },
					new() { OrderID = 10510, OrderDate = new DateTime(1997, 4, 18), Total = 4707.54m },
					new() { OrderID = 10555, OrderDate = new DateTime(1997, 6, 2), Total = 2944.40m },
					new() { OrderID = 10603, OrderDate = new DateTime(1997, 7, 18), Total = 1483.00m },
					new() { OrderID = 10607, OrderDate = new DateTime(1997, 7, 22), Total = 6475.40m },
					new() { OrderID = 10612, OrderDate = new DateTime(1997, 7, 28), Total = 6375.00m },
					new() { OrderID = 10627, OrderDate = new DateTime(1997, 8, 11), Total = 1185.75m },
					new() { OrderID = 10657, OrderDate = new DateTime(1997, 9, 4), Total = 4371.60m },
					new() { OrderID = 10678, OrderDate = new DateTime(1997, 9, 23), Total = 5256.50m },
					new() { OrderID = 10700, OrderDate = new DateTime(1997, 10, 10), Total = 1638.40m },
					new() { OrderID = 10711, OrderDate = new DateTime(1997, 10, 21), Total = 4451.70m },
					new() { OrderID = 10713, OrderDate = new DateTime(1997, 10, 22), Total = 2827.90m },
					new() { OrderID = 10714, OrderDate = new DateTime(1997, 10, 22), Total = 2205.75m },
					new() { OrderID = 10722, OrderDate = new DateTime(1997, 10, 29), Total = 1570.00m },
					new() { OrderID = 10748, OrderDate = new DateTime(1997, 11, 20), Total = 2196.00m },
					new() { OrderID = 10757, OrderDate = new DateTime(1997, 11, 27), Total = 3082.00m },
					new() { OrderID = 10815, OrderDate = new DateTime(1998, 1, 5), Total = 40.00m },
					new() { OrderID = 10847, OrderDate = new DateTime(1998, 1, 22), Total = 4931.92m },
					new() { OrderID = 10882, OrderDate = new DateTime(1998, 2, 11), Total = 892.64m },
					new() { OrderID = 10894, OrderDate = new DateTime(1998, 2, 18), Total = 2753.10m },
					new() { OrderID = 10941, OrderDate = new DateTime(1998, 3, 11), Total = 4011.75m },
					new() { OrderID = 10983, OrderDate = new DateTime(1998, 3, 27), Total = 720.90m },
					new() { OrderID = 10984, OrderDate = new DateTime(1998, 3, 30), Total = 1809.75m },
					new() { OrderID = 11002, OrderDate = new DateTime(1998, 4, 6), Total = 1811.10m },
					new() { OrderID = 11030, OrderDate = new DateTime(1998, 4, 17), Total = 12615.05m },
					new() { OrderID = 11031, OrderDate = new DateTime(1998, 4, 17), Total = 2393.50m },
					new() { OrderID = 11064, OrderDate = new DateTime(1998, 5, 1), Total = 4330.40m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-072",
				CustomerName = "Marwa Hassan",
				Address = "13 Gamal Abdel Nasser St.",
				City = "Zagazig",
				Region = "Sharqia",
				PostalCode = "44512",
				Country = "Egypt",
				Phone = "011-2855839",
				Orders = new Order[]
				{
					new() { OrderID = 10359, OrderDate = new DateTime(1996, 11, 21), Total = 3471.68m },
					new() { OrderID = 10377, OrderDate = new DateTime(1996, 12, 9), Total = 863.60m },
					new() { OrderID = 10388, OrderDate = new DateTime(1996, 12, 19), Total = 1228.80m },
					new() { OrderID = 10472, OrderDate = new DateTime(1997, 3, 12), Total = 1036.80m },
					new() { OrderID = 10523, OrderDate = new DateTime(1997, 5, 1), Total = 2444.31m },
					new() { OrderID = 10547, OrderDate = new DateTime(1997, 5, 23), Total = 1792.80m },
					new() { OrderID = 10800, OrderDate = new DateTime(1997, 12, 26), Total = 1468.94m },
					new() { OrderID = 10804, OrderDate = new DateTime(1997, 12, 30), Total = 2278.40m },
					new() { OrderID = 10869, OrderDate = new DateTime(1998, 2, 4), Total = 1630.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-073",
				CustomerName = "Nour Adel",
				Address = "20 Saad Zaghloul St.",
				City = "Ismailia",
				Region = "Ismailia",
				PostalCode = "41511",
				Country = "Egypt",
				Phone = "012-2873160",
				Orders = new Order[]
				{
					new() { OrderID = 10341, OrderDate = new DateTime(1996, 10, 29), Total = 352.60m },
					new() { OrderID = 10417, OrderDate = new DateTime(1997, 1, 16), Total = 11188.40m },
					new() { OrderID = 10556, OrderDate = new DateTime(1997, 6, 3), Total = 835.20m },
					new() { OrderID = 10642, OrderDate = new DateTime(1997, 8, 22), Total = 696.00m },
					new() { OrderID = 10669, OrderDate = new DateTime(1997, 9, 15), Total = 570.00m },
					new() { OrderID = 10802, OrderDate = new DateTime(1997, 12, 29), Total = 2942.81m },
					new() { OrderID = 11074, OrderDate = new DateTime(1998, 5, 6), Total = 232.08m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-074",
				CustomerName = "Farah Mohamed",
				Address = "27 El Gomhoreya St.",
				City = "Suez",
				Region = "Suez",
				PostalCode = "43512",
				Country = "Egypt",
				Phone = "015-2890481",
				Orders = new Order[]
				{
					new() { OrderID = 10738, OrderDate = new DateTime(1997, 11, 12), Total = 52.35m },
					new() { OrderID = 10907, OrderDate = new DateTime(1998, 2, 25), Total = 108.50m },
					new() { OrderID = 10964, OrderDate = new DateTime(1998, 3, 20), Total = 2052.50m },
					new() { OrderID = 11043, OrderDate = new DateTime(1998, 4, 22), Total = 210.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-075",
				CustomerName = "Habiba Ali",
				Address = "34 Port Said St.",
				City = "Port Said",
				Region = "Port Said",
				PostalCode = "42514",
				Country = "Egypt",
				Phone = "010-2907802",
				Orders = new Order[]
				{
					new() { OrderID = 10271, OrderDate = new DateTime(1996, 8, 1), Total = 48.00m },
					new() { OrderID = 10329, OrderDate = new DateTime(1996, 10, 15), Total = 4578.43m },
					new() { OrderID = 10349, OrderDate = new DateTime(1996, 11, 8), Total = 141.60m },
					new() { OrderID = 10369, OrderDate = new DateTime(1996, 12, 2), Total = 2390.40m },
					new() { OrderID = 10385, OrderDate = new DateTime(1996, 12, 17), Total = 691.20m },
					new() { OrderID = 10432, OrderDate = new DateTime(1997, 1, 31), Total = 485.00m },
					new() { OrderID = 10756, OrderDate = new DateTime(1997, 11, 27), Total = 1990.00m },
					new() { OrderID = 10821, OrderDate = new DateTime(1998, 1, 8), Total = 678.00m },
					new() { OrderID = 10974, OrderDate = new DateTime(1998, 3, 25), Total = 439.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-076",
				CustomerName = "Malak Nabil",
				Address = "41 El Geish St.",
				City = "Damietta",
				Region = "Damietta",
				PostalCode = "34511",
				Country = "Egypt",
				Phone = "011-2925123",
				Orders = new Order[]
				{
					new() { OrderID = 10252, OrderDate = new DateTime(1996, 7, 9), Total = 3597.90m },
					new() { OrderID = 10302, OrderDate = new DateTime(1996, 9, 10), Total = 2708.80m },
					new() { OrderID = 10458, OrderDate = new DateTime(1997, 2, 26), Total = 3891.00m },
					new() { OrderID = 10463, OrderDate = new DateTime(1997, 3, 4), Total = 713.30m },
					new() { OrderID = 10475, OrderDate = new DateTime(1997, 3, 14), Total = 1505.18m },
					new() { OrderID = 10767, OrderDate = new DateTime(1997, 12, 5), Total = 28.00m },
					new() { OrderID = 10841, OrderDate = new DateTime(1998, 1, 20), Total = 4581.00m },
					new() { OrderID = 10846, OrderDate = new DateTime(1998, 1, 22), Total = 1112.00m },
					new() { OrderID = 10885, OrderDate = new DateTime(1998, 2, 12), Total = 1209.00m },
					new() { OrderID = 10930, OrderDate = new DateTime(1998, 3, 6), Total = 2255.50m },
					new() { OrderID = 11035, OrderDate = new DateTime(1998, 4, 20), Total = 1754.50m },
					new() { OrderID = 11038, OrderDate = new DateTime(1998, 4, 21), Total = 732.60m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-077",
				CustomerName = "Jana Mostafa",
				Address = "48 Abbas El Akkad St.",
				City = "Minya",
				Region = "Minya",
				PostalCode = "61512",
				Country = "Egypt",
				Phone = "012-2942444",
				Orders = new Order[]
				{
					new() { OrderID = 10310, OrderDate = new DateTime(1996, 9, 20), Total = 336.00m },
					new() { OrderID = 10708, OrderDate = new DateTime(1997, 10, 17), Total = 180.40m },
					new() { OrderID = 10805, OrderDate = new DateTime(1997, 12, 30), Total = 2775.00m },
					new() { OrderID = 10992, OrderDate = new DateTime(1998, 4, 1), Total = 69.60m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-078",
				CustomerName = "Mariam Fathy",
				Address = "8 Mostafa El Nahas St.",
				City = "Assiut",
				Region = "Assiut",
				PostalCode = "71513",
				Country = "Egypt",
				Phone = "015-2959765",
				Orders = new Order[]
				{
					new() { OrderID = 10624, OrderDate = new DateTime(1997, 8, 7), Total = 1393.24m },
					new() { OrderID = 10775, OrderDate = new DateTime(1997, 12, 12), Total = 228.00m },
					new() { OrderID = 11003, OrderDate = new DateTime(1998, 4, 6), Total = 326.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-079",
				CustomerName = "Donia Samir",
				Address = "15 Ahmed Orabi St.",
				City = "Sohag",
				Region = "Sohag",
				PostalCode = "82511",
				Country = "Egypt",
				Phone = "010-2977086",
				Orders = new Order[]
				{
					new() { OrderID = 10438, OrderDate = new DateTime(1997, 2, 6), Total = 454.00m },
					new() { OrderID = 10446, OrderDate = new DateTime(1997, 2, 14), Total = 246.24m },
					new() { OrderID = 10548, OrderDate = new DateTime(1997, 5, 26), Total = 240.10m },
					new() { OrderID = 10608, OrderDate = new DateTime(1997, 7, 23), Total = 1064.00m },
					new() { OrderID = 10967, OrderDate = new DateTime(1998, 3, 23), Total = 910.40m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-080",
				CustomerName = "Rana Khaled",
				Address = "22 El Farouk St.",
				City = "Qena",
				Region = "Qena",
				PostalCode = "83512",
				Country = "Egypt",
				Phone = "011-2994407",
				Orders = new Order[]
				{
					new() { OrderID = 10276, OrderDate = new DateTime(1996, 8, 8), Total = 420.00m },
					new() { OrderID = 10293, OrderDate = new DateTime(1996, 8, 29), Total = 848.70m },
					new() { OrderID = 10304, OrderDate = new DateTime(1996, 9, 12), Total = 954.40m },
					new() { OrderID = 10319, OrderDate = new DateTime(1996, 10, 2), Total = 1191.20m },
					new() { OrderID = 10518, OrderDate = new DateTime(1997, 4, 25), Total = 4150.05m },
					new() { OrderID = 10576, OrderDate = new DateTime(1997, 6, 23), Total = 838.45m },
					new() { OrderID = 10676, OrderDate = new DateTime(1997, 9, 22), Total = 534.85m },
					new() { OrderID = 10842, OrderDate = new DateTime(1998, 1, 20), Total = 975.00m },
					new() { OrderID = 10915, OrderDate = new DateTime(1998, 2, 27), Total = 539.50m },
					new() { OrderID = 11069, OrderDate = new DateTime(1998, 5, 4), Total = 360.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-081",
				CustomerName = "Shimaa Ahmed",
				Address = "29 El Mahatta St.",
				City = "Luxor",
				Region = "Luxor",
				PostalCode = "85953",
				Country = "Egypt",
				Phone = "012-3011728",
				Orders = new Order[]
				{
					new() { OrderID = 10249, OrderDate = new DateTime(1996, 7, 5), Total = 1863.40m },
					new() { OrderID = 10292, OrderDate = new DateTime(1996, 8, 28), Total = 1296.00m },
					new() { OrderID = 10496, OrderDate = new DateTime(1997, 4, 4), Total = 190.00m },
					new() { OrderID = 10606, OrderDate = new DateTime(1997, 7, 22), Total = 1130.40m },
					new() { OrderID = 10830, OrderDate = new DateTime(1998, 1, 13), Total = 1974.00m },
					new() { OrderID = 10834, OrderDate = new DateTime(1998, 1, 15), Total = 1432.71m },
					new() { OrderID = 10839, OrderDate = new DateTime(1998, 1, 19), Total = 827.55m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-082",
				CustomerName = "Asmaa Ibrahim",
				Address = "36 El Bahr St.",
				City = "Aswan",
				Region = "Aswan",
				PostalCode = "81511",
				Country = "Egypt",
				Phone = "015-3029049",
				Orders = new Order[]
				{
					new() { OrderID = 10574, OrderDate = new DateTime(1997, 6, 19), Total = 764.30m },
					new() { OrderID = 10577, OrderDate = new DateTime(1997, 6, 23), Total = 569.00m },
					new() { OrderID = 10822, OrderDate = new DateTime(1998, 1, 8), Total = 237.90m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-083",
				CustomerName = "Aya Mohamed",
				Address = "43 El Salam St.",
				City = "Fayoum",
				Region = "Fayoum",
				PostalCode = "63512",
				Country = "Egypt",
				Phone = "010-3046370",
				Orders = new Order[]
				{
					new() { OrderID = 10367, OrderDate = new DateTime(1996, 11, 28), Total = 834.20m },
					new() { OrderID = 10399, OrderDate = new DateTime(1996, 12, 31), Total = 1765.60m },
					new() { OrderID = 10465, OrderDate = new DateTime(1997, 3, 5), Total = 2518.00m },
					new() { OrderID = 10591, OrderDate = new DateTime(1997, 7, 7), Total = 812.50m },
					new() { OrderID = 10602, OrderDate = new DateTime(1997, 7, 17), Total = 48.75m },
					new() { OrderID = 10688, OrderDate = new DateTime(1997, 10, 1), Total = 3160.60m },
					new() { OrderID = 10744, OrderDate = new DateTime(1997, 11, 17), Total = 736.00m },
					new() { OrderID = 10769, OrderDate = new DateTime(1997, 12, 8), Total = 1684.28m },
					new() { OrderID = 10921, OrderDate = new DateTime(1998, 3, 3), Total = 1936.00m },
					new() { OrderID = 10946, OrderDate = new DateTime(1998, 3, 12), Total = 1407.50m },
					new() { OrderID = 10994, OrderDate = new DateTime(1998, 4, 2), Total = 940.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-084",
				CustomerName = "Hager Tarek",
				Address = "50 El Wadi St.",
				City = "Beni Suef",
				Region = "Beni Suef",
				PostalCode = "62514",
				Country = "Egypt",
				Phone = "011-3063691",
				Orders = new Order[]
				{
					new() { OrderID = 10251, OrderDate = new DateTime(1996, 7, 8), Total = 654.06m },
					new() { OrderID = 10334, OrderDate = new DateTime(1996, 10, 21), Total = 144.80m },
					new() { OrderID = 10450, OrderDate = new DateTime(1997, 2, 19), Total = 425.12m },
					new() { OrderID = 10459, OrderDate = new DateTime(1997, 2, 27), Total = 1659.20m },
					new() { OrderID = 10478, OrderDate = new DateTime(1997, 3, 18), Total = 471.20m },
					new() { OrderID = 10546, OrderDate = new DateTime(1997, 5, 23), Total = 2812.00m },
					new() { OrderID = 10806, OrderDate = new DateTime(1997, 12, 31), Total = 439.60m },
					new() { OrderID = 10814, OrderDate = new DateTime(1998, 1, 5), Total = 1788.45m },
					new() { OrderID = 10843, OrderDate = new DateTime(1998, 1, 21), Total = 159.00m },
					new() { OrderID = 10850, OrderDate = new DateTime(1998, 1, 23), Total = 629.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-085",
				CustomerName = "Doaa Hassan",
				Address = "10 El Nasr Road, Shoubra",
				City = "Cairo",
				Region = "",
				PostalCode = "11728",
				Country = "Egypt",
				Phone = "012-3081012",
				Orders = new Order[]
				{
					new() { OrderID = 10274, OrderDate = new DateTime(1996, 8, 6), Total = 538.60m },
					new() { OrderID = 10295, OrderDate = new DateTime(1996, 9, 2), Total = 121.60m },
					new() { OrderID = 10737, OrderDate = new DateTime(1997, 11, 11), Total = 139.80m },
					new() { OrderID = 10739, OrderDate = new DateTime(1997, 11, 12), Total = 240.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-086",
				CustomerName = "Amira Youssef",
				Address = "17 El Nile St., Haram",
				City = "Giza",
				Region = "Giza",
				PostalCode = "12566",
				Country = "Egypt",
				Phone = "015-3098333",
				Orders = new Order[]
				{
					new() { OrderID = 10301, OrderDate = new DateTime(1996, 9, 9), Total = 755.00m },
					new() { OrderID = 10312, OrderDate = new DateTime(1996, 9, 23), Total = 1614.80m },
					new() { OrderID = 10348, OrderDate = new DateTime(1996, 11, 7), Total = 363.60m },
					new() { OrderID = 10356, OrderDate = new DateTime(1996, 11, 18), Total = 1106.40m },
					new() { OrderID = 10513, OrderDate = new DateTime(1997, 4, 22), Total = 1942.00m },
					new() { OrderID = 10632, OrderDate = new DateTime(1997, 8, 14), Total = 589.00m },
					new() { OrderID = 10640, OrderDate = new DateTime(1997, 8, 21), Total = 708.75m },
					new() { OrderID = 10651, OrderDate = new DateTime(1997, 9, 1), Total = 397.80m },
					new() { OrderID = 10668, OrderDate = new DateTime(1997, 9, 15), Total = 625.28m },
					new() { OrderID = 11046, OrderDate = new DateTime(1998, 4, 23), Total = 1485.80m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-087",
				CustomerName = "Nourhan Ahmed",
				Address = "24 El Mostashfa St.",
				City = "Alexandria",
				Region = "Alexandria",
				PostalCode = "21524",
				Country = "Egypt",
				Phone = "010-3115654",
				Orders = new Order[]
				{
					new() { OrderID = 10266, OrderDate = new DateTime(1996, 7, 26), Total = 346.56m },
					new() { OrderID = 10270, OrderDate = new DateTime(1996, 8, 1), Total = 1376.00m },
					new() { OrderID = 10320, OrderDate = new DateTime(1996, 10, 3), Total = 516.00m },
					new() { OrderID = 10333, OrderDate = new DateTime(1996, 10, 18), Total = 877.20m },
					new() { OrderID = 10412, OrderDate = new DateTime(1997, 1, 13), Total = 334.80m },
					new() { OrderID = 10416, OrderDate = new DateTime(1997, 1, 16), Total = 720.00m },
					new() { OrderID = 10437, OrderDate = new DateTime(1997, 2, 5), Total = 393.00m },
					new() { OrderID = 10455, OrderDate = new DateTime(1997, 2, 24), Total = 2684.00m },
					new() { OrderID = 10526, OrderDate = new DateTime(1997, 5, 5), Total = 1151.40m },
					new() { OrderID = 10553, OrderDate = new DateTime(1997, 5, 30), Total = 1546.30m },
					new() { OrderID = 10583, OrderDate = new DateTime(1997, 6, 30), Total = 2237.50m },
					new() { OrderID = 10636, OrderDate = new DateTime(1997, 8, 19), Total = 629.50m },
					new() { OrderID = 10750, OrderDate = new DateTime(1997, 11, 21), Total = 1590.56m },
					new() { OrderID = 10781, OrderDate = new DateTime(1997, 12, 17), Total = 975.88m },
					new() { OrderID = 11025, OrderDate = new DateTime(1998, 4, 15), Total = 270.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-088",
				CustomerName = "Mariam Mostafa",
				Address = "31 El Nasr St.",
				City = "Mansoura",
				Region = "Dakahlia",
				PostalCode = "35514",
				Country = "Egypt",
				Phone = "011-3132975",
				Orders = new Order[]
				{
					new() { OrderID = 10256, OrderDate = new DateTime(1996, 7, 15), Total = 517.80m },
					new() { OrderID = 10420, OrderDate = new DateTime(1997, 1, 21), Total = 1707.84m },
					new() { OrderID = 10585, OrderDate = new DateTime(1997, 7, 1), Total = 142.50m },
					new() { OrderID = 10644, OrderDate = new DateTime(1997, 8, 25), Total = 1371.80m },
					new() { OrderID = 10803, OrderDate = new DateTime(1997, 12, 30), Total = 1193.01m },
					new() { OrderID = 10809, OrderDate = new DateTime(1998, 1, 1), Total = 140.00m },
					new() { OrderID = 10900, OrderDate = new DateTime(1998, 2, 20), Total = 33.75m },
					new() { OrderID = 10905, OrderDate = new DateTime(1998, 2, 24), Total = 342.00m },
					new() { OrderID = 10935, OrderDate = new DateTime(1998, 3, 9), Total = 619.50m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-089",
				CustomerName = "Riham Khaled",
				Address = "38 El Horreya St.",
				City = "Tanta",
				Region = "Gharbia",
				PostalCode = "31516",
				Country = "Egypt",
				Phone = "012-3150296",
				Orders = new Order[]
				{
					new() { OrderID = 10269, OrderDate = new DateTime(1996, 7, 31), Total = 642.20m },
					new() { OrderID = 10344, OrderDate = new DateTime(1996, 11, 1), Total = 2296.00m },
					new() { OrderID = 10469, OrderDate = new DateTime(1997, 3, 10), Total = 956.68m },
					new() { OrderID = 10483, OrderDate = new DateTime(1997, 3, 24), Total = 668.80m },
					new() { OrderID = 10504, OrderDate = new DateTime(1997, 4, 11), Total = 1388.50m },
					new() { OrderID = 10596, OrderDate = new DateTime(1997, 7, 11), Total = 1180.88m },
					new() { OrderID = 10693, OrderDate = new DateTime(1997, 10, 6), Total = 2071.20m },
					new() { OrderID = 10696, OrderDate = new DateTime(1997, 10, 8), Total = 996.00m },
					new() { OrderID = 10723, OrderDate = new DateTime(1997, 10, 30), Total = 468.45m },
					new() { OrderID = 10740, OrderDate = new DateTime(1997, 11, 13), Total = 1416.00m },
					new() { OrderID = 10861, OrderDate = new DateTime(1998, 1, 30), Total = 3523.40m },
					new() { OrderID = 10904, OrderDate = new DateTime(1998, 2, 24), Total = 1924.25m },
					new() { OrderID = 11032, OrderDate = new DateTime(1998, 4, 17), Total = 8902.50m },
					new() { OrderID = 11066, OrderDate = new DateTime(1998, 5, 1), Total = 928.75m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-090",
				CustomerName = "Hoda Samir",
				Address = "45 El Tahrir St.",
				City = "Zagazig",
				Region = "Sharqia",
				PostalCode = "44516",
				Country = "Egypt",
				Phone = "015-3167617",
				Orders = new Order[]
				{
					new() { OrderID = 10248, OrderDate = new DateTime(1996, 7, 4), Total = 440.00m },
					new() { OrderID = 10615, OrderDate = new DateTime(1997, 7, 30), Total = 120.00m },
					new() { OrderID = 10673, OrderDate = new DateTime(1997, 9, 18), Total = 412.35m },
					new() { OrderID = 10695, OrderDate = new DateTime(1997, 10, 7), Total = 642.00m },
					new() { OrderID = 10873, OrderDate = new DateTime(1998, 2, 6), Total = 336.80m },
					new() { OrderID = 10879, OrderDate = new DateTime(1998, 2, 10), Total = 611.30m },
					new() { OrderID = 10910, OrderDate = new DateTime(1998, 2, 26), Total = 452.90m },
					new() { OrderID = 11005, OrderDate = new DateTime(1998, 4, 7), Total = 586.00m },
				}
			},
			new Customer
			{
				CustomerID = "CUS-091",
				CustomerName = "Rasha Adel",
				Address = "52 Gamal Abdel Nasser St.",
				City = "Ismailia",
				Region = "Ismailia",
				PostalCode = "41511",
				Country = "Egypt",
				Phone = "010-3184938",
				Orders = new Order[]
				{
					new() { OrderID = 10374, OrderDate = new DateTime(1996, 12, 5), Total = 459.00m },
					new() { OrderID = 10611, OrderDate = new DateTime(1997, 7, 25), Total = 808.00m },
					new() { OrderID = 10792, OrderDate = new DateTime(1997, 12, 23), Total = 399.85m },
					new() { OrderID = 10870, OrderDate = new DateTime(1998, 2, 4), Total = 160.00m },
					new() { OrderID = 10906, OrderDate = new DateTime(1998, 2, 25), Total = 427.50m },
					new() { OrderID = 10998, OrderDate = new DateTime(1998, 4, 3), Total = 686.00m },
					new() { OrderID = 11044, OrderDate = new DateTime(1998, 4, 23), Total = 591.60m },
				}
			},
		};
	}
}
