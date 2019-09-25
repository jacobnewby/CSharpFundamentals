using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_BakerStreetRepository;

namespace _08_BakerStreet_Console
{
    internal class ProgramUI
    {
        Repo _productRepo = new Repo();
        ProductContent _content = new ProductContent();
        public ProgramUI()
        {

        }

        public void Run()
        {
            _productRepo.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                Console.WriteLine("Enter the number of the menu item you would like to see\n" +
                    "1. Add User and Order\n" +
                    "2. Remove Order\n" +
                    "3. See All Orders\n" +
                    "4. Udpate Order\n" +
                    "5. Exit\n" +
                    "");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);

                switch (userNumber)
                {
                    case 1:
                        AddNewUserAndOrder();
                        break;
                    case 2:
                        RemoveOrder();
                        break;
                    case 3:
                        SeeAllProducts();
                        break;
                    case 4:
                        UpdateOrderUI();
                        break;
                    case 5:
                        continueToRun = false;
                        break;
                }
            }
        }

        public void AddNewUserAndOrder()
        {
            
            Console.WriteLine("Name of product: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Customer: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Batch size: ");
            string batchSizeString = Console.ReadLine();
            int orderBatchSize = int.Parse(batchSizeString);

            Console.WriteLine("What type is this product?\n" +
                "1. Bread\n" +
                "2. Cake\n" +
                "3. Pastery\n" +
                "4. Pies\n");
            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            BakeType type = (BakeType)typeAsInt;

            decimal orderCost = OrderCostMethod(type, orderBatchSize); 

            ProductContent product = new ProductContent(productName, customerName, orderBatchSize, orderCost, type);
            _productRepo.AddToList(product);
        }

        public void RemoveOrder()
        {
            SeeAllProducts();

            Console.WriteLine("Who's order would you like to remove? Please enter name of the customer: ");
            string customerName = Console.ReadLine();

            _productRepo.RemoveProductContentFromList(customerName);

            SeeAllProducts();

        }
        public void SeeAllProducts()
        {
            List<ProductContent> contentList = _productRepo.GetProductList();

            foreach (ProductContent product in contentList)
            {
                Console.WriteLine($"{product.ProductName}\n" +
                    $" Customer: {product.CustomerName}\n" +
                    $" Batch Size: {product.OrderBatchSize}\n" +
                    $" Cost: {product.OrderCost}\n" +
                    $" Type: {product.Type}\n");
            }
            Console.WriteLine("Hit any key to continue... ");
            Console.ReadKey();
        }

        public decimal OrderCostMethod(BakeType type, int orderBatchSize)
        {
            decimal initialCharge = 100m;

            switch (type)
            {
                case BakeType.Bread:
                    decimal total = 500.01m * orderBatchSize;
                    initialCharge += total;
                    break;
                case BakeType.Cake:
                    decimal total2 = 2000m * orderBatchSize;
                    initialCharge += total2;
                    break;
                case BakeType.Pastery:
                    decimal total3 = 200.10m * orderBatchSize;
                    initialCharge += total3;
                    break;
                case BakeType.Pies:
                    decimal total4 = 851.5m * orderBatchSize;
                    initialCharge += total4;
                    break;
            }
            return initialCharge;
        }

        public void UpdateOrderUI()
        {

            List<ProductContent> contentList = _productRepo.GetProductList();
            
            foreach (ProductContent product in contentList)
            {
                Console.WriteLine("Would you like to update this customer's order: " + product.CustomerName + "?" + "Y/N");
                string userInput = Console.ReadLine();
                userInput.ToUpper();

                UpdateOrder(userInput, product);
            }

        }

        public void UpdateOrder(string userInput, ProductContent product)
        {
            List<ProductContent> contentList = _productRepo.GetProductList();
            switch (userInput)
            {
                case "Y":
                    
                    Console.WriteLine("Here are your options: \n" +
                        "1. Change product name.\n" +
                        "2. Change customer name.\n" +
                        "3. Change batch size.\n" +
                        "4. Change order cost\n" +
                        "5. Change bake type.\n");
                    string userResponse = Console.ReadLine();
                    int userNumberResponse = int.Parse(userResponse);
                    switch (userNumberResponse)
                    {
                        
                        case 1:
                            Console.WriteLine("Enter product new name: ");
                            product.ProductName = Console.ReadLine();
                             break;
                        case 2:
                            Console.WriteLine("Enter customer new name: ");
                            product.CustomerName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new batch size: ");
                            string batchSize = Console.ReadLine();
                            int batchSizeInt = int.Parse(batchSize);
                            product.OrderBatchSize = batchSizeInt;
                            break;
                        case 4:
                            Console.WriteLine("Enter new order cost: ");
                            string orderCost = Console.ReadLine();
                            int orderCostAsInt = int.Parse(orderCost);
                            product.OrderCost = orderCostAsInt;
                            break;
                        case 5:
                            Console.WriteLine("What would you like to change the type to?\n" +
                            "1. Bread\n" +
                            "2. Cake\n" +
                            "3. Pastery\n" +
                            "4. Pies\n");
                            string typeAsString = Console.ReadLine();
                            int typeAsInt = int.Parse(typeAsString);
                            BakeType type = (BakeType)typeAsInt;
                            product.Type = type;
                            break;

                    }
                    break;
                case "N":
                    break;

            }


        }
    }
}
