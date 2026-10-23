using LINQ.DataSources;
using LINQ.Models;

namespace GNET71_LINQ02
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProductList = Source.ProductList;
            var CustomerList = Source.CustomerList;

            // 1. Get top 3 most expensive products
            var result1 = ProductList
                .OrderByDescending(p => p.UnitPrice)
                .Take(3);

            foreach (var p in result1)
                Console.WriteLine(p);


            // 2. Show page 2 of products, page size = 5
            var result2 = ProductList
                .Skip(5)
                .Take(5);

            foreach (var p in result2)
                Console.WriteLine(p);


            // 3. Take products while UnitPrice is less than $25
            var result3 = ProductList
                .OrderBy(p => p.UnitPrice)
                .TakeWhile(p => p.UnitPrice < 25);

            foreach (var p in result3)
                Console.WriteLine(p);


            // 4. Check if ALL Seafood products are in stock
            bool result4 = ProductList
                .Where(p => p.Category == "Seafood")
                .All(p => p.UnitsInStock > 0);

            Console.WriteLine(result4);


            // 5. Check if the ID list contains 9
            int[] ids = { 3, 9, 13, 18 };

            bool result5 = ids.Contains(9);

            Console.WriteLine(result5);


            // 6. Group products by Category and print product count
            var result6 = ProductList
                .GroupBy(p => p.Category);

            foreach (var group in result6)
                Console.WriteLine($"{group.Key}: {group.Count()}");


            // 7. Group products by Category and select product names
            var result7 = ProductList
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    ProductNames = g.Select(p => p.ProductName)
                });

            foreach (var group in result7)
            {
                Console.WriteLine(group.Category);

                foreach (var name in group.ProductNames)
                    Console.WriteLine(name);
            }


            // 8. Find categories that have MORE THAN 3 products
            var result8 = ProductList
                .GroupBy(p => p.Category)
                .Where(g => g.Count() > 3)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                });

            foreach (var group in result8)
                Console.WriteLine($"{group.Category}: {group.Count}");


            // 9. Group customers by Country using Query Syntax
            // Select Country, Count, TotalOrderValue
            var result9 =
                from customer in CustomerList
                group customer by customer.Country into countryGroup
                select new
                {
                    Country = countryGroup.Key,
                    Count = countryGroup.Count(),
                    TotalOrderValue = countryGroup
                        .SelectMany(c => c.Orders)
                        .Sum(o => o.Total)
                };

            foreach (var group in result9)
            {
                Console.WriteLine(
                    $"{group.Country} - Count: {group.Count} - Total: {group.TotalOrderValue}");
            }


            // 10. Calculate total units in stock
            var result10 = ProductList
                .Sum(p => p.UnitsInStock);

            Console.WriteLine(result10);


            // 11. Find the CHEAPEST and MOST EXPENSIVE prices
            var cheapest = ProductList.Min(p => p.UnitPrice);
            var mostExpensive = ProductList.Max(p => p.UnitPrice);

            Console.WriteLine($"Cheapest: {cheapest}");
            Console.WriteLine($"Most Expensive: {mostExpensive}");


            // 12. Get distinct product categories
            var result12 = ProductList
                .Select(p => p.Category)
                .Distinct();

            foreach (var category in result12)
                Console.WriteLine(category);


            // 13. Find IDs in setA but NOT in setB
            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };

            var result13 = setA.Except(setB);

            foreach (var id in result13)
                Console.WriteLine(id);


            // 14. Countries in list1 but NOT in list2
            // Case-insensitive comparison
            string[] list1 = { "Germany", "France", "UK", "Spain" };
            string[] list2 = { "france", "SPAIN", "Italy" };

            var result14 = list1
                .Except(list2, StringComparer.OrdinalIgnoreCase);

            foreach (var country in result14)
                Console.WriteLine(country);


            // 15. Build Dictionary keyed by ProductID
            // Retrieve and print product with ID = 18
            Dictionary<int, Product> result15 = ProductList
                .ToDictionary(p => p.ProductID);

            if (result15.TryGetValue(18, out Product product))
                Console.WriteLine(product);


            // 16. Get the first product whose price is greater than $50
            var result16 = ProductList
                .First(p => p.UnitPrice > 50);

            Console.WriteLine(result16);


            // 17. Get first product with price > $500
            // FirstOrDefault returns null if no product matches
            var result17 = ProductList
                .FirstOrDefault(p => p.UnitPrice > 500);

            Console.WriteLine(result17 == null
                ? "No product found"
                : result17.ToString());


            // 18. Generate multiplication table row for 7
            var result18 = Enumerable
                .Range(1, 10)
                .Select(n => $"7 x {n} = {7 * n}");

            foreach (var item in result18)
                Console.WriteLine(item);


            // 19. Generate even numbers between 1 and 30
            var result19 = Enumerable
                .Range(1, 30)
                .Where(n => n % 2 == 0);

            foreach (var number in result19)
                Console.WriteLine(number);


            // 20. Concatenate first 3 product names
            // with first 3 customer names
            var result20 = ProductList
                .Take(3)
                .Select(p => p.ProductName)
                .Concat(
                    CustomerList
                        .Take(3)
                        .Select(c => c.CustomerName)
                );

            foreach (var name in result20)
                Console.WriteLine(name);


            // 21. Pair products with customers by position
            // ProductName sold to CustomerName
            var result21 = ProductList
                .Zip(
                    CustomerList,
                    (p, c) => $"{p.ProductName} sold to {c.CustomerName}"
                );

            foreach (var item in result21)
                Console.WriteLine(item);
        }
    }
}
