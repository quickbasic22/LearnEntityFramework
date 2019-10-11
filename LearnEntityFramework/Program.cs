using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace LearnEntityFramework
{
    class Program
    {
       
        static void Main(string[] args)
        {
            GetEntitiesList();
            //UseEqualOperator();
            //UseLessThanOperator();
            //UseLessThanOrEqualOperator();
            //UseGreaterThanOperator();
            //UseGreaterThanOrEqualOperator();
            //AndClause();
            //BetweenClause();
            //LikeClause();
            //SortIn();
            //LimitIn();
            //FindEntityByPrimaryKey();
            //Projection();
            //Sum();
            //Count();
            //MinAndMax();
            //Avg();
            //DateTime();
            //Join();
            //GroupBy();
            //Having();
            //Insert();
            //Update();
            //Delete();
                                                  
        }

        private static void GetEntitiesList()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate);
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void UseEqualOperator()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Status == true).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void UseLessThanOperator()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Price < 20).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void UseLessThanOrEqualOperator()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Price <= 15).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void UseGreaterThanOperator()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Price > 22).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void UseGreaterThanOrEqualOperator()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Price >= 25).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void AndClause()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Price >= 16 && p.Status == true).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void OrClause()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.CategoryId == 1 || p.CategoryId == 2).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void BetweenClause()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Price >= 15 && p.Price <= 20).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void LikeClause()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Where(p => p.Name.StartsWith("mob")).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void SortIn()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.OrderBy(p => p.Price).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.WriteLine("\nSort By Price Descending");
            var productList2 = db.Products.OrderByDescending(p => p.Price).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.WriteLine("\nConditions with sort by");
            var productList3 = db.Products.Where(p => p.Status == true).OrderByDescending(p => p.Price).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void LimitIn()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            Console.WriteLine("Find 2 products with the biggest price");
            var productList1 = db.Products.OrderByDescending(p => p.Price).Skip(0).Take(2).ToList();
            foreach (var product in productList1)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.WriteLine("\nConditions in Limit");
            var productList3 = db.Products.Where(p => p.CategoryId == 1).OrderByDescending(p => p.Id).Skip(0).Take(2).ToList();
            foreach (var product in productList3)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }
        private static void FindEntityByPrimaryKey()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var product = db.Products.SingleOrDefault(p => p.Id == 2);
            if (product != null)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            else
            {
                Console.WriteLine("Product does not exist");
            }
           
            Console.ReadLine();
        }
        private static void Projection()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var products = db.Products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Total = p.Price.Value * p.Quantity.Value
            }).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Total);
                
            }
            Console.ReadLine();
        }
        private static void Sum()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var sum1 = db.Products.Sum(p => p.Quantity);
            Console.WriteLine("Sum Quantities: " + sum1);

            var sum2 = db.Products.Where(p => p.Status == true).Sum(p => p.Quantity);
            Console.WriteLine("Conditions in Sum Quantities: " + sum2);

            var sum3 = db.Products.Sum(p => p.Price * p.Quantity);
            Console.WriteLine("Total: " + sum3);

            Console.ReadLine();
        }
        private static void Count()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var count1 = db.Products.Count();
            Console.WriteLine("Count Products: " + count1);

            var count2 = db.Products.Count(p => p.Status == true);
            Console.WriteLine("Conditions in Count Products: " + count2);


            Console.ReadLine();
        }
        private static void MinAndMax()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var max = db.Products.Max(p => p.Price);
            Console.WriteLine("The biggest price: " + max);

            var min = db.Products.Min(p => p.Price);
            Console.WriteLine("The smallest price: " + min);


            Console.ReadLine();
        }
        private static void Avg()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            var avgPrice = db.Products.Average(p => p.Price);
            Console.WriteLine("Average price of the products: " + avgPrice);
            
            Console.ReadLine();
        }
        private static void DateTime()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();
            Console.WriteLine("Use Year, Month and Day in DateTime");
            var productsList1 = db.Products.Where(p => p.CreationDate.Value.Year == 2016 && p.CreationDate.Value.Month == 11 && p.CreationDate.Value.Day == 20).ToList();
            foreach (var product in productsList1)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.WriteLine("\nCompare Date");
            var productsList2 = db.Products.Where(p => p.CreationDate.Value >= new System.DateTime(2017, 12, 15) && p.CreationDate.Value <= new DateTime(2017, 12, 25)).ToList();
            foreach (var product in productsList2)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.WriteLine("\nSubstract Date");
            var passedDate = System.DateTime.Now.AddDays(-3);
            Console.WriteLine(passedDate.ToShortDateString());
            var productsList3 = db.Products.Where(p => DbFunctions.TruncateTime(p.CreationDate.Value) == DbFunctions.TruncateTime(passedDate)).ToList();
            foreach (var product in productsList3)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price : " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("Creation Date: " + product.CreationDate.Value.ToShortDateString());
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
            }
            Console.ReadLine();
        }

        private static void Join()
        {
            LearnEntityFramework.LearnEntityFrameworkDB db = new LearnEntityFramework.LearnEntityFrameworkDB();

            Console.WriteLine("Use Join");
            var productsList1 = db.Categories.Join(
                db.Products,
                category => category.Id,
                product => product.CategoryId,
                (category, product) => new
                {
                    productId = product.Id,
                    produceName = product.Name,
                    price = product.Price,
                    quantity = product.Quantity,
                    categoryId = category.Id,
                    categoryName = category.Name
                }).ToList();
            foreach (var product in productsList1)
            {
                Console.WriteLine("Product Id: " + product.productId);
                Console.WriteLine("Product Name: " + product.produceName);
                Console.WriteLine("Price : " + product.price);
                Console.WriteLine("Quantity: " + product.quantity);
                Console.WriteLine("Category Id: " + product.categoryId);
                Console.WriteLine("Category Name: " + product.categoryName);
                
            }
            Console.WriteLine("\nCondition in Join");
            var productsList2 = db.Categories.Join(
                db.Products,
                category => category.Id,
                product => product.CategoryId,
                (category, product) => new
                {
                    productId = product.Id,
                    productName = product.Name,
                    price = product.Price,
                    quantity = product.Quantity,
                    categoryId = category.Id,
                    categoryName = category.Name
                }).Where(p => p.price > 24).ToList();
            foreach (var product in productsList2)
            {
                Console.WriteLine("Product Id: " + product.productId);
                Console.WriteLine("Product Name: " + product.productName);
                Console.WriteLine("Price : " + product.price);
                Console.WriteLine("Quantity: " + product.quantity);
                Console.WriteLine("Category Id: " + product.categoryId);
                Console.WriteLine("Category Name: " + product.categoryName);

            }
            Console.ReadLine();
        }
        private static void GroupBy()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();

            var groups = db.Products
                         .GroupBy(p => p.CategoryId)
                         .Select(g => new
                         {
                             g.Key,
                             CountProduct = g.Count(),
                             SumQuantities = g.Sum(p => p.Quantity),
                             MinPrice = g.Min(p => p.Price),
                             MaxPrice = g.Max(p => p.Price),
                             AvgPrice = g.Average(p => p.Price)
                         }).ToList();
            foreach (var group in groups)
            {
                Console.WriteLine("Category Id: " + group.Key);
                Console.WriteLine("Count Product: " + group.CountProduct);
                Console.WriteLine("Sum Quantities : " + group.SumQuantities);
                Console.WriteLine("Min Price: " + group.MinPrice);
                Console.WriteLine("Max Price: " + group.MaxPrice);
                Console.WriteLine("Avg Price: " + group.AvgPrice);

            }
            Console.ReadLine();
        }
        private static void Having()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();

            var groups = db.Products
                         .GroupBy(p => p.CategoryId)
                         .Select(g => new
                         {
                             g.Key,
                             CountProduct = g.Count(),
                             SumQuantities = g.Sum(p => p.Quantity),
                             MinPrice = g.Min(p => p.Price),
                             MaxPrice = g.Max(p => p.Price),
                             AvgPrice = g.Average(p => p.Price)
                         }).Where(g => g.SumQuantities > 20)
                         .ToList();
            foreach (var group in groups)
            {
                Console.WriteLine("Category Id: " + group.Key);
                Console.WriteLine("Count Product: " + group.CountProduct);
                Console.WriteLine("Sum Quantities : " + group.SumQuantities);
                Console.WriteLine("Min Price: " + group.MinPrice);
                Console.WriteLine("Max Price: " + group.MaxPrice);
                Console.WriteLine("Avg Price: " + group.AvgPrice);

            }
            Console.ReadLine();
        }
        private static void Insert()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();

            var product = new Product()
            {
                Name = "Tivi 3",
                Price = 12,
                Quantity = 3,
                CreationDate = System.DateTime.Now,
                Status = true,
                CategoryId = 3
            };
            db.Products.Add(product);
            Console.WriteLine("Result: " + db.SaveChanges());
            Console.ReadLine();

        }
        private static void Update()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();

            var product = db.Products.SingleOrDefault(p => p.Id == 6);
            product.Name = "abc";
            product.Price = 999;
            product.Status = false;

            Console.WriteLine("Result: " + db.SaveChanges());
            Console.ReadLine();

        }
        private static void Delete()
        {
            LearnEntityFrameworkDB db = new LearnEntityFrameworkDB();

            var product = db.Products.SingleOrDefault(p => p.Id == 6);
            db.Products.Remove(product);


            Console.WriteLine("Result: " + db.SaveChanges());
            Console.ReadLine();

        }








    }
}
