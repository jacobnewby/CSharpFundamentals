﻿using System;
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
                    "4. Exit\n" +
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

            decimal orderCost = OrderCostMethod(type);

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

        public decimal OrderCostMethod(BakeType type)
        {
            decimal initialCharge = 100m;

            switch (type)
            {
                case BakeType.Bread:
                    initialCharge += 500.01m;
                    break;
                case BakeType.Cake:
                    initialCharge += 2000m;
                    break;
                case BakeType.Pastery:
                    initialCharge += 200.10m;
                    break;
                case BakeType.Pies:
                    initialCharge += 851.5m;
                    break;
            }
            return initialCharge;
        }
    }
}