namespace LinqTutorial
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "pen", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "color", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "Processor", productPrice = 7680 });
            productList.Add(new ProductStore { productName = "Bluetooth", productPrice = 540 });
            productList.Add(new ProductStore { productName = "Keyboard & Mouse", productPrice = 1130 });

          
            var result = from p in productList
                         orderby p.productPrice
                         select p;

           

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}